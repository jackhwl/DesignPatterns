using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDemo
{
    public class Group : IParty
    {
        public string Name { get; set; }
        public List<IParty> Members { get; set; }

        public Group()
        {
            Members = new List<IParty>();
        }

        public int Gold
        {
            get { 
                //int totalGold = 0;
                //foreach(var member in Members)
                //{
                //    totalGold += member.Gold;
                //}

                //return totalGold;
				return Members.Sum(m=>m.Gold);
            }
            set
            {
                var eachSplit = value/Members.Count;
                var leftOver = value%Members.Count;
                //foreach(var member in Members)
                //{
                //    member.Gold += eachSplit + leftOver;
                //    leftOver = 0;
                //}
				Members.ForEach(m=> {
					m.Gold += eachSplit + leftOver; 
					leftOver = 0;
				});
            }
        }
		static IEnumerable<int> LeftOver(int first)
        {
            yield return first;
			yield return 0;
        }
        public void Stats()
        {
            foreach(var member in Members)
            {
                member.Stats();
            }
        }
    }
}
