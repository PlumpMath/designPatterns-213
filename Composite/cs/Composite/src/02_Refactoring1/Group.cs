using System.Collections.Generic;
using System.Linq;

namespace _02_Refactoring1 {
    public class Group : IParty {
        public string Name { get; set; }
        public List<IParty> Members { get; set; } = new List<IParty>();

        public int Gold {
            get {
                return Members.Sum(member => member.Gold);
            }
            set {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members) {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats() {
            foreach (var member in Members) {
                member.Stats();
            }
        }
    }
}
