using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.Entities
{
    public class CoronaVaccine
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReceivingDate { get; set; }
        public string VaccineManufacturer { get; set; }
    }
}
