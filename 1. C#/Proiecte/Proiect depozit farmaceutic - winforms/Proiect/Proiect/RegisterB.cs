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
    public partial class RegisterB : Form
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SQL sql = new SQL();
        SqlCommand cmd;
        //string idFarmacie;

        public RegisterB()
        {
            InitializeComponent();
        }

        private void RegisterB_Load(object sender, EventArgs e)
        {
            sql.Conexiune();
            completeazaDataSet();
            foreach (DataRow dr in ds.Tables["Farmacii"].Rows)
                listBoxFarmacii.Items.Add(dr.ItemArray.GetValue(1));
        }

        public void completeazaDataSet()
        {
            sql.con.Open();
            da = new SqlDataAdapter("select * from farmacie",sql.con);
            da.Fill(ds, "Farmacii");
            da = new SqlDataAdapter("select * from conturi", sql.con);
            da.Fill(ds, "Conturi");
            da = new SqlDataAdapter("select * from beneficiar", sql.con);
            da.Fill(ds, "Beneficiari");
            sql.con.Close();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            //listBoxFarmacii.Items.Clear();
            if (textBoxCauta.Text == "")
                actualizeazaListbox();
            else
            {
                listBoxFarmacii.Items.Clear();
                string numeFarmacie = textBoxCauta.Text;

                foreach (DataRow dr in ds.Tables["Farmacii"].Rows)
                {
                    if (dr.ItemArray.GetValue(1).ToString().ToUpper().Contains(numeFarmacie.ToString().ToUpper()))
                        listBoxFarmacii.Items.Add(dr.ItemArray.GetValue(1).ToString());
                }
            }
        }

        private void buttonContinua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxid_cont.Text) && string.IsNullOrEmpty(textBoxpw_cont.Text))
                MessageBox.Show("Completati datele contului");
            else
            {
                if (textBoxid_cont.Text.Contains(' ') || textBoxpw_cont.Text.Contains(' '))
                    MessageBox.Show("Datele contului nu pot contine spatii!");
                else
                {
                    bool existaID = false;
                    foreach (DataRow dr in ds.Tables["conturi"].Rows)
                    {
                        if (dr.ItemArray.GetValue(0).ToString() == textBoxid_cont.Text)
                        {
                            existaID = true;
                            break;
                        }
                    }

                    if (existaID == true)
                        MessageBox.Show("ID-ul introdus exista deja!");
                    else
                    {
                        //contul poate fi inregistrat, se verifica urmatoarele campuri
                        if (string.IsNullOrWhiteSpace(textBoxNume.Text) || string.IsNullOrWhiteSpace(textBoxPrenume.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxTelefon.Text))
                            MessageBox.Show("Completati toate datele personale!");
                        else
                        {
                            if (listBoxFarmacii.SelectedIndex == -1 && (string.IsNullOrWhiteSpace(textBoxDenumire.Text) || string.IsNullOrWhiteSpace(textBoxAdresa.Text) || string.IsNullOrWhiteSpace(textBoxEmailF.Text) || string.IsNullOrWhiteSpace(textBoxTelefonF.Text)))
                                MessageBox.Show("Selectati o farmacie sau completati toate datele pentru a va inregistra");
                            else
                            {
                                if (listBoxFarmacii.SelectedIndex != -1 && (string.IsNullOrWhiteSpace(textBoxDenumire.Text) || string.IsNullOrWhiteSpace(textBoxAdresa.Text) || string.IsNullOrWhiteSpace(textBoxEmailF.Text) || string.IsNullOrWhiteSpace(textBoxTelefonF.Text)))
                                {
                                    //MessageBox.Show("Veti fi inregistrat cu farmacia selectata");
                                    inregistreazaBeneficiar(textBoxid_cont.Text, textBoxpw_cont.Text, textBoxNume.Text, textBoxPrenume.Text, textBoxEmail.Text, textBoxTelefon.Text);
                                    MessageBox.Show("Beneficiar inregistrat cu succes!");

                                    ds.Tables["Beneficiari"].Clear();
                                    sql.con.Open();
                                    da = new SqlDataAdapter("select * from beneficiar", sql.con);
                                    da.Fill(ds, "Beneficiari");
                                    sql.con.Close();
                                    this.Close();
                                    
                                }
                                else if (listBoxFarmacii.SelectedIndex == -1 && (!string.IsNullOrWhiteSpace(textBoxDenumire.Text) && !string.IsNullOrWhiteSpace(textBoxAdresa.Text) && !string.IsNullOrWhiteSpace(textBoxEmailF.Text) && !string.IsNullOrWhiteSpace(textBoxTelefonF.Text)))
                                {
                                    bool existaDenumire = false;
                                    foreach (DataRow dr in ds.Tables["Farmacii"].Rows)
                                    {
                                        if (dr.ItemArray.GetValue(1).ToString() == textBoxDenumire.Text)
                                        {
                                            existaDenumire = true;
                                            break;
                                        }
                                    }
                                    if (existaDenumire == true)
                                        MessageBox.Show("Numele farmaciei a fost deja inregistrat!");
                                    else
                                    {
                                        //MessageBox.Show("Veti fi inregistrat cu farmacia noua");
                                        inregistreazaFarmacie(textBoxDenumire.Text, textBoxAdresa.Text, textBoxEmailF.Text, textBoxTelefonF.Text);

                                        ds.Clear();

                                        sql.con.Open();
                                        da = new SqlDataAdapter("select * from farmacie", sql.con);
                                        da.Fill(ds, "Farmacii");
                                        sql.con.Close();

                                        inregistreazaBeneficiar(textBoxid_cont.Text, textBoxpw_cont.Text, textBoxNume.Text, textBoxPrenume.Text, textBoxEmail.Text, textBoxTelefon.Text);
                                        
                                        sql.con.Open();
                                        da = new SqlDataAdapter("select * from conturi", sql.con);
                                        da.Fill(ds, "Conturi");
                                        da = new SqlDataAdapter("select * from beneficiar", sql.con);
                                        da.Fill(ds, "Beneficiari");
                                        sql.con.Close();


                                        MessageBox.Show("Beneficiar si farmacie inregistrate cu succes!");
                                        actualizeazaListbox();
                                        this.Close();
                                    }
                                }
                                else
                                    MessageBox.Show("Deselectati optiunea sau stergeti datele introduse pentru a va putea inregistra!");
                            }
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxFarmacii.SelectedIndex = -1;
        }

        public void inregistreazaBeneficiar(string id, string pw, string nume, string prenume, string email, string telefon)
        {
            sql.con.Open();
            cmd = new SqlCommand("insert into conturi values ('"+id+"', '"+pw+"', 'beneficiar')",sql.con);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("insert into beneficiar values ('" + id + "', '" + nume + "', '" + prenume + "', '" + email + "', '" + telefon + "', '"+idFarmacie()+"')", sql.con);
            cmd.ExecuteNonQuery();
            sql.con.Close();
        }
        public void inregistreazaFarmacie(string denumire, string adresa, string email, string telefon)
        {
            sql.con.Open();
            cmd = new SqlCommand("insert into farmacie values ('" + denumire + "', '" + adresa + "', '" + email + "', '" + telefon + "')", sql.con);
            cmd.ExecuteNonQuery();
            sql.con.Close();
        }


        public string idFarmacie()
        {

            string idFarmacie = "";

            if (listBoxFarmacii.SelectedIndex != -1)
            {
                foreach (DataRow dr in ds.Tables["Farmacii"].Rows)
                {
                    if (dr.ItemArray.GetValue(1).ToString() == listBoxFarmacii.GetItemText(listBoxFarmacii.SelectedItem))
                    {
                        idFarmacie = dr.ItemArray.GetValue(0).ToString();
                        break;
                    }
                }
            }
            else
            {
                foreach (DataRow dr in ds.Tables["Farmacii"].Rows)
                {
                    if (dr.ItemArray.GetValue(1).ToString() == textBoxDenumire.Text)
                    {
                        idFarmacie = dr.ItemArray.GetValue(0).ToString();
                        break;
                    }
                }
            }

            return idFarmacie;
        }

        private void buttonStergeDate_Click(object sender, EventArgs e)
        {
            textBoxDenumire.Text = "";
            textBoxAdresa.Text = "";
            textBoxEmailF.Text = "";
            textBoxTelefonF.Text = "";
        }

        public void actualizeazaListbox()
        {
            listBoxFarmacii.Items.Clear();
            foreach (DataRow dr in ds.Tables["Farmacii"].Rows)
                listBoxFarmacii.Items.Add(dr.ItemArray.GetValue(1));
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
