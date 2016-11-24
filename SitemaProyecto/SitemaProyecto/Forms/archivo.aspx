<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="archivo.aspx.cs" Inherits="SitemaProyecto.Forms.archivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>Select a file to upload:</h4>

            <asp:FileUpload ID="FileUpload1"
                runat="server"></asp:FileUpload>

            <br />
            <br />

            <asp:Button ID="UploadButton"
                Text="Upload file"
                OnClick="UploadButton_Click"
                runat="server"></asp:Button>

            <hr />

            <asp:Label ID="UploadStatusLabel"
                runat="server">
            </asp:Label>
            <asp:Label ID="Label1"
                runat="server">
            </asp:Label>
        </div>
    </form>
</body>
</html>
