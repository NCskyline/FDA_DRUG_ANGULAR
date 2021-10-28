
@Code
    Layout = ""
End Code


<div>
    <p style="text-align: center;">ค้นหา Cer</p>
</div>
<br />
<table style="width:100%">
    <tr>
        <td style="width:8%">เลขที่ CER</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
        <td style="width:12%">ชื่อผู้ผลิตต่างประเทศ</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
        <td><button style="width:20%">ค้นหา</button></td>
    <tr>
        <td style="width:8%">เลขดำเนินการ</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
    </tr>
</table>
<br />
<div align="center">
    <table class="dataTable" style="width:100%">
        <thead>
            <tr>
                <th style="width:12%">เลขดำเนินการ</th>
                <th style="width:15%">ประเทศ</th>
                <th style="width:15%">เลขที่ CER</th>
                <th style="width:12%">วันที่ยื่นคำขอ</th>
                <th style="width:8%">สถานะ</th>
                <th style="width:18%">ชื่อผู้ผลิตต่างประเทศ</th>
                <th style="width:13%">ประเภท CER	</th>
                <th style="width:5%"></th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="data in LIST_CERT">
                <td>{{data.TR_ID}}</td>
                <td>{{data.thacntnm}}</td>
                <td>{{data.CER_FORMAT}}</td>
                <td>{{data.REQUEST_DATE}}</td>
                <td>{{data.STATUS_NAME}}</td>
                <td>{{data.FOREIGN_LOCATION_NAME}}</td>
                <td>{{data.cer_type}}</td>
                <td>ดูข้อมูล</td>
            </tr>
        </tbody>
        <tfoot>
            <tr></tr>
        </tfoot>
    </table>
</div>