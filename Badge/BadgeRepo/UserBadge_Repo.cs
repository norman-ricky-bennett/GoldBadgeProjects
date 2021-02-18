using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepo
{
    public class UserBadge_Repo

    {
        Dictionary<int, List<string>> _listOfBadges = new Dictionary<int, List<string>>();

        public Dictionary<int, List<string>> GetAllBadges()
        {
            return _listOfBadges;
        }
        
    
    }
}
