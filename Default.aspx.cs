using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calcontrol
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 27)
                e.Cell.Controls.Add(new LiteralControl("</br>Eid Milad"));


        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 27)
                e.Cell.Controls.Add(new LiteralControl("</br>Eid Milad"));


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan t = Calendar2.SelectedDate - Calendar1.SelectedDate;
            Label1.Text += t.Days.ToString();
        }
    }
}
