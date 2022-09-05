using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDapperDataAccess.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }
        public string web { get; set; }


        public string FullInfo
        {
            get
            {
                // Return full info - read only property
                return $"{ last_name } { first_name } { city } { state } ({ email }) ";
            }            
        }


    }
}
