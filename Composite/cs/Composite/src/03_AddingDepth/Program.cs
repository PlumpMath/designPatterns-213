using System;
using System.Collections.Generic;

namespace _03_AddingDepth {
    public class Program {
        public static void Main(string[] args) {
            int goldForKill = 1023;
            Console.WriteLine($"You have killed the Giant IE6 Monster and gained {goldForKill} gold!");

            var joe = new Person { Name = "Joe" };
            var jake = new Person { Name = "Jake" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var brian = new Person { Name = "Brian" };
            var oldBob = new Person {Name = "Old Bob"};
            var newBob = new Person {Name = "New Bob"};

            var bobs = new Group {Name = "Bobs", Members = {oldBob, newBob}};
            var developers = new Group { Name = "Developers", Members = { joe, jake, emily, bobs } };
            var parties = new List<IParty> { developers, sophia, brian };

            var totalSplitBy = parties.Count;

            var amountForEach = goldForKill / totalSplitBy;
            var leftOver = goldForKill % totalSplitBy;

            foreach (var partyMember in parties) {
                partyMember.Gold += amountForEach + leftOver;
                leftOver = 0;
                partyMember.Stats();
            }

            Console.ReadKey();
        }
    }
}
