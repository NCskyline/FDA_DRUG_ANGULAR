
@Code
    Layout = ""
End Code


<div>
    <p style="font-family:'Taviraj';font-size:24px">ค้นหาสาร</p>
</div>
<br />
<table style="width:100%">
    <tr>
        <td style="width:15%">ชื่อสารที่ต้องการค้นหา</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="name"></td>
        <td width="2%"></td>
        <td style="width:12%">เลข iowa (ยาว)</td>
        <td style="width:30%"><input class="form-control inline" type="text" style="width:100%" ng-model="iowa"></td>
        <td width="2%"></td>
        <td><input class="btn btn-lg" type="button" value="ค้นหา" ng-click="BTN_SEARCH_IOWA_STAFF(name,iowa)" style="width:150px;height:40px;" /></td>
    </tr>
</table>
<br />
<div class="row">
    <div class="col-sm-12">
        <div class="card" style=" border-top: 10px solid #F9D027;">
            <table class="table table-condensed" style="width:100%;margin-top:10px;">
                <thead>
                    <tr>
                        <th style="width:5%">IDA</th>
                        <th style="width:10%">CAS NO.</th>
                        <th style="width:15%">ชื่อสาร</th>
                        <th style="width:5%">iowacd</th>
                        <th style="width:5%">runno</th>
                        <th style="width:3%">salt</th>
                        <th style="width:3%">syn</th>
                        <th style="width:3%">aori</th>
                        <th style="width:10%">REGIS_STATUS</th>
                        @*<th style="width:5%">INN</th>
                        <th style="width:5%">INN_TH</th>*@
                        @*<th style="width:15%">Version update</th>*@
                        <th style="width:10%">สถานะ</th>
                        <th style="width:5%"></th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in LIST_SEARCH_CHEM">
                        <td>{{data.IDA}}</td>
                        <td>{{data.cas_number}}</td>
                        <td>{{data.iowanm}}</td>
                        <td>{{data.iowacd}}</td>
                        <td>{{data.runno}}</td>
                        <td>{{data.salt}}</td>
                        <td>{{data.syn}}</td>
                        <td>{{data.aori}}</td>
                        <td>{{data.REGIS_STATUS}}</td>
                        @*<td>{{data.INN}}</td>
                        <td>{{data.INN_TH}}</td>*@
                        @*<td>{{data.Version_update}}</td>*@
                        <td>{{data.STATUS_IOWA}}</td>
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
