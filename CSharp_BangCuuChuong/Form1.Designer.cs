namespace CSharp_BangCuuChuong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labKQ = new Label();
            txtBCC = new TextBox();
            numBCC = new NumericUpDown();
            butKQ = new Button();
            tbSo = new TrackBar();
            labTrackBar = new Label();
            groupBox1 = new GroupBox();
            rad10 = new RadioButton();
            rad9 = new RadioButton();
            rad8 = new RadioButton();
            rad7 = new RadioButton();
            rad6 = new RadioButton();
            rad5 = new RadioButton();
            rad4 = new RadioButton();
            rad3 = new RadioButton();
            rad2 = new RadioButton();
            listBox1 = new ListBox();
            butRad = new Button();
            ((System.ComponentModel.ISupportInitialize)numBCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 48);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(326, 36);
            label1.TabIndex = 0;
            label1.Text = "Chọn bảng cửu chương";
            // 
            // labKQ
            // 
            labKQ.AutoSize = true;
            labKQ.Location = new Point(37, 281);
            labKQ.Name = "labKQ";
            labKQ.Size = new Size(129, 36);
            labKQ.TabIndex = 2;
            labKQ.Text = "Kết quả:";
            // 
            // txtBCC
            // 
            txtBCC.Location = new Point(364, 45);
            txtBCC.Name = "txtBCC";
            txtBCC.Size = new Size(97, 43);
            txtBCC.TabIndex = 3;
            // 
            // numBCC
            // 
            numBCC.Location = new Point(479, 46);
            numBCC.Name = "numBCC";
            numBCC.Size = new Size(120, 43);
            numBCC.TabIndex = 4;
            numBCC.ValueChanged += numBCC_ValueChanged;
            // 
            // butKQ
            // 
            butKQ.Location = new Point(619, 33);
            butKQ.Name = "butKQ";
            butKQ.Size = new Size(165, 65);
            butKQ.TabIndex = 5;
            butKQ.Text = "Show";
            butKQ.UseVisualStyleBackColor = true;
            butKQ.Click += butKQ_Click;
            // 
            // tbSo
            // 
            tbSo.LargeChange = 2;
            tbSo.Location = new Point(37, 233);
            tbSo.Name = "tbSo";
            tbSo.Size = new Size(505, 45);
            tbSo.TabIndex = 6;
            tbSo.Scroll += tbSo_Scroll;
            // 
            // labTrackBar
            // 
            labTrackBar.AutoSize = true;
            labTrackBar.Location = new Point(548, 233);
            labTrackBar.Name = "labTrackBar";
            labTrackBar.Size = new Size(0, 36);
            labTrackBar.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad10);
            groupBox1.Controls.Add(rad9);
            groupBox1.Controls.Add(rad8);
            groupBox1.Controls.Add(rad7);
            groupBox1.Controls.Add(rad6);
            groupBox1.Controls.Add(rad5);
            groupBox1.Controls.Add(rad4);
            groupBox1.Controls.Add(rad3);
            groupBox1.Controls.Add(rad2);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 108);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn bảng cửu chương";
            // 
            // rad10
            // 
            rad10.AutoSize = true;
            rad10.Location = new Point(508, 42);
            rad10.Name = "rad10";
            rad10.Size = new Size(65, 40);
            rad10.TabIndex = 9;
            rad10.TabStop = true;
            rad10.Text = "10";
            rad10.UseVisualStyleBackColor = true;
            // 
            // rad9
            // 
            rad9.AutoSize = true;
            rad9.Location = new Point(441, 42);
            rad9.Name = "rad9";
            rad9.Size = new Size(49, 40);
            rad9.TabIndex = 9;
            rad9.TabStop = true;
            rad9.Text = "9";
            rad9.UseVisualStyleBackColor = true;
            // 
            // rad8
            // 
            rad8.AutoSize = true;
            rad8.Location = new Point(371, 42);
            rad8.Name = "rad8";
            rad8.Size = new Size(49, 40);
            rad8.TabIndex = 9;
            rad8.TabStop = true;
            rad8.Text = "8";
            rad8.UseVisualStyleBackColor = true;
            // 
            // rad7
            // 
            rad7.AutoSize = true;
            rad7.Location = new Point(308, 42);
            rad7.Name = "rad7";
            rad7.Size = new Size(49, 40);
            rad7.TabIndex = 9;
            rad7.TabStop = true;
            rad7.Text = "7";
            rad7.UseVisualStyleBackColor = true;
            // 
            // rad6
            // 
            rad6.AutoSize = true;
            rad6.Location = new Point(239, 42);
            rad6.Name = "rad6";
            rad6.Size = new Size(49, 40);
            rad6.TabIndex = 9;
            rad6.TabStop = true;
            rad6.Text = "6";
            rad6.UseVisualStyleBackColor = true;
            // 
            // rad5
            // 
            rad5.AutoSize = true;
            rad5.Location = new Point(184, 42);
            rad5.Name = "rad5";
            rad5.Size = new Size(49, 40);
            rad5.TabIndex = 9;
            rad5.TabStop = true;
            rad5.Text = "5";
            rad5.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            rad4.AutoSize = true;
            rad4.Location = new Point(129, 42);
            rad4.Name = "rad4";
            rad4.Size = new Size(49, 40);
            rad4.TabIndex = 9;
            rad4.TabStop = true;
            rad4.Text = "4";
            rad4.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.Location = new Point(74, 42);
            rad3.Name = "rad3";
            rad3.Size = new Size(49, 40);
            rad3.TabIndex = 9;
            rad3.TabStop = true;
            rad3.Text = "3";
            rad3.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(19, 42);
            rad2.Name = "rad2";
            rad2.Size = new Size(49, 40);
            rad2.TabIndex = 9;
            rad2.TabStop = true;
            rad2.Text = "2";
            rad2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(251, 281);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(314, 179);
            listBox1.TabIndex = 10;
            // 
            // butRad
            // 
            butRad.Location = new Point(629, 129);
            butRad.Name = "butRad";
            butRad.Size = new Size(145, 63);
            butRad.TabIndex = 10;
            butRad.Text = "Show 2";
            butRad.UseVisualStyleBackColor = true;
            butRad.Click += butRad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 469);
            Controls.Add(butRad);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(labTrackBar);
            Controls.Add(tbSo);
            Controls.Add(butKQ);
            Controls.Add(numBCC);
            Controls.Add(txtBCC);
            Controls.Add(labKQ);
            Controls.Add(label1);
            Font = new Font("Tahoma", 22F);
            Margin = new Padding(8);
            Name = "Form1";
            Text = "CSHARP_BANGCUUCHUONG";
            ((System.ComponentModel.ISupportInitialize)numBCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labKQ;
        private TextBox txtBCC;
        private NumericUpDown numBCC;
        private Button butKQ;
        private TrackBar tbSo;
        private Label labTrackBar;
        private GroupBox groupBox1;
        private RadioButton rad10;
        private RadioButton rad9;
        private RadioButton rad8;
        private RadioButton rad7;
        private RadioButton rad6;
        private RadioButton rad5;
        private RadioButton rad4;
        private RadioButton rad3;
        private RadioButton rad2;
        private ListBox listBox1;
        private Button butRad;
    }
}
