using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PC_26_Module1
{
    public partial class Menu : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        Config db = new Config();
        public Menu()
        {
            InitializeComponent();
            cn = new SqlConnection(db.Myconnection());
            Clear();
        }

        private void Clear()
        {

            txtName.Clear();
            txtName.Focus();
            txtPRice.Clear();
            txtDescription.Clear();
            txtfavorite.Text = "0";
            btnAddd.Text = "Save";
            cbox.Checked = false;
            txtTitle.Text = "Add Menu ";
        }

        private void loadCmb()
        {
            this.menu_categoryTableAdapter.Fill(this.mrenuCategory1DataSet.menu_category);
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mrenuCategory1DataSet.menu_category' table. You can move, or remove it, as needed.
            this.menu_categoryTableAdapter.Fill(this.mrenuCategory1DataSet.menu_category);
            // TODO: This line of code loads data into the 'menu_Module1DataSet.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.menu_Module1DataSet.menu);

        }

        private void load()
        {
            this.menuTableAdapter.Fill(this.menu_Module1DataSet.menu);
        }


        private void txtPRice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<46)
            {

            }
            else if (e.KeyChar==8)
            {

            }
            else if ((e.KeyChar<48) || (e.KeyChar>57))
            {
                e.Handled = true;
           
            }
        }

        public void cheked()
        {
            
            if (cbox.Checked)
            {
                cbox.Checked = true;
            }
            else
            {
                cbox.Checked = false;
            }
        }

        private void btnAddd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ep.Clear();
                ep.SetError(txtName, "Please enter name menu ");
            }
            else if (string.IsNullOrEmpty(txtPRice.Text))
            {
                ep.Clear();
                ep.SetError(txtName, "Please enter Price menu ");

            }
            else if (txtPRice.Text=="0")
            {
                ep.Clear();
                ep.SetError(txtName, "Price cannot be zero");
            }
            else if (btnAddd.Text=="Save")
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert menu values('" + cmbCategory.SelectedValue + "','" + txtName.Text + "','"+txtPRice.Text+"','" + txtDescription.Text + "','" + txtfavorite.Text + "')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Menu  successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    load();
                    Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnAddd.Text=="Update")
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("update menu set menu_category_id='" + cmbCategory.SelectedValue + "',name='" + txtName.Text + "',price='" +Convert.ToDouble(txtPRice.Text)+ "',description='" + txtDescription.Text + "',is_favorite='" + txtfavorite.Text+ "' where id='"+txtId.Text+"'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Update Menu successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    load();
                    Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dgv[0, e.RowIndex].Value.ToString();
            txtName.Text = dgv[1, e.RowIndex].Value.ToString();
            cmbCategory.Text= dgv[2, e.RowIndex].Value.ToString();
            loadCmb();
            txtPRice.Text= dgv[3, e.RowIndex].Value.ToString();
            txtDescription.Text = dgv[4, e.RowIndex].Value.ToString();
            cbox.Checked= Convert.ToBoolean(dgv[5, e.RowIndex].Value.ToString());
            txtTitle.Text = "Edit Menu ";
            btnAddd.Text = "Update";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox.Checked)
            {
                cbox.Checked = true;
                txtfavorite.Text = "1";
            }
            else
            {
                cbox.Checked = false;
                txtfavorite.Text = "0";
            }
        }
    }
}
