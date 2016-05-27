using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;

namespace OpTeamEngine.Messages
{
    [Serializable]
    public class BaseMessage
    {
        public string ID { get; set; }

        [NonSerialized]
        public static int counter = 0;
        
        [NonSerialized]
        protected static object locker = new object();
    }

    [Serializable]
    public class Request : BaseMessage
    {
        public int requestID { get; set; }

        public Request()
        {
            lock (locker)
            {
                this.requestID = counter++;
            }
        }
    }

    [Serializable]
    public class Response : BaseMessage
    {
        public int responseID { get; set; }
    }

    #region requests
    [Serializable]
    public class RegisterUserRequest : Request
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public RegisterUserRequest()
        {
           base.ID = "REGISTER_USER_REQUEST";
        }
    }

    [Serializable]
    public class AuthorizeUserRequest : Request
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public AuthorizeUserRequest()
        {
            base.ID = "AUTHORIZE_USER_REQUEST";
        }
    }

    [Serializable]
    public class UpdateProjectRequest : Request
    {
        public UpdateProjectRequest()
        {
            base.ID = "UPDATE_PROJECT_REQUEST";
        }
    }

    [Serializable]
    public class DeleteProjectRequest : Request
    {
        public DeleteProjectRequest()
        {
            base.ID = "DELETE_PROJECT_REQUEST";
        }
    }

    [Serializable]
    public class GetAllProjectsRequest : Request
    {
        public GetAllProjectsRequest()
        {
            base.ID = "GET_ALL_PROJECTS_REQUEST";
        }
    }

    [Serializable]
    public class UpdateTopicRequest : Request
    {
        public UpdateTopicRequest()
        {
            base.ID = "UPDATE_TOPIC_REQUEST";
        }
    }

    [Serializable]
    public class GetAllTopicsRequest : Request
    {
        public GetAllTopicsRequest()
        {
            base.ID = "GET_ALL_TOPICS_REQUEST";
        }
    }

    [Serializable]
    public class GetAllParticipantsRequest : Request
    {
        public GetAllParticipantsRequest()
        {
            base.ID = "GET_ALL_PARTICIPANTS_REQUEST";
        }
    }
    #endregion

    #region responses
    [Serializable]
    public class RegisterUserResponse : Response
    {
        public RegisterUserResponse()
        {
            base.ID = "REGISTER_USER_RESPONSE";
        }
    }

    [Serializable]
    public class AuthorizeUserResponse : Response
    {
        public string UserName { get; set; }
        public string Status { get; set; }

        public AuthorizeUserResponse()
        {
            base.ID = "AUTHORIZE_USER_RESPONSE";
        }
    }

    [Serializable]
    public class UpdateProjectResponse : Response
    {
        public UpdateProjectResponse()
        {
            base.ID = "UPDATE_PROJECT_RESPONSE";
        }
    }

    [Serializable]
    public class DeleteProjectResponse : Response
    {
        public DeleteProjectResponse()
        {
            base.ID = "DELETE_PROJECT_RESPONSE";
        }
    }

    [Serializable]
    public class GetAllProjectsResponse : Response
    {
        public GetAllProjectsResponse()
        {
            base.ID = "GET_ALL_PROJECTS_RESPONSE";
        }
    }

    [Serializable]
    public class UpdateTopicResponse : Response
    {
        public UpdateTopicResponse()
        {
            base.ID = "UPDATE_TOPIC_RESPONSE";
        }
    }

    [Serializable]
    public class GetAllTopicsResponse : Response
    {
        public GetAllTopicsResponse()
        {
            base.ID = "GET_ALL_TOPICS_RESPONSE";
        }
    }

    [Serializable]
    public class GetAllParticipantsResponse : Response
    {
        public GetAllParticipantsResponse()
        {
            base.ID = "GET_ALL_PARTICIPANTS_RESPONSE";
        }
    }
    #endregion
}
