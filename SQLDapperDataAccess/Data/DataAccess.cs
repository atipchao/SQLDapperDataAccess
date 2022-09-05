using SQLDapperDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SQLDapperDataAccess.Data
{
    public class DataAccess
    {
        public List<Customer> GetCusts(string LastName)
        {

            // Just copy the section out in your notepad  - as we are going to repeat this a lot when connect to DB
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("FCCDB")))
            {

                var output =  connection.Query<Customer>($"Select * from Customers where last_name = '{LastName}'").ToList();
                return output;
            } // this is line, we drop the database connection

        }
    }
}
