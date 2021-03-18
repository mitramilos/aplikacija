<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="napravilet.aspx.cs" Inherits="aerodrom.napravilet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img src="images/agent.png" / width="150">
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Unos leta</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>Mesto polaska</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Mesto polaska"></asp:TextBox>
                        </div>
                     </div>
                       <div class="col-md-4">
                        <label>Mesto dolaska</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Mesto dolaska"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Datum leta</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Datum" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                      <div class="col-md-4">
                        <label>ID Leta</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="ID leta" TextMode="Number"></asp:TextBox>
                        </div>
                          </div>
                     <div class="col-md-4">
                        <label>Broj presedanja</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Broj presedanja" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Broj mesta</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Broj mesta" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                 <br />
                   <center>
                  <div class="row">
                     <div class="col">
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Unesi let" OnClick="Button1_Click"  />
                        </div>
                     </div>
                  </div>
               </div>
                </center>
            </div>
            <a href="pocetna.aspx"><< Pocetna</a><br><br>
         </div>
      </div>
   </div>


</asp:Content>
