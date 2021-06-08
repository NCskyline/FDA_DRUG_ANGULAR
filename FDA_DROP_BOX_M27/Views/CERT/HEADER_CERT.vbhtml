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
                <label>{{LCNNO_SHOW}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ประเภท :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{TYPE_IMPORT}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ชื่อผู้รับอนุญาต :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;padding-top:10px;">
                <label>{{thanm}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                สถานที่ ชื่อ :
            </td>

            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{thanameplace}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                อยู่เลขที่ :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{fulladdr2}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                โทรศัพท์ :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{tel}}</label>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                โทรสาร :
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{fax}}</label>
            </td>
        </tr>
    </table>
    <div ng-include="INPUT">

    </div>
    <div>
        <div>
            <input class="form-control" ng-model="iowanm" />
            <button class="btn btn-lg" ng-click="BTN_SEARCH_CHEM(iowanm)" value="ค้นหาสารที่นี่"></button>
        </div>
        <div>
            <table style="width:100%;height:200%" border="1" >
                <thead>
                    <tr>
                        <th>ชื่อสาร</th>
                        <th>A or I</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="datas in LIST_CHEM">
                        <th>{{datas.ss}}</th>
                        <th>{{datas.AA}}</th>
                        <th ng-click="BTN_ADD_CHEM(datas.ss,datas.AA)">เลือกสาร</th>
                    </tr>
                </tbody>
            </table>
        </div>
        <div>
            <table>
                <thead>
                    <tr>
                        <th>ลำดับ</th>
                        <th>ชื่อสาร</th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="datas in GMP_CHEM">
                        <th>{{$index + 1}}</th>
                        <th>{{datas.CAS_NAME}}</th>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div style="text-align:center">
        <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
        <input type="button" class="btn btn-lg" ng-click="BTN_SAVE()" value="บันทึก" />
    </div>

</div>