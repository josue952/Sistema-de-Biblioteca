namespace DAE.Interfaz.Reportes_Interfaz
{
    partial class frmRptProveedor
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
            this.frmRptProveedores = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // frmRptProveedores
            // 
            this.frmRptProveedores.ActiveViewIndex = 0;
            this.frmRptProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmRptProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.frmRptProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmRptProveedores.Location = new System.Drawing.Point(0, 0);
            this.frmRptProveedores.Name = "frmRptProveedores";
            this.frmRptProveedores.ReportSource = "C:\\Users\\josue\\source\\repos\\josue952\\Sistema-de-Biblioteca\\DAE\\DAE\\Reportes\\RptPr" +
    "oveedores.rpt";
            this.frmRptProveedores.ShowGroupTreeButton = false;
            this.frmRptProveedores.ShowLogo = false;
            this.frmRptProveedores.ShowParameterPanelButton = false;
            this.frmRptProveedores.Size = new System.Drawing.Size(800, 450);
            this.frmRptProveedores.TabIndex = 0;
            this.frmRptProveedores.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRptProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmRptProveedores);
            this.Name = "frmRptProveedor";
            this.Text = "ReporteProveedores";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer frmRptProveedores;
    }
}