using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class angajat_addm : Form
    {
        SQL sql = new SQL();
        
        public angajat_addm()
        {
            sql.Conexiune();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDenumire.Text) || string.IsNullOrWhiteSpace(textBoxProducator.Text))
                MessageBox.Show("Nu ai completat toate campurile");
            else
            {
                if (MessageBox.Show("Sunteti sigur ca vreti sa inregistrati urmatorul medicament?:\n\nDenumire: " + textBoxDenumire.Text + "\nProducator:" + textBoxProducator.Text + "","Confirmare",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql.con.Open();
                    SqlCommand cmd = new SqlCommand("insert into medicament(denumire, producator) values('" + textBoxDenumire.Text + "','" + textBoxProducator.Text + "')", sql.con);
                    cmd.ExecuteNonQuery();
                    sql.con.Close();
                    MessageBox.Show("Medicamentul a fost adaugat!");   
                }
            }
        }
    }
}
