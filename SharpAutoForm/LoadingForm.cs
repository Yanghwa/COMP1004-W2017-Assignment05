//FileName: LoadingForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Created On: 30/01/2017
//Copy Rights: Junghwan Yang
//Description: This app shows this application is loading now.
//            

/////////////////////////////////////////////////////////////////////////

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
    /// <summary>
    /// LoadingForm for showing now loading/splashed form
    /// </summary>
    public partial class LoadingForm : Form
    {
        //CONSTRUCTORS-------------
        public LoadingForm()
        {
            InitializeComponent();         
        }

        //PRIVATE METHODS - HANDLERS---------------------
        /// <summary>
        /// Event handler timer - After 2 seconds, splashed form disappears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadingTime_Tick(object sender, EventArgs e)
        {
            this.LoadingTime.Enabled = false;
            this.Close();
        }
    }
}
