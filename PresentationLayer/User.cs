using System;
namespace LogicLayer;
{
    public class User
    {
        //Unique identification details for every user
        private String nickname;
        private int groupID;
        public bool status = true;

        public User(String nickname, int groupID) //User's class constructor
        {
            this.nickname = nickname;
            this.groupID = groupID;
        }

        public void logout()
        {
            status = false;
            Console.WriteLine(this.nickname + " You are now Offline");
        }
    }
}
