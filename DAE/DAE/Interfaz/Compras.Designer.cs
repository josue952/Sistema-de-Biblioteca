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
            this.txtFechaCom = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.txtPrecioLibro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoCompras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerCompUnit = new System.Windows.Forms.Button();
            this.btnVerCompAgrp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTablaCompras)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpCompras.SuspendLayout();
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
            this.groupBox4.Location = new System.Drawing.Point(228, 746);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1285, 114);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscador";
            // 
            // txtBuscarCompras
            // 
            this.txtBuscarCompras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCompras.Location = new System.Drawing.Point(156, 49);
            this.txtBuscarCompras.Name = "txtBuscarCompras";
            this.txtBuscarCompras.Size = new System.Drawing.Size(177, 27);
            this.txtBuscarCompras.TabIndex = 6;
            // 
            // cmbPorCompras
            // 
            this.cmbPorCompras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorCompras.FormattingEnabled = true;
            this.cmbPorCompras.Location = new System.Drawing.Point(462, 48);
            this.cmbPorCompras.Name = "cmbPorCompras";
            this.cmbPorCompras.Size = new System.Drawing.Size(202, 27);
            this.cmbPorCompras.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(388, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Por";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(39, 48);
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
            this.btnUpdateTableCom.Location = new System.Drawing.Point(1111, 34);
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
            this.btnFiltrar.Location = new System.Drawing.Point(797, 34);
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
            this.groupBox3.Location = new System.Drawing.Point(228, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1285, 571);
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
            this.dtTablaCompras.Size = new System.Drawing.Size(1273, 546);
            this.dtTablaCompras.TabIndex = 1;
            this.dtTablaCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTablaCompras_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarCom);
            this.groupBox2.Controls.Add(this.btnEditarCom);
            this.groupBox2.Controls.Add(this.btnAgregarCom);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(1049, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 118);
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
            this.btnEliminarCom.Location = new System.Drawing.Point(476, 42);
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
            this.btnEditarCom.Location = new System.Drawing.Point(268, 42);
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
            this.btnAgregarCom.Location = new System.Drawing.Point(44, 42);
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
            this.gpCompras.Controls.Add(this.txtFechaCom);
            this.gpCompras.Controls.Add(this.cmbUsuario);
            this.gpCompras.Controls.Add(this.label11);
            this.gpCompras.Controls.Add(this.cmbEditorial);
            this.gpCompras.Controls.Add(this.label2);
            this.gpCompras.Controls.Add(this.cmbLibros);
            this.gpCompras.Controls.Add(this.txtPrecioLibro);
            this.gpCompras.Controls.Add(this.label8);
            this.gpCompras.Controls.Add(this.txtCodigoCompras);
            this.gpCompras.Controls.Add(this.label4);
            this.gpCompras.Controls.Add(this.label3);
            this.gpCompras.Controls.Add(this.label1);
            this.gpCompras.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCompras.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpCompras.Location = new System.Drawing.Point(29, 16);
            this.gpCompras.Name = "gpCompras";
            this.gpCompras.Size = new System.Drawing.Size(1005, 118);
            this.gpCompras.TabIndex = 12;
            this.gpCompras.TabStop = false;
            this.gpCompras.Text = "Compras";
            // 
            // txtFechaCom
            // 
            this.txtFechaCom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCom.Location = new System.Drawing.Point(277, 71);
            this.txtFechaCom.Name = "txtFechaCom";
            this.txtFechaCom.Size = new System.Drawing.Size(219, 27);
            this.txtFechaCom.TabIndex = 20;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(856, 27);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 27);
            this.cmbUsuario.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Location = new System.Drawing.Point(791, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Usuario";
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(584, 26);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(169, 27);
            this.cmbEditorial.TabIndex = 17;
            this.cmbEditorial.SelectedIndexChanged += new System.EventHandler(this.cmbEditorial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(511, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Editorial";
            // 
            // cmbLibros
            // 
            this.cmbLibros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(262, 28);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(234, 27);
            this.cmbLibros.TabIndex = 15;
            this.cmbLibros.SelectedIndexChanged += new System.EventHandler(this.cmbLibros_SelectedIndexChanged);
            // 
            // txtPrecioLibro
            // 
            this.txtPrecioLibro.Enabled = false;
            this.txtPrecioLibro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioLibro.Location = new System.Drawing.Point(698, 71);
            this.txtPrecioLibro.Name = "txtPrecioLibro";
            this.txtPrecioLibro.Size = new System.Drawing.Size(110, 27);
            this.txtPrecioLibro.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(638, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total";
            // 
            // txtCodigoCompras
            // 
            this.txtCodigoCompras.Enabled = false;
            this.txtCodigoCompras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCompras.Location = new System.Drawing.Point(89, 27);
            this.txtCodigoCompras.Name = "txtCodigoCompras";
            this.txtCodigoCompras.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoCompras.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(224, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(205, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // btnVerCompUnit
            // 
            this.btnVerCompUnit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVerCompUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCompUnit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCompUnit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerCompUnit.Location = new System.Drawing.Point(40, 288);
            this.btnVerCompUnit.Name = "btnVerCompUnit";
            this.btnVerCompUnit.Size = new System.Drawing.Size(154, 76);
            this.btnVerCompUnit.TabIndex = 16;
            this.btnVerCompUnit.Text = "Compras Unitarias";
            this.btnVerCompUnit.UseVisualStyleBackColor = false;
            this.btnVerCompUnit.Click += new System.EventHandler(this.btnVerCompUnit_Click);
            // 
            // btnVerCompAgrp
            // 
            this.btnVerCompAgrp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVerCompAgrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCompAgrp.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCompAgrp.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerCompAgrp.Location = new System.Drawing.Point(40, 491);
            this.btnVerCompAgrp.Name = "btnVerCompAgrp";
            this.btnVerCompAgrp.Size = new System.Drawing.Size(154, 76);
            this.btnVerCompAgrp.TabIndex = 17;
            this.btnVerCompAgrp.Text = "Compras Agrupadas";
            this.btnVerCompAgrp.UseVisualStyleBackColor = false;
            this.btnVerCompAgrp.Click += new System.EventHandler(this.btnVerCompAgrp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Location = new System.Drawing.Point(51, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 40);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ver por \r\nCompras Unitarias";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Location = new System.Drawing.Point(51, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 40);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ver por \r\nCompras Agrupadas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1720, 888);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVerCompAgrp);
            this.Controls.Add(this.btnVerCompUnit);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtPrecioLibro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoCompras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnVerCompUnit;
        public System.Windows.Forms.Button btnVerCompAgrp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.DataGridView dtTablaCompras;
        private System.Windows.Forms.TextBox txtFechaCom;
    }
}