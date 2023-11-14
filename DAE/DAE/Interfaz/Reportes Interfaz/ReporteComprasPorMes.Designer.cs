namespace DAE.Interfaz.Reportes_Interfaz
{
    partial class frmRptComprasxMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptComprasxMes));
            this.RptComprasView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnGenerarRptUserByRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // RptComprasView
            // 
            this.RptComprasView.ActiveViewIndex = -1;
            this.RptComprasView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptComprasView.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptComprasView.Location = new System.Drawing.Point(12, 81);
            this.RptComprasView.Name = "RptComprasView";
            this.RptComprasView.ShowGotoPageButton = false;
            this.RptComprasView.ShowGroupTreeButton = false;
            this.RptComprasView.ShowLogo = false;
            this.RptComprasView.ShowPageNavigateButtons = false;
            this.RptComprasView.ShowParameterPanelButton = false;
            this.RptComprasView.Size = new System.Drawing.Size(1045, 476);
            this.RptComprasView.TabIndex = 0;
            this.RptComprasView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnGenerarRptUserByRol
            // 
            this.btnGenerarRptUserByRol.BackColor = System.Drawing.Color.Green;
            this.btnGenerarRptUserByRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRptUserByRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRptUserByRol.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerarRptUserByRol.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarRptUserByRol.Image")));
            this.btnGenerarRptUserByRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarRptUserByRol.Location = new System.Drawing.Point(833, 14);
            this.btnGenerarRptUserByRol.Name = "btnGenerarRptUserByRol";
            this.btnGenerarRptUserByRol.Size = new System.Drawing.Size(188, 50);
            this.btnGenerarRptUserByRol.TabIndex = 4;
            this.btnGenerarRptUserByRol.Text = "Generar Reporte";
            this.btnGenerarRptUserByRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarRptUserByRol.UseVisualStyleBackColor = false;
            this.btnGenerarRptUserByRol.Click += new System.EventHandler(this.btnGenerarRptUserByRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Fin:";
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaInicio.CustomFormat = "";
            this.dateFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateFechaInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaInicio.Location = new System.Drawing.Point(149, 24);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateFechaInicio.Size = new System.Drawing.Size(211, 27);
            this.dateFechaInicio.TabIndex = 21;
            this.dateFechaInicio.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaFin.CustomFormat = "";
            this.dateFechaFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateFechaFin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaFin.Location = new System.Drawing.Point(552, 22);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateFechaFin.Size = new System.Drawing.Size(211, 27);
            this.dateFechaFin.TabIndex = 22;
            this.dateFechaFin.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // frmRptComprasxMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 569);
            this.Controls.Add(this.dateFechaFin);
            this.Controls.Add(this.dateFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarRptUserByRol);
            this.Controls.Add(this.RptComprasView);
            this.Name = "frmRptComprasxMes";
            this.Text = "ReporteComprasPorMes";
            this.Load += new System.EventHandler(this.ReporteComprasPorMes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptComprasView;
        private System.Windows.Forms.Button btnGenerarRptUserByRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateFechaInicio;
        public System.Windows.Forms.DateTimePicker dateFechaFin;
    }
}