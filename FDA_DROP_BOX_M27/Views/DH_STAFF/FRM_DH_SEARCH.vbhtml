@Code Layout = "" End Code


<div>
    <H2 style="text-align: center;">ค้นหาเภสัชเคมีภัณฑ์</H2>
</div>
<br />
@*<div class="row">
        <div class="col-sm-12">
            <div class="search-item">
                <input class="search-input" type="text" placeholder="ค้นหา..." ng-model="filter">
                <i class="fa fa-search search-icon"></i>
            </div>
        </div>
    </div>
    <hr />*@
<table width="100%">
    <tr>
        <td style="width:12%">สถานะ</td>
        <td style="width:30%">
            <select style="font-family:'Taviraj';font-size:20px;" ng-model="STATUS_ID">
                <option value="">-- กรุณาเลือกสถานะ --</option>
                <option ng-repeat="x in LIST_STATUS" value="{{x.STATUS_ID}}">{{x.STATUS_NAME}}</option>
            </select>
        </td>
        <td width="2%"></td>
        <td style="width:12%">เลขดำเนินการ</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="TR_ID"></td>
    <tr>
        <td style="width:12%">เลข DRM</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="DRM"></td>
        <td width="2%"></td>
        <td style="width:12%">ชื่อสาร</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="iowanm"></td>
    </tr>
</table>
<br />
<table width="100%">
    <tr>
        <td colspan="6" align="center">
            <input class="btn btn-lg" type="button" value="ค้นหา" ng-click="BTN_SEARCH_DH_STAFF(STATUS_ID,TR_ID, DRM, iowanm)" style="width:150px;height:40px;" />
        </td>
    </tr>
</table>
<br />
<div class="row">
    <div class="col-sm-12">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table style="margin-top:10px;width:100%;" class="table table-condensed">
                <thead>
                    <tr>
                        <th style="width:8%">เลข DRM</th>
                        <th style="width:20%">ชื่อสาร</th>
                        <th style="width:10%">เลขที่คำขอ</th>
                        <th style="width:10%">วันที่ยื่นคำขอ</th>
                        <th style="width:5%">สถานะ</th>
                        <th style="width:20%">รหัสการดำเนินการ</th>
                        <th style="width:5%"></th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in LIST_DRM">
                        <td>{{data.phm15dgt}}</td>
                        <td>{{data.CAS_NAME}}</td>
                        <td>{{data.rcvno}}</td>
                        <td>{{data.rcvdate}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>{{data.TR_ID}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click>
                                ดูข้อมูล
                            </a>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr></tr>
                </tfoot>
            </table>
            <hr />
            @*<uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                boundary-link-numbers="true" rotate="false" max-size="maxSize">
                </uib-pagination>
                <div align="right">
                    <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>  ก่อนหน้า</button>
                    <button type="button" class="btn btn-sm" ng-disabled="currentPage >= LIST_DRM.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
                </div>*@
        </div>
    </div>
</div>