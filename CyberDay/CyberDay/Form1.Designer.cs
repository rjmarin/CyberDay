namespace CyberDay
{
    partial class Form1
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
            this.text_buscador = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.listbuscador = new System.Windows.Forms.ListBox();
            this.text_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_buscador
            // 
            this.text_buscador.Location = new System.Drawing.Point(304, 85);
            this.text_buscador.Name = "text_buscador";
            this.text_buscador.Size = new System.Drawing.Size(204, 20);
            this.text_buscador.TabIndex = 0;
            this.text_buscador.TextChanged += new System.EventHandler(this.text_buscador_TextChanged);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(514, 85);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(81, 20);
            this.button_buscar.TabIndex = 1;
            this.button_buscar.Text = "buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // listbuscador
            // 
            this.listbuscador.FormattingEnabled = true;
            this.listbuscador.Location = new System.Drawing.Point(29, 151);
            this.listbuscador.Name = "listbuscador";
            this.listbuscador.Size = new System.Drawing.Size(243, 199);
            this.listbuscador.TabIndex = 2;
            this.listbuscador.Click += new System.EventHandler(this.listbuscador_Click);
            this.listbuscador.SelectedIndexChanged += new System.EventHandler(this.listbuscador_SelectedIndexChanged);
            // 
            // text_info
            // 
            this.text_info.AcceptsReturn = true;
            this.text_info.Location = new System.Drawing.Point(428, 120);
            this.text_info.Multiline = true;
            this.text_info.Name = "text_info";
            this.text_info.ReadOnly = true;
            this.text_info.Size = new System.Drawing.Size(294, 287);
            this.text_info.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_info);
            this.Controls.Add(this.listbuscador);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.text_buscador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_buscador;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.ListBox listbuscador;
        private System.Windows.Forms.TextBox text_info;
    }
}

