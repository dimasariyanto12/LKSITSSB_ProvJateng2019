using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PC_26_Module1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sideBar.Left = btnMenuCategory.Left;
            sideBar.Height = btnMenuCategory.Height;
            MenuCategory frm = new MenuCategory();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnMenuCategory_Click(object sender, EventArgs e)
        {
            sideBar.Left = btnMenuCategory.Left;
            sideBar.Height = btnMenuCategory.Height;
            MenuCategory frm = new MenuCategory();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnMEnu_Click(object sender, EventArgs e)
        {
            sideBar.Left = btnMEnu.Left;
            sideBar.Height = btnMEnu.Height;
            Menu frm = new Menu();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            sideBar.Left = btnPromotion.Left;
            sideBar.Height = btnPromotion.Height;
            PromotionForm frm = new PromotionForm();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
