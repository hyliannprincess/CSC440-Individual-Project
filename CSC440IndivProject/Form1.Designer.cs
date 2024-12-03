namespace CSC440IndivProject
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
            this.importGradesBttn = new System.Windows.Forms.Button();
            this.addGradeBttn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.crnAdd = new System.Windows.Forms.TextBox();
            this.gradeAdd = new System.Windows.Forms.TextBox();
            this.courseAddNum = new System.Windows.Forms.TextBox();
            this.coursePre = new System.Windows.Forms.TextBox();
            this.StuID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.deleteGradeIDSubmit = new System.Windows.Forms.Button();
            this.deleteIdTB = new System.Windows.Forms.TextBox();
            this.deleteIDLabel = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editSubmitButton = new System.Windows.Forms.Button();
            this.editLabel = new System.Windows.Forms.Label();
            this.studentIDEditBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.newGradeBox = new System.Windows.Forms.ComboBox();
            this.editBox = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gradesLabel = new System.Windows.Forms.Label();
            this.submitTranscript = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.transcriptTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // importGradesBttn
            // 
            this.importGradesBttn.Location = new System.Drawing.Point(679, 83);
            this.importGradesBttn.Name = "importGradesBttn";
            this.importGradesBttn.Size = new System.Drawing.Size(126, 50);
            this.importGradesBttn.TabIndex = 0;
            this.importGradesBttn.Text = "Import Grades";
            this.importGradesBttn.UseVisualStyleBackColor = true;
            this.importGradesBttn.Click += new System.EventHandler(this.importGrades_Click);
            // 
            // addGradeBttn
            // 
            this.addGradeBttn.Location = new System.Drawing.Point(679, 167);
            this.addGradeBttn.Name = "addGradeBttn";
            this.addGradeBttn.Size = new System.Drawing.Size(126, 51);
            this.addGradeBttn.TabIndex = 1;
            this.addGradeBttn.Text = "Add Grade";
            this.addGradeBttn.UseVisualStyleBackColor = true;
            this.addGradeBttn.Click += new System.EventHandler(this.addGrade_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(679, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Grade";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.editGrade_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Print Transcript";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.printTranscript_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.crnAdd);
            this.panel1.Controls.Add(this.gradeAdd);
            this.panel1.Controls.Add(this.courseAddNum);
            this.panel1.Controls.Add(this.coursePre);
            this.panel1.Controls.Add(this.StuID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(31, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 514);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(311, 348);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 36);
            this.button6.TabIndex = 18;
            this.button6.Text = "Submit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.submitNewGrade_Click);
            // 
            // crnAdd
            // 
            this.crnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crnAdd.Location = new System.Drawing.Point(155, 301);
            this.crnAdd.Name = "crnAdd";
            this.crnAdd.Size = new System.Drawing.Size(255, 22);
            this.crnAdd.TabIndex = 17;
            // 
            // gradeAdd
            // 
            this.gradeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeAdd.Location = new System.Drawing.Point(155, 253);
            this.gradeAdd.Name = "gradeAdd";
            this.gradeAdd.Size = new System.Drawing.Size(255, 22);
            this.gradeAdd.TabIndex = 16;
            // 
            // courseAddNum
            // 
            this.courseAddNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseAddNum.Location = new System.Drawing.Point(155, 195);
            this.courseAddNum.Name = "courseAddNum";
            this.courseAddNum.Size = new System.Drawing.Size(255, 22);
            this.courseAddNum.TabIndex = 15;
            // 
            // coursePre
            // 
            this.coursePre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursePre.Location = new System.Drawing.Point(155, 143);
            this.coursePre.Name = "coursePre";
            this.coursePre.Size = new System.Drawing.Size(255, 22);
            this.coursePre.TabIndex = 14;
            // 
            // StuID
            // 
            this.StuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuID.Location = new System.Drawing.Point(155, 88);
            this.StuID.Name = "StuID";
            this.StuID.Size = new System.Drawing.Size(255, 22);
            this.StuID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Course Prefix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Course Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "CRN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(606, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 435);
            this.panel2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.deleteGradeIDSubmit);
            this.panel6.Controls.Add(this.deleteIdTB);
            this.panel6.Controls.Add(this.deleteIDLabel);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.deleteBox);
            this.panel6.Location = new System.Drawing.Point(31, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 496);
            this.panel6.TabIndex = 3;
            // 
            // deleteGradeIDSubmit
            // 
            this.deleteGradeIDSubmit.Location = new System.Drawing.Point(332, 80);
            this.deleteGradeIDSubmit.Name = "deleteGradeIDSubmit";
            this.deleteGradeIDSubmit.Size = new System.Drawing.Size(75, 23);
            this.deleteGradeIDSubmit.TabIndex = 4;
            this.deleteGradeIDSubmit.Text = "Submit";
            this.deleteGradeIDSubmit.UseVisualStyleBackColor = true;
            this.deleteGradeIDSubmit.Click += new System.EventHandler(this.deleteGradeIDSubmit_Click_1);
            // 
            // deleteIdTB
            // 
            this.deleteIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIdTB.Location = new System.Drawing.Point(119, 50);
            this.deleteIdTB.Name = "deleteIdTB";
            this.deleteIdTB.Size = new System.Drawing.Size(288, 24);
            this.deleteIdTB.TabIndex = 3;
            this.deleteIdTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // deleteIDLabel
            // 
            this.deleteIDLabel.AutoSize = true;
            this.deleteIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIDLabel.Location = new System.Drawing.Point(22, 52);
            this.deleteIDLabel.Name = "deleteIDLabel";
            this.deleteIDLabel.Size = new System.Drawing.Size(91, 20);
            this.deleteIDLabel.TabIndex = 2;
            this.deleteIDLabel.Text = "Student ID:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(424, 397);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 36);
            this.button9.TabIndex = 1;
            this.button9.Text = "Delete Grade";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.deleteGradeSubmit_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.FormattingEnabled = true;
            this.deleteBox.Location = new System.Drawing.Point(26, 134);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(487, 251);
            this.deleteBox.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.editSubmitButton);
            this.panel4.Controls.Add(this.editLabel);
            this.panel4.Controls.Add(this.studentIDEditBox);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.editBox);
            this.panel4.Location = new System.Drawing.Point(25, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(554, 502);
            this.panel4.TabIndex = 23;
            // 
            // editSubmitButton
            // 
            this.editSubmitButton.Location = new System.Drawing.Point(416, 24);
            this.editSubmitButton.Name = "editSubmitButton";
            this.editSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.editSubmitButton.TabIndex = 5;
            this.editSubmitButton.Text = "Submit";
            this.editSubmitButton.UseVisualStyleBackColor = true;
            this.editSubmitButton.Click += new System.EventHandler(this.editSubmitButton_Click);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.Location = new System.Drawing.Point(27, 24);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(91, 20);
            this.editLabel.TabIndex = 4;
            this.editLabel.Text = "Student ID:";
            // 
            // studentIDEditBox
            // 
            this.studentIDEditBox.Location = new System.Drawing.Point(124, 24);
            this.studentIDEditBox.Name = "studentIDEditBox";
            this.studentIDEditBox.Size = new System.Drawing.Size(270, 20);
            this.studentIDEditBox.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.newGradeBox);
            this.panel5.Location = new System.Drawing.Point(31, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(431, 142);
            this.panel5.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "New Grade:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(165, 91);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 32);
            this.button8.TabIndex = 1;
            this.button8.Text = "Submit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // newGradeBox
            // 
            this.newGradeBox.FormattingEnabled = true;
            this.newGradeBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F",
            "I"});
            this.newGradeBox.Location = new System.Drawing.Point(118, 46);
            this.newGradeBox.Name = "newGradeBox";
            this.newGradeBox.Size = new System.Drawing.Size(129, 21);
            this.newGradeBox.TabIndex = 0;
            this.newGradeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editBox
            // 
            this.editBox.FormattingEnabled = true;
            this.editBox.Location = new System.Drawing.Point(31, 75);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(431, 225);
            this.editBox.TabIndex = 0;
            this.editBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.editBox.DoubleClick += new System.EventHandler(this.listBox1_DoubleCLick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.gradesLabel);
            this.panel7.Controls.Add(this.submitTranscript);
            this.panel7.Controls.Add(this.infoLabel);
            this.panel7.Controls.Add(this.transcriptTB);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(31, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(542, 490);
            this.panel7.TabIndex = 2;
            // 
            // gradesLabel
            // 
            this.gradesLabel.AutoSize = true;
            this.gradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesLabel.Location = new System.Drawing.Point(25, 166);
            this.gradesLabel.Name = "gradesLabel";
            this.gradesLabel.Size = new System.Drawing.Size(12, 18);
            this.gradesLabel.TabIndex = 26;
            this.gradesLabel.Text = " ";
            // 
            // submitTranscript
            // 
            this.submitTranscript.Location = new System.Drawing.Point(371, 43);
            this.submitTranscript.Name = "submitTranscript";
            this.submitTranscript.Size = new System.Drawing.Size(75, 26);
            this.submitTranscript.TabIndex = 25;
            this.submitTranscript.Text = "Submit";
            this.submitTranscript.UseVisualStyleBackColor = true;
            this.submitTranscript.Click += new System.EventHandler(this.submitTranscript_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(21, 114);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(177, 20);
            this.infoLabel.TabIndex = 24;
            this.infoLabel.Text = "Preview will appear here";
            // 
            // transcriptTB
            // 
            this.transcriptTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcriptTB.Location = new System.Drawing.Point(118, 43);
            this.transcriptTB.Name = "transcriptTB";
            this.transcriptTB.Size = new System.Drawing.Size(216, 26);
            this.transcriptTB.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Student ID:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(679, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "Delete Grade";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.deleteGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(973, 623);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addGradeBttn);
            this.Controls.Add(this.importGradesBttn);
            this.Name = "Form1";
            this.Text = "Grade System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importGradesBttn;
        private System.Windows.Forms.Button addGradeBttn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox crnAdd;
        private System.Windows.Forms.TextBox gradeAdd;
        private System.Windows.Forms.TextBox StuID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox editBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox newGradeBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox deleteBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox transcriptTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox courseAddNum;
        private System.Windows.Forms.TextBox coursePre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button submitTranscript;
        private System.Windows.Forms.Label gradesLabel;
        private System.Windows.Forms.TextBox deleteIdTB;
        private System.Windows.Forms.Label deleteIDLabel;
        private System.Windows.Forms.Button deleteGradeIDSubmit;
        private System.Windows.Forms.Button editSubmitButton;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.TextBox studentIDEditBox;
    }
}

