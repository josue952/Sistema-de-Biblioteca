using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
//necesario cargar parael reporte
using CrystalDecisions.Shared;
using DAE.Reportes;
using CrystalDecisions.ReportSource;

namespace DAE.Interfaz.Reportes_Interfaz
{
    public partial class frmRptComprasxMes : Form
    {
        //definir variables globales
        ParameterFields parametros1 = new ParameterFields();//variable de tipo array
        ParameterFields parametros2 = new ParameterFields();//variable de tipo array
        //variable de tipo parametro
        ParameterField FechaInicio = new ParameterField();
        ParameterField FechaFin = new ParameterField();
        //variable para guardar el valor que ira en el parametro
        ParameterDiscreteValue valor1 = new ParameterDiscreteValue();
        ParameterDiscreteValue valor2 = new ParameterDiscreteValue();
        public frmRptComprasxMes()
        {
            InitializeComponent();
        }
         
        private void btnGenerarRptUserByRol_Click(object sender, EventArgs e)
        {
            //asignar el tipo de dato al valor del parametro
            this.FechaInicio.ParameterValueType = ParameterValueKind.DateParameter;
            this.FechaFin.ParameterValueType = ParameterValueKind.DateParameter;
            //asignar el nombre del parametro segun el procedimiento almacenado
            this.FechaInicio.Name = "FechaInicio";
            this.valor1.Value = this.dateFechaInicio.Text;//capturar el valor del control en el formulario
            this.FechaFin.Name = "FechaFin";
            this.valor2.Value = this.dateFechaFin.Text;//capturar el valor del control en el formulario
            //pasando el valor al parametro
            this.FechaInicio.CurrentValues.Add(valor1);
            this.FechaFin.CurrentValues.Add(valor2);
            //agregando el parametro al array
            this.parametros1.Add(FechaInicio);
            this.parametros1.Add(FechaFin);
            //definir parametros para el reporte
            this.RptComprasView.ParameterFieldInfo = parametros1;
            //declaracion del objeto que representa el reporte
            RptComprasXmes rpt = new RptComprasXmes();
            //asignar el reporte al que se vera en el control viewer
            this.RptComprasView.ReportSource = rpt;
        }

        private void ReporteComprasPorMes_Load(object sender, EventArgs e)
        {

        }

    }
}
