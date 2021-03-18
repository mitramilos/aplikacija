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
    public partial class userlogin : System.Web.UI.Page
    {

        public string constring = "Data Source=MILOSMITROVIC\\SQLEXPRESS;Initial Catalog=aerodromDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from korisnik_tbl where username='" + TextBox1.Text.Trim() + "' AND password='" + TextBox2.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                       Session["id"]= dr.GetValue(0).ToString();
                        Session["username"] = dr.GetValue(1).ToString();
                        Session["ime"] = dr.GetValue(2).ToString();
                        Session["vrsta"] = "user";
                    }
                    Response.Redirect("pocetna.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Prijavljivanje nije uspelo');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}