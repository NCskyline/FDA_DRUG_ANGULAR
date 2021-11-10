@Code
    ViewData("Title") = "FRM_EXTEND_LCN_ATTACH_PAGE"
End Code

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/LCN_CTRL.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>


<div class="ic" ng-app="ANGULAR_APP" ng-controller="LCN_CTRL">
    <div  style="font-family:'Taviraj';width:100%">
        <h1 style="color:red"><b>พิกัด</b></h1>
        <h3>โปรดระบุพิกัดทางภูมิศาสตร์ของที่ตั้งร้านยา (วิธีการดูพิกัด <a ng-click="BTN()" style="color:blue">กดที่นี่</a> )</h3>
        <div>
            <table class="table" width="100%">
                <tr>
                    <td width="30%">latitude (ละติจูด)</td>
                    <td></td>
                </tr>
                <tr>
                    <td>longitude (ลองจิจูด)</td>
                    <td></td>
                </tr>
            </table>
        </div>
        <br />
        <h2><b>เหตุผลการคืนให้แก้ไขคำขอระบบต่ออายุ</b></h2>
        <br />
        <h3 style="color:red"><b>ขั้นตอนการจัดส่งเอกสาร</b></h3>

        <table class="table" width="100%">
            <tr>
                <td>
                    1.พิมพ์ใบปะหน้าซองเพื่อส่งไปรษณีย์ ที่อยู่ อย. (เฉพาะ กทม) ที่นี่
                </td>
            </tr>
            <tr>
                <td>
                    2.พิมพ์์ใบนำส่งเอกสารและตรวจสอบเอกสารให้ครบถ้วนก่อนส่งไปรษณีย์ (เฉพาะ กทม) ที่นี่
                </td>
            </tr>
            <tr>
                <td>
                    3.เมื่องานใบอนุญาตดำเนินการเสร็จสิ้นแล้ว จะดำเนินการจัดส่งเอกสารให้กับผู้ประกอบการ
                </td>
            </tr>
        </table>

        <br />
        <div>
            <h3 style="color:red"><b>รายการใบเสร็จ</b></h3>
        </div>
        <br />
        <div>
            <h3 style="color:red"><b>รูปถ่าย</b></h3>
            <img />
            <a>รูปถ่ายของผู้รับอนุญาต ผู้ดำเนินกิจการ (รูปถ่ายสีขนาด 3 x 4 ชม. ถ่ายไว้ไม่เกิน 6 เดือน ต่อประเภทใบอนุญาต ( หน้าตรงไม่ยิ้ม ไม่สวมแว่นตาและหมวก พื้นหลังสีเรียบ )</a>
        </div>
        <hr />
        <input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" value="Picture" />
        <hr />
        <div>
            <h3 style="color:red"><b>รูปถ่ายสถานที่</b></h3>
            <img />
            <a>รูปถ่ายด้านหน้าของสถานที่ที่ได้รับอนุญาต ( เห็นป้ายชื่อสถานที่ )</a>
        </div>
        <hr />
        <input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" value="Picture_LCT" />
        <hr />
        <table class="table" width="100%">
            <tr>
                <td align="left" width="70%"><h3 style="color:red"><b>รายการไฟล์แนบ</b></h3></td>
                <td>
                    <input type="button" class="form-control" value="Upload" ng-click="BTN_Upload()" />
                </td>
            </tr>
            
        </table>
    </div>
    <div style="text-align:center">
        <button class="btn btn-lg" ng-click="BTN_BACK()" >ย้อนกลับ</button>
    </div>
</div>