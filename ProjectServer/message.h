#include <string>

class BaseMessage
{
public:

	string id;
};

class Connect: public BaseMessage
{
	string userId;
	string userPass;
};

class DisConnect: public BaseMessage
{
	
};

class BaseResponce: public BaseMessage
{

};

class BaseRequest: public BaseMessage
{

};

class GetAllProjectsResponce: public BaseResponce
{

};

class GetAllParticipantsResponce: public BaseResponce
{

};

class GetAllTopicsResponce: public BaseResponce
{

};

class OnProjectUpdatedResponce: public BaseResponce
{

};

class OnProjectDeletedResponce: public BaseResponce
{

};

class OnParticipantUpdatedResponce: public BaseResponce
{

};

class OnParticipantDeletedResponce: public BaseResponce
{

};

class OnTopicUpdatedResponce: public BaseResponce
{

};

class OnTopicDeletedResponce: public BaseResponce
{

};

class GetAllProjectsRequest: public BaseRequest
{

};

class GetAllParticipantsRequest: public BaseRequest
{

};

class GetAllTopicsRequest: public BaseRequest
{

};

class OnProjectUpdatedRequest: public BaseRequest
{

};

class OnProjectDeletedRequest: public BaseRequest
{

};

class OnParticipantUpdatedRequest: public BaseRequest
{

};

class OnParticipantDeletedRequest: public BaseRequest
{

};

class OnTopicUpdatedRequest: public BaseRequest
{

};

class OnTopicDeletedRequest: public BaseRequest
{

};