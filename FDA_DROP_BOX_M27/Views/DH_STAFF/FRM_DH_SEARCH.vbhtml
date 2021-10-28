@Code
    Layout = ""
End Code


<div>
    <p style="text-align: center;">ค้นหาเภสัชเคมีภัณฑ์</p>
</div>
<br />
<table style="width:100%">
    <tr>
        <td style="width:12%">สถานะ</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
        <td style="width:12%">เลขดำเนินการ</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
        <td><button style="width:16%">ค้นหา</button></td>
    <tr>
        <td style="width:12%">เลข DRM</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
        <td style="width:12%">ชื่อสาร</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
    </tr>
</table>
<br />
<div align="center">
    <table class="dataTable" style="width:100%">
        <thead>
            <tr>
                <th style="width:5%">เลข DRM</th>
                <th style="width:20%">ชื่อสาร</th>
                <th style="width:10%">เลขที่คำขอ</th>
                <th style="width:10%">วันที่ยื่นคำขอ</th>
                <th style="width:5%">สถานะ</th>
                <th style="width:20%">รหัสการดำเนินการ</th>
                <th style="width:5%"></th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="data in LIST_DRM">
                <td>{{data.phm15dgt}}</td>
                <td>{{data.CAS_NAME}}</td>
                <td>{{data.rcvno}}</td>
                <td>{{data.rcvdate}}</td>
                <td>{{data.STATUS_NAME}}</td>
                <td>{{data.TR_ID}}</td>
                <td>ดูข้อมูล</td>
            </tr>
        </tbody>
        <tfoot>
            <tr></tr>
        </tfoot>
    </table>
</div>
