namespace appCriptografia
{
    partial class frmHash
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
            this.label3 = new System.Windows.Forms.Label();
            this.SHA1 = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SHA256 = new System.Windows.Forms.TextBox();
            this.SHA384 = new System.Windows.Forms.TextBox();
            this.SHA512 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MD5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SALT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CIFRADO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(177, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "SHA1";
            // 
            // SHA1
            // 
            this.SHA1.Location = new System.Drawing.Point(12, 160);
            this.SHA1.Multiline = true;
            this.SHA1.Name = "SHA1";
            this.SHA1.Size = new System.Drawing.Size(383, 100);
            this.SHA1.TabIndex = 11;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(31, 69);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(244, 28);
            this.txtMensaje.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(295, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "ENCRIPTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SHA256
            // 
            this.SHA256.Location = new System.Drawing.Point(405, 160);
            this.SHA256.Multiline = true;
            this.SHA256.Name = "SHA256";
            this.SHA256.Size = new System.Drawing.Size(383, 100);
            this.SHA256.TabIndex = 14;
            // 
            // SHA384
            // 
            this.SHA384.Location = new System.Drawing.Point(12, 282);
            this.SHA384.Multiline = true;
            this.SHA384.Name = "SHA384";
            this.SHA384.Size = new System.Drawing.Size(383, 100);
            this.SHA384.TabIndex = 15;
            // 
            // SHA512
            // 
            this.SHA512.Location = new System.Drawing.Point(405, 282);
            this.SHA512.Multiline = true;
            this.SHA512.Name = "SHA512";
            this.SHA512.Size = new System.Drawing.Size(383, 100);
            this.SHA512.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(566, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "SHA256";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Brown;
            this.label15.Location = new System.Drawing.Point(557, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "SHA512";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(168, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "SHA384";
            // 
            // MD5
            // 
            this.MD5.Location = new System.Drawing.Point(405, 37);
            this.MD5.Multiline = true;
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(383, 100);
            this.MD5.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(557, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "MD5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(28, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "MENSAJE";
            // 
            // SALT
            // 
            this.SALT.Location = new System.Drawing.Point(31, 117);
            this.SALT.Name = "SALT";
            this.SALT.Size = new System.Drawing.Size(244, 20);
            this.SALT.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(28, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "SALT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(12, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(417, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "MENSAJE CIFRADO HASH(SALT + MD5(CONTRASEÑA))";
            // 
            // CIFRADO
            // 
            this.CIFRADO.Location = new System.Drawing.Point(12, 422);
            this.CIFRADO.Multiline = true;
            this.CIFRADO.Name = "CIFRADO";
            this.CIFRADO.Size = new System.Drawing.Size(776, 44);
            this.CIFRADO.TabIndex = 26;
            // 
            // frmHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.CIFRADO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SALT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MD5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHA512);
            this.Controls.Add(this.SHA384);
            this.Controls.Add(this.SHA256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SHA1);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.button3);
            this.Name = "frmHash";
            this.Text = "frmHash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SHA1;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SHA256;
        private System.Windows.Forms.TextBox SHA384;
        private System.Windows.Forms.TextBox SHA512;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MD5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SALT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CIFRADO;
    }
}