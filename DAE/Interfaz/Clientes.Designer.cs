﻿namespace DAE.Interfaz
{
    partial class frmClientes
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
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.cbPorClientes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpClientes = new System.Windows.Forms.GroupBox();
            this.txtDireccionClientes = new System.Windows.Forms.TextBox();
            this.txtApellidoClientes = new System.Windows.Forms.TextBox();
            this.txtNombreClientes = new System.Windows.Forms.TextBox();
            this.txtCodigoClientes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBuscarClientes);
            this.groupBox4.Controls.Add(this.cbPorClientes);
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
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Location = new System.Drawing.Point(102, 32);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(100, 27);
            this.txtBuscarClientes.TabIndex = 6;
            // 
            // cbPorClientes
            // 
            this.cbPorClientes.FormattingEnabled = true;
            this.cbPorClientes.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Apellido"});
            this.cbPorClientes.Location = new System.Drawing.Point(350, 31);
            this.cbPorClientes.Name = "cbPorClientes";
            this.cbPorClientes.Size = new System.Drawing.Size(121, 28);
            this.cbPorClientes.TabIndex = 5;
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
            this.groupBox3.Controls.Add(this.dtClientes);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(38, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 200);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla Clientes";
            // 
            // dtClientes
            // 
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.dtClientes.Location = new System.Drawing.Point(6, 19);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.Size = new System.Drawing.Size(514, 175);
            this.dtClientes.TabIndex = 0;
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
            // gpClientes
            // 
            this.gpClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.gpClientes.Controls.Add(this.txtDireccionClientes);
            this.gpClientes.Controls.Add(this.txtApellidoClientes);
            this.gpClientes.Controls.Add(this.txtNombreClientes);
            this.gpClientes.Controls.Add(this.txtCodigoClientes);
            this.gpClientes.Controls.Add(this.label5);
            this.gpClientes.Controls.Add(this.label3);
            this.gpClientes.Controls.Add(this.label2);
            this.gpClientes.Controls.Add(this.label1);
            this.gpClientes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpClientes.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpClientes.Location = new System.Drawing.Point(29, 16);
            this.gpClientes.Name = "gpClientes";
            this.gpClientes.Size = new System.Drawing.Size(535, 118);
            this.gpClientes.TabIndex = 12;
            this.gpClientes.TabStop = false;
            this.gpClientes.Text = "Clientes";
            // 
            // txtDireccionClientes
            // 
            this.txtDireccionClientes.Location = new System.Drawing.Point(359, 71);
            this.txtDireccionClientes.Name = "txtDireccionClientes";
            this.txtDireccionClientes.Size = new System.Drawing.Size(100, 27);
            this.txtDireccionClientes.TabIndex = 10;
            // 
            // txtApellidoClientes
            // 
            this.txtApellidoClientes.Location = new System.Drawing.Point(359, 26);
            this.txtApellidoClientes.Name = "txtApellidoClientes";
            this.txtApellidoClientes.Size = new System.Drawing.Size(100, 27);
            this.txtApellidoClientes.TabIndex = 7;
            // 
            // txtNombreClientes
            // 
            this.txtNombreClientes.Location = new System.Drawing.Point(111, 75);
            this.txtNombreClientes.Name = "txtNombreClientes";
            this.txtNombreClientes.Size = new System.Drawing.Size(100, 27);
            this.txtNombreClientes.TabIndex = 6;
            // 
            // txtCodigoClientes
            // 
            this.txtCodigoClientes.Location = new System.Drawing.Point(111, 27);
            this.txtCodigoClientes.Name = "txtCodigoClientes";
            this.txtCodigoClientes.Size = new System.Drawing.Size(100, 27);
            this.txtCodigoClientes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(281, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(281, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(592, 582);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpClientes);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gpClientes.ResumeLayout(false);
            this.gpClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.ComboBox cbPorClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpClientes;
        private System.Windows.Forms.TextBox txtDireccionClientes;
        private System.Windows.Forms.TextBox txtApellidoClientes;
        private System.Windows.Forms.TextBox txtNombreClientes;
        private System.Windows.Forms.TextBox txtCodigoClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}