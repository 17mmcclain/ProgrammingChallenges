using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTest
{

    //Determine who's a friend or foe, those with names only 4 characters are friends.
    public class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            var list = new List<string>();

            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    list.Add(name);
                }
            }
            return list.ToArray();
        }
    }
}
