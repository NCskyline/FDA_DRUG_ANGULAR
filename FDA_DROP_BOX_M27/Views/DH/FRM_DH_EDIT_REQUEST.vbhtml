@Code ViewData("Title") = "FRM_DH_EDIT_REQUEST" End Code

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DH_CTRL.js"></script>

<div ng-app="ANGULAR_APP" ng-controller="DH_CTRL" ng-init="DH_EDIT()">
    <div class="ic">
        <div style="font-family:'Taviraj';width:100%">
            <center>
                <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
                <h2>
                    {{HEADER_PROCESS}}
                </h2>
            </center>
            <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                <tr>
                    <td width="20%" align="right">
                        ข้าพเจ้า
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;" align="center">
                        <label>{{LIST_LCN.NAME}}</label>
                    </td>
                    <td>
                        ผู้รับอนุญาต
                    </td>

                </tr>
            </table>
            <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                <tr>
                    <td width="30%">
                        <form name="myForm">
                            <label>
                                <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="1">
                                ผลิต
                            </label>
                            <label>
                                <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="2">
                                นำหรือสั่ง เข้ามาในราชอาณาจักร ซึ่งยาแผนปัจจุบัน
                            </label>
                        </form>
                    </td>
                    <td align="right" width="10%">
                        ใบอนุญาต เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <span style="padding-left:5px;" />  <label>{{LIST_LCN.LCN_NO_DISPLAY}}</label>
                    </td>

                </tr>

            </table>
            <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                <tr>
                    <td width="10%">อยู่เลขที่ </td>
                    <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.FULL_ADDR}}</label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>หมายเลขโทรศัพท์ </td>
                    <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.TEL}}</label>
                    </td>
                    <td>มีความประสงค์ขอ</td>
                </tr>
            </table>
            <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                <tr>
                    <td width="25%">
                        <form name="myForm">
                            <label>
                                <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="1">
                                ผลิต
                            </label>
                            <label>
                                <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="2">
                                นำหรือสั่งเข้ามาในราชอาณาจักร
                            </label>
                        </form>

                    </td>
                    <td>

                        <form name="myForm">
                            ซึ่ง
                            <label>
                                <input type="radio" ng-model="LIST_LCN.dh15rqt.CHK_TYPE_CHEMICAL" value="1">
                                เภสัชเคมีภัณฑ์เดี่ยว
                            </label>
                            <label>
                                <input type="radio" ng-model="LIST_LCN.dh15rqt.CHK_TYPE_CHEMICAL" value="2">
                                เภสัชเคมีภัณฑ์กึ่งสำเร็จรูป
                            </label>
                        </form>
                    </td>
                </tr>
            </table>
            <div style="font-family:'Taviraj';font-size:20px;">มีรายละเอียดดังนี้</div>
            <br />
            <div ng-show="LIST_DH.dh15rqt.PROCESS_ID == '14'">
                <center>
                    <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
                    <h2>
                        เป็นสารออกฤทธิ์ในทะเบียนตำรับยาผลิตในประเทศ
                    </h2>
                </center>

                <table width="30%">
                    <tr>
                        <td>
                            เลขที่อ้างอิงสถานที่ผลิต (ThFDA-D Ref)
                        </td>
                        <td>
                            <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA" ng-change="Getdetails_REF_CER(LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA)">
                                <option ng-repeat="ref in REF_CERT" value="{{ref.IDA}}">{{ref.CER_NUMBER}}</option>
                            </select>
                        </td>
                    </tr>
                </table>
                <table width="100%">
                    <tr>
                        <td>
                            ชื่อผู้ผลิตเภสัชเคมีภัณฑ์ (Drug Substance Manufacturer)
                        </td>
                        <td width="30%" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>
                                {{LIST_REF_CERT.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                            </label>
                        </td>
                        <td>
                            ประเทศ (Country)
                        </td>
                        <td width="20%" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>
                                {{LIST_REF_CERT.COUNTRY_NAME}}
                            </label>
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>
                            วันที่ที่ออกใบรับรอง (Issue Date)
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>
                                {{LIST_REF_CERT.CER.DOCUMENT_DATE}}
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            วันที่ใบรับรองหมดอายุ (Valid Until)
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>
                                {{LIST_REF_CERT.CER.EXP_DOCUMENT_DATE}}
                            </label>
                        </td>
                    </tr>
                </table>
                <table width="100%">
                    <tr>
                        <td>
                            ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน) (Foreign Distributor (Purchasing through))
                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_DH.dh15rqt.AGENT_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>
                        <td>
                            ประเทศ (Country)
                        </td>
                        <td>
                            <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
                                @*<option value="0">--กรุณาเลือก--</option>*@
                                <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                            </select>
                        </td>
                    </tr>
                </table>
                <br />
                <table width="100%">
                    <tr>
                        <td>
                            ชื่อการค้า (Trade Name) <font color="red">*</font>
                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_DH.dh15rqt.TRADING_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>

                    </tr>
                    <tr>
                        <td>
                            มาตรฐานตามตำรับยา (Phamacopoeia Standard of Drug Substance)
                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>
                    </tr>
                </table>
            </div>
            <div ng-show="LIST_DH.dh15rqt.PROCESS_ID == '15'">

            </div>
            <div ng-show="LIST_DH.dh15rqt.PROCESS_ID == '16'">

            </div>
            <div class="row" style="padding-top: 30px;">
                <div class="col-sm-6">
                    <h1>
                        รายการเอกสารไฟล์แนบเพิ่มเติม
                    </h1>
                </div>
                <div class="col-sm-6" style="text-align:right;margin-bottom:20px;">
                    <input type="button" class="btn btn-lg btn-success" ng-click="ADD_FILE_LIST()" value="เพิ่มเอกสารแนบ" />
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12" style="width:100%">
                    <div class="card" ng-repeat="datas in DOC_LIST.FILE_LISTs">
                        <div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                            หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                        </div>
                        <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                            หัวข้อเอกสาร (ไม่บังคับแนบ)
                        </div>
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
            <div style="text-align:center">
                <input type="button" class="btn btn-lg" ng-click="BTN_SEND_REQUEST()" value="บันทึกและส่งเรื่องคืนเจ้าหน้าที่" />
                <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
            </div>
        </div>
    </div>
</div>

