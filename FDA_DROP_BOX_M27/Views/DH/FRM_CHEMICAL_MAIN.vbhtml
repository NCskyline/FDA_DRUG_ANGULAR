@Code
    Layout = ""
End Code

<div><h3 style="color:red">{{HEADER}}</h3></div>
<div align="right">
    <button ng-click="ADD_CHEMICAL()">เพิ่มสาร</button>
</div>
<hr />
<div class="row">
    <div class="col-sm-12">
        <div class="card" style=" border-top: 10px solid #277210;">
            <table style="margin-top:10px;width:100%;" class="table table-condensed">
                <thead>
                    <tr>
                        <th>เลขรับ</th>
                        <th>ชื่อสาร</th>
                        <th>สถานะ</th>
                        <th>iowa</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="datas in DATA_CHEMICAL">

                        <td>{{datas.RCVNO}}</td>
                        <td>{{datas.iowanm}}</td>
                        <td>{{datas.STATUS_NAME}}</td>
                        <td>{{datas.iowacd}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="SELECT_CER(datas,'12')">
                                เลือก
                            </a>
                        </td>
                    </tr>
                </tbody>
                <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                boundary-link-numbers="true" rotate="false" max-size="maxSize">
                </uib-pagination>
            </table>
        </div>
    </div>
</div>

