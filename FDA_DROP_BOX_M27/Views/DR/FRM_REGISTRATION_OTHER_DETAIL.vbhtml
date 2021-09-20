@Code
    ViewData("Title") = "FRM_REGISTRATION_OTHER_DETAIL"
End Code

    <style>
        .tab {
            overflow: hidden;
            border: 1px solid #ccc;
            background-color: #f1f1f1;
        }

            /* Style the buttons that are used to open the tab content */
            .tab button {
                background-color: inherit;
                float: left;
                border: none;
                outline: none;
                cursor: pointer;
                padding: 14px 16px;
                transition: 0.3s;
            }

                /* Change background color of buttons on hover */
                .tab button:hover {
                    background-color: #ddd;
                }

                /* Create an active/current tablink class */
                .tab button.active {
                    background-color: #ccc;
                }

        /* Style the tab content */
        .tabcontent {
            display: none;
            padding: 6px 12px;
            border: 1px solid #ccc;
            border-top: none;
        }
    </style>

<h2>FRM_REGISTRATION_OTHER_DETAIL</h2>

<div>
    <div>
        <div class="tab">
            <button class="tablinks" onclick="openTab(event, 'GENERAL')">1.ข้อมูลทั่วไป</button>
            <button class="tablinks" onclick="openTab(event, 'CONTAIN')">2.ขนาดบรรจุ</button>
            <button class="tablinks" onclick="openTab(event, 'IOW')">3.สูตรสาร</button>
            <button class="tablinks" onclick="openTab(event, 'PRODUCCER')">4.1 ผู้ผลิตต่างประเทศ</button>
            <button class="tablinks" onclick="openTab(event, 'PRODUCCER_IN')">4.2 ผู้ผลิตในประเทศ</button>
            <button class="tablinks" onclick="openTab(event, 'DRUGKEEP')">5.การเก็บรักษา</button>
            <button class="tablinks" onclick="openTab(event, 'ATC')">6.กลุ่มตำรับ</button>
            <button class="tablinks" onclick="openTab(event, 'INDICATION')">7.ข้อบ่งใช้</button>
            <button class="tablinks" onclick="openTab(event, 'COLOR')">8.สีของยา</button>
        </div>
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
</script>