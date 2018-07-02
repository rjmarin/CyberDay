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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.text_clave = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.label_bienvenida = new System.Windows.Forms.Label();
            this.panel_wishlist = new System.Windows.Forms.Panel();
            this.button_salir = new System.Windows.Forms.Button();
            this.info_lista_deseos = new System.Windows.Forms.TextBox();
            this.box_lista_deseos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_comprar = new System.Windows.Forms.Button();
            this.panel_user.SuspendLayout();
            this.panel_wishlist.SuspendLayout();
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
            this.button_buscar.Text = "Search";
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
            this.panel_user.Location = new System.Drawing.Point(639, 13);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(831, 415);
            this.panel_user.TabIndex = 5;
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
            // panel_wishlist
            // 
            this.panel_wishlist.Controls.Add(this.button_comprar);
            this.panel_wishlist.Controls.Add(this.button_salir);
            this.panel_wishlist.Controls.Add(this.info_lista_deseos);
            this.panel_wishlist.Controls.Add(this.box_lista_deseos);
            this.panel_wishlist.Location = new System.Drawing.Point(12, 394);
            this.panel_wishlist.Name = "panel_wishlist";
            this.panel_wishlist.Size = new System.Drawing.Size(437, 162);
            this.panel_wishlist.TabIndex = 6;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(336, 104);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 2;
            this.button_salir.Text = "Back";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // info_lista_deseos
            // 
            this.info_lista_deseos.Location = new System.Drawing.Point(211, 16);
            this.info_lista_deseos.Multiline = true;
            this.info_lista_deseos.Name = "info_lista_deseos";
            this.info_lista_deseos.Size = new System.Drawing.Size(200, 69);
            this.info_lista_deseos.TabIndex = 1;
            // 
            // box_lista_deseos
            // 
            this.box_lista_deseos.FormattingEnabled = true;
            this.box_lista_deseos.Location = new System.Drawing.Point(17, 16);
            this.box_lista_deseos.Name = "box_lista_deseos";
            this.box_lista_deseos.Size = new System.Drawing.Size(172, 69);
            this.box_lista_deseos.TabIndex = 0;
            this.box_lista_deseos.SelectedIndexChanged += new System.EventHandler(this.box_lista_deseos_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Wishlist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add to wishlist";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_comprar
            // 
            this.button_comprar.Location = new System.Drawing.Point(235, 104);
            this.button_comprar.Name = "button_comprar";
            this.button_comprar.Size = new System.Drawing.Size(75, 23);
            this.button_comprar.TabIndex = 3;
            this.button_comprar.Text = "Comprar";
            this.button_comprar.UseVisualStyleBackColor = true;
            this.button_comprar.Click += new System.EventHandler(this.button_comprar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 568);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel_wishlist);
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
            this.panel_wishlist.ResumeLayout(false);
            this.panel_wishlist.PerformLayout();
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
        private System.Windows.Forms.Panel panel_wishlist;
        private System.Windows.Forms.TextBox info_lista_deseos;
        private System.Windows.Forms.ListBox box_lista_deseos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_comprar;
    }
}

