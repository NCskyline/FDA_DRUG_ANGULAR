@Code
    ViewData("Title") = "INPUT_DS_PORYOR8"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DR_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div ng-app="ANGULAR_APP" ng-controller="DR_CTRL">
    <div style="font-family:'Taviraj'">
        <div class="in">
            <div align="center">
                <div>
                    <h2><b>ผลิตยาตัวอย่างเพื่อขอขึ้นทะเบียนตำรับยา (ผย8)</b></h2>
                </div>
                <div>
                    <h4><u>(หากมีปัญหาเกี่ยวกับการใช้งานระบบหรือไม่พบตัวเลือกโปรดแจ้ง Drug-SmartHelp@fda.moph.go.th)</u></h4>
                </div>
            </div>
        </div>
        <div class="in">
            <div align="center">
                <h3>ข้อมูลทั่วไป</h3>
            </div>
            <br />
            <table class="table" width="100%" style="font-size:20px">
                <tr>
                    <td width="30%">เขียนที่ :</td>
                    <td width="70%">
                        <label></label>
                    </td>
                </tr>
                <tr>
                    <td>วันที่ :</td>
                    <td>
                        <label></label>
                    </td>
                </tr>
                <tr>
                    <td>บัญชีรายการยา :</td>
                    <td>
                        <label></label>
                    </td>
                </tr>
            </table>
            <br />
            <div align="center">
                <h3>ข้อมูลใบอนุญาต</h3>
            </div>
            <br />
            <table class="table" width="100%" style="font-size:20px">
                <tr>
                    <td width="30%">ชื่อผู้รับอนุญาต :</td>
                    <td width="70%">
                        <label></label>
                    </td>
                </tr>
                <tr>
                    <td>เลขที่ใบอนุญาต :</td>
                    <td>
                        <label></label>
                    </td>
                </tr>
                <tr>
                    <td>สถานที่ผลิต/นำสั่ง :</td>
                    <td>
                        <label></label>
                    </td>
                </tr>
                <tr>
                    <td>ชื่อผู้ดำเนินกิจการ :</td>
                    <td>
                        <label></label>
                    </td>
                </tr>
                <tr>
                    <td>ที่อยู่ :</td>
                    <td>
                        {{LIST_LCN.thaaddr}}
                </tr>
                <tr>
                    <td>ซอย :</td>
                    <td>
                        {{LIST_LCN.thasoi}}
                    </td>
                </tr>
                <tr>
                    <td>ถนน :</td>
                    <td>
                        {{LIST_LCN.tharoad}}
                    </td>
                </tr>
                <tr>
                    <td>หมู่ :</td>
                    <td>
                        {{LIST_LCN.thamu}}
                    </td>
                </tr>
                <tr>
                    <td>ตำบล :</td>
                    <td>
                        {{LIST_LCN.thathmblnm}}
                    </td>
                </tr>
                <tr>
                    <td>อำเภอ :</td>
                    <td>
                        {{LIST_LCN.thaamphrnm}}
                    </td>
                </tr>
                <tr>
                    <td>จังหวัด :</td>
                    <td>
                        {{LIST_LCN.thachngwtnm}}
                    </td>
                </tr>
                <tr>
                    <td>โทรศัพท์ :</td>
                    <td>
                        {{LIST_LCN.tel}}
                    </td>
                </tr>
                <tr>
                    <td>ผู้มีหน้าที่ปฏิบัติการ :</td>
                    <td>
                        {{}}
                    </td>
                </tr>
            </table>
            <br />
            <div align="center">
                <h3>ข้อมูลผลิตภัณฑ์ยา</h3>
            </div>
            <br />
            <table class="table" width="100%" style="font-size:20px">
                <tr>
                    <td width="30%">ชื่อยา :</td>
                    <td width="70%"></td>
                </tr>
                <tr>
                    <td>ลักษณะและสีของยา :</td>
                    <td></td>
                </tr>
            </table>
            <br />
            <table class="table" width="100%" border="1" style="font-size:20px">
                <tr>
                    <td width="10%" style="text-align:center">ลำดับ</td>
                    <td style="text-align:center">ตัวยาสำคัญ</td>
                    <td style="text-align:center">ปริมาณ</td>
                    <td style="text-align:center">หน่วย</td>
                </tr>
                <tr>
                    <td style="text-align:center"></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
            <table class="table" style="font-size:20px">
                <tr>
                    <td width="15%">หน่วยนับตามรูปแบบยา :</td>
                    <td width="30%"></td>
                    <td width="15%"></td>
                    <td width="20%"></td>
                    <td width="20%"></td>
                </tr>
                <tr>
                    <td>ปริมาณที่จะผลิต/นำสั่ง :</td>
                    <td>
                        <select class="form-control selectpicker">
                            <option></option>
                        </select>
                    </td>
                    <td>
                        <input type="text" class="form-control" />
                    </td>
                    <td>
                        <input type="button" class="form-control" value="บันทึก" />
                    </td>
                    <td>
                        <input type="button" class="form-control" value="เพิ่ม/ลบ ขนาดบรรจุ" @*ng-click="ADD_PACKAGE()"*@ />
                    </td>
                </tr>
            </table>
            <br />
            <div align="center" style="font-size:20px">     
                <table class="table" width="70%" border="1">
                    <tr>
                        <td style="text-align:center">ชื่อขนาดบรรจุ</td>
                        <td style="text-align:center">จำนวนปริมาณนำสั่ง / ผลิต</td>
                        <td style="text-align:center">หน่วย</td>
                        <td style="text-align:center"></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>
            </div>

        </div>
        <div class="in">
            <div class="row" style="padding-top: 30px;">
                <div class="col-sm-6">
                    <h1>
                        รายการเอกสารไฟล์แนบ
                    </h1>
                </div>
                <div class="col-sm-6" style="text-align:right;margin-bottom:20px;">
                    <input type="button" class="btn btn-lg btn-success" ng-click="ADD_FILE_LIST()" value="เพิ่มเอกสารแนบ" />
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12" style="width:100%">
                    <div class="card">
                        @*<div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                                หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                            </div>
                            <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                                หัวข้อเอกสาร (ไม่บังคับแนบ)
                            </div>*@
                        <div class="card-body">

                            <table class="table" style="width:100%">
                                <tr>
                                    <td colspan="5">
                                        {{datas.DES}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:15%;"><input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                                    <td style="width:10%;">ชื่อไฟล์</td>
                                    <td style="width:50%;">{{datas.FILENAME}}</td>
                                    <td style="width:5%">
                                        <a ng-click="OPEN_DOC_PATH(datas.PATH)">{{FLAG}}</a>
                                    </td>
                                    <td style="width:20%; text-align: right;">
                                        @*<input type="button" ng-click="UPLOAD_PDFs(datas)" value="บันทึก" />*@
                                        <input type="button" ng-click="deleteRow(datas,$index)" value="ลบ" />
                                    </td>
                                </tr>

                            </table>
                        </div>

                    </div>
                </div>
            </div>
            <br />
            <div class="col-sm-12" style="text-align:center;margin-bottom:40px;">
                <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="BTN_SAVE_DS()" value="บันทึก" />
                <input type="button" class="btn btn-lg" style="background-color:#FFD700" value="ย้อนกลับ" />
            </div>
        </div>
        <div class="clearfix"></div>
        <div class="modal fade bd-example-modal-lg" id="exampleModalLong" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true" style="">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-body">
                        <div class="ic">
                            <table>
                                <tr>
                                    <td>Email</td>
                                    <td>
                                        <input type="text" class="form-control" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>Tel</td>
                                    <td>
                                        <input type="text" class="form-control" />
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <div>
                                <button class="btn btn-lg" ng-click="BTN_CONFIRM()">บันทึก</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

