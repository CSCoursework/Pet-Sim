
namespace Tomagtachi
{
    partial class Game
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
            this.WritePoints = new System.Windows.Forms.Label();
            this.WriteLives = new System.Windows.Forms.Label();
            this.WriteHint = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WritePoints
            // 
            this.WritePoints.AutoSize = true;
            this.WritePoints.BackColor = System.Drawing.Color.Black;
            this.WritePoints.ForeColor = System.Drawing.Color.White;
            this.WritePoints.Location = new System.Drawing.Point(19, 53);
            this.WritePoints.Name = "WritePoints";
            this.WritePoints.Size = new System.Drawing.Size(50, 20);
            this.WritePoints.TabIndex = 8;
            this.WritePoints.Text = "label1";
            this.WritePoints.Click += new System.EventHandler(this.WritePoints_Click);
            // 
            // WriteLives
            // 
            this.WriteLives.AutoSize = true;
            this.WriteLives.BackColor = System.Drawing.Color.Black;
            this.WriteLives.ForeColor = System.Drawing.Color.White;
            this.WriteLives.Location = new System.Drawing.Point(14, 23);
            this.WriteLives.Name = "WriteLives";
            this.WriteLives.Size = new System.Drawing.Size(77, 20);
            this.WriteLives.TabIndex = 7;
            this.WriteLives.Text = "WriteLives";
            this.WriteLives.Click += new System.EventHandler(this.WriteLives_Click);
            // 
            // WriteHint
            // 
            this.WriteHint.AutoSize = true;
            this.WriteHint.BackColor = System.Drawing.Color.Black;
            this.WriteHint.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WriteHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(245)))), ((int)(((byte)(173)))));
            this.WriteHint.Location = new System.Drawing.Point(133, 19);
            this.WriteHint.Name = "WriteHint";
            this.WriteHint.Size = new System.Drawing.Size(232, 61);
            this.WriteHint.TabIndex = 6;
            this.WriteHint.Text = "WriteHint";
            this.WriteHint.Click += new System.EventHandler(this.WriteHint_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(33, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(396, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guess";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WriteLives);
            this.groupBox1.Controls.Add(this.WritePoints);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(628, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 169);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WriteHint);
            this.Controls.Add(this.textBox1);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WritePoints;
        private System.Windows.Forms.Label WriteLives;
        private System.Windows.Forms.Label WriteHint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}