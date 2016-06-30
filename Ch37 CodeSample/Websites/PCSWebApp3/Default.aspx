<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Meeting Room Booker</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align: center;">
        Enter details and set a day to initiate an event.
      </h1>
    </div>
    <div style="text-align: center;">
      <table style="text-align: left; border-color: #000000;
        border-width: 2px; background-color: #fff99e;" cellspacing="0"
        cellpadding="8" rules="none" width="540">
        <tr>
          <td valign="top">
            Your Name:</td>
          <td valign="top">
            <asp:TextBox ID="nameBox" Runat="server" Width="160px" />
            <asp:RequiredFieldValidator ID="validateName" Runat="server"
              ErrorMessage="You must enter a name."
              ControlToValidate="nameBox" Display="None" />
          </td>
          <td valign="middle" rowspan="4">
            <asp:Calendar ID="calendar" Runat="server" BackColor="White" 
              ondayrender="calendar_DayRender" 
              onselectionchanged="calendar_SelectionChanged" />
          </td>
        </tr>
        <tr>
          <td valign="top">
            Event Name:</td>
          <td valign="top">
            <asp:TextBox ID="eventBox" Runat="server" Width="160px" />
            <asp:RequiredFieldValidator ID="validateEvent" Runat="server"
              ErrorMessage="You must enter an event name."
              ControlToValidate="eventBox" Display="None" />
          </td>
        </tr>
        <tr>
          <td valign="top">
            Meeting Room:</td>
          <td valign="top">
            <asp:DropDownList ID="roomList" Runat="server" Width="160px" 
            DataSourceID="MRBRoomData" DataTextField="Room" DataValueField="ID" />
            <asp:RequiredFieldValidator ID="validateRoom" Runat="server"
              ErrorMessage="You must select a room."
              ControlToValidate="roomList" Display="None" />
          </td>
        </tr>
        <tr>
          <td valign="top">
            Attendees:</td>
          <td valign="top">
            <asp:ListBox ID="attendeeList" Runat="server" Width="160px"
              SelectionMode="Multiple" Rows="6" DataSourceID="MRBAttendeeData"
              DataTextField="Name" DataValueField="ID" />
            <asp:RequiredFieldValidator ID="validateAttendees" Runat="server"
              ErrorMessage="You must have at least one attendee."
              ControlToValidate="attendeeList" Display="None" />
          </td>
        </tr>
        <tr>
          <td align="center" colspan="3">
            <asp:Button ID="submitButton" Runat="server" Width="100%"
              Text="Submit meeting room request" onclick="submitButton_Click" />
          </td>
        </tr>
        <tr>
          <td align="center" colspan="3">
            <asp:ValidationSummary ID="validationSummary" Runat="server"
              HeaderText="Before submitting your request:" />
          </td>
        </tr>
                <tr>
          <td align="left" colspan="3" style="width: 40%;">
            <table cellspacing="4" style="width: 100%;">
              <tr>
                <td colspan="2" style="text-align: center;">
                  <h2>Event details</h2>
                </td>
              </tr>
              <tr>
                <td style="width: 40%; background-color: #ccffcc;"
                  valign="top">
                  <asp:ListView ID="EventList" runat="server"
                    DataSourceID="MRBEventData2" DataKeyNames="ID"
                    OnSelectedIndexChanged="EventList_SelectedIndexChanged">
                    <LayoutTemplate>
                      <ul>
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                      </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                      <li>
                        <asp:LinkButton Text='<%# Bind("Name") %>'
                          runat="server" ID="NameLink" CommandName="Select"
                          CommandArgument='<%# Bind("ID") %>'
                          CausesValidation="false" />
                      </li>
                    </ItemTemplate>
                    <SelectedItemTemplate>
                      <li>
                        <b><%# Eval("Name") %></b>
                      </li>
                    </SelectedItemTemplate>
                  </asp:ListView>
                </td>
                <td valign="top">
                  <asp:FormView ID="FormView1" Runat="server"
                    DataSourceID="MRBEventDetailData">
                    <ItemTemplate>
                      <h3><%# Eval("Name") %></h3>
                      <b>Date:</b>
                      <%# Eval("EventDate", "{0:D}") %>
                      <br />
                      <b>Room:</b>
                      <%# Eval("Room") %>
                      <br />
                      <b>Attendees:</b>
                      <%# Eval("AttendeeList") %>
                    </ItemTemplate>
                  </asp:FormView>
                </td>
              </tr>
            </table>
          </td>
        </tr>
      </table>
    </div>
    <div>
      <p>
        Results:
        <asp:Label Runat="server" ID="resultLabel" Text="None." />
        <asp:SqlDataSource ID="MRBAttendeeData" runat="server"
          ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>"
          SelectCommand="SELECT * FROM [Attendees]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="MRBRoomData" runat="server"
          ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>"
          SelectCommand="SELECT * FROM [Rooms]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="MRBEventData" runat="server"
          ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>"
          SelectCommand="SELECT * FROM [Events]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
          DataKeyNames="ID" DataSourceID="MRBEventData">
          <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
              ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Room" HeaderText="Room" SortExpression="Room" />
            <asp:BoundField DataField="AttendeeList" HeaderText="AttendeeList" 
              SortExpression="AttendeeList" />
            <asp:BoundField DataField="EventDate" HeaderText="EventDate" 
              SortExpression="EventDate" />
          </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="MRBEventData2" Runat="server"
          SelectCommand="SELECT [ID], [Name] FROM [Events]"
          ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="MRBEventDetailData" Runat="server"
          SelectCommand="SELECT dbo.Events.Name, dbo.Rooms.Room,
                         dbo.Events.AttendeeList, dbo.Events.EventDate
                         FROM dbo.Events INNER JOIN dbo.Rooms
                         ON dbo.Events.ID = dbo.Rooms.ID WHERE dbo.Events.ID = @ID"
          ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>">
          <SelectParameters>
            <asp:ControlParameter Name="ID" DefaultValue="-1" ControlID="EventList"
              PropertyName="SelectedValue" />
          </SelectParameters>
        </asp:SqlDataSource>
      </p>
    </div>
    </form>
</body>
</html>
