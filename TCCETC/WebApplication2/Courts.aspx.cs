using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TCCETC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Server.MapPath("App_Data/res.txt");
            var reader = new StreamReader(path);

            string line;
            while((line = reader.ReadLine()) != null){
                Console.WriteLine(line);
            }



            string[,] reservations = new string[,]{
                {"","Lundi","Mardi","Mercredi","Jeudi","Vendredi","Samedi","Dimanche"},
                {"08:00","","","","","","",""},
                {"09:00","","","","","","",""},
                {"10:00","","","","","","",""},
                {"11:00","","","","","","",""},
                {"12:00","","","","","","",""},
                {"13:00","","","","","","",""},
                {"14:00","","","","","","",""},
                {"15:00","","","","","","",""},
                {"16:00","","","","","","",""},
                {"17:00","","","","","","",""},
                {"18:00","","","","","","",""},
                {"19:00","","","","","","",""},
                {"20:00","","","","","","",""},
                {"21:00","","","","","","",""}
            };

            //tblCourt.Rows[4].Cells[3].Text = "Tennis";

            for (int x = 0; x <= reservations.Length; x++) {
                for (int y = 0; y <= 8; y++) { 
                    tblCourt.Rows[x].Cells[y].Text = reservations[x,y];
                }
            }

        }/*End Page Load*/
    }
}