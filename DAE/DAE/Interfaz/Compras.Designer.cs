namespace DAE.Interfaz
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCompras = new System.Windows.Forms.TextBox();
            this.cmbPorCompras = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateTableCom = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtTablaCompras = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarCom = new System.Windows.Forms.Button();
            this.btnEditarCom = new System.Windows.Forms.Button();
            this.btnAgregarCom = new System.Windows.Forms.Button();
            this.gpCompras = new System.Windows.Forms.GroupBox();
            this.btnAgregarItemsCom = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoCompras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoDetalleCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTableDetalleCompra = new System.Windows.Forms.DataGridView();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.btnAgregarItems = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTablaCompras)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpCompras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTableDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBuscarCompras);
            this.groupBox4.Controls.Add(this.cmbPorCompras);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnUpdateTableCom);
            this.groupBox4.Controls.Add(this.btnFiltrar);
            this.groupBox4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(234, 581);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(952, 96);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscador";
            // 
            // txtBuscarCompras
            // 
            this.txtBuscarCompras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCompras.Location = new System.Drawing.Point(149, 43);
            this.txtBuscarCompras.Name = "txtBuscarCompras";
            this.txtBuscarCompras.Size = new System.Drawing.Size(177, 27);
            this.txtBuscarCompras.TabIndex = 6;
            // 
            // cmbPorCompras
            // 
            this.cmbPorCompras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorCompras.FormattingEnabled = true;
            this.cmbPorCompras.Location = new System.Drawing.Point(421, 42);
            this.cmbPorCompras.Name = "cmbPorCompras";
            this.cmbPorCompras.Size = new System.Drawing.Size(202, 27);
            this.cmbPorCompras.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(347, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Por";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(32, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Buscar";
            // 
            // btnUpdateTableCom
            // 
            this.btnUpdateTableCom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdateTableCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTableCom.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTableCom.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateTableCom.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTableCom.Image")));
            this.btnUpdateTableCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateTableCom.Location = new System.Drawing.Point(804, 32);
            this.btnUpdateTableCom.Name = "btnUpdateTableCom";
            this.btnUpdateTableCom.Size = new System.Drawing.Size(132, 52);
            this.btnUpdateTableCom.TabIndex = 1;
            this.btnUpdateTableCom.Text = "Actualizar";
            this.btnUpdateTableCom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateTableCom.UseVisualStyleBackColor = false;
            this.btnUpdateTableCom.Click += new System.EventHandler(this.btnUpdateTableCom_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(646, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(132, 52);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.groupBox3.Controls.Add(this.dtTablaCompras);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(29, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 414);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla Compras";
            // 
            // dtTablaCompras
            // 
            this.dtTablaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtTablaCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtTablaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTablaCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtTablaCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.dtTablaCompras.Location = new System.Drawing.Point(6, 19);
            this.dtTablaCompras.Name = "dtTablaCompras";
            this.dtTablaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTablaCompras.Size = new System.Drawing.Size(616, 386);
            this.dtTablaCompras.TabIndex = 1;
            this.dtTablaCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTablaCompras_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarCom);
            this.groupBox2.Controls.Add(this.btnEditarCom);
            this.groupBox2.Controls.Add(this.btnAgregarCom);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(834, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 118);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEliminarCom
            // 
            this.btnEliminarCom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEliminarCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCom.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnEliminarCom.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarCom.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCom.Image")));
            this.btnEliminarCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCom.Location = new System.Drawing.Point(311, 42);
            this.btnEliminarCom.Name = "btnEliminarCom";
            this.btnEliminarCom.Size = new System.Drawing.Size(132, 52);
            this.btnEliminarCom.TabIndex = 2;
            this.btnEliminarCom.Text = "Eilminar";
            this.btnEliminarCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCom.UseVisualStyleBackColor = false;
            this.btnEliminarCom.Click += new System.EventHandler(this.btnEliminarCom_Click);
            // 
            // btnEditarCom
            // 
            this.btnEditarCom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditarCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCom.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnEditarCom.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditarCom.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCom.Image")));
            this.btnEditarCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCom.Location = new System.Drawing.Point(162, 42);
            this.btnEditarCom.Name = "btnEditarCom";
            this.btnEditarCom.Size = new System.Drawing.Size(132, 52);
            this.btnEditarCom.TabIndex = 1;
            this.btnEditarCom.Text = "Editar";
            this.btnEditarCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCom.UseVisualStyleBackColor = false;
            this.btnEditarCom.Click += new System.EventHandler(this.btnEditarCom_Click);
            // 
            // btnAgregarCom
            // 
            this.btnAgregarCom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregarCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCom.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnAgregarCom.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarCom.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCom.Image")));
            this.btnAgregarCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCom.Location = new System.Drawing.Point(12, 42);
            this.btnAgregarCom.Name = "btnAgregarCom";
            this.btnAgregarCom.Size = new System.Drawing.Size(132, 52);
            this.btnAgregarCom.TabIndex = 0;
            this.btnAgregarCom.Text = "Agregar";
            this.btnAgregarCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCom.UseVisualStyleBackColor = false;
            this.btnAgregarCom.Click += new System.EventHandler(this.btnAgregarCom_Click);
            // 
            // gpCompras
            // 
            this.gpCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.gpCompras.Controls.Add(this.btnAgregarItemsCom);
            this.gpCompras.Controls.Add(this.txtTotal);
            this.gpCompras.Controls.Add(this.label3);
            this.gpCompras.Controls.Add(this.dateFechaCompra);
            this.gpCompras.Controls.Add(this.cmbUsuario);
            this.gpCompras.Controls.Add(this.label11);
            this.gpCompras.Controls.Add(this.txtCodigoCompras);
            this.gpCompras.Controls.Add(this.label4);
            this.gpCompras.Controls.Add(this.label1);
            this.gpCompras.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCompras.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpCompras.Location = new System.Drawing.Point(29, 16);
            this.gpCompras.Name = "gpCompras";
            this.gpCompras.Size = new System.Drawing.Size(774, 118);
            this.gpCompras.TabIndex = 12;
            this.gpCompras.TabStop = false;
            this.gpCompras.Text = "Compras";
            // 
            // btnAgregarItemsCom
            // 
            this.btnAgregarItemsCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarItemsCom.Enabled = false;
            this.btnAgregarItemsCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItemsCom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItemsCom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAgregarItemsCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarItemsCom.Location = new System.Drawing.Point(577, 72);
            this.btnAgregarItemsCom.Name = "btnAgregarItemsCom";
            this.btnAgregarItemsCom.Size = new System.Drawing.Size(190, 37);
            this.btnAgregarItemsCom.TabIndex = 3;
            this.btnAgregarItemsCom.Text = "Agregar Items a Compra";
            this.btnAgregarItemsCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarItemsCom.UseVisualStyleBackColor = false;
            this.btnAgregarItemsCom.Click += new System.EventHandler(this.btbAgregarItemsCom_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(302, 72);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 27);
            this.txtTotal.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(231, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total";
            // 
            // dateFechaCompra
            // 
            this.dateFechaCompra.CustomFormat = "";
            this.dateFechaCompra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaCompra.Location = new System.Drawing.Point(472, 26);
            this.dateFechaCompra.Name = "dateFechaCompra";
            this.dateFechaCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateFechaCompra.Size = new System.Drawing.Size(295, 27);
            this.dateFechaCompra.TabIndex = 20;
            this.dateFechaCompra.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(273, 26);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 27);
            this.cmbUsuario.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Location = new System.Drawing.Point(208, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Usuario";
            // 
            // txtCodigoCompras
            // 
            this.txtCodigoCompras.Enabled = false;
            this.txtCodigoCompras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCompras.Location = new System.Drawing.Point(90, 26);
            this.txtCodigoCompras.Name = "txtCodigoCompras";
            this.txtCodigoCompras.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoCompras.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(409, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.groupBox1.Controls.Add(this.txtCodigoDetalleCompra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTableDetalleCompra);
            this.groupBox1.Controls.Add(this.btnGuardarCompra);
            this.groupBox1.Controls.Add(this.btnAgregarItems);
            this.groupBox1.Controls.Add(this.numCantidad);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbLibros);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(668, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 414);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla Detalle Compras";
            // 
            // txtCodigoDetalleCompra
            // 
            this.txtCodigoDetalleCompra.Enabled = false;
            this.txtCodigoDetalleCompra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDetalleCompra.Location = new System.Drawing.Point(27, 63);
            this.txtCodigoDetalleCompra.Name = "txtCodigoDetalleCompra";
            this.txtCodigoDetalleCompra.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoDetalleCompra.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código";
            // 
            // dtTableDetalleCompra
            // 
            this.dtTableDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtTableDetalleCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtTableDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTableDetalleCompra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtTableDetalleCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.dtTableDetalleCompra.Location = new System.Drawing.Point(6, 108);
            this.dtTableDetalleCompra.Name = "dtTableDetalleCompra";
            this.dtTableDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTableDetalleCompra.Size = new System.Drawing.Size(612, 244);
            this.dtTableDetalleCompra.TabIndex = 2;
            this.dtTableDetalleCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTableDetalleCompra_CellClick);
            this.dtTableDetalleCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTableDetalleCompra_CellContentClick);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGuardarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCompra.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnGuardarCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCompra.Location = new System.Drawing.Point(417, 362);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(169, 43);
            this.btnGuardarCompra.TabIndex = 3;
            this.btnGuardarCompra.Text = "Guardar Compra";
            this.btnGuardarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCompra.UseVisualStyleBackColor = false;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // btnAgregarItems
            // 
            this.btnAgregarItems.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregarItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItems.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItems.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarItems.Location = new System.Drawing.Point(27, 362);
            this.btnAgregarItems.Name = "btnAgregarItems";
            this.btnAgregarItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarItems.Size = new System.Drawing.Size(54, 37);
            this.btnAgregarItems.TabIndex = 25;
            this.btnAgregarItems.Text = "+";
            this.btnAgregarItems.UseVisualStyleBackColor = false;
            this.btnAgregarItems.Click += new System.EventHandler(this.btnAgregarDetalleCom_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.Enabled = false;
            this.numCantidad.Location = new System.Drawing.Point(472, 68);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 27);
            this.numCantidad.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Location = new System.Drawing.Point(397, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(482, 26);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(110, 27);
            this.txtPrecio.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Location = new System.Drawing.Point(410, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Precio";
            // 
            // cmbLibros
            // 
            this.cmbLibros.Enabled = false;
            this.cmbLibros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(192, 69);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(195, 27);
            this.cmbLibros.TabIndex = 22;
            this.cmbLibros.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Location = new System.Drawing.Point(133, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Libros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(128, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(207, 26);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 27);
            this.cmbCategoria.TabIndex = 21;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1323, 699);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpCompras);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTablaCompras)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gpCompras.ResumeLayout(false);
            this.gpCompras.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTableDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBuscarCompras;
        private System.Windows.Forms.ComboBox cmbPorCompras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateTableCom;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarCom;
        private System.Windows.Forms.Button btnEditarCom;
        private System.Windows.Forms.Button btnAgregarCom;
        private System.Windows.Forms.GroupBox gpCompras;
        private System.Windows.Forms.TextBox txtCodigoCompras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtTablaCompras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAgregarItems;
        private System.Windows.Forms.DataGridView dtTableDetalleCompra;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.TextBox txtCodigoDetalleCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFechaCompra;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarItemsCom;
    }
}