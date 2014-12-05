using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


namespace TCCETC
{

    public partial class Members : System.Web.UI.Page
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        public void BindData()
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["sqlConnect"]);
            cmd.CommandText = "Select * from Users";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            Grid.DataSource = ds;
            Grid.DataBind();
            con.Close();
        }
        protected void Grid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            Grid.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }
        protected void Grid_EditCommand(object source, DataGridCommandEventArgs e)
        {
            Grid.EditItemIndex = e.Item.ItemIndex;
            BindData();
        }
        protected void Grid_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            Grid.EditItemIndex = -1;
            BindData();
        }
        protected void Grid_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["sqlConnect"]);
            cmd.Connection = con;
            Guid userId = (Guid)Grid.DataKeys[(int)e.Item.ItemIndex];
            cmd.CommandText = "Delete from Users where UserId='" + userId + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            Grid.EditItemIndex = -1;
            BindData();
        }
        protected void Grid_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["sqlConnect"]);
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = ((TextBox)e.Item.Cells[0].Controls[0]).Text;
            cmd.Parameters.Add("@Firstname", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[1].Controls[0]).Text;
            cmd.Parameters.Add("@LastName", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[2].Controls[0]).Text;
            cmd.Parameters.Add("@UserName", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[3].Controls[0]).Text;
            cmd.Parameters.Add("@IsAnonymous", SqlDbType.Char).Value = ((TextBox)e.Item.Cells[4].Controls[0]).Text;
            cmd.Parameters.Add("@LastActivityDate", SqlDbType.DateTime).Value = DateTime.Now.ToString();
            cmd.CommandText = "Update Users set Firstname=@Firstname,LastName=@LastName,UserName=@UserName,IsAnonymous=@IsAnonymous,LastActivityDate=@LastActivitydate where UserId=@UserId";
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            Grid.EditItemIndex = -1;
            BindData();
        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(ConfigurationManager.AppSettings["connect"]);
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("Insert into  Users (UserId, ApplicationId,Firstname,LastName,UserName,IsAnonymous,LastActivitydate) values('" + TextBox1.Text + "','','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
        protected void btnOk_Click(object sender, EventArgs e)
        {
            BindData1();
        }
        public void BindData1()
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["sqlConnect"]);
            cmd.CommandText = "Select * from Users";
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            Grid1.DataSource = ds;
            Grid1.DataBind();
            con.Close();
        }
    }
}