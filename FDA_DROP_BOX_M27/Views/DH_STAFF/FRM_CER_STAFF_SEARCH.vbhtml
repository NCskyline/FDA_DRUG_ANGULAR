
@Code
    Layout = ""
End Code


<div>
    <p style="font-family:'Taviraj';font-size:24px">ค้นหาการลงทะเบียนสถานที่ผลิต</p>
</div>
<br />
<table style="width:100%">
    <tr>
        <td style="width:12%">เลขอ้างอิงสถานที่ผลิต <br />(ThFDA-DRef)</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="CER_FORMAT"></td>
        <td width="2%"></td>
        <td style="width:15%">ชื่อผู้ผลิตเภสัชเคมีภัณฑ์</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="FOREIGN_LOCATION_NAME"></td>
        <td width="2%"></td>
        <td><input class="btn btn-lg" type="button" value="ค้นหา" ng-click="BTN_SEARCH_CERT_STAFF(CER_FORMAT,FOREIGN_LOCATION_NAME,TR_ID,thanm)" style="width:150px;height:40px;" /></td>
    </tr>
    <tr>
        <td style="width:12%">เลขดำเนินการ</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="TR_ID"></td>
        <td width="2%"></td>
        <td style="width:15%">ชื่อผู้รับผู้รับอนุญาต <br />(ผลิต/นำสั่ง)</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="thanm"></td>
        <td width="2%"></td>
        <td style="width:150px"></td>
    </tr>
</table>
<br />
<div class="row">
    <div class="col-sm-12">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table class="table table-condensed" style="width:100%">
                <thead>
                    <tr>
                        <th style="width:15%">เลขดำเนินการ</th>
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
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
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