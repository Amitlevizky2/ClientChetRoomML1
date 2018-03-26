using System;
using MileStoneClient.CommunicationLayer;
namespace LogicLayer
{
    public class User
    {
        //Unique identification details for every user
        private String nickname;
        private String groupID;
        public bool status;
        private DateTime dateStamp;

        public User(String nickname, String groupID) //User's class constructor
        {
            this.nickname = nickname;
            this.groupID = groupID;
            this.status = true;
            this.dateStamp = DateTime.Now;
        }

        public void send(String msg)
        {
            IMessage message = Communication.Instance.Send(Chatroom.url
                                                           , this.groupID, this.nickname, msg);
            Message m = new Message(message);   
        }

        public void logout()
        {
            status = false;
            Console.WriteLine(this.nickname + " You are now Offline");
            this.dateStamp = DateTime.Now;
        }

        public bool isOnline()
        {
            if (this.status)
                return true;
            else
                return false;
        }


    }
}
