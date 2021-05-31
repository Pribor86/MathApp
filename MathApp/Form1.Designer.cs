
using System;

namespace MathApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Сheck = new System.Windows.Forms.Button();
            this.label_Number1 = new System.Windows.Forms.Label();
            this.label_Znak = new System.Windows.Forms.Label();
            this.label_Number2 = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_Check_Answer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summDiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1_1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1_10_Multiply = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1_100_Multiply = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1_1000_Multiply = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1_Answer_True = new System.Windows.Forms.PictureBox();
            this.pictureBox1_Answer_False = new System.Windows.Forms.PictureBox();
            this.label_Answer = new System.Windows.Forms.Label();
            this.label_Mistake = new System.Windows.Forms.Label();
            this.CheckMultiDiv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Answer_True)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Answer_False)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реши пример";
            // 
            // button_Сheck
            // 
            this.button_Сheck.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_Сheck.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_Сheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Сheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Сheck.Location = new System.Drawing.Point(369, 398);
            this.button_Сheck.Name = "button_Сheck";
            this.button_Сheck.Size = new System.Drawing.Size(162, 40);
            this.button_Сheck.TabIndex = 1;
            this.button_Сheck.Text = "Проверить";
            this.button_Сheck.UseVisualStyleBackColor = false;
            this.button_Сheck.Click += new System.EventHandler(this.button_Сheck_Click_1);
            // 
            // label_Number1
            // 
            this.label_Number1.AutoSize = true;
            this.label_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number1.Location = new System.Drawing.Point(40, 125);
            this.label_Number1.Name = "label_Number1";
            this.label_Number1.Size = new System.Drawing.Size(41, 25);
            this.label_Number1.TabIndex = 2;
            this.label_Number1.Text = "N1";
            // 
            // label_Znak
            // 
            this.label_Znak.AutoSize = true;
            this.label_Znak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Znak.Location = new System.Drawing.Point(81, 125);
            this.label_Znak.Name = "label_Znak";
            this.label_Znak.Size = new System.Drawing.Size(67, 25);
            this.label_Znak.TabIndex = 3;
            this.label_Znak.Text = "+/-/%";
            // 
            // label_Number2
            // 
            this.label_Number2.AutoSize = true;
            this.label_Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number2.Location = new System.Drawing.Point(128, 125);
            this.label_Number2.Name = "label_Number2";
            this.label_Number2.Size = new System.Drawing.Size(41, 25);
            this.label_Number2.TabIndex = 4;
            this.label_Number2.Text = "N2";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Answer.Location = new System.Drawing.Point(259, 125);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(162, 31);
            this.textBox_Answer.TabIndex = 5;
            this.textBox_Answer.Text = "Введи ответ";
            this.textBox_Answer.Click += new System.EventHandler(this.textBox_Answer_TextChanged);
            this.textBox_Answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Answer_KeyPress);
            // 
            // label_Check_Answer
            // 
            this.label_Check_Answer.AutoSize = true;
            this.label_Check_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Check_Answer.Location = new System.Drawing.Point(198, 323);
            this.label_Check_Answer.Name = "label_Check_Answer";
            this.label_Check_Answer.Size = new System.Drawing.Size(67, 20);
            this.label_Check_Answer.TabIndex = 6;
            this.label_Check_Answer.Text = "Ответ:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summDiffToolStripMenuItem,
            this.multiToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // summDiffToolStripMenuItem
            // 
            this.summDiffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_1_10,
            this.toolStripMenuItem_1_100,
            this.toolStripMenuItem_1_1000});
            this.summDiffToolStripMenuItem.Name = "summDiffToolStripMenuItem";
            this.summDiffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.summDiffToolStripMenuItem.Text = "Summ/Diff";
            // 
            // toolStripMenuItem_1_10
            // 
            this.toolStripMenuItem_1_10.Name = "toolStripMenuItem_1_10";
            this.toolStripMenuItem_1_10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_1_10.Text = "1 - 10";
            this.toolStripMenuItem_1_10.Click += new System.EventHandler(this.toolStripMenuItem_1_10_Click);
            // 
            // toolStripMenuItem_1_100
            // 
            this.toolStripMenuItem_1_100.Enabled = false;
            this.toolStripMenuItem_1_100.Name = "toolStripMenuItem_1_100";
            this.toolStripMenuItem_1_100.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_1_100.Text = "1 - 100";
            this.toolStripMenuItem_1_100.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem_1_1000
            // 
            this.toolStripMenuItem_1_1000.Enabled = false;
            this.toolStripMenuItem_1_1000.Name = "toolStripMenuItem_1_1000";
            this.toolStripMenuItem_1_1000.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_1_1000.Text = "1 - 1000";
            // 
            // multiToolStripMenuItem
            // 
            this.multiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_1_10_Multiply,
            this.toolStripMenuItem_1_100_Multiply,
            this.toolStripMenuItem_1_1000_Multiply});
            this.multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            this.multiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiToolStripMenuItem.Text = "Multi/Div";
            // 
            // toolStripMenuItem_1_10_Multiply
            // 
            this.toolStripMenuItem_1_10_Multiply.Name = "toolStripMenuItem_1_10_Multiply";
            this.toolStripMenuItem_1_10_Multiply.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_1_10_Multiply.Text = "1 - 10";
            // 
            // toolStripMenuItem_1_100_Multiply
            // 
            this.toolStripMenuItem_1_100_Multiply.Enabled = false;
            this.toolStripMenuItem_1_100_Multiply.Name = "toolStripMenuItem_1_100_Multiply";
            this.toolStripMenuItem_1_100_Multiply.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_1_100_Multiply.Text = "1 - 100";
            // 
            // toolStripMenuItem_1_1000_Multiply
            // 
            this.toolStripMenuItem_1_1000_Multiply.Enabled = false;
            this.toolStripMenuItem_1_1000_Multiply.Name = "toolStripMenuItem_1_1000_Multiply";
            this.toolStripMenuItem_1_1000_Multiply.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_1_1000_Multiply.Text = "1 - 1000";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // pictureBox1_Answer_True
            // 
            this.pictureBox1_Answer_True.ErrorImage = global::MathApp.Properties.Resources.AnswerPicture;
            this.pictureBox1_Answer_True.Image = global::MathApp.Properties.Resources.AnswerPicture;
            this.pictureBox1_Answer_True.InitialImage = global::MathApp.Properties.Resources.AnswerPicture;
            this.pictureBox1_Answer_True.Location = new System.Drawing.Point(27, 205);
            this.pictureBox1_Answer_True.Name = "pictureBox1_Answer_True";
            this.pictureBox1_Answer_True.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1_Answer_True.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_Answer_True.TabIndex = 10;
            this.pictureBox1_Answer_True.TabStop = false;
            // 
            // pictureBox1_Answer_False
            // 
            this.pictureBox1_Answer_False.ErrorImage = global::MathApp.Properties.Resources.MistakePicture;
            this.pictureBox1_Answer_False.Image = global::MathApp.Properties.Resources.MistakePicture;
            this.pictureBox1_Answer_False.InitialImage = global::MathApp.Properties.Resources.MistakePicture;
            this.pictureBox1_Answer_False.Location = new System.Drawing.Point(27, 244);
            this.pictureBox1_Answer_False.Name = "pictureBox1_Answer_False";
            this.pictureBox1_Answer_False.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1_Answer_False.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_Answer_False.TabIndex = 11;
            this.pictureBox1_Answer_False.TabStop = false;
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Answer.Location = new System.Drawing.Point(71, 216);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(21, 24);
            this.label_Answer.TabIndex = 12;
            this.label_Answer.Text = "0";
            // 
            // label_Mistake
            // 
            this.label_Mistake.AutoSize = true;
            this.label_Mistake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mistake.Location = new System.Drawing.Point(71, 255);
            this.label_Mistake.Name = "label_Mistake";
            this.label_Mistake.Size = new System.Drawing.Size(21, 24);
            this.label_Mistake.TabIndex = 13;
            this.label_Mistake.Text = "0";
            // 
            // CheckMultiDiv
            // 
            this.CheckMultiDiv.AutoSize = true;
            this.CheckMultiDiv.Location = new System.Drawing.Point(24, 414);
            this.CheckMultiDiv.Name = "CheckMultiDiv";
            this.CheckMultiDiv.Size = new System.Drawing.Size(35, 13);
            this.CheckMultiDiv.TabIndex = 14;
            this.CheckMultiDiv.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Debugging";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckMultiDiv);
            this.Controls.Add(this.label_Mistake);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.pictureBox1_Answer_False);
            this.Controls.Add(this.pictureBox1_Answer_True);
            this.Controls.Add(this.label_Check_Answer);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.label_Number2);
            this.Controls.Add(this.label_Znak);
            this.Controls.Add(this.label_Number1);
            this.Controls.Add(this.button_Сheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MathApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Answer_True)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Answer_False)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox_Answer_TextChanged(object sender, EventArgs e)
        {
            this.textBox_Answer.Text = String.Empty;
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Сheck;
        private System.Windows.Forms.Label label_Number1;
        private System.Windows.Forms.Label label_Znak;
        private System.Windows.Forms.Label label_Number2;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_Check_Answer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summDiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1_10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1_100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1_1000;
        private System.Windows.Forms.ToolStripMenuItem multiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1_10_Multiply;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1_100_Multiply;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1_1000_Multiply;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1_Answer_True;
        private System.Windows.Forms.PictureBox pictureBox1_Answer_False;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.Label label_Mistake;
        private System.Windows.Forms.Label CheckMultiDiv;
        private System.Windows.Forms.Label label2;
    }
}

