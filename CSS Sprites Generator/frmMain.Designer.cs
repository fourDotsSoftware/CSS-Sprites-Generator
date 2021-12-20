namespace CSS_Sprites_Generator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstImages = new System.Windows.Forms.ListBox();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdbOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbGenerate = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCSSSpritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnGooglePlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareOnLinkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareWithEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followUsOnTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visit4dotsSoftwareWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.txtCSSClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCombinedImageFilepath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCombinedImageURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.niceLine1 = new CSS_Sprites_Generator.NiceLine();
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lstImages
            // 
            this.lstImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstImages.FormattingEnabled = true;
            this.lstImages.ItemHeight = 16;
            this.lstImages.Location = new System.Drawing.Point(0, 86);
            this.lstImages.Name = "lstImages";
            this.lstImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstImages.Size = new System.Drawing.Size(255, 356);
            this.lstImages.TabIndex = 0;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.BackColor = System.Drawing.Color.Transparent;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreview.Location = new System.Drawing.Point(613, 310);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(75, 20);
            this.chkPreview.TabIndex = 2;
            this.chkPreview.Text = "&Preview";
            this.chkPreview.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdbOpen,
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbAdd,
            this.tsbRemove,
            this.tsbGenerate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(897, 62);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdbOpen
            // 
            this.tsdbOpen.AutoSize = false;
            this.tsdbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsdbOpen.Image")));
            this.tsdbOpen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsdbOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbOpen.Name = "tsdbOpen";
            this.tsdbOpen.Size = new System.Drawing.Size(100, 59);
            this.tsdbOpen.Text = "&Open Project";
            this.tsdbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdbOpen.ToolTipText = "Open Project";
            this.tsdbOpen.ButtonClick += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            this.tsdbOpen.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsdbOpen_DropDownItemClicked);
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.Image = global::CSS_Sprites_Generator.Properties.Resources.disk_blue;
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(90, 59);
            this.tsbSave.Text = "&Save Project";
            this.tsbSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSave.ToolTipText = "Save Project";
            this.tsbSave.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // tsbAdd
            // 
            this.tsbAdd.AutoSize = false;
            this.tsbAdd.Image = global::CSS_Sprites_Generator.Properties.Resources.add1;
            this.tsbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(90, 59);
            this.tsbAdd.Text = "&Add Image";
            this.tsbAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAdd.ToolTipText = "Add Image";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.AutoSize = false;
            this.tsbRemove.Image = global::CSS_Sprites_Generator.Properties.Resources.delete1;
            this.tsbRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(90, 59);
            this.tsbRemove.Text = "&Remove Image";
            this.tsbRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRemove.ToolTipText = "Remove Image";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // tsbGenerate
            // 
            this.tsbGenerate.AutoSize = false;
            this.tsbGenerate.Image = global::CSS_Sprites_Generator.Properties.Resources.flash;
            this.tsbGenerate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerate.Name = "tsbGenerate";
            this.tsbGenerate.Size = new System.Drawing.Size(90, 59);
            this.tsbGenerate.Text = "&Generate";
            this.tsbGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGenerate.ToolTipText = "Generate";
            this.tsbGenerate.Click += new System.EventHandler(this.tsbGenerate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.shareToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.document_new;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newProjectToolStripMenuItem.Text = "&New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.folder1;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openProjectToolStripMenuItem.Text = "&Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.disk_blue;
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveProjectToolStripMenuItem.Text = "&Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "&Image";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.add1;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.delete1;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.brush2;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateCSSSpritesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // generateCSSSpritesToolStripMenuItem
            // 
            this.generateCSSSpritesToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.flash;
            this.generateCSSSpritesToolStripMenuItem.Name = "generateCSSSpritesToolStripMenuItem";
            this.generateCSSSpritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateCSSSpritesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.generateCSSSpritesToolStripMenuItem.Text = "&Generate CSS Sprites";
            // 
            // shareToolStripMenuItem
            // 
            this.shareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shareOnFacebookToolStripMenuItem,
            this.shareOnTwitterToolStripMenuItem,
            this.shareOnGooglePlusToolStripMenuItem,
            this.shareOnLinkedInToolStripMenuItem,
            this.shareWithEmailToolStripMenuItem});
            this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
            this.shareToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.shareToolStripMenuItem.Text = "&Share";
            // 
            // shareOnFacebookToolStripMenuItem
            // 
            this.shareOnFacebookToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.facebook_24;
            this.shareOnFacebookToolStripMenuItem.Name = "shareOnFacebookToolStripMenuItem";
            this.shareOnFacebookToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.shareOnFacebookToolStripMenuItem.Text = "Share on Facebook";
            this.shareOnFacebookToolStripMenuItem.Click += new System.EventHandler(this.shareOnFacebookToolStripMenuItem_Click);
            // 
            // shareOnTwitterToolStripMenuItem
            // 
            this.shareOnTwitterToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.twitter_24;
            this.shareOnTwitterToolStripMenuItem.Name = "shareOnTwitterToolStripMenuItem";
            this.shareOnTwitterToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.shareOnTwitterToolStripMenuItem.Text = "Share on Twitter";
            this.shareOnTwitterToolStripMenuItem.Click += new System.EventHandler(this.shareOnTwitterToolStripMenuItem_Click);
            // 
            // shareOnGooglePlusToolStripMenuItem
            // 
            this.shareOnGooglePlusToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.googleplus_24;
            this.shareOnGooglePlusToolStripMenuItem.Name = "shareOnGooglePlusToolStripMenuItem";
            this.shareOnGooglePlusToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.shareOnGooglePlusToolStripMenuItem.Text = "Share on Google Plus";
            this.shareOnGooglePlusToolStripMenuItem.Click += new System.EventHandler(this.shareOnGooglePlusToolStripMenuItem_Click);
            // 
            // shareOnLinkedInToolStripMenuItem
            // 
            this.shareOnLinkedInToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.linkedin_24;
            this.shareOnLinkedInToolStripMenuItem.Name = "shareOnLinkedInToolStripMenuItem";
            this.shareOnLinkedInToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.shareOnLinkedInToolStripMenuItem.Text = "Share on Linked In";
            this.shareOnLinkedInToolStripMenuItem.Click += new System.EventHandler(this.shareOnLinkedInToolStripMenuItem_Click);
            // 
            // shareWithEmailToolStripMenuItem
            // 
            this.shareWithEmailToolStripMenuItem.Image = global::CSS_Sprites_Generator.Properties.Resources.mail;
            this.shareWithEmailToolStripMenuItem.Name = "shareWithEmailToolStripMenuItem";
            this.shareWithEmailToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.shareWithEmailToolStripMenuItem.Text = "Share with Email";
            this.shareWithEmailToolStripMenuItem.Click += new System.EventHandler(this.shareWithEmailToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpGuideToolStripMenuItem,
            this.followUsOnTwitterToolStripMenuItem,
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem,
            this.visit4dotsSoftwareWebsiteToolStripMenuItem,
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpGuideToolStripMenuItem
            // 
            this.helpGuideToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpGuideToolStripMenuItem.Image")));
            this.helpGuideToolStripMenuItem.Name = "helpGuideToolStripMenuItem";
            this.helpGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpGuideToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.helpGuideToolStripMenuItem.Text = "Help - Users Manual";
            this.helpGuideToolStripMenuItem.Click += new System.EventHandler(this.helpGuideToolStripMenuItem_Click);
            // 
            // followUsOnTwitterToolStripMenuItem
            // 
            this.followUsOnTwitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("followUsOnTwitterToolStripMenuItem.Image")));
            this.followUsOnTwitterToolStripMenuItem.Name = "followUsOnTwitterToolStripMenuItem";
            this.followUsOnTwitterToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.followUsOnTwitterToolStripMenuItem.Text = "Follow us on &Twitter";
            this.followUsOnTwitterToolStripMenuItem.Click += new System.EventHandler(this.followUsOnTwitterToolStripMenuItem_Click);
            // 
            // dotsSoftwarePRODUCTCATALOGToolStripMenuItem
            // 
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Name = "dotsSoftwarePRODUCTCATALOGToolStripMenuItem";
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Text = "4dots Software PRODUCT CATALOG";
            this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem.Click += new System.EventHandler(this.dotsSoftwarePRODUCTCATALOGToolStripMenuItem_Click);
            // 
            // visit4dotsSoftwareWebsiteToolStripMenuItem
            // 
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Name = "visit4dotsSoftwareWebsiteToolStripMenuItem";
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Text = "&Visit 4dots Software Website";
            this.visit4dotsSoftwareWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visit4dotsSoftwareWebsiteToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslImage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslImage
            // 
            this.tslImage.Name = "tslImage";
            this.tslImage.Size = new System.Drawing.Size(16, 17);
            this.tslImage.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Label :";
            // 
            // txtLabel
            // 
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.Location = new System.Drawing.Point(363, 163);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(192, 22);
            this.txtLabel.TabIndex = 7;
            this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
            // 
            // txtCSSClass
            // 
            this.txtCSSClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSSClass.Location = new System.Drawing.Point(363, 189);
            this.txtCSSClass.Name = "txtCSSClass";
            this.txtCSSClass.Size = new System.Drawing.Size(192, 22);
            this.txtCSSClass.TabIndex = 9;
            this.txtCSSClass.TextChanged += new System.EventHandler(this.txtCSSClass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "CSS Class :";
            // 
            // txtCombinedImageFilepath
            // 
            this.txtCombinedImageFilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombinedImageFilepath.Location = new System.Drawing.Point(441, 362);
            this.txtCombinedImageFilepath.Name = "txtCombinedImageFilepath";
            this.txtCombinedImageFilepath.Size = new System.Drawing.Size(339, 22);
            this.txtCombinedImageFilepath.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Combined Image Filepath :";
            // 
            // txtCombinedImageURL
            // 
            this.txtCombinedImageURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombinedImageURL.Location = new System.Drawing.Point(441, 390);
            this.txtCombinedImageURL.Name = "txtCombinedImageURL";
            this.txtCombinedImageURL.Size = new System.Drawing.Size(223, 22);
            this.txtCombinedImageURL.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Combined Image URL :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(786, 360);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 26);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Image = global::CSS_Sprites_Generator.Properties.Resources.arrow_up_green;
            this.btnMoveUp.Location = new System.Drawing.Point(103, 448);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(97, 26);
            this.btnMoveUp.TabIndex = 23;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Image = global::CSS_Sprites_Generator.Properties.Resources.arrow_down_green;
            this.btnMoveDown.Location = new System.Drawing.Point(0, 448);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(97, 26);
            this.btnMoveDown.TabIndex = 22;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(613, 89);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(251, 215);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 1;
            this.picPreview.TabStop = false;
            // 
            // niceLine1
            // 
            this.niceLine1.BackColor = System.Drawing.Color.Transparent;
            this.niceLine1.Location = new System.Drawing.Point(261, 336);
            this.niceLine1.Name = "niceLine1";
            this.niceLine1.Size = new System.Drawing.Size(636, 15);
            this.niceLine1.TabIndex = 24;
            // 
            // visitOnlineCSSSpritesToolWebsiteToolStripMenuItem
            // 
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem.Name = "visitOnlineCSSSpritesToolWebsiteToolStripMenuItem";
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem.Text = "Visit Online CSS Sprites Tool Website";
            this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visitOnlineCSSSpritesToolWebsiteToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 499);
            this.Controls.Add(this.niceLine1);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtCombinedImageURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCombinedImageFilepath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCSSClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lstImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSS Sprites Generator V2.0 - 4dots Software";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmMain_DragOver);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripSplitButton tsdbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripButton tsbGenerate;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCSSSpritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnFacebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnTwitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnGooglePlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareOnLinkedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareWithEmailToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCSSClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCombinedImageFilepath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCombinedImageURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visit4dotsSoftwareWebsiteToolStripMenuItem;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private NiceLine niceLine1;
        private System.Windows.Forms.ToolStripMenuItem followUsOnTwitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotsSoftwarePRODUCTCATALOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitOnlineCSSSpritesToolWebsiteToolStripMenuItem;
    }
}

