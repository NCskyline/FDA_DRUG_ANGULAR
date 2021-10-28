@Code
    Layout = ""
End Code
<br />
<h4>คำขออนุญาตยาตัวอย่าง</h4><br />
<div class="row">
    <div class="col-sm-12" style="width:100%;">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                <thead style="font-weight:300;">
                    <tr>
                        <td>วันเวลาที่ส่งคำขอ</td>
                        <td>ประเภท</td>
                        <td>รหัสบัญชีรายการยา</td>
                        <td>ชื่อยา (Th/Eng)</td>
                        <td>เลขดำเนินการ</td>
                        <td>สถานะ</td>
                        <td></td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in DATA_DS_STAFF">
                        <td>{{data.UPLOAD_DATE}}</td>
                        <td>{{data.lcntpcd}}</td>
                        <td>{{data.RCVNO_DISPLAY}}</td>
                        <td>{{data.drug_name}}</td>
                        <td>{{data.ID}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>{{data.REMARK}}</td>
                        <td>{{data.STAFF_NAME}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
                                ดูข้อมูล
                            </a>
                        </td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
                                เพิ่มข้อมูลส่วนที่ 2
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
