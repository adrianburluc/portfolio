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
    public partial class RegisterF : Form
    {
        SQL sql = new SQL();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        

        public RegisterF()
        {
            InitializeComponent();
        }

        private void RegisterF_Load(object sender, EventArgs e)
        {
            sql.Conexiune();
            completeazaDataSet();
        }

        private void buttonContinua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxid_cont.Text))
                MessageBox.Show("Introdu un ID fara spatii");
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxpw_cont.Text) || string.IsNullOrWhiteSpace(textBoxNumeFirma.Text) || string.IsNullOrWhiteSpace(textBoxAdresa.Text) || string.IsNullOrWhiteSpace(textBoxTelefon.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxOras.Text))
                    MessageBox.Show("Introdu date in toate campurile");
                else
                { 
                    //verifica daca id-ul exista
                    bool existaID=false;
                    foreach (DataRow dr in ds.Tables["Conturi"].Rows)
                    {
                        if (dr.ItemArray.GetValue(0).ToString() == textBoxid_cont.Text)
                        {
                            existaID = true;
                            break;
                        }
                    }
                    if (existaID)
                        MessageBox.Show("ID-ul introdus este deja folosit");
                    else
                    {

                        bool existaF = false;
                        foreach (DataRow dr in ds.Tables["Furnizor"].Rows)
                        {
                            if (dr.ItemArray.GetValue(0).ToString() == textBoxid_cont.Text)
                            {
                                existaF = true;
                                break;
                            }
                        }

                        if (existaF)
                            MessageBox.Show("Numele firmei este fost deja inregistrata!");
                        else
                        {
                            string comanda;
                            SqlCommand cmd;

                            sql.con.Open();
                            comanda = "insert into conturi values ('" + textBoxid_cont.Text + "', '" + textBoxpw_cont.Text + "', 'furnizor')";
                            cmd = new SqlCommand(comanda, sql.con);
                            cmd.ExecuteNonQuery();

                            comanda = "insert into furnizor values ('" + textBoxid_cont.Text + "', '" + textBoxNumeFirma.Text + "', '" + textBoxAdresa.Text + "', '" + textBoxTelefon.Text + "', '" + textBoxEmail.Text + "', '" + textBoxOras.Text + "')";
                            cmd = new SqlCommand(comanda, sql.con);
                            cmd.ExecuteNonQuery();
                            
                            MessageBox.Show("" + textBoxNumeFirma.Text + ", (id: " + textBoxid_cont.Text + ") v-ati inregistrat cu succes!");
                            sql.con.Close();

                            completeazaDataSet();
                        }
                    }
                }                    
            }
        }

        public void completeazaDataSet()
        {
            ds = new DataSet();
            sql.con.Open();
            da = new SqlDataAdapter("select * from furnizor", sql.con);
            da.Fill(ds, "Furnizor");
            da = new SqlDataAdapter("select id_cont from conturi", sql.con);
            da.Fill(ds, "Conturi");
            sql.con.Close();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
