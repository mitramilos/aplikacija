<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="svikorisnici.aspx.cs" Inherits="aerodrom.svikorisnici" %>
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
                           <img src="images/user1.png"  width="100" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Karte</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  
                   
                  <div class="row">

                       <div class="col-md-6">
                        <label>ID karte</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="ID karte" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>

                     <div class="col-md-6">
                        <label>ID leta</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="" TextMode="Number" ReadOnly="true"  ></asp:TextBox>
                        </div>
                     </div>
                      </div>
  
                  <div class="row">
                    <div class="col-md-6">
                        <label>ID Korisnika</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="" TextMode="Number" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>

                     <div class="col-md-6">
                        <label>Rezervisano</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Na cekanju" ReadOnly="true" ></asp:TextBox>
                        </div>
                     </div>
                      </div>
                  
                  <br />
                   <center>
                  <div class="row">
                     <div class="col">
                        <div class="form-group">
                            <center>
                           <asp:Button class="btn btn-info btn-block btn-lg" ID="Button1" runat="server" Text="Ucitaj kartu" OnClick="Button1_Click"   />
                                 </center>                        
                                </div>
                         <br />
                         <div class="col">
                         <div class="form-group">
                             <center>
                           <asp:Button class="btn btn-danger btn-block btn-lg" ID="Button2" runat="server" Text="Izmeni status" OnClick="Button2_Click"   />
                                </center>
                                 </div>
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
