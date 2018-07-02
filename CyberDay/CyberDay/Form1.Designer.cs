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
            this.button_Add_Producto = new System.Windows.Forms.Button();
            this.button_lista_deseos = new System.Windows.Forms.Button();
            this.panel_deseos = new System.Windows.Forms.Panel();
            this.listBox_deseos = new System.Windows.Forms.ListBox();
            this.textbox_deseos = new System.Windows.Forms.TextBox();
            this.button_comprar = new System.Windows.Forms.Button();
            this.button_salir_deseos = new System.Windows.Forms.Button();
            this.panel_user.SuspendLayout();
            this.panel_deseos.SuspendLayout();
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
            this.panel_user.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_user.Controls.Add(this.label2);
            this.panel_user.Controls.Add(this.label1);
            this.panel_user.Controls.Add(this.LogIn);
            this.panel_user.Controls.Add(this.text_clave);
            this.panel_user.Controls.Add(this.text_user);
            this.panel_user.Location = new System.Drawing.Point(12, 2);
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
            this.LogIn.Location = new System.Drawing.Point(339, 112);
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
            // button_Add_Producto
            // 
            this.button_Add_Producto.Location = new System.Drawing.Point(537, 394);
            this.button_Add_Producto.Name = "button_Add_Producto";
            this.button_Add_Producto.Size = new System.Drawing.Size(75, 23);
            this.button_Add_Producto.TabIndex = 5;
            this.button_Add_Producto.Text = "Agregar producto";
            this.button_Add_Producto.UseVisualStyleBackColor = true;
            this.button_Add_Producto.Click += new System.EventHandler(this.button_Add_Producto_Click);
            // 
            // button_lista_deseos
            // 
            this.button_lista_deseos.Location = new System.Drawing.Point(528, 10);
            this.button_lista_deseos.Name = "button_lista_deseos";
            this.button_lista_deseos.Size = new System.Drawing.Size(110, 24);
            this.button_lista_deseos.TabIndex = 6;
            this.button_lista_deseos.Text = "lista de deseos";
            this.button_lista_deseos.UseVisualStyleBackColor = true;
            this.button_lista_deseos.Click += new System.EventHandler(this.button_lista_deseos_Click);
            // 
            // panel_deseos
            // 
            this.panel_deseos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_deseos.Controls.Add(this.button_salir_deseos);
            this.panel_deseos.Controls.Add(this.button_comprar);
            this.panel_deseos.Controls.Add(this.textbox_deseos);
            this.panel_deseos.Controls.Add(this.listBox_deseos);
            this.panel_deseos.Location = new System.Drawing.Point(52, 423);
            this.panel_deseos.Name = "panel_deseos";
            this.panel_deseos.Size = new System.Drawing.Size(538, 332);
            this.panel_deseos.TabIndex = 7;
            this.panel_deseos.Visible = false;
            // 
            // listBox_deseos
            // 
            this.listBox_deseos.FormattingEnabled = true;
            this.listBox_deseos.Location = new System.Drawing.Point(20, 48);
            this.listBox_deseos.Name = "listBox_deseos";
            this.listBox_deseos.Size = new System.Drawing.Size(176, 199);
            this.listBox_deseos.TabIndex = 3;
            this.listBox_deseos.SelectedIndexChanged += new System.EventHandler(this.listBox_deseos_SelectedIndexChanged);
            // 
            // textbox_deseos
            // 
            this.textbox_deseos.AcceptsReturn = true;
            this.textbox_deseos.Location = new System.Drawing.Point(243, 48);
            this.textbox_deseos.Multiline = true;
            this.textbox_deseos.Name = "textbox_deseos";
            this.textbox_deseos.ReadOnly = true;
            this.textbox_deseos.Size = new System.Drawing.Size(188, 208);
            this.textbox_deseos.TabIndex = 4;
            // 
            // button_comprar
            // 
            this.button_comprar.Location = new System.Drawing.Point(247, 281);
            this.button_comprar.Name = "button_comprar";
            this.button_comprar.Size = new System.Drawing.Size(75, 23);
            this.button_comprar.TabIndex = 5;
            this.button_comprar.Text = "Comprar!";
            this.button_comprar.UseVisualStyleBackColor = true;
            this.button_comprar.Click += new System.EventHandler(this.button_comprar_Click);
            // 
            // button_salir_deseos
            // 
            this.button_salir_deseos.Location = new System.Drawing.Point(356, 281);
            this.button_salir_deseos.Name = "button_salir_deseos";
            this.button_salir_deseos.Size = new System.Drawing.Size(75, 23);
            this.button_salir_deseos.TabIndex = 6;
            this.button_salir_deseos.Text = "salir";
            this.button_salir_deseos.UseVisualStyleBackColor = true;
            this.button_salir_deseos.Click += new System.EventHandler(this.button_salir_deseos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 749);
            this.Controls.Add(this.panel_deseos);
            this.Controls.Add(this.button_lista_deseos);
            this.Controls.Add(this.button_Add_Producto);
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
            this.panel_deseos.ResumeLayout(false);
            this.panel_deseos.PerformLayout();
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
        private System.Windows.Forms.Button button_Add_Producto;
        private System.Windows.Forms.Button button_lista_deseos;
        private System.Windows.Forms.Panel panel_deseos;
        private System.Windows.Forms.TextBox textbox_deseos;
        private System.Windows.Forms.ListBox listBox_deseos;
        private System.Windows.Forms.Button button_salir_deseos;
        private System.Windows.Forms.Button button_comprar;
    }
}

