
namespace DevApp.Child_Forms
{
    partial class XtraMDICaixaHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraMDICaixaHistory));
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintHist = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridCaixaHist = new DevExpress.XtraGrid.GridControl();
            this.gridViewCaixaHist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnHistId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblHistPesqFilter = new DevExpress.XtraEditors.LabelControl();
            this.comboHistPesqFuncionario = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblHistPesqFuncionario = new DevExpress.XtraEditors.LabelControl();
            this.lblHistPesqFim = new DevExpress.XtraEditors.LabelControl();
            this.dateHistPesqFim = new DevExpress.XtraEditors.DateEdit();
            this.lblHistPesqInicio = new DevExpress.XtraEditors.LabelControl();
            this.dateHistPesqInicio = new DevExpress.XtraEditors.DateEdit();
            this.radioCaixaLogPesquisa = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboHistPesqFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqFim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioCaixaLogPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element4";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Element5";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnPrintHist);
            this.panelControl2.Location = new System.Drawing.Point(181, 467);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(973, 45);
            this.panelControl2.TabIndex = 30;
            // 
            // btnPrintHist
            // 
            this.btnPrintHist.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintHist.ImageOptions.SvgImage")));
            this.btnPrintHist.Location = new System.Drawing.Point(5, 5);
            this.btnPrintHist.Name = "btnPrintHist";
            this.btnPrintHist.Size = new System.Drawing.Size(94, 35);
            this.btnPrintHist.TabIndex = 2;
            this.btnPrintHist.Text = "Imprimir ";
            this.btnPrintHist.Click += new System.EventHandler(this.btnPrintHist_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridCaixaHist);
            this.panelControl3.Location = new System.Drawing.Point(181, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(973, 466);
            this.panelControl3.TabIndex = 31;
            // 
            // gridCaixaHist
            // 
            this.gridCaixaHist.Location = new System.Drawing.Point(1, 2);
            this.gridCaixaHist.MainView = this.gridViewCaixaHist;
            this.gridCaixaHist.Name = "gridCaixaHist";
            this.gridCaixaHist.Size = new System.Drawing.Size(970, 465);
            this.gridCaixaHist.TabIndex = 29;
            this.gridCaixaHist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCaixaHist});
            // 
            // gridViewCaixaHist
            // 
            this.gridViewCaixaHist.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewCaixaHist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnHistId,
            this.Status,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridViewCaixaHist.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewCaixaHist.GridControl = this.gridCaixaHist;
            this.gridViewCaixaHist.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "endvalue", null, "{0:c}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "endvalueuser", null, "{0:c}")});
            this.gridViewCaixaHist.Name = "gridViewCaixaHist";
            this.gridViewCaixaHist.OptionsBehavior.Editable = false;
            this.gridViewCaixaHist.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCaixaHist.OptionsView.ShowFooter = true;
            this.gridViewCaixaHist.OptionsView.ShowGroupPanel = false;
            this.gridViewCaixaHist.OptionsView.ShowIndicator = false;
            this.gridViewCaixaHist.RowHeight = 25;
            this.gridViewCaixaHist.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewCaixaHist_CustomDrawCell);
            this.gridViewCaixaHist.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewCaixaHist_CustomColumnDisplayText);
            this.gridViewCaixaHist.DoubleClick += new System.EventHandler(this.gridViewCaixaHist_DoubleClick);
            // 
            // clnHistId
            // 
            this.clnHistId.AppearanceCell.Options.UseTextOptions = true;
            this.clnHistId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clnHistId.Caption = "Id";
            this.clnHistId.FieldName = "Id";
            this.clnHistId.Name = "clnHistId";
            this.clnHistId.Visible = true;
            this.clnHistId.VisibleIndex = 0;
            this.clnHistId.Width = 40;
            // 
            // Status
            // 
            this.Status.AppearanceCell.Options.UseTextOptions = true;
            this.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Status.Caption = "Status";
            this.Status.FieldName = "IsOpen";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 1;
            this.Status.Width = 80;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Aberto Em";
            this.gridColumn3.FieldName = "OpenedAt";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 140;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fechado Em";
            this.gridColumn4.FieldName = "ClosedAt";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 140;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Saldo Inicial";
            this.gridColumn5.FieldName = "StartValue";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 90;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Saldo Final";
            this.gridColumn6.FieldName = "EndValue";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "endvalue", "{0:c}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 90;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "S. Final Informado";
            this.gridColumn7.FieldName = "EndValueUser";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "endvalueuser", "{0:c}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Sangria";
            this.gridColumn8.FieldName = "Sangria";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 80;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Despesas";
            this.gridColumn9.FieldName = "Despesas";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 80;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Acrecimos";
            this.gridColumn10.FieldName = "Acrecimos";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 80;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblHistPesqFilter);
            this.groupControl1.Controls.Add(this.comboHistPesqFuncionario);
            this.groupControl1.Controls.Add(this.lblHistPesqFuncionario);
            this.groupControl1.Controls.Add(this.lblHistPesqFim);
            this.groupControl1.Controls.Add(this.dateHistPesqFim);
            this.groupControl1.Controls.Add(this.lblHistPesqInicio);
            this.groupControl1.Controls.Add(this.dateHistPesqInicio);
            this.groupControl1.Controls.Add(this.radioCaixaLogPesquisa);
            this.groupControl1.Location = new System.Drawing.Point(6, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(171, 184);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Pesquisa";
            // 
            // lblHistPesqFilter
            // 
            this.lblHistPesqFilter.Location = new System.Drawing.Point(21, 238);
            this.lblHistPesqFilter.Name = "lblHistPesqFilter";
            this.lblHistPesqFilter.Size = new System.Drawing.Size(127, 13);
            this.lblHistPesqFilter.TabIndex = 15;
            this.lblHistPesqFilter.Text = "Nenhum filtro selecionado.";
            this.lblHistPesqFilter.Visible = false;
            // 
            // comboHistPesqFuncionario
            // 
            this.comboHistPesqFuncionario.EditValue = "Thiago Marquezini";
            this.comboHistPesqFuncionario.Location = new System.Drawing.Point(20, 197);
            this.comboHistPesqFuncionario.Name = "comboHistPesqFuncionario";
            this.comboHistPesqFuncionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboHistPesqFuncionario.Properties.Items.AddRange(new object[] {
            "Sistema",
            "Thiago Marquezini"});
            this.comboHistPesqFuncionario.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboHistPesqFuncionario.Size = new System.Drawing.Size(132, 20);
            this.comboHistPesqFuncionario.TabIndex = 14;
            this.comboHistPesqFuncionario.Visible = false;
            this.comboHistPesqFuncionario.SelectedIndexChanged += new System.EventHandler(this.comboHistPesqFuncionario_SelectedIndexChanged);
            // 
            // lblHistPesqFuncionario
            // 
            this.lblHistPesqFuncionario.Location = new System.Drawing.Point(21, 182);
            this.lblHistPesqFuncionario.Name = "lblHistPesqFuncionario";
            this.lblHistPesqFuncionario.Size = new System.Drawing.Size(59, 13);
            this.lblHistPesqFuncionario.TabIndex = 13;
            this.lblHistPesqFuncionario.Text = "Funcionario:";
            this.lblHistPesqFuncionario.Visible = false;
            // 
            // lblHistPesqFim
            // 
            this.lblHistPesqFim.Location = new System.Drawing.Point(21, 137);
            this.lblHistPesqFim.Name = "lblHistPesqFim";
            this.lblHistPesqFim.Size = new System.Drawing.Size(20, 13);
            this.lblHistPesqFim.TabIndex = 12;
            this.lblHistPesqFim.Text = "Fim:";
            this.lblHistPesqFim.Visible = false;
            // 
            // dateHistPesqFim
            // 
            this.dateHistPesqFim.EditValue = null;
            this.dateHistPesqFim.Location = new System.Drawing.Point(20, 152);
            this.dateHistPesqFim.Name = "dateHistPesqFim";
            this.dateHistPesqFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHistPesqFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHistPesqFim.Size = new System.Drawing.Size(131, 20);
            this.dateHistPesqFim.TabIndex = 11;
            this.dateHistPesqFim.Visible = false;
            this.dateHistPesqFim.TextChanged += new System.EventHandler(this.dateHistPesqFim_TextChanged);
            // 
            // lblHistPesqInicio
            // 
            this.lblHistPesqInicio.Location = new System.Drawing.Point(20, 97);
            this.lblHistPesqInicio.Name = "lblHistPesqInicio";
            this.lblHistPesqInicio.Size = new System.Drawing.Size(29, 13);
            this.lblHistPesqInicio.TabIndex = 10;
            this.lblHistPesqInicio.Text = "Inicio:";
            this.lblHistPesqInicio.Visible = false;
            // 
            // dateHistPesqInicio
            // 
            this.dateHistPesqInicio.EditValue = null;
            this.dateHistPesqInicio.Location = new System.Drawing.Point(19, 112);
            this.dateHistPesqInicio.Name = "dateHistPesqInicio";
            this.dateHistPesqInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHistPesqInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHistPesqInicio.Size = new System.Drawing.Size(132, 20);
            this.dateHistPesqInicio.TabIndex = 9;
            this.dateHistPesqInicio.Visible = false;
            this.dateHistPesqInicio.TextChanged += new System.EventHandler(this.dateHistPesqInicio_TextChanged);
            // 
            // radioCaixaLogPesquisa
            // 
            this.radioCaixaLogPesquisa.EditValue = 0;
            this.radioCaixaLogPesquisa.Location = new System.Drawing.Point(8, 30);
            this.radioCaixaLogPesquisa.Name = "radioCaixaLogPesquisa";
            this.radioCaixaLogPesquisa.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Todos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Periodo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Usuario")});
            this.radioCaixaLogPesquisa.Properties.ItemVertAlignment = DevExpress.XtraEditors.RadioItemVertAlignment.Top;
            this.radioCaixaLogPesquisa.Size = new System.Drawing.Size(155, 60);
            this.radioCaixaLogPesquisa.TabIndex = 0;
            this.radioCaixaLogPesquisa.EditValueChanged += new System.EventHandler(this.radioCaixaLogPesquisa_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(182, 513);
            this.panelControl1.TabIndex = 29;
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(6, 197);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(171, 315);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Informacoes";
            // 
            // XtraMDICaixaHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 513);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XtraMDICaixaHistory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de Abertura e Fechamento de Caixa";
            this.Load += new System.EventHandler(this.XtraMDICaixaHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboHistPesqFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqFim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHistPesqInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioCaixaLogPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridCaixaHist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCaixaHist;
        private DevExpress.XtraGrid.Columns.GridColumn clnHistId;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblHistPesqFim;
        private DevExpress.XtraEditors.DateEdit dateHistPesqFim;
        private DevExpress.XtraEditors.LabelControl lblHistPesqInicio;
        private DevExpress.XtraEditors.DateEdit dateHistPesqInicio;
        private DevExpress.XtraEditors.RadioGroup radioCaixaLogPesquisa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnPrintHist;
        private DevExpress.XtraEditors.ComboBoxEdit comboHistPesqFuncionario;
        private DevExpress.XtraEditors.LabelControl lblHistPesqFuncionario;
        private DevExpress.XtraEditors.LabelControl lblHistPesqFilter;
    }
}