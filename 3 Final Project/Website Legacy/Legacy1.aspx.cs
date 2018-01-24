using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultHome : System.Web.UI.Page
{

    string fav_link;
 
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        foreach (Control c in panelFav.Controls)
        {
            if (c is Image)
            {
                fav_link += c.ID + ",";
            }
        }
        labelShowBox.Text = fav_link;   
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        


    }
}