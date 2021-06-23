
@Code
    Layout = ""
End Code


<div>
    <p style="text-align: center;">ค้นหาสาร</p>
</div>
<br />
<table style="width:100%">
    <tr>
        <td style="width:12%">ชื่อสารที่ต้องการค้นหา</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
        <td style="width:12%">เลข iowa (ยาว)</td>
        <td style="width:30%"><input type="text" style="width:30%"></td>
        <td><button style="width:16%">ค้นหา</button></td>
    </tr>
</table>
<br />
<div align="center">
    <table class="dataTable" style="width:100%">
        <thead>
            <tr>
                <th style="width:5%">IDA</th>
                <th style="width:10%">CAS NO.</th>
                <th style="width:15%">ชื่อสาร</th>
                <th style="width:5%">iowacd</th>
                <th style="width:5%">runno</th>
                <th style="width:3%">salt</th>
                <th style="width:3%">syn</th>
                <th style="width:3%">aori</th>
                <th style="width:10%">REGIS_STATUS</th>
                <th style="width:5%">INN</th>
                <th style="width:5%">INN_TH</th>
                <th style="width:15%">Version update</th>
                <th style="width:10%">สถานะ</th>
                <th style="width:5%"></th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="data in LIST_GMP.CER_DETAIL_CASCHEMICAL">
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>{{NULL}}</td>
                <td>ดูข้อมูล</td>
            </tr>
        </tbody>
        <tfoot>
            <tr></tr>
        </tfoot>
    </table>
</div>