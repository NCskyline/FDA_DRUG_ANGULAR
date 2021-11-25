@Code
    Layout = ""
End Code

<div style="font-family:'Taviraj';width:100%">
    <div><h3 style="color:red"> คำขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์</h3></div>

    <hr />
    <table style="width:100%">
        <tr>
            <td style="width:100%"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
            
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
                                วันที่ล่าสุด
                            </th>
                            <th>
                                จำนวนวันที่ทำงาน
                            </th>
                            <th>
                                ชื่อผู้รับอนุญาต
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
                        @*<tr ng-repeat="datas in DATA_RECLASS | filter : filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">

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
                            </tr>*@
                        <tr>
                            <td>640009999</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>K 1/62 (NC)</td>
                            <td>ทดสอบ4 /test4</td>
                            <td>ชำระเงินแล้ว รอเจ้าหน้าที่ตรวจสอบเอกสาร</td>
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="SELECT_RECLASS(datas)">
                                    ดูข้อมูล
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td>640009999</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>K 1/62 (NC)</td>
                            <td>ทดสอบ4 /test4</td>
                            <td>รับคำขอแล้วรอส่งผู้เชี่ยวชาญพิจารณา</td>
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="SELECT_RECLASS(datas)">
                                    ดูข้อมูล
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td>640009999</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>K 1/62 (NC)</td>
                            <td>ทดสอบ4 /test4</td>
                            <td>ส่งให้ผู้ประกอบการแก้ไขคำขอ</td>
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="SELECT_RECLASS(datas)">
                                    ดูข้อมูล
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td>640009999</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>K 1/62 (NC)</td>
                            <td>ทดสอบ4 /test4</td>
                            <td>อนุมัติ</td>
                            <td>
                                <span class="fa fa-eye"></span>
                                <a ng-click="SELECT_RECLASS(datas)">
                                    ดูข้อมูล
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