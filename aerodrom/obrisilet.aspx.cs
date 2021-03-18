using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aerodrom
{
    public partial class obrisilet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string constring = "Data Source=MILOSMITROVIC\\SQLEXPRESS;Initial Catalog=aerodromDB;Integrated Security=True";

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from let_tbl where datum_leta = '" + TextBox2.Text.Trim() + "' AND id_let = '" + TextBox5.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TextBox1.Text = dr.GetValue(2).ToString();
                        TextBox10.Text = dr.GetValue(3).ToString();
                      
                       // TextBox5.Text = dr.GetValue(0).ToString();
                        TextBox3.Text = dr.GetValue(5).ToString();
                        TextBox4.Text = dr.GetValue(6).ToString();

                        int broj = int.Parse(TextBox4.Text);
                        if (broj <= 5)
                        {
                            TextBox4.BackColor = System.Drawing.Color.DarkRed;
                        }

                    }

                }
                else
                {
                    Response.Write("<script>alert('Prikazivanje nije uspelo');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }


                SqlCommand cmd = new SqlCommand("DELETE  from let_tbl where datum_leta = '" + TextBox2.Text.Trim() + "' AND id_let = '" + TextBox5.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                con.Close();
                
                Response.Write("<script>alert('Brisanje je uspelo');</script>");
                
                




            }
            catch (Exception ex)
            {

            }
        }
    }
}