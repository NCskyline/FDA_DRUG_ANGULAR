@Code
    ViewData("Title") = "HEADER_CERT"
End Code
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CERT_GMP_CTRL.js"></script>
<div class="ic" ng-controller="CERT_GMP_CTRL" ng-app="ANGULAR_APP">
    <h1></h1>
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:22px;">
        <tr>
            <td width="20%" style="height:25px">
                เลขที่ใบอนุญาต :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label ng-repeat="x in LCN_SHOW">{{x.LCNNO_SHOW}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ประเภท :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label ng-repeat="x in LCN_SHOW">{{x.TYPE_IMPORT}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ชื่อผู้รับอนุญาต :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;padding-top:10px;">
                <label ng-repeat="x in LCN_NAME">{{x.thanm}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                สถานที่ ชื่อ :
            </td>
            
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label ng-repeat="x in LCN_LCT">{{x.thanameplace}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                อยู่เลขที่ : 
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label ng-repeat="x in LCN_LCT">{{x.fulladdr3}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                โทรศัพท์ :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label ng-repeat="x in LCN_LCT">{{x.tel}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                โทรสาร :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label ng-repeat="x in LCN_LCT">{{x.fax}}</label>
            </td>
        </tr>
    </table>
    <div ng-include="">

    </div>
</div>