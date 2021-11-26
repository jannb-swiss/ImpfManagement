using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impfverwaltung.Database;

namespace Impfverwaltung.Model
{
    class RepoVaccination
    {
        private ImpfManagementEntities1 _context;

        public RepoVaccination()
        {
            _context = new ImpfManagementEntities1();
        }

        //Read
        public List<Vaccination> GetVaccinationList()
        {
            return _context.Vaccination.Include("Person").ToList();
        }
    }
}
