using System;

namespace _02_Refactoring1 {
    public class Person : IParty {
        public string Name { get; set; }
        public int Gold { get; set; }
        public void Stats() {
            Console.WriteLine($"{Name} has {Gold} gold coins.");
        }
    }
}
