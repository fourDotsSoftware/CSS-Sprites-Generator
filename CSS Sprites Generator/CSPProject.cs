using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CSS_Sprites_Generator
{
    class CSPProject
    {
        public static bool SaveProject(string filepath)
        {
            DataTable dt = new DataTable("table");
            dt.Columns.Add("cssclass");
            dt.Columns.Add("image");
            dt.Columns.Add("label");

            for (int k = 0; k < Module.CSSClasses.Count; k++)
            {
                DataRow dr = dt.NewRow();
                dr["cssclass"] = Module.CSSClasses[k];
                dr["image"] = Module.ProjectImages[k];
                dr["label"] = Module.Labels[k];

                dt.Rows.Add(dr);
            }

            DataTable dtprops = new DataTable("properties");

            dtprops.Columns.Add("combined_filepath");
            dtprops.Columns.Add("combined_url");
            
            dtprops.Columns.Add("cssindex");

            DataRow dr2 = dtprops.NewRow();

            dr2["combined_filepath"] = Module.CombinedImageFilepath;
            dr2["combined_url"] = Module.CombinedImageURL;
            
            dr2["cssindex"] = Module.CSSClassesIndex.ToString();
            
            dtprops.Rows.Add(dr2);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dtprops);

            ds.WriteXml(filepath);

            Module.OpenedProject = filepath;

            return true;
        }

        public static bool OpenProject(string filepath)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(filepath);

            DataTable dt = ds.Tables[0];
            DataTable dtprops = ds.Tables[1];

            Module.CSSClasses = new List<string>();
            Module.Labels = new List<string>();
            Module.ProjectImages = new List<string>();

            for (int k = 0; k < dt.Rows.Count; k++)
            {
                Module.CSSClasses.Add(dt.Rows[k]["cssclass"].ToString());
                Module.Labels.Add(dt.Rows[k]["label"].ToString());
                Module.ProjectImages.Add(dt.Rows[k]["image"].ToString());
            }

            DataRow dr2 = dtprops.Rows[0];

            Module.CombinedImageFilepath = dr2["combined_filepath"].ToString();
            Module.CombinedImageURL = dr2["combined_url"].ToString();
            
            Module.CSSClassesIndex = int.Parse(dr2["cssindex"].ToString());
                        
            Module.OpenedProject = filepath;

            return true;
        }
    }
}