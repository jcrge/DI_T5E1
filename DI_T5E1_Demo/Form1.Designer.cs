namespace DI_T5E1_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInvertOrientation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLastPressedKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUpdatedText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSeparation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPasswordChar = new System.Windows.Forms.TextBox();
            this.buttonChangePasswordChar = new System.Windows.Forms.Button();
            this.buttonChangeSeparation = new System.Windows.Forms.Button();
            this.textBoxSeparation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTextBox1 = new DI_T5E1.LabelTextBox();
            this.SuspendLayout();
            // 
            // buttonInvertOrientation
            // 
            this.buttonInvertOrientation.Location = new System.Drawing.Point(18, 38);
            this.buttonInvertOrientation.Name = "buttonInvertOrientation";
            this.buttonInvertOrientation.Size = new System.Drawing.Size(167, 23);
            this.buttonInvertOrientation.TabIndex = 1;
            this.buttonInvertOrientation.Text = "Invert Orientation";
            this.buttonInvertOrientation.UseVisualStyleBackColor = true;
            this.buttonInvertOrientation.Click += new System.EventHandler(this.buttonInvertOrientation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last pressed key:";
            // 
            // labelLastPressedKey
            // 
            this.labelLastPressedKey.AutoSize = true;
            this.labelLastPressedKey.Location = new System.Drawing.Point(111, 73);
            this.labelLastPressedKey.Name = "labelLastPressedKey";
            this.labelLastPressedKey.Size = new System.Drawing.Size(13, 13);
            this.labelLastPressedKey.TabIndex = 3;
            this.labelLastPressedKey.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text updates:";
            // 
            // labelUpdatedText
            // 
            this.labelUpdatedText.AutoEllipsis = true;
            this.labelUpdatedText.Location = new System.Drawing.Point(93, 97);
            this.labelUpdatedText.Name = "labelUpdatedText";
            this.labelUpdatedText.Size = new System.Drawing.Size(95, 13);
            this.labelUpdatedText.TabIndex = 5;
            this.labelUpdatedText.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Separation updates:";
            // 
            // labelSeparation
            // 
            this.labelSeparation.AutoSize = true;
            this.labelSeparation.Location = new System.Drawing.Point(123, 120);
            this.labelSeparation.Name = "labelSeparation";
            this.labelSeparation.Size = new System.Drawing.Size(13, 13);
            this.labelSeparation.TabIndex = 7;
            this.labelSeparation.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PasswordChar:";
            // 
            // textBoxPasswordChar
            // 
            this.textBoxPasswordChar.Location = new System.Drawing.Point(99, 142);
            this.textBoxPasswordChar.Name = "textBoxPasswordChar";
            this.textBoxPasswordChar.Size = new System.Drawing.Size(25, 20);
            this.textBoxPasswordChar.TabIndex = 9;
            // 
            // buttonChangePasswordChar
            // 
            this.buttonChangePasswordChar.Location = new System.Drawing.Point(130, 140);
            this.buttonChangePasswordChar.Name = "buttonChangePasswordChar";
            this.buttonChangePasswordChar.Size = new System.Drawing.Size(55, 23);
            this.buttonChangePasswordChar.TabIndex = 10;
            this.buttonChangePasswordChar.Text = "Apply";
            this.buttonChangePasswordChar.UseVisualStyleBackColor = true;
            this.buttonChangePasswordChar.Click += new System.EventHandler(this.buttonChangePasswordChar_Click);
            // 
            // buttonChangeSeparation
            // 
            this.buttonChangeSeparation.Location = new System.Drawing.Point(130, 170);
            this.buttonChangeSeparation.Name = "buttonChangeSeparation";
            this.buttonChangeSeparation.Size = new System.Drawing.Size(55, 23);
            this.buttonChangeSeparation.TabIndex = 13;
            this.buttonChangeSeparation.Text = "Apply";
            this.buttonChangeSeparation.UseVisualStyleBackColor = true;
            this.buttonChangeSeparation.Click += new System.EventHandler(this.buttonChangeSeparation_Click);
            // 
            // textBoxSeparation
            // 
            this.textBoxSeparation.Location = new System.Drawing.Point(99, 172);
            this.textBoxSeparation.Name = "textBoxSeparation";
            this.textBoxSeparation.Size = new System.Drawing.Size(25, 20);
            this.textBoxSeparation.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Separation:";
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.LabelText = "Text";
            this.labelTextBox1.Location = new System.Drawing.Point(18, 12);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Orientation = DI_T5E1.OrientationType.Left;
            this.labelTextBox1.PasswordChar = '\0';
            this.labelTextBox1.Separation = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(68, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextBoxText = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 202);
            this.Controls.Add(this.buttonChangeSeparation);
            this.Controls.Add(this.textBoxSeparation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonChangePasswordChar);
            this.Controls.Add(this.textBoxPasswordChar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSeparation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUpdatedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLastPressedKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInvertOrientation);
            this.Controls.Add(this.labelTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::DI_T5E1.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button buttonInvertOrientation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLastPressedKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUpdatedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSeparation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPasswordChar;
        private System.Windows.Forms.Button buttonChangePasswordChar;
        private System.Windows.Forms.Button buttonChangeSeparation;
        private System.Windows.Forms.TextBox textBoxSeparation;
        private System.Windows.Forms.Label label5;
    }
}

