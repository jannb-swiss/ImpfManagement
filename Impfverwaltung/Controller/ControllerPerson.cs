using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impfverwaltung.Model;
using Impfverwaltung.Database;



namespace Impfverwaltung.Controller
{
    class ControllerPerson
    {
        //Entity Framework
        private RepoPerson _modelPerson;
        private RepoVaccination _modelVaccination;

        public ControllerPerson()
        {

            //Entity Framework
            _modelPerson = new RepoPerson();
            _modelVaccination = new RepoVaccination();
        }

        #region Person
        public List<Person> GetPersonList()
        {
            return _modelPerson.GetPersonList();
        }

        public List<Person> GetNotFullVaccPerson()
        {
            return _modelPerson.GetNotFullVaccPerson();
        }

        public List<Person> GetFullVaccPerson()
        {
            return _modelPerson.GetFullVaccPerson();
        }

        public void EntryPerson(Person pers)
        {
            _modelPerson.EntryPerson(pers);
        }

        public void UpdatePerson(Person pers)
        {
            _modelPerson.UpdatePerson(pers);
        }

        public void DeletePerson(Person pers)
        {
            _modelPerson.DeletePerson(pers);
        }
        #endregion

        #region Vaccination
        public List<Vaccination> GetVaccinationList()
        {
            return _modelVaccination.GetVaccinationList();
        }
        #endregion
    }
}
