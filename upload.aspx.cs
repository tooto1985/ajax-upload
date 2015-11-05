using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        for (var i = 0; i < Request.Files.Count; i++)
        {
            var file = Request.Files[i];
            file.SaveAs(Server.MapPath(string.Format("upload/{0}", file.FileName)));
        }


        

    }
}