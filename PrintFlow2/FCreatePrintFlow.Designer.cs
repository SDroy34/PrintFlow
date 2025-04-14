namespace PrintFlow2
{
    partial class FCreatePrintFlow
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
            label1 = new Label();
            TbxNamePrintFlow = new TextBox();
            BtnSelecionar = new Button();
            LblPathFolder = new Label();
            LblAliasDoc = new Label();
            TbxAliasDoc = new TextBox();
            NudCopias = new NumericUpDown();
            label2 = new Label();
            CbxImpresoras = new ComboBox();
            CbxTipoDocumento = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            BtnAddPrintFlow = new Button();
            ((System.ComponentModel.ISupportInitialize)NudCopias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre print flow";
            // 
            // TbxNamePrintFlow
            // 
            TbxNamePrintFlow.Location = new Point(124, 8);
            TbxNamePrintFlow.Name = "TbxNamePrintFlow";
            TbxNamePrintFlow.Size = new Size(327, 23);
            TbxNamePrintFlow.TabIndex = 1;
            TbxNamePrintFlow.TextChanged += TbxNamePrintFlow_TextChanged;
            // 
            // BtnSelecionar
            // 
            BtnSelecionar.Location = new Point(13, 38);
            BtnSelecionar.Name = "BtnSelecionar";
            BtnSelecionar.Size = new Size(75, 23);
            BtnSelecionar.TabIndex = 2;
            BtnSelecionar.Text = "Selecionar";
            BtnSelecionar.UseVisualStyleBackColor = true;
            BtnSelecionar.Click += BtnSelecionar_Click;
            // 
            // LblPathFolder
            // 
            LblPathFolder.AutoSize = true;
            LblPathFolder.Location = new Point(94, 42);
            LblPathFolder.Name = "LblPathFolder";
            LblPathFolder.Size = new Size(220, 15);
            LblPathFolder.TabIndex = 3;
            LblPathFolder.Text = "Seleccione una carpeta para el print flow";
            // 
            // LblAliasDoc
            // 
            LblAliasDoc.AutoSize = true;
            LblAliasDoc.Location = new Point(13, 67);
            LblAliasDoc.Name = "LblAliasDoc";
            LblAliasDoc.Size = new Size(116, 15);
            LblAliasDoc.TabIndex = 4;
            LblAliasDoc.Text = "Alias del documento";
            // 
            // TbxAliasDoc
            // 
            TbxAliasDoc.Location = new Point(135, 64);
            TbxAliasDoc.Name = "TbxAliasDoc";
            TbxAliasDoc.Size = new Size(316, 23);
            TbxAliasDoc.TabIndex = 5;
            TbxAliasDoc.TextChanged += textBox1_TextChanged;
            // 
            // NudCopias
            // 
            NudCopias.Location = new Point(62, 95);
            NudCopias.Name = "NudCopias";
            NudCopias.Size = new Size(39, 23);
            NudCopias.TabIndex = 6;
            NudCopias.ValueChanged += NudCopias_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Copias";
            // 
            // CbxImpresoras
            // 
            CbxImpresoras.FormattingEnabled = true;
            CbxImpresoras.Location = new Point(13, 176);
            CbxImpresoras.Name = "CbxImpresoras";
            CbxImpresoras.Size = new Size(149, 23);
            CbxImpresoras.TabIndex = 8;
            CbxImpresoras.SelectedIndexChanged += CbxImpresoras_SelectedIndexChanged;
            // 
            // CbxTipoDocumento
            // 
            CbxTipoDocumento.FormattingEnabled = true;
            CbxTipoDocumento.Location = new Point(190, 176);
            CbxTipoDocumento.Name = "CbxTipoDocumento";
            CbxTipoDocumento.Size = new Size(149, 23);
            CbxTipoDocumento.TabIndex = 9;
            CbxTipoDocumento.SelectedIndexChanged += CbxTipoDocumento_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 155);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 10;
            label3.Text = "Impresoras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 155);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 11;
            label4.Text = "Tipo de documento";
            // 
            // BtnAddPrintFlow
            // 
            BtnAddPrintFlow.Location = new Point(13, 254);
            BtnAddPrintFlow.Name = "BtnAddPrintFlow";
            BtnAddPrintFlow.Size = new Size(75, 23);
            BtnAddPrintFlow.TabIndex = 12;
            BtnAddPrintFlow.Text = "Crear";
            BtnAddPrintFlow.UseVisualStyleBackColor = true;
            BtnAddPrintFlow.Click += BtnAddPrintFlow_Click;
            // 
            // FCreatePrintFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAddPrintFlow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CbxTipoDocumento);
            Controls.Add(CbxImpresoras);
            Controls.Add(label2);
            Controls.Add(NudCopias);
            Controls.Add(TbxAliasDoc);
            Controls.Add(LblAliasDoc);
            Controls.Add(LblPathFolder);
            Controls.Add(BtnSelecionar);
            Controls.Add(TbxNamePrintFlow);
            Controls.Add(label1);
            Name = "FCreatePrintFlow";
            Text = "Create print flow";
            ((System.ComponentModel.ISupportInitialize)NudCopias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TbxNamePrintFlow;
        private Button BtnSelecionar;
        private Label LblPathFolder;
        private Label LblAliasDoc;
        private TextBox TbxAliasDoc;
        private NumericUpDown NudCopias;
        private Label label2;
        private ComboBox CbxImpresoras;
        private ComboBox CbxTipoDocumento;
        private Label label3;
        private Label label4;
        private Button BtnAddPrintFlow;
    }
}