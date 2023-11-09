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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCompras = new System.Windows.Forms.TextBox();
            this.cbPorCompras = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpCompras = new System.Windows.Forms.GroupBox();
            this.txtTotalCompras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadCompras = new System.Windows.Forms.TextBox();
            this.txtProveedorCompras = new System.Windows.Forms.TextBox();
            this.txtLibroCompras = new System.Windows.Forms.TextBox();
            this.txtCodigoCompras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaCompras = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBuscarCompras);
            this.groupBox4.Controls.Add(this.cbPorCompras);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnActualizar);
            this.groupBox4.Controls.Add(this.btnFiltrar);
            this.groupBox4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(38, 452);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 114);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscador";
            // 
            // txtBuscarCompras
            // 
            this.txtBuscarCompras.Location = new System.Drawing.Point(102, 32);
            this.txtBuscarCompras.Name = "txtBuscarCompras";
            this.txtBuscarCompras.Size = new System.Drawing.Size(100, 27);
            this.txtBuscarCompras.TabIndex = 6;
            // 
            // cbPorCompras
            // 
            this.cbPorCompras.FormattingEnabled = true;
            this.cbPorCompras.Items.AddRange(new object[] {
            "Fecha",
            "Proveedor",
            "Código"});
            this.cbPorCompras.Location = new System.Drawing.Point(350, 31);
            this.cbPorCompras.Name = "cbPorCompras";
            this.cbPorCompras.Size = new System.Drawing.Size(121, 28);
            this.cbPorCompras.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Por";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 10F);
            this.label6.Location = new System.Drawing.Point(39, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Buscar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualizar.Location = new System.Drawing.Point(359, 73);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 32);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFiltrar.Location = new System.Drawing.Point(102, 73);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(96, 32);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.groupBox3.Controls.Add(this.dtCompras);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(38, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 200);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla Compras";
            // 
            // dtCompras
            // 
            this.dtCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.dtCompras.Location = new System.Drawing.Point(6, 19);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.Size = new System.Drawing.Size(514, 175);
            this.dtCompras.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(38, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 89);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminar.Location = new System.Drawing.Point(386, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eilminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditar.Location = new System.Drawing.Point(212, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 32);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregar.Location = new System.Drawing.Point(52, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gpCompras
            // 
            this.gpCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.gpCompras.Controls.Add(this.fechaCompras);
            this.gpCompras.Controls.Add(this.txtTotalCompras);
            this.gpCompras.Controls.Add(this.label8);
            this.gpCompras.Controls.Add(this.txtCantidadCompras);
            this.gpCompras.Controls.Add(this.txtProveedorCompras);
            this.gpCompras.Controls.Add(this.txtLibroCompras);
            this.gpCompras.Controls.Add(this.txtCodigoCompras);
            this.gpCompras.Controls.Add(this.label5);
            this.gpCompras.Controls.Add(this.label4);
            this.gpCompras.Controls.Add(this.label3);
            this.gpCompras.Controls.Add(this.label2);
            this.gpCompras.Controls.Add(this.label1);
            this.gpCompras.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCompras.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpCompras.Location = new System.Drawing.Point(29, 16);
            this.gpCompras.Name = "gpCompras";
            this.gpCompras.Size = new System.Drawing.Size(535, 118);
            this.gpCompras.TabIndex = 12;
            this.gpCompras.TabStop = false;
            this.gpCompras.Text = "Compras";
            // 
            // txtTotalCompras
            // 
            this.txtTotalCompras.Location = new System.Drawing.Point(429, 72);
            this.txtTotalCompras.Name = "txtTotalCompras";
            this.txtTotalCompras.Size = new System.Drawing.Size(100, 27);
            this.txtTotalCompras.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(365, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total";
            // 
            // txtCantidadCompras
            // 
            this.txtCantidadCompras.Location = new System.Drawing.Point(264, 75);
            this.txtCantidadCompras.Name = "txtCantidadCompras";
            this.txtCantidadCompras.Size = new System.Drawing.Size(100, 27);
            this.txtCantidadCompras.TabIndex = 10;
            // 
            // txtProveedorCompras
            // 
            this.txtProveedorCompras.Location = new System.Drawing.Point(264, 29);
            this.txtProveedorCompras.Name = "txtProveedorCompras";
            this.txtProveedorCompras.Size = new System.Drawing.Size(100, 27);
            this.txtProveedorCompras.TabIndex = 7;
            // 
            // txtLibroCompras
            // 
            this.txtLibroCompras.Location = new System.Drawing.Point(86, 78);
            this.txtLibroCompras.Name = "txtLibroCompras";
            this.txtLibroCompras.Size = new System.Drawing.Size(100, 27);
            this.txtLibroCompras.TabIndex = 6;
            // 
            // txtCodigoCompras
            // 
            this.txtCodigoCompras.Location = new System.Drawing.Point(86, 27);
            this.txtCodigoCompras.Name = "txtCodigoCompras";
            this.txtCodigoCompras.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoCompras.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(193, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(372, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(200, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // fechaCompras
            // 
            this.fechaCompras.Location = new System.Drawing.Point(429, 27);
            this.fechaCompras.Name = "fechaCompras";
            this.fechaCompras.Size = new System.Drawing.Size(90, 27);
            this.fechaCompras.TabIndex = 14;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(592, 582);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpCompras);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gpCompras.ResumeLayout(false);
            this.gpCompras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBuscarCompras;
        private System.Windows.Forms.ComboBox cbPorCompras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtCompras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpCompras;
        private System.Windows.Forms.TextBox txtTotalCompras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadCompras;
        private System.Windows.Forms.TextBox txtProveedorCompras;
        private System.Windows.Forms.TextBox txtLibroCompras;
        private System.Windows.Forms.TextBox txtCodigoCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaCompras;
    }
}