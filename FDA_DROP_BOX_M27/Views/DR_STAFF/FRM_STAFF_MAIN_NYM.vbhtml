@Code
    Layout = ""
End Code
<script type="text/javascript">
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        })
</script>

<div >
    <div style="font-family:'Taviraj';width:100%">
        <div class="in">
            <table class="table" width="100%">
                <tr>
                    <td style="font-size:24px;width:30%">
                        <b>ยายกเว้นทะเบียน</b>
                    </td>
                    <td align="center">
                        <select style="width:20%" ng-model="ddl_nym" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                            <option value="1026">นยม1</option>
                            <option value="1027">นยม2</option>
                            <option value="1028">นยม3</option>
                            <option value="1029">นยม4 (รัฐ)</option>
                            <option value="1031">นยม4 (เอกชน)</option>
                        </select>
                    </td>
                    <td width="20%" align="center">
                        <input type="button" class="form-control" value="ค้นหา" ng-click="BTN_SEARCH_NYM(ddl_nym)" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div class="in">
            <div ng-show="ddl_nym == '1027'">
                <h1>นยม. 2</h1>
                <div class="row">
                    <div class="col-sm-12" style="width:100%;">
                        <div class="card" style=" border-top: 10px solid #F9D027;">
                            <table width="100%" style="font-family: 'Taviraj'" class="table" id="myTable" datatable="ng">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>วันเวลาที่ส่งคำขอ</td>
                                        <td>รหัสบัญชีรายการยา</td>
                                        <td>ชื่อยา (Th/Eng)</td>
                                        <td>เลขดำเนินการ</td>
                                        <td>สถานะ</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat="data in DATA_NYM_STAFF">
                                        <td>{{data.NYM2_DATE_TOP}}</td>
                                        <td>{{data.RCVNO_DISPLAY}}</td>
                                        <td>{{data.NYM2_WISH_MED}}</td>
                                        <td>{{data.TR_ID_FORMAT}}</td>
                                        <td>{{data.STATUS_NAME}}</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="">
                                                ดูข้อมูล
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
                </div>
            </div>
            <div ng-show="ddl_nym == '1028'">
                <h1>นยม. 3</h1>
                <div class="row">
                    <div class="col-sm-12" style="width:100%;">
                        <div class="card" style=" border-top: 10px solid #F9D027;">
                            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>วันเวลาที่ส่งคำขอ</td>
                                        <td>รหัสบัญชีรายการยา</td>
                                        <td>ชื่อยา (Th/Eng)</td>
                                        <td>เลขดำเนินการ</td>
                                        <td>สถานะ</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat="data in DATA_NYM_STAFF">
                                        <td>{{data.NYM3_DATE_TOP}}</td>
                                        <td>{{data.RCVNO_DISPLAY}}</td>
                                        <td>{{data.NYM3_WISH_MED}}</td>
                                        <td>{{data.TR_ID_FORMAT}}</td>
                                        <td>{{data.STATUS_NAME}}</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="">
                                                ดูข้อมูล
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
                </div>
            </div>
            <div ng-show="ddl_nym == '1029'">
                <h1>นยม4 (รัฐ)</h1>
                <div class="row">
                    <div class="col-sm-12" style="width:100%;">
                        <div class="card" style=" border-top: 10px solid #F9D027;">
                            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>วันเวลาที่ส่งคำขอ</td>
                                        <td>รหัสบัญชีรายการยา</td>
                                        <td>ชื่อยา (Th/Eng)</td>
                                        <td>เลขดำเนินการ</td>
                                        <td>สถานะ</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat="data in DATA_NYM_STAFF">
                                        <td>{{data.NYM4_DATE_TOP}}</td>
                                        <td>{{data.RCVNO_DISPLAY}}</td>
                                        <td>{{data.NYM4_WISH_MED}}</td>
                                        <td>{{data.TR_ID_FORMAT}}</td>
                                        <td>{{data.STATUS_NAME}}</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="">
                                                ดูข้อมูล
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
                </div>
            </div>
            <div ng-show="ddl_nym == '1031'">
                <h1>นยม. 4 (เอกชน)</h1>
                <div class="row">
                    <div class="col-sm-12" style="width:100%;">
                        <div class="card" style=" border-top: 10px solid #F9D027;">
                            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>วันเวลาที่ส่งคำขอ</td>
                                        <td>รหัสบัญชีรายการยา</td>
                                        <td>ชื่อยา (Th/Eng)</td>
                                        <td>เลขดำเนินการ</td>
                                        <td>สถานะ</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat="data in DATA_NYM_STAFF">
                                        <td>{{data.NYM4_COMPANY_DATE_TOP}}</td>
                                        <td>{{data.RCVNO_DISPLAY}}</td>
                                        <td>{{data.NYM4_COMPANY_WISH_MED}}</td>
                                        <td>{{data.TR_ID_FORMAT}}</td>
                                        <td>{{data.STATUS_NAME}}</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="">
                                                ดูข้อมูล
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
                </div>
            </div>
        </div>
    </div>
</div>
