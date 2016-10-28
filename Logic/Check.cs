using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFKCK.Model1;
using WPFKCK.View.Calendar;

namespace WPFKCK.Logic
{
    static class Check
    {
        public static readonly Model db = new Model();

        public static bool CheckPassword(User user, string password, string repassword)
        {
            if (password == repassword)
            {
                var result = db.users.FirstOrDefault(x => x.idusers == user.idusers);
                result.password = password;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CheckBikeDivider(User user, string s_divider)
        {
            float divider;
            if (float.TryParse(s_divider, out divider))
            {
                var result = db.users.FirstOrDefault(x => x.idusers == user.idusers);
                result.bikedivider = divider;
                user.bikedivider = divider;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CheckSwimDivider(User user, string s_divider)
        {
            float divider;
            if (float.TryParse(s_divider, out divider))
            {
                var result = db.users.FirstOrDefault(x => x.idusers == user.idusers);
                result.swimdivider = divider;
                user.swimdivider = divider;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool CheckGoal(User user, string s_goal)
        {
            float goal;
            if (float.TryParse(s_goal, out goal))
            {
                var result = db.users.FirstOrDefault(x => x.idusers == user.idusers);
                result.goal = goal;
                user.goal = goal;
                db.SaveChanges();
                return true;
            }
            return false;
        }


    }
}
