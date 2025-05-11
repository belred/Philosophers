namespace Philosophers
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.trackBarThread1 = new System.Windows.Forms.TrackBar();
            this.trackBarThread2 = new System.Windows.Forms.TrackBar();
            this.trackBarThread3 = new System.Windows.Forms.TrackBar();
            this.trackBarThread4 = new System.Windows.Forms.TrackBar();
            this.trackBarThread5 = new System.Windows.Forms.TrackBar();
            this.labelPh1 = new System.Windows.Forms.Label();
            this.labelPh3 = new System.Windows.Forms.Label();
            this.labelPh4 = new System.Windows.Forms.Label();
            this.labelPh5 = new System.Windows.Forms.Label();
            this.labelPh2 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonScript1 = new System.Windows.Forms.Button();
            this.buttonScript2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(19, 24);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(603, 59);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(193, 435);
            this.textBoxInfo.TabIndex = 10;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(275, 24);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "останов";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStopThread1_Click);
            // 
            // trackBarThread1
            // 
            this.trackBarThread1.Location = new System.Drawing.Point(12, 310);
            this.trackBarThread1.Maximum = 10000;
            this.trackBarThread1.Minimum = 5000;
            this.trackBarThread1.Name = "trackBarThread1";
            this.trackBarThread1.Size = new System.Drawing.Size(117, 45);
            this.trackBarThread1.TabIndex = 12;
            this.trackBarThread1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThread1.Value = 7500;
            this.trackBarThread1.Scroll += new System.EventHandler(this.trackBarThread1_Scroll);
            // 
            // trackBarThread2
            // 
            this.trackBarThread2.Location = new System.Drawing.Point(44, 90);
            this.trackBarThread2.Maximum = 12000;
            this.trackBarThread2.Minimum = 7000;
            this.trackBarThread2.Name = "trackBarThread2";
            this.trackBarThread2.Size = new System.Drawing.Size(117, 45);
            this.trackBarThread2.TabIndex = 13;
            this.trackBarThread2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThread2.Value = 9500;
            this.trackBarThread2.Scroll += new System.EventHandler(this.trackBarThread2_Scroll);
            // 
            // trackBarThread3
            // 
            this.trackBarThread3.Location = new System.Drawing.Point(432, 70);
            this.trackBarThread3.Maximum = 14000;
            this.trackBarThread3.Minimum = 9000;
            this.trackBarThread3.Name = "trackBarThread3";
            this.trackBarThread3.Size = new System.Drawing.Size(117, 45);
            this.trackBarThread3.TabIndex = 14;
            this.trackBarThread3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThread3.Value = 11500;
            this.trackBarThread3.Scroll += new System.EventHandler(this.trackBarThread3_Scroll);
            // 
            // trackBarThread4
            // 
            this.trackBarThread4.Location = new System.Drawing.Point(449, 436);
            this.trackBarThread4.Maximum = 16000;
            this.trackBarThread4.Minimum = 11000;
            this.trackBarThread4.Name = "trackBarThread4";
            this.trackBarThread4.Size = new System.Drawing.Size(117, 45);
            this.trackBarThread4.TabIndex = 15;
            this.trackBarThread4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThread4.Value = 13500;
            this.trackBarThread4.Scroll += new System.EventHandler(this.trackBarThread4_Scroll);
            // 
            // trackBarThread5
            // 
            this.trackBarThread5.Location = new System.Drawing.Point(187, 479);
            this.trackBarThread5.Maximum = 18000;
            this.trackBarThread5.Minimum = 13000;
            this.trackBarThread5.Name = "trackBarThread5";
            this.trackBarThread5.Size = new System.Drawing.Size(117, 45);
            this.trackBarThread5.TabIndex = 16;
            this.trackBarThread5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThread5.Value = 15500;
            this.trackBarThread5.Scroll += new System.EventHandler(this.trackBarThread5_Scroll);
            // 
            // labelPh1
            // 
            this.labelPh1.AutoSize = true;
            this.labelPh1.Location = new System.Drawing.Point(16, 358);
            this.labelPh1.Name = "labelPh1";
            this.labelPh1.Size = new System.Drawing.Size(65, 13);
            this.labelPh1.TabIndex = 18;
            this.labelPh1.Text = "Философ 1";
            // 
            // labelPh3
            // 
            this.labelPh3.AutoSize = true;
            this.labelPh3.Location = new System.Drawing.Point(514, 112);
            this.labelPh3.Name = "labelPh3";
            this.labelPh3.Size = new System.Drawing.Size(65, 13);
            this.labelPh3.TabIndex = 19;
            this.labelPh3.Text = "Философ 3";
            // 
            // labelPh4
            // 
            this.labelPh4.AutoSize = true;
            this.labelPh4.Location = new System.Drawing.Point(434, 479);
            this.labelPh4.Name = "labelPh4";
            this.labelPh4.Size = new System.Drawing.Size(65, 13);
            this.labelPh4.TabIndex = 20;
            this.labelPh4.Text = "Философ 4";
            // 
            // labelPh5
            // 
            this.labelPh5.AutoSize = true;
            this.labelPh5.Location = new System.Drawing.Point(134, 454);
            this.labelPh5.Name = "labelPh5";
            this.labelPh5.Size = new System.Drawing.Size(65, 13);
            this.labelPh5.TabIndex = 21;
            this.labelPh5.Text = "Философ 5";
            // 
            // labelPh2
            // 
            this.labelPh2.AutoSize = true;
            this.labelPh2.Location = new System.Drawing.Point(109, 70);
            this.labelPh2.Name = "labelPh2";
            this.labelPh2.Size = new System.Drawing.Size(65, 13);
            this.labelPh2.TabIndex = 17;
            this.labelPh2.Text = "Философ 2";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(147, 24);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 22;
            this.buttonPause.Text = "пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonScript1
            // 
            this.buttonScript1.Location = new System.Drawing.Point(414, 24);
            this.buttonScript1.Name = "buttonScript1";
            this.buttonScript1.Size = new System.Drawing.Size(152, 23);
            this.buttonScript1.TabIndex = 23;
            this.buttonScript1.Text = "голодная смерть";
            this.buttonScript1.UseVisualStyleBackColor = true;
            this.buttonScript1.Click += new System.EventHandler(this.buttonScript1_Click);
            // 
            // buttonScript2
            // 
            this.buttonScript2.Location = new System.Drawing.Point(603, 24);
            this.buttonScript2.Name = "buttonScript2";
            this.buttonScript2.Size = new System.Drawing.Size(152, 23);
            this.buttonScript2.TabIndex = 24;
            this.buttonScript2.Text = "заговор соседей";
            this.buttonScript2.UseVisualStyleBackColor = true;
            this.buttonScript2.Click += new System.EventHandler(this.buttonScript2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 129);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "быстрее   медленнее";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "быстрее   медленнее";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "быстрее   медленнее";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "быстрее   медленнее";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "быстрее   медленнее";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonScript2);
            this.Controls.Add(this.buttonScript1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelPh5);
            this.Controls.Add(this.labelPh4);
            this.Controls.Add(this.labelPh3);
            this.Controls.Add(this.labelPh1);
            this.Controls.Add(this.labelPh2);
            this.Controls.Add(this.trackBarThread5);
            this.Controls.Add(this.trackBarThread4);
            this.Controls.Add(this.trackBarThread3);
            this.Controls.Add(this.trackBarThread2);
            this.Controls.Add(this.trackBarThread1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThread5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar trackBarThread1;
        private System.Windows.Forms.TrackBar trackBarThread2;
        private System.Windows.Forms.TrackBar trackBarThread3;
        private System.Windows.Forms.TrackBar trackBarThread4;
        private System.Windows.Forms.TrackBar trackBarThread5;
        private System.Windows.Forms.Label labelPh1;
        private System.Windows.Forms.Label labelPh3;
        private System.Windows.Forms.Label labelPh4;
        private System.Windows.Forms.Label labelPh5;
        private System.Windows.Forms.Label labelPh2;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonScript1;
        private System.Windows.Forms.Button buttonScript2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

