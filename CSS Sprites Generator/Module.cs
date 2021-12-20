using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CSS_Sprites_Generator
{
    class Module
    {
        public static readonly string ImagesFilter = "Images (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All Files (*.*)|*.*";

        public static string OpenedProject = "";

        public static List<string> ProjectImages = new List<string>();
        public static List<string> Labels = new List<string>();
        public static List<string> CSSClasses = new List<string>();

        public static string CombinedImageFilepath = "";
        public static string CombinedImageURL = "";
        
        public static int CSSClassesIndex = 0;

        public static string DefaultProjectFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CSS Sprites Generator";

        public static bool ProjectWasSavedOnce = false;

        public static string HelpURL = "http://www.4dots-software.com/css-sprites-generator/how-to-use.php";

        public static void ShowMessage(string msg)
        {
            MessageBox.Show(msg);            
        }

        public static void ShowError(Exception ex)
        {
            ShowError("Error", ex);
        }

        public static void ShowError(string msg)
        {            
           MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);           
        }


        public static void ShowError(string msg, Exception ex)
        {
            ShowError(msg + "\n\n" + ex.Message);
        }

        public static void ShowError(string msg, string exstr)
        {
            ShowError(msg + "\n\n" + exstr);
        }


    }
}
