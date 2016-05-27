using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpTeamEngine.HandlersPrototypes;
using OpTeamEngine.MainClasses;

namespace OpTeamEngine.Interfaces
{
    public interface IEngine
    {
        void RegisterUser(string name, string password);
        void AuthorizeUser(string name, string password);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
        void GetAllProjects();
        void UpdateTopic(Topic topic);
        void GetAllTopics();
        void GetAllParticipants();
        void SendMail();

        event UserRegisteredHandler UserRegistered;
        event UserAuthorizedHandler UserAuthorized;
        event UpdateProjectHandler ProjectUpdated;
        event DeleteProjectHandler ProjectDeleted;
        event GetAllProjectsHandler ProjectsListReceived;
        event UpdateTopicHandler TopicUpdated;
        event GetAllTopicsHandler TopicsListReceived;
        event GetAllParticipantsHandler ParticipantsListReceived;

        event EventHandler MessageSent;
        event EventHandler MailSent; 
    }
}
