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

        //Read
        public List<Person> GetPersonList()
        {
            return _context.Person.Include("Vaccination").ToList();
        }

        public List<Person> GetNotFullVaccPerson()
        {
            var notFullVaccPersList = _context.Person.Where(x => (x.Age > 65 && x.NumVaccinations <= 2) || (x.Age < 65 && x.NumVaccinations < 2));

            return notFullVaccPersList.ToList();
        }

        public List<Person> GetFullVaccPerson()
        {

            var fullVaccPersList = _context.Person.Where(x => (x.Age >= 65 && x.NumVaccinations > 2) || (x.Age < 65 && x.NumVaccinations >= 2));

            return fullVaccPersList.ToList();
        }

        //Create
        public void EntryPerson(Person pers)
        {
            var tmpVac = new Vaccination { VaccinationId = pers.Vaccination.VaccinationId };
            pers.VaccinationId = tmpVac.VaccinationId;
            pers.Vaccination = null;

            _context.Person.Add(pers);
            _context.SaveChanges();
        }

        //Update
        public void UpdatePerson(Person pers)
        {
            if (pers == null)
                return;

            pers.VaccinationId = pers.Vaccination.VaccinationId;
            pers.Vaccination = null;

            _context.Person.AddOrUpdate(pers);
            _context.SaveChanges();
        }

        //Delete
        public void DeletePerson(Person pers)
        {
            if (pers == null)
                return;
            _context.Person.Remove(pers);
            _context.SaveChanges();
        }
    }
}
