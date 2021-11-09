@Code
    ViewData("Title") = "FRM_SEARCH_LCN_TO_DL"
End Code

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DI_CTRL.js"></script>

<div ng-app="ANGULAR_APP" ng-controller="DI_CTRL">
    <div class="ic" style="font-family:'Taviraj';width:100%">
        <div>
            <table class="table" width="100%">
                <tr>
                    <td width="30%">โปรดเลือกเลขที่ใบอนุญาต</td>
                    <td width="30%" align="right">
                        <select class="form-control" style="font-family:'Taviraj'" >
                            <option>ผย1 999/2563</option>
                        </select>
                    </td>
                    <td align="left">
                        <input style="width:30%" type="button" class="form-control" value="ค้นหา" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <td>เลขที่ตำรับ</td>
                                <td>วันที่สร้างตำรับ</td>
                                <td>ชื่อตำรับ (ภาษาไทย)</td>
                                <td>ชื่อตำรับ (ภาษาอังกฤษ)</td>
                                <td>เลขดำเนินการ</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>DL-64-01257</td>
                                <td>16/8/2564</td>
                                <td>พาราทดสอบ</td>
                                <td></td>
                                <td>640000987</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_DL(datas)">
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
