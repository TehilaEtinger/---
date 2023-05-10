using Server.Repository.Entities;


namespace Services.Models
{
    public class PatientModel
    {

        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IDNumber { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public DateTime DOB { get; set; }
        public string TelNumber { get; set; }
        public string PhoneNumber { get; set; }
        public List<CoronaVaccine> CoronaVaccines { get; set; } 
        //public DateTime ReceivingCoronaVaccineDate1 { get; set; }

        //public DateTime ReceivingCoronaVaccineDate2 { get; set; }

        //public DateTime ReceivingCoronaVaccineDate3 { get; set; }

        //public DateTime ReceivingCoronaVaccineDate4 { get; set; }
        //public string VaccineManufacturerVaccine1 { get; set; }
        //public string VaccineManufacturerVaccine2 { get; set; }
        //public string VaccineManufacturerVaccine3 { get; set; }
        //public string VaccineManufacturerVaccine4 { get; set; }

        public DateTime ReceivingPositiveResultDate { get; set; }

        public DateTime RecoveryDate { get; set; }
    }
}
