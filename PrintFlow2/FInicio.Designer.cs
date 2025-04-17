namespace PrintFlow2
{
    partial class FInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
            button1 = new Button();
            BtnInicioPrintFlow = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 0;
            button1.Text = "Crear print flow";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnInicioPrintFlow
            // 
            BtnInicioPrintFlow.Location = new Point(65, 190);
            BtnInicioPrintFlow.Name = "BtnInicioPrintFlow";
            BtnInicioPrintFlow.Size = new Size(75, 23);
            BtnInicioPrintFlow.TabIndex = 1;
            BtnInicioPrintFlow.Text = "Iniciar print flow";
            BtnInicioPrintFlow.UseVisualStyleBackColor = true;
            BtnInicioPrintFlow.Click += BtnInicioPrintFlow_Click;
            // 
            // FInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnInicioPrintFlow);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FInicio";
            Text = "Print flow";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button BtnInicioPrintFlow;
    }
}