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
            this.StartPosition = FormStartPosition.Manual;
            var screenArea = Screen.FromControl(this).WorkingArea;
            this.Location = new Point(screenArea.Right - this.Width, screenArea.Top);
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
            cbShowWeekDay.Visible = false;
            cdShowDate.Visible = false;
            btnHideControls.Visible = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = this.BackColor;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            cbShowWeekDay.Visible = true;
            cdShowDate.Visible = true;
            btnHideControls.Visible = true;
            this.ShowInTaskbar = true;
            this.TransparencyKey = Color.Empty; 
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
