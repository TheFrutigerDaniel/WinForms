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

        private void labelTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clockontext.Show(labelTime, e.Location);
            }
        }

        private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdShowDate.Checked = showDateToolStripMenuItem.Checked;
        }

        private void showDayOfTheWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbShowWeekDay.Checked = showDayOfTheWeekToolStripMenuItem.Checked;
        }
        
        private void showDayOfTheWeekToolStripMenuItem_Checked(object sender, EventArgs e)
        {
            labelTime.Text += "\n" + DateTime.Now.ToString("dddd");
        }


        private void hideControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllowTransparency = true;
            cbShowWeekDay.Visible = false;
            cdShowDate.Visible = false;
            btnHideControls.Visible = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = this.BackColor;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void showControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbShowWeekDay.Visible = true;
            cdShowDate.Visible = true;
            btnHideControls.Visible = true;
            this.ShowInTaskbar = true;
            AllowTransparency = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
