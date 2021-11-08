﻿@Code
    Layout = ""
End Code

<div style="font-family:'Taviraj';width:100%">
    <div><h3 style="color:red">{{HEADER}}</h3></div>
    <div>
        @*<table>
            <tr>
                <td>เลขที่ใบอนุญาต (License Number)</td>
                <td>{{LCNNO_NO}}</td>
            </tr>
            <tr>
                <td>ชื่อผู้รับอนุญาต (License Name)</td>
                <td>{{nameOperator}}</td>
            </tr>
            <tr>
                <td>ชื่อสถานที่ (Establishment Name)</td>
                <td>{{thanameplace}}</td>
            </tr>
        </table>
        <hr />*@
        <table style="width:100%">
            <tr>
                <td style="width:100%"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
                <td align="right"><button class="btn btn-lg" ng-click="INPUT_RECLASS()">สร้างคำขอ</button></td>
            </tr>
        </table>
        <br />
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>
                                    รหัสดำเนินการ
                                </th>
                                <th>
                                    เลขรับที่
                                </th>
                                <th>
                                    เลขทะเบียน
                                </th>
                                <th>
                                    ชื่อยา
                                </th>
                                <th>
                                    สถานะ
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="datas in DATA_RECLASS | filter : filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">

                                <td>{{datas.TR_ID}}</td>
                                <td>{{datas.RCVNO_DISPLAY}}</td>
                                <td>{{datas.RGTNO_DISPLAY}}</td>
                                <td>{{datas.DRUG_NAME}}</td>
                                <td>{{datas.STATUS_NAME}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_RECLASS(datas)">
                                        เลือก
                                    </a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <hr />
                    <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                    ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                    boundary-link-numbers="true" rotate="false" max-size="maxSize">
                    </uib-pagination>
                    <div align="right">
                        <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>  ก่อนหน้า</button>
                        <button type="button" class="btn btn-sm" ng-disabled="currentPage >= DATA_RECLASS.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>