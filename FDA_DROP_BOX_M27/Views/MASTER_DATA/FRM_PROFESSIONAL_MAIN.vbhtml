@Code
    Layout = ""
End Code

<h4>รายการผู้เชี่ยวชาญ</h4><br />

<div class="row">
    <div class="col-sm-12" style="width:100%;">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                <thead style="font-weight:300;">
                    <tr>
                        <td>เลขบัตรประชาชน</td>
                        <td>ชื่อผู้เชี่ยวชาญ</td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in DATA_PROFESS">
                        <td>{{data.CITIZEN_ID}}</td>
                        <td>{{data.FULLNAME}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
                                แก้ไข
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