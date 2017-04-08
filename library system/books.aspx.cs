using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace library_system
{
    public partial class WebForm1 : System.Web.UI.Page
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
                        DropDownList3.Items.Add(rdr1.GetString(0));
                    }
                }
                rdr1.Close();
                conn.Close();





                conn.Open();
                string str2 = "select pubtitle from Publishers";
                SqlCommand cmd2 = new SqlCommand(str2, conn);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                if (rdr2.HasRows)
                {
                    while (rdr2.Read())
                    {
                        DropDownList4.Items.Add(rdr2.GetString(0));

                    }
                }
                rdr2.Close();

                conn.Close();
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            



                int deptid = 0;
                conn.Open();

                string str2 = "select deptid from departments where depttitle='" + DropDownList1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, conn);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                if (rdr2.HasRows)
                {
                    while (rdr2.Read())
                    {
                        deptid = rdr2.GetInt32(0);
                    }

                }
                rdr2.Close();




                string str1 = "select booktitle from books where deptid='" + deptid + "' ";
                SqlCommand cmd1 = new SqlCommand(str1, conn);
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                if (rdr1.HasRows)
                {
                    while (rdr1.Read())
                    {
                        DropDownList2.Items.Add(rdr1.GetString(0));
                    }

                }
                rdr1.Close();
                conn.Close();
            
            }
        

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            TextBox4.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int deptid = 0;
            int pubid = 0;
            conn.Open();

            string str2 = "select deptid from departments where depttitle='" + DropDownList3.Text + "'";
            SqlCommand cmd2 = new SqlCommand(str2, conn);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            if (rdr2.HasRows)
            {
                while (rdr2.Read())
                {
                    deptid = rdr2.GetInt32(0);
                }
                
            }
            rdr2.Close();

            string str3 = "select pubid from publishers where pubtitle='" + DropDownList4.Text + "'";
            SqlCommand cmd3 = new SqlCommand(str3, conn);
            SqlDataReader rdr3 = cmd3.ExecuteReader();
            if (rdr3.HasRows)
            {
                while (rdr3.Read())
                {
                    pubid = rdr3.GetInt32(0);
                }

            }
            rdr3.Close();





            
            string str1 = "insert into books (booktitle,number,date,deptid,pubid) values ('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox4.Text+"','"+deptid+"','"+pubid+"') ";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label9.Text = "Book Has been Saved ....";
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int deptid = 0;
            int pubid = 0;
            conn.Open();

            string str2 = "select deptid from departments where depttitle='" + DropDownList3.Text + "'";
            SqlCommand cmd2 = new SqlCommand(str2, conn);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            if (rdr2.HasRows)
            {
                while (rdr2.Read())
                {
                    deptid = rdr2.GetInt32(0);
                }

            }
            rdr2.Close();

            string str3 = "select pubid from publishers where pubtitle='" + DropDownList4.Text + "'";
            SqlCommand cmd3 = new SqlCommand(str3, conn);
            SqlDataReader rdr3 = cmd3.ExecuteReader();
            if (rdr3.HasRows)
            {
                while (rdr3.Read())
                {
                    pubid = rdr3.GetInt32(0);
                }

            }
            rdr3.Close();


            
            string str1 = "update books set booktitle='" + TextBox1.Text + "',number='" + TextBox2.Text + "',date='" + TextBox4.Text + "',deptid='" + deptid + "',pubid='" + pubid + "' where bookid='"+TextBox5.Text+"'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label9.Text = "Book Has been Updated ....";
            conn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            int deptid = 0;
            int pubid = 0;
            conn.Open();

            string str2 = "select deptid from departments where depttitle='" + DropDownList3.Text + "'";
            SqlCommand cmd2 = new SqlCommand(str2, conn);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            if (rdr2.HasRows)
            {
                while (rdr2.Read())
                {
                    deptid = rdr2.GetInt32(0);
                }

            }
            rdr2.Close();

            string str3 = "select pubid from publishers where pubtitle='" + DropDownList4.Text + "'";
            SqlCommand cmd3 = new SqlCommand(str3, conn);
            SqlDataReader rdr3 = cmd3.ExecuteReader();
            if (rdr3.HasRows)
            {
                while (rdr3.Read())
                {
                    pubid = rdr3.GetInt32(0);
                }

            }
            rdr3.Close();

            
            string str1 = "delete from books where bookid='"+TextBox5.Text+"'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label9.Text = "Book Has been Deleted ....";
            conn.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            
            int deptid = 0;
            int pubid = 0;
            conn.Open();

            string str2 = "select deptid from departments where depttitle='" + DropDownList3.Text + "'";
            SqlCommand cmd2 = new SqlCommand(str2, conn);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            if (rdr2.HasRows)
            {
                while (rdr2.Read())
                {
                    deptid = rdr2.GetInt32(0);
                }

            }
            rdr2.Close();

            string str3 = "select pubid from publishers where pubtitle='" + DropDownList4.Text + "'";
            SqlCommand cmd3 = new SqlCommand(str3, conn);
            SqlDataReader rdr3 = cmd3.ExecuteReader();
            if (rdr3.HasRows)
            {
                while (rdr3.Read())
                {
                    pubid = rdr3.GetInt32(0);
                }

            }
            rdr3.Close();


            
            string str1 = "delete  from books ";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.ExecuteNonQuery();
            Label9.Text = "Books Has been Deleted ....";
            conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = ""; 
            TextBox4.Text = ""; 
            TextBox5.Text = ""; 
            Label9.Text = "";
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a=0;
            int z=0;

            string x = "";
            string y = "";

            conn.Open();

            string str4= "select deptid from books where booktitle='" + DropDownList2.Text + "'";
            SqlCommand cmd4 = new SqlCommand(str4, conn);
            SqlDataReader rdr4 = cmd4.ExecuteReader();
            if (rdr4.HasRows)
            {
                while (rdr4.Read())
                {

                    a = rdr4.GetInt32(0);
                }
                rdr4.Close();
            }




            string str2 = "select depttitle from departments where deptid='" + a + "'";
            SqlCommand cmd2 = new SqlCommand(str2, conn);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            if (rdr2.HasRows)
            {
                while (rdr2.Read())
                {
                    x = rdr2.GetString(0);
                }

            }
            rdr2.Close();


            string str5 = "select pubid from books where booktitle='" + DropDownList2.Text + "'";
            SqlCommand cmd5 = new SqlCommand(str5, conn);
            SqlDataReader rdr5 = cmd5.ExecuteReader();
            if (rdr5.HasRows)
            {
                while (rdr5.Read())
                {

                    z = rdr5.GetInt32(0);
                }
                rdr5.Close();
            }

            string str3 = "select pubtitle from publishers where pubid='" + z + "'";
            SqlCommand cmd3 = new SqlCommand(str3, conn);
            SqlDataReader rdr3 = cmd3.ExecuteReader();
            if (rdr3.HasRows)
            {
                while (rdr3.Read())
                {
                    y = rdr3.GetString(0);
                }

            }
            rdr3.Close();










            string str1 = "select * from books where booktitle='" + DropDownList2.Text + "'";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.HasRows)
            {
                while (rdr1.Read())
                {
                    
                    TextBox5.Text = rdr1.GetInt32(0).ToString();
                    TextBox1.Text = rdr1.GetString(1);
                    TextBox2.Text = rdr1.GetInt32(2).ToString();
                    TextBox4.Text = rdr1.GetString(3);
                    DropDownList3.SelectedValue = x ;
                    DropDownList4.SelectedValue = y ;
                }

            }
            rdr1.Close();

            conn.Close();
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}