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


<h2>FRM_RQT_REGIST_INFORMATION</h2>
<div>
    <div class="in">

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
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">การเก็บรักษา</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">กลุ่มตำรับ</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">ข้อบ่งใช่</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">ลักษณะและสีของยา</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">ข้อมูลยาสัตว์</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">เงื่อนไข</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">อ้างอิง</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">ผู้แทนจำหน่าย</button>
                    <button class="tablinks" onclick="openTab(event, 'Tokyo')">ชื่อยาส่งออก</button>
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