﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TNSWebApplication
{
    public partial class _Default : Page
    {
        TCService.Service1Client tcService;
        SortService.Service1Client sortService;
        protected void Page_Load(object sender, EventArgs e)
        {
            tcService = new TCService.Service1Client();
            sortService = new SortService.Service1Client();
        }

        protected void c2fButton_Click(object sender, EventArgs e)
        {             
            int f = tcService.c2f(int.Parse(c2fInput.Text));
            c2fResLabel.Text = f.ToString();
        }

        protected void f2cButton_Click(object sender, EventArgs e)
        {            
            int c = tcService.f2c(int.Parse(f2cInput.Text));
            f2cResLabel.Text = c.ToString();
        }

        protected void sortButton_Click(object sender, EventArgs e)
        {
            string sortedString = sortService.sort(stringInput.Text);
            sortResLabel.Text = sortedString;
        }
    }
}