@Code
    Layout = ""
End Code

<div>
    <div><h3 style="color:red">{{HEADER}}</h3></div>
    <div>
        <table>
            <tr>
                <td>License number :</td>
                <td>{{LCNNO_NO}}</td>
            </tr>
            <tr>
                <td>ชื่อสถานที่ :</td>
                <td>{{thanameplace}}</td>
            </tr>
            <tr>
                <td>ชื่อผู้ดำเนินการ :</td>
                <td>{{nameOperator}}</td>
            </tr>
        </table>

        <div align="right">
            <button ng-click="INPUT_CERT()">สร้างคำขอ</button>
        </div>
        <hr />
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #277210;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>ประเทศ</th>
                                <th>เลขที่ CER</th>
                                <th>วันที่ยื่นคำขอ</th>
                                <th>สถานะ</th>
                                <th>รหัสดำเนินการ</th>
                                <th>ใช้ได้ถึง</th>
                                <th>ชื่อผู้ผลิตต่างประเทศ</th>
                                <th>เหตุผลการคืนคำขอ</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="datas in DATA_GMP">

                                <td>{{datas.thacntnm}}</td>
                                <td>{{datas.CER_NUMBER}}</td>
                                <td>{{datas.REQUEST_DATE}}</td>
                                <td>{{datas.STATUS_NAME}}</td>
                                <td>{{datas.TR_ID}}</td>
                                <td>{{datas.EXP_DATE_EXTEND}}</td>
                                <td>{{datas.FOREIGN_LOCATION_NAME}}</td>
                                <td>{{datas.REMARK}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_CER(datas.IDA)">
                                        เลือก
                                    </a>
                                </td>
                            </tr>
                        </tbody>
                        <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                        ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                        boundary-link-numbers="true" rotate="false" max-size="maxSize">
                        </uib-pagination>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
