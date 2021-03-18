using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aerodrom
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["vrsta"].Equals(""))
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;
                    LinkButton6.Visible = true;

                    LinkButton5.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton4.Visible = false;
                    LinkButton3.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton7.Visible = false;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton13.Visible = false;
                    LinkButton14.Visible = false;
                    LinkButton15.Visible = false;

                }
                else if (Session["vrsta"].Equals("user"))
                {
                    LinkButton5.Visible = false;
                    LinkButton8.Visible = true;
                    LinkButton4.Visible = false;
                    LinkButton3.Visible = true;
                    LinkButton9.Visible = true;
                    LinkButton7.Visible = true;
                    LinkButton7.Text = Session["ime"].ToString().ToUpper();
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton6.Visible = false;
                    LinkButton3.Text = "Vase rezervacije";
                    LinkButton9.Text = "Log out";
                    LinkButton8.Text = "Rezervisi kartu";
                    LinkButton10.Visible = false;
                    LinkButton13.Visible = true;
                    LinkButton14.Visible = true;
                    LinkButton13.Text ="letovi bez presedanja" ;
                    LinkButton14.Text = "letovi sa presedanjem";
                    LinkButton15.Visible = false;

                }
                else if (Session["vrsta"].Equals("admin"))
                {
                    LinkButton5.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton4.Visible = true;
                    LinkButton3.Visible = false;
                    LinkButton9.Visible = true;
                    LinkButton7.Visible = true;
                    LinkButton7.Text = "ADMIN";
                    
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton11.Visible = true;
                    LinkButton12.Visible = true;
                    LinkButton6.Visible = false;
                    LinkButton4.Text = "Letovi";
                    LinkButton9.Text = "Log out";
                    LinkButton12.Text = "Unesi korisnika";
                    LinkButton10.Visible = false;
                    LinkButton11.Text = "Obrisi let";
                    LinkButton13.Visible = false;
                    LinkButton14.Visible = false;
                    LinkButton15.Visible = false;
                }
                else if (Session["vrsta"].Equals("agent"))
                {
                    LinkButton5.Visible = true;
                    LinkButton8.Visible = true;
                    LinkButton4.Visible = true;
                    LinkButton3.Visible = false;
                    LinkButton9.Visible = true;
                    LinkButton7.Visible = true;
                    LinkButton7.Text = "AGENT";
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton6.Visible = false;
                    LinkButton4.Text = "Letovi";
                    LinkButton9.Text = "Log out";
                    LinkButton5.Text = "Novi let";
                    LinkButton10.Visible = true;
                    LinkButton10.Text = "Potvrdi kartu";
                    LinkButton13.Visible = false;
                    LinkButton14.Visible = false;
                    LinkButton15.Visible = true;
                    LinkButton15.Text = "Sve karte";
                }
            }
            catch(Exception ex)
            {

            }
        }


        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("agentlogin.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("napravilet.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("rezervisikartu.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("noviuser.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Session["username"] ="";
            Session["ime"] = "";
            Session["vrsta"] = "";
            LinkButton7.Text = "";
            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
            LinkButton6.Visible = true;

            LinkButton5.Visible = false;
            LinkButton8.Visible = false;
            LinkButton4.Visible = false;
            LinkButton3.Visible = false;
            LinkButton9.Visible = false;
            LinkButton7.Visible = false;
            LinkButton11.Visible = false;
            LinkButton12.Visible = false;
            Response.Redirect("pocetna.aspx");

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("sviletovi.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("obrisilet.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("svikorisnici.aspx");
        }

        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            Response.Redirect("letsa.aspx");
        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            Response.Redirect("letbez.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("userletovi.aspx");
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("svekarte.aspx");
        }
    }
}