app.controller('DR_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var CITIZEN = CITIZEN_ID_AUTHORIZE;
    var PROCESS_ID = QueryString("PROCESS");

    pageload();

    function dropdown() {
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        });
    }

    function pageload() {

        $scope.FILE_ATTACH = SET_URL_SV('/DR/INPUT_RECLASS_ATTACH');
        var process = sessionStorage.PROCESS_ID;
        if (process == 130001 || process == 130002 || process == 130004) {
            $scope.SUB_PATH = SET_URL_SV('/DL/DL_MAIN');
        } else if (process == 140099) {
            $scope.SUB_PATH = SET_URL_SV('/DR/FRM_RECLASS_MAIN');
        } else if (process == 130099) {
            $scope.SUB_PATH = SET_URL_SV('/DR_EDIT_REQUEST/FRM_RGT_EDIT_MAIN');
        } else if (process == 1027) {
            $scope.SUB_PATH = SET_URL_SV('/DI/FRM_DRUG_IMPORT_NYM2');
        } else if (process == 1028) {
            $scope.SUB_PATH = SET_URL_SV('/DI/FRM_DRUG_IMPORT_NYM3');
        } else if (process == 1029) {
            $scope.SUB_PATH = SET_URL_SV('/DI/FRM_DRUG_IMPORT_NYM4');
        } else if (process == 1031) {
            $scope.SUB_PATH = SET_URL_SV('/DI/FRM_DRUG_IMPORT_NYM4_2');
        } else if (process == '130098') {
            $scope.SUB_PATH = SET_URL_SV('/DR/FRM_SUBSTITUTE_TABEAN_MAIN');
        }

        if (process != undefined) {
            var data_DL = CENTER_SV.SP_DRUG_REGISTRATION_BY_FK_IDA_PROCESS_ID(LCN_IDA, process);
            data_DL.then(function (datas) {
                $scope.DL_List = datas.data;
            }, function () { });
        }
        
        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
            dropdown();
        }, function () { });

        var data_UNIT_PHYSIC = CENTER_SV.SP_DRUG_UNIT_PHYSIC();
        data_UNIT_PHYSIC.then(function (datas) {
            $scope.UNIT_PHYSIC = datas.data;
            dropdown();
        }, function () { });


        var data_dactg = CENTER_SV.SP_dactg();
        data_dactg.then(function (datas) {
            $scope.dactg = datas.data;
            dropdown();
        }, function () { });

        var data_drclass = CENTER_SV.SP_MASTER_drclass();
        data_drclass.then(function (datas) {
            $scope.drclass = datas.data;
            dropdown();
        }, function () { });

        var data_drdosage = CENTER_SV.SP_dosage_form();
        data_drdosage.then(function (datas) {
            $scope.drdosage = datas.data;
            dropdown();
        }, function () { });

        var data_BIO_UNIT = CENTER_SV.GET_MAS_BIO_UNIT();
        data_BIO_UNIT.then(function (datas) {
            $scope.BIO_UNIT = datas.data;
            dropdown();
        }, function () { });

        var data_DRUG_PACKAGING = CENTER_SV.GET_DRUG_PACKAGING();
        data_DRUG_PACKAGING.then(function (datas) {
            $scope.DRUG_PACKAGING = datas.data;
            dropdown();
        }, function () { });

        var data_DRUG_SHAPE = CENTER_SV.SP_MAS_DRUG_SHAPE();
        data_DRUG_SHAPE.then(function (datas) {
            $scope.DRUG_SHAPE = datas.data;
            dropdown();
        }, function () { });

        
        var data_drkdofdrg = CENTER_SV.SP_drkdofdrg();
        data_drkdofdrg.then(function (datas) {
            $scope.drkdofdrg = datas.data;
            dropdown();
        }, function () { });

        
        var data_dramltype = CENTER_SV.GET_dramltype();
        data_dramltype.then(function (datas) {
            $scope.dramltype = datas.data;
            dropdown();
        }, function () { });

        var Getdata = CENTER_SV.SP_GET_LCN(CITIZEN);
        Getdata.then(function (datas) {
            $scope.LIST_LCN = datas.data;
        });

        var data3 = CENTER_SV.SP_REGISTER_SELECT(CITIZEN);
        data3.then(function (datas) {
            $scope.DATA_RGT = datas.data;
        }, function () { });

        
        var data4 = CENTER_SV.SP_RECLASS_BY_NEWCODE(sessionStorage.NEWCODE);
        data4.then(function (datas) {
            $scope.DATA_RECLASS = datas.data;
        }, function () { });


        //var id = '@Html.IdFor( o => o.model )';
        //var dropdown = $("#" + id);
        //var vall = dropdown.val();
        //var e = document.getElementById("ddl_dramltype");
        //var vall = e.options[e.selectedIndex].value;
        //var data_dramlsubtp = CENTER_SV.GET_dramlsubtp(vall);
        //data_dramlsubtp.then(function (datas) {
        //    $scope.dramlsubtp = datas.data;
         
        //}, function () { });

        
        //var e = document.getElementById("ddl_dramlsubtp");
        //var val2 = e.options[e.selectedIndex].value;
        //var data_dramlusetp = CENTER_SV.GET_dramlusetp(val2);
        //data_dramlusetp.then(function (datas) {
        //    $scope.dramlusetp = datas.data;
           
        //}, function () { });
    }

    $scope.BTN_MENU = function (process) {

        if (process == '130001' || process == '130002' || process == '13004') {
            REDIRECT('/DR/FRM_SEARCH_LCN?PROCESS=' + process);
        } else if (process == '130099' || process == '140099' || process == '130098') {
            REDIRECT('/DR/FRM_RGT_SELECT?PROCESS=' + process);
        } else if (process == '1027' || process == '1028' || process == '1029' || process == '1031') {
            REDIRECT('/DI/FRM_SEARCH_LCN_TO_DL?PROCESS=' + process);
        } else if (process == '1026') {
            //var url = 'http://164.115.28.156/FDA_DRUG_IMPORT_ORDER/Home/MAIN';
            window.open('http://164.115.28.156/FDA_DRUG_IMPORT_ORDER/Home/MAIN');
        }
    };

    
    //$scope.pageload_sel = function () {
       
    
    //};


    $scope.SELECT_LCN = function (datas) {

        sessionStorage.LCN_IDA = datas.IDA;
        sessionStorage.LCT_IDA = datas.LCT_IDA;
        sessionStorage.PROCESS_ID = PROCESS_ID;
        REDIRECT('/DR/FRM_MAIN_PAGE_PRODUCT');

    };
    $scope.SELECT_REGIST = function (datas) {
        sessionStorage.PROCESS_ID = PROCESS_ID;
        sessionStorage.NEWCODE = datas.newcode;
        REDIRECT('/DR/FRM_MAIN_PAGE_PRODUCT');

    };


    $scope.BTN_DL = function (process) {
        sessionStorage.PROCESS = process;
        REDIRECT('/DL/INPUT_DL');
    };

    $scope.BTN_EDIT = function (data) {
        REDIRECT('/DL/FRM_REGISTRATION_OTHER_DETAIL');
    };

    $scope.BTN_DATA = function (data) {
        REDIRECT('/DR/TABEAN_YA_MAIN');
    };

    $scope.BTN_INPUT = function (data) {
        REDIRECT('/DR/INPUT_YOR_1');
    };
    
    $scope.BTN_INPUT_RECLASS = function () {
        REDIRECT('/DR/INPUT_RECLASS');
    };

    $scope.BTN_PREVIEW = function () {
        REDIRECT('/DR/INPUT_YOR_1');
    };

    $scope.BTN_TRANSFER = function () {
        REDIRECT('/DR/FRM_DR_TRANSFER_DL');
    };

    $scope.BTN_PREVIEW_RGT_EDIT = function () {
        REDIRECT('/DR_EDIT_REQUEST/FRM_RGT_EDIT_CONFIRM');
    };

    $scope.BTN_DS_INPUT = function () {
        REDIRECT('/DS/INPUT_DS_PORYOR8');
        //if (process == 1701) {
        //    REDIRECT('/DS/INPUT_DS_PORYOR8');
        //} else if (process == 1702) {
        //    REDIRECT('/DS/INPUT_DS_NORYOR8');
        //}
    };

    $scope.BTN_RQT = function () {
        REDIRECT('/DR/FRM_RQT_REGIST_INFORMATION');
    };

    $scope.BTN_INPUT_YOR5 = function () {
        REDIRECT('/DR_EDIT_REQUEST/INPUT_YOR_5');
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/DR/FRM_MAIN_PAGE_PRODUCT');
    };

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);