class ProjectServer
{
    int port;
public:
    ProjectServer(int port);
    void Listen();

private:
    int StartPerformTransactionCycle(int);
};
