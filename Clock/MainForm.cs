using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if(cdShowDate.Checked)
            {
                labelTime.Text += "\n" + DateTime.Now.ToString("dd MMMM, yyyy");
            }
            if(cbShowWeekDay.Checked)
            {
                labelTime.Text += "\n" + DateTime.Now.ToString("dddd");
            }
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {

        }
    }
}
