using System;
using System.Collections.Generic;
using System.Text;

namespace CSS_Sprites_Generator
{
    public class RecentFilesHelper
    {
        public frmMain frmMainOwner = null;

        public void FillMenuRecentFile()
        {
            string[] str = Properties.Settings.Default.OpenRecent.Split(new string[] { "|||" }, StringSplitOptions.RemoveEmptyEntries);

            for (int k = 0; k < str.Length; k++)
            {
                frmMainOwner.tsdbOpen.DropDownItems.Add(str[k]);                
            }
        }
                
        public void AddRecentFile(string filepath)
        {
            string[] str = Properties.Settings.Default.OpenRecent.Split(new string[] { "|||" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> strl = ArrayToListString(str);

            if (strl.IndexOf(filepath) >= 0)
            {
                strl.RemoveAt(strl.IndexOf(filepath));
            }
            
            strl.Insert(0, filepath);

            frmMainOwner.tsdbOpen.DropDownItems.Clear();

            string newrec = "";

            for (int k = 0; k < strl.Count && k <= 12; k++)
            {
                frmMainOwner.tsdbOpen.DropDownItems.Add(strl[k]);
                newrec += strl[k] + "|||";
            }

            Properties.Settings.Default.OpenRecent = newrec;
        }              

        public  List<string> ArrayToListString(string[] str)
        {
            List<string> strl = new List<string>();

            for (int k = 0; k < str.Length; k++)
            {
                strl.Add(str[k]);
            }

            return strl;
        }
    }
}
