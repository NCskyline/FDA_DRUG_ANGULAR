@Code
    ViewData("Title") = "FRM_EXTEND_TIME_LOCATION_MAIN_USER"
End Code

<h2>{{LIST_EXTEND.TYPE_EXTEND}}</h2>
<div>
    <table width="100%">
        <tr>
            <td></td>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btn_refresh" runat="server" Text="รีเฟรชหน้าจอ" CssClass="btn-lg" />
                        </td>
                        <td>
                            <asp:Button ID="btn_extend" runat="server" Text="ยื่นคำขอต่ออายุใบอนุญาต (ระบบใหม่)" CssClass="btn-lg" />
                        </td>
                    </tr>
                </table>


            </td>
        </tr>
    </table>
</div>
