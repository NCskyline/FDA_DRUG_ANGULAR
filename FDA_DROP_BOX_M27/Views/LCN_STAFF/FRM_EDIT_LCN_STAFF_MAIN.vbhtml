
@Code
    Layout = ""
End Code
<br />
<h4>คำขอแก้ไขใบอนุญาตสถานที่ด้านยา</h4><br />
<table width="100%" style="font-family:'Taviraj';">
    <tr>
        <td><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
    </tr>
</table>
<div class="row">
    <div class="col-sm-12" style="width:100%;">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                <thead style="font-weight:300;">
                    <tr>
                        <td>เลขรับ</td>
                        <td>เลขที่ใบอนุญาต</td>
                        <td>สถานะ</td>
                        <td>เลขดำเนินการ</td>
                        <td></td>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td>ขตวจ3 กท 99999/2563</td>
                        <td>ชำระเงินค่ายื่นคำขอแล้ว รอเจ้าหน้าที่พิจารณา</td>
                        <td>640009999</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="SELECT_STAFF_LCN(data)">
                                ดูข้อมูล
                            </a>
                        </td>
                    </tr>
                    <tr ng-repeat="data in DATA_LCN_EDIT_STAFF | filter: filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                        <td>{{data.RCVNO_MANUAL}}</td>
                        <td>{{data.LCNNO_MANUAL}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>{{data.TRANSACTION_UPLOAD}}</td>

                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="SELECT_STAFF_EDIT_LCN(data)">
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
