namespace MensajeDeTexto
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
            this.btnMensajeUno = new System.Windows.Forms.Button();
            this.btnMensaje2 = new System.Windows.Forms.Button();
            this.btnMensajeTres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensajeUno
            // 
            this.btnMensajeUno.Location = new System.Drawing.Point(82, 45);
            this.btnMensajeUno.Name = "btnMensajeUno";
            this.btnMensajeUno.Size = new System.Drawing.Size(168, 33);
            this.btnMensajeUno.TabIndex = 0;
            this.btnMensajeUno.Text = "Mensaje 1";
            this.btnMensajeUno.UseVisualStyleBackColor = true;
            this.btnMensajeUno.Click += new System.EventHandler(this.btnMensajeUno_Click);
            // 
            // btnMensaje2
            // 
            this.btnMensaje2.Location = new System.Drawing.Point(82, 105);
            this.btnMensaje2.Name = "btnMensaje2";
            this.btnMensaje2.Size = new System.Drawing.Size(168, 33);
            this.btnMensaje2.TabIndex = 1;
            this.btnMensaje2.Text = "Mensaje 2";
            this.btnMensaje2.UseVisualStyleBackColor = true;
            this.btnMensaje2.Click += new System.EventHandler(this.btnMensaje2_Click);
            // 
            // btnMensajeTres
            // 
            this.btnMensajeTres.Location = new System.Drawing.Point(82, 165);
            this.btnMensajeTres.Name = "btnMensajeTres";
            this.btnMensajeTres.Size = new System.Drawing.Size(168, 33);
            this.btnMensajeTres.TabIndex = 2;
            this.btnMensajeTres.Text = "Mensaje 3";
            this.btnMensajeTres.UseVisualStyleBackColor = true;
            this.btnMensajeTres.Click += new System.EventHandler(this.btnMensajeTres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 252);
            this.Controls.Add(this.btnMensajeTres);
            this.Controls.Add(this.btnMensaje2);
            this.Controls.Add(this.btnMensajeUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensajeUno;
        private System.Windows.Forms.Button btnMensaje2;
        private System.Windows.Forms.Button btnMensajeTres;
    }
}

