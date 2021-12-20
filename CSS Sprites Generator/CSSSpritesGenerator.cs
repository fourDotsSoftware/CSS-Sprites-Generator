using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CSS_Sprites_Generator
{
    class CSSSpritesGenerator
    {
        public static void GenerateCSSSprites()
        {
            int totalwidth = 0;

            // collection that stores the image objects in order to get their size

            List<Image> lstimg = new List<Image>();
            
            for (int k = 0; k < Module.ProjectImages.Count; k++)
            {
                lstimg.Add(Image.FromFile(Module.ProjectImages[k]));
            }
            
            List<string> lstd = Module.Labels;

            #region calculate total width of the images and their maximum height

            int maxheight = 0;

            for (int k = 0; k < lstimg.Count; k++)
            {
                totalwidth += lstimg[k].Width;

                if (lstimg[k].Height > maxheight)
                {
                    maxheight = lstimg[k].Height;
                }
            }

            int height = maxheight;

            #endregion

            // Create an Image with the correct size

            Bitmap bmp = new Bitmap(totalwidth, height);

            Graphics g = Graphics.FromImage(bmp);

            int curwidth = 0;

            #region Get the correct output filepaths for the .css and the .html file that will be generated

            string cssfilepath="";
            string htmlfilepath="";
            string testhtmlfilepath = "";

            if (Module.OpenedProject==string.Empty)
            {
                cssfilepath=System.IO.Path.Combine(Module.DefaultProjectFolder,"css-sprites.css");
                htmlfilepath=System.IO.Path.Combine(Module.DefaultProjectFolder,"css-sprites.html");
                htmlfilepath = System.IO.Path.Combine(Module.DefaultProjectFolder, "test-css-sprites.html");

                if (!System.IO.Directory.Exists(Module.DefaultProjectFolder))
                {
                    System.IO.Directory.CreateDirectory(Module.DefaultProjectFolder);
                }
            }
            else
            {
                cssfilepath=System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Module.OpenedProject),"css-sprites.css");
                htmlfilepath=System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Module.OpenedProject),"css-sprites.html");
                testhtmlfilepath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Module.OpenedProject), "test-css-sprites.html");

                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(Module.OpenedProject)))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Module.OpenedProject));
                }
            }

            #endregion

            StringBuilder sbcss = new StringBuilder();
            StringBuilder sbhtml = new StringBuilder();
            StringBuilder sbtestcss = new StringBuilder();
            
            using (System.IO.StreamWriter swc = new System.IO.StreamWriter(cssfilepath))
            {
                using (System.IO.StreamWriter swh = new System.IO.StreamWriter(htmlfilepath))
                {
                    using (System.IO.StreamWriter swtesth = new System.IO.StreamWriter(testhtmlfilepath))
                    {

                        for (int k = 0; k < lstimg.Count; k++)
                        {
                            // get the correct position in the y-axis

                            int yoffset = maxheight - lstimg[k].Height;

                            g.DrawImage(lstimg[k], new Rectangle(curwidth, yoffset, lstimg[k].Width, lstimg[k].Height));

                            // get the correct position in the x-axis

                            string sbw = "-" + curwidth;

                            if (curwidth == 0)
                            {
                                sbw = "0";
                            }

                            // write label
                            sbcss.AppendLine("/* " + lstd[k] + " */");
                            sbtestcss.AppendLine("/* " + lstd[k] + " */");

                            sbcss.AppendLine("." + Module.CSSClasses[k]);
                            sbtestcss.AppendLine("." + Module.CSSClasses[k]);

                            sbcss.AppendLine("{");
                            sbtestcss.AppendLine("{");

                            // write the correct css code for the sprite

                            sbcss.AppendLine("background:url('" + Module.CombinedImageURL + "') " + sbw + "px -" + yoffset.ToString() + "px;");

                            Uri combUri = new Uri(Module.CombinedImageFilepath);
                            string combAbsoluteUri = combUri.AbsoluteUri;

                            sbtestcss.AppendLine("background:url('" + combAbsoluteUri + "') " + sbw + "px -" + yoffset.ToString() + "px;");

                            sbcss.AppendLine("display:inline-block;");
                            sbtestcss.AppendLine("display:inline-block;");

                            sbcss.AppendLine("width:" + lstimg[k].Width.ToString() + "px;");
                            sbtestcss.AppendLine("width:" + lstimg[k].Width.ToString() + "px;");

                            sbcss.AppendLine("height:" + lstimg[k].Height.ToString() + "px;");
                            sbtestcss.AppendLine("height:" + lstimg[k].Height.ToString() + "px;");

                            sbcss.AppendLine("}");
                            sbtestcss.AppendLine("}");

                            sbcss.AppendLine();
                            sbtestcss.AppendLine();

                            curwidth += lstimg[k].Width;

                            // html code for the placeholder image
                            sbhtml.AppendLine("<span class=\"" + Module.CSSClasses[k] + "\"></span>");
                        }

                        swc.Write(sbcss.ToString());

                        swh.WriteLine("<html>");
                        swtesth.WriteLine("<html>");

                        swh.WriteLine("<head>");
                        swtesth.WriteLine("<head>");

                        swh.WriteLine("<style>");
                        swtesth.WriteLine("<style>");

                        swh.WriteLine(sbcss.ToString());
                        swtesth.WriteLine(sbtestcss.ToString());

                        swh.WriteLine("</style>");
                        swtesth.WriteLine("</style>");

                        swh.WriteLine("</head>");
                        swtesth.WriteLine("</head>");

                        swh.WriteLine("<body>");
                        swtesth.WriteLine("<body>");

                        swh.WriteLine(sbhtml.ToString());
                        swtesth.WriteLine(sbhtml.ToString());

                        swh.WriteLine("</body>");
                        swtesth.WriteLine("</body>");

                        swh.WriteLine("</html>");
                        swtesth.WriteLine("</html>");

                        #region Save Sprites Image and Placeholder Image

                        if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(Module.CombinedImageFilepath)))
                        {
                            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Module.CombinedImageFilepath));
                        }

                        string ext = System.IO.Path.GetExtension(Module.CombinedImageFilepath).ToLower();

                        if (ext == ".png")
                        {
                            bmp.Save(Module.CombinedImageFilepath, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else if (ext == ".jpg" || ext == ".jpeg")
                        {
                            bmp.Save(Module.CombinedImageFilepath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        else
                        {
                            bmp.Save(Module.CombinedImageFilepath, System.Drawing.Imaging.ImageFormat.Gif);
                        }

                        #endregion

                    }
                }
            }

            ExploreOutFile(cssfilepath);
        }

        private static void ExploreOutFile(string filepath)
        {
            string args = string.Format("/e, /select, \"{0}\"", filepath);
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = "explorer";
            info.UseShellExecute = true;
            info.Arguments = args;
            System.Diagnostics.Process.Start(info);
        }
    }
}
