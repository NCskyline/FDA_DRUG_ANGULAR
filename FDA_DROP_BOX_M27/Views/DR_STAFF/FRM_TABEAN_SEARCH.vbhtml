
@Code
    Layout = ""
End Code

<br />
<h4>ค้นหาใบทะเบียน</h4><br />
<table width="100%" style="font-family:'Taviraj'"> 
    <tr>
        <td>เลขทะเบียน</td>
        <td>
            <input type="text" ng-model="txt_search" />
        </td>
        <td align="left">
            (ตัวอย่าง 1/26)
        </td>
    </tr>
    <tr>
        <td></td>
        <td colspan="2"><button class="btn btn-lg">ค้นหา</button></td>
    </tr>
</table>
<br />
<div class="row">
    <div class="col-sm-12" style="width:100%;">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                <thead style="font-weight:300;">
                    <tr>
                        <td>เลขรับ</td>
                        <td>เลขทะเบียน</td>
                        <td>ชื่อภาษาไทย</td>
                        <td>ชื่อภาษาอังกฤษ</td>
                        <td>เลขทะเบียน (Refer/Transfer/Copy)</td>
                        <td>สถานะทะเบียน</td>
                        <td></td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in DATA_TABEAN_SEARCH">
                        <td>{{data.rcvno_display}}</td>
                        <td>{{data.rgtno_display}}</td>
                        <td>{{data.thadrgnm}}</td>
                        <td>{{data.engdrgnm}}</td>
                        <td>{{data.rgtno_t_display}}</td>
                        <td>{{data.cncnm}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
                                แบบฟอร์มทะเบียน
                            </a>
                        </td>
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
