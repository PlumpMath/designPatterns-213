using System.Collections.Generic;

namespace _01_SplitGold {
    public class Group {
        public string Name { get; set; }
        public List<Person> Members { get; set; } = new List<Person>();
    }
}