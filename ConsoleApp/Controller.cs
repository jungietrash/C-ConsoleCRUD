using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Controller : Persons
    {
        public List<Persons> People = new List<Persons>();
        public void CreatePerson()
        {
            People.Add(new Persons { PersonId = "1", PersonName = "t", PersonDescription = "z" });
            People.Add(new Persons { PersonId = "2", PersonName = "a", PersonDescription = "x" });
            People.Add(new Persons { PersonId = "3", PersonName = "d", PersonDescription = "c" });
        }

        public List<Persons> GetAllPeople()
        {
            return People;
        }

        public void setPersonID(string id, string replaceID)
        {
            Persons personWithId = People.FirstOrDefault(person => person.PersonId == id);

            if (personWithId != null)
            {
                personWithId.PersonId = replaceID;
            }
        }

        public void CreatePerson(Persons pr)
        {
            People.Add(pr);
        }

        public void DeletePerson(string ID)
        {
            Persons personToDelete = People.FirstOrDefault(person => person.PersonId == ID);

            if (personToDelete != null)
            {
                People.Remove(personToDelete);
            }
        }
    }
}
