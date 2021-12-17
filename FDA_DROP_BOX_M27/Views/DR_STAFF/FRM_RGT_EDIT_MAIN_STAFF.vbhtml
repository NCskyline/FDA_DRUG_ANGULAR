
@Code
    Layout = ""
End Code
<br />
<h4> คำขอแก้ไขเปลี่ยนแปลงทะเบียน</h4>
<br />
<div class="row">
    <div class="col-sm-12" style="width:100%;">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                <thead style="font-weight:300;">
                    <tr>
                        <td>เลขดำเนินการ</td>
                        <td>เลขรับ</td>
                        <td width="10%">เลขทะเบียน</td>
                        
                        <td>ชื่อภาษาไทย</td>
                        <td>ชื่อภาษาอังกฤษ</td>
                        <td>รายละเอียดการแก้ไข</td>
                        <td>สถานะ</td>
                        <td>ผู้รับผิดชอบคำขอ</td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>640009999</td>
                        <td></td>
                        <td>K 1/62</td>

                        <td>พารา</td>
                        <td>para</td>
                        <td>ฉลากทุกขนาดบรรจุ และเอกสารกำกับยาตามที่ได้ขึ้นทะเบียนไว้</td>
                        <td>อนุมัติ</td>
                        <td></td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="BTN_PREVIEW_RGT_EDIT()">
                                ดูข้อมูล
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
                                เพิ่มผู้รับผิดชอบคำขอ
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td>640009999</td>
                        <td></td>
                        <td>K 1/62</td>

                        <td>พารา 10<sup>8</sup></td>
                        <td>para</td>
                        <td>ฉลากทุกขนาดบรรจุ และเอกสารกำกับยาตามที่ได้ขึ้นทะเบียนไว้</td>
                        <td>เสนอลงนาม</td>
                        <td></td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="BTN_PREVIEW_RGT_EDIT()">
                                ดูข้อมูล
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
                                เพิ่มผู้รับผิดชอบคำขอ
                            </a>
                        </td>
                    </tr>
                    <tr ng-repeat="data in DATA_EDIT_TABEAN_STAFF">
                        <td>{{data.TR_ID}}</td>
                        <td>{{data.RCVNO_MANUAL}}</td>
                        <td>{{data.rgtno_display}}</td>

                        <td>{{data.thadrgnm}}</td>
                        <td>{{data.engdrgnm}}</td>
                        <td>{{data.EDIT_DESCRIPTION}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>{{data.STAFF_NAME}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="BTN_PREVIEW_RGT_EDIT()">
                                ดูข้อมูล
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
                                เพิ่มผู้รับผิดชอบคำขอ
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
