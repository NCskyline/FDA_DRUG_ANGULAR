
@Code
    Layout = ""
End Code

    <div>
        <div><h3 style="color:red">เภสัชเคมีภัณฑ์ > {{HEADER}}</h3></div>
        <div>
            <table>
                <tr>
                    <td>License number :</td>
                    <td>{{LCNNO_NO}}</td>
                </tr>
            </table>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="width:100%"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
                    <td align="right"><button class="btn btn-lg" ng-click="INPUT_DH()">สร้างคำขอ</button></td>
                </tr>
            </table>
            <br />
            <hr />
            <div>1.สามารถพิมพ์ใบสั่งชำระเงินจากระบบไปชำระได้ที่ ธนาคารไทยพาณิชย์ ทุกสาขา ตู้ATMของธนาคาร หรือชำระผ่าน SCBeasy หรือMobile appication ของธนาคาร</div>
            <div>2.เพื่อป้องกันไม่ให้เกิดปัญหาการชำระเงิน แนะนำ ใช้เครื่องพิมพ์ ชนิดเลเซอร์ในการพิมพ์ใบสั่งชำระ</div>
            <div>3.ไม่สามารถออกใบสั่งชำระที่ออกจากระบบอื่นที่ไม่ได้ออกมาจากระบบเภสัชเคมีภัณฑ์นี้ได้</div>
            <div>*หากพบปัญหาในการใช้งาน ขอความกรุณาแจ้งมาที่ drug-smarthelp@fda.moph.go.th ด้วยครับ</div>
            <br />
            <div class="row">
                <div class="col-sm-12">
                    <div class="card" style=" border-top: 10px solid #277210;">
                        <table style="margin-top:10px;width:100%;" class="table table-condensed">
                            <thead>
                                <tr>
                                    <th>เลขที่รับคำขอ</th>
                                    <th>วันที่ยื่นคำขอ</th>
                                    <th>สถานะ</th>
                                    <th>รหัส 15 หลัก</th>
                                    <th>ชื่อสาร</th>
                                    <th>รหัสการดำเนินการ</th>
                                    <th>เหตุผลการคืนคำขอ</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="datas in DATA_DH | filter : filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">

                                    <td>{{datas.rcvdate}}</td>
                                    <td>{{datas.REQUEST_DATE}}</td>
                                    <td>{{datas.STATUS_NAME}}</td>
                                    <td>{{datas.phm15dgt}}</td>
                                    <td>{{datas.CAS_NAME}}</td>
                                    <td>{{datas.TR_ID}}</td>
                                    <td>{{datas.REMARK}}</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_DH(datas)">
                                            เลือก
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td></td>
                                </tr>
                            </tfoot>
                        </table>
                        <hr />
                        <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                        ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                        boundary-link-numbers="true" rotate="false" max-size="maxSize">
                        </uib-pagination>
                        <div align="right">
                            <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>  ก่อนหน้า</button>
                            <button type="button" class="btn btn-sm" ng-disabled="currentPage >= DATA_DH.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>