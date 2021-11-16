
@Code
    Layout = ""
End Code

<div>
    <div class="ic">
        <h3><b>คำขอใบแทนใบสำคัญ</b></h3>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:100%"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
            </tr>
        </table>
        <br />
        <div class="row">
            <div class="col-sm-12" style="width:100%;">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                        <thead style="font-weight:300;">
                            <tr>

                                <td>เลขรับ</td>
                                <td>เลขทะเบียน</td>
                                <td>เลขดำเนินการ</td>
                                <td>เหตุผล</td>
                                <td>สถานะ</td>
                                <td></td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>640009999</td>
                                <td>TEST</td>
                                <td>ส่งเรื่องแล้วรอจนท.รับคำขอ</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                    <span class="fa fa-book"></span>
                                    <a ng-click="">
                                        ใบสำคัญ
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>640009999</td>
                                <td>TEST</td>
                                <td>ชำระเงินค่าคำขอแล้วรอจนท.เสนอลงนาม</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                    <span class="fa fa-book"></span>
                                    <a ng-click="">
                                        ใบสำคัญ
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>640009999</td>
                                <td>TEST</td>
                                <td>จนท.กดจ่ายใบสำคัญแล้ว</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                    <span class="fa fa-book"></span>
                                    <a ng-click="">
                                        ใบสำคัญ
                                    </a>
                                </td>
                            </tr>
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
                                    <span class="fa fa-book"></span>
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
    </div>
</div>

