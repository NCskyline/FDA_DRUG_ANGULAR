﻿@Code
    ViewData("Title") = "INPUT_DS_PORYOR8"
End Code

    <div>
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
                <table class="table" width="100%">
                    <tr>
                        <td width="30%">เขียนที่ :</td>
                        <td width="70%"></td>
                    </tr>
                    <tr>
                        <td>วันที่ :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>บัญชีรายการยา :</td>
                        <td></td>
                    </tr>
                </table>
                <div align="center">
                    <h3>ข้อมูลใบอนุญาต</h3>
                </div>
                <br />
                <table class="table" width="100%">
                    <tr>
                        <td width="30%">ชื่อผู้รับอนุญาต :</td>
                        <td width="70%"></td>
                    </tr>
                    <tr>
                        <td>เลขที่ใบอนุญาต :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>สถานที่ผลิต/นำสั่ง :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ชื่อผู้ดำเนินกิจการ :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ที่อยู่ :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ผู้มีหน้าที่ปฏิบัติการ :</td>
                        <td></td>
                    </tr>
                </table>
                <div align="center">
                    <h3>ข้อมูลผลิตภัณฑ์ยา</h3>
                </div>
                <br />
                <table class="table" width="100%">
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
                <table class="table" width="100%" border="1">
                    <tr>
                        <td>ลำดับ</td>
                        <td>ตัวยาสำคัญ</td>
                        <td>ปริมาณ</td>
                        <td>หน่วย</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>
                <table class="table">
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
                            <input type="button" class="form-control" value="เพิ่ม/ลบ ขนาดบรรจุ" />
                        </td>
                    </tr>
                </table>
                <br />
                <div align="center">
                    <table class="table" width="70%" border="1">
                        <tr>
                            <td>ชื่อขนาดบรรจุ</td>
                            <td>จำนวนปริมาณนำสั่ง / ผลิต</td>
                            <td>หน่วย</td>
                            <td></td>
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
                        <div class="card" >
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
                    <input type="button" class="btn btn-lg " value="บันทึก" />
                    <input type="button" class="btn btn-lg " value="ย้อนกลับ" />
                </div>
            </div>
        </div>
    </div>

