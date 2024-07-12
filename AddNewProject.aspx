<%@ Page Title="" Language="C#" MasterPageFile="~/WebSiteMaster.master" AutoEventWireup="true" CodeFile="AddNewProject.aspx.cs" Inherits="AddNewProject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@700&display=swap" rel="stylesheet">
    <style>
        .border-blue {
            border: 10px solid blue;
        }
        .form-label {
            font-weight: bold;
            color: #626567;
            font-family: 'Roboto', sans-serif;
        }
        .thick-border {
            border: 3px solid #626567;
        }
        .heading {
            font-family: 'Poppins', sans-serif;
            font-size: 24px;
            text-align: center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 20px;">
        <div class="border-blue">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <div class="heading">Add Project</div>
                    <asp:ImageButton ID="btn_Submit" runat="server" OnClick="btn_Submit_Click" Height="35px" Width="100px"
                        ImageUrl="images/submitButton.jpg" style="float: right; margin-top: -2px;" />
                </div>
                <div class="card-body">
                    <div class="form-row">
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_fyear" class="form-label">Year*:</label>
                            <asp:DropDownList ID="ddl_fyear" runat="server" CssClass="form-control" Font-Bold="true" ForeColor="White" BackColor="#626567" OnSelectedIndexChanged="ddl_fyear_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_wings" class="form-label">Wings:</label>
                            <asp:DropDownList ID="ddl_wings" runat="server" CssClass="form-control" Font-Bold="true" ForeColor="White" BackColor="#626567" OnSelectedIndexChanged="ddl_wings_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_circle" class="form-label">Circle:</label>
                            <asp:DropDownList ID="ddl_circle" runat="server" CssClass="form-control" Font-Bold="true" ForeColor="White" BackColor="#626567" OnSelectedIndexChanged="ddl_circle_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_division" class="form-label">Division:</label>
                            <asp:DropDownList ID="ddl_division" runat="server" CssClass="form-control" Font-Bold="true" ForeColor="White" BackColor="#626567" OnSelectedIndexChanged="ddl_division_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_head" class="form-label">Head Name*:</label>
                            <asp:DropDownList ID="ddl_head" runat="server" AutoPostBack="true" Font-Bold="true" ForeColor="White" BackColor="#626567" OnSelectedIndexChanged="ddl_head_SelectedIndexChanged" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_subhead" class="form-label">Sub-Head:</label>
                            <asp:DropDownList ID="ddl_subhead" runat="server" AutoPostBack="true" Font-Bold="true" ForeColor="White" BackColor="#626567" CssClass="form-control" OnSelectedIndexChanged="ddl_subhead_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-10 col-xs-12">
                            <label for="txt_project" class="form-label">Project*:</label>
                            <asp:TextBox ID="txt_project" runat="server" CssClass="form-control thick-border"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_roadtype" class="form-label">Road Type*:</label>
                            <asp:DropDownList ID="ddl_roadtype" runat="server" AutoPostBack="true" Font-Bold="true" ForeColor="White" BackColor="#626567" OnSelectedIndexChanged="ddl_roadtype_SelectedIndexChanged" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-9 col-xs-12">
                            <label for="ddl_roadname" class="form-label">Road Name*:</label>
                            <asp:DropDownList ID="ddl_roadname" runat="server" AutoPostBack="true" Font-Bold="true" ForeColor="White" BackColor="#626567" CssClass="form-control" OnSelectedIndexChanged="ddl_roadname_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-3 col-xs-12">
                            <label for="txt_lengthofroad" class="form-label">Length of Sanction Road*:</label>
                            <asp:TextBox ID="txt_lengthofroad" runat="server" placeholder="(in km)" CssClass="form-control thick-border" OnTextChanged="txt_lengthofroad_TextChanged"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-2 col-xs-12">
                            <label for="ddl_status" class="form-label">Status:</label>
                            <asp:DropDownList ID="ddl_status" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_status_SelectedIndexChanged" CssClass="form-control" Enabled="true" Font-Bold="true" ForeColor="White" BackColor="#626567"></asp:DropDownList>
                        </div>
                    </div>
                    <asp:Panel runat="server" ID="pnlOngoing">
                        <div class="row">
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label4" runat="server" Text="Nature Of Work:"></asp:Label>
                                <asp:DropDownList ID="ddl_natureofwork" runat="server" CssClass="form-control" AutoPostBack="true"
                                    OnSelectedIndexChanged="ddl_natureofwork_SelectedIndexChanged" style="margin-bottom: 2px;">
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="lbl_work_type" runat="server" Text="Type:"></asp:Label>
                                <asp:DropDownList ID="ddl_type_of_work" runat="server" CssClass="form-control" AutoPostBack="true"
                                    OnSelectedIndexChanged="ddl_tyoe_of_work_SelectedIndexChanged" style="margin-bottom: 2px;">
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="lbl_sub_type" runat="server" Text="Sub-Type:" ></asp:Label>
                                <asp:DropDownList ID="ddl_sub_type" runat="server" CssClass="form-control" style="margin-bottom: 2px;"></asp:DropDownList>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label5" runat="server" Text="Administrative Approval Reference No.*:" style="font-size:12px; margin-bottom: 2px;"></asp:Label>
                                <asp:TextBox ID="txt_adaproval" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label6" runat="server" Text="Administrative Approval Amount*:" ></asp:Label>
                                <asp:TextBox ID="txt_admaprovalamount" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label7" runat="server" Text="Administrative Approval Date*:"></asp:Label>
                                <asp:TextBox ID="txt_admin_approval_date" runat="server"  TextMode="date" CssClass="form-control" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label8" runat="server" Text="Technical Sanction Reference No.*:"></asp:Label>
                                <asp:TextBox ID="txt_tecref" runat="server" CssClass="form-control" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label9" runat="server" Text="Technical Sanction Amount:*" ></asp:Label>
                                <asp:TextBox ID="txt_technical" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label10" runat="server" Text="Technical Sanction Date*:"></asp:Label>
                                <asp:TextBox ID="txt_technicalsanction" runat="server"  TextMode="date" CssClass="form-control" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label11" runat="server" Text="Administrative Approval Amount:*"></asp:Label>
                                <asp:TextBox ID="txt_technicalsanctionapprovedamount" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label12" runat="server" Text="Estimated Cost*:"></asp:Label>
                                <asp:TextBox ID="txt_estimatedcost" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label13" runat="server" Text="Amount Released*:" ></asp:Label>
                                <asp:TextBox ID="txt_amountreleased" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label14" runat="server" Text="Amount Received:*"></asp:Label>
                                <asp:TextBox ID="txt_amountreceived" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label15" runat="server" Text="Estimate Expenditure:*"></asp:Label>
                                <asp:TextBox ID="txt_estimate" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label16" runat="server" Text="Completion Date:*"></asp:Label>
                                <asp:TextBox ID="txt_completion_date" runat="server"  TextMode="date" CssClass="form-control" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-3 col-xs-12">
                                <asp:Label ID="Label17" runat="server" Text="Cost Completed:*"></asp:Label>
                                <asp:TextBox ID="txt_cost_completed" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-3 col-xs-12">
                                <asp:Label ID="Label18" runat="server" Text="Economic IRR:*"></asp:Label>
                                <asp:TextBox ID="txt_economic" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                            <div class="col-md-2 col-xs-12">
                                <asp:Label ID="Label19" runat="server" Text="Last Year Expenditure:*"></asp:Label>
                                <asp:TextBox ID="txt_lastyear" runat="server" CssClass="form-control" placeholder="(In Lakh)" style="margin-bottom: 2px;"></asp:TextBox>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel  runat="server" ID="pnldpr">
                    <div class="row">
                      <div class="col-md-2 col-xs-12">
                  
                     <asp:Label ID="lbldprstartdate" runat="server" Text="DPR start Date :"></asp:Label>
                      <asp:TextBox ID="txtdprstartdate" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                    <div class="col-md-2 col-xs-12">
                  
                      <asp:Label ID="lbldprenddate" runat="server" Text="DPR End Date:"></asp:Label>
                       <asp:TextBox ID="txtdprenddate" runat="server"  TextMode="date" CssClass="form-control"></asp:TextBox>
                     </div>
                     <div class="col-md-2 col-xs-12">
                  
                        <asp:Label ID="lbldprreport" runat="server" Text="DPR Status Report :"></asp:Label>
                       <asp:TextBox ID="txtdprreport" runat="server" CssClass="form-control" ></asp:TextBox>
                     </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel  runat="server" ID="pnlta">
                         <div class="row">
                      <div class="col-md-2 col-xs-12">
                  
                     <asp:Label ID="lbltastrtdt" runat="server" Text="TA Start Date:"></asp:Label>
                    <asp:TextBox ID="txttastrtdt" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                      <asp:Label ID="lbltadate" runat="server" Text="TA Approval Date:"></asp:Label>
                   <asp:TextBox ID="txttadate" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                       <asp:Label ID="lbltaremarks" runat="server" Text="TA Approval Remarks:"></asp:Label>
                    <asp:TextBox ID="txttaaremarks" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                     </div>
                             </div>
                     </asp:Panel>
                    <asp:Panel  runat="server" ID="pnlsfc">
                         <div class="row">
                      <div class="col-md-2 col-xs-12">
                  
                     <asp:Label ID="lblsfcstrtdt" runat="server" Text="SFC Start Date:" ></asp:Label>
                     <asp:TextBox ID="txtsfcstrtdt" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                       <asp:Label ID="lblsfcapproval" runat="server" Text="SFC Approval Date:" ></asp:Label>
                  <asp:TextBox ID="txtsfcapproval" runat="server"  CssClass="form-control" TextMode="date" ></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                     <asp:Label ID="lblsfcremark" runat="server" Text="SFC/PFC Remarks:" ></asp:Label>
                     <asp:TextBox ID="txtsfcremarks" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                     </div>
                             </div>
                     </asp:Panel>
                    <asp:Panel  runat="server" ID="pnlaa">
                         <div class="row">
                      <div class="col-md-2 col-xs-12">
                  
                      <asp:Label ID="lblaastrtdt" runat="server" Text="AA Start Date:"></asp:Label>
                     <asp:TextBox ID="txtaastrtdt" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                        <asp:Label ID="lblaadate" runat="server" Text="AA Approval Date:"></asp:Label>
                 <asp:TextBox ID="txtaadate" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                    <asp:Label ID="lblaaremarks" runat="server" Text="AA Remarks:"></asp:Label>
                    <asp:TextBox ID="txtaaremarks" runat="server" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
                     </div>

                      <div class="col-md-2 col-xs-12">
                  
                  <asp:Label ID="lblaaamount" runat="server" Text="AA Amount:(In Lakh)" ></asp:Label>
                    <asp:TextBox ID="txtaaamount" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
                             </div>
                     </asp:Panel>
                    <asp:Panel  runat="server" ID="pnlts">
                         <div class="row">
                      <div class="col-md-2 col-xs-12">
                  
                      <asp:Label ID="lbltsstrtdt" runat="server" Text="TS Start Date:"></asp:Label>
                     <asp:TextBox ID="txttsstrtdt" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                       <asp:Label ID="lbltsdate" runat="server" Text="TS Date:"></asp:Label>
                 <asp:TextBox ID="txttsdate" runat="server"  CssClass="form-control" TextMode="date" ></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                    <asp:Label ID="lbltsremarks" runat="server" Text="TS Remarks:"></asp:Label>
                     <asp:TextBox ID="txttsremarks" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                     </div>
</div>
                     
                     </asp:Panel>
                    <asp:Panel  runat="server" ID="pnlboq">
                         <div class="row">
                      <div class="col-md-2 col-xs-12">
                  
                      <asp:Label ID="lblboqstrtdt" runat="server" Text="BOQ Start Date:" ></asp:Label>  
                    <asp:TextBox ID="txtboqstrtdt" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                      <asp:Label ID="lblboqdate" runat="server" Text="BOQ Date :" ></asp:Label>
                  <asp:TextBox ID="txtboqdate" runat="server"  CssClass="form-control" TextMode="date" ></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                    <asp:Label ID="lblboqremarks" runat="server" Text="BOQ Remarks:"></asp:Label>
                      <asp:TextBox ID="txtboqremarks" runat="server" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
                     </div>
</div>
                     
                     </asp:Panel>
                    <asp:Panel  runat="server" ID="pnltender">
                         <div class="row">
                      <div class="col-md-2 col-xs-12">
                  
                      <asp:Label ID="lbltndrstrtdt" runat="server" Text="Tender Start Date:" ></asp:Label>
                    <asp:TextBox ID="txttndrstrtdt" runat="server"  CssClass="form-control" TextMode="date"></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                    <asp:Label ID="lblbiddate" runat="server" Text="Technical Bid Date :" ></asp:Label>
                    <asp:TextBox ID="txtbiddate" runat="server"  CssClass="form-control" TextMode="date" ></asp:TextBox>
                     </div>
                      <div class="col-md-2 col-xs-12">
                  
                   <asp:Label ID="lblbidremarks" runat="server" Text="Technical Bid Remarks:"></asp:Label>
                     <asp:TextBox ID="txtbidremarks" runat="server" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
                     </div>
                     <div class="col-md-2 col-xs-12">
                  
                 <asp:Label ID="lblfinancialdate" runat="server" Text="Financial Bid Date :" ></asp:Label>
                     <asp:TextBox ID="txtfinancialbid" runat="server" CssClass="form-control" TextMode="date" ></asp:TextBox>
                     </div>
                     <div class="col-md-2 col-xs-12">
                  
                 <asp:Label ID="lblfinancialbidremarks" runat="server" Text="Financial Bid Remarks :" ></asp:Label>
                       <asp:TextBox ID="txtfinancialbidremarks" runat="server" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
                     </div>
                             </div>
                     </asp:Panel>
                </div>
                <div class="form-row justify-content-center">
                        <div class="form-group col-md-2 col-xs-12">
                            <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="btn btn-primary btn-block" OnClick="btn_save_Click" />
                        </div>
                        <div class="form-group col-md-2 col-xs-12">
                            <asp:Button ID="btn_reset" runat="server" Text="Reset" CssClass="btn btn-info btn-block" OnClick="btn_reset_Click" />
                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
