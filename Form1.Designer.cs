namespace thrift_tutorial_csharp
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
            this.textBoxArg1 = new System.Windows.Forms.TextBox();
            this.textBoxArg2 = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdejmij = new System.Windows.Forms.Button();
            this.buttonDziel = new System.Windows.Forms.Button();
            this.buttonMnoz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWynikResult = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxArg1
            // 
            this.textBoxArg1.Location = new System.Drawing.Point(52, 13);
            this.textBoxArg1.Name = "textBoxArg1";
            this.textBoxArg1.Size = new System.Drawing.Size(80, 20);
            this.textBoxArg1.TabIndex = 0;
            // 
            // textBoxArg2
            // 
            this.textBoxArg2.Location = new System.Drawing.Point(195, 12);
            this.textBoxArg2.Name = "textBoxArg2";
            this.textBoxArg2.Size = new System.Drawing.Size(77, 20);
            this.textBoxArg2.TabIndex = 1;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(13, 59);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(119, 30);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "+";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            // 
            // buttonOdejmij
            // 
            this.buttonOdejmij.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdejmij.Location = new System.Drawing.Point(154, 59);
            this.buttonOdejmij.Name = "buttonOdejmij";
            this.buttonOdejmij.Size = new System.Drawing.Size(118, 30);
            this.buttonOdejmij.TabIndex = 3;
            this.buttonOdejmij.Text = "-";
            this.buttonOdejmij.UseVisualStyleBackColor = true;
            // 
            // buttonDziel
            // 
            this.buttonDziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDziel.Location = new System.Drawing.Point(154, 120);
            this.buttonDziel.Name = "buttonDziel";
            this.buttonDziel.Size = new System.Drawing.Size(118, 30);
            this.buttonDziel.TabIndex = 5;
            this.buttonDziel.Text = "/";
            this.buttonDziel.UseVisualStyleBackColor = true;
            // 
            // buttonMnoz
            // 
            this.buttonMnoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMnoz.Location = new System.Drawing.Point(13, 120);
            this.buttonMnoz.Name = "buttonMnoz";
            this.buttonMnoz.Size = new System.Drawing.Size(119, 30);
            this.buttonMnoz.TabIndex = 4;
            this.buttonMnoz.Text = "*";
            this.buttonMnoz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "arg1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "arg2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wynik:";
            // 
            // labelWynikResult
            // 
            this.labelWynikResult.AutoSize = true;
            this.labelWynikResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynikResult.Location = new System.Drawing.Point(154, 206);
            this.labelWynikResult.Name = "labelWynikResult";
            this.labelWynikResult.Size = new System.Drawing.Size(0, 20);
            this.labelWynikResult.TabIndex = 9;
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(154, 260);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(116, 23);
            this.buttonOblicz.TabIndex = 10;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.labelWynikResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDziel);
            this.Controls.Add(this.buttonMnoz);
            this.Controls.Add(this.buttonOdejmij);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxArg2);
            this.Controls.Add(this.textBoxArg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArg1;
        private System.Windows.Forms.TextBox textBoxArg2;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdejmij;
        private System.Windows.Forms.Button buttonDziel;
        private System.Windows.Forms.Button buttonMnoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWynikResult;
        private System.Windows.Forms.Button buttonOblicz;
    }
}

