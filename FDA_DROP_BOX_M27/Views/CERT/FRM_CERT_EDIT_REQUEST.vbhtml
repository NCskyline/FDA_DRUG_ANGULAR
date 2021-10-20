@Code
    ViewData("Title") = "FRM_CERT_EDIT_REQUEST"
End Code

    <script type="text/javascript">
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        })
    </script>

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CERT_GMP_CTRL.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>

<div ng-app="ANGULAR_APP" ng-controller="CERT_GMP_CTRL" ng-init="CER_EDIT()">
    <div class="ic">
        <div ng-show="LIST_GMP.CER.CER_TYPE == '31'">
            <h2 style="font-family:'Taviraj';font-size:24px;">
                <b> รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
            </h2>
            <h2 style="font-family:'Taviraj';font-size:24px;">
                <b> (Information of Certificate of Drug Substance Manufacturer)</b>
            </h2>
            <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                <tr>
                    <td style="height:25px;width:35%;">
                        1. เลขที่ใบรับรอง (Certificate Number)<font color="red">*</font>
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_GMP.CER.CERTIFICATION_NUMBER_ALL" style="font-family:'Taviraj';font-size:20px;font:lighter" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        2. ชื่อผู้ผลิต (Manufacturer)<font color="red">*</font>
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        3. เลขที่ใบอนุญาตผลิต (Manufacturing Licence Number)
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                @*<tr>
                <td style="height:25px">
                    Global Location Number (GLN) :
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.GLN" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>*@
                <tr>
                    <td style="height:25px">
                        4. ที่ตั้ง (Site Address)<font color="red">*</font>
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        5. เมือง (City / Province/ State)<font color="red">*</font>
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        6. ประเทศ (Country<font color="red">*</font>
                    </td>
                    <td>
                        <select style="font-family:'Taviraj';font-size:20px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_GMP.CER.COUNTRY_ID">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                            <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        รหัสไปรษณีย์ (Postal Code / Zip Code)
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>

                <tr>
                    <td style="height:25px">
                        7. วันที่ออกใบรับรอง GMP (Issue Date)<font color="red">*</font>
                    </td>
                    <td>
                        <md-datepicker ng-model="LIST_GMP.CER.DOCUMENT_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header"></md-datepicker>
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        วันที่หมดอายุใบรับรอง GMP (Expiry Date / Valid Until)<font color="red">*</font>
                    </td>
                    <td>
                        <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header "></md-datepicker>
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        8. หน่วยงานที่ออกใบรับรอง (Certification Agency)<font color="red">*</font>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="1" />
                        หน่วยงานรัฐที่ออกใบรับรอง (Government Certification Agency)
                    </td>
                    <td rowspan="2" ;">
                        <input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME" style="font-family:'Taviraj';font-size:20px;height:100px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="2" />
                        หน่วยงานอื่นที่ได้รับการรับรองจากหน่วยงานรัฐของประเทศที่ออกใบรับรอง (Certification Agency Accredited by Government Agency)
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="height:25px">
                        9. มาตรฐาน GMP ของสถานที่ผลิต (GMP Standard of Manufacturer)<font color="red">*</font>

                    </td>
                    <td>
                        <table>
                            <tr>
                                <td style="height:25px">
                                    <form name="rdl_gmp">
                                        <label>
                                            <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" value="1">
                                            PIC/S GMP
                                        </label>
                                        <label>&nbsp;</label>
                                        <label>
                                            <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="2">
                                            WHO GMP
                                        </label>
                                        <label>&nbsp;</label>
                                        <label>
                                            <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" value="3">
                                            National GMP
                                        </label>
                                    </form>
                                </td>
                                <td>
                                    &nbsp; ประเทศ (Country)<font color="red">* &nbsp;&nbsp;</font>
                                </td>
                                <td>
                                    <select style="font-family:'Taviraj';font-size:20px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_GMP">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                        <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                                    </select>

                                </td>
                            </tr>
                        </table>


                    </td>
                </tr>
            </table>
            <br />
            <h2 style="font-family:'Taviraj';font-size:24px;">
                <b> รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substances under Certification) </b>
            </h2>
            <table width="100%">
                <tr>
                    <td style="height:25px;width:35%;font-family:'Taviraj';font-size:20px;">
                        10. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_GMP.CER.CER_SCOPE" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
            </table>
            <br />
            <div>
                <div>
                    <table width="100%">
                        <tr>
                            <td align="right" width="50%">
                                <input class="form-control" placeholder="ค้นหาสารที่นี่..." ng-model="iowanm" />
                            </td>
                            <td align="left" width="50%">
                                <button class="btn btn-lg" ng-click="BTN_SEARCH_CHEM(iowanm)" value="ค้นหาสารที่นี่">ค้นหาสาร</button>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="ic">
                    <table id="myTable" datatable="ng" class="dataTable" width="100%">
                        <thead>
                            <tr>
                                <th>ชื่อสาร</th>
                                <th>A</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="datas in LIST_CHEM | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                                <td>{{datas.iowanm}}</td>
                                <td>{{datas.aori}}</td>
                                <td>
                                    <a ng-click="BTN_ADD_CHEM(datas)">
                                        เลือกสาร
                                    </a>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr></tr>
                        </tfoot>
                    </table>
                    <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                    ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                    boundary-link-numbers="true" rotate="false" max-size="maxSize">
                    </uib-pagination>
                    <div align="center">
                        <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>  ก่อนหน้า</button>
                        <button type="button" class="btn btn-sm" ng-disabled="currentPage >= LIST_CHEM.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
                    </div>
                </div>

                <div>
                    <table class="dataTable" width="100%">
                        <thead>
                            <tr>
                                <th>ลำดับ</th>
                                <th>ชื่อสาร</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="datas in GMP_CHEM">
                                <td>{{$index + 1}}</td>
                                <td>{{datas.CAS_NAME}}</td>
                                <td>
                                    <span class="fas fa-edit"></span>
                                    <a ng-click="deleteCHEM(datas,$index)">
                                        ลบสาร
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
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
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
        <div ng-show="LIST_GMP.CER.CER_TYPE == '32'">

        </div>
        <div ng-show="LIST_GMP.CER.CER_TYPE == '33'">

        </div>
        <div ng-show="LIST_GMP.CER.CER_TYPE == '34'">

        </div>
        <div ng-show="LIST_GMP.CER.CER_TYPE == '36'">

        </div>
    </div>
</div>