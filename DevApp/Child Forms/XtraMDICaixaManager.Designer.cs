
namespace DevApp.Child_Forms
{
    partial class XtraMDICaixaManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraMDICaixaManager));
            this.btnDeleteActivity = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddActivity = new DevExpress.XtraEditors.SimpleButton();
            this.gridCaixaActivity = new DevExpress.XtraGrid.GridControl();
            this.gridViewCaixaActivity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_caixa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldataehora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colformapgto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.lblCaixaCloseTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaixaSaldoInicial = new DevExpress.XtraEditors.TextEdit();
            this.lblCaixaOpenTime = new DevExpress.XtraEditors.LabelControl();
            this.btnCaixaOpenClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.memoCaixaObs = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelCaixaStateColor = new System.Windows.Forms.Panel();
            this.lblCaixaState = new DevExpress.XtraEditors.LabelControl();
            this.btnPrintResumoCaixa = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintMovCaixa = new DevExpress.XtraEditors.SimpleButton();
            this.panelCaixaReceipt = new DevExpress.XtraEditors.PanelControl();
            this.gridCaixaResumo = new DevExpress.XtraGrid.GridControl();
            this.gridViewCaixaResumo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnRecordId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnRecordDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnRecordValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCalcText = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaActivity)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCaixaObs.Properties)).BeginInit();
            this.panelCaixaStateColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCaixaReceipt)).BeginInit();
            this.panelCaixaReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaResumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaResumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalcText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.Enabled = false;
            this.btnDeleteActivity.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteActivity.ImageOptions.SvgImage")));
            this.btnDeleteActivity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteActivity.Location = new System.Drawing.Point(225, 504);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDeleteActivity.Size = new System.Drawing.Size(146, 40);
            this.btnDeleteActivity.TabIndex = 7;
            this.btnDeleteActivity.Text = "Excluir Lancamento";
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Enabled = false;
            this.btnAddActivity.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddActivity.ImageOptions.SvgImage")));
            this.btnAddActivity.Location = new System.Drawing.Point(378, 504);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddActivity.Size = new System.Drawing.Size(175, 40);
            this.btnAddActivity.TabIndex = 11;
            this.btnAddActivity.Text = "Adicionar Entrada / Saida";
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // gridCaixaActivity
            // 
            this.gridCaixaActivity.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridCaixaActivity.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridCaixaActivity.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridCaixaActivity.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridCaixaActivity.Location = new System.Drawing.Point(223, -1);
            this.gridCaixaActivity.MainView = this.gridViewCaixaActivity;
            this.gridCaixaActivity.Name = "gridCaixaActivity";
            this.gridCaixaActivity.Size = new System.Drawing.Size(625, 498);
            this.gridCaixaActivity.TabIndex = 22;
            this.gridCaixaActivity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCaixaActivity});
            // 
            // gridViewCaixaActivity
            // 
            this.gridViewCaixaActivity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewCaixaActivity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_caixa,
            this.coldataehora,
            this.coldescricao,
            this.colentrada,
            this.colsaida,
            this.colformapgto,
            this.coltipo});
            this.gridViewCaixaActivity.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewCaixaActivity.GridControl = this.gridCaixaActivity;
            this.gridViewCaixaActivity.Name = "gridViewCaixaActivity";
            this.gridViewCaixaActivity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewCaixaActivity.OptionsBehavior.Editable = false;
            this.gridViewCaixaActivity.OptionsCustomization.AllowFilter = false;
            this.gridViewCaixaActivity.OptionsImageLoad.AsyncLoad = true;
            this.gridViewCaixaActivity.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCaixaActivity.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridViewCaixaActivity.OptionsView.ShowGroupPanel = false;
            this.gridViewCaixaActivity.OptionsView.ShowIndicator = false;
            this.gridViewCaixaActivity.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewCaixaActivity.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewCaixaActivity.PaintStyleName = "Skin";
            this.gridViewCaixaActivity.RowHeight = 25;
            this.gridViewCaixaActivity.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewCaixaActivity_CustomDrawCell);
            this.gridViewCaixaActivity.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCaixaActivity_FocusedRowChanged);
            this.gridViewCaixaActivity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewCaixaActivity_CustomColumnDisplayText);
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "Id";
            this.colid.Name = "colid";
            // 
            // colid_caixa
            // 
            this.colid_caixa.Caption = "Id Caixa";
            this.colid_caixa.FieldName = "IdCaixa";
            this.colid_caixa.Name = "colid_caixa";
            // 
            // coldataehora
            // 
            this.coldataehora.Caption = "Data / Hora";
            this.coldataehora.FieldName = "DataHora";
            this.coldataehora.Name = "coldataehora";
            this.coldataehora.Visible = true;
            this.coldataehora.VisibleIndex = 0;
            // 
            // coldescricao
            // 
            this.coldescricao.Caption = "Descricao";
            this.coldescricao.FieldName = "Descricao";
            this.coldescricao.Name = "coldescricao";
            this.coldescricao.Visible = true;
            this.coldescricao.VisibleIndex = 1;
            // 
            // colentrada
            // 
            this.colentrada.Caption = "Entrada";
            this.colentrada.FieldName = "Entrada";
            this.colentrada.Name = "colentrada";
            this.colentrada.Visible = true;
            this.colentrada.VisibleIndex = 2;
            // 
            // colsaida
            // 
            this.colsaida.Caption = "Saida";
            this.colsaida.FieldName = "Saida";
            this.colsaida.Name = "colsaida";
            this.colsaida.Visible = true;
            this.colsaida.VisibleIndex = 3;
            // 
            // colformapgto
            // 
            this.colformapgto.Caption = "Forma de Pgto.";
            this.colformapgto.FieldName = "FormaPgto";
            this.colformapgto.Name = "colformapgto";
            this.colformapgto.Visible = true;
            this.colformapgto.VisibleIndex = 4;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "Tipo";
            this.coltipo.Name = "coltipo";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.lblCaixaCloseTime);
            this.sidePanel1.Controls.Add(this.labelControl5);
            this.sidePanel1.Controls.Add(this.txtCaixaSaldoInicial);
            this.sidePanel1.Controls.Add(this.lblCaixaOpenTime);
            this.sidePanel1.Controls.Add(this.btnCaixaOpenClose);
            this.sidePanel1.Controls.Add(this.labelControl4);
            this.sidePanel1.Controls.Add(this.memoCaixaObs);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.panelCaixaStateColor);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(220, 551);
            this.sidePanel1.TabIndex = 23;
            this.sidePanel1.Text = "Caixa Fechado";
            // 
            // lblCaixaCloseTime
            // 
            this.lblCaixaCloseTime.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblCaixaCloseTime.Appearance.Options.UseForeColor = true;
            this.lblCaixaCloseTime.Location = new System.Drawing.Point(21, 517);
            this.lblCaixaCloseTime.Name = "lblCaixaCloseTime";
            this.lblCaixaCloseTime.Size = new System.Drawing.Size(71, 13);
            this.lblCaixaCloseTime.TabIndex = 37;
            this.lblCaixaCloseTime.Text = "Caixa Fechado";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(21, 500);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(135, 13);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Data e Hora do Fechamento";
            // 
            // txtCaixaSaldoInicial
            // 
            this.txtCaixaSaldoInicial.EditValue = "R$ 0,00";
            this.txtCaixaSaldoInicial.Location = new System.Drawing.Point(21, 106);
            this.txtCaixaSaldoInicial.Name = "txtCaixaSaldoInicial";
            this.txtCaixaSaldoInicial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCaixaSaldoInicial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaixaSaldoInicial.Properties.Appearance.Options.UseBackColor = true;
            this.txtCaixaSaldoInicial.Properties.Appearance.Options.UseFont = true;
            this.txtCaixaSaldoInicial.Properties.BeepOnError = false;
            this.txtCaixaSaldoInicial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCaixaSaldoInicial.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCaixaSaldoInicial.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCaixaSaldoInicial.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtCaixaSaldoInicial.Properties.MaskSettings.Set("mask", "c");
            this.txtCaixaSaldoInicial.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            this.txtCaixaSaldoInicial.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            this.txtCaixaSaldoInicial.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.txtCaixaSaldoInicial.Properties.UseMaskAsDisplayFormat = true;
            this.txtCaixaSaldoInicial.Size = new System.Drawing.Size(150, 26);
            this.txtCaixaSaldoInicial.TabIndex = 35;
            // 
            // lblCaixaOpenTime
            // 
            this.lblCaixaOpenTime.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblCaixaOpenTime.Appearance.Options.UseForeColor = true;
            this.lblCaixaOpenTime.Location = new System.Drawing.Point(21, 473);
            this.lblCaixaOpenTime.Name = "lblCaixaOpenTime";
            this.lblCaixaOpenTime.Size = new System.Drawing.Size(71, 13);
            this.lblCaixaOpenTime.TabIndex = 34;
            this.lblCaixaOpenTime.Text = "Caixa Fechado";
            // 
            // btnCaixaOpenClose
            // 
            this.btnCaixaOpenClose.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnCaixaOpenClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCaixaOpenClose.ImageOptions.SvgImage")));
            this.btnCaixaOpenClose.Location = new System.Drawing.Point(21, 277);
            this.btnCaixaOpenClose.Name = "btnCaixaOpenClose";
            this.btnCaixaOpenClose.Size = new System.Drawing.Size(186, 40);
            this.btnCaixaOpenClose.TabIndex = 27;
            this.btnCaixaOpenClose.Text = "Abrir Caixa <b>(F5)</b>        ";
            this.btnCaixaOpenClose.Click += new System.EventHandler(this.btnCaixaOpenClose_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 456);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Data e Hora da Abertura";
            // 
            // memoCaixaObs
            // 
            this.memoCaixaObs.Location = new System.Drawing.Point(21, 168);
            this.memoCaixaObs.Name = "memoCaixaObs";
            this.memoCaixaObs.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.memoCaixaObs.Properties.Appearance.Options.UseBackColor = true;
            this.memoCaixaObs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.memoCaixaObs.Size = new System.Drawing.Size(186, 91);
            this.memoCaixaObs.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 153);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Observacoes";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Saldo Inicial";
            // 
            // panelCaixaStateColor
            // 
            this.panelCaixaStateColor.BackColor = System.Drawing.Color.OrangeRed;
            this.panelCaixaStateColor.Controls.Add(this.lblCaixaState);
            this.panelCaixaStateColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaixaStateColor.Location = new System.Drawing.Point(0, 0);
            this.panelCaixaStateColor.Name = "panelCaixaStateColor";
            this.panelCaixaStateColor.Size = new System.Drawing.Size(219, 54);
            this.panelCaixaStateColor.TabIndex = 29;
            // 
            // lblCaixaState
            // 
            this.lblCaixaState.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblCaixaState.Appearance.Options.UseFont = true;
            this.lblCaixaState.Location = new System.Drawing.Point(49, 14);
            this.lblCaixaState.Name = "lblCaixaState";
            this.lblCaixaState.Size = new System.Drawing.Size(121, 23);
            this.lblCaixaState.TabIndex = 0;
            this.lblCaixaState.Text = "Caixa Fechado";
            // 
            // btnPrintResumoCaixa
            // 
            this.btnPrintResumoCaixa.Enabled = false;
            this.btnPrintResumoCaixa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintResumoCaixa.ImageOptions.SvgImage")));
            this.btnPrintResumoCaixa.Location = new System.Drawing.Point(731, 504);
            this.btnPrintResumoCaixa.Name = "btnPrintResumoCaixa";
            this.btnPrintResumoCaixa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrintResumoCaixa.Size = new System.Drawing.Size(136, 40);
            this.btnPrintResumoCaixa.TabIndex = 26;
            this.btnPrintResumoCaixa.Text = "Imprimir Resumo";
            this.btnPrintResumoCaixa.Click += new System.EventHandler(this.btnPrintResumoCaixa_Click);
            // 
            // btnPrintMovCaixa
            // 
            this.btnPrintMovCaixa.Enabled = false;
            this.btnPrintMovCaixa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintMovCaixa.ImageOptions.SvgImage")));
            this.btnPrintMovCaixa.Location = new System.Drawing.Point(560, 504);
            this.btnPrintMovCaixa.Name = "btnPrintMovCaixa";
            this.btnPrintMovCaixa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrintMovCaixa.Size = new System.Drawing.Size(163, 40);
            this.btnPrintMovCaixa.TabIndex = 25;
            this.btnPrintMovCaixa.Text = "Imprimir Movimentacao";
            this.btnPrintMovCaixa.Click += new System.EventHandler(this.btnPrintMovCaixa_Click);
            // 
            // panelCaixaReceipt
            // 
            this.panelCaixaReceipt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelCaixaReceipt.Controls.Add(this.gridCaixaResumo);
            this.panelCaixaReceipt.Location = new System.Drawing.Point(847, -1);
            this.panelCaixaReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.panelCaixaReceipt.Name = "panelCaixaReceipt";
            this.panelCaixaReceipt.Size = new System.Drawing.Size(285, 498);
            this.panelCaixaReceipt.TabIndex = 28;
            // 
            // gridCaixaResumo
            // 
            this.gridCaixaResumo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridCaixaResumo.BackgroundImage")));
            this.gridCaixaResumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridCaixaResumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCaixaResumo.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCaixaResumo.Location = new System.Drawing.Point(2, 2);
            this.gridCaixaResumo.MainView = this.gridViewCaixaResumo;
            this.gridCaixaResumo.Name = "gridCaixaResumo";
            this.gridCaixaResumo.Size = new System.Drawing.Size(281, 494);
            this.gridCaixaResumo.TabIndex = 0;
            this.gridCaixaResumo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCaixaResumo});
            // 
            // gridViewCaixaResumo
            // 
            this.gridViewCaixaResumo.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCaixaResumo.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewCaixaResumo.Appearance.EvenRow.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.gridViewCaixaResumo.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewCaixaResumo.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCaixaResumo.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewCaixaResumo.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCaixaResumo.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewCaixaResumo.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCaixaResumo.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewCaixaResumo.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewCaixaResumo.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCaixaResumo.Appearance.HorzLine.Options.UseBorderColor = true;
            this.gridViewCaixaResumo.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewCaixaResumo.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewCaixaResumo.Appearance.Row.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCaixaResumo.Appearance.Row.Options.UseFont = true;
            this.gridViewCaixaResumo.Appearance.RowSeparator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewCaixaResumo.Appearance.RowSeparator.Options.UseBorderColor = true;
            this.gridViewCaixaResumo.Appearance.SelectedRow.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.gridViewCaixaResumo.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewCaixaResumo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewCaixaResumo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnRecordId,
            this.clnRecordDescription,
            this.clnRecordValue});
            this.gridViewCaixaResumo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewCaixaResumo.GridControl = this.gridCaixaResumo;
            this.gridViewCaixaResumo.Name = "gridViewCaixaResumo";
            this.gridViewCaixaResumo.OptionsBehavior.Editable = false;
            this.gridViewCaixaResumo.OptionsPrint.PrintHeader = false;
            this.gridViewCaixaResumo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCaixaResumo.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewCaixaResumo.OptionsView.AllowHtmlDrawGroups = false;
            this.gridViewCaixaResumo.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridViewCaixaResumo.OptionsView.ShowColumnHeaders = false;
            this.gridViewCaixaResumo.OptionsView.ShowGroupPanel = false;
            this.gridViewCaixaResumo.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewCaixaResumo.OptionsView.ShowIndicator = false;
            this.gridViewCaixaResumo.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewCaixaResumo.PaintStyleName = "Flat";
            this.gridViewCaixaResumo.RowHeight = 25;
            this.gridViewCaixaResumo.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewCaixaResumo_CustomDrawCell);
            // 
            // clnRecordId
            // 
            this.clnRecordId.Caption = "Id";
            this.clnRecordId.FieldName = "ID";
            this.clnRecordId.Name = "clnRecordId";
            // 
            // clnRecordDescription
            // 
            this.clnRecordDescription.Caption = "Descricao";
            this.clnRecordDescription.FieldName = "Descricao";
            this.clnRecordDescription.Name = "clnRecordDescription";
            this.clnRecordDescription.Visible = true;
            this.clnRecordDescription.VisibleIndex = 0;
            this.clnRecordDescription.Width = 150;
            // 
            // clnRecordValue
            // 
            this.clnRecordValue.Caption = "Valor";
            this.clnRecordValue.FieldName = "Valor";
            this.clnRecordValue.Name = "clnRecordValue";
            this.clnRecordValue.Visible = true;
            this.clnRecordValue.VisibleIndex = 1;
            this.clnRecordValue.Width = 76;
            // 
            // txtCalcText
            // 
            this.txtCalcText.EditValue = "R$ 0,00";
            this.txtCalcText.Location = new System.Drawing.Point(969, 509);
            this.txtCalcText.Name = "txtCalcText";
            this.txtCalcText.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCalcText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcText.Properties.Appearance.Options.UseBackColor = true;
            this.txtCalcText.Properties.Appearance.Options.UseFont = true;
            this.txtCalcText.Properties.BeepOnError = false;
            this.txtCalcText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCalcText.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCalcText.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCalcText.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtCalcText.Properties.MaskSettings.Set("mask", "c");
            this.txtCalcText.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            this.txtCalcText.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            this.txtCalcText.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.txtCalcText.Properties.UseMaskAsDisplayFormat = true;
            this.txtCalcText.Size = new System.Drawing.Size(147, 26);
            this.txtCalcText.TabIndex = 36;
            this.txtCalcText.Visible = false;
            // 
            // XtraMDICaixaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 551);
            this.Controls.Add(this.txtCalcText);
            this.Controls.Add(this.panelCaixaReceipt);
            this.Controls.Add(this.btnPrintResumoCaixa);
            this.Controls.Add(this.btnPrintMovCaixa);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.gridCaixaActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.btnDeleteActivity);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XtraMDICaixaManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Caixa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraMDICaixaManager_FormClosing);
            this.Load += new System.EventHandler(this.XtraMDICaixaManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaActivity)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCaixaObs.Properties)).EndInit();
            this.panelCaixaStateColor.ResumeLayout(false);
            this.panelCaixaStateColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCaixaReceipt)).EndInit();
            this.panelCaixaReceipt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaResumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaResumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalcText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnDeleteActivity;
        private DevExpress.XtraEditors.SimpleButton btnAddActivity;
        private DevExpress.XtraGrid.GridControl gridCaixaActivity;
        private DevExpress.XtraGrid.Columns.GridColumn coldataehora;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada;
        private DevExpress.XtraGrid.Columns.GridColumn colsaida;
        private DevExpress.XtraGrid.Columns.GridColumn colformapgto;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit memoCaixaObs;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panelCaixaStateColor;
        private DevExpress.XtraEditors.LabelControl lblCaixaState;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_caixa;
        private DevExpress.XtraEditors.SimpleButton btnCaixaOpenClose;
        private DevExpress.XtraEditors.SimpleButton btnPrintResumoCaixa;
        private DevExpress.XtraEditors.SimpleButton btnPrintMovCaixa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCaixaActivity;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraEditors.LabelControl lblCaixaOpenTime;
        private DevExpress.XtraEditors.TextEdit txtCaixaSaldoInicial;
        private DevExpress.XtraEditors.PanelControl panelCaixaReceipt;
        private DevExpress.XtraGrid.GridControl gridCaixaResumo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCaixaResumo;
        private DevExpress.XtraGrid.Columns.GridColumn clnRecordId;
        private DevExpress.XtraGrid.Columns.GridColumn clnRecordDescription;
        private DevExpress.XtraGrid.Columns.GridColumn clnRecordValue;
        private DevExpress.XtraEditors.TextEdit txtCalcText;
        private DevExpress.XtraEditors.LabelControl lblCaixaCloseTime;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
