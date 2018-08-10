namespace HangmanWithUI
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
            this.displayWord = new System.Windows.Forms.Label();
            this.tbxGuess = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.displayWrongGuess = new System.Windows.Forms.Label();
            this.lblHangman = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // displayWord
            // 
            this.displayWord.AutoSize = true;
            this.displayWord.BackColor = System.Drawing.SystemColors.Control;
            this.displayWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWord.Location = new System.Drawing.Point(130, 503);
            this.displayWord.Name = "displayWord";
            this.displayWord.Size = new System.Drawing.Size(324, 25);
            this.displayWord.TabIndex = 0;
            this.displayWord.Text = "__________________________";
            // 
            // tbxGuess
            // 
            this.tbxGuess.Location = new System.Drawing.Point(39, 508);
            this.tbxGuess.MaxLength = 1;
            this.tbxGuess.Name = "tbxGuess";
            this.tbxGuess.Size = new System.Drawing.Size(59, 20);
            this.tbxGuess.TabIndex = 1;
            this.tbxGuess.TextChanged += new System.EventHandler(this.tbxGuess_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(39, 539);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(58, 25);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // displayWrongGuess
            // 
            this.displayWrongGuess.AutoSize = true;
            this.displayWrongGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWrongGuess.Location = new System.Drawing.Point(130, 536);
            this.displayWrongGuess.Name = "displayWrongGuess";
            this.displayWrongGuess.Size = new System.Drawing.Size(324, 25);
            this.displayWrongGuess.TabIndex = 3;
            this.displayWrongGuess.Text = "__________________________";
            // 
            // lblHangman
            // 
            this.lblHangman.AutoSize = true;
            this.lblHangman.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHangman.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangman.Location = new System.Drawing.Point(203, 106);
            this.lblHangman.Name = "lblHangman";
            this.lblHangman.Size = new System.Drawing.Size(121, 304);
            this.lblHangman.TabIndex = 4;
            this.lblHangman.Text = " @\r\n \\|/\r\n  |\r\n / \\";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(135, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 334);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 608);
            this.Controls.Add(this.lblHangman);
            this.Controls.Add(this.displayWrongGuess);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbxGuess);
            this.Controls.Add(this.displayWord);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayWord;
        private System.Windows.Forms.TextBox tbxGuess;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label displayWrongGuess;
        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Panel panel1;
    }
}

