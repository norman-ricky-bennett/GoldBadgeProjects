using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepo
{
    public class ClaimsEntry_Repo
    {
            public readonly Queue<ClaimEntry> _directory = new Queue<ClaimEntry>();

            public int Count
            {
                get
                {
                    return _directory.Count;
                }
            }

            public bool AddItemToDirectory(ClaimEntry entry)
            {
                int startingCount = _directory.Count;
                _directory.Enqueue(entry);
                bool wasAdded = _directory.Count > startingCount;
                return wasAdded;
            }

            public Queue<ClaimEntry> GetContents()
            {
                return _directory;
            }

            public ClaimEntry GetClaimByNum(int id)
            {
                foreach (ClaimEntry entry in _directory)
                {
                    if (entry.ClaimID == id)
                        return entry;
                }
                return null;
            }

            public void DeleteContent()
            {
                _directory.Dequeue();
            }
        }
}
