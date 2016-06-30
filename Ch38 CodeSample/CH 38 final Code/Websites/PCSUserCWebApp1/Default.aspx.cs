﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
   {

   }

   protected void suitList_SelectedIndexChanged(object sender, EventArgs e)
   {
      myUserControl.Suit = (suit)Enum.Parse(typeof(suit),
                                           suitList.SelectedItem.Value);
   }

   protected void clubButton_Click(object sender, ImageClickEventArgs e)
   {
      myUserControl.Club();
      suitList.SelectedIndex = 0;
   }

   protected void diamondButton_Click(object sender, ImageClickEventArgs e)
   {
      myUserControl.Diamond();
      suitList.SelectedIndex = 1;
   }

   protected void heartButton_Click(object sender, ImageClickEventArgs e)
   {
      myUserControl.Heart();
      suitList.SelectedIndex = 2;
   }

   protected void spadeButton_Click(object sender, ImageClickEventArgs e)
   {
      myUserControl.Spade();
      suitList.SelectedIndex = 3;
   }
}
