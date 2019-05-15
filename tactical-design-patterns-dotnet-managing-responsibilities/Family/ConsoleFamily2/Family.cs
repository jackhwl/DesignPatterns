using System;
using System.Collections.Generic;
using Family.Common;

namespace ConsoleFamily2
{
    class Family
    {
        private readonly IEnumerable<FamilyMember> members;
        public Family(IEnumerable<FamilyMember> members)
        {
            this.members = new List<FamilyMember>(members);
        }

        public void WinterBegins()
        {
            Console.WriteLine("Winter just came...");
            foreach(FamilyMember member in members)
            {
                //IHairy hairy = member.As<IHairy>();
                //if (hairy != null) hairy.GrowHair();

                //IBearded bearded = member.As<IBearded>();
                //if (bearded != null) bearded.GrownBeard();
                member.As<IHairy>(NullHairy.Instance).GrowHair();
                member.As<IBearded>(NullBearded.Instance).GrownBeard();
            }
            Console.WriteLine(new string('-', 20));
        }

        public void SummerComes()
        {
            Console.WriteLine("Summer is here...");
            foreach(FamilyMember member in members)
            {
                //IEmotional emotional = member.As<IEmotional>();
                //if (emotional != null) emotional.BeHappy();
                member.As<IEmotional>(NullEmotional.Instance).BeHappy();
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
