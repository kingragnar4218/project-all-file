﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Reflection.Emit;

namespace stock_market_learning
{
    public partial class ipo_update : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=PC-221\\SQLEXPRESS;Initial Catalog=stock_learning_db;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from ipo";
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "" && b10.Text != "")
            {
                string sql = "insert into ipo values('"+b1.Text+ "' , '"+b2.Text+ "' , '"+b3.Text+ "' , '"+b4.Text+ "' , '"+b5.Text+ "' , '"+b6.Text+ "' , '"+b7.Text+ "' , '"+b8.Text+ "' , '"+b9.Text+ "', '"+b10.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Response.Write("<script LANGUAGE='JavaScript' >alert('News Add')</script>");
                hhh();
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('No Empty Value Allowed ')</script>");
            }
        }
        public void hhh()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            b10.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            hhh();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "" && b10.Text != "")
            {
                 string sql = "UPDATE  ipo SET [Company Name] ='" + b1.Text + "' , [Open Date]='" + b2.Text + "' , [Close Date]='" + b3.Text + "' , [Listing Date]='" + b4.Text + "' ,  [Lot size]='" + b5.Text + "' , [Allotmen]='" + b6.Text + "' , [Listing At]='" + b7.Text + "' , [Total Issue Size]='" + b8.Text + "' , [Credit of Shares to Demat]='" + b9.Text + "' , [Initiation of     Refunds]='" + b10.Text + "' WHERE [Id]='" + b11.Text + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Response.Write("<script LANGUAGE='JavaScript' >alert('News Updated ')</script>");
                    hhh();
            }
            else
            {
                 Response.Write("<script LANGUAGE='JavaScript' >alert('No Empty Value Allowed ')</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            string sql = "Delete From ipo Where [id]='" + b11.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Response.Write("<script LANGUAGE='JavaScript' >alert('News Deleted  ')</script>");
                hhh();
            }
    }
}


//if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "" && b10.Text != "")
//{
//    string sql = "UPDATE  ipo SET [Company Name] ='" + b1.Text + "' , [Open Date]='" + b2.Text + "' , [Close Date]='" + b3.Text + "' , [Listing Date]='" + b4.Text + "' ,  [Lot size]='" + b5.Text + "' , [Allotmen]='" + b6.Text + "' , [Listing At]='" + b7.Text + "' , [Total Issue Size]='" + b8.Text + "' , [Credit of Shares to Demat]='" + b9.Text + "' , [Initiation of Refunds]='" + b10.Text + "' WHERE [Id]='" + b11.Text + "' ";
//    SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
//    DataTable dt = new DataTable();
//    sda.Fill(dt);
//    Response.Write("<script LANGUAGE='JavaScript' >alert('News Updated ')</script>");
//    hhh();
//}
//else
//{
//    Response.Write("<script LANGUAGE='JavaScript' >alert('No Empty Value Allowed ')</script>");
//}