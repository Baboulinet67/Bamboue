using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IUT.Bamboue.Outils;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace IUT.Bamboue.Data
{
    public class DataBamboue
    {
        ConnectionStringSettings connec = new ConnectionStringSettings("Bamboue", ConfigurationManager.ConnectionStrings["BamboueConnectionString"].ConnectionString, "System.Data.OleDb");
    }
}
