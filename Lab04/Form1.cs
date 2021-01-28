using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Lab04 : Form
    {
        public Lab04()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Lab04_Bai01 bai1 = new Lab04_Bai01();
            bai1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Lab04_Bai02 bai2 = new Lab04_Bai02();
            bai2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab04_Bai03 bai3 = new Lab04_Bai03();
            bai3.Show();
        }
    }
}
