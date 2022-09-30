namespace Loginform
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffManagemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_logout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinksManagementToolStripMenuItem,
            this.staffManagemntToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.toolStripMenuItem1.Text = "Beecoffee ";
            // 
            // drinksManagementToolStripMenuItem
            // 
            this.drinksManagementToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.drinksManagementToolStripMenuItem.Name = "drinksManagementToolStripMenuItem";
            this.drinksManagementToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.drinksManagementToolStripMenuItem.Text = "Drinks management";
            this.drinksManagementToolStripMenuItem.Click += new System.EventHandler(this.drinksManagementToolStripMenuItem_Click);
            // 
            // staffManagemntToolStripMenuItem
            // 
            this.staffManagemntToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.staffManagemntToolStripMenuItem.Name = "staffManagemntToolStripMenuItem";
            this.staffManagemntToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.staffManagemntToolStripMenuItem.Text = "Staff managemnt";
            this.staffManagemntToolStripMenuItem.Click += new System.EventHandler(this.staffManagemntToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.userManagementToolStripMenuItem.Text = "User management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(252, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tb_logout
            // 
            this.tb_logout.BackColor = System.Drawing.Color.Red;
            this.tb_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_logout.Location = new System.Drawing.Point(423, 354);
            this.tb_logout.Name = "tb_logout";
            this.tb_logout.Size = new System.Drawing.Size(134, 46);
            this.tb_logout.TabIndex = 3;
            this.tb_logout.Text = "Log out";
            this.tb_logout.UseVisualStyleBackColor = false;
            this.tb_logout.Click += new System.EventHandler(this.tb_logout_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loginform.Properties.Resources.a7066ffa8525afcbc6db9d73ab2c035d1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_logout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem drinksManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffManagemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tb_logout;
    }
}