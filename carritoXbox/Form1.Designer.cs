namespace carritoXbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb_Puertos = new System.Windows.Forms.ComboBox();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Puertos
            // 
            this.cb_Puertos.FormattingEnabled = true;
            this.cb_Puertos.Location = new System.Drawing.Point(42, 31);
            this.cb_Puertos.Name = "cb_Puertos";
            this.cb_Puertos.Size = new System.Drawing.Size(121, 21);
            this.cb_Puertos.TabIndex = 0;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(186, 28);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_Conectar.TabIndex = 1;
            this.btn_Conectar.Text = "CONECTAR";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(283, 28);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(91, 23);
            this.btn_Actualizar.TabIndex = 2;
            this.btn_Actualizar.Text = "ACTUALIZAR";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 234);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.cb_Puertos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SUPER CARRITO BT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Puertos;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Actualizar;
    }
}

