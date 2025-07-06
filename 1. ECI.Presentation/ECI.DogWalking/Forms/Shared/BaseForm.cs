namespace ECI.DogWalking.Forms.Shared
{
    using ECI.DogWalking.Forms.Admin;
    using ECI.DogWalking.Forms.Shared.Menu;
    using ECI.DogWalking.Forms.Walks;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    public partial class BaseForm : Form
    {
        private readonly IFormNavigator _formNavigator;      

        public BaseForm(IFormNavigator formNavigator)
        {
            InitializeComponent();
            _formNavigator = formNavigator;
        }

        protected BaseForm()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                InitializeComponent();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _formNavigator.OpenWalksForm();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _formNavigator.OpenClientsForm();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _formNavigator.LogOut();
        }
    }
}
