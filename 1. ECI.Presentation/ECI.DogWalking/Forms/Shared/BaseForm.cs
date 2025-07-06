namespace ECI.DogWalking.Forms.Shared
{
    using ECI.DogWalking.Forms.Admin;
    using ECI.DogWalking.Forms.Shared.Menu;
    using ECI.DogWalking.Forms.Walks;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class BaseForm : Form
    {
        private readonly IFormNavigator _formNavigator;
        
        public BaseForm(IFormNavigator _formNavigator)
        {
            InitializeComponent();
            _formNavigator = _formNavigator;
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
            
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formNavigator.OpenClientsForm();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        public void SetUserName(string userName)
        {
            lblUser.Text = $"Hello {userName}";
        }
    }
}
