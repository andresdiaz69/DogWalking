namespace ECI.DogWalking.Forms.Shared
{
    partial class BaseForm
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
            pnlMenu = new Panel();
            linkLogout = new LinkLabel();
            lblUser = new Label();
            menuStrip1 = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            pnlMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(linkLogout);
            pnlMenu.Controls.Add(lblUser);
            pnlMenu.Controls.Add(menuStrip1);
            pnlMenu.Location = new Point(0, 1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(720, 53);
            pnlMenu.TabIndex = 1;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.Location = new Point(652, 26);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(45, 15);
            linkLogout.TabIndex = 1;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(566, 26);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(720, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(47, 20);
            usersToolStripMenuItem.Text = "Users";
            // 
            // BaseForm
            // 
            ClientSize = new Size(720, 480);
            Controls.Add(pnlMenu);
            MainMenuStrip = menuStrip1;
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECI Dog Walking";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private Label lblUser;
        private LinkLabel linkLogout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usersToolStripMenuItem;
    }
}