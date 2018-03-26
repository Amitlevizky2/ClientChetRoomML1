using System;
namespace LogicLayer
{
    public class Message
{
        private String message = null;
        private User user;
        private DateTime dt;
        Boolean isSent = false;
        private int msgID = 0;

    private static object dateTimeObect;

    public Message(String msg, User user)
    {
            this.message = msg;
            this.user = user;
    }
    public static Boolean isValid(String msg)
    {
        Boolean valid = true;
        if (msg.Length >= 150)
        {
            valid = false;
        }
        return valid;
    }
    public static DateTime getTime()
    {
        DateTime dt = DateTime.Parse("6/22/2009 07:00:00 AM");
        dt.ToString(" 	dd/MM/yyyy h:mm tt");
        Console.WriteLine(dt);
            Console.ReadLine();

        return dt;
    }
        public static void SaveMsg(int msgID)
        {
            int messageID = msgID;
        }
        public static void delete(int msgID)
        {
            msgID = 0;
        }
}
   
}
