using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lab8Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// Constructor for Lab8Form
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the Submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength > 0 || AgeTextBox.TextLength > 0)
            {
                UserName = NameTextBox.Text;
                UserAge = float.Parse(AgeTextBox.Text);
            }
            else
            {
                SubmitButton.Enabled = false;
            }
            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            NameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
        }
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }


    }
}
