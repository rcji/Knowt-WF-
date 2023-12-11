using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowt_WF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type commands here.", "Terminal");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            string PreviewText = richTextBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string CurrentText = richTextBox2.Text + "\n";
                PreviewText = PreviewText + CurrentText;
                richTextBox2.Clear();
                richTextBox1.Text = PreviewText;
            }
        }

        
    }
}
