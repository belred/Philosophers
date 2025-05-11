namespace FirstTask
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelThread1 = new System.Windows.Forms.Label();
            this.labelThread2 = new System.Windows.Forms.Label();
            this.buttonStartThread1 = new System.Windows.Forms.Button();
            this.buttonStartThread2 = new System.Windows.Forms.Button();
            this.buttonStopThread1 = new System.Windows.Forms.Button();
            this.buttonStopThread2 = new System.Windows.Forms.Button();
            this.buttonGlobalStop = new System.Windows.Forms.Button();
            this.textBoxThread1 = new System.Windows.Forms.TextBox();
            this.textBoxThread2 = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.trackBarThread1 = new System.Windows.Forms.TrackBar();
            this.trackBarThread2 = new System.Windows.Forms.TrackBar();
            this.labelTask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelThread1
            // 
            this.labelThread1.AutoSize = true;
            this.labelThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread1.Location = new System.Drawing.Point(24, 91);
            this.labelThread1.Name = "labelThread1";
            this.labelThread1.Size = new System.Drawing.Size(60, 17);
            this.labelThread1.TabIndex = 0;
            this.labelThread1.Text = "Поток 1";
            // 
            // labelThread2
            // 
            this.labelThread2.AutoSize = true;
            this.labelThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread2.Location = new System.Drawing.Point(231, 91);
            this.labelThread2.Name = "labelThread2";
            this.labelThread2.Size = new System.Drawing.Size(60, 17);
            this.labelThread2.TabIndex = 1;
            this.labelThread2.Text = "Поток 2";
            // 
            // buttonStartThread1
            // 
            this.buttonStartThread1.Location = new System.Drawing.Point(52, 502);
            this.buttonStartThread1.Name = "buttonStartThread1";
            this.buttonStartThread1.Size = new System.Drawing.Size(75, 23);
            this.buttonStartThread1.TabIndex = 2;
            this.buttonStartThread1.Text = "Запуск";
            this.buttonStartThread1.UseVisualStyleBackColor = true;
            this.buttonStartThread1.Click += new System.EventHandler(this.buttonStartThread1_Click);
            // 
            // buttonStartThread2
            // 
            this.buttonStartThread2.Location = new System.Drawing.Point(269, 502);
            this.buttonStartThread2.Name = "buttonStartThread2";
            this.buttonStartThread2.Size = new System.Drawing.Size(75, 23);
            this.buttonStartThread2.TabIndex = 3;
            this.buttonStartThread2.Text = "Запуск";
            this.buttonStartThread2.UseVisualStyleBackColor = true;
            this.buttonStartThread2.Click += new System.EventHandler(this.buttonStartThread2_Click);
            // 
            // buttonStopThread1
            // 
            this.buttonStopThread1.Location = new System.Drawing.Point(52, 540);
            this.buttonStopThread1.Name = "buttonStopThread1";
            this.buttonStopThread1.Size = new System.Drawing.Size(75, 23);
            this.buttonStopThread1.TabIndex = 4;
            this.buttonStopThread1.Text = "Пауза";
            this.buttonStopThread1.UseVisualStyleBackColor = true;
            this.buttonStopThread1.Click += new System.EventHandler(this.buttonStopThread1_Click);
            // 
            // buttonStopThread2
            // 
            this.buttonStopThread2.Location = new System.Drawing.Point(269, 540);
            this.buttonStopThread2.Name = "buttonStopThread2";
            this.buttonStopThread2.Size = new System.Drawing.Size(75, 23);
            this.buttonStopThread2.TabIndex = 5;
            this.buttonStopThread2.Text = "Пауза";
            this.buttonStopThread2.UseVisualStyleBackColor = true;
            this.buttonStopThread2.Click += new System.EventHandler(this.buttonStopThread2_Click);
            // 
            // buttonGlobalStop
            // 
            this.buttonGlobalStop.Location = new System.Drawing.Point(162, 540);
            this.buttonGlobalStop.Name = "buttonGlobalStop";
            this.buttonGlobalStop.Size = new System.Drawing.Size(75, 23);
            this.buttonGlobalStop.TabIndex = 6;
            this.buttonGlobalStop.Text = "Останов";
            this.buttonGlobalStop.UseVisualStyleBackColor = true;
            this.buttonGlobalStop.Click += new System.EventHandler(this.buttonGlobalStop_Click);
            // 
            // textBoxThread1
            // 
            this.textBoxThread1.Location = new System.Drawing.Point(27, 117);
            this.textBoxThread1.Multiline = true;
            this.textBoxThread1.Name = "textBoxThread1";
            this.textBoxThread1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxThread1.Size = new System.Drawing.Size(128, 305);
            this.textBoxThread1.TabIndex = 7;
            // 
            // textBoxThread2
            // 
            this.textBoxThread2.Location = new System.Drawing.Point(234, 117);
            this.textBoxThread2.Multiline = true;
            this.textBoxThread2.Name = "textBoxThread2";
            this.textBoxThread2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxThread2.Size = new System.Drawing.Size(128, 305);
            this.textBoxThread2.TabIndex = 8;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(486, 90);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(249, 435);
            this.textBoxInfo.TabIndex = 9;
            // 
            // trackBarThread1
            // 
            this.trackBarThread1.Location = new System.Drawing.Point(3, 442);
            this.trackBarThread1.Maximum = 1000;
            this.trackBarThread1.Minimum = 500;
            this.trackBarThread1.Name = "trackBarThread1";
            this.trackBarThread1.Size = new System.Drawing.Size(167, 45);
            this.trackBarThread1.TabIndex = 10;
            this.trackBarThread1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThread1.Value = 750;
            this.trackBarThread1.Scroll += new System.EventHandler(this.trackBarThread1_Scroll);
            // 
            // trackBarThread2
            // 
            this.trackBarThread2.Location = new System.Drawing.Point(218, 442);
            this.trackBarThread2.Maximum = 1000;
            this.trackBarThread2.Minimum = 500;
            this.trackBarThread2.Name = "trackBarThread2";
            this.trackBarThread2.Size = new System.Drawing.Size(167, 45);
            this.trackBarThread2.TabIndex = 11;
            this.trackBarThread2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThread2.Value = 750;
            this.trackBarThread2.Scroll += new System.EventHandler(this.trackBarThread2_Scroll);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(20, 15);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(768, 51);
            this.labelTask.TabIndex = 12;
            this.labelTask.Text = resources.GetString("labelTask.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "быстрее               медленнее";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "быстрее               медленнее";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.trackBarThread2);
            this.Controls.Add(this.trackBarThread1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxThread2);
            this.Controls.Add(this.textBoxThread1);
            this.Controls.Add(this.buttonGlobalStop);
            this.Controls.Add(this.buttonStopThread2);
            this.Controls.Add(this.buttonStopThread1);
            this.Controls.Add(this.buttonStartThread2);
            this.Controls.Add(this.buttonStartThread1);
            this.Controls.Add(this.labelThread2);
            this.Controls.Add(this.labelThread1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThread1;
        private System.Windows.Forms.Label labelThread2;
        private System.Windows.Forms.Button buttonStartThread1;
        private System.Windows.Forms.Button buttonStartThread2;
        private System.Windows.Forms.Button buttonStopThread1;
        private System.Windows.Forms.Button buttonStopThread2;
        private System.Windows.Forms.Button buttonGlobalStop;
        private System.Windows.Forms.TextBox textBoxThread1;
        private System.Windows.Forms.TextBox textBoxThread2;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TrackBar trackBarThread1;
        private System.Windows.Forms.TrackBar trackBarThread2;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

