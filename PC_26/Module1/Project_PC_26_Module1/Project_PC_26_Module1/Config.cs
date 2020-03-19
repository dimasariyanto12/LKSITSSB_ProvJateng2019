using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PC_26_Module1
{
    class Config
    {

        public string Myconnection()
        {
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_PC_26_Module1;Integrated Security=True";
            return con;
        }
    }
}
