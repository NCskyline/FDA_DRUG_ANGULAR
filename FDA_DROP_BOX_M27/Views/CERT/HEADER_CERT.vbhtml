﻿@Code
    ViewData("Title") = "HEADER_CERT"
End Code


<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/CERT_GMP_CTRL.js"></script>



<div class="ic" ng-controller="CERT_GMP_CTRL" ng-app="ANGULAR_APP">
    <h1></h1>
    <table width="100%" style="font-family:'Taviraj';font-size:22px;">
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
    </div>
    <div class="row" style="padding-top: 30px;">
        <div class="col-sm-6">
            <h1>
                รายการเอกสาร
            </h1>
        </div>
        <div class="col-sm-6" style="text-align:right;margin-bottom:20px;">
            <input type="button" class="btn btn-lg btn-success" ng-click="ADD_FILE_LIST()" value="เพิ่มเอกสารแนบ" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12" style="width:100%">
            <div class="card" ng-repeat="datas in DOC_LIST.FILE_LISTs">
                <div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                    หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                </div>
                <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                    หัวข้อเอกสาร (ไม่บังคับแนบ)
                </div>
                <div class="card-body">

                    <table class="table" style="width:100%">
                        <tr>
                            <td colspan="5">
                                {{datas.DES}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width:15%;"><input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                            <td style="width:10%;">ชื่อไฟล์</td>
                            <td style="width:50%;">{{datas.FILENAME}}</td>
                            <td style="width:5%">
                                <a ng-click="OPEN_DOC_PATH(datas.PATH)">{{datas.FLAG}}</a>
                            </td>
                            <td style="width:20%; text-align: right;">
                                <input type="button" ng-click="UPLOAD_PDFs(datas)" value="บันทึก" />
                                <input type="button" ng-click="deleteRow(datas,$index)" value="ลบ" />
                            </td>
                        </tr>

                    </table>
                </div>

            </div>
        </div>
    </div>

    <br />
    <div style="text-align:center">
        <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
        <input type="button" class="btn btn-lg" ng-click="BTN_SAVE()" value="บันทึก" />
    </div>

</div>