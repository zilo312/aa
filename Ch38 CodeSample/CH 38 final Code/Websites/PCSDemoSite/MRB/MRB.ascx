<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MRB.ascx.cs" Inherits="MRB" %>
<div style="text-align: center;">
  &nbsp;
  <table class="mrbTable" cellspacing="0" cellpadding="8" rules="none" width="540">
    <tr>
      <td valign="top">
        Your Name:</td>
      <td valign="top">
        <asp:TextBox ID="nameBox" runat="server" Width="160px" Enabled="false" />
        <asp:RequiredFieldValidator ID="validateName" runat="server" ErrorMessage="You must enter a name."
          ControlToValidate="nameBox" Display="None" />
      </td>
      <td valign="middle" rowspan="4">
        <asp:Calendar ID="calendar" runat="server" OnSelectionChanged="calendar_SelectionChanged"
          OnDayRender="calendar_DayRender"></asp:Calendar>
      </td>
    </tr>
    <tr>
      <td valign="top">
        Event Name:</td>
      <td valign="top">
        <asp:TextBox ID="eventBox" runat="server" Width="160px" />
        <asp:RequiredFieldValidator ID="validateEvent" runat="server" ErrorMessage="You must enter an event name."
          ControlToValidate="eventBox" Display="None" />
      </td>
    </tr>
    <tr>
      <td valign="top">
        Meeting Room:</td>
      <td valign="top">
        <asp:DropDownList ID="roomList" runat="server" Width="160px" DataSourceID="MRBRoomData"
          DataTextField="Room" DataValueField="ID" />
        <asp:RequiredFieldValidator ID="validateRoom" runat="server" ErrorMessage="You must select a room."
          ControlToValidate="roomList" Display="None" />
      </td>
    </tr>
    <tr>
      <td valign="top">
        Attendees:</td>
      <td valign="top">
        <asp:ListBox ID="attendeeList" runat="server" Width="160px" SelectionMode="Multiple"
          Rows="6" DataSourceID="MRBAttendeeData" DataTextField="Name" DataValueField="ID" />
        <asp:RequiredFieldValidator ID="validateAttendees" runat="server" ErrorMessage="You must have at least one attendee."
          ControlToValidate="attendeeList" Display="None" />
      </td>
    </tr>
    <tr>
      <td align="center" colspan="3">
        <asp:Button ID="submitButton" runat="server" Width="100%" Text="Submit meeting room request"
          OnClick="submitButton_Click" />
      </td>
    </tr>
    <tr>
      <td align="center" colspan="3">
        <asp:ValidationSummary ID="validationSummary" runat="server" HeaderText="Before submitting your request:" />
      </td>
    </tr>
    <tr>
      <td align="left" colspan="3" style="width: 40%;">
        <table cellspacing="4" style="width: 100%;">
          <tr>
            <td colspan="2" style="text-align: center;">
              <h2>
                Event details</h2>
            </td>
          </tr>
          <tr>
            <td class="mrbEventList" valign="top">
              <asp:ListView ID="EventList" runat="server" DataSourceID="MRBEventData2" DataKeyNames="ID"
                OnSelectedIndexChanged="EventList_SelectedIndexChanged">
                <LayoutTemplate>
                  <ul>
                     <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                  </ul>
                </LayoutTemplate>
                <ItemTemplate>
                  <li>
                    <asp:LinkButton Text='<%# Bind("Name") %>' runat="server" ID="NameLink" CommandName="Select"
                      CommandArgument='<%# Bind("ID") %>' CausesValidation="false" />
                  </li>
                </ItemTemplate>
                <SelectedItemTemplate>
                  <li><b>
                    <%# Eval("Name") %></b> </li>
                </SelectedItemTemplate>
              </asp:ListView>
            </td>
            <td valign="top">
              <asp:FormView ID="FormView1" runat="server" DataSourceID="MRBEventDetailData">
                <ItemTemplate>
                  <h3>
                    <%# Eval("Name") %>
                  </h3>
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
    <asp:SqlDataSource ID="MRBAttendeeData" runat="server" SelectCommand="SELECT * FROM [Attendees]"
      ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="MRBRoomData" runat="server" SelectCommand="SELECT * FROM [Rooms]"
      ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="MRBEventData" runat="server" SelectCommand="SELECT * FROM [Events]"
      ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="MRBEventData2" runat="server" SelectCommand="SELECT [ID], [Name] FROM [Events]"
      ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="MRBEventDetailData" runat="server" SelectCommand="SELECT dbo.Events.Name, dbo.Rooms.Room, dbo.Events.AttendeeList, dbo.Events.EventDate FROM dbo.Events INNER JOIN dbo.Rooms ON dbo.Events.ID = dbo.Rooms.ID WHERE dbo.Events.ID = @ID"
      ConnectionString="<%$ ConnectionStrings:MRBConnectionString %>">
      <SelectParameters>
        <asp:ControlParameter Name="ID" DefaultValue="-1" ControlID="EventList" PropertyName="SelectedValue" />
      </SelectParameters>
    </asp:SqlDataSource>
  </p>
</div>
