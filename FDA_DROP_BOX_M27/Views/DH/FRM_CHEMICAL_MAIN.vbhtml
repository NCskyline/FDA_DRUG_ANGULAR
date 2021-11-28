@Code Layout = "" End Code

<div><h3 style="color:red">{{HEADER}}</h3></div>
<div>

</div>
<hr />
<table style="width:100%">
    <tr>
        <td style="width:100%"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
        <td align="right"><button class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="ADD_CHEMICAL()">เพิ่มสาร (Add Substance)</button></td>
    </tr>
</table>
<br />
<div class="row">
    <div class="col-sm-12">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table style="margin-top:10px;width:100%;" class="table table-condensed">
                <thead>
                    <tr>
                        <th>เลขรับ</th>
                        <th>
                            ชื่อสาร<br />
                            Substance
                        </th>
                        <th>
                            สถานะ<br />
                            Status
                        </th>
                        <th>
                            รหัสสาร<br />
                            Code
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="datas in DATA_CHEMICAL | filter : filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">

                        <td>{{datas.RCVNO}}</td>
                        <td>{{datas.iowanm}}</td>
                        <td>{{datas.STATUS_NAME}}</td>
                        <td>{{datas.iowa}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="EDIT_CHEM(datas.IDA)">
                                แก้ไข/ดูข้อมูล
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
                <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>ก่อนหน้า (Previous)</button>
                <button type="button" class="btn btn-sm" ng-disabled="currentPage >= DATA_CHEMICAL.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป (Next)<i class="fas fa-arrow-right"></i></button>
            </div>
        </div>
    </div>
</div>
<div align="right">
    <a ng-click="BTN_PAYMENT()" style="color:blue">กดที่นี่เพื่อชำระเงิน</a>
</div>
