using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSS_Sprites_Generator
{
    public partial class frmMain : Form
    {
        RecentFilesHelper RecentFilesHelper = new RecentFilesHelper();
        private bool IsDragging = true;

        public frmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            RecentFilesHelper.frmMainOwner = this;

            if (Properties.Settings.Default.ShowPromotion)
            {
                frmPromotion fp = new frmPromotion();
                fp.Show(this);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {                        
            try
            {
                System.Drawing.Graphics g = e.Graphics;
                int x = this.Width;
                int y = this.Height;

                System.Drawing.Drawing2D.LinearGradientBrush
                    lgBrush = new System.Drawing.Drawing2D.LinearGradientBrush
                    (new System.Drawing.Point(0, 0), new System.Drawing.Point(x, y),
                    Color.White, Color.FromArgb(190, 190, 190));
                lgBrush.GammaCorrection = true;
                g.FillRectangle(lgBrush, 0, 0, x, y);
            }
            catch
            {
                base.OnPaintBackground(e);
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Module.ImagesFilter;
            openFileDialog1.Multiselect = true;
            openFileDialog1.FileName = "";

            if (Properties.Settings.Default.LastOpenImagesFolder!=string.Empty) openFileDialog1.InitialDirectory=Properties.Settings.Default.LastOpenImagesFolder;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LastOpenImagesFolder = System.IO.Path.GetDirectoryName(openFileDialog1.FileNames[0]);

                for (int k = 0; k < openFileDialog1.FileNames.Length; k++)
                {
                    //for (int m = 0; m < 300; m++)
                    //{
                        AddImage(openFileDialog1.FileNames[k]);
                    //}
                }
            }
        }

        private void AddImage(string filepath)
        {
            try
            {
                Image img = Image.FromFile(filepath);
            }
            catch
            {
                MessageBox.Show("Incorrect image file type !");
            }
            Module.ProjectImages.Add(filepath);
            Module.Labels.Add(System.IO.Path.GetFileName(filepath));
            Module.CSSClasses.Add("sprite" + Module.CSSClassesIndex.ToString());

            Module.CSSClassesIndex++;

            lstImages.Items.Add(System.IO.Path.GetFileName(filepath));

            if (lstImages.SelectedIndex < 0) lstImages.SelectedIndex = 0;
        }

        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImages.SelectedIndex >= 0)
            {
                try
                {
                    tslImage.Text = Module.ProjectImages[lstImages.SelectedIndex];
                    txtLabel.Text = Module.Labels[lstImages.SelectedIndex];
                    txtCSSClass.Text = Module.CSSClasses[lstImages.SelectedIndex];

                    picPreview.Image = null;

                    if (chkPreview.Checked)
                    {
                        Image img = Image.FromFile(Module.ProjectImages[lstImages.SelectedIndex]);
                        if (img.Width > picPreview.Width || img.Height > picPreview.Height)
                        {
                            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            picPreview.SizeMode = PictureBoxSizeMode.CenterImage;
                        }

                        picPreview.Image = img;
                    }

                }
                catch { }

            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            while (lstImages.SelectedItems.Count > 0)
            {
                Module.ProjectImages.RemoveAt(lstImages.SelectedIndices[0]);
                Module.Labels.RemoveAt(lstImages.SelectedIndices[0]);
                Module.CSSClasses.RemoveAt(lstImages.SelectedIndices[0]);

                lstImages.Items.Remove(lstImages.SelectedItems[0]);
            }

            if (lstImages.Items.Count == 0) picPreview.Image = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstImages.Items.Clear();
            Module.Labels.Clear();
            Module.ProjectImages.Clear();
            Module.CSSClasses.Clear();
            picPreview.Image = null;
        }

        private void txtLabel_TextChanged(object sender, EventArgs e)
        {
            if (lstImages.SelectedIndex < 0) return;

            Module.Labels[lstImages.SelectedIndex] = txtLabel.Text;
        }

        private void txtCSSClass_TextChanged(object sender, EventArgs e)
        {
            if (lstImages.SelectedIndex < 0) return;

            Module.CSSClasses[lstImages.SelectedIndex] = txtCSSClass.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = Module.ImagesFilter;
            saveFileDialog1.FileName = "";

            try
            {
                if (txtCombinedImageFilepath.Text.Trim() != string.Empty) saveFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(txtCombinedImageFilepath.Text);
                saveFileDialog1.FileName = txtCombinedImageFilepath.Text;
            }
            catch { }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCombinedImageFilepath.Text = saveFileDialog1.FileName;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Module.OpenedProject = System.IO.Path.Combine(Module.DefaultProjectFolder, "DefaultProject.csp");

            txtCombinedImageFilepath.Text = System.IO.Path.Combine(Module.DefaultProjectFolder, "css-sprites.gif");           
            
            txtCombinedImageURL.Text="/images/css-sprites.gif";

            RecentFilesHelper.FillMenuRecentFile();            
        }

        private void tsbGenerate_Click(object sender, EventArgs e)
        {
            Module.CombinedImageFilepath = txtCombinedImageFilepath.Text;
            Module.CombinedImageURL = txtCombinedImageURL.Text;
            

            CSSSpritesGenerator.GenerateCSSSprites();
        }
        
        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module.CombinedImageFilepath = txtCombinedImageFilepath.Text;
            Module.CombinedImageURL = txtCombinedImageURL.Text;
            
            if (!Module.ProjectWasSavedOnce)
            {
                saveFileDialog1.Filter = "CSS Sprites Generator Projects (*.csp)|*.csp";
                saveFileDialog1.FileName = "";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CSPProject.SaveProject(saveFileDialog1.FileName);
                    RecentFilesHelper.AddRecentFile(saveFileDialog1.FileName);
                    Module.ProjectWasSavedOnce = true;
                }
            }
            else
            {
                CSPProject.SaveProject(Module.OpenedProject);
                RecentFilesHelper.AddRecentFile(Module.OpenedProject);
            }


        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSS Sprites Generator Projects (*.csp)|*.csp";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
                        

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (CSPProject.OpenProject(openFileDialog1.FileName))
                {
                    Module.ProjectWasSavedOnce = true;

                    txtCombinedImageFilepath.Text = Module.CombinedImageFilepath;
                    txtCombinedImageURL.Text = Module.CombinedImageURL;
                    
                    picPreview.Image = null;

                    lstImages.Items.Clear();

                    for (int k = 0; k < Module.ProjectImages.Count; k++)
                    {
                        lstImages.Items.Add(System.IO.Path.GetFileName(Module.ProjectImages[k]));

                        lstImages.SelectedIndex = 0;
                    }

                    RecentFilesHelper.AddRecentFile(openFileDialog1.FileName);                
                }

            }
        }

        private void shareOnFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShareHelper.ShareFacebook();
        }

        private void shareOnTwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShareHelper.ShareTwitter();
        }

        private void shareOnGooglePlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShareHelper.ShareGooglePlus();
        }

        private void shareOnLinkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShareHelper.ShareLinkedIn();
        }

        private void shareWithEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShareHelper.ShareEmail();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module.ProjectWasSavedOnce = false;
            
            Module.ProjectImages.Clear();
            Module.CSSClasses.Clear();
            Module.CSSClassesIndex = 0;
            Module.Labels.Clear();

            lstImages.Items.Clear();
            picPreview.Image = null;

            Module.OpenedProject = System.IO.Path.Combine(Module.DefaultProjectFolder, "DefaultProject.csp");

            txtCombinedImageFilepath.Text = System.IO.Path.Combine(Module.DefaultProjectFolder, "css-sprites.gif");            
            
            txtCombinedImageURL.Text = "/images/css-sprites.gif";            

        }

        private void visit4dotsSoftwareWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.4dots-software.com");
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if ((lstImages.SelectedIndex < 0) || (lstImages.SelectedIndex==lstImages.Items.Count-1)) return;

            int isel = lstImages.SelectedIndex;
            string item = lstImages.SelectedItem.ToString();

            lstImages.Items.RemoveAt(isel);

            lstImages.Items.Insert(isel + 1, item);

            string img = Module.ProjectImages[isel];
            string cssclass=Module.CSSClasses[isel];
            string lbl=Module.Labels[isel];

            Module.ProjectImages.RemoveAt(isel);
            Module.CSSClasses.RemoveAt(isel);
            Module.Labels.RemoveAt(isel);

            Module.ProjectImages.Insert(isel + 1, img);
            Module.CSSClasses.Insert(isel + 1, cssclass);
            Module.Labels.Insert(isel + 1, lbl);

            lstImages.SelectedIndex = isel + 1;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if ((lstImages.SelectedIndex < 0) || (lstImages.SelectedIndex == 0)) return;

            int isel = lstImages.SelectedIndex;
            string item = lstImages.SelectedItem.ToString();

            lstImages.Items.RemoveAt(isel);

            lstImages.Items.Insert(isel - 1, item);

            string img = Module.ProjectImages[isel];
            string cssclass = Module.CSSClasses[isel];
            string lbl = Module.Labels[isel];

            Module.ProjectImages.RemoveAt(isel);
            Module.CSSClasses.RemoveAt(isel);
            Module.Labels.RemoveAt(isel);

            Module.ProjectImages.Insert(isel - 1, img);
            Module.CSSClasses.Insert(isel - 1, cssclass);
            Module.Labels.Insert(isel - 1, lbl);

            lstImages.SelectedIndex = isel - 1;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void tsdbOpen_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (CSPProject.OpenProject(e.ClickedItem.Text))
            {
                Module.ProjectWasSavedOnce = true;

                txtCombinedImageFilepath.Text = Module.CombinedImageFilepath;
                txtCombinedImageURL.Text = Module.CombinedImageURL;
                
                picPreview.Image = null;

                lstImages.Items.Clear();

                for (int k = 0; k < Module.ProjectImages.Count; k++)
                {
                    lstImages.Items.Add(System.IO.Path.GetFileName(Module.ProjectImages[k]));

                    lstImages.SelectedIndex = 0;
                }

                RecentFilesHelper.AddRecentFile(e.ClickedItem.Text);
            }
        }

        private void followUsOnTwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://twitter.com/4dotsSoftware");
        }

        private void dotsSoftwarePRODUCTCATALOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\4dots-Software-PRODUCT-CATALOG.pdf");
        }

        private void helpGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Module.HelpURL);
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                IsDragging = true;
                e.Effect = DragDropEffects.All;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] filez = (string[])e.Data.GetData(DataFormats.FileDrop);

                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    for (int k = 0; k < filez.Length; k++)
                    {
                        AddImage(filez[k]);
                    }
                }
                finally
                {
                    this.Cursor = null;
                }
            }
        }

        private void frmMain_DragOver(object sender, DragEventArgs e)
        {
            IsDragging = true;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void visitOnlineCSSSpritesToolWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://cssspritestool.com/");
        }

    }
}
