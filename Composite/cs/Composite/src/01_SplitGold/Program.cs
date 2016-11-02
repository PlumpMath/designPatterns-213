using System;
using System.Collections.Generic;

namespace _01_SplitGold {
    public class Program {
        public static void Main(string[] args) {
            int goldForKill = 1023;
            Console.WriteLine($"You have killed the Giant IE6 Monster and gained {goldForKill} gold!");

            var joe = new Person {Name = "Joe"};
            var jake = new Person {Name = "Jake"};
            var emily = new Person {Name = "Emily"};
            var sophia = new Person {Name = "Sophia"};
            var brian = new Person { Name = "Brian" };
            var developers = new Group { Name = "Developers", Members = {joe, jake, emily} };

            var individuals = new List<Person> {sophia, brian};
            var groups = new List<Group> {developers};

            var totalSplitBy = individuals.Count + groups.Count;

            var amountForEach = goldForKill/totalSplitBy;
            var leftOver = goldForKill%totalSplitBy;

            foreach (var person in individuals) {
                person.Gold += amountForEach + leftOver;
                leftOver = 0;
                person.Stats();
            }

            foreach (var @group in groups) {
                var amountForEachGroupMember = amountForEach/group.Members.Count;
                var leftOverGroup = amountForEach%group.Members.Count;
                foreach (var member in group.Members) {
                    member.Gold += amountForEachGroupMember + leftOverGroup;
                    leftOverGroup = 0;
                    member.Stats();
                }
            }

            Console.ReadKey();
        }
    }
}
