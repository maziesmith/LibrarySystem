using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace library_system
{
    public partial class publishers : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=KHALEDHATAB\\SQLEXPRESS;Initial Catalog=librarysystem;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                conn.Open();
                string str1 = "select pubtitle from publishers";
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
            string str1 = "select * from publishers where pubtitle='" + DropDownList1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.HasRows)
            {
                while (rdr1.Read())
                {
                    TextBox5.Text = rdr1.GetInt32(0).ToString();
                    TextBox1.Text = rdr1.GetString(1);
                    TextBox2.Text = rdr1.GetString(2); 
                    TextBox3.Text = rdr1.GetString(3);
                    TextBox4.Text = rdr1.GetString(4);
                }
                
            }
            rdr1.Close();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "insert into publishers (pubtitle,address,mobile,website) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            SqlCommand cmd1 = new SqlCommand(str1,conn);
            cmd1.ExecuteNonQuery();
            Label7.Text = "Publisher Has been Saved ...";
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "update publishers set pubtitle='" + TextBox1.Text + "',address='" + TextBox2.Text + "',mobile='" + TextBox3.Text + "',website='" + TextBox4.Text + "' where pubid='"+TextBox5.Text+"'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label7.Text = "Publisher Has been Updated ...";
            conn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "delete from publishers where pubid='" + TextBox5.Text + "'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label7.Text = "Publisher Has been Deleted ...";
            conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
           
            Label7.Text = "";
            TextBox5.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = "delete from publishers";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label7.Text = "Publishers Has been Deleted ...";
            conn.Close();
        }
    }
}