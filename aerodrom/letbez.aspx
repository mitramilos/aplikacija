<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="letbez.aspx.cs" Inherits="aerodrom.letbez" %>
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
                           <h4>Letovi sa presedanjem</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:aerodromDBConnectionString %>" SelectCommand="SELECT [id_let], [mesto_polaska], [mesto_dolaska], [datum_leta], [broj_presedanja], [broj_mesta] FROM [let_tbl] WHERE ([broj_presedanja] > 0)">
    
                </asp:SqlDataSource>
                     <div class="col">
                         
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                           <Columns>
                              <asp:BoundField DataField="id_let" HeaderText="id_let" SortExpression="id_let" />
                              <asp:BoundField DataField="mesto_polaska" HeaderText="mesto_polaska" SortExpression="mesto_polaska" />
                              <asp:BoundField DataField="mesto_dolaska" HeaderText="mesto_dolaska" SortExpression="mesto_dolaska" />
                              <asp:BoundField DataField="datum_leta" HeaderText="datum_leta" SortExpression="datum_leta" />
                              <asp:BoundField DataField="broj_presedanja" HeaderText="broj_presedanja" SortExpression="broj_presedanja" />
                              <asp:BoundField DataField="broj_mesta" HeaderText="broj_mesta" SortExpression="broj_mesta" />
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
