@Code
    ViewData("Title") = "INPUT_LCT_REQUEST"
End Code

<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload_lct()">
    <div style="font-family:'Taviraj';font-size:20px;">
        <h1>เลือกที่ตั้ง</h1>
        <table style="width:100%">
            <tr>
                <td colspan="2">
                    <label style="margin-left:20%">
                        <input type="radio" ng-model="LIST_LCT.LOCATION_TYPE" value="1" checked>
                        เลือกสถานที่
                    </label>
                    <label>
                        <input type="radio" ng-model="LIST_LCT.LOCATION_TYPE" value="2">
                        อ้างอิงสถานที่
                    </label>

                </td>
            </tr>
        </table>
        <br />
        <div ng-show="LIST_LCT.LOCATION_TYPE == '1'">

            <table style="width:100%">
                <tr>
                    <td style="width:20%;padding-left:5%">
                        ชื่อที่ตั้ง
                    </td>
                    <td>
                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCT.KEEP_SELECT" ng-change="getdetails_1(LIST_LCT.KEEP_SELECT)">
                            <option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ที่ตั้ง (ใหม่)
                    </td>
                    <td>
                        <label>{{LIST_LABEL.fulladdr}}</label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="hidden" ng-model="LIST_LCT.KEEP_SELECT" id="txt_hidden" />
                        <input type="button" value="เลือกข้อมูล" style="margin-left:20%" ng-click="BTN_SAVE_LCT(LIST_LCT.KEEP_SELECT)" />
                    </td>
                </tr>
            </table>


        </div>


        <div ng-show="LIST_LCT.LOCATION_TYPE == '2'">
            <table style="width:100%">
                <tr>
                    <td style="width:20%;padding-left:5%">
                        เลือกสถานที่
                    </td>
                    <td>
                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCT.LOCATION_SELECT" ng-change="Getdetails_Location(LIST_LCT.LOCATION_SELECT)">
                            <option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                        </select>
                    </td>
                </tr>

            </table>
            <h1>ที่ตั้งสถานที่</h1>
            <table style="width:100%">
                <tr>
                    <td style="padding-left:5%">
                        ชื่อสถานที่ (ภาษาไทย)
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.thanameplace" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ชื่อสถานที่ (ภาษาอังกฤษ)
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.engnameplace" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;padding-left:5%">
                        รหัสประจำบ้าน
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.HOUSENO" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        เลขที่
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.thaaddr" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        อาคาร/ตึก
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.thabuilding" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ชั้น
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.thafloor" style="font-family:'Taviraj';font-size:20px;" type="text" />*กรุณากรอกคำว่า "ชั้น" เช่น ชั้น 3
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ห้อง
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.tharoom" style="font-family:'Taviraj';font-size:20px;" type="text" />*กรุณากรอกคำว่า "ห้อง" เช่น ห้อง 241
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        หมู่
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.thamu" style="font-family:'Taviraj';font-size:20px;" type="text" />*กรุณากรอกคำว่า "อาคาร" เช่น อาคาร 1
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ซอย
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.thasoi" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ถนน
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.tharoad" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;padding-left:5%">
                        จังหวัด
                    </td>
                    <td>
                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.chngwtcd" ng-change="Bind_dll_amp(LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.chngwtcd)">
                            <option ng-repeat="x in REF_CHNGWT" value="{{x.chngwtcd}}">{{x.thachngwtnm}}</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;padding-left:5%">
                        เขต/อำเภอ
                    </td>
                    <td>
                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.amphrcd" ng-change="Bind_dll_tmb(LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.chngwtcd , LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.amphrcd)">
                            <option ng-repeat="x in REF_AMP" value="{{x.amphrcd}}">{{x.thaamphrnm}}</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;padding-left:5%">
                        แขวง/ตำบล
                    </td>
                    <td>

                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.thmblcd">
                            <option ng-repeat="x in REF_TMB" value="{{x.thmblcd}}">{{x.thathmblnm}}</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        รหัสไปรษณีย์
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.zipcode" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        โทรศัพท์
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.tel" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        โทรศัพท์มือถือ
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.Mobile" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        โทรสาร
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.fax" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        latitude(ถ้าไม่มีใส่ 0)
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.latitude" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        longitude(ถ้าไม่มีใส่ 0)
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCT.DALCN_LOCATION_ADDRESS_RQT.longitude" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
            </table>

            <div style="text-align:center;">
                <input type="button" value="บันทึกเเละใช้สถานที่" ng-click="BTN_SAVE_LCT_COPY()" />
                <input type="button" value="กลับหน้าหลัก" ng-click="BTN_BACK_TO_INFORMATION()" />
            </div>
        </div>

    </div>
</div>