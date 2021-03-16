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
    public partial class angajat_cereri : Form
    {
        SQL sql = new SQL();
        string id="";
        DataTable dt;

        public angajat_cereri()
        {
            InitializeComponent();
        }

        private void buttonDeschide_Click(object sender, EventArgs e)
        {
            if (listBoxCereriFinalizate.SelectedIndex == -1)
                MessageBox.Show("Nu ati selectat o cerere");
            else
            {
                sql.con.Open();
                DataTable dtCereri = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select lista_cumparare.id_cerere_cumparare, lista_cumparare.id_medicament, medicament.denumire, lista_cumparare.cantitate, lista_cumparare.pret, lista_cumparare.data_fabricarii, lista_cumparare.data_expirarii, lista_cumparare.cod_medicament, status from lista_cumparare inner join medicament on lista_cumparare.id_medicament = medicament.id_medicament where lista_cumparare.id_cerere_cumparare = '" + listBoxCereriFinalizate.SelectedItem.ToString()[0] + "'", sql.con);
                da.Fill(dtCereri);
                sql.con.Close();

                dgvListaCerere.DataSource = dtCereri;
                id = dtCereri.Rows[0].ItemArray.GetValue(0).ToString();
                for (int i = 0; i < dgvListaCerere.Columns.Count; i++)
                {
                    dgvListaCerere.Columns[i].ReadOnly = true;
                    dgvListaCerere.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvListaCerere.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvListaCerere.Columns[2].HeaderText = "denumire";

                //dgvListaCerere.ForeColor = Color.White;

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

        private void listBoxCereriFinalizate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void angajat_cereri_Load(object sender, EventArgs e)
        {
            sql.Conexiune();

            sql.con.Open();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_cerere_cumparare, furnizor.nume_firma from cerere_cumparare inner join furnizor on cerere_cumparare.id_furnizor=furnizor.id_furnizor where cerere_cumparare.finalizat='1'", sql.con);
            da.Fill(dt);
            sql.con.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBoxCereriFinalizate.Items.Add(dt.Rows[i].ItemArray.GetValue(0).ToString() + " submitted by " + dt.Rows[i].ItemArray.GetValue(1).ToString());
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
                        
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr.ItemArray.GetValue(0).ToString() == id)
                                dr.Delete();
                        }
                        dt.AcceptChanges();

                        listBoxCereriFinalizate.Items.Clear();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            listBoxCereriFinalizate.Items.Add(dt.Rows[i].ItemArray.GetValue(0).ToString() + " submitted by " + dt.Rows[i].ItemArray.GetValue(1).ToString());
                        }
                    }
                    catch (Exception eroare)
                    {
                        MessageBox.Show(eroare.ToString(), "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
