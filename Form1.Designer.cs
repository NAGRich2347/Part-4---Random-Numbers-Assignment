namespace Part_4___Random_Numbers_Assignment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Please enter a minimum and maximum value:";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMinimum
            // 
            this.txtMinimum.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMinimum.Location = new System.Drawing.Point(12, 53);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 20);
            this.txtMinimum.TabIndex = 1;
            this.txtMinimum.TextChanged += new System.EventHandler(this.txtMinimum_TextChanged_1);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.BackColor = System.Drawing.Color.Silver;
            this.lblMinimum.Location = new System.Drawing.Point(12, 37);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(78, 13);
            this.lblMinimum.TabIndex = 2;
            this.lblMinimum.Text = "Minimum Value";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.BackColor = System.Drawing.Color.Silver;
            this.lblMaximum.Location = new System.Drawing.Point(12, 86);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(81, 13);
            this.lblMaximum.TabIndex = 3;
            this.lblMaximum.Text = "Maximum Value";
            this.lblMaximum.Click += new System.EventHandler(this.lblMaximum_Click);
            // 
            // txtMaximum
            // 
            this.txtMaximum.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMaximum.Location = new System.Drawing.Point(12, 103);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(100, 20);
            this.txtMaximum.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Crimson;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(134, 32);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(173, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit (Int)";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.DimGray;
            this.txtOutput.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(134, 86);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(173, 37);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.Crimson;
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.ForeColor = System.Drawing.Color.Black;
            this.btnDouble.Location = new System.Drawing.Point(134, 57);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(173, 23);
            this.btnDouble.TabIndex = 7;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(319, 135);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDouble;
    }
}

