﻿@Code
    Layout = ""

End Code

@*<script src="../Scripts/bootstrap-select.js"></script>
<script src="../Scripts/bootstrap-select.min.js"></script>*@
@*<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>*@

    <script type="text/javascript">
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        })
    </script>

<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    
</style>

<div class="ic">
    <h2 style="font-family:'Taviraj';font-size:24px;">
        แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ
    </h2>
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td style="height:25px;width:35%;">
                1. Reference Number<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CERTIFICATION_NUMBER_ALL" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                3. ที่อยู่ (Address)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                4. เมือง (City / Province/ State)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                5. ประเทศ (Country)<font color="red">*</font> :
            </td>
            <td>
                @*<input list="countrys"  class="form-control" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID" />*@
                <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                รหัสไปรษณีย์ (Post code/Zip code) :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                6. Manufactur&#39;s License Number<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                Global Location Number (GLN) :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.GLN" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                7. หน่วยงานที่ออกเอกสาร<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ประเทศ (Country)<font color="red">*</font> :
            </td>
            <td>
                <select class="form-control selectpicker" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID" data-live-search="true" title="-- Please select --">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                8. เลขหนังสือให้ความเห็นชอบ<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_DOCNO" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                9. วันเดือนปีที่ออกหนังสือ (Issue Date)<font color="red">*</font> :
            </td>
            <td>

                <md-datepicker ng-model="LIST_GMP.CER.DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>

            </td>
        </tr>
        <tr>
            <td style="height:25px">
                วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ประเทศของหน่วยงานที่ออกใบรับรอง :
            </td>
            <td>
                <select class="form-control selectpicker" data-live-search="true" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_OF_DEPARTMENT_IDA" title="-- Please select --">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
    </table>
    <br />
    <h2 style="font-family:'Taviraj';font-size:24px;">
        รายละเอียดผลิตภัณฑ์
    </h2>
    <table width="100%">
        <tr>
            <td style="height:25px;width:35%;">
                10. ขอบข่าย
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CER_SCOPE" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
    <br />
    @*<div class="col-sm-12">
            <div class="row">
                <div class="col-sm-3" style="text-align:center">
                    รายละเอืยด :
                </div>
                <div class="col-sm-9">
                    {{REMARK}}
                </div>
            </div>
            <br />
            <table class="table" style="width:100%">
                <tr>
                    <td>ชื่อไฟล์</td>
                    <td></td>
                </tr>
                <tr ng-repeat="datas in LIST_GMP" style="background-color:#FDFCE3">
                    <td>{{datas.FILENAME}}</td>
                    <td>
                        <a ng-show="datas.PROCESS == '36'" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                    </td>
                </tr>
            </table>
            <br />
        </div>*@
</div>

