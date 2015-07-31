<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autocomplete.aspx.cs" Inherits="WebFormsWithAutocomplete.Autocomplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <script src="Scripts/jquery-ui-1.11.4.min.js"></script>
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/themes/overcast/jquery-ui.overcast.min.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server" ID="sMng" EnablePageMethods="true"></asp:ScriptManager>
        <table style="border:none;">
            <tr>
                <td><label>Product Code</label></td>
                <td><asp:TextBox ID="txtProduct" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><label>Product Name</label></td>
                <td><asp:TextBox ID="txtProductName" runat="server"></asp:TextBox></td>
            </tr>
        </table>

    </form>


    <script type="text/javascript">
        $(function () {
            $('#' + '<%= txtProduct.ClientID %>').autocomplete({
                source: function (request, response) {
                    var param = { prodCode: $('#' + '<%= txtProduct.ClientID %>').val() };
                    //debugger;
                    $.ajax({
                        url: '<%= ResolveUrl("~/Autocomplete.aspx/GetData") %>',
                        data: JSON.stringify(param),
                        datatype: "json",
                        type: "POST",
                        contentType: "application/json",
                        dataFilter: function (data) { return data },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    label: "コード:" + item.Code + " 名称:" + item.Name,
                                    value: item.Code,
                                    extend: item
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(textStatus);
                        }
                    })
                },
                minLength: 2,
                select: function (event, ui) {
                    //debugger;
                    var name = ui.item.extend.Name;
                    $('#' + '<%= txtProductName.ClientID %>').val(name);
                    var code = ui.item.extend.Code;
                    PageMethods.CodeBehindMethod(code, function (result) {
                        alert(result);
                    });
                }
            });
        });

        function test() {
            debugger;
            $('#' + '<%= txtProduct.ClientID %>').focusout(function () {
                var code = $('#' + '<%= txtProduct.ClientID %>').val();
                PageMethods.GetProductName(code, function (result) {
                    alert(result);
                });                
            });            
        }
    </script>
</body>
</html>
