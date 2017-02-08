using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm
{
    public partial class LoadingForm : Form
    {
        public Form previousForm = new Form();
        public LoadingForm()
        {
            InitializeComponent();         
        }

        private void LoadingTime_Tick(object sender, EventArgs e)
        {
            this.Hide();
            this.LoadingTime.Enabled = false;
        }
    }
}
