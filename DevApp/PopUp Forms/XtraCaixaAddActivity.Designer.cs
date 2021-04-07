
namespace DevApp.PopUp_Forms
{
    partial class XtraCaixaAddActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCaixaAddActivity));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.editValorActivity = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelAddActivity = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddActivity = new DevExpress.XtraEditors.SimpleButton();
            this.lblFornecedores = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoriaDespesas = new DevExpress.XtraEditors.LabelControl();
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.lblOperacao = new DevExpress.XtraEditors.LabelControl();
            this.lblFormaPgto = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioOperacaoTipo = new DevExpress.XtraEditors.RadioGroup();
            this.radioActivityType = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editValorActivity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioOperacaoTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioActivityType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.editValorActivity);
            this.panelControl1.Controls.Add(this.btnCancelAddActivity);
            this.panelControl1.Controls.Add(this.btnAddActivity);
            this.panelControl1.Controls.Add(this.lblFornecedores);
            this.panelControl1.Controls.Add(this.lblCategoriaDespesas);
            this.panelControl1.Controls.Add(this.lblValor);
            this.panelControl1.Controls.Add(this.lblOperacao);
            this.panelControl1.Controls.Add(this.lblFormaPgto);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.radioOperacaoTipo);
            this.panelControl1.Controls.Add(this.radioActivityType);
            this.panelControl1.Location = new System.Drawing.Point(7, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(406, 317);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 244);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Fornecedor:";
            // 
            // editValorActivity
            // 
            this.editValorActivity.EditValue = "R$ 0,00";
            this.editValorActivity.Location = new System.Drawing.Point(111, 183);
            this.editValorActivity.Name = "editValorActivity";
            this.editValorActivity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editValorActivity.Properties.Appearance.Options.UseFont = true;
            this.editValorActivity.Properties.BeepOnError = false;
            this.editValorActivity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.editValorActivity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.editValorActivity.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.editValorActivity.Properties.MaskSettings.Set("culture", "pt-BR");
            this.editValorActivity.Properties.MaskSettings.Set("mask", "c");
            this.editValorActivity.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            this.editValorActivity.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            this.editValorActivity.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.editValorActivity.Properties.UseMaskAsDisplayFormat = true;
            this.editValorActivity.Size = new System.Drawing.Size(150, 26);
            this.editValorActivity.TabIndex = 36;
            // 
            // btnCancelAddActivity
            // 
            this.btnCancelAddActivity.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelAddActivity.ImageOptions.SvgImage")));
            this.btnCancelAddActivity.Location = new System.Drawing.Point(181, 266);
            this.btnCancelAddActivity.Name = "btnCancelAddActivity";
            this.btnCancelAddActivity.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancelAddActivity.Size = new System.Drawing.Size(83, 40);
            this.btnCancelAddActivity.TabIndex = 14;
            this.btnCancelAddActivity.Text = "Voltar";
            this.btnCancelAddActivity.Click += new System.EventHandler(this.btnCancelAddActivity_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddActivity.ImageOptions.SvgImage")));
            this.btnAddActivity.Location = new System.Drawing.Point(287, 266);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddActivity.Size = new System.Drawing.Size(107, 40);
            this.btnAddActivity.TabIndex = 13;
            this.btnAddActivity.Text = "Adicionar";
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.Location = new System.Drawing.Point(30, 266);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(62, 13);
            this.lblFornecedores.TabIndex = 9;
            this.lblFornecedores.Text = "Observacao:";
            // 
            // lblCategoriaDespesas
            // 
            this.lblCategoriaDespesas.Location = new System.Drawing.Point(41, 221);
            this.lblCategoriaDespesas.Name = "lblCategoriaDespesas";
            this.lblCategoriaDespesas.Size = new System.Drawing.Size(51, 13);
            this.lblCategoriaDespesas.TabIndex = 8;
            this.lblCategoriaDespesas.Text = "Categoria:";
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(65, 189);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(28, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor:";
            // 
            // lblOperacao
            // 
            this.lblOperacao.Location = new System.Drawing.Point(42, 65);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(51, 13);
            this.lblOperacao.TabIndex = 6;
            this.lblOperacao.Text = "Operacao:";
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.Location = new System.Drawing.Point(14, 20);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(78, 13);
            this.lblFormaPgto.TabIndex = 5;
            this.lblFormaPgto.Text = "Forma de Pgto.:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(133, 155);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(234, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Nao registra o lancamento como conta a receber.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(133, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(228, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nao registra o lancamento como conta a pagar.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(133, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(207, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Registra o lancamento como conta a pagar.";
            // 
            // radioOperacaoTipo
            // 
            this.radioOperacaoTipo.EditValue = "Despesa";
            this.radioOperacaoTipo.Location = new System.Drawing.Point(111, 51);
            this.radioOperacaoTipo.Name = "radioOperacaoTipo";
            this.radioOperacaoTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.radioOperacaoTipo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioOperacaoTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Despesa", "Saida - Lancamento de Despesa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Sangria", "Saida - Sangria"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Entrada", "Entrada")});
            this.radioOperacaoTipo.Size = new System.Drawing.Size(283, 122);
            this.radioOperacaoTipo.TabIndex = 1;
            this.radioOperacaoTipo.EditValueChanged += new System.EventHandler(this.radioOperacaoTipo_EditValueChanged);
            // 
            // radioActivityType
            // 
            this.radioActivityType.EditValue = "Dinheiro";
            this.radioActivityType.Location = new System.Drawing.Point(111, 11);
            this.radioActivityType.Name = "radioActivityType";
            this.radioActivityType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.radioActivityType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Dinheiro", "Dinheiro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Cheque", "Cheque"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Debito", "Debito"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PIX", "PIX")});
            this.radioActivityType.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioActivityType.Size = new System.Drawing.Size(283, 34);
            this.radioActivityType.TabIndex = 0;
            // 
            // XtraCaixaAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 328);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraCaixaAddActivity";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Entrada / Saida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraCaixaAddActivity_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editValorActivity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioOperacaoTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioActivityType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.RadioGroup radioActivityType;
        private DevExpress.XtraEditors.RadioGroup radioOperacaoTipo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblOperacao;
        private DevExpress.XtraEditors.LabelControl lblFormaPgto;
        private DevExpress.XtraEditors.LabelControl lblValor;
        private DevExpress.XtraEditors.LabelControl lblCategoriaDespesas;
        private DevExpress.XtraEditors.LabelControl lblFornecedores;
        private DevExpress.XtraEditors.SimpleButton btnCancelAddActivity;
        private DevExpress.XtraEditors.SimpleButton btnAddActivity;
        private DevExpress.XtraEditors.TextEdit editValorActivity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}