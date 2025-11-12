using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevVise1
{
    internal class Logger
    {
        private RevDB db;
        private String source;
        private String user;
        private int userID;
        public Logger(String source = "System", String username = "")
        {
            this.source = source;
            this.user = username;
            this.userID = Session.UserID;
            db = new RevDB();
        }
        public void log(String action)
        {
            if (source.Equals("System")) // to be used for system generated logs
            {
                string sql = "INSERT INTO tbl_logs (log_date, log_source, log_action, user, user_id) " +
             "VALUES (NOW(), @source, @action, 'System', '0')";

                var parameters = new Dictionary<string, object>()
            {
                { "@source", source },
                { "@action", action },
                { "@user", user },
                { "@userID", userID }
            };

                db.SQLManager(sql, parameters);
            }
            else
            {
                string sql = "INSERT INTO tbl_logs (log_date, log_source, log_action, user, user_id) " +
                 "VALUES (NOW(), @source, @action, @user, @userID)";

                var parameters = new Dictionary<string, object>()
            {
                { "@source", source },
                { "@action", action },
                { "@user", user },
                { "@userID", userID }
            };

                db.SQLManager(sql, parameters);
            }
        }
    }
}
