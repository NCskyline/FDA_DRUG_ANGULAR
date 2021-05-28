@*@Code
    Layout = ""
End Code*@

<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>

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



<div ng-controller="DH_CTRL" ng-app="ANGULAR_APP" ng-init="pageloadDH('31')">
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:25px;">
        <tr>
            <td width="20%" align="right">
                ข้าพเจ้า
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;" align="center">
                testtttttttttttttttttttttttt
            </td>
            <td>
                ผู้รับอนุญาต
            </td>
        </tr>
    </table>
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:25px;">
        <tr>
            <td width="25%">
                <form name="myForm" >
                    <label>
                        <input type="radio" ng-model="LCN.TYPE" value="1">
                        ผลิต
                    </label>
                    <label>
                        <input type="radio" ng-model="LCN.TYPE" value="2">
                        นำหรือสั่ง เข้ามาในราชอาณาจักร ซึ่งยาแผนปัจจุบัน
                    </label>
                </form>
            </td>
            <td align="right">
                ใบอนุญาต เลขที่
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <span style="padding-left:5px;" />  TESTTTTTTTTTTTTTTTTTTTTTT
            </td>
        </tr>

    </table>
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:25px;">
        <tr>
            <td width="8%">อยู่เลขที่ </td>
            <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                dddddddddddddddddd
            </td>
        </tr>
        <tr>
            <td>หมายเลขโทรศัพท์ </td>
            <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                1234556 มีความประสงค์ขอ
            </td>
        </tr>
    </table>
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:25px;">
        <tr>
            <td width="25%">
                <form name="myForm" >
                    <label>
                        <input type="radio" ng-model="LCN.TYPE" value="1">
                        ผลิต
                    </label>
                    <label>
                        <input type="radio" ng-model="LCN.TYPE" value="2">
                        นำหรือสั่งเข้ามาในราชอาณาจักร
                    </label>
                </form>

            </td>
            <td>

                <form name="myForm" >
                    ซึ่ง
                    <label>
                        <input type="radio" ng-model="LCN.TYPE" value="1">
                        เภสัชเคมีภัณฑ์เดี่ยว
                    </label>
                    <label>
                        <input type="radio" ng-model="LCN.TYPE" value="2">
                        เภสัชเคมีภัณฑ์กึ่งสำเร็จรูป
                    </label>
                </form>
            </td>
        </tr>
    </table>
    มีรายละเอียดดังนี้
    <br />
    <div class="row">
        <div ng-include="INPUT" style="width:100%;"></div>
    </div>
</div>


