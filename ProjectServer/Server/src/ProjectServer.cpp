#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h> 
#include <sys/socket.h>
#include <netinet/in.h>
#include <pthread.h>
#include <iostream>

#include "../headers/ProjectServer.h"
#include "../headers/somerequests.pb.h"

using namespace std;
using namespace ProjectServerRequests;

void* HandleRequest(void *args)
{
    int newsockfd = ((int *)args)[0];

    char buffer[256];
    bzero(buffer, 256);

    int n = read(newsockfd, buffer, 255);

    GOOGLE_PROTOBUF_VERIFY_VERSION;

    SignUserRequest request;
    try
    {
        request.ParseFromArray(buffer, n);
    }
    catch (...)
    {
        printf("Here is the message: %s\n",buffer);
        return 0;
    }

    cout << "REQUEST_ID: " << (int)request.id() << endl \
            << "User name: " << request.username() << endl \
            << "Password: " << request.userpassword() << endl;

    printf("Here is the message: %s\n",buffer);

    n = write(newsockfd,"I got your message",18);

    close(newsockfd);
}

ProjectServer::ProjectServer(int port)
{
    this->port = port;
}

void ProjectServer::Listen()
{
    struct sockaddr_in serv_addr;

    int sockfd = socket(AF_INET, SOCK_STREAM, 0);
    if (sockfd < 0)
    {
        cout << "ERROR opening socket";
        throw;
    }

    bzero((char *) &serv_addr, sizeof(serv_addr));

    serv_addr.sin_family = AF_INET;
    serv_addr.sin_addr.s_addr = INADDR_ANY;
    serv_addr.sin_port = htons(port);

    if (bind(sockfd, (struct sockaddr *) &serv_addr,
             sizeof(serv_addr)) < 0)
    {
        cout << "ERROR on binding";
        throw;
    }

    listen(sockfd, 500);

    StartPerformTransactionCycle(sockfd);
}

int ProjectServer::StartPerformTransactionCycle(int sockfd)
{
    while (true)
    {
        int newsockfd;
        socklen_t clilen;
        struct sockaddr_in cli_addr;

        clilen = sizeof(cli_addr);
        newsockfd = accept(sockfd, (struct sockaddr *) &cli_addr, &clilen);
        if (newsockfd < 0)
        {
            cout << "ERROR on accept";
            return 1;
        }

        pthread_t handler_thread;
        pthread_create(&handler_thread, 0, HandleRequest, &newsockfd);
    }
    return 0;
}
