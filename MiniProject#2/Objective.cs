using System.Collections.Generic;

namespace MiniProject_2 {
    internal class Objective {

        public List<string> Persons { get; private set; }
        public string Text { get ; private set; }

        public Objective(string text, string person) {
            Persons = new List<string>();
            this.Persons.Add(person);
            this.Text = text;
        }

        public Objective(string text, List<string> persons) {
            this.Persons = persons;
            this.Text = text;
        }

        public void AddPerson(string person) {
            Persons.Add(person);
        }
    }
}
