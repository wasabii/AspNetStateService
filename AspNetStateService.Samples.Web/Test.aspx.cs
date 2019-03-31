﻿using System;

namespace AspNetStateService.Samples.Web
{

    public partial class Test : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs args)
        {

        }

        public int Value
        {
            get => (int?)Session["Value"] ?? 0;
            set => Session["Value"] = value;
        }

    }

}