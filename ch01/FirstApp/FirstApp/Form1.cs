using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        bool toggle;
        public Form1()
        {
            InitializeComponent();
        }

        private void colorPickEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeBackColor();
        }

        private void ChangeBackColor()
        {
            if (toggle)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = Color.Blue;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                toggle ^= true;
                ChangeBackColor();
            }
        }
    }
}
