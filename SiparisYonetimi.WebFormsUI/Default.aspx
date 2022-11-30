<%@ Page Title="Anasayfa" Language="C#" MasterPageFile="~/OnYuz.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiparisYonetimi.WebFormsUI.Default" %>

<%@ Register Src="~/Moduller/Slider.ascx" TagPrefix="uc1" TagName="Slider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:Slider runat="server" ID="Slider" />

    <div class="container marketing">

        <h2>Markalar</h2>
        <!-- Three columns of text below the carousel -->
        <div class="row">
            <asp:Repeater ID="rptMarkalar" runat="server">
                <ItemTemplate>
                    <div class="col-lg-2">
                        <a href="/Marka.aspx?id=<%#Eval("Id") %>">
                            <img src="/Img/<%#Eval("Logo") %>" alt="<%#Eval("Name") %>" class="img-fluid" />
                        </a>

                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <!-- /.row -->

        <!-- START THE FEATURETTES -->



    </div>
</asp:Content>
