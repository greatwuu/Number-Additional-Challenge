namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.answerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number1Box = new System.Windows.Forms.Label();
            this.number2Box = new System.Windows.Forms.Label();
            this.pointBox = new System.Windows.Forms.Label();
            this.timerBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewScoreRecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTimer
            // 
            this.formTimer.Enabled = true;
            this.formTimer.Interval = 1000;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // answerBox
            // 
            this.answerBox.AcceptsReturn = true;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.answerBox.Location = new System.Drawing.Point(36, 152);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(195, 31);
            this.answerBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer Additon";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Window;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Submit.Location = new System.Drawing.Point(43, 189);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(188, 34);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(38, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(184, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Point";
            // 
            // number1Box
            // 
            this.number1Box.AutoSize = true;
            this.number1Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.number1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.number1Box.Location = new System.Drawing.Point(60, 59);
            this.number1Box.Name = "number1Box";
            this.number1Box.Size = new System.Drawing.Size(55, 39);
            this.number1Box.TabIndex = 6;
            this.number1Box.Text = "00";
            // 
            // number2Box
            // 
            this.number2Box.AutoSize = true;
            this.number2Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.number2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.number2Box.Location = new System.Drawing.Point(60, 97);
            this.number2Box.Name = "number2Box";
            this.number2Box.Size = new System.Drawing.Size(55, 39);
            this.number2Box.TabIndex = 7;
            this.number2Box.Text = "00";
            // 
            // pointBox
            // 
            this.pointBox.AutoSize = true;
            this.pointBox.BackColor = System.Drawing.SystemColors.Info;
            this.pointBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pointBox.Location = new System.Drawing.Point(131, 64);
            this.pointBox.Name = "pointBox";
            this.pointBox.Size = new System.Drawing.Size(47, 33);
            this.pointBox.TabIndex = 8;
            this.pointBox.Text = "00";
            // 
            // timerBox
            // 
            this.timerBox.AutoSize = true;
            this.timerBox.BackColor = System.Drawing.SystemColors.Info;
            this.timerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.timerBox.Location = new System.Drawing.Point(139, 111);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(30, 24);
            this.timerBox.TabIndex = 9;
            this.timerBox.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(185, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewScoreRecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewScoreRecToolStripMenuItem
            // 
            this.viewScoreRecToolStripMenuItem.Name = "viewScoreRecToolStripMenuItem";
            this.viewScoreRecToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.viewScoreRecToolStripMenuItem.Text = "View Score Rec";
            this.viewScoreRecToolStripMenuItem.Click += new System.EventHandler(this.viewScoreRecToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(109, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "+";
            // 
            // Form1
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(278, 237);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.pointBox);
            this.Controls.Add(this.number2Box);
            this.Controls.Add(this.number1Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Number Addition Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer formTimer;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label number1Box;
        private System.Windows.Forms.Label number2Box;
        private System.Windows.Forms.Label pointBox;
        private System.Windows.Forms.Label timerBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewScoreRecToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}

