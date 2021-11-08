@Code
    ViewData("Title") = "FRM_RGT_EDIT_MAIN"
End Code

<div>
    <div class="ic" style="font-family:'Taviraj'">
        <div>
            <table class="table" width="100%">
                <tr>
                    <td width="30%">คำขอแก้ไขเปลี่ยนแปลงทะเบียน > K 1/62 (NC)</td> @*{{register}}*@
                    <td width="60%" align="center">
                        <select style="width:40%;" class="form-control">
                            <option>นาย ณัฐสิทธิ์ อาจเมือง</option>
                            <option></option>
                        </select>
                    </td>
                    <td>
                        <input type="button" class="form-control" value="สร้างคำขอแก้ไข" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-12" style="width:100%;">
                <div class="card" style="border-top: 10px solid #F9D027;">
                    <table width="100%" class="table">
                        <thead style="font-weight:300;">
                            <tr>
                                <td>เลขรับที่</td>
                                <td>ทะเบียน</td>
                                <td>ชื่อยา</td>
                                <td>เลขดำเนินการ</td>
                                <td>รายละเอียดการแก้ไข</td>
                                <td>สถานะ</td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>ทดสอบ4 /test4</td>
                                <td>64009999</td>
                                <td></td>
                                <td>อยู่ระหว่างการประเมินคำขอ</td>
                                <td>
                                    <a ng-click="">ใบนัด</a>
                                </td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_EXTEND()">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr></tr>
                        </tfoot>
                    </table>
                </div>
                <div style="text-align:right">
                    <a ng-click="BTN_PAYMENT">ชำระเงินคลิ๊กที่นี่</a>
                </div>
            </div>
        </div>
    </div>
</div>
