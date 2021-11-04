
@Code
    Layout = ""
End Code

<div class="ic">
    <h4>คำขอขึ้นทะเบียนยา</h4><br />
    <div class="row">
        <div class="col-sm-12" style="width:100%;">
            <div class="card" style=" border-top: 10px solid #F9D027;">
                <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                    <thead style="font-weight:300;">
                        <tr>
                            <td>เลขดำเนินการ</td>
                            <td>เลขรับ</td>
                            <td>สถานะ</td>
                            <td>ชื่อภาษาไทย</td>
                            <td>ชื่อภาษาอังกฤษ</td>
                            <td>รหัสการดำเนินการ</td>
                            <td>เหตุผลการคืนคำขอ</td>
                            <td>ผู้รับผิดชอบคำขอ</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </thead>
                    <tbody>
                        @*<tr ng-repeat="data in DATA_TABEAN_STAFF">
                            <td>{{data.TR_ID}}</td>
                            <td>{{data.RCVNO_MANUAL}}</td>
                            <td>{{data.STATUS_NAME_STAFF}}</td>
                            <td>{{data.thadrgnm}}</td>

                            <td>{{data.engdrgnm}}</td>
                            <td>{{data.trans_code}}</td>
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
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="">
                                    แบบฟอร์มทะเบียน
                                </a>
                            </td>
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="">
                                    ใบนัด
                                </a>
                            </td>
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="">
                                    เพิ่มการหยุดและขยายเวลา
                                </a>
                            </td>
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="">
                                    เพิ่มผู้รับผิดชอบคำขอ
                                </a>
                            </td>
                        </tr>*@
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>
                                <input type="button" ng-click="BTN_PREVIEW_DR()" value="ดูข้อมูล" />
                            </td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
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
