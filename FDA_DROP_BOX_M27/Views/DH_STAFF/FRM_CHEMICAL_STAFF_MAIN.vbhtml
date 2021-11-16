@Code Layout = "" End Code

<div>
    <div style="font-family:'Taviraj';width:100%">
        <div>
            <div>
                <h3>เพิ่มชื่อเภสัชเคมีภัณฑ์</h3>
            </div>
            <br />
            <table width="100%" style="font-family:'Taviraj';">
                <tr>
                    <td><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
                </tr>
            </table>
            <div class="row" width="100%">
                <div class="col-sm-12">
                    <div align="center" class="card" style=" border-top: 10px solid #F9D027;">
                        <table style="margin-top:10px;width:100%;" class="table table-condensed">
                            <thead>
                                <tr>
                                    <th style="width:8%">ชื่อสาร</th>
                                    <th style="width:20%">ชนิด</th>
                                    <th style="width:13%">วันที่ยื่นคำขอ</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="data in LIST_CHEM_STAFF | filter: filter | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                                    <td>{{data.iowanm}}</td>
                                    <td>{{data.chem_type2}}</td>
                                    <td>{{data.REQUEST_DATE}}</td>
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

