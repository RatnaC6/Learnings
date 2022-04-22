using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess2.Models
{
    public class OfficeRepository
    {
        List<Office> offices = new List<Office>();

        public OfficeRepository()
        {
            offices.AddRange(new Office[]
            {
                new Office{Id=1,City="Mumbai", Phone="3679034"},
                new Office{Id=2,City="Delhi",Phone="4739045"},
                new Office{Id=3,City="London",Phone="4903493"}
            });
        }

        public IEnumerable<Office> GetAllOffices()
        {
            return this.offices;
        }

        public List<Office> GetOfficeByCity(string city)
        {
            //return this.offices.Where(office => office.City.Equals(city)).FirstOrDefault();
            return this.offices.Where(office => office.City.Equals(city)).ToList();
        }
    }
}
