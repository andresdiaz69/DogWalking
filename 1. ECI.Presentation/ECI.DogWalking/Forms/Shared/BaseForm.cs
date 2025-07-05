using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECI.DogWalking.Forms.Shared
{
    public partial class BaseForm: Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit(); // o redirigir al LoginForm
        }
    }
}
