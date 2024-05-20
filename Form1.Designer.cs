namespace demoCorreo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnviar1 = new System.Windows.Forms.Button();
            this.listBoxEnviados1 = new System.Windows.Forms.ListBox();
            this.listBoxRecibidos1 = new System.Windows.Forms.ListBox();
            this.listBoxSPAM1 = new System.Windows.Forms.ListBox();
            this.txtBoxAsunto1 = new System.Windows.Forms.TextBox();
            this.txtBoxDestinatario1 = new System.Windows.Forms.TextBox();
            this.txtBoxRemitente1 = new System.Windows.Forms.TextBox();
            this.txtBoxRemitente2 = new System.Windows.Forms.TextBox();
            this.txtBoxDestinatario2 = new System.Windows.Forms.TextBox();
            this.txtBoxAsunto2 = new System.Windows.Forms.TextBox();
            this.listBoxSPAM2 = new System.Windows.Forms.ListBox();
            this.listBoxRecibidos2 = new System.Windows.Forms.ListBox();
            this.listBoxEnviados2 = new System.Windows.Forms.ListBox();
            this.btnEnviar2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.richTxtBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Yimeil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "De:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Para:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asunto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mensaje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correos enviados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correos recibidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Correos SPAM:";
            // 
            // btnEnviar1
            // 
            this.btnEnviar1.Location = new System.Drawing.Point(508, 112);
            this.btnEnviar1.Name = "btnEnviar1";
            this.btnEnviar1.Size = new System.Drawing.Size(88, 28);
            this.btnEnviar1.TabIndex = 8;
            this.btnEnviar1.Text = "Enviar";
            this.btnEnviar1.UseVisualStyleBackColor = true;
            this.btnEnviar1.Click += new System.EventHandler(this.btnEnviar1_Click);
            // 
            // listBoxEnviados1
            // 
            this.listBoxEnviados1.FormattingEnabled = true;
            this.listBoxEnviados1.ItemHeight = 18;
            this.listBoxEnviados1.Location = new System.Drawing.Point(25, 289);
            this.listBoxEnviados1.Name = "listBoxEnviados1";
            this.listBoxEnviados1.Size = new System.Drawing.Size(601, 58);
            this.listBoxEnviados1.TabIndex = 10;
            // 
            // listBoxRecibidos1
            // 
            this.listBoxRecibidos1.FormattingEnabled = true;
            this.listBoxRecibidos1.ItemHeight = 18;
            this.listBoxRecibidos1.Location = new System.Drawing.Point(25, 380);
            this.listBoxRecibidos1.Name = "listBoxRecibidos1";
            this.listBoxRecibidos1.Size = new System.Drawing.Size(601, 58);
            this.listBoxRecibidos1.TabIndex = 11;
            // 
            // listBoxSPAM1
            // 
            this.listBoxSPAM1.FormattingEnabled = true;
            this.listBoxSPAM1.ItemHeight = 18;
            this.listBoxSPAM1.Location = new System.Drawing.Point(25, 480);
            this.listBoxSPAM1.Name = "listBoxSPAM1";
            this.listBoxSPAM1.Size = new System.Drawing.Size(601, 58);
            this.listBoxSPAM1.TabIndex = 12;
            // 
            // txtBoxAsunto1
            // 
            this.txtBoxAsunto1.Location = new System.Drawing.Point(163, 158);
            this.txtBoxAsunto1.Name = "txtBoxAsunto1";
            this.txtBoxAsunto1.Size = new System.Drawing.Size(275, 26);
            this.txtBoxAsunto1.TabIndex = 14;
            // 
            // txtBoxDestinatario1
            // 
            this.txtBoxDestinatario1.Location = new System.Drawing.Point(162, 125);
            this.txtBoxDestinatario1.Name = "txtBoxDestinatario1";
            this.txtBoxDestinatario1.Size = new System.Drawing.Size(275, 26);
            this.txtBoxDestinatario1.TabIndex = 15;
            this.txtBoxDestinatario1.TextChanged += new System.EventHandler(this.txtBoxDestinatario1_TextChanged);
            // 
            // txtBoxRemitente1
            // 
            this.txtBoxRemitente1.Location = new System.Drawing.Point(163, 93);
            this.txtBoxRemitente1.Name = "txtBoxRemitente1";
            this.txtBoxRemitente1.Size = new System.Drawing.Size(275, 26);
            this.txtBoxRemitente1.TabIndex = 16;
            // 
            // txtBoxRemitente2
            // 
            this.txtBoxRemitente2.Location = new System.Drawing.Point(847, 96);
            this.txtBoxRemitente2.Name = "txtBoxRemitente2";
            this.txtBoxRemitente2.Size = new System.Drawing.Size(275, 26);
            this.txtBoxRemitente2.TabIndex = 32;
            // 
            // txtBoxDestinatario2
            // 
            this.txtBoxDestinatario2.Location = new System.Drawing.Point(847, 129);
            this.txtBoxDestinatario2.Name = "txtBoxDestinatario2";
            this.txtBoxDestinatario2.Size = new System.Drawing.Size(275, 26);
            this.txtBoxDestinatario2.TabIndex = 31;
            // 
            // txtBoxAsunto2
            // 
            this.txtBoxAsunto2.Location = new System.Drawing.Point(847, 161);
            this.txtBoxAsunto2.Name = "txtBoxAsunto2";
            this.txtBoxAsunto2.Size = new System.Drawing.Size(275, 26);
            this.txtBoxAsunto2.TabIndex = 30;
            // 
            // listBoxSPAM2
            // 
            this.listBoxSPAM2.FormattingEnabled = true;
            this.listBoxSPAM2.ItemHeight = 18;
            this.listBoxSPAM2.Location = new System.Drawing.Point(700, 480);
            this.listBoxSPAM2.Name = "listBoxSPAM2";
            this.listBoxSPAM2.Size = new System.Drawing.Size(601, 58);
            this.listBoxSPAM2.TabIndex = 28;
            // 
            // listBoxRecibidos2
            // 
            this.listBoxRecibidos2.FormattingEnabled = true;
            this.listBoxRecibidos2.ItemHeight = 18;
            this.listBoxRecibidos2.Location = new System.Drawing.Point(700, 380);
            this.listBoxRecibidos2.Name = "listBoxRecibidos2";
            this.listBoxRecibidos2.Size = new System.Drawing.Size(601, 58);
            this.listBoxRecibidos2.TabIndex = 27;
            // 
            // listBoxEnviados2
            // 
            this.listBoxEnviados2.FormattingEnabled = true;
            this.listBoxEnviados2.ItemHeight = 18;
            this.listBoxEnviados2.Location = new System.Drawing.Point(700, 289);
            this.listBoxEnviados2.Name = "listBoxEnviados2";
            this.listBoxEnviados2.Size = new System.Drawing.Size(601, 58);
            this.listBoxEnviados2.TabIndex = 26;
            // 
            // btnEnviar2
            // 
            this.btnEnviar2.Location = new System.Drawing.Point(1171, 129);
            this.btnEnviar2.Name = "btnEnviar2";
            this.btnEnviar2.Size = new System.Drawing.Size(88, 28);
            this.btnEnviar2.TabIndex = 24;
            this.btnEnviar2.Text = "Enviar";
            this.btnEnviar2.UseVisualStyleBackColor = true;
            this.btnEnviar2.Click += new System.EventHandler(this.btnEnviar2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(696, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Correos SPAM:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(697, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Correos recibidos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(696, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Correos enviados:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(762, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mensaje:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(771, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Asunto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(790, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 18);
            this.label14.TabIndex = 18;
            this.label14.Text = "Para:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(806, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "De:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(259, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 18);
            this.label16.TabIndex = 33;
            this.label16.Text = "Usuario 1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(961, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 18);
            this.label17.TabIndex = 34;
            this.label17.Text = "Usuario 2";
            // 
            // richTxtBox2
            // 
            this.richTxtBox2.Location = new System.Drawing.Point(847, 196);
            this.richTxtBox2.Name = "richTxtBox2";
            this.richTxtBox2.Size = new System.Drawing.Size(412, 70);
            this.richTxtBox2.TabIndex = 35;
            this.richTxtBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(162, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(412, 70);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 590);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTxtBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBoxRemitente2);
            this.Controls.Add(this.txtBoxDestinatario2);
            this.Controls.Add(this.txtBoxAsunto2);
            this.Controls.Add(this.listBoxSPAM2);
            this.Controls.Add(this.listBoxRecibidos2);
            this.Controls.Add(this.listBoxEnviados2);
            this.Controls.Add(this.btnEnviar2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxRemitente1);
            this.Controls.Add(this.txtBoxDestinatario1);
            this.Controls.Add(this.txtBoxAsunto1);
            this.Controls.Add(this.listBoxSPAM1);
            this.Controls.Add(this.listBoxRecibidos1);
            this.Controls.Add(this.listBoxEnviados1);
            this.Controls.Add(this.btnEnviar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnviar1;
        private System.Windows.Forms.ListBox listBoxEnviados1;
        private System.Windows.Forms.ListBox listBoxRecibidos1;
        private System.Windows.Forms.ListBox listBoxSPAM1;
        private System.Windows.Forms.TextBox txtBoxAsunto1;
        private System.Windows.Forms.TextBox txtBoxDestinatario1;
        private System.Windows.Forms.TextBox txtBoxRemitente1;
        private System.Windows.Forms.TextBox txtBoxRemitente2;
        private System.Windows.Forms.TextBox txtBoxDestinatario2;
        private System.Windows.Forms.TextBox txtBoxAsunto2;
        private System.Windows.Forms.ListBox listBoxSPAM2;
        private System.Windows.Forms.ListBox listBoxRecibidos2;
        private System.Windows.Forms.ListBox listBoxEnviados2;
        private System.Windows.Forms.Button btnEnviar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTxtBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

