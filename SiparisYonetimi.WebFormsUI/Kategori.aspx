<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Kategori.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Kategori" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        <asp:Literal ID="ltKategoriAdi" runat="server"></asp:Literal>
    </h1>

    <p>
        <asp:Literal ID="ltAciklama" runat="server"></asp:Literal>
    </p>
    <div class="row row row-cols-3">
        <asp:Repeater ID="rptUrunler" runat="server">
            <ItemTemplate>
                <div class="col">
                    <a href="/UrunDetay.aspx?id=<%#Eval("Id")%>">
                        <img class="img-fluid" src="/Img/<%#Eval("Image")%>" alt="<%#Eval("Name")%>" />
                        <h3><%#Eval("Name")%> <%#Eval("Price")%> ₺</h3>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
