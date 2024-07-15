namespace prueba
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrepetir = new System.Windows.Forms.TextBox();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.txtactual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cambiar = new System.Windows.Forms.Button();
            this.lblus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(110, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(114, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(118, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // txtrepetir
            // 
            this.txtrepetir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtrepetir.Location = new System.Drawing.Point(326, 212);
            this.txtrepetir.Name = "txtrepetir";
            this.txtrepetir.PasswordChar = '*';
            this.txtrepetir.Size = new System.Drawing.Size(100, 20);
            this.txtrepetir.TabIndex = 3;
            // 
            // txtnueva
            // 
            this.txtnueva.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtnueva.CausesValidation = false;
            this.txtnueva.Location = new System.Drawing.Point(326, 184);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.PasswordChar = '*';
            this.txtnueva.Size = new System.Drawing.Size(100, 20);
            this.txtnueva.TabIndex = 4;
            // 
            // txtactual
            // 
            this.txtactual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtactual.CausesValidation = false;
            this.txtactual.Location = new System.Drawing.Point(326, 155);
            this.txtactual.Name = "txtactual";
            this.txtactual.PasswordChar = '*';
            this.txtactual.Size = new System.Drawing.Size(100, 20);
            this.txtactual.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(266, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cambio de Contraseña";
            // 
            // Cambiar
            // 
            this.Cambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.Cambiar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambiar.Location = new System.Drawing.Point(359, 298);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(107, 33);
            this.Cambiar.TabIndex = 6;
            this.Cambiar.Text = "Cambiar";
            this.Cambiar.UseVisualStyleBackColor = false;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // lblus
            // 
            this.lblus.AutoSize = true;
            this.lblus.BackColor = System.Drawing.Color.Transparent;
            this.lblus.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblus.Location = new System.Drawing.Point(359, 69);
            this.lblus.Name = "lblus";
            this.lblus.Size = new System.Drawing.Size(64, 23);
            this.lblus.TabIndex = 7;
            this.lblus.Text = "label5";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblus);
            this.Controls.Add(this.Cambiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtactual);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.txtrepetir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Password";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrepetir;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.TextBox txtactual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cambiar;
        public System.Windows.Forms.Label lblus;
    }
}