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
    public partial class Angajat : Form
    {
        SQL sql = new SQL();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlCommand cmd;
        string id;
        string id2;
        DataTable dt = new DataTable();
        DataTable dtCereriC = new DataTable();
        DataTable dtStoc = new DataTable();
        DataTable dtCereri;
        string text;

        public Angajat(string user)
        {
            InitializeComponent();
            id = user;
        }
        private void Angajat_Load(object sender, EventArgs e)
        {
            sql.Conexiune();
            sql.con.Open();
            da = new SqlDataAdapter("select * from furnizor", sql.con);
            da.Fill(ds, "Furnizori");

            da = new SqlDataAdapter("select * from medicament", sql.con);
            da.Fill(ds, "Medicamente");

            dtCereriC = new DataTable();
            da = new SqlDataAdapter("select id_cerere_cumparare, furnizor.nume_firma from cerere_cumparare inner join furnizor on cerere_cumparare.id_furnizor=furnizor.id_furnizor where cerere_cumparare.finalizat='1'", sql.con);
            da.Fill(dtCereriC);

            dtStoc = new DataTable();
            da = new SqlDataAdapter("select stoc.id_medicament, medicament.denumire, medicament.producator, cantitate, data_fabricarii, data_expirarii, cod_medicament from stoc inner join medicament on stoc.id_medicament=medicament.id_medicament", sql.con);
            da.Fill(dtStoc);


            sql.con.Close();

            foreach (DataRow dr in ds.Tables["Furnizori"].Rows)
            {
                listBoxFurnizor.Items.Add(dr.ItemArray.GetValue(2).ToString());
            }

            foreach (DataRow dr in ds.Tables["Medicamente"].Rows)
            {
                listBoxMedicament.Items.Add(dr.ItemArray.GetValue(1).ToString());
            }

            for (int i = 0; i < dtCereriC.Rows.Count; i++)
            {
                listBoxCereriFinalizate.Items.Add(dtCereriC.Rows[i].ItemArray.GetValue(0).ToString() + " submitted by " + dtCereriC.Rows[i].ItemArray.GetValue(1).ToString());
            }

            dgvStocMed.DataSource = dtStoc;
            dgvStocMed.Columns[1].HeaderText = "denumire";
            dgvStocMed.Columns[2].HeaderText = "producator";
            dt.Columns.Add("Medicament");
            dt.Columns.Add("Cantitate");

            text = labelnrcereri.Text;
            labelnrcereri.Text = text + dtCereriC.Rows.Count.ToString();
        }

        private void buttonGenereaza_Click(object sender, EventArgs e)
        {
            sql.con.Open();
            DataTable dtCod = new DataTable();
            da = new SqlDataAdapter("select nr_cod, id_cont from coduri", sql.con);
            da.Fill(dtCod);
            sql.con.Close();

            int j = 0;
            StringBuilder sb = new StringBuilder();

            foreach (DataRow dr in dtCod.Rows)
            {
                if (string.IsNullOrEmpty(dr.ItemArray.GetValue(1).ToString()))
                {
                    j++;
                    sb.AppendLine(dr.ItemArray.GetValue(0).ToString());
                }
                if (j > 2)
                    break;
            }

            if (j > 2)
                MessageBox.Show("Eroare: Exista deja 3 coduri nefolosite:\n" + sb.ToString() + "");
            else
            {
                string caractere = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                char[] sirCaractere = new char[5];
                Random rnd = new Random();

                for (int i = 0; i < sirCaractere.Length; i++)
                    sirCaractere[i] = caractere[rnd.Next(caractere.Length)];

                string cod = new string(sirCaractere);
                labelCod.Text = "Cod: " + cod + "";

                sql.con.Open();
                cmd = new SqlCommand("insert into coduri(nr_cod) values ('" + cod + "')", sql.con);
                cmd.ExecuteNonQuery();
                sql.con.Close();
            }
        }

        private void listBoxFurnizor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCautaFurnizor_Click(object sender, EventArgs e)
        {
            listBoxFurnizor.Items.Clear();
            if (string.IsNullOrWhiteSpace(textBoxCautaFurnizor.Text))
            {
                foreach (DataRow dr in ds.Tables["Furnizori"].Rows)
                {
                    listBoxFurnizor.Items.Add(dr.ItemArray.GetValue(2).ToString());
                }
            }
            else
            {
                foreach (DataRow dr in ds.Tables["Furnizori"].Rows)
                {
                    if (dr.ItemArray.GetValue(2).ToString().ToUpper().Contains(textBoxCautaFurnizor.Text.ToUpper()))
                        listBoxFurnizor.Items.Add(dr.ItemArray.GetValue(2).ToString());
                }
            }
        }

        private void buttonCautaMedicament_Click(object sender, EventArgs e)
        {
            listBoxMedicament.Items.Clear();
            if (string.IsNullOrWhiteSpace(textBoxCautaMedicament.Text))
            {
                foreach (DataRow dr in ds.Tables["Medicamente"].Rows)
                {
                    listBoxMedicament.Items.Add(dr.ItemArray.GetValue(1).ToString());
                }
            }
            else
            {
                foreach (DataRow dr in ds.Tables["Medicamente"].Rows)
                {
                    if (dr.ItemArray.GetValue(1).ToString().ToUpper().Contains(textBoxCautaMedicament.Text.ToUpper()))
                        listBoxMedicament.Items.Add(dr.ItemArray.GetValue(1).ToString());
                }
            }
        }



        List<string> lista = new List<string>();
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (listBoxMedicament.SelectedIndex == -1)
                MessageBox.Show("Nu ati selectat un medicament");
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxCantitate.Text))
                    MessageBox.Show("Nu ati introdus cantitatea pentru medicamentul selectat");
                else
                { 
                    int valoare;
                    int cantitate=0;
                    if(!Int32.TryParse(textBoxCantitate.Text, out valoare))
                        MessageBox.Show("Nu ati introdus doar cifre la cantitate");
                    else
                    {
                        
                        //se verifica daca medicamentul introdus exista
                        //daca exista atunci se va aduna doar cantitatea totala
                        int ok = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            //daca medicamentul este introdus deja se va actualiza doar cantitatea
                            if (dr.ItemArray.GetValue(0).ToString() == listBoxMedicament.SelectedItem.ToString())
                            {
                                ok = 1;
                                cantitate = Convert.ToInt32(dr.ItemArray.GetValue(1).ToString()) + Convert.ToInt32(textBoxCantitate.Text);
                                dr["Cantitate"] = cantitate;
                                MessageBox.Show("Medicamentul " + listBoxMedicament.SelectedItem.ToString() + " este deja adaugat!\n\nCantitate noua: " + dr["Cantitate"].ToString() + "");
                                break;
                            }
                            else
                                ok = 0;
                        }

                        if (ok == 0)
                        {
                            lista.Add(listBoxMedicament.SelectedItem.ToString());
                            MessageBox.Show("Medicamentul " + listBoxMedicament.SelectedItem.ToString() + " a fost adaugat in lista!\n\nCantitate: " + textBoxCantitate.Text + "");

                            DataRow row = dt.NewRow();
                            row["Medicament"] = listBoxMedicament.SelectedItem.ToString();
                            row["Cantitate"] = textBoxCantitate.Text;
                            dt.Rows.Add(row);
                        }

                        listBoxListaM.Items.Clear();
                        foreach (DataRow dr in dt.Rows)
                        {
                            listBoxListaM.Items.Add(dr.ItemArray.GetValue(0).ToString() + " [" +dr["Cantitate"]+" buc.]");
                        }
                    }
                }
            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (listBoxListaM.SelectedIndex == -1)
                MessageBox.Show("Nu ati selectat un medicament pentru a-l sterge din lista");
            else
            {
                if (MessageBox.Show("Sunteti sigur ca vreti sa stergeti " + listBoxListaM.SelectedItem.ToString() + "?", "Eroare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string med="";
                    foreach (char c in listBoxListaM.SelectedItem.ToString())
                    {
                        if (c != ' ')
                            med = med + c;
                        else
                            break;
                    }

                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Medicament"].ToString() == med)
                        {
                            dr.Delete();
                            break;
                        }
                    }
                    listBoxListaM.Items.Remove(listBoxListaM.SelectedItem);
                }
            }
        }

        private void buttonTrimiteCerereC_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
                MessageBox.Show("Nu ati introdus medicamente in lista pentru a trimite cererea");
            else
            {
                if (listBoxFurnizor.SelectedIndex == -1)
                    MessageBox.Show("Nu ati selectat furnizorul");
                else
                {
                    //se va inregistra cererea in ambele tabele
                    //se obtine id-ul user-ului logat pentru a completa cererea
                    DataTable dtConturi = new DataTable();
                    sql.con.Open();
                    da = new SqlDataAdapter("select id_angajat from angajat where id_cont='"+id+"'", sql.con);
                    da.Fill(dtConturi);
                    string id_angajat = dtConturi.Rows[0][0].ToString();


                    //se obtine id-ul furnizorului selectat

                    string id_furnizor="";

                    foreach(DataRow dr in ds.Tables["Furnizori"].Rows)
                    {
                        if(dr.ItemArray.GetValue(2).ToString()==listBoxFurnizor.SelectedItem.ToString())
                        {
                            id_furnizor = dr.ItemArray.GetValue(0).ToString();
                            break;
                        }
                    }

                    //se inregistreaza cererea

                    //se inregistreaza lista medicamentelor pentru cererea creeata

                    cmd = new SqlCommand("insert into cerere_cumparare values('" + id_angajat + "', '" + id_furnizor + "', NULL, NULL,'0')", sql.con);
                    cmd.ExecuteNonQuery();

                    //se obtine id de la ultima cerere creeata
                    da = new SqlDataAdapter("select max(id_cerere_cumparare) from cerere_cumparare", sql.con);
                    DataTable dtCereriID = new DataTable();
                    da.Fill(dtCereriID);
                    string id_cerere = dtCereriID.Rows[0][0].ToString();



                    foreach (DataRow dr in dt.Rows) //pentru fiecare medicament inregistrat in lista
                    {
                        foreach (DataRow dr2 in ds.Tables["Medicamente"].Rows) //pentru fiecare medicament din baza de date
                        {
                            if (dr.ItemArray.GetValue(0).ToString() == dr2.ItemArray.GetValue(1).ToString())
                            {
                                //sb.AppendLine(dr2.ItemArray.GetValue(1).ToString() + " = id: " + dr2.ItemArray.GetValue(0).ToString());
                                cmd = new SqlCommand("insert into lista_cumparare values('" + dr2.ItemArray.GetValue(0).ToString() + "', '"+id_cerere+"', '" + dr.ItemArray.GetValue(1).ToString() + "', NULL, NULL, NULL, NULL,'nefinalizat')", sql.con);
                                cmd.ExecuteNonQuery();
                                break;
                            }
                        }
                    }
                    sql.con.Close();
                    MessageBox.Show("Succes");
                    listBoxListaM.Items.Clear();
                    listBoxFurnizor.Items.Clear();
                    textBoxCantitate.Clear();
                    //MessageBox.Show("furnizor = "+id_furnizor+"\ncerere="+id_cerere+"\nmedicamente:\n"+sb.ToString()+"");

                }
            }
        }

        private void buttonDeschide_Click(object sender, EventArgs e)
        {
            this.Hide();
            angajat_cereri cereri = new angajat_cereri();
            cereri.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBoxCereriFinalizate.SelectedIndex == -1)
                MessageBox.Show("Nu ati selectat o cerere");
            else
            {
                id2 = "";
                foreach (char c in listBoxCereriFinalizate.SelectedItem.ToString())
                {
                    if (c != ' ')
                        id2 = id2 + c;
                    else
                        break;
                }

                sql.con.Open();
                dtCereri = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select lista_cumparare.id_cerere_cumparare, lista_cumparare.id_medicament, medicament.denumire, lista_cumparare.cantitate, lista_cumparare.pret, lista_cumparare.data_fabricarii, lista_cumparare.data_expirarii, lista_cumparare.cod_medicament, status from lista_cumparare inner join medicament on lista_cumparare.id_medicament = medicament.id_medicament where lista_cumparare.id_cerere_cumparare = '" + id2 + "'", sql.con);
                da.Fill(dtCereri);
                sql.con.Close();

                //id2 = listBoxCereriFinalizate.SelectedItem.ToString()[0];

                dgvListaCerere.DataSource = dtCereri;
                id = dtCereri.Rows[0].ItemArray.GetValue(0).ToString();
                for (int i = 0; i < dgvListaCerere.Columns.Count; i++)
                {
                    dgvListaCerere.Columns[i].ReadOnly = true;
                    dgvListaCerere.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvListaCerere.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvListaCerere.Columns[2].HeaderText = "denumire";


                foreach (DataGridViewRow row in dgvListaCerere.Rows)
                {
                    if (row.Cells[8].Value.ToString() == "sters")
                    {
                        row.DefaultCellStyle.BackColor = Color.Crimson;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (row.Cells[8].Value.ToString() == "finalizat")
                        row.DefaultCellStyle.BackColor = Color.PaleGreen;

                }

                dgvListaCerere.Columns[8].SortMode = DataGridViewColumnSortMode.Programmatic;

            }
        }

        private void buttonRespinge_Click(object sender, EventArgs e)
        {
            if (dgvListaCerere.DataSource == null)
                MessageBox.Show("Nu ati deschis o cerere");
            else
            {
                if (MessageBox.Show("Doriti sa stergeti cererea cu ID-ul " + id + "?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        sql.con.Open();
                        SqlCommand cmd = new SqlCommand("delete from lista_cumparare where id_cerere_cumparare='" + id + "'", sql.con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("delete from cerere_cumparare where id_cerere_cumparare='" + id + "'", sql.con);
                        cmd.ExecuteNonQuery();
                        sql.con.Close();
                        MessageBox.Show("Cererea a fost stearsa");
                        dgvListaCerere.DataSource = null;

                        foreach (DataRow dr in dtCereriC.Rows)
                        {
                            if (dr.ItemArray.GetValue(0).ToString() == id)
                                dr.Delete();
                        }
                        dtCereriC.AcceptChanges();

                        listBoxCereriFinalizate.Items.Clear();
                        for (int i = 0; i < dtCereriC.Rows.Count; i++)
                        {
                            listBoxCereriFinalizate.Items.Add(dtCereriC.Rows[i].ItemArray.GetValue(0).ToString() + " submitted by " + dtCereriC.Rows[i].ItemArray.GetValue(1).ToString());
                        }
                        labelnrcereri.Text = text + dtCereriC.Rows.Count.ToString();
                    }
                    catch (Exception eroare)
                    {
                        MessageBox.Show(eroare.ToString(), "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            angajat_addm addm = new angajat_addm();
            addm.ShowDialog();

            ds.Tables["Medicamente"].Rows.Clear();
            ds.Tables["Medicamente"].AcceptChanges();

            sql.con.Open();
            da = new SqlDataAdapter("select * from medicament", sql.con);
            da.Fill(ds, "Medicamente");
            sql.con.Close();

            listBoxMedicament.Items.Clear();
            foreach (DataRow dr in ds.Tables["Medicamente"].Rows)
            {
                listBoxMedicament.Items.Add(dr.ItemArray.GetValue(1).ToString());
            }

        }

        private void buttonAproba_Click(object sender, EventArgs e)
        {
            if (dgvListaCerere.DataSource == null)
                MessageBox.Show("Nu ati deschis o cerere");
            else
            {
                if (MessageBox.Show("Esti sigur ca vrei sa aprobi cererea?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        sql.con.Open();

                        DataTable dtVerifica;

                        foreach (DataRow dr in dtCereri.Rows)
                        {
                            dtVerifica = new DataTable();
                            da = new SqlDataAdapter("select * from stoc where cod_medicament='"+dr.ItemArray.GetValue(7).ToString()+"'", sql.con);
                            da.Fill(dtVerifica);

                            if (dtVerifica.Rows.Count == 0)
                            {
                                if (dr.ItemArray.GetValue(8).ToString() == "finalizat")
                                {
                                    cmd = new SqlCommand("insert into stoc values('" + dr.ItemArray.GetValue(1).ToString() + "', '" + dr.ItemArray.GetValue(7).ToString() + "', '" + dr.ItemArray.GetValue(5).ToString() + "', '" + dr.ItemArray.GetValue(6).ToString() + "', '" + dr.ItemArray.GetValue(3).ToString() + "')", sql.con);
                                    cmd.ExecuteNonQuery();
                                }
                                
                            }
                            else if (dtVerifica.Rows.Count > 0)
                            {
                                cmd = new SqlCommand("update stoc set cantitate=cantitate+" + dr.ItemArray.GetValue(3).ToString() + " where cod_medicament='"+dr.ItemArray.GetValue(7).ToString()+"' and id_medicament='"+dr.ItemArray.GetValue(1).ToString()+"'",sql.con);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        sql.con.Close();
                        MessageBox.Show("Finalizat!");


                        

                        sql.con.Open();

                        cmd = new SqlCommand("update cerere_cumparare set finalizat=2 where id_cerere_cumparare='" + id2 + "'", sql.con);
                        cmd.ExecuteNonQuery();

                        dtCereriC = new DataTable();
                        da = new SqlDataAdapter("select id_cerere_cumparare, furnizor.nume_firma from cerere_cumparare inner join furnizor on cerere_cumparare.id_furnizor=furnizor.id_furnizor where cerere_cumparare.finalizat='1'", sql.con);
                        da.Fill(dtCereriC);

                        dtStoc = new DataTable();
                        da = new SqlDataAdapter("select stoc.id_medicament, medicament.denumire, medicament.producator, cantitate, data_fabricarii, data_expirarii, cod_medicament from stoc inner join medicament on stoc.id_medicament=medicament.id_medicament", sql.con);
                        da.Fill(dtStoc);
                        dgvStocMed.DataSource = dtStoc;
                        dgvStocMed.Columns[1].HeaderText = "denumire";
                        dgvStocMed.Columns[2].HeaderText = "producator";

                        sql.con.Close();

                        dgvListaCerere.DataSource = null;

                        listBoxCereriFinalizate.Items.Clear();
                        for (int i = 0; i < dtCereriC.Rows.Count; i++)
                        {
                            listBoxCereriFinalizate.Items.Add(dtCereriC.Rows[i].ItemArray.GetValue(0).ToString() + " submitted by " + dtCereriC.Rows[i].ItemArray.GetValue(1).ToString());
                        }

                        labelnrcereri.Text = text + dtCereriC.Rows.Count.ToString();

                    }
                    catch (Exception eroare)
                    {
                        MessageBox.Show(eroare.ToString(), "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm main = new LoginForm();
            main.ShowDialog();
            this.Close();
            
        }
    }
}
