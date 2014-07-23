using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrift_tutorial_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            int arg1 = int.Parse(textBoxArg1.Text);
            int arg2 = int.Parse(textBoxArg2.Text);
        }
    }
}
