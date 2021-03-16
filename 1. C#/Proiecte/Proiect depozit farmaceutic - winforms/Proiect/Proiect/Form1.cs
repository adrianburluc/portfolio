using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Proiect
{
    public partial class LoginForm : Form
    {
        SQL sql = new SQL();

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            sql.Conexiune();
        }

        private void buttonConectare_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
                MessageBox.Show("Nu ai introdus ID si parola pentru a te conecta!");
            else
            {
                if (textBoxParola.Text == "")
                    MessageBox.Show("Nu ai introdus parola pentru a te conecta!");
                else
                {
                    sql.con.Open();
                    DataTable dtConturi = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select * from conturi where id_cont='"+textBoxID.Text+"'", sql.con);
                    da.Fill(dtConturi);
                    sql.con.Close();

                    if (dtConturi.Rows.Count == 0)
                        MessageBox.Show("Contul introdus nu este inregistrat!");
                    else
                    {
                        string parola = dtConturi.Rows[0][1].ToString();
                        if (parola != textBoxParola.Text)
                            MessageBox.Show("Datele contului sunt gresite!");
                        else
                        {
                            string id = textBoxID.Text;
                            MessageBox.Show("Te-ai conectat cu succes!");

                            if (dtConturi.Rows[0][2].ToString() == "angajat")
                            {
                                Angajat angajat = new Angajat(textBoxID.Text);
                                this.Hide();
                                angajat.ShowDialog();
                                this.Close();
                            }
                            else if (dtConturi.Rows[0][2].ToString() == "beneficiar")
                            {
                                Beneficiar beneficiar = new Beneficiar();
                                beneficiar.ShowDialog();
                            }
                            else if (dtConturi.Rows[0][2].ToString() == "furnizor")
                            {
                                Furnizor furnizor = new Furnizor(textBoxID.Text);
                                this.Hide();
                                furnizor.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                }
            }


        }
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            if (!rbBeneficiar.Checked && !rbFurnizor.Checked && !rbAngajat.Checked)
                MessageBox.Show("Selecteaza tipul contului pentru a te inregistra!");
            else
            {
                if (rbBeneficiar.Checked)
                {
                    RegisterB inregistrareBeneficiar = new RegisterB();
                    inregistrareBeneficiar.ShowDialog();
                }
                if (rbFurnizor.Checked)
                {
                    RegisterF inregistrareFurnizor = new RegisterF();
                    inregistrareFurnizor.ShowDialog();
                }
                if (rbAngajat.Checked)
                {
                    Register inregistrare = new Register();
                    inregistrare.ShowDialog();
                }
            }
        }
    }
}
