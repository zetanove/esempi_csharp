using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplication1
{
    public class MyControl: Control
    {
        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write(DateTime.Now.ToShortTimeString());
        }
    }
}