namespace Project_PC_26_Module1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuCategory = new System.Windows.Forms.Button();
            this.btnMEnu = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.sideBar);
            this.panel1.Controls.Add(this.btnPromotion);
            this.panel1.Controls.Add(this.btnMEnu);
            this.panel1.Controls.Add(this.btnMenuCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnMenuCategory
            // 
            this.btnMenuCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenuCategory.FlatAppearance.BorderSize = 0;
            this.btnMenuCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCategory.ForeColor = System.Drawing.Color.White;
            this.btnMenuCategory.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCategory.Name = "btnMenuCategory";
            this.btnMenuCategory.Size = new System.Drawing.Size(161, 36);
            this.btnMenuCategory.TabIndex = 0;
            this.btnMenuCategory.Text = "MENU CATEGORY";
            this.btnMenuCategory.UseVisualStyleBackColor = true;
            this.btnMenuCategory.Click += new System.EventHandler(this.btnMenuCategory_Click);
            // 
            // btnMEnu
            // 
            this.btnMEnu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMEnu.FlatAppearance.BorderSize = 0;
            this.btnMEnu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMEnu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMEnu.ForeColor = System.Drawing.Color.White;
            this.btnMEnu.Location = new System.Drawing.Point(161, 0);
            this.btnMEnu.Name = "btnMEnu";
            this.btnMEnu.Size = new System.Drawing.Size(161, 36);
            this.btnMEnu.TabIndex = 1;
            this.btnMEnu.Text = "MENU";
            this.btnMEnu.UseVisualStyleBackColor = true;
            this.btnMEnu.Click += new System.EventHandler(this.btnMEnu_Click);
            // 
            // btnPromotion
            // 
            this.btnPromotion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPromotion.FlatAppearance.BorderSize = 0;
            this.btnPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromotion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotion.ForeColor = System.Drawing.Color.White;
            this.btnPromotion.Location = new System.Drawing.Point(322, 0);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(161, 36);
            this.btnPromotion.TabIndex = 2;
            this.btnPromotion.Text = "PROMOTION";
            this.btnPromotion.UseVisualStyleBackColor = true;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideBar.Location = new System.Drawing.Point(2, 31);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(159, 10);
            this.sideBar.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 36);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(829, 453);
            this.pnlMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 489);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esemka Resto";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnMEnu;
        private System.Windows.Forms.Button btnMenuCategory;
        private System.Windows.Forms.Panel pnlMain;
    }
}

