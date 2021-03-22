
namespace DevApp
{
    partial class WizardConfigureApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardConfigureApp));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblSelectThemeColors = new DevExpress.XtraEditors.LabelControl();
            this.wizardSelectFont = new DevExpress.XtraEditors.FontEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinPaletteRibbonGalleryBarItem4 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem3 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardSelectFont.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            resources.ApplyResources(this.wizardControl1, "wizardControl1");
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            // 
            // welcomeWizardPage1
            // 
            resources.ApplyResources(this.welcomeWizardPage1, "welcomeWizardPage1");
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.welcomeWizardPage1_PageValidating);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.labelControl1);
            this.wizardPage1.Controls.Add(this.lblSelectThemeColors);
            this.wizardPage1.Controls.Add(this.wizardSelectFont);
            this.wizardPage1.Controls.Add(this.ribbonControl1);
            resources.ApplyResources(this.wizardPage1, "wizardPage1");
            this.wizardPage1.Name = "wizardPage1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // lblSelectThemeColors
            // 
            this.lblSelectThemeColors.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblSelectThemeColors.Appearance.Font")));
            this.lblSelectThemeColors.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblSelectThemeColors, "lblSelectThemeColors");
            this.lblSelectThemeColors.Name = "lblSelectThemeColors";
            // 
            // wizardSelectFont
            // 
            resources.ApplyResources(this.wizardSelectFont, "wizardSelectFont");
            this.wizardSelectFont.MenuManager = this.ribbonControl1;
            this.wizardSelectFont.Name = "wizardSelectFont";
            this.wizardSelectFont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("wizardSelectFont.Properties.Buttons"))))});
            // 
            // ribbonControl1
            // 
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.skinPaletteRibbonGalleryBarItem4,
            this.barEditItem1});
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1});
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinPaletteRibbonGalleryBarItem4
            // 
            resources.ApplyResources(this.skinPaletteRibbonGalleryBarItem4, "skinPaletteRibbonGalleryBarItem4");
            this.skinPaletteRibbonGalleryBarItem4.Id = 1;
            this.skinPaletteRibbonGalleryBarItem4.Name = "skinPaletteRibbonGalleryBarItem4";
            // 
            // barEditItem1
            // 
            resources.ApplyResources(this.barEditItem1, "barEditItem1");
            this.barEditItem1.Edit = this.repositoryItemFontEdit1;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemFontEdit1
            // 
            resources.ApplyResources(this.repositoryItemFontEdit1, "repositoryItemFontEdit1");
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemFontEdit1.Buttons"))))});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            resources.ApplyResources(this.completionWizardPage1, "completionWizardPage1");
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            resources.ApplyResources(this.skinPaletteRibbonGalleryBarItem1, "skinPaletteRibbonGalleryBarItem1");
            this.skinPaletteRibbonGalleryBarItem1.Id = 42;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // skinPaletteRibbonGalleryBarItem2
            // 
            resources.ApplyResources(this.skinPaletteRibbonGalleryBarItem2, "skinPaletteRibbonGalleryBarItem2");
            this.skinPaletteRibbonGalleryBarItem2.Id = 42;
            this.skinPaletteRibbonGalleryBarItem2.Name = "skinPaletteRibbonGalleryBarItem2";
            // 
            // skinPaletteRibbonGalleryBarItem3
            // 
            resources.ApplyResources(this.skinPaletteRibbonGalleryBarItem3, "skinPaletteRibbonGalleryBarItem3");
            this.skinPaletteRibbonGalleryBarItem3.Id = 42;
            this.skinPaletteRibbonGalleryBarItem3.Name = "skinPaletteRibbonGalleryBarItem3";
            // 
            // WizardConfigureApp
            // 
            this.Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("WizardConfigureApp.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WizardConfigureApp";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardSelectFont.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem2;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem3;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.FontEdit wizardSelectFont;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblSelectThemeColors;
    }
}