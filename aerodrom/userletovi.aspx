<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userletovi.aspx.cs" Inherits="aerodrom.userletovi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
     <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Vase rezervacije</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:aerodromDBConnectionString %>" SelectCommand="SELECT * FROM [karta_tbl] WHERE ([id_korisnik] = @id_korisnik)">
                         <SelectParameters>
                             <asp:SessionParameter Name="id_korisnik" SessionField="id" Type="String" />
                         </SelectParameters>
                        
                      </asp:SqlDataSource>
                         
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="id_karte">
                        <Columns>
                            <asp:BoundField DataField="id_karte" HeaderText="id_karte" SortExpression="id_karte" ReadOnly="True" />
                              <asp:BoundField DataField="id_leta" HeaderText="id_leta" SortExpression="id_leta" />
                              <asp:BoundField DataField="id_korisnik" HeaderText="id_korisnik" SortExpression="id_korisnik" />
                              <asp:BoundField DataField="rezervisano" HeaderText="rezervisano" SortExpression="rezervisano" />
                        </Columns>
                            </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
        </center>

   


</asp:Content>
