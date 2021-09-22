@Code
    ViewData("Title") = "FRM_RQT_REGIST_INFORMATION"
End Code

<style>
    * {box-sizing: border-box}

    /* Style the tab */
    .tab {
        float: left;
        /*border: 1px solid #ccc;*/
        background-color: #f1f1f1;
        width: 100%;
        font-family: 'Taviraj';
        /*height: 300px;*/
    }

        /* Style the buttons that are used to open the tab content */
    .tab button {
        display: block;
        background-color: inherit;
        color: black;
        padding: 22px 16px;
        width: 100%;
        border: none;
        outline: none;
        text-align: left;
        cursor: pointer;
        transition: 0.3s;
    }

    /* Change background color of buttons on hover */
    .tab button:hover {
        background-color: #ddd;
    }

    /* Create an active/current "tab button" class */
    .tab button.active {
        background-color: #ccc;
    }

    /* Style the tab content */
    .tabcontent {
        float: left;
        /*padding: 0px 12px;*/
        /*border: 1px solid #ccc;*/
        /*width: 70%;*/
        border-left: none;
        /*height: 300px;*/
    }
</style>



<div style="font-family:'Taviraj';width:100%">
    <div class="in">
        <h2>ข้อมูลทั่วไปผลิตภัณฑ์ยา</h2>
        <br />
        <table class="table" width="100%" border="1">
            <tr>
                <td width="20%" style="font-size:20px">เลขทะเบียนตำรับยา</td>
                <td></td>
            </tr>
            <tr>
                <td style="font-size:20px">ชื่อการค้า (ภาษาไทย):</td>
                <td></td>
            </tr>
            <tr>
                <td style="font-size:20px">ชื่อการค้า (ภาษาอังกฤษ):</td>
                <td></td>
            </tr>
            <tr>
                <td style="font-size:20px">ชื่อผู้รับอนุญาต :</td>
                <td></td>
            </tr>
            <tr>
                <td style="font-size:20px">ชื่อสถานที่ :</td>
                <td></td>
            </tr>
            <tr>
                <td style="font-size:20px">ที่ตั้ง :</td>
                <td></td>
            </tr>
            <tr>
                <td style="font-size:20px">ประเภทใบอนุญาต :</td>
                <td></td>
            </tr>
            <tr>
                <td style="font-size:20px">เลขที่ใบอนุญาต :</td>
                <td></td>
            </tr>
        </table>
    </div>
    <div >
        <div class="content-part">
            <div class="part part-1-3 ic">
                <div class="tab">
                    <button class="tablinks" onclick="openTab(event, 'GENERAL')" id="defaultOpen">ข้อมูลทั่วไป</button>
                    <button class="tablinks" onclick="openTab(event, 'CONTAIN')">ขนาดบรรจุ</button>
                    <button class="tablinks" onclick="openTab(event, 'PRODUCCER')">ผู้ผลิตต่างประเทศ</button>
                    <button class="tablinks" onclick="openTab(event, 'PRODUCCER_IN')">ผู้ผลิตในประเทศ</button>
                    <button class="tablinks" onclick="openTab(event, 'IOW')">สูตรสาร</button>
                    <button class="tablinks" onclick="openTab(event, 'DRUG_KEEP')">การเก็บรักษา</button>
                    <button class="tablinks" onclick="openTab(event, 'ATC')">กลุ่มตำรับ</button>
                    <button class="tablinks" onclick="openTab(event, 'INDICATION')">ข้อบ่งใช่</button>
                    <button class="tablinks" onclick="openTab(event, 'COLOR')">ลักษณะและสีของยา</button>
                    <button class="tablinks" onclick="openTab(event, 'ANIMAL')">ข้อมูลยาสัตว์</button>
                    <button class="tablinks" onclick="openTab(event, 'CONDITION')">เงื่อนไข</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">อ้างอิง</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">ผู้แทนจำหน่าย</button>
                    <button class="tablinks" onclick="openTab(event, 'DRUG_EXPORT')">ชื่อยาส่งออก</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">เอกสารกำกับยา</button>
                </div>
            </div>
            <div class="part part-2-3 ic">
                <div id="GENERAL" class="tabcontent">
                    @Html.Partial("../DR/INPUT_GENERAL", Nothing)
                </div>
                <div id="CONTAIN" class="tabcontent">
                    @Html.Partial("../DR/INPUT_PACKAGE_DETAIL2", Nothing)
                </div>
                <div id="IOW" class="tabcontent">
                    @Html.Partial("../DR/INPUT_CHEM", Nothing)
                </div>
                <div id="PRODUCCER" class="tabcontent">
                    @Html.Partial("../DR/INPUT_PRODUCCER", Nothing)
                </div>
                <div id="PRODUCCER_IN" class="tabcontent">
                    @Html.Partial("../DR/INPUT_PRODUCCER_IN", Nothing)
                </div>
                <div id="DRUGKEEP" class="tabcontent">
                    @Html.Partial("../DR/INPUT_DRUG_KEEP", Nothing)
                </div>
                <div id="ATC" class="tabcontent">
                    @Html.Partial("../DR/INPUT_ATC", Nothing)
                </div>
                <div id="INDICATION" class="tabcontent">
                    @Html.Partial("../DR/INPUT_DETAIL_USE", Nothing)
                </div>
                <div id="COLOR" class="tabcontent">
                    @Html.Partial("../DR/INPUT_GENERAL", Nothing)
                </div>
                <div id="ANIMAL" class="tabcontent">
                    @Html.Partial("../DR/INPUT_DRUG_ANIMAL", Nothing)
                </div>
                <div id="CONDITION" class="tabcontent">
                    @Html.Partial("../DR/INPUT_CONDITION", Nothing)
                </div>
                <div id="DRUG_EXPORT" class="tabcontent">
                    @Html.Partial("../DR/INPUT_NAME_DRUG_EXPORT", Nothing)
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    function openTab(evt, Type) {
        var i, tabcontent, tablinks;

        tabcontent = document.getElementsByClassName("tabcontent");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = "none";
        }

        tablinks = document.getElementsByClassName("tablinks");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace(" active", "");
        }

        document.getElementById(Type).style.display = "block";
        evt.currentTarget.className += " active";
    }
    document.getElementById("defaultOpen").click();
</script>