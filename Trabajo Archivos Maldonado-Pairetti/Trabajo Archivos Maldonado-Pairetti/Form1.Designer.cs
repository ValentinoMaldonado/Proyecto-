namespace Trabajo_Archivos_Maldonado_Pairetti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroModelo = new System.Windows.Forms.TextBox();
            this.txtNumeroConcesionaria = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnOrdenarYEnviar = new System.Windows.Forms.Button();
            this.btnGuardarPedidos = new System.Windows.Forms.Button();
            this.btnCargarPedidos = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.buttonListarModelos = new System.Windows.Forms.Button();
            this.buttonModificarModelo = new System.Windows.Forms.Button();
            this.buttonEliminarModelo = new System.Windows.Forms.Button();
            this.buttonAgregarModelo = new System.Windows.Forms.Button();
            this.textBoxStockModelo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionModelo = new System.Windows.Forms.TextBox();
            this.textBoxNumeroModelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEliminarModelo = new System.Windows.Forms.TextBox();
            this.txtEliminarConcesionaria = new System.Windows.Forms.TextBox();
            this.txtModificarModelo = new System.Windows.Forms.TextBox();
            this.txtModificarConcesionaria = new System.Windows.Forms.TextBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModificarCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Concesionaria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pedidos a Realizar: ";
            // 
            // txtNumeroModelo
            // 
            this.txtNumeroModelo.Location = new System.Drawing.Point(165, 17);
            this.txtNumeroModelo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNumeroModelo.Name = "txtNumeroModelo";
            this.txtNumeroModelo.Size = new System.Drawing.Size(49, 20);
            this.txtNumeroModelo.TabIndex = 3;
            // 
            // txtNumeroConcesionaria
            // 
            this.txtNumeroConcesionaria.Location = new System.Drawing.Point(165, 45);
            this.txtNumeroConcesionaria.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNumeroConcesionaria.Name = "txtNumeroConcesionaria";
            this.txtNumeroConcesionaria.Size = new System.Drawing.Size(49, 20);
            this.txtNumeroConcesionaria.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(165, 78);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(27, 105);
            this.btnAgregarPedido.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(187, 23);
            this.btnAgregarPedido.TabIndex = 6;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(26, 163);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 123;
            this.dgvPedidos.RowTemplate.Height = 46;
            this.dgvPedidos.Size = new System.Drawing.Size(396, 321);
            this.dgvPedidos.TabIndex = 7;
            // 
            // btnOrdenarYEnviar
            // 
            this.btnOrdenarYEnviar.Location = new System.Drawing.Point(311, 27);
            this.btnOrdenarYEnviar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnOrdenarYEnviar.Name = "btnOrdenarYEnviar";
            this.btnOrdenarYEnviar.Size = new System.Drawing.Size(111, 23);
            this.btnOrdenarYEnviar.TabIndex = 8;
            this.btnOrdenarYEnviar.Text = "Ordenar y Enviar";
            this.btnOrdenarYEnviar.UseVisualStyleBackColor = true;
            this.btnOrdenarYEnviar.Click += new System.EventHandler(this.btnOrdenarYEnviar_Click);
            // 
            // btnGuardarPedidos
            // 
            this.btnGuardarPedidos.Location = new System.Drawing.Point(311, 66);
            this.btnGuardarPedidos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGuardarPedidos.Name = "btnGuardarPedidos";
            this.btnGuardarPedidos.Size = new System.Drawing.Size(111, 26);
            this.btnGuardarPedidos.TabIndex = 9;
            this.btnGuardarPedidos.Text = "Guardar Pedidos";
            this.btnGuardarPedidos.UseVisualStyleBackColor = true;
            this.btnGuardarPedidos.Click += new System.EventHandler(this.btnGuardarPedidos_Click);
            // 
            // btnCargarPedidos
            // 
            this.btnCargarPedidos.Location = new System.Drawing.Point(311, 110);
            this.btnCargarPedidos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCargarPedidos.Name = "btnCargarPedidos";
            this.btnCargarPedidos.Size = new System.Drawing.Size(111, 24);
            this.btnCargarPedidos.TabIndex = 10;
            this.btnCargarPedidos.Text = "Cargar Pedidos";
            this.btnCargarPedidos.UseVisualStyleBackColor = true;
            this.btnCargarPedidos.Click += new System.EventHandler(this.btnCargarPedidos_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(776, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 457);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvModelos);
            this.tabPage1.Controls.Add(this.buttonListarModelos);
            this.tabPage1.Controls.Add(this.buttonModificarModelo);
            this.tabPage1.Controls.Add(this.buttonEliminarModelo);
            this.tabPage1.Controls.Add(this.buttonAgregarModelo);
            this.tabPage1.Controls.Add(this.textBoxStockModelo);
            this.tabPage1.Controls.Add(this.textBoxDescripcionModelo);
            this.tabPage1.Controls.Add(this.textBoxNumeroModelo);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(12, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(559, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modelos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvModelos
            // 
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(7, 145);
            this.dgvModelos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.RowHeadersWidth = 123;
            this.dgvModelos.RowTemplate.Height = 46;
            this.dgvModelos.Size = new System.Drawing.Size(387, 203);
            this.dgvModelos.TabIndex = 10;
            this.dgvModelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelos_CellContentClick);
            // 
            // buttonListarModelos
            // 
            this.buttonListarModelos.Location = new System.Drawing.Point(240, 116);
            this.buttonListarModelos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonListarModelos.Name = "buttonListarModelos";
            this.buttonListarModelos.Size = new System.Drawing.Size(63, 21);
            this.buttonListarModelos.TabIndex = 9;
            this.buttonListarModelos.Text = "Listar";
            this.buttonListarModelos.UseVisualStyleBackColor = true;
            // 
            // buttonModificarModelo
            // 
            this.buttonModificarModelo.Location = new System.Drawing.Point(240, 84);
            this.buttonModificarModelo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonModificarModelo.Name = "buttonModificarModelo";
            this.buttonModificarModelo.Size = new System.Drawing.Size(63, 21);
            this.buttonModificarModelo.TabIndex = 8;
            this.buttonModificarModelo.Text = "Modificar";
            this.buttonModificarModelo.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarModelo
            // 
            this.buttonEliminarModelo.Location = new System.Drawing.Point(240, 51);
            this.buttonEliminarModelo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonEliminarModelo.Name = "buttonEliminarModelo";
            this.buttonEliminarModelo.Size = new System.Drawing.Size(63, 21);
            this.buttonEliminarModelo.TabIndex = 7;
            this.buttonEliminarModelo.Text = "Eliminar";
            this.buttonEliminarModelo.UseVisualStyleBackColor = true;
            this.buttonEliminarModelo.Click += new System.EventHandler(this.buttonEliminarModelo_Click_1);
            // 
            // buttonAgregarModelo
            // 
            this.buttonAgregarModelo.Location = new System.Drawing.Point(240, 19);
            this.buttonAgregarModelo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonAgregarModelo.Name = "buttonAgregarModelo";
            this.buttonAgregarModelo.Size = new System.Drawing.Size(63, 21);
            this.buttonAgregarModelo.TabIndex = 6;
            this.buttonAgregarModelo.Text = "Agregar";
            this.buttonAgregarModelo.UseVisualStyleBackColor = true;
            this.buttonAgregarModelo.Click += new System.EventHandler(this.buttonAgregarModelo_Click_1);
            // 
            // textBoxStockModelo
            // 
            this.textBoxStockModelo.Location = new System.Drawing.Point(140, 87);
            this.textBoxStockModelo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxStockModelo.Name = "textBoxStockModelo";
            this.textBoxStockModelo.Size = new System.Drawing.Size(65, 20);
            this.textBoxStockModelo.TabIndex = 5;
            // 
            // textBoxDescripcionModelo
            // 
            this.textBoxDescripcionModelo.Location = new System.Drawing.Point(140, 57);
            this.textBoxDescripcionModelo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxDescripcionModelo.Name = "textBoxDescripcionModelo";
            this.textBoxDescripcionModelo.Size = new System.Drawing.Size(65, 20);
            this.textBoxDescripcionModelo.TabIndex = 4;
            // 
            // textBoxNumeroModelo
            // 
            this.textBoxNumeroModelo.Location = new System.Drawing.Point(140, 29);
            this.textBoxNumeroModelo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxNumeroModelo.Name = "textBoxNumeroModelo";
            this.textBoxNumeroModelo.Size = new System.Drawing.Size(65, 20);
            this.textBoxNumeroModelo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Stock Actual";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Descripción del Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Número de Modelo";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(12, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(559, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Piezas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(12, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(559, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Composición";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Eliminar Modelo Nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(21, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Eliminar Concesionaria Nro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Modelo Nro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Concesionaria\r\n Nro:";
            // 
            // txtEliminarModelo
            // 
            this.txtEliminarModelo.Location = new System.Drawing.Point(177, 16);
            this.txtEliminarModelo.Name = "txtEliminarModelo";
            this.txtEliminarModelo.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarModelo.TabIndex = 16;
            // 
            // txtEliminarConcesionaria
            // 
            this.txtEliminarConcesionaria.Location = new System.Drawing.Point(177, 46);
            this.txtEliminarConcesionaria.Name = "txtEliminarConcesionaria";
            this.txtEliminarConcesionaria.Size = new System.Drawing.Size(100, 20);
            this.txtEliminarConcesionaria.TabIndex = 17;
            // 
            // txtModificarModelo
            // 
            this.txtModificarModelo.Location = new System.Drawing.Point(179, 27);
            this.txtModificarModelo.Name = "txtModificarModelo";
            this.txtModificarModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModificarModelo.TabIndex = 18;
            // 
            // txtModificarConcesionaria
            // 
            this.txtModificarConcesionaria.Location = new System.Drawing.Point(179, 71);
            this.txtModificarConcesionaria.Name = "txtModificarConcesionaria";
            this.txtModificarConcesionaria.Size = new System.Drawing.Size(100, 20);
            this.txtModificarConcesionaria.TabIndex = 19;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(24, 80);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(133, 27);
            this.btnEliminarPedido.TabIndex = 20;
            this.btnEliminarPedido.Text = "Eliminar Pedido";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Location = new System.Drawing.Point(24, 158);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(133, 25);
            this.btnModificarPedido.TabIndex = 21;
            this.btnModificarPedido.Text = "Modificar Pedido";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(23, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Modificar Cantidad Nro:";
            // 
            // txtModificarCantidad
            // 
            this.txtModificarCantidad.Location = new System.Drawing.Point(179, 127);
            this.txtModificarCantidad.Name = "txtModificarCantidad";
            this.txtModificarCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtModificarCantidad.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnModificarPedido);
            this.groupBox1.Controls.Add(this.txtModificarCantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtModificarModelo);
            this.groupBox1.Controls.Add(this.txtModificarConcesionaria);
            this.groupBox1.Location = new System.Drawing.Point(439, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 189);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Cantidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEliminarConcesionaria);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnEliminarPedido);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEliminarModelo);
            this.groupBox2.Location = new System.Drawing.Point(439, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 125);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Pedido";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNumeroModelo);
            this.groupBox3.Controls.Add(this.txtNumeroConcesionaria);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.btnAgregarPedido);
            this.groupBox3.Location = new System.Drawing.Point(44, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 132);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar Pedido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1368, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCargarPedidos);
            this.Controls.Add(this.btnGuardarPedidos);
            this.Controls.Add(this.btnOrdenarYEnviar);
            this.Controls.Add(this.dgvPedidos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Consecionaria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroModelo;
        private System.Windows.Forms.TextBox txtNumeroConcesionaria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnOrdenarYEnviar;
        private System.Windows.Forms.Button btnGuardarPedidos;
        private System.Windows.Forms.Button btnCargarPedidos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEliminarModelo;
        private System.Windows.Forms.TextBox txtEliminarConcesionaria;
        private System.Windows.Forms.TextBox txtModificarModelo;
        private System.Windows.Forms.TextBox txtModificarConcesionaria;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModificarCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAgregarModelo;
        private System.Windows.Forms.TextBox textBoxStockModelo;
        private System.Windows.Forms.TextBox textBoxDescripcionModelo;
        private System.Windows.Forms.TextBox textBoxNumeroModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.Button buttonListarModelos;
        private System.Windows.Forms.Button buttonModificarModelo;
        private System.Windows.Forms.Button buttonEliminarModelo;
    }
}

