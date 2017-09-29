using System;

namespace LocalBloodBank.DomainModels
{
    public class BloodDoner
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string bloodGroup { get; set; }
        public string permanentAddress { get; set; }
        public string presentAddress { get; set; }
        public string phoneNumber { get; set; }
        public string occupation { get; set; }
        public string region { get; set; }

        public DateTime lastDonationDate { get; set; }
    }
}