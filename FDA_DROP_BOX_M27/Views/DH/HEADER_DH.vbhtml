﻿@*@Code
    Layout = ""
End Code*@

<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>

@*<script>
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
</script>*@



<div class="ic" ng-controller="DH_CTRL" ng-app="ANGULAR_APP" ng-init="pageloadDH()">
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td width="20%" align="right">
                ข้าพเจ้า
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;" align="center">
                <label>{{LIST_DH.NAME}}</label>
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
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="1">
                        ผลิต
                    </label>
                    <label>
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="2">
                        นำหรือสั่ง เข้ามาในราชอาณาจักร ซึ่งยาแผนปัจจุบัน
                    </label>
                </form>
            </td>
            <td align="right" width="10%">
                ใบอนุญาต เลขที่
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <span style="padding-left:5px;" /><label>{{LIST_DH.LCN_NO_DISPLAY}}</label>
            </td>

        </tr>
    </table>
    <br />
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td width="10%">อยู่เลขที่ </td>
            <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{LIST_DH.FULL_ADDR}}</label>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>หมายเลขโทรศัพท์ </td>
            <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{LIST_DH.TEL}}</label>
            </td>
            <td>มีความประสงค์ขอ</td>
        </tr>
    </table>
    <br />
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td width="25%">
                <form name="myForm">
                    <label>
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="1">
                        ผลิต
                    </label>
                    <label>
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="2">
                        นำหรือสั่งเข้ามาในราชอาณาจักร
                    </label>
                </form>

            </td>
            <td>

                <form name="myForm">
                    ซึ่ง
                    <label>&nbsp;</label>
                    <label>
                        <input type="radio" ng-model="LIST_DH.dh15rqt.CHK_TYPE_CHEMICAL" value="1">
                        เภสัชเคมีภัณฑ์เดี่ยว
                    </label>
                    <label>&nbsp;&nbsp;</label>
                    <label>
                        <input type="radio" ng-model="LIST_DH.dh15rqt.CHK_TYPE_CHEMICAL" value="2">
                        เภสัชเคมีภัณฑ์กึ่งสำเร็จรูป
                    </label>
                </form>
            </td>
        </tr>
    </table>
    <div style="font-family:'Taviraj';font-size:20px;">มีรายละเอียดดังนี้</div>
    <br />

    <div class="row">
        <div ng-include="INPUT" style="width:100%;"></div>
    </div>
    <div ng-show="PROCESS_ID == '14' || PROCESS_ID == '15'">
        <div class="ic">
            <table id="myTable" datatable="ng" class="dataTable" width="100%">
                <thead>
                    <tr>
                        <th>ชื่อสาร</th>
                        <th>A or I</th>
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

   <div ng-show="PROCESS_ID == '16'">
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
                            <th>A or I</th>
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
            <br />
        </div>
        <div style="text-align:center">
            <input type="button" class="btn btn-lg" ng-click="BTN_SAVE_DH()" value="บันทึก" />
            <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
        </div>
    </div>
