using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using DevExpress.XtraSplashScreen;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace HISSMS
{
    public partial class FormHISSMS : RibbonForm
    {
        static public string[] arrayThamSo = null;
        static public OracleConnection conn = null;
        static public string conn_string = null;

        public FormHISSMS()
        {
            InitializeComponent();
            arrayThamSo = new string[13];
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.Name == "HIS")
                    {
                        conn_string = cs.ConnectionString;
                        conn = DBUtils.GetDBConnection(conn_string);
                        conn.Open();
                        loadThamSo();
                    }
                }  
            }
        }

        private void loadThamSo()
        {
            string sql = "select * from sms_thamso";
            try
            {
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    arrayThamSo[int.Parse(dt.Rows[0]["ID"].ToString())-1] = dt.Rows[0]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[1]["ID"].ToString())-1] = dt.Rows[1]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[2]["ID"].ToString())-1] = dt.Rows[2]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[3]["ID"].ToString())-1] = dt.Rows[3]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[4]["ID"].ToString())-1] = dt.Rows[4]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[5]["ID"].ToString())-1] = dt.Rows[5]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[6]["ID"].ToString())-1] = dt.Rows[6]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[7]["ID"].ToString())-1] = dt.Rows[7]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[8]["ID"].ToString())-1] = dt.Rows[8]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[9]["ID"].ToString())-1] = dt.Rows[9]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[10]["ID"].ToString())-1] = dt.Rows[10]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[11]["ID"].ToString())-1] = dt.Rows[11]["GIATRI"].ToString();
                    arrayThamSo[int.Parse(dt.Rows[12]["ID"].ToString())-1] = dt.Rows[12]["GIATRI"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDSBN_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this.ParentForm, typeof(WaitForm), true, true, false);
            try
            {
                int pagecount = xtraTabControlMain.TabPages.Count;
                Boolean found = false;
                for (int i = 0; i < pagecount; i++)
                {
                    if (xtraTabControlMain.TabPages[i].Name == "xtraTabPageSMS")
                    {
                        found = true;
                        xtraTabControlMain.SelectedTabPage = xtraTabControlMain.TabPages[i];
                    }
                }
                if (!found)
                {
                    XtraTabPage xtraTabPageSMS = new DevExpress.XtraTab.XtraTabPage();
                    xtraTabPageSMS.Name = "xtraTabPageSMS";
                    xtraTabPageSMS.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                    xtraTabPageSMS.Text = "Danh sách hẹn tái khám";
                    XtraUserControlSMS userControlSMS = new XtraUserControlSMS();
                    userControlSMS.Dock = DockStyle.Fill;
                    xtraTabPageSMS.Controls.Add(userControlSMS);
                    xtraTabControlMain.TabPages.Add(xtraTabPageSMS);
                    xtraTabControlMain.SelectedTabPage = xtraTabPageSMS;
                }
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControlMain.TabPages.Remove(((XtraTabControl)sender).SelectedTabPage);
        }

        private void btnThamSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            int pagecount = xtraTabControlMain.TabPages.Count;
            Boolean found = false;
            for (int i = 0; i < pagecount; i++)
            {
                if (xtraTabControlMain.TabPages[i].Name == "xtraTabPageThamSo")
                {
                    found = true;
                    xtraTabControlMain.SelectedTabPage = xtraTabControlMain.TabPages[i];
                }
            }
            if (!found)
            {
                XtraTabPage xtraTabPageThamSo = new DevExpress.XtraTab.XtraTabPage();
                xtraTabPageThamSo.Name = "xtraTabPageThamSo";
                xtraTabPageThamSo.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                xtraTabPageThamSo.Text = "Tham số";
                XtraUserControlThamSo userControlThamSo = new XtraUserControlThamSo();
                userControlThamSo.Dock = DockStyle.Fill;
                xtraTabPageThamSo.Controls.Add(userControlThamSo);
                xtraTabControlMain.TabPages.Add(xtraTabPageThamSo);
                xtraTabControlMain.SelectedTabPage = xtraTabPageThamSo;
            }
        }

        private void barButtonItemMau20_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this.ParentForm, typeof(WaitForm), true, true, false);
            try
            {
                int pagecount = xtraTabControlMain.TabPages.Count;
                Boolean found = false;
                for (int i = 0; i < pagecount; i++)
                {
                    if (xtraTabControlMain.TabPages[i].Name == "xtraTabPageBaoCao")
                    {
                        found = true;
                        xtraTabControlMain.SelectedTabPage = xtraTabControlMain.TabPages[i];
                    }
                }
                if (!found)
                {
                    XtraTabPage xtraTabPageBaoCao = new DevExpress.XtraTab.XtraTabPage();
                    xtraTabPageBaoCao.Name = "xtraTabPageBaoCao";
                    xtraTabPageBaoCao.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                    xtraTabPageBaoCao.Text = "Báo cáo";
                    XtraUserControlBaoCao userControlBaoCao = new XtraUserControlBaoCao();
                    userControlBaoCao.Dock = DockStyle.Fill;
                    xtraTabPageBaoCao.Controls.Add(userControlBaoCao);
                    xtraTabControlMain.TabPages.Add(xtraTabPageBaoCao);
                    xtraTabControlMain.SelectedTabPage = xtraTabPageBaoCao;
                }
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }
    }
}