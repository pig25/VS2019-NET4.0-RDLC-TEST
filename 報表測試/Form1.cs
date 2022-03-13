using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 報表測試
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", GetProject_Lines());
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            var setup = this.reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.reportViewer1.SetPageSettings(setup);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
        private List<Project_Line> GetProject_Lines()
        {
            List<Project_Line> result = new List<Project_Line>();
            for (int i = 0; i < 104; i++)
            {
                result.Add(new Project_Line { ProjectID = $"一二三四五六七八九十早安午安晚安龜-{i}", ProjectName = i.ToString(), ReMark = "" });
            }
            return result;
        }
    }
}
