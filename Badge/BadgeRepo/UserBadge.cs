using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepo
{
    public class UserBadge
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }

        public UserBadge()
        {

        }

        public UserBadge(int badgeID, List<string> doorAccess)
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
        }
    }
}
