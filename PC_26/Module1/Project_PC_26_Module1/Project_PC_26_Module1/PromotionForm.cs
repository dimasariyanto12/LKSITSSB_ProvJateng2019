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
    public partial class PromotionForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        Config db = new Config();
        public PromotionForm()
        {
            InitializeComponent();
            cn = new SqlConnection(db.Myconnection());
        }

        private void Clear()
        {
            txtCode.Clear();
            txtCode.Focus();
            txtDiscount.Clear();
            txtMinSpeend.Clear();
            btnAddd.Text = "Save";
            txtTitle.Text = "Add Promotion Menu";
        }

        private void PromotionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promotionDataSet.promotion' table. You can move, or remove it, as needed.
            this.promotionTableAdapter.Fill(this.promotionDataSet.promotion);

        }
        private void load()
        {
            this.promotionTableAdapter.Fill(this.promotionDataSet.promotion);
        }

        private void btnAddd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCode.Text))
            {
                ep.Clear();
                ep.SetError(txtCode, "Please enter Code  ");
            }
            else if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                ep.Clear();
                ep.SetError(txtDiscount, "Please enter Discount");

            }
            else if (txtMinSpeend.Text == "0")
            {
                ep.Clear();
                ep.SetError(txtMinSpeend, "Minimum Spend cannot be zero");
            }
            else if (btnAddd.Text=="Save")
            {
                ep.Clear();
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert promotion values('" + txtCode.Text + "','" + txtDiscount.Text + "','" + txtMinSpeend.Text + "','" + txtStar.Text + "','" + txtEnd.Text + "')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Promotion successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    cm = new SqlCommand("update promotion set code='" + txtCode.Text + "',discount='" +Convert.ToDouble( txtDiscount.Text) + "',minimum_spent='" +Convert.ToDouble(txtMinSpeend.Text )+ "',star_time='" + txtStar.Text + "',end_time='" + txtEnd.Text + "' where id ='"+txtId.Text+"'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Update Promotion successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtCode.Text = dgv[1, e.RowIndex].Value.ToString();
            txtDiscount.Text = dgv[2, e.RowIndex].Value.ToString();
            
            txtMinSpeend.Text = dgv[3, e.RowIndex].Value.ToString();
            txtStar.Text = dgv[4, e.RowIndex].Value.ToString();
            txtEnd.Text = dgv[5, e.RowIndex].Value.ToString();

            txtTitle.Text = "Edit Promotion ";
            btnAddd.Text = "Update";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMinSpeend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 46)
            {

            }
            else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
