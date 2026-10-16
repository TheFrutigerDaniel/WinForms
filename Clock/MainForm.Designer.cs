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
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(56, 47);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(379, 69);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Current Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cdShowDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 599);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekDay);
            this.Controls.Add(this.cdShowDate);
            this.Controls.Add(this.labelTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Clock P418";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cdShowDate;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.Button btnHideControls;
    }
}

