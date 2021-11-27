using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impfverwaltung.Database;

namespace Impfverwaltung.Model
{
    class RepoPerson
    {
        private ImpfManagementEntities1 _context;

        public RepoPerson()
        {
            _context = new ImpfManagementEntities1();
        }

        //Liste mit allen Personen
        public List<Person> GetPersonList()
        {
            return _context.Person.Include("Vaccination").ToList();
        }

        //Liste der nicht geimpften Personen
        public List<Person> GetNotFullVaccPerson()
        {
            var notFullVaccPersList = _context.Person.Where(x => (x.Age > 65 && x.NumVaccinations <= 2) || (x.Age < 65 && x.NumVaccinations < 2));

            return notFullVaccPersList.ToList();
        }

        //Liste der geimpften Personen
        public List<Person> GetFullVaccPerson()
        {

            var fullVaccPersList = _context.Person.Where(x => (x.Age >= 65 && x.NumVaccinations > 2) || (x.Age < 65 && x.NumVaccinations >= 2));

            return fullVaccPersList.ToList();
        }

        //Erstellen
        public void EntryPerson(Person person)
        {
            var tmpVaccination = new Vaccination { VaccinationId = person.Vaccination.VaccinationId };
            person.VaccinationId = tmpVaccination.VaccinationId;
            person.Vaccination = null;

            _context.Person.Add(person);
            _context.SaveChanges();
        }

        //Updaten
        public void UpdatePerson(Person person)
        {
            if (person == null)
                return;

            person.VaccinationId = person.Vaccination.VaccinationId;
            person.Vaccination = null;

            _context.Person.AddOrUpdate(person);
            _context.SaveChanges();
        }

        //Löschen
        public void DeletePerson(Person person)
        {
            if (person == null)
                return;
            _context.Person.Remove(person);
            _context.SaveChanges();
        }
    }
}
