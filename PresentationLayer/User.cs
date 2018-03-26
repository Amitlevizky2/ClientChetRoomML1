using System;
using Newtonsoft;
using MileStoneClient.CommunicationLayer;
namespace LogicLayer
{
    public class User
    {
        //Unique identification details for every user
        private String nickname;
        private String groupID;
        public bool status = true;

        public User(String nickname, String groupID) //User's class constructor
        {
            this.nickname = nickname;
            this.groupID = groupID;

        }
        public void send(String msg)
        {
            IMessage message = MileStoneClient.CommunicationLayer.Communication.Instance.Send(Chatroom.url, this.groupID, this.nickname, msg);
            Message m = new Message(message);     
        }

        public void logout()
        {
            status = false;
            Console.WriteLine(this.nickname + " You are now Offline");
        }
    }
}
