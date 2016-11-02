using System;

namespace _03_AddingDepth {
    public class Person : IParty {
        public string Name { get; set; }
        public int Gold { get; set; }
        public void Stats() {
            Console.WriteLine($"{Name} has {Gold} gold coins.");
        }
    }
}
