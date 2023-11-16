
namespace DAE.Interfaz
{
    partial class frmListPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPrestamos));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtListadoPrestamos = new System.Windows.Forms.DataGridView();
            this.xd = new System.Windows.Forms.GroupBox();
            this.dtListDetallePrestamo = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAprobarPrestamo = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoPrestamos)).BeginInit();
            this.xd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListDetallePrestamo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.groupBox3.Controls.Add(this.dtListadoPrestamos);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(41, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 221);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Prestamos";
            // 
            // dtListadoPrestamos
            // 
            this.dtListadoPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtListadoPrestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListadoPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListadoPrestamos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtListadoPrestamos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.dtListadoPrestamos.Location = new System.Drawing.Point(6, 19);
            this.dtListadoPrestamos.Name = "dtListadoPrestamos";
            this.dtListadoPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListadoPrestamos.Size = new System.Drawing.Size(598, 184);
            this.dtListadoPrestamos.TabIndex = 1;
            this.dtListadoPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListadoPrestamos_CellContentClick);
            this.dtListadoPrestamos.SelectionChanged += new System.EventHandler(this.dtListadoPrestamos_SelectionChanged);
            // 
            // xd
            // 
            this.xd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.xd.Controls.Add(this.dtListDetallePrestamo);
            this.xd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xd.ForeColor = System.Drawing.Color.Black;
            this.xd.Location = new System.Drawing.Point(41, 274);
            this.xd.Name = "xd";
            this.xd.Size = new System.Drawing.Size(613, 228);
            this.xd.TabIndex = 16;
            this.xd.TabStop = false;
            this.xd.Text = "Detalle del Prestamo";
            // 
            // dtListDetallePrestamo
            // 
            this.dtListDetallePrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtListDetallePrestamo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListDetallePrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListDetallePrestamo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtListDetallePrestamo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(103)))), ((int)(((byte)(138)))));
            this.dtListDetallePrestamo.Location = new System.Drawing.Point(6, 26);
            this.dtListDetallePrestamo.Name = "dtListDetallePrestamo";
            this.dtListDetallePrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListDetallePrestamo.Size = new System.Drawing.Size(598, 184);
            this.dtListDetallePrestamo.TabIndex = 1;
            this.dtListDetallePrestamo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListDetallePrestamo_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnAprobarPrestamo);
            this.groupBox4.Location = new System.Drawing.Point(659, 142);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(197, 243);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(28, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 52);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(26, 99);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAprobarPrestamo
            // 
            this.btnAprobarPrestamo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAprobarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAprobarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobarPrestamo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobarPrestamo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAprobarPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobarPrestamo.Image")));
            this.btnAprobarPrestamo.Location = new System.Drawing.Point(26, 28);
            this.btnAprobarPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAprobarPrestamo.Name = "btnAprobarPrestamo";
            this.btnAprobarPrestamo.Size = new System.Drawing.Size(155, 50);
            this.btnAprobarPrestamo.TabIndex = 1;
            this.btnAprobarPrestamo.Text = "Aprobar Prestamo";
            this.btnAprobarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAprobarPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAprobarPrestamo.UseVisualStyleBackColor = false;
            this.btnAprobarPrestamo.Click += new System.EventHandler(this.btnAprobarPrestamo_Click);
            // 
            // frmListPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(888, 532);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.xd);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmListPrestamos";
            this.Text = "ListPrestamos";
            this.Load += new System.EventHandler(this.frmListPrestamos_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoPrestamos)).EndInit();
            this.xd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListDetallePrestamo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtListadoPrestamos;
        private System.Windows.Forms.GroupBox xd;
        private System.Windows.Forms.DataGridView dtListDetallePrestamo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAprobarPrestamo;
        private System.Windows.Forms.Button btnUpdate;
    }
}