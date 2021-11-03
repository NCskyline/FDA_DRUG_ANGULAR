@Code
    Layout = ""
End Code

<h2>บัญชีรายการยา</h2>
<div class="ic">
    <div class="row">
        <div class="col-sm-12">
            <div>
                <table width="100%" style="font-family:'Taviraj';font-size:medium">
                    <tr>
                        <td style="width:80%">
                            <b>License number :</b>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b>ชื่อสถานที่ :</b>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b>ชื่อผู้ดำเนินการ :</b>
                        </td>
                        <td></td>
                        <td align="right">
                            <input class="form-control" style="color:white;background-color:#38A86B" type="button" value="สร้างชื่อตำรับ" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <br/>
    <div >
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    <table class="table" width="100%" style="font-family:'Taviraj'">
                        <tr>
                            <td>เลขที่ตำรับ</td>
                            <td>วันที่สร้างตำรับ</td>
                            <td>ชื่อตำรับ (ภาษาไทย)</td>
                            <td>ชื่อตำรับ (ภาษาอังกฤษ)</td>
                            <td>เลขดำเนินการ</td>
                            <td>เพิ่มข้อมูลส่วนที่ 2</td>
                            <td>ดูข้อมูล/ยื่นคำขอ</td>
                            <td>เลือกข้อมูล</td>
                        </tr>
                        <tr ng-repeat="datas in DL_List">
                            <td>{{datas.RCVNO_DISPLAY}}</td>
                            <td>{{datas.rcvdate}}</td>
                            <td>{{datas.DRUG_NAME_THAI}}</td>
                            <td>{{datas.DRUG_NAME_OTHER}}</td>
                            <td>{{datas.TR_ID}}</td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

