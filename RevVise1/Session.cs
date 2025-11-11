using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevVise1
{
    internal class Session
    {
        public static int UserID { get; private set; }
        public static string Username { get; private set; }
        public static string Role { get; private set; }

        public static void startSession(int userId, string username, string role)
        {
            UserID = userId;
            Username = username;
            Role = role;
        }
        public static void endSession()
        {
            UserID = 0;
            Username = null;
            Role = null;
        }
    }
}
