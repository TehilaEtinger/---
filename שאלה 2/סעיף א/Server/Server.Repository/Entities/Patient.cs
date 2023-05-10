using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IDNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string TelNumber { get; set; }
        public string PhoneNumber { get; set; }

        public virtual List<CoronaVaccine> CoronaVaccines { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime ReceivingCoronaVaccineDate1 { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime ReceivingCoronaVaccineDate2 { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime ReceivingCoronaVaccineDate3 { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime ReceivingCoronaVaccineDate4 { get; set; }
        //public string VaccineManufacturerVaccine1 { get; set; }
        //public string VaccineManufacturerVaccine2 { get; set; }
        //public string VaccineManufacturerVaccine3 { get; set; }
        //public string VaccineManufacturerVaccine4 { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReceivingPositiveResultDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime RecoveryDate { get; set; }
    }
}
