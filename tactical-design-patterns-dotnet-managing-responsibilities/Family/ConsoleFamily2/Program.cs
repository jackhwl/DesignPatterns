using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily2
{
    class Program
    {
        static void Main(string[] args)
        {
            //FamilyMember dad = new FamilyMember(new object[]{
            //    new Bearded("Dad"), new Emotional("Dad", "hoho") });
            //FamilyMember mom = new FamilyMember(new object[]{
            //    new Hairy("Mom"), new Emotional("Mom", "hihi") });
            //FamilyMember boy = new FamilyMember(new object[]{
            //    new Emotional("Boy", "haha") });
            //FamilyMember dog = new FamilyMember(new object[]{
            //    new Emotional("Dog", "tail waving") });
            //FamilyMember uncle = new FamilyMember(new object[]{
            //    new Bearded("Uncle"), new Hairy("Uncle") });
            FamilyMember dad = new FamilyMember(new Bearded("Dad", new Emotional("Dad", "hoho", null)));
            FamilyMember mom = new FamilyMember(new Hairy("Mom", new Emotional("Mom", "hihi", null)));
            FamilyMember boy = new FamilyMember(new Bearded("Boy", new Emotional("Boy", "haha", null)));
            FamilyMember dog = new FamilyMember(new Emotional("Dog", "tail waving", null));
            FamilyMember uncle = new FamilyMember(new Bearded("Uncle", new Hairy("Uncle", null)));
            FamilyMember granddad = new FamilyMember(new Bearded("Granddad", new Hairy("Granddad", new Emotional("Granddad", "oyoyo", null))));

            Family family = new Family(new FamilyMember[]{dad, mom, boy, dog, uncle, granddad});

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();
        }
    }
}
