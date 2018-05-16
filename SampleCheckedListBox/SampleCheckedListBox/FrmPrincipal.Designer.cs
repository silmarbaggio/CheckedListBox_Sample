namespace SampleCheckedListBox
{
    partial class FrmPrincipal
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
            this.chkTipoGuia = new System.Windows.Forms.CheckedListBox();
            this.btnCarregarTipoGuia = new System.Windows.Forms.Button();
            this.btnCarregarChecked = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkTipoGuia
            // 
            this.chkTipoGuia.FormattingEnabled = true;
            this.chkTipoGuia.Location = new System.Drawing.Point(25, 12);
            this.chkTipoGuia.Name = "chkTipoGuia";
            this.chkTipoGuia.Size = new System.Drawing.Size(207, 229);
            this.chkTipoGuia.TabIndex = 0;
            // 
            // btnCarregarTipoGuia
            // 
            this.btnCarregarTipoGuia.Location = new System.Drawing.Point(248, 12);
            this.btnCarregarTipoGuia.Name = "btnCarregarTipoGuia";
            this.btnCarregarTipoGuia.Size = new System.Drawing.Size(133, 58);
            this.btnCarregarTipoGuia.TabIndex = 1;
            this.btnCarregarTipoGuia.Text = "Carregar Tipo de Guias";
            this.btnCarregarTipoGuia.UseVisualStyleBackColor = true;
            this.btnCarregarTipoGuia.Click += new System.EventHandler(this.btnCarregarTipoGuia_Click);
            // 
            // btnCarregarChecked
            // 
            this.btnCarregarChecked.Location = new System.Drawing.Point(248, 99);
            this.btnCarregarChecked.Name = "btnCarregarChecked";
            this.btnCarregarChecked.Size = new System.Drawing.Size(133, 57);
            this.btnCarregarChecked.TabIndex = 2;
            this.btnCarregarChecked.Text = "Carregar Tipo de Guias com checked";
            this.btnCarregarChecked.UseVisualStyleBackColor = true;
            this.btnCarregarChecked.Click += new System.EventHandler(this.btnCarregarChecked_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(248, 183);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(133, 58);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Recuperando Valores";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 256);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnCarregarChecked);
            this.Controls.Add(this.btnCarregarTipoGuia);
            this.Controls.Add(this.chkTipoGuia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPrincipal";
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkTipoGuia;
        private System.Windows.Forms.Button btnCarregarTipoGuia;
        private System.Windows.Forms.Button btnCarregarChecked;
        private System.Windows.Forms.Button btnIncluir;
    }
}