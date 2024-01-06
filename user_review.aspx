<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_review.aspx.cs" Inherits="stock_market_learning.user_review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Reviw </title>
    <%--<script src="https://cdn.tailwindcss.com"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1 Align="Center"> User Reviw  </h1>
<p class="text-lg font-normal text-gray-500 lg:text-xl dark:text-gray-400"></p>
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center"></asp:GridView>

        </div>
    </form>
</body>
</html>
