@Code
    Layout = ""
End Code

<div style="font-family:'Taviraj';font-size:20px">
    <h3>ประเภทสถานที่</h3>
    <table width="100%" style="margin-left:5%;font-family:'Taviraj';font-size:20px">
        <tr>
            <td colspan="2">
                <label style="margin-left:20px">
                    <input type="radio" ng-model="LIST_EDIT_LCN.LOCATION_TYPE" value="1" checked />
                    ที่ตั้ง
                </label>
                <label>&nbsp;&nbsp;&nbsp;</label>
                <label>
                    <input type="radio" ng-model="LIST_EDIT_LCN.LOCATION_TYPE" value="2" />
                    สถานที่เก็บ
                </label>
            </td>
        </tr>
    </table>

    <div ng-show="LIST_EDIT_LCN.LOCATION_TYPE == '1'">

    </div>

    <h3>ชื่อสถานที่</h3>
    <table width="100%" style="margin-left:3%;font-family:'Taviraj';font-size:20px">
        <tr>
            <td width="15%">ชื่อสถานที่ (ภาษาไทย)</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thanameplace" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
        <tr>
            <td width="15%">ชื่อสถานที่ (ภาษาอังกฤษ)</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.engnameplace" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
    </table>

    <h3>ที่ตั้งสถานที่</h3>
    <table width="100%" style="margin-left:3%;font-family:'Taviraj';font-size:20px">
        <tr>
            <td width="15%">รหัสประจำบ้าน</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.HOUSENO" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" />&nbsp;(หมายเหตุ สามารถดึงได้ทีละเลข)</td>
        </tr>
        <tr>
            <td width="15%">เลขที่</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thaaddr" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
        <tr>
            <td width="15%">อาคาร/ตึก</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thabuilding" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" />&nbsp;*กรุณากรอกคำว่า "อาคาร" เช่น อาคาร 1</td>
        </tr>
        <tr>
            <td width="15%">ชั้น</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thafloor" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" />&nbsp;*กรุณากรอกคำว่า "ชั้น" เช่น ชั้น 3</td>
        </tr>
        <tr>
            <td width="15%">ห้อง</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.tharoom" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" />&nbsp;*กรุณากรอกคำว่า "ห้อง" เช่น ห้อง 241</td>
        </tr>
        <tr>
            <td width="15%">หมู่</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thamu" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
        <tr>
            <td width="15%">จังหวัด</td>
            <td>
                <select class=" form-control selectpicker" data-live-search="true" title="---Please Select---" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.chngwtcd" ng-change="Bind_dll_amp(LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.chngwtcd)">
                    <option ng-repeat="x in REF_CHNGWT" value="{{x.chngwtcd}}">{{x.thachngwtnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td width="15%">เขต/อำเภอ</td>
            <td>
                <select class=" form-control selectpicker" data-live-search="true" title="---Please Select---" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.amphrcd" ng-change="Bind_dll_tmb(LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.chngwtcd,LCN.DALCN_LOCATION_ADDRESS.amphrcd)">
                    <option ng-repeat="x in REF_AMP" value="{{x.amphrcd}}">{{x.thaamphrnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td width="15%">แขวง/ตำบล</td>
            <td>
                <select class=" form-control selectpicker" data-live-search="true" title="---Please Select---" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thmblcd">
                    <option ng-repeat="x in REF_TMB" value="{{x.thmblcd}}">{{x.thathmblnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td width="15%">รหัสไปรษณีย์</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.zipcode" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
        <tr>
            <td width="15%">โทรศัพท์</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.tel" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
        <tr>
            <td width="15%">โทรศัพท์มือถือ</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.Mobile" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
        <tr>
            <td width="15%">โทรสาร</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.fax" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" /></td>
        </tr>
        <tr>
            <td width="15%">latitude(ถ้าไม่มีใส่ 0)</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.latitude" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" />&nbsp;(อยู่ในช่วงระหว่าง 5.6166667 - 20.4666667)</td>
        </tr>
        <tr>
            <td width="15%">longitude(ถ้าไม่มีใส่ 0)</td>
            <td><input class="form-control inline" ng-model="LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.longitude" style="width:400px;font-family:'Taviraj';font-size:20px" type="text" />&nbsp;(อยู่ในช่วงระหว่าง 97.3500000 - 105.6166667)</td>
        </tr>
    </table>
    <br />
    <div style="text-align:center">
        <input class="btn btn-lg" type="button" value="บันทึกข้อมูล" ng-click="BTN_SAVE_LOCATION()" />
        <input class="btn btn-lg" type="button" value="กลับหน้าหลัก" ng-click="BTN_BACK_LOCATION()" />
    </div>
</div>