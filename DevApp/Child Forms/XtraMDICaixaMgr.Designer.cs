
namespace DevApp.Child_Forms
{
    partial class XtraMDICaixaMgr
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraMDICaixaMgr));
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
            this.txtCaixaSaldoInicial = new DevExpress.XtraEditors.TextEdit();
            this.lblCaixaOpenTime = new DevExpress.XtraEditors.LabelControl();
            this.btnCaixaOpenClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.memoCaixaObs = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelCaixaStateColor = new System.Windows.Forms.Panel();
            this.lblCaixaState = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tblCaixaActivity = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaActivity)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCaixaObs.Properties)).BeginInit();
            this.panelCaixaStateColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCaixaActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.Enabled = false;
            this.btnDeleteActivity.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteActivity.ImageOptions.SvgImage")));
            this.btnDeleteActivity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteActivity.Location = new System.Drawing.Point(235, 483);
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
            this.btnAddActivity.Location = new System.Drawing.Point(387, 482);
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
            this.gridCaixaActivity.Location = new System.Drawing.Point(235, 0);
            this.gridCaixaActivity.MainView = this.gridViewCaixaActivity;
            this.gridCaixaActivity.Name = "gridCaixaActivity";
            this.gridCaixaActivity.Size = new System.Drawing.Size(644, 478);
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
            this.gridViewCaixaActivity.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCaixaActivity_FocusedRowChanged);
            this.gridViewCaixaActivity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewCaixaActivity_CustomColumnDisplayText);
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_caixa
            // 
            this.colid_caixa.Caption = "Id Caixa";
            this.colid_caixa.FieldName = "id_caixa";
            this.colid_caixa.Name = "colid_caixa";
            // 
            // coldataehora
            // 
            this.coldataehora.Caption = "Data / Hora";
            this.coldataehora.FieldName = "dataehora";
            this.coldataehora.Name = "coldataehora";
            this.coldataehora.Visible = true;
            this.coldataehora.VisibleIndex = 0;
            // 
            // coldescricao
            // 
            this.coldescricao.Caption = "Descricao";
            this.coldescricao.FieldName = "descricao";
            this.coldescricao.Name = "coldescricao";
            this.coldescricao.Visible = true;
            this.coldescricao.VisibleIndex = 1;
            // 
            // colentrada
            // 
            this.colentrada.Caption = "Entrada";
            this.colentrada.FieldName = "entrada";
            this.colentrada.Name = "colentrada";
            this.colentrada.Visible = true;
            this.colentrada.VisibleIndex = 2;
            // 
            // colsaida
            // 
            this.colsaida.Caption = "Saida";
            this.colsaida.FieldName = "saida";
            this.colsaida.Name = "colsaida";
            this.colsaida.Visible = true;
            this.colsaida.VisibleIndex = 3;
            // 
            // colformapgto
            // 
            this.colformapgto.Caption = "Forma de Pgto.";
            this.colformapgto.FieldName = "formapgto";
            this.colformapgto.Name = "colformapgto";
            this.colformapgto.Visible = true;
            this.colformapgto.VisibleIndex = 4;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
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
            this.sidePanel1.Size = new System.Drawing.Size(229, 527);
            this.sidePanel1.TabIndex = 23;
            this.sidePanel1.Text = "sidePanel1";
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
            this.lblCaixaOpenTime.Location = new System.Drawing.Point(19, 482);
            this.lblCaixaOpenTime.Name = "lblCaixaOpenTime";
            this.lblCaixaOpenTime.Size = new System.Drawing.Size(0, 13);
            this.lblCaixaOpenTime.TabIndex = 34;
            // 
            // btnCaixaOpenClose
            // 
            this.btnCaixaOpenClose.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnCaixaOpenClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCaixaOpenClose.ImageOptions.SvgImage")));
            this.btnCaixaOpenClose.Location = new System.Drawing.Point(21, 277);
            this.btnCaixaOpenClose.Name = "btnCaixaOpenClose";
            this.btnCaixaOpenClose.Size = new System.Drawing.Size(135, 40);
            this.btnCaixaOpenClose.TabIndex = 27;
            this.btnCaixaOpenClose.Text = "Abrir Caixa <b>(F5)</b>";
            this.btnCaixaOpenClose.Click += new System.EventHandler(this.btnCaixaOpenClose_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 465);
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
            this.panelCaixaStateColor.Location = new System.Drawing.Point(20, 22);
            this.panelCaixaStateColor.Name = "panelCaixaStateColor";
            this.panelCaixaStateColor.Size = new System.Drawing.Size(186, 54);
            this.panelCaixaStateColor.TabIndex = 29;
            // 
            // lblCaixaState
            // 
            this.lblCaixaState.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lblCaixaState.Appearance.Options.UseFont = true;
            this.lblCaixaState.Location = new System.Drawing.Point(30, 15);
            this.lblCaixaState.Name = "lblCaixaState";
            this.lblCaixaState.Size = new System.Drawing.Size(121, 23);
            this.lblCaixaState.TabIndex = 0;
            this.lblCaixaState.Text = "Caixa Fechado";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Enabled = false;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(745, 482);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(136, 40);
            this.simpleButton3.TabIndex = 26;
            this.simpleButton3.Text = "Imprimir Resumo";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(568, 483);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(171, 40);
            this.simpleButton2.TabIndex = 25;
            this.simpleButton2.Text = "Imprimir Movimentacao";
            // 
            // tblCaixaActivity
            // 
            this.tblCaixaActivity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tblCaixaActivity.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tblCaixaActivity.Location = new System.Drawing.Point(878, 0);
            this.tblCaixaActivity.Name = "tblCaixaActivity";
            this.tblCaixaActivity.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tblCaixaActivity.Size = new System.Drawing.Size(260, 478);
            this.tblCaixaActivity.TabIndex = 28;
            // 
            // XtraMDICaixaMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblCaixaActivity);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.gridCaixaActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.btnDeleteActivity);
            this.Name = "XtraMDICaixaMgr";
            this.Size = new System.Drawing.Size(1144, 527);
            this.Load += new System.EventHandler(this.XtraMDICaixaMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCaixaActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCaixaActivity)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCaixaObs.Properties)).EndInit();
            this.panelCaixaStateColor.ResumeLayout(false);
            this.panelCaixaStateColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCaixaActivity)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.Utils.Layout.TablePanel tblCaixaActivity;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCaixaActivity;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraEditors.LabelControl lblCaixaOpenTime;
        private DevExpress.XtraEditors.TextEdit txtCaixaSaldoInicial;
    }
}
