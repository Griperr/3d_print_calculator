using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3d_print_calculator
{
    public partial class PopUpForm : Form
    {
        public PopUpForm()
        {
            InitializeComponent();
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            labelCom.Text = Form1.massage;
        }
    }
}
