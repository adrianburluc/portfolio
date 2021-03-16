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
    public partial class Register : Form
    {
        SQL sql = new SQL();

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonContinua_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text != "" && textBoxPrenume.Text != "" && textBoxEmail.Text != "" && textBoxTelefon.Text != "" && textBoxCod.Text != "" && textBoxid_cont.Text != "" && textBoxpw_cont.Text != "")
            {
                SQL sql = new SQL();
                sql.Conexiune();
                sql.con.Open();
                
                //se verifica daca codul introdus exista in baza de date
                SqlDataAdapter da;
                da = new SqlDataAdapter("select * from coduri where nr_cod='" + textBoxCod.Text + "'", sql.con);

                DataSet dsCod = new DataSet();
                da.Fill(dsCod, "Check");
                if (dsCod.Tables["Check"].Rows.Count == 0)
                    MessageBox.Show("Codul de inregistrare nu exista");

                //se verifica daca codul introdus a fost folosit de alt user
                else if (dsCod.Tables["Check"].Rows.Count != 0 && dsCod.Tables["Check"].Rows[0].ItemArray.GetValue(1).ToString() == "")
                {
                    //se verifica daca id-ul introdus exista deja
                    da = new SqlDataAdapter("select * from conturi where id_cont='" + textBoxid_cont.Text + "'", sql.con);
                    DataSet dsCont = new DataSet();
                    da.Fill(dsCont, "Check");
                    if (dsCont.Tables["Check"].Rows.Count != 0)
                        MessageBox.Show("ID-ul contului exista deja!");
                    else //va trece la inregistrarea datelor in tabelele coduri, conturi si angajat
                    {
                        //autoincrementarea cheii primare pentru tabela angajat pentru urmatoarea inregistrare
                        string maxid = "select max(id_angajat) from angajat";
                        da = new SqlDataAdapter(maxid, sql.con);
                        DataSet dsMaxID = new DataSet();
                        da.Fill(dsMaxID, "MaxID");
                        int id = Convert.ToInt32(dsMaxID.Tables["MaxID"].Rows[0].ItemArray.GetValue(0));
                        id = id + 1;

                        string cmdregister;

                        //inregistrarea contului in tabela conturi
                        SqlCommand cmd;
                        cmdregister = "insert into conturi (id_cont, pw_cont, tip) values ('" + textBoxid_cont.Text + "','" + textBoxpw_cont.Text + "','angajat')";
                        cmd = new SqlCommand(cmdregister, sql.con);
                        cmd.ExecuteNonQuery();

                        //completarea tabelului coduri cu id-ul contului care a utilizat codul
                        string cmdcompleteazacod = "update coduri set id_cont='" + textBoxid_cont.Text + "' where nr_cod='" + dsCod.Tables["Check"].Rows[0].ItemArray.GetValue(0).ToString() + "'";
                        cmd = new SqlCommand(cmdcompleteazacod, sql.con);
                        cmd.ExecuteNonQuery();

                        //inregistrarea angajatului in tabela angajati
                        cmdregister = "insert into angajat values ('" + textBoxid_cont.Text + "','" + textBoxNume.Text + "','" + textBoxPrenume.Text + "','" + textBoxEmail.Text + "','" + textBoxTelefon.Text + "')";
                        cmd = new SqlCommand(cmdregister, sql.con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Contul "+textBoxNume.Text+" a fost inregistrat!");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Codul introdus a fost deja folosit");
                sql.con.Close(); 
            }
            else
                MessageBox.Show("Nu ati introdus date in toate campurile!");

        }
    }
}
