
<link rel="stylesheet" href="../dist/listree.min.css" />
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>
<link href="../css/bootstrap_limitless.min.css" rel="stylesheet" />

<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">

    <div class="content-part " style="width:100%;font-family:'Taviraj'">
        <div class="part part-1-3 ic">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading">ขออนุญาตสถานที่ด้านยาแห่งใหม่</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a ng-click="BTN_MENU('101')" style="color:#06B716">ขย1</a>  @*ng-click="DATA_GMP('31')"*@
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('103')" style="color:#06B716">ขย3</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('104')" style="color:#06B716">ขย4</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('105')" style="color:#06B716">นย1</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('106')" style="color:#06B716">ผย1</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('107')" style="color:#06B716">ขยบ</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('108')" style="color:#06B716">นยบ</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('109')" style="color:#06B716">ผยบ</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">ขออนุญาตสถานที่วัตถุเสพติดแห่งใหม่</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <div class="listree-submenu-heading">วัตถุออกฤทธิ์จิตและประสาทประเภท ๓ , ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a ng-click="BTN_MENU('131')" style="color:#06B716">นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('132')" style="color:#06B716">นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('123')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('124')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('133')" style="color:#06B716">ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('134')" style="color:#06B716">ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('125')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('126')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๔</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ยาเสพติดให้โทษประเภทที่ ๓ หรือ ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">นำเข้ายาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=15">ส่งออกยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=16">จำหน่ายยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ผลิตวัตถุออกฤทธิ์ฯประเภท ๓ หรือ ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">ผลิตวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=15">ผลิตวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ผลิตยาเสพติดให้โทษประเภทที่ ๓ หรือ ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">ผลิตยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">คำขอแก้ไข/คำขอใบแทน/คำขอต่ออายุ</div>
                    <ul class="listree-submenu-items">
                        <li>
                            <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอแก้ไขใบอนุญาตวัตถุออกฤทธิ์และยาเสพติด</a>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">คำขอใบแทนใบอนุญาตวัตถุออกฤทธิ์และยาเสพติด</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=101">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม</a>
                                </li>
                                <li>
                                    <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4 ประชุม</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class="part part-2-3 ic">

            <div ng-include="SUB_PATH">

            </div>

        </div>
    </div>
</div>
