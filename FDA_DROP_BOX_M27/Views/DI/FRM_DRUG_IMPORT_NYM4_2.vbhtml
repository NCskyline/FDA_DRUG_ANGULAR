﻿@Code
    Layout = ""
End Code

    <div>
        <div class="ic" style="font-family:'Taviraj';width:100%">
            <div>
                <table class="table" width="100%">
                    <tr>
                        <td align="right">
                            <input style="width:30%" type="button" class="form-control" value="สร้างคำขอ" />
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
                                    <td>วันเวลาที่ส่งคำขอ</td>
                                    <td>ประเภท</td>
                                    <td>รหัสบัญชีรายการยา</td>
                                    <td>ชื่อยา (Th/Eng)</td>
                                    <td>เลขดำเนินการ</td>
                                    <td>สถานะ</td>
                                    <td></td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td></td>
                                    <td>นยม4</td>
                                    <td>DL-64-01257</td>
                                    <td>พาราทดสอบ</td>
                                    <td>640000987</td>
                                    <td>ชำระเงิรแล้ว รอรับคำขอ</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_DI()">
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
            <div align="right">
                <a ng-click="BTN_PAYMENT()">ชำระเงิรคลิ๊กที่นี่</a>
            </div>
        </div>
    </div>