using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Configuration.Assemblies;
namespace ABMS.DL
{
    public class SqlDBHelper
    {
        public  string ConnectionString()
        {
             return ConfigurationManager.AppSettings["ABMSConnectionString"].ToString(); 
        }

    }
}
