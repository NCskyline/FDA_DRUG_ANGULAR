@Code
    Layout = ""
End Code

<div>
    <div class="ic" style="font-family:'Taviraj'">
        <div>
            <h3><b>ลงทะเบียนสถานที่จำลอง</b></h3>
        </div>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:100%" align="center"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
            </tr>
        </table>
        <br />
        <div class="row">
            <div class="col-sm-12" style="width:100%;">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    <table width="100%" class="table" id="myTable" datatable="ng">
                        <thead style="font-weight:300;">
                            <tr>
                                <td>เลขรับ</td>
                                <td>วันที่ส่งเรื่อง</td>
                                <td>ชื่อสถานที่</td>
                                <td>ที่อยู่</td>
                                <td>รหัสดำเนินการ</td>
                                <td>สถานะ</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td></td>
                                <td></td>
                                <td>บริษัท สถานที่ใหม่ จำกัด มหาชน 3</td>
                                <td>บ้านเลขที่46/1 1 1 อาคาร 1 ซอย23/5 ถนนจันทน์ หมู่2 แขวงคลองสาน เขตคลองสาน จังหวัดกรุงเทพมหานคร 73150</td>
                                <td></td>
                                <td>ส่งเรื่องและรอพิจารณา</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_STAFF_LCN(data)">
                                        ดูข้อมูล
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td>บริษัท สถานที่ใหม่ จำกัด มหาชน 3</td>
                                <td>บ้านเลขที่46/1 1 1 อาคาร 1 ซอย23/5 ถนนจันทน์ หมู่2 แขวงคลองสาน เขตคลองสาน จังหวัดกรุงเทพมหานคร 73150</td>
                                <td></td>
                                <td>อนุมัติ</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_STAFF_LCN(data)">
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