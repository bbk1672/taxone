namespace TAX
{
    partial class Taxcalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.โสด = new System.Windows.Forms.RadioButton();
            this.สมรสรายได้ = new System.Windows.Forms.RadioButton();
            this.สมรสไม่มีรายได้ = new System.Windows.Forms.RadioButton();
            this.หย่า = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.บิดา = new System.Windows.Forms.CheckBox();
            this.มารดา = new System.Windows.Forms.CheckBox();
            this.บิดา2 = new System.Windows.Forms.CheckBox();
            this.มารดา2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.เดือน = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ปี = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ภาษี = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.บ60 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.บ61 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.พิการ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.คลอด = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.คลอด)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรมคำนวณลดหย่อนภาษี";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // โสด
            // 
            this.โสด.AutoSize = true;
            this.โสด.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.โสด.Location = new System.Drawing.Point(671, 113);
            this.โสด.Name = "โสด";
            this.โสด.Size = new System.Drawing.Size(45, 20);
            this.โสด.TabIndex = 1;
            this.โสด.TabStop = true;
            this.โสด.Text = "โสด";
            this.โสด.UseVisualStyleBackColor = true;
            // 
            // สมรสรายได้
            // 
            this.สมรสรายได้.AutoSize = true;
            this.สมรสรายได้.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.สมรสรายได้.Location = new System.Drawing.Point(671, 136);
            this.สมรสรายได้.Name = "สมรสรายได้";
            this.สมรสรายได้.Size = new System.Drawing.Size(96, 20);
            this.สมรสรายได้.TabIndex = 2;
            this.สมรสรายได้.TabStop = true;
            this.สมรสรายได้.Text = "คู่สมรสมีรายได้";
            this.สมรสรายได้.UseVisualStyleBackColor = true;
            // 
            // สมรสไม่มีรายได้
            // 
            this.สมรสไม่มีรายได้.AutoSize = true;
            this.สมรสไม่มีรายได้.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.สมรสไม่มีรายได้.Location = new System.Drawing.Point(671, 159);
            this.สมรสไม่มีรายได้.Name = "สมรสไม่มีรายได้";
            this.สมรสไม่มีรายได้.Size = new System.Drawing.Size(108, 20);
            this.สมรสไม่มีรายได้.TabIndex = 3;
            this.สมรสไม่มีรายได้.TabStop = true;
            this.สมรสไม่มีรายได้.Text = "คู่สมรสไม่มีรายได้";
            this.สมรสไม่มีรายได้.UseVisualStyleBackColor = true;
            // 
            // หย่า
            // 
            this.หย่า.AutoSize = true;
            this.หย่า.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.หย่า.Location = new System.Drawing.Point(671, 182);
            this.หย่า.Name = "หย่า";
            this.หย่า.Size = new System.Drawing.Size(62, 20);
            this.หย่า.TabIndex = 4;
            this.หย่า.TabStop = true;
            this.หย่า.Text = "หย่าร้าง";
            this.หย่า.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "สถานะภาพการสมรส";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prompt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(273, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "การอุปการะเลี้ยงดูอายุ 60 ปีขึ้นไป \r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // บิดา
            // 
            this.บิดา.AutoSize = true;
            this.บิดา.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.บิดา.Location = new System.Drawing.Point(314, 141);
            this.บิดา.Name = "บิดา";
            this.บิดา.Size = new System.Drawing.Size(46, 20);
            this.บิดา.TabIndex = 8;
            this.บิดา.Text = "บิดา";
            this.บิดา.UseVisualStyleBackColor = true;
            // 
            // มารดา
            // 
            this.มารดา.AutoSize = true;
            this.มารดา.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.มารดา.Location = new System.Drawing.Point(314, 167);
            this.มารดา.Name = "มารดา";
            this.มารดา.Size = new System.Drawing.Size(57, 20);
            this.มารดา.TabIndex = 9;
            this.มารดา.Text = "มารดา";
            this.มารดา.UseVisualStyleBackColor = true;
            // 
            // บิดา2
            // 
            this.บิดา2.AutoSize = true;
            this.บิดา2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.บิดา2.Location = new System.Drawing.Point(314, 193);
            this.บิดา2.Name = "บิดา2";
            this.บิดา2.Size = new System.Drawing.Size(80, 20);
            this.บิดา2.TabIndex = 10;
            this.บิดา2.Text = "บิดาคู่สมรส";
            this.บิดา2.UseVisualStyleBackColor = true;
            // 
            // มารดา2
            // 
            this.มารดา2.AutoSize = true;
            this.มารดา2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.มารดา2.Location = new System.Drawing.Point(314, 219);
            this.มารดา2.Name = "มารดา2";
            this.มารดา2.Size = new System.Drawing.Size(91, 20);
            this.มารดา2.TabIndex = 11;
            this.มารดา2.Text = "มารดาคู่สมรส";
            this.มารดา2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prompt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "รายได้และภาษี";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "รายได้ต่อเดือน";
            // 
            // เดือน
            // 
            this.เดือน.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.เดือน.Location = new System.Drawing.Point(12, 141);
            this.เดือน.Name = "เดือน";
            this.เดือน.Size = new System.Drawing.Size(127, 20);
            this.เดือน.TabIndex = 14;
            this.เดือน.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "รายได้ต่อปี";
            // 
            // ปี
            // 
            this.ปี.Location = new System.Drawing.Point(12, 193);
            this.ปี.Name = "ปี";
            this.ปี.Size = new System.Drawing.Size(127, 20);
            this.ปี.TabIndex = 16;
            this.ปี.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "ภาษีที่ต้องจ่าย";
            // 
            // ภาษี
            // 
            this.ภาษี.Location = new System.Drawing.Point(12, 254);
            this.ภาษี.Name = "ภาษี";
            this.ภาษี.Size = new System.Drawing.Size(127, 20);
            this.ภาษี.TabIndex = 18;
            this.ภาษี.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Prompt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "บุตรและอุปการะคนพิการ";
            // 
            // บ60
            // 
            this.บ60.Location = new System.Drawing.Point(314, 297);
            this.บ60.Name = "บ60";
            this.บ60.Size = new System.Drawing.Size(127, 20);
            this.บ60.TabIndex = 20;
            this.บ60.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "บุตรที่เกิดก่อน พ.ศ.2561";
            // 
            // บ61
            // 
            this.บ61.Location = new System.Drawing.Point(314, 323);
            this.บ61.Name = "บ61";
            this.บ61.Size = new System.Drawing.Size(127, 20);
            this.บ61.TabIndex = 22;
            this.บ61.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(447, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "บุตรที่เกิดหลัง พ.ศ.2561";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "ค่าฝากครรภ์และคลอดบุตร";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(314, 375);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(127, 20);
            this.textBox7.TabIndex = 26;
            this.textBox7.Text = "0";
            // 
            // พิการ
            // 
            this.พิการ.AutoSize = true;
            this.พิการ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.พิการ.Location = new System.Drawing.Point(447, 377);
            this.พิการ.Name = "พิการ";
            this.พิการ.Size = new System.Drawing.Size(101, 18);
            this.พิการ.TabIndex = 27;
            this.พิการ.Text = "อุปการะคนพิการ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Prompt ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(20, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 51);
            this.button1.TabIndex = 28;
            this.button1.Text = "คำนวณ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(274, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "(หากไม่มีไม่ต้องเลือกตัวเลือกใดๆ)";
            // 
            // คลอด
            // 
            this.คลอด.Location = new System.Drawing.Point(314, 349);
            this.คลอด.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.คลอด.Name = "คลอด";
            this.คลอด.Size = new System.Drawing.Size(127, 20);
            this.คลอด.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 10, 17, 36, 30, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Itim", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "โปรแกรมโดยเสี่ยบูม";
            // 
            // Taxcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.คลอด);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.พิการ);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.บ61);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.บ60);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ภาษี);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ปี);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.เดือน);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.มารดา2);
            this.Controls.Add(this.บิดา2);
            this.Controls.Add(this.มารดา);
            this.Controls.Add(this.บิดา);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.หย่า);
            this.Controls.Add(this.สมรสไม่มีรายได้);
            this.Controls.Add(this.สมรสรายได้);
            this.Controls.Add(this.โสด);
            this.Controls.Add(this.label1);
            this.Name = "Taxcalculator";
            this.Text = "Taxcalculator";
            ((System.ComponentModel.ISupportInitialize)(this.คลอด)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton โสด;
        private System.Windows.Forms.RadioButton สมรสรายได้;
        private System.Windows.Forms.RadioButton สมรสไม่มีรายได้;
        private System.Windows.Forms.RadioButton หย่า;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox บิดา;
        private System.Windows.Forms.CheckBox มารดา;
        private System.Windows.Forms.CheckBox บิดา2;
        private System.Windows.Forms.CheckBox มารดา2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox เดือน;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ปี;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ภาษี;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox บ60;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox บ61;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label พิการ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown คลอด;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
    }
}

