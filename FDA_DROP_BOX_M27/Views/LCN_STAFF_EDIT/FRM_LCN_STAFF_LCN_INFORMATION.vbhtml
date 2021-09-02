<script>

</script>
<style>
</style>
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_STAFF_EDIT_CTRL.js"></script>
<div ng-controller="LCN_STAFF_EDIT_CTRL" ng-app="ANGULAR_APP" class="ic" ng-init="pageload()">
    <div style="font-family:'Taviraj';font-size:20px;">
        <h1>รายละเอียดใบอนุญาต</h1>
        <table style="width:100%">
            <tr>
                <td style="width:10%">
                    เลขอนุญาต :
                </td>
                <td style="width:20%">
                    {{LCNNO_SHOW}}
                </td>
                <td>
                    เลขบัตรปชช.ผู้รับอนุญาต :
                </td>
                <td>
                    {{CITIZEN_ID_AUTHORIZE}}
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อสถานที่ :
                </td>
                <td>
                    {{thanameplace}}
                </td>
                <td style="width:20%">
                    ชื่อผู้ดำเนินกิจการ :
                </td>
                <td>
                    {{BSN_THAIFULLNAME}}
                </td>
            </tr>
        </table>
        <br />

        <h1>สถานะใบอนุญาต</h1>
        <table style="width:100%" @*border="1"*@>
            <tr>
                <td style="width:20%">
                    สถานะปัจจุบัน :
                </td>
                <td>
                    {{INFO_LIST.cncnm}}
                </td>
            </tr>
            <tr>
                <td>
                    วันที่มีผล :
                </td>
                <td>
                    {{INFO_LIST.date_cancel}}
                </td>
            </tr>
            <tr>
                <td>
                    วันที่ออกให้ครั้งแรก :
                </td>
                <td>
                    {{first_appdate}}
                </td>
            </tr>
        </table>
        <br />

        <h1>การขอเปลี่ยนแปลงสถานะ </h1>
        <table style="width:100%" @*border="1"*@>
            <tr>
                <td style="width:20%">
                    เลือกสถานะใหม่ :
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:18px;" class="form-control inline" ng-model="INFO_LIST.dalcn.cnccscd">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in CNC_LIST" value="{{x.cscd}}">{{x.csnm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    เลือกวันที่มีผล :
                </td>
                <td>
                    <md-datepicker ng-model="INFO_LIST.dalcn.cncdate" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
            </tr>
        </table>
        <input type="button" value="เปลี่ยนสถานะ" style="margin-left:20%" />
        <br />

        <h1>เวลาทำการ</h1>
        <table style="width:100%" @*border="1"*@>
            <tr>
                <td style="width:20%">
                    เวลาทำการ :
                </td>
                <td>
                    {{INFO_LIST.dalcn.opentime}}
                </td>
            </tr>
            <tr>
                <td>
                    รูปแบบบ้านเลขที่ในไฟล์ pdf:
                </td>
                <td>
                    <select style="width:30%">
                        <option>
                            เเบบปกติ
                        </option>
                        <option>
                            เเบบบ้านเลขที่ยาว
                        </option>
                    </select>
                    <input type="button" value="เปลี่ยนรูปแบบ pdf" style="width:17%" />
                </td>
            </tr>
        </table>
        <br />

        <h1>แก้ไขวันที่ให้ไว้ ณ และปีที่หมดอายุ</h1>
        <table style="width:100%" @*border="1"*@>
            <tr>
                <td style="width:20%">
                    วันที่ให้ไว้ ณ :
                </td>
                <td>
                    <md-datepicker ng-model="INFO_LIST.dalcn.appdate" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                    <input type="button" value="เปลี่ยนวันที่ให้ไว้ ณ" style="margin-left:.5%;width:17%" />
                </td>
            </tr>
            <tr>
                <td>
                    ปีที่หมดอายุ :
                </td>
                <td>
                    <input style="width:30%" ng-model="INFO_LIST.dalcn.expyear" /><input type="button" value="เปลี่ยนปีที่หมดอายุ" style="margin-left:.5%;width:17%" />
                </td>
            </tr>
        </table>
        <br />

        <h1>รูปถ่ายที่แนบในใบอนุญาต</h1>
        <div>

            <img data-ng-src="data:image/png;base64,{{INFO_LIST.dalcn.IMAGE_BSN}}" width="20%" height="20%" />

        </div>
        <table>
            <tr>
                <td>
                    <input type="button" value="Chosse File" />
                </td>
                <td>
                    <span>No file choses</span>
                </td>
                <td>
                    <input type="button" value="Upload Photo" />
                </td>
            </tr>


        </table>
        <br />

        <h1>รายละเอียดสถานที่ตั้ง</h1>


        <div>
            <table width="100%">
                <tr>
                    <td style="text-align:right;">
                        <input type="button" value="เลือกสถานที่ตั้ง" class="btn btn-sm">
                    </td>
                </tr>
            </table>

            @*<table style="width:100%" border="1">
                <tr style="background-color:#8CB340">
                    <td style="width:15%">
                        <span style="margin-left:5%">ชื่อสถานที่</span>
                    </td>
                    <td>
                        <span style="margin-left:2%">ที่อยู่ตามทะเบียนราษฎร์</span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span style="margin-left:5%"> text</span>
                    </td>
                    <td>
                        <span style="margin-left:2%"> text</span>
                    </td>
                </tr>
            </table>*@
            <div class="row">
                <div class="col-sm-12">
                    <div class="card" style=" border-top: 10px solid #277210;">
                        <table style="margin-top:10px;width:100%;" class="table table-condensed">
                            <thead>
                                <tr>
                                    <th>ชื่อสถานที่</th>
                                    <th>ที่อยู่ตามทะเบียนราษฎร์</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="cc in DATA_LCT | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                                    <td>{{cc.thanameplace}}</td>
                                    <td>{{cc.fulladdr}}</td>
                                </tr>
                            </tbody>
                        </table>
                        <hr />
                        <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                        ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                        boundary-link-numbers="true" rotate="false" max-size="maxSize">
                        </uib-pagination>
                        @*<div align="right">
                            <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>  ก่อนหน้า</button>
                            <button type="button" class="btn btn-sm" ng-disabled="currentPage >= DATA_LCT.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
                        </div>*@
                    </div>
                </div>
            </div>




            <p>*หมายเหตุ หากมีการเพิ่มสถานที่ตั้งใหม่ ระบบจะทำการผูกกับใบอนุญาตให้อัติโนมัติ</p>
            <br />

            <h1>รายละเอียดสถานที่เก็บ(ถ้ามี)</h1>

            <table width="100%">
                <tr>
                    <td style="text-align:right;">
                        <input type="button" value="เลือกสถานที่เก็บ" class="btn btn-sm">
                        <input type="button" value="เพิ่มสถานที่เก็บใหม่" class="btn btn-sm">
                    </td>

                </tr>
            </table>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #277210;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>ชื่อสถานที่เก็บ</th>
                                <th>ที่อยู่</th>

                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="datas in DATA_KEEP | filter : filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">

                                <td>{{datas.thanameplace}}</td>
                                <td>{{datas.fulladdr}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        ลบข้อมูล
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
                        <button type="button" class="btn btn-sm" ng-disabled="currentPage >= DATA_KEEP.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
                    </div>
                </div>
            </div>
        </div>
        <p>*หมายเหตุ เมื่อเพิ่มสถานที่เก็บใหม่ จะต้องทำการเลือกสถานที่เก็บทุกครั้ง ข้อมูลถึงจะเปลี่ยนตามที่เพิ่มเข้าไปใหม่</p>
        <br />

        <h1>รายละเอียดผู้ดำเนินกิจการ</h1>

        <table width="100%">
            <tr>
                <td style="text-align:right;">
                    <input type="button" value="เปลี่ยนผู้ดำเนินกิจการ" class="btn btn-sm">
                </td>
            </tr>
        </table>
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #277210;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>ชื่อผู้ดำเนินกิจการ</th>
                                <th>ที่อยู่</th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="cc in DATA_BSN | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                                <td>{{cc.BSN_THAIFULLNAME}}</td>
                                <td>{{cc.fulladdr}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        อัพเดทข้อมูล
                                    </a>
                                </td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        แก้ไขข้อมูลชื่อ-ที่อยู่เอง
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

                </div>
            </div>
        </div>
        <br />

        <h1>รายละเอียดผู้รับอนุญาต</h1>

        <table width="100%">
            <tr>
                <td style="text-align:right;">
                    <input type="button" value="เปลี่ยนผู้รับอนุญาต" class="btn btn-sm">
                </td>
            </tr>
        </table>
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #277210;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>เลขนิติบุคคล</th>
                                <th>ชื่อผู้รับอนุญาต</th>
                                <th></th>

                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="cc in DATA_LCNS | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                                <td>{{cc.identify}}</td>
                                <td>{{cc.thanm}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        อัพเดทข้อมูล
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

                </div>
            </div>
        </div>
        <br />

        <h1>รายละเอียดผู้มีหน้าที่ปฏิบัติการ</h1>
        <table width="100%">
            <tr>
                <td style="text-align:right;">
                    <input type="button" value="เพิ่มผู้ที่มีหน้าที่ปฏิบัติ" class="btn btn-sm">
                </td>
            </tr>
        </table>
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #277210;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>เลขบัตรปชช.</th>
                                <th>ชื่อผู้มีหน้าที่ปฏิบัติการ</th>
                                <th>เวลาทำการ</th>
                                <th>หน้าที่</th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="cc in DATA_PHR | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                                <td>{{cc.PHR_CTZNO}}</td>
                                <td>{{cc.PHR_FULLNAME}}</td>
                                <td>{{cc.PHR_TEXT_WORK_TIME}}</td>
                                <td>{{cc.functnm}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="">
                                        อัพเดทข้อมูล
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

                </div>
            </div>
        </div>
        <br />

    </div>
    </div>
</div>