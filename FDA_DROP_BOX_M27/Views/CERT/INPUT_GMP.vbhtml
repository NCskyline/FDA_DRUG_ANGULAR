@Code
    Layout = ""
End Code
<script>
    angular.module('radioExample', [])
        .controller('ExampleController', ['$scope', function ($scope) {
            $scope.color = {
                name: 'blue'
            };
            $scope.specialValue = {
                "id": "12345",
                "value": "green"
            };
        }]);
</script>
<div class="ic" >
    <h2 style="font-family:'TH SarabunPSK';font-size:24px;">
        <b> แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ</b>
    </h2>
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:20px;" >
        <tr>
            <td style="height:25px;width:35%;">
                1. เลขที่ใบรับรอง (Certificate Number)<font color="red">*</font>  :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.Certificate_Number" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.Manufacturer" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                3. ที่อยู่ (Address)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.Address" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                4. เมือง (City / Province/ State)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.Province" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                5. ประเทศ (Country<font color="red">*</font> :
            </td>
            <td>
                <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_GMP.Country">
                    <option value="0">--กรุณาเลือก--</option>
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                รหัสไปรษณีย์ (Post code/Zip code) :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.Zipcode" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                6. Manufacturer&quot;s License Number :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.Manufacturer_License" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                Global Location Number (GLN) :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                7. วันเดือนปีที่ออกหนังสือ GMP (Issue Date)<font color="red">*</font> :
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.MFD_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.EXP_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                8. หน่วยงานที่ออกใบรับรอง<font color="red">*</font>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:CheckBox ID="cb_DEPARTMENT_REGIST_CER_TYPE" runat="server" Text="ชื่อหน่วยงานรัฐของประเทศผู้ผลิต" />
            </td>
            <td class="auto-style1">
                <asp:Label ID="lbl_DEPARTMENT_REGIST_CER_NAME" runat="server" Text="-"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                <asp:CheckBox ID="cb_DEPARTMENT_REGIST_CER_TYPE2" runat="server" Text="ชื่อหน่วยงานอื่นที่ได้รับการรับรองจากหน่วยงานรัฐของประเทศผู้ผลิต" />
            </td>
            <td>
                <asp:Label ID="lbl_DEPARTMENT_REGIST_CER_NAME2" runat="server" Text="-"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                9. สถานที่ผลิตได้มาตรฐาน GMP ตาม<font color="red">*</font> :

            </td>
            <td>
                <table>
                    <tr>
                        <td style="height:25px">
                            <form name="rdl_gmp">
                                <label>
                                    <input type="radio" ng-model="color.name" value="1">
                                    PIC / S GMP
                                </label>
                                <label>
                                    <input type="radio" ng-model="color.name" ng-value="2">
                                    WHO GMP
                                </label>
                                <label>
                                    <input type="radio" ng-model="color.name" value="3">
                                    National GMP
                                </label>
                            </form>
                        </td>
                        <td>
                            &nbsp; ประเทศ<font color="red">*</font>
                        </td>
                        <td>
                            <select style="font-family:'TH SarabunPSK';font-size:20px;">
                                <option value="0">--กรุณาเลือก--</option>
                                <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                            </select>
                            @*&nbsp;
                            <asp:Label ID="lbl_iso_gmp" runat="server" Text="-"></asp:Label> &nbsp;*@
                        </td>
                    </tr>
                </table>


            </td>
        </tr>
    </table>
    <br />
    <h2 style="font-family:'TH SarabunPSK';font-size:24px;">
        <b> รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง </b>
    </h2>
    <table width="100%">
        <tr>
            <td style="height:25px;width:35%;">
                10. ขอบเขตของประเภทยาที่รับรอง
            </td>
            <td>
                <asp:Label ID="lbl_CER_SCOPE" runat="server" Text="-"></asp:Label>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
    </div>