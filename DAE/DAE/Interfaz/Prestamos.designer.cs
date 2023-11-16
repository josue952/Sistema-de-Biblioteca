
namespace DAE.Interfaz
{
    partial class frmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregarItemsPre = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoPrestamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPrestamo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStockDisponible = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarItems = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigoDetallePrestamo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDetallePrestamo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.groupBox1.Controls.Add(this.dateFechaPrestamo);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.btnAgregarItemsPre);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCodigoPrestamo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtPrestamo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestamos";
            // 
            // dateFechaPrestamo
            // 
            this.dateFechaPrestamo.CustomFormat = "";
            this.dateFechaPrestamo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaPrestamo.Location = new System.Drawing.Point(291, 29);
            this.dateFechaPrestamo.Name = "dateFechaPrestamo";
            this.dateFechaPrestamo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateFechaPrestamo.Size = new System.Drawing.Size(158, 22);
            this.dateFechaPrestamo.TabIndex = 33;
            this.dateFechaPrestamo.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnEditar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Location = new System.Drawing.Point(737, 40);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(197, 209);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(32, 141);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 52);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(32, 81);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 52);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(32, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 52);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(291, 82);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(110, 22);
            this.txtUsuario.TabIndex = 32;
            // 
            // btnAgregarItemsPre
            // 
            this.btnAgregarItemsPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarItemsPre.Enabled = false;
            this.btnAgregarItemsPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItemsPre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItemsPre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAgregarItemsPre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarItemsPre.Location = new System.Drawing.Point(449, 71);
            this.btnAgregarItemsPre.Name = "btnAgregarItemsPre";
            this.btnAgregarItemsPre.Size = new System.Drawing.Size(221, 37);
            this.btnAgregarItemsPre.TabIndex = 25;
            this.btnAgregarItemsPre.Text = "Agregar items al prestamo";
            this.btnAgregarItemsPre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarItemsPre.UseVisualStyleBackColor = false;
            this.btnAgregarItemsPre.Click += new System.EventHandler(this.btnAgregarItemsPre_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Location = new System.Drawing.Point(225, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Usuario";
            // 
            // txtCodigoPrestamo
            // 
            this.txtCodigoPrestamo.Enabled = false;
            this.txtCodigoPrestamo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPrestamo.Location = new System.Drawing.Point(94, 51);
            this.txtCodigoPrestamo.Name = "txtCodigoPrestamo";
            this.txtCodigoPrestamo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoPrestamo.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(225, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código";
            // 
            // dtPrestamo
            // 
            this.dtPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPrestamo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPrestamo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtPrestamo.Location = new System.Drawing.Point(47, 120);
            this.dtPrestamo.Name = "dtPrestamo";
            this.dtPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPrestamo.Size = new System.Drawing.Size(651, 142);
            this.dtPrestamo.TabIndex = 0;
            this.dtPrestamo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPrestamo_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtStockDisponible);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAgregarItems);
            this.groupBox2.Controls.Add(this.btnRealizarPedido);
            this.groupBox2.Controls.Add(this.numCantidad);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbLibros);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.txtCodigoDetallePrestamo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtDetallePrestamo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(25, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del prestamo";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(726, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 52);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Enabled = false;
            this.txtStockDisponible.Location = new System.Drawing.Point(548, 65);
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.Size = new System.Drawing.Size(55, 22);
            this.txtStockDisponible.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(520, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Stock Disponible";
            // 
            // btnAgregarItems
            // 
            this.btnAgregarItems.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregarItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItems.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItems.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarItems.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarItems.Image")));
            this.btnAgregarItems.Location = new System.Drawing.Point(584, 127);
            this.btnAgregarItems.Name = "btnAgregarItems";
            this.btnAgregarItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarItems.Size = new System.Drawing.Size(54, 37);
            this.btnAgregarItems.TabIndex = 44;
            this.btnAgregarItems.UseVisualStyleBackColor = false;
            this.btnAgregarItems.Click += new System.EventHandler(this.btnAgregarItems_Click);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.BackColor = System.Drawing.Color.Lime;
            this.btnRealizarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPedido.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarPedido.Location = new System.Drawing.Point(726, 174);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(131, 45);
            this.btnRealizarPedido.TabIndex = 43;
            this.btnRealizarPedido.Text = "Realizar Prestamo";
            this.btnRealizarPedido.UseVisualStyleBackColor = false;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(376, 86);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 22);
            this.numCantidad.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Location = new System.Drawing.Point(292, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "Cantidad";
            // 
            // cmbLibros
            // 
            this.cmbLibros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(77, 84);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(195, 27);
            this.cmbLibros.TabIndex = 40;
            this.cmbLibros.UseWaitCursor = true;
            this.cmbLibros.SelectedIndexChanged += new System.EventHandler(this.cmbLibros_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Location = new System.Drawing.Point(22, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Libros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(208, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(296, 39);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 27);
            this.cmbCategoria.TabIndex = 37;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtCodigoDetallePrestamo
            // 
            this.txtCodigoDetallePrestamo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDetallePrestamo.Location = new System.Drawing.Point(77, 35);
            this.txtCodigoDetallePrestamo.Name = "txtCodigoDetallePrestamo";
            this.txtCodigoDetallePrestamo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoDetallePrestamo.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Código";
            // 
            // dtDetallePrestamo
            // 
            this.dtDetallePrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDetallePrestamo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDetallePrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetallePrestamo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtDetallePrestamo.Location = new System.Drawing.Point(26, 127);
            this.dtDetallePrestamo.Name = "dtDetallePrestamo";
            this.dtDetallePrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDetallePrestamo.Size = new System.Drawing.Size(542, 166);
            this.dtDetallePrestamo.TabIndex = 0;
            this.dtDetallePrestamo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDetallePrestamo_CellClick);
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1009, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtPrestamo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtDetallePrestamo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAgregarItemsPre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoDetallePrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dateFechaPrestamo;
        private System.Windows.Forms.Button btnAgregarItems;
        private System.Windows.Forms.TextBox txtStockDisponible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
    }
}