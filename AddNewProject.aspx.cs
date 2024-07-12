using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddNewProject : System.Web.UI.Page
{


    clsDataAccessRCDPMISNEW cls = new clsDataAccessRCDPMISNEW();
    string sqlQuery = string.Empty;
    string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillInDropDown();
            ddl_status_SelectedIndexChanged(sender, e);
        }

    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
        addNewProject();
    }

    protected void btn_Submit_Click(object sender, ImageClickEventArgs e)
    {
        addNewProject();
    }

    protected void ddl_wings_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_division_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_circle_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_head_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_subhead_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_roadtype_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_roadname_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txt_lengthofroad_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_natureofwork_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_tyoe_of_work_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_sub_type_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_conductor_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddl_status_SelectedIndexChanged(object sender, EventArgs e)
    {
        pnlOngoing.Visible = false;
        pnldpr.Visible = false;
        pnlta.Visible = false;
        pnlsfc.Visible = false;
        pnlaa.Visible = false;
        pnlts.Visible = false;
        pnlboq.Visible = false;
        pnltender.Visible = false;

        switch (ddl_status.SelectedValue)
        {
            case "":
                break;
            case "Ongoning":
                pnlOngoing.Visible = true;
                break;
            case "DPR":
                pnldpr.Visible = true;
                break;
            case "Technical Approval":
                pnlta.Visible = true;
                break;
            case "SFC/PFC":
                pnlsfc.Visible = true;
                break;
            case "Administrative Approval":
                pnlaa.Visible = true;
                break;
            case "Technical Sanction":
                pnlts.Visible = true;
                break;
            case "BOQ":
                pnlboq.Visible = true;
                break;
            case "Tender":
                pnltender.Visible = true;
                break;
            default:
                break;
        }
    }


    protected void ddl_fyear_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void clear()
    {
        ddl_fyear.ClearSelection();
        ddl_circle.ClearSelection();
        ddl_division.ClearSelection();
        ddl_head.ClearSelection();
        ddl_roadname.ClearSelection();
        ddl_roadtype.ClearSelection();
        ddl_status.ClearSelection();
        txt_project.Text = "";
        txt_lengthofroad.Text = "";
    }

    void fillInDropDown()
    {
        SqlConnection con = new SqlConnection(strcon);
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT ID from Year;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddl_fyear.DataSource = dt;
            ddl_fyear.DataValueField = "ID";
            ddl_fyear.DataBind();

            //wings name in drodown configuration
            cmd = new SqlCommand("SELECT WingName from Wing;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_wings.DataSource = dt;
            ddl_wings.DataValueField = "WingName";
            ddl_wings.DataBind();

            //filling circle name in dropdown list
            cmd = new SqlCommand("SELECT CircleName from Circles;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_circle.DataSource = dt;
            ddl_circle.DataValueField = "CircleName";
            ddl_circle.DataBind();

            //filling division name
            cmd = new SqlCommand("SELECT DivisionName from Divisions;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_division.DataSource = dt;
            ddl_division.DataValueField = "DivisionName";
            ddl_division.DataBind();

            //filling Head Name in drowpdownlist
            cmd = new SqlCommand("SELECT headName from Head;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_head.DataSource = dt;
            ddl_head.DataValueField = "headName";
            ddl_head.DataBind();

            //filling Sub Head Name in drowpdownlist
            cmd = new SqlCommand("SELECT SubHeadName from SubHead;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_subhead.DataSource = dt;
            ddl_subhead.DataValueField = "SubHeadName";
            ddl_subhead.DataBind();

            //filling Road Type in dropdownlist
            cmd = new SqlCommand("SELECT description from RoadType;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_roadtype.DataSource = dt;
            ddl_roadtype.DataValueField = "description";
            ddl_roadtype.DataBind();

            //filling Road Name in dropdownlist
            cmd = new SqlCommand("SELECT RoadName from RaodMaster;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_roadname.DataSource = dt;
            ddl_roadname.DataValueField = "RoadName";
            ddl_roadname.DataBind();

            //filling Status in dropdownlist
            cmd = new SqlCommand("SELECT status from tbl_project_status;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_status.DataSource = dt;
            ddl_status.DataValueField = "status";
            ddl_status.DataBind();

            //filling nature of work in dropdownlist
            cmd = new SqlCommand("SELECT NatOfWorkName from NatureOfWrk;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_natureofwork.DataSource = dt;
            ddl_natureofwork.DataValueField = "NatOfWorkName";
            ddl_natureofwork.DataBind();

            //filling type in dropdownlist
            cmd = new SqlCommand("SELECT CMBDTypeName from NatOfWrk_Type;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_type_of_work.DataSource = dt;
            ddl_type_of_work.DataValueField = "CMBDTypeName";
            ddl_type_of_work.DataBind();

            //filling subtype in dropdownlist
            cmd = new SqlCommand("SELECT WSTypeName from NatOfWrk_SubType;", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            ddl_sub_type.DataSource = dt;
            ddl_sub_type.DataValueField = "WSTypeName";
            ddl_sub_type.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        finally
        {
            con.Close();
        }
    }

    void addNewProject()
    {
        string sql = "";
        SqlConnection con = new SqlConnection(strcon);

        try
        {
            // Open the connection
            con.Open();

            // Get DivisionID based on selected DivisionName
            string divisionName = ddl_division.SelectedValue;
            SqlCommand cmdDivision = new SqlCommand("SELECT DivisionID FROM Divisions WHERE DivisionName = @DivisionName", con);
            cmdDivision.Parameters.AddWithValue("@DivisionName", divisionName);
            int divisionID = Convert.ToInt32(cmdDivision.ExecuteScalar());

            // Get WingID based on selected WingName
            string wingName = ddl_wings.SelectedValue;
            SqlCommand cmdWing = new SqlCommand("SELECT WingID FROM Wing WHERE WingName = @WingName", con);
            cmdWing.Parameters.AddWithValue("@WingName", wingName);
            int wingID = Convert.ToInt32(cmdWing.ExecuteScalar());

            // Get CircleID based on selected CircleName
            string circleName = ddl_circle.SelectedValue;
            SqlCommand cmdCircle = new SqlCommand("SELECT CircleID FROM Circles WHERE CircleName = @CircleName", con);
            cmdCircle.Parameters.AddWithValue("@CircleName", circleName);
            int circleID = Convert.ToInt32(cmdCircle.ExecuteScalar());

            // Get HeadID based on selected HeadName
            string headName = ddl_head.SelectedValue;
            SqlCommand cmdHead = new SqlCommand("SELECT headId FROM Head WHERE headName = @headName", con);
            cmdHead.Parameters.AddWithValue("@headName", headName);
            int headID = Convert.ToInt32(cmdHead.ExecuteScalar());

            // Get SubHeadID based on selected SubHeadName
            string subHeadName = ddl_subhead.SelectedValue;
            SqlCommand cmdSubHead = new SqlCommand("SELECT SubHeadID FROM SubHead WHERE SubHeadName = @SubHeadName", con);
            cmdSubHead.Parameters.AddWithValue("@SubHeadName", subHeadName);
            string subHeadID = cmdSubHead.ExecuteScalar().ToString();

            // Get RoadTypeID based on selected RoadType description
            string roadTypeDesc = ddl_roadtype.SelectedValue;
            SqlCommand cmdRoadType = new SqlCommand("SELECT RoadTypeId FROM RoadType WHERE description = @description", con);
            cmdRoadType.Parameters.AddWithValue("@description", roadTypeDesc);
            int roadTypeID = Convert.ToInt32(cmdRoadType.ExecuteScalar());

            // Get RoadID based on selected RoadName
            string roadName = ddl_roadname.SelectedValue;
            SqlCommand cmdRoadName = new SqlCommand("SELECT RoadID FROM RaodMaster WHERE RoadName = @RoadName", con);
            cmdRoadName.Parameters.AddWithValue("@RoadName", roadName);
            int roadID = Convert.ToInt32(cmdRoadName.ExecuteScalar());

            // Get Status based on selected status
            string Status = ddl_status.SelectedValue;
            SqlCommand cmdStatus = new SqlCommand("SELECT id FROM tbl_project_status WHERE status = @status", con);
            cmdStatus.Parameters.AddWithValue("@status", Status);
            int stausID = Convert.ToInt32(cmdStatus.ExecuteScalar());

            // Get Nowid based on selected nature of work
            string noWID = ddl_natureofwork.SelectedValue;
            SqlCommand cmdNow = new SqlCommand("SELECT NoWID FROM NatureOfWrk WHERE NatOfWorkName = @NatOfWorkName", con);
            cmdNow.Parameters.AddWithValue("@NatOfWorkName", noWID);
            int NaoWID= Convert.ToInt32(cmdNow.ExecuteScalar());

            // Get NatOfwrk type id based on selected nature of work type
            string noWTID = ddl_type_of_work.SelectedValue;
            SqlCommand cmdNowt = new SqlCommand("SELECT NoWID FROM NatOfWrk_Type WHERE CMBDTypeName = @CMBDTypeName", con);
            cmdNowt.Parameters.AddWithValue("@CMBDTypeName", noWTID);
            int NowTID = Convert.ToInt32(cmdNowt.ExecuteScalar());

            // Get NatOfwrk sub type id based on selected nature of work type
            string noWSTID = ddl_type_of_work.SelectedValue;
            SqlCommand cmdNowst = new SqlCommand("SELECT NoWID FROM NatOfWrk_SubType WHERE WSTypeName = @WSTypeName", con);
            cmdNowst.Parameters.AddWithValue("@WSTypeName", noWSTID);
            int NowSTID = Convert.ToInt32(cmdNowst.ExecuteScalar());

            // Insert into ProjectMaster table
            sql = @"INSERT INTO ProjectMaster(FYID, WingID, CircleID, DivisionID, HeadId, SubHeadID, RoadId, ProjectName, SanctionRoadLength, Status, AArefno, AAamount, AADate, EntryDate, NoWID, CMBDTypeID, WSTypeID, Completiondate, dprstartdate,dprenddate,
                                                dprremarks,taappprovaldate,taapprovalremarks,sfcapprovaldate,sfcremarks,aaapprovaldate,aaremarks,aaamounts,tsdate,tsremarks,boqdate,boqremarks,biddate,technicalbidremarks,financialbiddate,financialbidremarks,
                                                    tastartdate,aastartdate,tsstartdate,boqstartdate,tenderstartdate) 
                                            VALUES(@FYID, @WingID, @CircleID, @DivisionID, @HeadId, @SubHeadID, @RoadId, @ProjectName, @SanctionRoadLength, @Status, @AArefno, @AAamount, @AADate, @EntryDate, @NoWID, @CMBDTypeID, @WSTypeID, @Completiondate, @dprstartdate,
                                                        @dprenddate,@dprremarks,@taappprovaldate,@taapprovalremarks,@sfcapprovaldate,@sfcremarks,@aaapprovaldate,@aaremarks,@aaamounts,@tsdate,@tsremarks,@boqdate,@boqremarks,@biddate,@technicalbidremarks,@financialbid,
                                                            @financialbidremarks,@tastartdate,@aastartdate,@tsstartdate,@boqstartdate,@tenderstartdate)";

            SqlParameter FYID = new SqlParameter("@FYID", ddl_fyear.SelectedValue);
            SqlParameter WingID = new SqlParameter("@WingID", wingID);
            SqlParameter CircleID = new SqlParameter("@CircleID", circleID);
            SqlParameter DivisionID = new SqlParameter("@DivisionID", divisionID);
            SqlParameter HeadId = new SqlParameter("@HeadId", headID);
            SqlParameter SubHeadId = new SqlParameter("@SubHeadID", subHeadID);
            SqlParameter RoadID = new SqlParameter("@RoadID", roadID);
            SqlParameter ProjectName = new SqlParameter("@ProjectName", txt_project.Text.Trim());
            SqlParameter SanctionRoadLength = new SqlParameter("@SanctionRoadLength", txt_lengthofroad.Text.Trim());
            SqlParameter StausID = new SqlParameter("@Status", stausID);
            SqlParameter AAamount = new SqlParameter("@AAamount", txt_admaprovalamount.Text.Trim());
            SqlParameter AArefno = new SqlParameter("@AArefno", txt_adaproval.Text.Trim());
            SqlParameter AADate = new SqlParameter("@AADate", txt_admin_approval_date.Text.Trim());
            SqlParameter EntryDate = new SqlParameter("@EntryDate", System.DateTime.Now);
            SqlParameter NoWID = new SqlParameter("@NoWID", NaoWID);
            SqlParameter CMBDTypeID = new SqlParameter("@CMBDTypeID", NowTID);
            SqlParameter WSTypeID = new SqlParameter("@WSTypeID", NowSTID);
            SqlParameter _Completiondate = new SqlParameter("@Completiondate", txt_completion_date.Text.Trim());

            SqlParameter dprstartdate = new SqlParameter("@dprstartdate", txtdprstartdate.Text.Trim());
            SqlParameter dprenddate = new SqlParameter("@dprenddate", txtdprenddate.Text.Trim());
            SqlParameter dprremarks = new SqlParameter("@dprremarks", txtdprreport.Text.Trim());
                
            SqlParameter taappprovaldate = new SqlParameter("@taappprovaldate", txttadate.Text.Trim());
            SqlParameter taapprovalremarks = new SqlParameter("@taapprovalremarks", txttaaremarks.Text.Trim());

            SqlParameter sfcapprovaldate = new SqlParameter("@sfcapprovaldate", txtsfcapproval.Text.Trim());
            SqlParameter sfcremarks = new SqlParameter("@sfcremarks ", txtsfcremarks.Text.Trim());

            SqlParameter aaapprovaldate = new SqlParameter("@aaapprovaldate", txtaadate.Text.Trim());
            SqlParameter aaremarks = new SqlParameter("@aaremarks", txtaaremarks.Text.Trim());
            SqlParameter aaamount = new SqlParameter("@aaamounts", txtaaamount.Text.Trim());

            SqlParameter tsdate = new SqlParameter("@tsdate", txttsdate.Text.Trim());
            SqlParameter tsremarks = new SqlParameter("@tsremarks", txttsremarks.Text.Trim());

            SqlParameter boqdate = new SqlParameter("@boqdate", txtboqdate.Text.Trim());
            SqlParameter boqremarks = new SqlParameter("@boqremarks", txtboqremarks.Text.Trim());

            SqlParameter biddate = new SqlParameter("@biddate", txtbiddate.Text.Trim());
            SqlParameter technicalbidremarks = new SqlParameter("@technicalbidremarks", txtbidremarks.Text.Trim());
            SqlParameter financialbid = new SqlParameter("@financialbid", txtfinancialbid.Text.Trim());
            SqlParameter financialbidremarks = new SqlParameter("@financialbidremarks", txtfinancialbidremarks.Text.Trim());

            SqlParameter tastartdate = new SqlParameter("@tastartdate", txttastrtdt.Text.Trim());
            SqlParameter sfcstrtdt = new SqlParameter("@sfcstartdate", txtsfcstrtdt.Text.Trim());
            SqlParameter aastrtdt = new SqlParameter("@aastartdate", txtaastrtdt.Text.Trim());
            SqlParameter tsstrtdt = new SqlParameter("@tsstartdate", txttsstrtdt.Text.Trim());
            SqlParameter boqstrtdt = new SqlParameter("@boqstartdate", txtboqstrtdt.Text.Trim());
            SqlParameter tndrstrtdt = new SqlParameter("@tenderstartdate", txttndrstrtdt.Text.Trim());

            // Execute the SQL query
            clear();
            if (cls.ExecuteSql(sql, new SqlParameter[] { FYID, WingID, CircleID, DivisionID, HeadId, SubHeadId, RoadID, ProjectName, SanctionRoadLength, StausID, AArefno, AAamount, AADate, EntryDate, NoWID, CMBDTypeID, WSTypeID, _Completiondate, dprstartdate,dprenddate,dprremarks,
                               taappprovaldate,taapprovalremarks,sfcapprovaldate,sfcremarks,aaapprovaldate,aaremarks,aaamount,tsdate,tsremarks,boqdate,boqremarks,biddate,technicalbidremarks,financialbid,financialbidremarks,tastartdate,sfcstrtdt,aastrtdt,tsstrtdt,boqstrtdt,tndrstrtdt }) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "msgSuccAdm", "alert('Project Details Saved Successfully.');", true);
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        finally
        {
            // Close the connection
            con.Close();
        }
    }

    protected void btn_reset_Click(object sender, EventArgs e)
    {
        clear();
    }
}