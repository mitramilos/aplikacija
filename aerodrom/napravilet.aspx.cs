using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aerodrom
{
    public partial class napravilet : System.Web.UI.Page
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
                string q = "insert into let_tbl(mesto_polaska,mesto_dolaska,datum_leta,id_let,broj_presedanja,broj_mesta)values('" + TextBox1.Text.ToString() + "','" + TextBox10.Text.ToString() + "','" + TextBox2.Text + "','" + TextBox5.Text.ToString() + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                Response.Write("<script>alert('Uspesno unet novi let');</script>");
                Response.Redirect("pocetna.aspx");
            }
        }
    }
}