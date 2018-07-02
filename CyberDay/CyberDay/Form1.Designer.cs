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
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.text_clave = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.label_bienvenida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_buscador
            // 
            this.text_buscador.Location = new System.Drawing.Point(202, 12);
            this.text_buscador.Name = "text_buscador";
            this.text_buscador.Size = new System.Drawing.Size(204, 20);
            this.text_buscador.TabIndex = 0;
            this.text_buscador.TextChanged += new System.EventHandler(this.text_buscador_TextChanged);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(412, 12);
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
            this.listbuscador.Location = new System.Drawing.Point(12, 98);
            this.listbuscador.Name = "listbuscador";
            this.listbuscador.Size = new System.Drawing.Size(310, 290);
            this.listbuscador.TabIndex = 2;
            this.listbuscador.Click += new System.EventHandler(this.listbuscador_Click);
            this.listbuscador.SelectedIndexChanged += new System.EventHandler(this.listbuscador_SelectedIndexChanged);
            // 
            // text_info
            // 
            this.text_info.AcceptsReturn = true;
            this.text_info.Location = new System.Drawing.Point(328, 98);
            this.text_info.Multiline = true;
            this.text_info.Name = "text_info";
            this.text_info.ReadOnly = true;
            this.text_info.Size = new System.Drawing.Size(294, 290);
            this.text_info.TabIndex = 3;
            // 
            // combo_categoria
            // 
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Location = new System.Drawing.Point(12, 13);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(172, 21);
            this.combo_categoria.TabIndex = 4;
            this.combo_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel_user
            // 
            this.panel_user.Controls.Add(this.button1);
            this.panel_user.Controls.Add(this.label2);
            this.panel_user.Controls.Add(this.label1);
            this.panel_user.Controls.Add(this.LogIn);
            this.panel_user.Controls.Add(this.text_clave);
            this.panel_user.Controls.Add(this.text_user);
            this.panel_user.Location = new System.Drawing.Point(12, 12);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(831, 415);
            this.panel_user.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserID";
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(319, 112);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 2;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // text_clave
            // 
            this.text_clave.Location = new System.Drawing.Point(376, 74);
            this.text_clave.Name = "text_clave";
            this.text_clave.Size = new System.Drawing.Size(100, 20);
            this.text_clave.TabIndex = 1;
            this.text_clave.UseSystemPasswordChar = true;
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(376, 38);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(100, 20);
            this.text_user.TabIndex = 0;
            // 
            // label_bienvenida
            // 
            this.label_bienvenida.AutoSize = true;
            this.label_bienvenida.Location = new System.Drawing.Point(26, 53);
            this.label_bienvenida.Name = "label_bienvenida";
            this.label_bienvenida.Size = new System.Drawing.Size(0, 13);
            this.label_bienvenida.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.label_bienvenida);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.combo_categoria);
            this.Controls.Add(this.text_info);
            this.Controls.Add(this.listbuscador);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.text_buscador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_buscador;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.ListBox listbuscador;
        private System.Windows.Forms.TextBox text_info;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.TextBox text_clave;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label label_bienvenida;
        private System.Windows.Forms.Button button1;
    }
}

