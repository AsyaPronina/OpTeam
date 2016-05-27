using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using OpTeamEngine.MainClasses;

namespace OpTeamEngine.HandlersPrototypes
{
    public delegate void UpdateProjectHandler(Project project);
    public delegate void DeleteProjectHandler(int projectID);
    public delegate void GetAllProjectsHandler(List<Project> projects);
    public delegate void UpdateTopicHandler(Topic topic);
    public delegate void GetAllTopicsHandler(List<Topic> topics);
    public delegate void GetAllParticipantsHandler(List<Participant> paticipants);
    public delegate void UserRegisteredHandler();
    public delegate void UserAuthorizedHandler();
    //Mail
    //IM
}
