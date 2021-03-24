
namespace DevApp.PopUp_Forms
{
    partial class XtraCaixaCloseDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCaixaCloseDialog));
            this.panelBg = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaixaSaldoFinalTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtCaixaSaldoFinalDinheiro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCloseAndPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelBg)).BeginInit();
            this.panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoFinalTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoFinalDinheiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBg.Appearance.Options.UseBackColor = true;
            this.panelBg.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelBg.Controls.Add(this.labelControl5);
            this.panelBg.Controls.Add(this.labelControl4);
            this.panelBg.Controls.Add(this.txtCaixaSaldoFinalTotal);
            this.panelBg.Controls.Add(this.txtCaixaSaldoFinalDinheiro);
            this.panelBg.Controls.Add(this.labelControl3);
            this.panelBg.Controls.Add(this.labelControl2);
            this.panelBg.Controls.Add(this.panelControl1);
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(492, 368);
            this.panelBg.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(103, 209);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(278, 13);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Saldo ((Dinheiro + Cheques + Cartao) - Saidas)";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(171, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Saldo (Apenas Dinheiro)";
            // 
            // txtCaixaSaldoFinalTotal
            // 
            this.txtCaixaSaldoFinalTotal.EditValue = "R$ 0,00";
            this.txtCaixaSaldoFinalTotal.Location = new System.Drawing.Point(133, 229);
            this.txtCaixaSaldoFinalTotal.Name = "txtCaixaSaldoFinalTotal";
            this.txtCaixaSaldoFinalTotal.Properties.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.txtCaixaSaldoFinalTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaixaSaldoFinalTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtCaixaSaldoFinalTotal.Properties.Appearance.Options.UseFont = true;
            this.txtCaixaSaldoFinalTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCaixaSaldoFinalTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCaixaSaldoFinalTotal.Properties.BeepOnError = false;
            this.txtCaixaSaldoFinalTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCaixaSaldoFinalTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCaixaSaldoFinalTotal.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCaixaSaldoFinalTotal.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtCaixaSaldoFinalTotal.Properties.MaskSettings.Set("mask", "c");
            this.txtCaixaSaldoFinalTotal.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            this.txtCaixaSaldoFinalTotal.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            this.txtCaixaSaldoFinalTotal.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.txtCaixaSaldoFinalTotal.Properties.UseMaskAsDisplayFormat = true;
            this.txtCaixaSaldoFinalTotal.Size = new System.Drawing.Size(223, 26);
            this.txtCaixaSaldoFinalTotal.TabIndex = 37;
            // 
            // txtCaixaSaldoFinalDinheiro
            // 
            this.txtCaixaSaldoFinalDinheiro.EditValue = "R$ 0,00";
            this.txtCaixaSaldoFinalDinheiro.Location = new System.Drawing.Point(133, 152);
            this.txtCaixaSaldoFinalDinheiro.Name = "txtCaixaSaldoFinalDinheiro";
            this.txtCaixaSaldoFinalDinheiro.Properties.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCaixaSaldoFinalDinheiro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaixaSaldoFinalDinheiro.Properties.Appearance.Options.UseBackColor = true;
            this.txtCaixaSaldoFinalDinheiro.Properties.Appearance.Options.UseFont = true;
            this.txtCaixaSaldoFinalDinheiro.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCaixaSaldoFinalDinheiro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCaixaSaldoFinalDinheiro.Properties.BeepOnError = false;
            this.txtCaixaSaldoFinalDinheiro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCaixaSaldoFinalDinheiro.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCaixaSaldoFinalDinheiro.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCaixaSaldoFinalDinheiro.Properties.MaskSettings.Set("culture", "pt-BR");
            this.txtCaixaSaldoFinalDinheiro.Properties.MaskSettings.Set("mask", "c");
            this.txtCaixaSaldoFinalDinheiro.Properties.MaskSettings.Set("hideInsignificantZeros", true);
            this.txtCaixaSaldoFinalDinheiro.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            this.txtCaixaSaldoFinalDinheiro.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.txtCaixaSaldoFinalDinheiro.Properties.ReadOnly = true;
            this.txtCaixaSaldoFinalDinheiro.Properties.UseMaskAsDisplayFormat = true;
            this.txtCaixaSaldoFinalDinheiro.Size = new System.Drawing.Size(223, 26);
            this.txtCaixaSaldoFinalDinheiro.TabIndex = 36;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(171, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(146, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = " na gaveta do seu caixa: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(51, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(385, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ao realizar o fechamento, faca a conferencia dos seguintes valores";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(492, 55);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(83, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(321, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Confirma o fechamento do caixa?";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(74, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 48);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(159, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 48);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Confirmar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseAndPrint
            // 
            this.btnCloseAndPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCloseAndPrint.ImageOptions.SvgImage")));
            this.btnCloseAndPrint.Location = new System.Drawing.Point(273, 297);
            this.btnCloseAndPrint.Name = "btnCloseAndPrint";
            this.btnCloseAndPrint.Size = new System.Drawing.Size(145, 48);
            this.btnCloseAndPrint.TabIndex = 3;
            this.btnCloseAndPrint.Text = "Imprimir e Confirmar";
            this.btnCloseAndPrint.Click += new System.EventHandler(this.btnCloseAndPrint_Click);
            // 
            // XtraCaixaCloseDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 367);
            this.Controls.Add(this.btnCloseAndPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelBg);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraCaixaCloseDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento do Caixa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraCaixaCloseDialog_FormClosing);
            this.Load += new System.EventHandler(this.XtraCaixaCloseDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelBg)).EndInit();
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoFinalTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaixaSaldoFinalDinheiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBg;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnCloseAndPrint;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCaixaSaldoFinalTotal;
        private DevExpress.XtraEditors.TextEdit txtCaixaSaldoFinalDinheiro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}