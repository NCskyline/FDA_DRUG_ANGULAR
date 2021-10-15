@Code
    Layout = ""
End Code

<div>
    <div style="font-family:'Taviraj';width:100%">
        <div>
            <p style="text-align: center;">เภสัชเคมีภัณฑ์</p>
        </div>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:5%">สถานะ</td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;">
                        <option value="0">--กรุณาเลือก--</option>
                    </select>
                </td>
            <tr>
                <td style="width:5%">ชื่อการค้า	</td>
                <td style="width:10%"><input type="text"></td>
            <tr>
                <td style="width:5%">เลขที่รับคำขอ	</td>
                <td style="width:10%"><input type="text"></td>
                <td style="width:10%"><button>ค้นหา</button></td>
            </tr>
        </table>
        <br />
        <div align="center">
            <table class="dataTable" style="width:100%">
                <thead>
                    <tr>
                        <th style="width:15%">เลขที่รับคำขอ</th>
                        <th style="width:15%">วันที่รับ</th>
                        <th style="width:15%">วันที่ยื่นคำขอ</th>
                        <th style="width:15%">สถานะ</th>
                        <th style="width:20%">ชื่อการค้า</th>
                        <th style="width:15%">รหัสดำเนินการ</th>
                        <th style="width:5%"></th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in LIST_DH_STAFF">
                        <td>{{data.rcvno}}</td>
                        <td>{{data.rcvdate}}</td>
                        <td>{{data.REQUEST_DATE}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>{{data.TRADING_NAME}}</td>
                        <td>{{data.TR_ID}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="SELECT_DH(data)">
                                ดูข้อมูล
                            </a>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr></tr>
                </tfoot>
            </table>
        </div>
    </div>
</div>

