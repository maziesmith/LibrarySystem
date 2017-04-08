using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace library_system
{
    public partial class departments : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=KHALEDHATAB\\SQLEXPRESS;Initial Catalog=librarysystem;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                conn.Open();
                string str1 = "select depttitle from departments";
                SqlCommand cmd1 = new SqlCommand(str1, conn);
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                if (rdr1.HasRows)
                {
                    while (rdr1.Read())
                    {
                        DropDownList1.Items.Add(rdr1.GetString(0));
                    }
                    
                }
                rdr1.Close();
                conn.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = " select * from departments where depttitle='" + DropDownList1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.HasRows)
            {
                while (rdr1.Read())
                { 
                    TextBox2.Text = rdr1.GetInt32(0).ToString();
                    TextBox1.Text = rdr1.GetString(1);
                  
                }

            }
            rdr1.Close();
            conn.Close();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "insert into departments (depttitle) values ('"+TextBox1.Text+"') ";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label3.Text = "Department Has been Saved ....";
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "update departments set depttitle='" + TextBox1.Text + "' where deptid='" + TextBox2.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label3.Text = "Department Has been Updated ....";
            conn.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "delete from departments where deptid='" + TextBox2.Text + "'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label3.Text = "Department Has been Deleted ....";
            conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            TextBox2.Text = "";
            TextBox1.Text = "";
            Label3.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "delete from departments";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label3.Text = "Departments Has been Deleted ...";
            conn.Close();

        }
    }
}