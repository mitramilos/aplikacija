<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="obrisilet.aspx.cs" Inherits="aerodrom.obrisilet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
       <div class="row">
                     <div class="col">
                        <center>
                           <h4>Let</h4>
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
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="" ReadOnly="true"></asp:TextBox>
                        </div>
                     </div>
                       <div class="col-md-4">
                        <label>Mesto dolaska</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="" ReadOnly="true"></asp:TextBox>
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
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder=""  TextMode="Number"></asp:TextBox>
                        </div>
                          </div>
                     <div class="col-md-4">
                        <label>Broj presedanja</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="" ReadOnly="true" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Broj mesta</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="" ReadOnly="true" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                 <br />
                  
                  <br />
                   <center>
                  <div class="row">
                     <div class="col">
                        <div class="form-group">
                            <center>
                           <asp:Button class="btn btn-info btn-block btn-lg" ID="Button1" runat="server" Text="Ucitaj let" OnClick="Button1_Click"   />
                                 </center>                        
                                </div>
                         <br />
                         <div class="col">
                         <div class="form-group">
                             <center>
                           <asp:Button class="btn btn-danger btn-block btn-lg" ID="Button2" runat="server" Text="Obrisi let" OnClick="Button2_Click"   />
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
