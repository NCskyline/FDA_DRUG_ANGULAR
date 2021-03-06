@*@Code
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
    <div ng-show="PROCESS_ID == '15'">
        <div>
            <p style="text-align:right;font-size:20px">แบบ ภค.1</p>
            <p style="text-align:right;font-size:20px">Form API-1</p>
        </div>
    </div>
    <center style="font-family:'Taviraj'">
        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2>
        <h2>
            {{HEADER_PROCESS}}
        </h2>
        <h2>
            {{HEADER_PROCESS1}}
        </h2>
    </center>
    <br />
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td width="25%" align="right">
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
    <br />
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td width="45%" align="center">
                <form name="myForm">
                    <label>
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="1">
                        ผลิต
                    </label>
                    <label>&nbsp;&nbsp;&nbsp;</label>
                    <label>
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="2">
                        นำหรือสั่ง เข้ามาในราชอาณาจักร ซึ่งยาแผนปัจจุบัน
                    </label>
                </form>
            </td>
        </tr>
    </table>
    <table width="100%" style="font-family:'Taviraj';font-size:20px">
        <tr>
            <td width="10%">
                ใบอนุญาตเลขที่
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label>{{LIST_DH.LCN_NO_DISPLAY}}</label>
            </td>
        </tr>
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
            <td align="center">
                <form name="myForm">
                    <label>
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="1">
                        ผลิต
                    </label>
                    <label>&nbsp;&nbsp;&nbsp;</label>
                    <label>
                        <input type="radio" ng-model="LIST_DH.CHK_TYPE_LCN" value="2">
                        นำหรือสั่งเข้ามาในราชอาณาจักร
                    </label>
                </form>
            </td>
        </tr>
    </table>
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td align="center">
                <form name="myForm">
                    ซึ่ง<font color="red">*</font>
                    <label>&nbsp;</label>
                    <label>
                        <input type="radio" ng-model="LIST_DH.dh15rqt.CHK_TYPE_CHEMICAL" value="1">
                        เภสัชเคมีภัณฑ์เดี่ยว
                    </label>
                    <label>&nbsp;&nbsp;&nbsp;</label>
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
        <div>
            <table width="100%">
                <tr>
                    <td align="right" width="50%">
                        <input class="form-control" placeholder="ค้นหาสารที่นี่..." ng-model="iowanm" />
                    </td>
                    <td align="left" width="50%">
                        <button class="btn btn-lg" ng-click="BTN_SEARCH_CHEM(iowanm)" value="ค้นหาสารที่นี่">ค้นหาสาร (Search for Substance)</button>
                    </td>
                </tr>
            </table>
        </div>
        <div class="ic">
            <table id="myTable" datatable="ng" class="dataTable" width="100%">
                <thead>
                    <tr>
                        <th width="50%">ชื่อสาร (Substance)</th>
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
                <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i> ก่อนหน้า (Previous)</button>
                <button type="button" class="btn btn-sm" ng-disabled="currentPage >= LIST_CHEM.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป (Next)<i class="fas fa-arrow-right"></i></button>
            </div>
        </div>

        <div>
            <table class="dataTable" width="100%">
                <thead>
                    <tr>
                        <th>ลำดับ</th>
                        <th width="55%">ชื่อสาร (Substance)</th>
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
                       <button class="btn btn-lg" ng-click="BTN_SEARCH_CHEM(iowanm)" value="ค้นหาสารที่นี่">ค้นหาสาร (Search for Substance)</button>
                   </td>
               </tr>
           </table>
       </div>
       <div class="ic">
           <table id="myTable" datatable="ng" class="dataTable" width="100%">
               <thead>
                   <tr>
                       <th width="50%">ชื่อสาร (Substance)</th>
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
               <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>ก่อนหน้า (Previous)</button>
               <button type="button" class="btn btn-sm" ng-disabled="currentPage >= LIST_CHEM.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป (Next)<i class="fas fa-arrow-right"></i></button>
           </div>
       </div>

       <div>
           <table class="dataTable" width="100%">
               <thead>
                   <tr>
                       <th>ลำดับ</th>
                       <th width="55%">ชื่อสาร (Substance)</th>
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
   <div style="text-align:center">
       <input type="button" class="btn btn-lg" style="background-color:#FFD700" ng-click="BTN_BACK()" value="ย้อนกลับ (Back)" />
       <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="BTN_SAVE_DH()" value="บันทึก (Save)" />
   </div>
</div>