﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

using OpTeamEngine.Interfaces;
using OpTeamEngine.HandlersPrototypes;
using OpTeamEngine.Messages;
using OpTeamEngine.MainClasses;

namespace OpTeamEngine.src
{
    class EngineFacade: IEngine
    {
        public static EngineFacade Instance
        {
            get
            {
                return instance;
            }
        }

        public MessageToXmlConverter XMLConverter
        {
            get
            {
                return xmlConverter;
            }
        }

        public ProjectClient ProjectClient
        {
            get
            {
                return client;
            }
            set
            {
                this.client = value;
                this.client.ResponseReceived += ProcessProjectServerResponse;
            }
        }

        public void ProcessProjectServerResponse(MemoryStream message)
        {
            Console.WriteLine("Response received");

            if (message == null)
            {
                Console.WriteLine("Something wrong with server response");
            }
            else
            {
                Console.WriteLine(Encoding.UTF8.GetString(message.ToArray()));
            }
        }

        #region Methods API for UI
        public void RegisterUser(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void AuthorizeUser(string name, string password)
        {
            Console.WriteLine("Engine: RegisterUser");
            new Thread(() =>
            {
                AuthorizeUserRequest request = new AuthorizeUserRequest();
                request.UserName = name;
                request.Password = password;

                MemoryStream xmlMessage = XMLConverter.Serialize(request);

                ProjectClient.SendMessage(xmlMessage);
            }).Start();
        }

        public void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public void UpdateTopic(Topic topic)
        {
            throw new NotImplementedException();
        }

        public void GetAllTopics()
        {
            throw new NotImplementedException();
        }

        public void GetAllParticipants()
        {
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Events for UI
        public event UserRegisteredHandler UserRegistered;

        public event UserAuthorizedHandler UserAuthorized;

        public event UpdateProjectHandler ProjectUpdated;

        public event DeleteProjectHandler ProjectDeleted;

        public event GetAllProjectsHandler ProjectsListReceived;

        public event UpdateTopicHandler TopicUpdated;

        public event GetAllTopicsHandler TopicsListReceived;

        public event GetAllParticipantsHandler ParticipantsListReceived;

        
        public event EventHandler MessageSent;

        public event EventHandler MailSent;
        #endregion 

        EngineFacade() {}

        static readonly EngineFacade instance = new EngineFacade();
        MessageToXmlConverter xmlConverter = new MessageToXmlConverter();
        ProjectClient client;
    }
}
