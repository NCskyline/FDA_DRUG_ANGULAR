
@Code
    Layout = ""
End Code
<br />
<h4> คำขอใบแทนใบสำคัญ</h4>
<br />
<div class="row">
    <div class="col-sm-12" style="width:100%;">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                <thead style="font-weight:300;">
                    <tr>

                        <td>เลขรับ</td>
                        <td width="10%">เลขทะเบียน</td>
                        <td>เลขดำเนินการ</td>
                        <td>เหตุผล</td>
                        <td>สถานะ</td>
                        <td></td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in DATA_STT_TABEAN_STAFF">
                       
                        <td>{{data.RCVNO_MANUAL}}</td>
                        <td>{{data.RGTNO_DISPLAY}}</td>
                        <td>{{data.TR_ID}}</td>
                        <td>{{data.PURPOSE}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
                                ดูข้อมูล
                            </a>
                        </td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
                                ใบสำคัญ
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
