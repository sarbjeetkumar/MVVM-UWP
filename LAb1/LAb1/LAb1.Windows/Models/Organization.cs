using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Organization
    {


        public List<Person> People { get; set; }
        public String Name { get; set; }

        public Organization(String databaseName)
        {
            Name = databaseName;
            People = FakeService.GetPeople();
        }



        public void Add(Person person)      //add the person 
        {
            if (!People.Contains(person))
            {
                People.Add(person);
                FakeService.Write(person);
            }
        }


        public void Delete(Person person)       //delete the person
        {
            if (People.Contains(person))
            {
                People.Remove(person);
                FakeService.Delete(person);
            }
        }



        public void Update(Person person)       //update the person 
        {
            FakeService.Write(person);
        }






    }
}
