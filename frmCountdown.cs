using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionCountdown
{
    public partial class frmCountdown : Form
    {

        public frmCountdown()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;
            DateTime secondDate = new DateTime(2020, 11, 03);

            var diff = (secondDate - today).TotalDays.ToString();
            txtCountdown.Text = diff;
        }
    }
}
