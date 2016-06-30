using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if (!this.IsPostBack)
       {
          calendar.SelectedDate = DateTime.Now;
       }
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
       if (this.IsValid)
       {
          resultLabel.Text = roomList.SelectedItem.Text +
             " has been booked on " +
             calendar.SelectedDate.ToLongDateString() +
             " by " + nameBox.Text + " for " +
             eventBox.Text + " event. ";
          foreach (ListItem attendee in attendeeList.Items)
          {
             if (attendee.Selected)
             {
                resultLabel.Text += attendee.Text + ", ";
             }
          }
          resultLabel.Text += " and " + nameBox.Text +
             " will be attending.";
       }
    }
}
