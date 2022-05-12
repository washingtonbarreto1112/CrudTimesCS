using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTimesCS.controller
{
    class ConexaoBD
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\washington.bpjunior\source\repos\CrudTimesCS\CrudTimesCS\BDTimesCS.mdf;Integrated Security=True";
        }
    }
}
