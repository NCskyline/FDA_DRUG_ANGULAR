
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

            <div align="right">
                <button ng-click="INPUT_DH()">สร้างคำขอ</button>
            </div>
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
                                <tr ng-repeat="datas in DATA_DH">

                                    <td>{{datas.rcvdate}}</td>
                                    <td>{{datas.REQUEST_DATE}}</td>
                                    <td>{{datas.STATUS_NAME}}</td>
                                    <td>{{datas.phm15dgt}}</td>
                                    <td>{{datas.CAS_NAME}}</td>
                                    <td>{{datas.TR_ID}}</td>
                                    <td>{{datas.REMARK}}</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_CER(datas,'12')">
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