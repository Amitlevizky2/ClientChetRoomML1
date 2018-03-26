using System;
using System.Collections.Generic; 
using PersistenceLayer;
namespace LogicLayer
{
    public class Chatroom
    {
        public User loginUser = null;
        private List<User> Users = new List<User>();
        private List<Message> Messages = new List<Message>();
        public static String url = "http://ise172.ise.bgu.ac.il";

        public Chatroom()
        {
        }

        public void login(String nickname, int groupID)
        {
            if (loginUser != null)
                Console.WriteLine("There is already user the connecting to the server");
        }

        public void checkValidity(String nickname, int GroupID)
        {
            Console.WriteLine("sqdqdq"); 
        }

        public void registration (String nickname, int GroupID)
        {
            User newUser = new User(nickname, GroupID);
            Users.Add(newUser);
        }


    }
}
