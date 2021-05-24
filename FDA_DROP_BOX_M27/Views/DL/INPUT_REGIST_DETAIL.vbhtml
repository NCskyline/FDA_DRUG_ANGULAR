@Code
    ViewData("Title") = "INPUT_REGIST_DETAIL"
End Code
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DL_CTRL.js"></script>
<div class="ic" ng-controller="DL_CTRL" ng-app="ANGULAR_APP">
    <h2>ข้อมูลทั่วไป</h2>
    <table>
        <tr>
            <td>
                หมวดยา
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_dactg"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <select id="ddl_dactg" style="width:100px;">
                    <option ng-repeat="x in dactg" value="{{x.ctgcd}}">{{x.ctgthanm}}</option>
                </select>
            </td>
            <td style="color:red;padding:0px 0px 0px 10px;">
                *
            </td>
        </tr>
        <tr>
            <td>
                ประเภทของยา
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_drclass"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <select id="ddl_drclass" style="width:100px;">
                    <option ng-repeat="x in drclass" value="{{x.classcd}}">{{x.thaclassnm}}</option>
                </select>
            </td>
            <td style="color:red;padding:0px 0px 0px 10px;">
                *
            </td>
        </tr>
        <tr>
            <td>
                รูปแบบของยา
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_drdosage"></label>
            </td>
            <td style="padding: 0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <select id="ddl_drdosage" style="width:100px;">
                    <option ng-repeat="x in drdosage" value="{{x.dsgcd}}">{{x.thadsgnm}}</option>
                </select>
            </td>
            <td style="color:red;padding:0px 0px 0px 10px;">
                *
            </td>
        </tr>
        <tr>
            <td>
                หน่วยนับตามรูปของแบบยา
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_small_unit"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">

                <select id="ddl_small_unit" style="width:100px;">
                    <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                </select>
            </td>
            <td style="color:red;padding:0px 0px 0px 10px;">
                *
            </td>
        </tr>
        <tr>
            <td>
                หน่วยนับทางชีวภาพ
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_bio_pack"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <select id="ddl_bio_pack" style="width:100px;">
                    <option ng-repeat="x in BIO_UNIT" value="{{x.IDA}}">{{x.BIO_UNIT}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                หน่วยนับตามบรรจุภัณฑ์
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_packaging"></label>

            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <select id="ddl_packaging" style="width:100px;">
                    <option ng-repeat="x in DRUG_PACKAGING" value="{{x.UOP_CODE}}">{{x.PACKAGING_NAME}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                รูปทรง
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_shape"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <select id="ddl_shape" style="width:100px;">
                    <option ng-repeat="x in DRUG_SHAPE" value="{{x.SHAPE_IDA}}">{{x.SHAPE_NAME}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                ชนิดของยาตามกฎหมาย
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label id="lbl_drug_type"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <select id="drug_type" style="width:100px;">
                    <option ng-repeat="x in drkdofdrg" value="{{x.kindcd}}">{{x.thakindnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                ความแรง
            </td>
            <td style="padding:0px 0px 0px 50px;">
                &nbsp;
            </td>
            <td style="padding:0px 0px 0px 50px;">
                &nbsp;
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <text id="txt_drug_str">

                </text>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td style="padding:0px 0px 0px 50px;">

                &nbsp;
            </td>
            <td style="padding:0px 0px 0px 50px;">

                &nbsp;
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <button ID="btn_save" class="input-lg">บันทึกข้อมูล</button>
            </td>
        </tr>
    </table>
    </div>