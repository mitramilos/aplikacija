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
    public partial class svikorisnici : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("select * from karta_tbl where id_karte='" + TextBox3.Text.ToString().Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TextBox1.Text = dr.GetValue(1).ToString();
                        TextBox2.Text = dr.GetValue(2).ToString();
                        TextBox4.Text = dr.GetValue(3).ToString();


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

            


           
                SqlConnection con1 = new SqlConnection(constring);
                if (con1.State == ConnectionState.Closed)
                {
                    con1.Open();
                    
                }
                 string  p = "update karta_tbl set rezervisano='odobreno' where id_karte ='" + TextBox3.Text.Trim() + "'";
                SqlCommand com1 = new SqlCommand(p, con1);
                com1.ExecuteNonQuery();



           
                
                TextBox4.BorderColor = System.Drawing.Color.Red;
                TextBox4.Text = "ODOBRENA REZERVACIJA";

                 Response.Write("<script>alert('Potvrda je uspela');</script>");

               Response.Redirect("svikorisnici.aspx");
            Response.Write("<script>alert('Potvrda je uspela');</script>");
            con1.Close();



            
            


        }
               
            
    }
    }
    
    
    
    
