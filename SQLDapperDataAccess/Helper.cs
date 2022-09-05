using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDapperDataAccess
{
    public static class Helper
    {
        //this is a helper class to get connectionstring from Web config file..
        public  static string CnnValue(String name)
        {
            return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
} 
