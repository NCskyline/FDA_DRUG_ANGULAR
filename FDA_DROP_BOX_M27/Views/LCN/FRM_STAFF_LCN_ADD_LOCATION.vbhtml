
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_EDIT_CTRL.js"></script>
<div ng-controller="LCN_EDIT_CTRL" ng-app="ANGULAR_APP">
    <h1>เลือกที่ตั้ง</h1>
    <table style="width:100%">
        <tr>
            <td colspan="2">
                @*<input type="radio" name="radio" value="1" style="margin-left:20%" ng-model="LIST_EDIT_LCN.LOCATION_TYPE" checked /> เลือกสถานที่
                    <input type="radio" name="radio" value="2" ng-model="LIST_EDIT_LCN.LOCATION_TYPE" />อ้างอิงสถานที่*@

                <label style="margin-left:20%">
                    <input type="radio" ng-model="LIST_EDIT_LCN.LOCATION_TYPE" value="1" checked>
                    เลือกสถานที่
                </label>
                <label>
                    <input type="radio" ng-model="LIST_EDIT_LCN.LOCATION_TYPE" value="2">
                    อ้างอิงสถานที่
                </label>

            </td>
        </tr>
    </table>
    <br />
    <div ng-show="LIST_EDIT_LCN.LOCATION_TYPE == '1'">

        <table style="width:100%">
            <tr>
                <td style="width:20%;padding-left:5%">
                    ชื่อที่ตั้ง
                </td>
                <td>
                    <select class="dropdown" ng-model="LIST_EDIT_LCN.KEEP_SELECT" ng-change="getdetails(LIST_EDIT_LCN.KEEP_SELECT)">
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
                    <input type="hidden" ng-model="LIST_EDIT_LCN.KEEP_SELECT" id="txt_hidden" />
                    <input type="button" value="เลือกข้อมูล" style="margin-left:20%" ng-click="BTN_SAVE(LIST_EDIT_LCN.KEEP_SELECT)" />
                </td>
            </tr>
        </table>


    </div>

 
    <div ng-show="LIST_EDIT_LCN.LOCATION_TYPE == '2'">
        <table style="width:100%">
            <tr>
                <td style="width:20%;padding-left:5%">
                    เลือกสถานที่
                </td>
                <td>
                    <select class="dropdown" ng-model="LIST_EDIT_LCN.LOCATION_SELECT" ng-change="Getdetails_Location(LIST_EDIT_LCN.LOCATION_SELECT)">
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
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.thanameplace" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    ชื่อสถานที่ (ภาษาอังกฤษ)
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.engnameplace" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="width:20%;padding-left:5%">
                    รหัสประจำบ้าน
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.HOUSENO" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    เลขที่
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.thaaddr" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    อาคาร/ตึก
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.thabuilding" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    ชั้น
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.thafloor" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />*กรุณากรอกคำว่า "ชั้น" เช่น ชั้น 3
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    ห้อง
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.tharoom" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />*กรุณากรอกคำว่า "ห้อง" เช่น ห้อง 241
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    หมู่
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.thamu" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />*กรุณากรอกคำว่า "อาคาร" เช่น อาคาร 1
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    ซอย
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.thasoi" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    ถนน
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.tharoad" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="width:20%;padding-left:5%">
                    จังหวัด
                </td>
                <td>
                    <select style="width:70%">
                        <option>
                            1
                        </option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="width:20%;padding-left:5%">
                    เขต/อำเภอ
                </td>
                <td>
                    <select style="width:70%">
                        <option>
                            1
                        </option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="width:20%;padding-left:5%">
                    แขวง/ตำบล
                </td>
                <td>
                    <select style="width:70%">
                        <option>
                            1
                        </option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    รหัสไปรษณีย์
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.zipcode" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    โทรศัพท์
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.tel" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    โทรศัพท์มือถือ
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.Mobile" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    โทรสาร
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.fax" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    latitude(ถ้าไม่มีใส่ 0)
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.latitude" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:5%">
                    longitude(ถ้าไม่มีใส่ 0)
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_LCN.longitude" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>

        <input type="button" value="บันทึกเเละใช้สถานที่" style="margin-left:20%" />
    </div>



    @*<br />
            <div ng-switch="checked">
                <div ng-switch-when="1">
                    <table style="width:100%">
                        <tr>
                            <td style="width:20%;padding-left:5%">
                                เลือกสถานที่
                            </td>
                            <td>
                                <select style="width:70%">
                                    <option>
                                        1
                                    </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                ชื่อสถานที่ (ภาษาไทย)
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                ชื่อสถานที่ (ภาษาอังกฤษ)
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <br />

            <div ng-switch="checked">
                <div ng-switch-when="2">
                    <h1>ที่ตั้งสถานที่</h1>
                    <table style="width:100%">
                        <tr>
                            <td style="width:20%;padding-left:5%">
                                รหัสประจำบ้าน
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                เลขที่
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                อาคาร/ตึก
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                ชั้น
                            </td>
                            <td>
                                <input style="width:70%" />*กรุณากรอกคำว่า "ชั้น" เช่น ชั้น 3
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                ห้อง
                            </td>
                            <td>
                                <input style="width:70%" />*กรุณากรอกคำว่า "ห้อง" เช่น ห้อง 241
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                หมู่
                            </td>
                            <td>
                                <input style="width:70%" />*กรุณากรอกคำว่า "อาคาร" เช่น อาคาร 1
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                ซอย
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                ถนน
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width:20%;padding-left:5%">
                                จังหวัด
                            </td>
                            <td>
                                <select style="width:70%">
                                    <option>
                                        1
                                    </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:20%;padding-left:5%">
                                เขต/อำเภอ
                            </td>
                            <td>
                                <select style="width:70%">
                                    <option>
                                        1
                                    </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:20%;padding-left:5%">
                                แขวง/ตำบล
                            </td>
                            <td>
                                <select style="width:70%">
                                    <option>
                                        1
                                    </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                รหัสไปรษณีย์
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                โทรศัพท์
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                โทรศัพท์มือถือ
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                โทรสาร
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                latitude(ถ้าไม่มีใส่ 0)
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:5%">
                                longitude(ถ้าไม่มีใส่ 0)
                            </td>
                            <td>
                                <input style="width:70%" />
                            </td>
                        </tr>
                    </table>

                    <input type="button" value="บันทึกเเละใช้สถานที่" style="margin-left:20%" />
                </div>
            </div>
        </div>*@
