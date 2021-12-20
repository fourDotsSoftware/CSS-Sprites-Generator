using System;
using System.Collections.Generic;
using System.Text;

namespace CSS_Sprites_Generator
{
    class ShareHelper
    {
        private static string ShareURL
        {
            get
            {
                return "http://www.4dots-software.com/css-sprites-generator/";
            }
        }

        private static string ShareText
        {
            get
            {
                return "Cool free application to easily generate CSS Image Sprites !";
            }
        }

        public static void ShareFacebook()
        {                                
            System.Diagnostics.Process.Start("http://www.facebook.com/sharer.php?u="+ShareURL+"&t="+ShareText);
                                       
        }

        public static void ShareTwitter()
        {            
            System.Diagnostics.Process.Start("http://twitter.com/share?text=" + ShareText + "&url=" + ShareURL);
        }

        public static void ShareGooglePlus()
        {             
            System.Diagnostics.Process.Start("https://plus.google.com/share?url=" + ShareURL);
        }

        public static void ShareLinkedIn()
        {            
            System.Diagnostics.Process.Start("https://www.linkedin.com/shareArticle?mini=true&url="+ShareURL+"&title="+ShareText+"%20!&summary=&source=");
        }
        
        public static void ShareEmail()
        {            
            System.Diagnostics.Process.Start("mailto:&subject=" + ShareText + "&body=" + ShareText + "%20" + ShareURL);
        }
    }
}
