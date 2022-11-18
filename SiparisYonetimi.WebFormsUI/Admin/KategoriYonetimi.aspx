<%@ Page Title="Kategori Yönetimi" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriYonetimi.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Admin.KategoriYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>
        Kategori Yönetimi
    </h1>

    <div>
        <asp:GridView ID="dgvKategoriler" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvKategoriler_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>

    <asp:Literal ID="ltMesaj" runat="server"></asp:Literal>

    <table class="table table-striped table-hover">
        <tr>
            <td>
                Kategori Adı
            </td>
            <td>
                <asp:TextBox ID="txtKategoriAdi" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Açıklama
            </td>
            <td>
                <asp:TextBox ID="txtAciklama" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:CheckBox ID="chbDurum" runat="server" Text="Durum" />

            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="btnEkle_Click"/>
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle"  CssClass="btn btn-success" OnClick="btnGuncelle_Click" Enabled="false"/>
                <asp:Button ID="btnSil" runat="server" Text="Sil"  CssClass="btn btn-danger" OnClick="btnSil_Click" Enabled="false"/>
            </td>           
        </tr>
    </table>

</asp:Content>
