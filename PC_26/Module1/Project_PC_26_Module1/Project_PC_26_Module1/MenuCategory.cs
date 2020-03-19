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
    public partial class MenuCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        Config db = new Config();
        public MenuCategory()
        {
            InitializeComponent();
            cn = new SqlConnection(db.Myconnection());
        }

        private void Clear()
        {

            txtName.Clear();
            txtName.Focus();
            btnAddd.Text = "Save";
            txtTitle.Text = "Add Menu Category";
        }

        private void MenuCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mrenuCategory1DataSet.menu_category' table. You can move, or remove it, as needed.
            this.menu_categoryTableAdapter.Fill(this.mrenuCategory1DataSet.menu_category);

        }

        private void load()
        {
            this.menu_categoryTableAdapter.Fill(this.mrenuCategory1DataSet.menu_category);
        }

        private void btnAddd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ep.Clear();
                ep.SetError(txtName, "Please enter name menu category");
            }
            else if(btnAddd.Text=="Save")
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert menu_category values('" + txtName.Text + "')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Menu Category successfully added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

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
                    cm = new SqlCommand("update  menu_category set name='" + txtName.Text + "' where id='"+txtId.Text+"'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Menu Category successfully Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    load();
                    Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            txtId.Text = dgv[0, e.RowIndex].Value.ToString();
            txtName.Text = dgv[1, e.RowIndex].Value.ToString();
            txtTitle.Text = "Edit Menu Category";
            btnAddd.Text = "Update";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void menucategoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
