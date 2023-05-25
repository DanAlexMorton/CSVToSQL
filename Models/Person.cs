using Microsoft.AspNetCore.Identity;

namespace csvtosql.Models;

    public class Person
    {
        public int ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string job_title {get; set; }
        public string email_address { get; set; }
        public string department { get; set; }
        public string contract_Type { get; set; }
        public string company_name { get; set; }
        public string business_phone { get; set; }
        public string street { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }    
        public string postcode { get; set; }   
        public string country { get; set; }
    }