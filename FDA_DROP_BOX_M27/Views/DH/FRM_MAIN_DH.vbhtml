
@Code
    Layout = ""
End Code

    <div>
        <div><h3 style="color:red">ออกเลขจดแจ้งเภสัชเคมีภัณฑ์ {{HEADER}}</h3></div>
        <div>
            <table>
                <tr>
                    <td>เลขที่ใบอนุญาต (License Number)</td>
                    <td>{{LCNNO_NO}}</td>
                </tr>
                <tr>
                    <td>ชื่อผู้รับอนุญาต (License Name)</td>
                    <td>{{nameOperator}}</td>
                </tr> 
                <tr>
                    <td>ที่ตั้ง (Address)</td>
                    <td>{{thanameplace}}</td>
                </tr>
            </table>
            <br />
            
            <div style="color:red">1.สามารถพิมพ์ใบสั่งชำระเงินจากระบบไปชำระได้ที่ ธนาคารไทยพาณิชย์ ทุกสาขา ตู้ATMของธนาคาร หรือชำระผ่าน SCBeasy หรือMobile appication ของธนาคาร</div>
            <div style="color:red">2.เพื่อป้องกันไม่ให้เกิดปัญหาการชำระเงิน แนะนำ ใช้เครื่องพิมพ์ ชนิดเลเซอร์ในการพิมพ์ใบสั่งชำระ</div>
            <div style="color:red">3.ไม่สามารถออกใบสั่งชำระที่ออกจากระบบอื่นที่ไม่ได้ออกมาจากระบบเภสัชเคมีภัณฑ์นี้ได้</div>
            <div style="color:red">*หากพบปัญหาในการใช้งาน ขอความกรุณาแจ้งมาที่ drug-smarthelp@fda.moph.go.th ด้วยครับ</div>
            <div style="color:red">*กรุณาตรวจสอบคำขอก่อนสร้างใบสั่งชำระ กรณีชำระเงินแล้ว ระบบไม่สามารถแก้ไขได้</div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="width:100%"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
                    <td align="right"><button class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="INPUT_DH()">สร้างคำขอ</button></td>
                </tr>
            </table>
            <br />
            <div class="row">
                <div class="col-sm-12">
                    <div class="card" style=" border-top: 10px solid #F9D027;">
                        <table style="margin-top:10px;width:100%;" class="table table-condensed">
                            <thead>
                                <tr>
                                    <th>เลขที่รับคำขอ <br />
                                    Submission Number</th>
                                    <th>วันที่ยื่นคำขอ <br />
                                    Submission Date</th>
                                    <th>สถานะ <br />
                                    Status</th>
                                    <th>เลขจดแจ้ง <br />
                                    DRM Number</th>
                                    <th>วันหมดอายุเลขจดแจ้ง <br />
                                    Valid Date of DRM No.</th>
                                    <th>ชื่อสาร <br />
                                    Substance</th>
                                    <th>ชื่อผู้ผลิต <br />
                                    Manufacturer</th>
                                    <th>รหัสการดำเนินการ <br />
                                    Submission No.</th>
                                    <th>เหตุผลการคืนคำขอ <br />
                                    Rejection Reason</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="datas in DATA_DH | filter : filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">

                                    <td>{{datas.rcvdate}}</td>
                                    <td>{{datas.REQUEST_DATE}}</td>
                                    <td>{{datas.STATUS_NAME}}</td>
                                    <td>{{datas.phm15dgt}}</td>
                                    <td>{{}}</td>
                                    <td>{{datas.CAS_NAME}}</td>
                                    <td>{{}}</td>
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