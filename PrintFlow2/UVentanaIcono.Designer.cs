namespace PrintFlow2
{
    partial class UVentanaIcono
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCerraApp = new Button();
            BtnRegresarInc = new Button();
            SuspendLayout();
            // 
            // BtnCerraApp
            // 
            BtnCerraApp.Location = new Point(3, 32);
            BtnCerraApp.Name = "BtnCerraApp";
            BtnCerraApp.Size = new Size(144, 23);
            BtnCerraApp.TabIndex = 0;
            BtnCerraApp.Text = "Cerrar aplicacion";
            BtnCerraApp.UseVisualStyleBackColor = true;
            BtnCerraApp.Click += BtnCerraApp_Click;
            // 
            // BtnRegresarInc
            // 
            BtnRegresarInc.Location = new Point(3, 3);
            BtnRegresarInc.Name = "BtnRegresarInc";
            BtnRegresarInc.Size = new Size(144, 23);
            BtnRegresarInc.TabIndex = 1;
            BtnRegresarInc.Text = "Regresar inicio";
            BtnRegresarInc.UseVisualStyleBackColor = true;
            BtnRegresarInc.Click += BtnRegresarInc_Click;
            // 
            // UVentanaIcono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnRegresarInc);
            Controls.Add(BtnCerraApp);
            Name = "UVentanaIcono";
            Size = new Size(150, 59);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCerraApp;
        private Button BtnRegresarInc;
    }
}
