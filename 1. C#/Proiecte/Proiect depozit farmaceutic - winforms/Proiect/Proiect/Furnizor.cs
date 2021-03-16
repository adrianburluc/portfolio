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
    public partial class Furnizor : Form
    {
        SQL sql = new SQL();
        SqlCommand cmd;
        SqlDataAdapter da;
        string id;
        DataSet ds;
        DataTable dtListaCerere;
        string id_cerere="";
        

        public Furnizor(string user)
        {
            InitializeComponent();
            id = user;
        }

        public void Furnizor_Load(object sender, EventArgs e)
        {
            sql.Conexiune();
            ds = new DataSet();
            sql.con.Open();
            da = new SqlDataAdapter("select cerere_cumparare.id_cerere_cumparare, angajat.nume, angajat.prenume from cerere_cumparare inner join angajat on cerere_cumparare.id_angajat=angajat.id_angajat where cerere_cumparare.id_furnizor in (select id_furnizor from furnizor where id_cont='" + id + "') and finalizat='0'", sql.con);
            da.Fill(ds, "Test");
            sql.con.Close();

            for (int i = 0; i < ds.Tables["Test"].Rows.Count; i++)
            {
                listBoxCereriF.Items.Add(ds.Tables["Test"].Rows[i].ItemArray.GetValue(0).ToString() + " by " + ds.Tables["Test"].Rows[i].ItemArray.GetValue(1).ToString() + " " + ds.Tables["Test"].Rows[i].ItemArray.GetValue(2).ToString());
            }
        }

        private void buttonDeschide_Click(object sender, EventArgs e)
        {
            if (listBoxCereriF.SelectedIndex == -1)
                MessageBox.Show("Nu ati selectat o cerere");
            else
            {
                try
                {
                    id_cerere="";
                    foreach (char c in listBoxCereriF.SelectedItem.ToString())
                    {
                        if (c != ' ')
                            id_cerere = id_cerere + c;
                        else
                            break;
                    }

                    //MessageBox.Show(id_cerere);

                    dtListaCerere = new DataTable();

                    sql.con.Open();
                    da = new SqlDataAdapter("select distinct lista_cumparare.id_cerere_cumparare, lista_cumparare.id_medicament, (select denumire from medicament where medicament.id_medicament=lista_cumparare.id_medicament), lista_cumparare.cantitate, lista_cumparare.pret, lista_cumparare.data_fabricarii, lista_cumparare.data_expirarii, lista_cumparare.cod_medicament from lista_cumparare inner join medicament on lista_cumparare.id_medicament=medicament.id_medicament where lista_cumparare.id_cerere_cumparare='" + id_cerere + "'", sql.con);
                    da.Fill(dtListaCerere);
                    sql.con.Close();

                    dgvListaCerere.DataSource = dtListaCerere;
                    dgvListaCerere.Columns[0].ReadOnly = true;
                    dgvListaCerere.Columns[1].ReadOnly = true;
                    dgvListaCerere.Columns[2].ReadOnly = true;
                    dgvListaCerere.Columns[3].ReadOnly = true;
                    dgvListaCerere.Columns[2].HeaderText = "denumire";

                    for (int i = 0; i < dgvListaCerere.Columns.Count; i++)
                        dgvListaCerere.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                catch (Exception eroare)
                {
                    MessageBox.Show(eroare.ToString());
                }
             }
        }

        private void buttonActualizeaza_Click(object sender, EventArgs e)
        {
            if (dgvListaCerere.DataSource == null)
                MessageBox.Show("Nu aveti o cerere deschisa");
            else
            {
                bool textCompletat = true;
                foreach (DataGridViewRow dr in dgvListaCerere.Rows)
                {
                    foreach (DataGridViewCell cell in dr.Cells)
                    {
                        if (string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            textCompletat = false;
                            break;
                        }
                    }
                    if (textCompletat == false)
                        break;
                }

                if (textCompletat == false)
                    MessageBox.Show("Completeaza toate campurile");
                else
                {
                    if (MessageBox.Show("Esti sigur ca ai completat toate campurile corect?\nCererea nu va mai fi vizibila dupa finalizare.", "Validare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommandBuilder cb = new SqlCommandBuilder(da);
                            sql.con.Open();

                            cb.DataAdapter.Update(dtListaCerere);

                            foreach (DataRow dr in dtListaCerere.Rows)
                            {
                                SqlCommand cmd = new SqlCommand("update lista_cumparare set status='finalizat' where id_medicament='" + dr.ItemArray.GetValue(1).ToString() + "' and id_cerere_cumparare='" + dr.ItemArray.GetValue(0).ToString() + "'", sql.con);
                                cmd.ExecuteNonQuery();
                            }
                            SqlCommand cmd2 = new SqlCommand("update cerere_cumparare set finalizat='1' where id_cerere_cumparare='" + id_cerere + "'", sql.con);
                            cmd2.ExecuteNonQuery();

                            sql.con.Close();

                            MessageBox.Show("Finalizat!!");

                            foreach (DataRow dr in ds.Tables["Test"].Rows)
                            {
                                if (dr.ItemArray.GetValue(0).ToString() == id_cerere)
                                {
                                    dr.Delete();
                                    break;
                                }
                            }

                            ds.Tables["Test"].AcceptChanges();

                            dgvListaCerere.DataSource = null;

                            listBoxCereriF.Items.Clear();
                            for (int i = 0; i < ds.Tables["Test"].Rows.Count; i++)
                            {
                                listBoxCereriF.Items.Add(ds.Tables["Test"].Rows[i].ItemArray.GetValue(0).ToString() + " by " + ds.Tables["Test"].Rows[i].ItemArray.GetValue(1).ToString() + " " + ds.Tables["Test"].Rows[i].ItemArray.GetValue(2).ToString());
                            }

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "Eroare");
                        }
                    }
                }
            }
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (dgvListaCerere.SelectedRows.Count == 0)
                MessageBox.Show("Selectati un rand intreg pentru a-l putea sterge");
            else
            {
                foreach (DataGridViewRow rand in dgvListaCerere.SelectedRows)
                {
                    if (MessageBox.Show("Doresti sa stergi randul " + (Convert.ToInt32(rand.Index) + 1).ToString() + "?\n\nDenumire: " + rand.Cells[2].Value.ToString() + "\nID medicament: " + rand.Cells[1].Value.ToString() + "", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        try
                        {
                            sql.con.Open();
                            SqlCommand cmd = new SqlCommand("update lista_cumparare set status='sters' where id_medicament='" + rand.Cells[1].Value.ToString() + "' and id_cerere_cumparare='" + rand.Cells[0].Value.ToString() + "'", sql.con);
                            cmd.ExecuteNonQuery();
                            sql.con.Close();

                            int index = rand.Index;
                            dgvListaCerere.Rows.RemoveAt(index);
                            dtListaCerere.Rows.RemoveAt(index);
                        }
                        catch(Exception err)
                        { 
                            MessageBox.Show(err.Message,"Eroare!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anulat!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm main = new LoginForm();
            main.ShowDialog();
            this.Close();
        }
    }
}
