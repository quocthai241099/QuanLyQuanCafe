using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyQuanCafeApp
{
    public partial class InHoaDon : Form
    {
        public InHoaDon(int id)
        {
            InitializeComponent();
            HoaDonReport rpt = new HoaDonReport();
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sql", "sa2012", "DESKTOP-AGVC0GA\\SQLEXPRESS", "QuanLyQuanCafe");
            
            rpt.SetParameterValue("InHoaDon", id);
        }
    }
}
