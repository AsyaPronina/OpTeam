using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

using OpTeamEngine.Messages;

namespace OpTeamEngine.Sources
{
    class MessageToXmlConverter
    {
        private Dictionary<string, XmlSerializer> messageIDToXMLSerializer = new Dictionary<string, XmlSerializer>();

        public void RegisterSerizalizer(string ID, XmlSerializer serializer)
        {
            messageIDToXMLSerializer.Add(ID, serializer);
        }

        public XmlSerializer UnregisterSerializer(string ID)
        {
            XmlSerializer serializer = null;
            try
            {
                serializer = messageIDToXMLSerializer[ID];
                messageIDToXMLSerializer.Remove(ID);
            }
            catch (Exception)
            {
                Console.WriteLine("No serializer found for this ID");
            }

            return serializer;
        }

        public MemoryStream Serialize(BaseMessage message)
        {
            MemoryStream xmlData = null;
            XmlSerializer serializer = null;
            try
            {
                serializer = messageIDToXMLSerializer[message.ID];
               
                using (xmlData = new MemoryStream())
                {
                    serializer.Serialize(xmlData, message);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unsupported message to serialization, ID = {0}", message.ID);
            }

            return xmlData;
        }

        public BaseMessage Deserialize(MemoryStream message)
        {
            BaseMessage result = null;

            string buffer = Encoding.UTF8.GetString(message.ToArray());
            string ID  = String.Empty;

            try
            {
                ID = buffer.Split(new string[] { "<ID>", "</ID>" }, StringSplitOptions.RemoveEmptyEntries)[1];
            }
            catch
            {
                Console.WriteLine("Wrong message from server. No ID provided");
                return null;
            }

            XmlSerializer serializer = null;

            try
            {
                serializer = messageIDToXMLSerializer[ID];
                message.Position = 0;
                result = (BaseMessage)serializer.Deserialize(message);
            }
            catch (Exception)
            {
                Console.WriteLine("Unsupported message from server, ID = {0}", ID);
            }

            return result;
        }
    }
}
