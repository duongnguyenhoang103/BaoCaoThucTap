using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeMoQLSV1.Report
{
    public partial class frmRP_DiemCaNamSV : Form
    {
        public frmRP_DiemCaNamSV()
        {
            InitializeComponent();
        }
        public string paratext_maK { set; get; }
        public string paratext_maN { set; get; }
        public string paratext_maL { set; get; }
        public string paratext_maSV { set; get; }

        private void crpv_DiemCaNamSV_Load(object sender, EventArgs e)
        {
            RP_DiemCaNamSV rp = new RP_DiemCaNamSV();
            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue b = new ParameterDiscreteValue();
            ParameterFieldDefinitions c;
            ParameterFieldDefinition d;

            b.Value = paratext_maK.ToString();
            c = rp.DataDefinition.ParameterFields;
            d = c["@maK"];
            a = d.CurrentValues;

            a.Clear();
            a.Add(b);
            d.ApplyCurrentValues(a);
            //Ma nghanh
            ParameterValues a1 = new ParameterValues();
            ParameterDiscreteValue b1 = new ParameterDiscreteValue();
            ParameterFieldDefinitions c1;
            ParameterFieldDefinition d1;
            b1.Value = paratext_maN.ToString();
            c1 = rp.DataDefinition.ParameterFields;
            d1 = c1["@maN"];
            a1 = d1.CurrentValues;

            a1.Clear();
            a1.Add(b1);
            d1.ApplyCurrentValues(a1);
            // Ma lop
            ParameterValues a2 = new ParameterValues();
            ParameterDiscreteValue b2 = new ParameterDiscreteValue();
            ParameterFieldDefinitions c2;
            ParameterFieldDefinition d2;
            b2.Value = paratext_maL.ToString();
            c2 = rp.DataDefinition.ParameterFields;
            d2 = c2["@maL"];
            a2 = d2.CurrentValues;

            a2.Clear();
            a2.Add(b2);
            d2.ApplyCurrentValues(a2);
            //Ma SV
            ParameterValues a4 = new ParameterValues();
            ParameterDiscreteValue b4 = new ParameterDiscreteValue();
            ParameterFieldDefinitions c4;
            ParameterFieldDefinition d4;

            b4.Value = paratext_maSV.ToString();
            c4 = rp.DataDefinition.ParameterFields;
            d4 = c4["@maSV"];
            a4 = d4.CurrentValues;

            a4.Clear();
            a4.Add(b4);
            d4.ApplyCurrentValues(a4);
      

            crpv_DiemCaNamSV.ReportSource = rp;
            crpv_DiemCaNamSV.Refresh();
        }
    }
}
