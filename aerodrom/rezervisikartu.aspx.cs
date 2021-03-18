using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aerodrom
{
    public partial class rezervisikartu : System.Web.UI.Page
    {

        public string constring = "Data Source=MILOSMITROVIC\\SQLEXPRESS;Initial Catalog=aerodromDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string broj="";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string qq = "select broj_mesta from let_tbl where id_let ='" + TextBox1.Text.Trim() + "'";

                SqlCommand com1 = new SqlCommand(qq, con);
                com1.ExecuteNonQuery();
                SqlDataReader dr = com1.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        broj = dr.GetValue(0).ToString();
                    }
                    dr.Close();
                        int br = int.Parse(broj);
                    
                        if (br > 0)
                        {
                            int br1 = br - 1;
                            string qqq = "update let_tbl set broj_mesta=" + br1.ToString() + " where id_let ='" + TextBox1.Text.Trim() + "'";
                            SqlCommand com2 = new SqlCommand(qqq, con);
                            com2.ExecuteNonQuery();

                            string q = "insert into karta_tbl(id_karte,id_leta,id_korisnik,rezervisano)values('" + TextBox3.Text.ToString() + "','" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "','" + "na cekanju" + "')";
                            SqlCommand com = new SqlCommand(q, con);
                            com.ExecuteNonQuery();

                            Response.Write("<script>alert('Uspesno unet novi let');</script>");
                            Response.Redirect("pocetna.aspx");

                        }
                        else {

                            Response.Write("<script>alert('Nema dovoljno mesta na datom letu!');</script>");
                            Response.Redirect("rezervisikartu.aspx");

                        }
                    
                }
                else
                {

                    Response.Write("<script>alert('Ne postoji let sa datim id-jem');</script>");
                    Response.Redirect("rezervisikartu.aspx");
                }
            }
         }


        }
    }
