using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Proiect
{
    class SQL
    {
        public SqlConnection con;
        public void Conexiune()
        {
            string conexiune = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Adrian\Desktop\Proiect C#\Proiect\Proiect\depozit.mdf';Integrated Security=True;"; //Trusted_Connection=True;
            con = new SqlConnection(conexiune);
        }

    }
}
