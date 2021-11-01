@Code
    Layout = ""
End Code
<div class="ic">
    <div class="panel-heading panel-title" style="padding-left:5%;">
        <h2>ค้นหาข้อมูลบุคคลธรรมดาและนิติบุคคลจากชื่อหรือเลขบัตรประจำตัวประชาชน</h2>
    </div>

    <table class="table" style="width:100%;">
        <tr>
            <td width="50%">กรอกชื่อ - นามสกุล หรือ<br /> เลขบัตรประจำตัวประชาชน<br /> </td>
            <td style="margin-left:0px">
                <input type="text" ng-model="txt_search" />
                <input type="button" value="ตรวจสอบชื่อผู้ยืนคำร้อง" ng-click="BTN_SEARCH_NAME_PRO(txt_search)" />
            </td>
        </tr>
    </table>
</div>
<div class="ic">
    <table id="myTable" datatable="ng" class="dataTable" width="100%">
        <thead>
            <tr>
                <th>ชื่อ - นามสกุล</th>
                <th>เลขบัตรประชาชน</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="datas in LIST_PROFESSIONAL | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                <td>{{datas.tha_fullnm}}</td>
                <td>{{datas.identify}}</td>
                <td>
                    <a ng-click="BTN_ADD_PROFESS(datas)">
                        เลือก
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
        <button type="button" class="btn btn-sm" ng-disabled="currentPage >= LIST_PROFESSIONAL.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
    </div>
</div>

<div>
    <table class="dataTable" width="100%">
        <thead>
            <tr>
                <th>ลำดับ</th>
                <th>ชื่อ - นามสกุล</th>
                <th>เลขบัตรประชาชน</th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="datas in PROFESS_DATA">
                <td>{{$index + 1}}</td>
                <td>{{datas.tha_fullnm}}</td>
                <td>{{datas.identify}}</td>
                <td>
                    <span class="fas fa-edit"></span>
                    <a ng-click="deletePROFESS(datas,$index)">
                        ลบ
                    </a>
                </td>
            </tr>
        </tbody>
        <tfoot>
            <tr></tr>
        </tfoot>
    </table>
</div>
<div style="text-align:center">
    <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
    <input type="button" class="btn btn-lg" ng-click="BTN_SAVE_PROFESS()" value="บันทึก" />
</div>