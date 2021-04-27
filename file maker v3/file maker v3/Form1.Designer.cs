namespace file_maker_v3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.specialNum = new System.Windows.Forms.Button();
            this.endNum = new System.Windows.Forms.NumericUpDown();
            this.startNum = new System.Windows.Forms.NumericUpDown();
            this.extTxt = new System.Windows.Forms.TextBox();
            this.exportLoc = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.RichTextBox();
            this.creatBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.specialNum1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.browseButtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.completeLbl = new System.Windows.Forms.Label();
            this.firstbtn = new System.Windows.Forms.RadioButton();
            this.endbtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.endNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ending number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Starting number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "File extentsion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Output location";
            // 
            // specialNum
            // 
            this.specialNum.Location = new System.Drawing.Point(624, 207);
            this.specialNum.Name = "specialNum";
            this.specialNum.Size = new System.Drawing.Size(75, 23);
            this.specialNum.TabIndex = 19;
            this.specialNum.Text = "§";
            this.specialNum.UseVisualStyleBackColor = true;
            this.specialNum.Click += new System.EventHandler(this.specialNum_Click_1);
            // 
            // endNum
            // 
            this.endNum.Location = new System.Drawing.Point(621, 296);
            this.endNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.endNum.Name = "endNum";
            this.endNum.Size = new System.Drawing.Size(120, 20);
            this.endNum.TabIndex = 18;
            // 
            // startNum
            // 
            this.startNum.Location = new System.Drawing.Point(621, 270);
            this.startNum.Name = "startNum";
            this.startNum.Size = new System.Drawing.Size(120, 20);
            this.startNum.TabIndex = 17;
            // 
            // extTxt
            // 
            this.extTxt.Location = new System.Drawing.Point(613, 58);
            this.extTxt.Name = "extTxt";
            this.extTxt.Size = new System.Drawing.Size(100, 20);
            this.extTxt.TabIndex = 16;
            // 
            // exportLoc
            // 
            this.exportLoc.Location = new System.Drawing.Point(28, 35);
            this.exportLoc.Name = "exportLoc";
            this.exportLoc.Size = new System.Drawing.Size(398, 20);
            this.exportLoc.TabIndex = 15;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(28, 81);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(479, 413);
            this.textInput.TabIndex = 14;
            this.textInput.Text = "";
            // 
            // creatBtn
            // 
            this.creatBtn.Location = new System.Drawing.Point(132, 602);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(101, 37);
            this.creatBtn.TabIndex = 13;
            this.creatBtn.Text = "Create Files";
            this.creatBtn.UseVisualStyleBackColor = true;
            this.creatBtn.Click += new System.EventHandler(this.creatBtn_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Location = new System.Drawing.Point(598, 602);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(101, 37);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Filename";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(613, 104);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 25;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(537, 422);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(263, 45);
            this.numLength.TabIndex = 26;
            this.numLength.Value = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(781, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "10";
            // 
            // specialNum1
            // 
            this.specialNum1.Location = new System.Drawing.Point(96, 21);
            this.specialNum1.Name = "specialNum1";
            this.specialNum1.Size = new System.Drawing.Size(75, 23);
            this.specialNum1.TabIndex = 29;
            this.specialNum1.Text = "µ";
            this.specialNum1.UseVisualStyleBackColor = true;
            this.specialNum1.Click += new System.EventHandler(this.specialNum1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.specialNum1);
            this.groupBox1.Location = new System.Drawing.Point(528, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 154);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special character 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Special character 1";
            // 
            // browseButtn
            // 
            this.browseButtn.Location = new System.Drawing.Point(443, 31);
            this.browseButtn.Name = "browseButtn";
            this.browseButtn.Size = new System.Drawing.Size(75, 23);
            this.browseButtn.TabIndex = 32;
            this.browseButtn.Text = "Browse";
            this.browseButtn.UseVisualStyleBackColor = true;
            this.browseButtn.Click += new System.EventHandler(this.browseButtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Input Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "number of pre-leading zeros";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 513);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(476, 23);
            this.progressBar1.TabIndex = 34;
            // 
            // completeLbl
            // 
            this.completeLbl.AutoSize = true;
            this.completeLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.completeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.completeLbl.Location = new System.Drawing.Point(233, 516);
            this.completeLbl.Name = "completeLbl";
            this.completeLbl.Size = new System.Drawing.Size(67, 17);
            this.completeLbl.TabIndex = 35;
            this.completeLbl.Text = "Complete";
            this.completeLbl.Visible = false;
            // 
            // firstbtn
            // 
            this.firstbtn.AutoSize = true;
            this.firstbtn.Location = new System.Drawing.Point(613, 142);
            this.firstbtn.Name = "firstbtn";
            this.firstbtn.Size = new System.Drawing.Size(108, 17);
            this.firstbtn.TabIndex = 36;
            this.firstbtn.Text = "begin of file name";
            this.firstbtn.UseVisualStyleBackColor = true;
            // 
            // endbtn
            // 
            this.endbtn.AutoSize = true;
            this.endbtn.Checked = true;
            this.endbtn.Location = new System.Drawing.Point(613, 166);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(100, 17);
            this.endbtn.TabIndex = 37;
            this.endbtn.TabStop = true;
            this.endbtn.Text = "end of file name";
            this.endbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(817, 676);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.firstbtn);
            this.Controls.Add(this.completeLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.browseButtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specialNum);
            this.Controls.Add(this.endNum);
            this.Controls.Add(this.startNum);
            this.Controls.Add(this.extTxt);
            this.Controls.Add(this.exportLoc);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.creatBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "File Maker";
            ((System.ComponentModel.ISupportInitialize)(this.endNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button specialNum;
        private System.Windows.Forms.NumericUpDown endNum;
        private System.Windows.Forms.NumericUpDown startNum;
        private System.Windows.Forms.TextBox extTxt;
        private System.Windows.Forms.TextBox exportLoc;
        private System.Windows.Forms.RichTextBox textInput;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TrackBar numLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button specialNum1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button browseButtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label completeLbl;
        private System.Windows.Forms.RadioButton firstbtn;
        private System.Windows.Forms.RadioButton endbtn;
    }
}

