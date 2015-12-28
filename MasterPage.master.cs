﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserID"] == null)
        {
            menu.Visible = false;
        }
        else if (Session["Role"].ToString() == "Doctor")
        {
            PatientMenu.Visible = false;
        }
        else if (Session["Role"].ToString() == "Patient")
        {
            DoctorMenu.Visible = false;
        }
        else
        {
            menu1.Visible = true;
        }

      
    }
}
