@Code
    ViewData("Title") = "FRM_RGT_SELECT"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DR_CTRL.js"></script>

<div ng-app="ANGULAR_APP" ng-controller="DR_CTRL">
    <div class="ic">
        <div style="font-family:'Taviraj';width:100%">
            <div class="title-ic">
                รายการทะเบียน <i class="tt-ic fas fa-bookmark"></i>
            </div>
            <hr />
            <div class="row">
                <div class="col-sm-12">
                    <div class="search-item">
                        <input class="search-input" type="text" placeholder="ค้นหา..." ng-model="filter">
                        <i class="fa fa-search search-icon"></i>
                    </div>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-sm-12">
                    <div class="card" ng-repeat="datas in DATA_RGT | filter : filter" style=" border-top: 10px solid #F9D027;">

                        <div class="card-body" style="padding:unset;font-size: 15px;">
                            <div class="row">
                                <div class="col-sm-10">
                                    <div class="row">
                                        <div class="col-sm-2 set-topic">
                                            เลขทะเบียน :
                                        </div>
                                        <div class="col-sm-10">
                                            {{datas.RGTNO_DISPLAY}}
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-2 set-topic">
                                            ชื่อยา :
                                        </div>
                                        <div class="col-sm-10">
                                            {{datas.thadrgnm}}
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-2 set-topic">
                                            ชื่อยาภาษาอังกฤษ :
                                        </div>
                                        <div class="col-sm-10">
                                            {{datas.engdrgnm}}
                                        </div>
                                    </div>

                                </div>
                                <div class="col-sm-2">
                                    <div class="row set-a-btn">
                                        <div class="col-sm-12 ">
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="SELECT_LCN(datas,'12')">
                                                เลือก
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
