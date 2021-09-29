@Code
    Layout = ""
End Code


<div>
    <p style="text-align: center;">เพิ่มชื่อสาร</p>
</div>
<br />
<div align="center">
    <table class="dataTable" style="width:100%">
        <thead>
            <tr>
                <th style="width:5%">ชื่อสาร</th>
                <th style="width:20%">ชนิด</th>
                <th style="width:10%">วันที่ยื่นคำขอ</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="data in LIST_CHEM_STAFF">
                <td>{{data.iowanm}}</td>
                <td>{{data.chem_type2}}</td>
                <td>{{data.REQUEST_DATE}}</td>
                <td>ดูข้อมูล</td>
            </tr>
        </tbody>
        <tfoot>
            <tr></tr>
        </tfoot>
    </table>
</div>
