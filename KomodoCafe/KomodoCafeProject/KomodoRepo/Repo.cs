using KomodoCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoRepo
{
    public class MenuItem_Repo
    {
        public readonly List<MenuItem> _directory = new List<MenuItem>();

        public int Count
        {
            get
            {
                return _directory.Count;
            }
        }

        public bool AddItemToDirectory(MenuItem item)
        {
            int startingCount = _directory.Count;
            _directory.Add(item);
            bool wasAdded = _directory.Count > startingCount;
            return wasAdded;
        }

        public List<MenuItem> GetContents()
        {
            return _directory;
        }

        public MenuItem GetMealByNum(int id)
        {
            foreach (MenuItem item in _directory)
            {
                if(item.MealNumber == id)
                    return item;
            }
            return null;
        } 
    }
}
