#include <mysql++.h>
#include <ssqls.h>
//#include <libxml++/libxml++.h>
#include <stdio.h>
#include <string>
#include <map>
#include "message.h"

using namespace mysqlpp;
using namecpace std;

class DataAccessLayer
{
	char* DBName;
	char* DBServer;
	char* DBUser;
	char* DBPass;
	char* QueryString;

	Connection DBConnection;
	Query query;
	StoreQueryResult queryResult;
	map<string, BaseMessage* (DataAccessLayer::*)(BaseMessage*)> HandleMap;

	BaseMessage* GetAllProjects(BaseMessage* msg)
	{
		GetAllProjectsRequest request = (GetAllProjectsRequest)msg;

		if (DBConnection.connected())
		{
			query = DBConnection.query("SELECT key, ");
			if (queryResult = query.store())
		}
	};

	BaseMessage* GetAllParticipants(BaseMessage* msg)
	{

	};

	BaseMessage* GetAllTopics(BaseMessage* msg)
	{

	};

	BaseMessage* OnProjectUpdated(BaseMessage* msg)
	{

	};

	BaseMessage* OnProjectDeleted(BaseMessage* msg)
	{

	};

	BaseMessage* OnParticipantUpdated(BaseMessage* msg)
	{

	};

	BaseMessage* OnParticipantDeleted(BaseMessage* msg)
	{

	};

	BaseMessage* OnTopicUpdated(BaseMessage* msg)
	{

	};

	BaseMessage* OnTopicDeleted(BaseMessage* msg)
	{

	};

public:

	DataAccessLayer()
	{
		DBName = "ProjectServerData";
		DBServer = "localhost";
		DBUser = "root";
		DBPass = "root";
		if (DBConnection.connect(NULL, DBServer, DBUser, DBPass))
		{
			query = DBConnection.query("SHOW DATABASES LIKE ProjectServerData");
			if (queryResult = query.store())
				query = DBConnection.exec("USE ProjectServerData");
			else
				query = DBConnection.exec("CREATE DATABASE ProjectServerData");
			if (!query) throw "Exception!!!!!";
		};
		HandleMap["GetAllProjects"] = GetAllProjects;
		HandleMap["GetAllParticipants"] = GetAllParticipants;
		HandleMap["GetAllTopics"] = GetAllTopics;
		HandleMap["OnProjectUpdated"] = OnProjectUpdated;
		HandleMap["OnProjectDeleted"] = OnProjectDeleted;
		HandleMap["OnParticipantUpdated"] = OnParticipantUpdated;
		HandleMap["OnParticipantDeleted"] = OnParticipantDeleted;
		HandleMap["OnTopicUpdated"] = OnTopicUpdated;
		HandleMap["OnTopicDeleted"] = OnTopicDeleted;
	};

	BaseMessage* ProcessMessage(BaseMessage* msg)
	{
		return (*HandleMap[msg->id])(msg);
	};
};

// CREATE TABLE IF NOT EXISTS table_name