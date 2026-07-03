using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class dataAccessSettings
    {
        static public string connectionString = ConfigurationManager.AppSettings["DATA_BASE"].ToString();

    }
}
