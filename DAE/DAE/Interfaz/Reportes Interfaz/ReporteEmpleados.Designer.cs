namespace DAE.Interfaz.Reportes_Interfaz
{
    partial class frmRptEmpleados
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
            this.RptEmpleadosViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RptEmpleadosViewer
            // 
            this.RptEmpleadosViewer.ActiveViewIndex = 0;
            this.RptEmpleadosViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptEmpleadosViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptEmpleadosViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptEmpleadosViewer.Location = new System.Drawing.Point(0, 0);
            this.RptEmpleadosViewer.Name = "RptEmpleadosViewer";
            this.RptEmpleadosViewer.ReportSource = "C:\\Users\\josue\\source\\repos\\josue952\\Sistema-de-Biblioteca\\DAE\\DAE\\Reportes\\RptEm" +
    "pleados.rpt";
            this.RptEmpleadosViewer.ShowGroupTreeButton = false;
            this.RptEmpleadosViewer.ShowLogo = false;
            this.RptEmpleadosViewer.ShowParameterPanelButton = false;
            this.RptEmpleadosViewer.Size = new System.Drawing.Size(800, 450);
            this.RptEmpleadosViewer.TabIndex = 0;
            this.RptEmpleadosViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRptEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RptEmpleadosViewer);
            this.Name = "frmRptEmpleados";
            this.Text = "ReporteEmpleados";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptEmpleadosViewer;
    }
}