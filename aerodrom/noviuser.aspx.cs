using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aerodrom
{
    public partial class noviuser : System.Web.UI.Page
    {

        public string constring = "Data Source=MILOSMITROVIC\\SQLEXPRESS;Initial Catalog=aerodromDB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into korisnik_tbl(id_korisnik,ime_korisnika,username,password)values('" + TextBox3.Text.ToString() + "','" + TextBox1.Text.ToString() + "','" + TextBox10.Text.ToString() + "','" + TextBox4.Text.ToString() + "')";          
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                Response.Write("<script>alert('Uspesno unet korisnik');</script>");
                Response.Redirect("pocetna.aspx");
            }
        }
    }
}