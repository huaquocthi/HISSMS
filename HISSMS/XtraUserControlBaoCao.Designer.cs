using DevExpress.XtraGrid.Views.Grid;
namespace HISSMS
{
    partial class XtraUserControlBaoCao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonXem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.stiViewerControl = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateEditDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1176, 75);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButtonXem
            // 
            this.simpleButtonXem.Location = new System.Drawing.Point(352, 33);
            this.simpleButtonXem.Name = "simpleButtonXem";
            this.simpleButtonXem.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonXem.TabIndex = 0;
            this.simpleButtonXem.Text = "Xem";
            this.simpleButtonXem.Click += new System.EventHandler(this.simpleButtonXem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.stiViewerControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 75);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1176, 462);
            this.panelControl2.TabIndex = 2;
            // 
            // stiViewerControl
            // 
            this.stiViewerControl.AllowDrop = true;
            this.stiViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl.Location = new System.Drawing.Point(2, 2);
            this.stiViewerControl.Name = "stiViewerControl";
            this.stiViewerControl.Report = null;
            this.stiViewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl.ShowBookmarksPanel = false;
            this.stiViewerControl.ShowOpen = false;
            this.stiViewerControl.ShowSendEMail = false;
            this.stiViewerControl.ShowSendEMailDocumentFile = false;
            this.stiViewerControl.ShowZoom = true;
            this.stiViewerControl.Size = new System.Drawing.Size(1172, 458);
            this.stiViewerControl.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateEditDenNgay);
            this.groupControl1.Controls.Add(this.simpleButtonXem);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dateEditTuNgay);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(435, 65);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ngày thống kê";
            // 
            // dateEditDenNgay
            // 
            this.dateEditDenNgay.EditValue = null;
            this.dateEditDenNgay.Location = new System.Drawing.Point(242, 33);
            this.dateEditDenNgay.Name = "dateEditDenNgay";
            this.dateEditDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditDenNgay.Size = new System.Drawing.Size(104, 22);
            this.dateEditDenNgay.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(176, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Đến ngày";
            // 
            // dateEditTuNgay
            // 
            this.dateEditTuNgay.EditValue = null;
            this.dateEditTuNgay.Location = new System.Drawing.Point(64, 33);
            this.dateEditTuNgay.Name = "dateEditTuNgay";
            this.dateEditTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditTuNgay.Size = new System.Drawing.Size(104, 22);
            this.dateEditTuNgay.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ ngày";
            // 
            // XtraUserControlBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "XtraUserControlBaoCao";
            this.Size = new System.Drawing.Size(1176, 537);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTuNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEditDenNgay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEditTuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
