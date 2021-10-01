@Code
    ViewData("Title") = "INPUT_GENERAL"
End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DR_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div class="ic" ng-controller="DR_CTRL" ng-app="ANGULAR_APP">

    <table>
        <tr>
            <td bgcolor="Lavender" width="197px" height="28px" align="right">ชื่อการค้า (ภาษาไทย):</td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                <input type="text" id="txt_thaname" style="width:100%;" />
            </td>
        </tr>



        <tr>
            <td bgcolor="Lavender" width="197px" height="28px" align="right">ชื่อการค้า (ภาษาอังกฤษ):</td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                <input type="text" id="txt_engname" style="width:100%;" />
            </td>
        </tr>



        <tr>
            <td bgcolor="Lavender" width="197px" align="right">หมวดยา : </td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_dactg"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="ddl_dactg" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in dactg" value="{{x.ctgcd}}">{{x.ctgthanm}}</option>
                </select>
            </td>
        </tr>



        <tr>
            <td bgcolor="Lavender" align="right">รูปแบบยา : </td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_drdosage"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="ddl_drdosage" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in drdosage" value="{{x.dsgcd}}">{{x.thadsgnm}}</option>
                </select>
            </td>
        </tr>




        <tr>
            <td bgcolor="Lavender" bgcolor="Wheat" align="right">ประเภทของยา :</td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_drclass"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="ddl_drclass" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in drclass" value="{{x.classcd}}">{{x.thaclassnm}}</option>
                </select>
            </td>
        </tr>


        <tr>
            <td bgcolor="Lavender" bgcolor="Wheat" align="right">ชนิดยา :</td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_drug_type"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="drug_type" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in drkdofdrg" value="{{x.kindcd}}">{{x.thakindnm}}</option>
                </select>
            </td>
        </tr>



        <tr>
            <td bgcolor="Lavender" bgcolor="Wheat" align="right">รูปทรง :</td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_shape"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="ddl_shape" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in DRUG_SHAPE" value="{{x.SHAPE_IDA}}">{{x.SHAPE_NAME}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td bgcolor="Lavender" bgcolor="Wheat" align="right">
                หน่วยนับตามรูปของแบบยา :
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_small_unit"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="ddl_small_unit" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                </select>
            </td>
        </tr>



        <tr>
            <td bgcolor="Lavender" bgcolor="Wheat" align="right">
                หน่วยนับทางชีวภาพ :
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_bio_pack"></label>
            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="ddl_bio_pack" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in BIO_UNIT" value="{{x.IDA}}">{{x.BIO_UNIT}}</option>
                </select>
            </td>
        </tr>



        <tr>
            <td bgcolor="Lavender" bgcolor="Wheat" align="right">
                หน่วยนับตามบรรจุภัณฑ์ :
            </td>
            <td style="padding:0px 0px 0px 50px;">
                <label ID="lbl_packaging"></label>

            </td>
            <td style="padding:0px 0px 0px 50px;">
                แก้ไขเป็น
            </td>
            <td>
                <select id="ddl_packaging" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in DRUG_PACKAGING" value="{{x.UOP_CODE}}">{{x.PACKAGING_NAME}}</option>
                </select>
            </td>
        </tr>



        <tr>
            <td bgcolor="Lavender" bgcolor="Wheat" align="right">ความแรงของตำรับยา</td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                <input type="text" id="txt_drug_str" style="width:100px;" />
            </td>
        </tr>

    </table>
</div>