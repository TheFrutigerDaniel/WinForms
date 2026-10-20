namespace Clock
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cdShowDate = new System.Windows.Forms.CheckBox();
            this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.clockontext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDayOfTheWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockontext.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(502, 250);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Current Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cdShowDate
            // 
            this.cdShowDate.AutoSize = true;
            this.cdShowDate.Location = new System.Drawing.Point(30, 295);
            this.cdShowDate.Margin = new System.Windows.Forms.Padding(6);
            this.cdShowDate.Name = "cdShowDate";
            this.cdShowDate.Size = new System.Drawing.Size(170, 36);
            this.cdShowDate.TabIndex = 1;
            this.cdShowDate.Text = "Show date";
            this.cdShowDate.UseVisualStyleBackColor = true;
            // 
            // cbShowWeekDay
            // 
            this.cbShowWeekDay.AutoSize = true;
            this.cbShowWeekDay.Location = new System.Drawing.Point(30, 343);
            this.cbShowWeekDay.Margin = new System.Windows.Forms.Padding(6);
            this.cbShowWeekDay.Name = "cbShowWeekDay";
            this.cbShowWeekDay.Size = new System.Drawing.Size(311, 36);
            this.cbShowWeekDay.TabIndex = 2;
            this.cbShowWeekDay.Text = "Show day of the week";
            this.cbShowWeekDay.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.Location = new System.Drawing.Point(30, 423);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(449, 164);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide Controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // clockontext
            // 
            this.clockontext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clockontext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDateToolStripMenuItem,
            this.showDayOfTheWeekToolStripMenuItem,
            this.hideControlsToolStripMenuItem,
            this.showControlsToolStripMenuItem});
            this.clockontext.Name = "clockontext";
            this.clockontext.Size = new System.Drawing.Size(224, 100);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.CheckOnClick = true;
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.showDateToolStripMenuItem.Text = "Show date";
            this.showDateToolStripMenuItem.Click += new System.EventHandler(this.showDateToolStripMenuItem_Click);
            // 
            // showDayOfTheWeekToolStripMenuItem
            // 
            this.showDayOfTheWeekToolStripMenuItem.CheckOnClick = true;
            this.showDayOfTheWeekToolStripMenuItem.Name = "showDayOfTheWeekToolStripMenuItem";
            this.showDayOfTheWeekToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.showDayOfTheWeekToolStripMenuItem.Text = "Show day of the week";
            this.showDayOfTheWeekToolStripMenuItem.Click += new System.EventHandler(this.showDayOfTheWeekToolStripMenuItem_Click);
            // 
            // hideControlsToolStripMenuItem
            // 
            this.hideControlsToolStripMenuItem.Name = "hideControlsToolStripMenuItem";
            this.hideControlsToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.hideControlsToolStripMenuItem.Text = "Hide controls";
            this.hideControlsToolStripMenuItem.Click += new System.EventHandler(this.hideControlsToolStripMenuItem_Click);
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            this.showControlsToolStripMenuItem.Click += new System.EventHandler(this.showControlsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 593);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekDay);
            this.Controls.Add(this.cdShowDate);
            this.Controls.Add(this.labelTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Clock P418";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.clockontext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cdShowDate;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.ContextMenuStrip clockontext;
        private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDayOfTheWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
    }
}

