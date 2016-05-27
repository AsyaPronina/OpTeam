using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using OpTeamEngine.Interfaces;
using OpTeamEngine.Messages;
using OpTeamEngine.src;
using OpTeamEngine.HandlersPrototypes;

namespace OpTeamEngine.Infrastructure
{
    public class Infrastructure
    {
        public static Infrastructure Instance
        {
            get
            {
                return instance;
            }
        }

        public void Start()
        {
            Console.WriteLine("Engine starting work...");
            var Engine = EngineFacade.Instance;

            var projectClient = new ProjectClient(System.Net.Dns.GetHostEntry("localhost").AddressList[0], 9090);
            Engine.ProjectClient = projectClient;

            Engine.XMLConverter.RegisterSerizalizer(new RegisterUserRequest().ID, new XmlSerializer(typeof(RegisterUserRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new AuthorizeUserRequest().ID, new XmlSerializer(typeof(AuthorizeUserRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new UpdateProjectRequest().ID, new XmlSerializer(typeof(UpdateProjectRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new DeleteProjectRequest().ID, new XmlSerializer(typeof(DeleteProjectRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new GetAllProjectsRequest().ID, new XmlSerializer(typeof(GetAllProjectsRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new UpdateTopicRequest().ID, new XmlSerializer(typeof(UpdateTopicRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new GetAllTopicsRequest().ID, new XmlSerializer(typeof(GetAllTopicsRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new GetAllParticipantsRequest().ID, new XmlSerializer(typeof(GetAllParticipantsRequest), new Type[] { typeof(Request), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new RegisterUserResponse().ID, new XmlSerializer(typeof(RegisterUserResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new AuthorizeUserResponse().ID, new XmlSerializer(typeof(AuthorizeUserResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new UpdateProjectResponse().ID, new XmlSerializer(typeof(UpdateProjectResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new DeleteProjectResponse().ID, new XmlSerializer(typeof(DeleteProjectResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new GetAllProjectsResponse().ID, new XmlSerializer(typeof(GetAllProjectsResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new UpdateTopicResponse().ID, new XmlSerializer(typeof(UpdateTopicResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new GetAllTopicsResponse().ID, new XmlSerializer(typeof(GetAllTopicsResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            Engine.XMLConverter.RegisterSerizalizer(new GetAllParticipantsResponse().ID, new XmlSerializer(typeof(GetAllParticipantsResponse), new Type[] { typeof(Response), typeof(BaseMessage) }));
            BaseMessage.counter = 0;
        }

        public IEngine GetEngine()
        {
            return EngineFacade.Instance;
        }

        private Infrastructure() { }

        private static readonly Infrastructure instance = new Infrastructure();
    }
}
