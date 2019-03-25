#include <QCoreApplication>

#include "../headers/ProjectServer.h"

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    ProjectServer server(9999);
    server.Listen();

    return a.exec();
}
