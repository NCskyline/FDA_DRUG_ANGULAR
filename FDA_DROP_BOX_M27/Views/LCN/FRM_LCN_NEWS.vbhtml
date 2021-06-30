
<link rel="stylesheet" href="../dist/listree.min.css" />
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>
<link href="../css/bootstrap_limitless.min.css" rel="stylesheet" />

<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">

    <div class="content-part " style="width:100%">
        <div class="part part-1-3 ic">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading">ขออนุญาตสถานที่ด้านยาแห่งใหม่</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=31">ขย1</a>  @*ng-click="DATA_GMP('31')"*@
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=32">ขย3</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=33">ขย4</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=34">นย1</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=36">ผย1</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=36">ขยบ</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=36">นยบ</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=36">ผยบ</a>
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
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=15">นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=16">ขายวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=17">ขายวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=17">ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=17">ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=17">ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=17">ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๔</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ยาเสพติดให้โทษประเภทที่ ๓ หรือ ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">นำเข้ายาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=15">ส่งออกยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=16">จำหน่ายยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ผลิตวัตถุออกฤทธิ์ฯประเภท ๓ หรือ ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">ผลิตวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=15">ผลิตวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ผลิตยาเสพติดให้โทษประเภทที่ ๓ หรือ ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">ผลิตยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">คำขอแก้ไข/คำขอใบแทน/คำขอต่ออายุ</div>
                    <ul class="listree-submenu-items">
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอแก้ไขใบอนุญาตวัตถุออกฤทธิ์และยาเสพติด</a>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">คำขอใบแทนใบอนุญาตวัตถุออกฤทธิ์และยาเสพติด</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4 ประชุม</a>
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
