using PayamHannan.Arian.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arian.CN.STR.WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var CN = new ConnectionStringOption();
            CN.DataSource = ".";
            CN.InitialCatalog = "Northwind";
            CN.Password = "1234";
            CN.UserID = "sa";
            var STR = CN.ToString();
        }
    }
}
