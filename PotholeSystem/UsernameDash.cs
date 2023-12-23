using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotholeSystem
{
    public partial class dashbr : Form
    {
        public dashbr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashbr exit = new dashbr();
            exit.Close();
        }
    }
}
