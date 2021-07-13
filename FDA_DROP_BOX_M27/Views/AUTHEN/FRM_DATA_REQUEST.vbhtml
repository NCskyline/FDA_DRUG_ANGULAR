@Code
'Layout = ""
End Code



<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN_STAFF_CTRL.js"></script>



<div ng-controller="AUTHEN_STAFF_CTRL" ng-app="ANGULAR_APP">
    <div class="ic">
        <div>
            <div class="row">
                <div class="col-sm-12 set-topic">
                    <h2>รายการชี้แจงคำขอโฆษณา ทั่วไป : ทางสื่อสิ่งพิมพ์,วิทยุกระจายเสียง,วิทยุโทรทัศน์ เเละสื่ออื่นๆ</h2>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-sm-3 set-topic">
                    รายละเอียดการชี้แจง :
                </div>
                <div class="col-sm-9">
                    <textarea class="form-control" ng-model="DES" style="width:100%"></textarea>
                </div>
            </div>
            <br />
            @*<div class="row">
                <div class="col-sm-3 set-topic">
                    กำหนดส่งเอกสาร :
                </div>
                <div class="col-sm-9">
                    <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">

                    </md-datepicker>
                </div>
            </div>*@
        </div>

        <div class="row" style="padding-top: 30px;">
            <div class="col-sm-6">
                <h1>
                    รายการเอกสารชี้แจง
                </h1>
            </div>
            <div class="col-sm-6" style="text-align:right;margin-bottom:20px;">
                <input type="button" class="btn btn-lg btn-success" ng-click="ADD_FILE_LIST()" value="เพิ่มเอกสารแนบ" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12" style="width:100%">
                <div class="card" ng-repeat="datas in DOC_LIST.FILE_LISTs">
                    <div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                        หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                    </div>
                    <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                        หัวข้อเอกสาร (ไม่บังคับแนบ)
                    </div>
                    <div class="card-body">

                        <table class="table" style="width:100%">
                            <tr>
                                <td colspan="5">
                                    {{datas.DES}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%;"><input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                                <td style="width:10%;">ชื่อไฟล์</td>
                                <td style="width:50%;">{{datas.FILENAME}}</td>
                                <td style="width:5%">
                                    <a ng-click="OPEN_DOC_PATH(datas.PATH)">{{datas.FLAG}}</a>
                                </td>
                                <td style="width:20%; text-align: right;">
                                    <input type="button" ng-click="UPLOAD_PDFs(datas)" value="บันทึก" />
                                    <input type="button" ng-click="deleteRow(datas,$index)" value="ลบ" />
                                </td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
            <div class="col-sm-12" style="text-align:center;margin-bottom:20px;">
                <input type="button" class="btn btn-lg btn-success" ng-click="ADD_DATA()" value="บันทึก" />
            </div>
        </div>
    </div>
</div>