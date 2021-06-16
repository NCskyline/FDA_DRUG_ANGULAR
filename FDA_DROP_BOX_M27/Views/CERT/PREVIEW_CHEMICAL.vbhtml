@Code
    Layout = ""
End Code


<div align="center">
    <table class="dataTable" width="70%">
        <thead>
            <tr>
                <th>รหัสสาร</th>
                <th>ชื่อสาร</th>
                <th>INN_NAME</th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat="data in LIST_GMP.CER_DETAIL_CASCHEMICAL">
                <td>{{data.CAS_ID}}</td>
                <td>{{data.CAS_NAME}}</td>
                <td>{{data.INN_NAME}}</td>
            </tr>
        </tbody>
        <tfoot>
            <tr></tr>
        </tfoot>
    </table>
</div>