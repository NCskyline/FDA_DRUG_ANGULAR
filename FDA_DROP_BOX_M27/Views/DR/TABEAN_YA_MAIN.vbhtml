@Code
    Layout = ""
End Code

@*<h2>TABEAN_YA_MAIN</h2>*@

<div>
    <div>
        <div>
            <h1>ข้อมูล</h1>
            <table class="table" width="100%" border="1">
                <tr>
                    <td>ชื่อบริษัท</td>
                    <td></td>
                    <td>เลขที่ใบอนุญาต</td>
                    <td></td>
                </tr>
                <tr>
                    <td>ชื่อยา (ภาษาไหย)</td>
                    <td></td>
                    <td>ชื่อยา (ภาษาอังกฤษ)</td>
                    <td></td>
                </tr>
                <tr>
                    <td>หมวดยา</td>
                    <td></td>
                    <td>ชนิดยา</td>
                    <td></td>
                </tr>
                <tr>
                    <td>เลขที่ตำรับ</td>
                    <td></td>
                </tr>
            </table>
            <br />
            <div>
                <div class="tab">
                    <button class="tablinks" ng-click="openTab(event, 'DS')">ยาตัวอย่าง</button>
                    <button class="tablinks" ng-click="openTab(event, 'DR')">ย.1</button>
                </div>
            </div>
            <div id="DS" class="tabcontent">
                <h3>London</h3>
                <p>London is the capital city of England.</p>
            </div>

            <div id="DR" class="tabcontent">
                <h3>Paris</h3>
                <p>Paris is the capital of France.</p>
            </div>
        </div>
    </div>
</div>