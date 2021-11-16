app.controller('LCN_STAFF_CTRL', function ($scope, CENTER_SV, $http, $location) {
    CHK_TOKEN();
   // var la_IDA = sessionStorage.LCT_IDA;
    //var CITIZEN_ID_AUTHORIZE = sessionStorage.CITIZEN_ID_AUTHORIZE;
   // var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = sessionStorage.PROCESS;
    var IDENTIFY = sessionStorage.CITIZEN_ID_AUTHORIZE;
    var HEAD_LCN_IDA = sessionStorage.HEAD_LCN_IDA;
    
    Pageload();

    function Pageload() {
        var getData_LIST = CENTER_SV.SETMODEL_LIST();
        getData_LIST.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });
    }

    $scope.LoadPreview = function () {
        var process = sessionStorage.PROCESS;
        var LCN_IDA = sessionStorage.LCN_IDA;
        if (process == '101') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(ขย1)';
        } else if (process == '103') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(ขย3)';
        } else if (process == '104') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(ขย4)';
        } else if (process == '105') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(นย1)';
        } else if (process == '106') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(ผย1)';
        } else if (process == '107') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(ขยบ)';
        } else if (process == '108') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(นยบ)';
        } else if (process == '109') {
            sessionStorage.HEAD_LCN_IDA = LCN_IDA;
            $scope.lcnnoType = '(ผยบ)';
        } else if (process == '123') {
            $scope.lcnnoType = '(ขย.1)';
        } else if (process == '124') {
            $scope.lcnnoType = ('ขย1');
        } else if (process == '125') {
            $scope.lcnnoType = ('ขย1');
        } else if (process == '126') {
            $scope.lcnnoType = ('ขย1');
        } else if (process == '131') {
            $scope.lcnnoType = ('นย1');
        } else if (process == '132') {
            $scope.lcnnoType = ('นย1');
        } else if (process == '133') {
            $scope.lcnnoType = ('ขย1');
        } else if (process == '134') {
            $scope.lcnnoType = ('ขย1');
        } else if (process == '127') {
            $scope.lcnnoType = ('ผวจ3');
        } else if (process == '128') {
            $scope.lcnnoType = ('ผวจ4');
        } else if (process == '114') {
            $scope.lcnnoType = ('ผย1');
        } else if (process == '115') {
            $scope.lcnnoType = ('ขย1');
        } else if (process == '116') {
            $scope.lcnnoType = ('นย1');
        } else if (process == '117') {
            $scope.lcnnoType = ('ขย1');
        } else $scope.lcnnoType = '';

        
        //var getData_LIST = CENTER_SV.SETMODEL_LIST_LCN(process);
        //getData_LIST.then(function (datas) {
        //    $scope.DOC_LIST = datas.data;
        //}, function () { });

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT_V2(sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.LCT_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_LCN.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
        }, function () { });

        var data_stat = CENTER_SV.SP_STATUS_SELECT_LCN_STAFF(LCN_IDA, 2);
        data_stat.then(function (datas) {
            $scope.STAT_LIST = datas.data;

        }, function () { });


        var MODEL_HEAD = CENTER_SV.GET_HEAD_LCN_INFORMATION_INPUT(sessionStorage.HEAD_LCN_IDA);
        MODEL_HEAD.then(function (datas) {

            $scope.LIST_HEAD_LCN = datas.data;
        }, function () { });

        var data_keep = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(sessionStorage.LCT_IDA, sessionStorage.PROCESS, sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_keep.then(function (datas) {
            $scope.DATA_LCN_MAIN = datas.data;

        }, function () { });



        var data_keep1 = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_keep1.then(function (datas) {
            $scope.REF_LOCATION_KEEP = datas.data;

        }, function () { });

        //var data_lct = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2('1', sessionStorage.CITIZEN_ID_AUTHORIZE);
        //data_lct.then(function (datas) {
        //    $scope.REF_LOCATION = datas.data;

        //}, function () { });

        if ($scope.LIST_EXTEND.YEAR_SELECT == "1") {
            var _YEAR = new Date().getFullYear();
            if (_YEAR < 2500) {
                _YEAR = _YEAR + 544;
            }
            var data_lct = CENTER_SV.SP_LCN_EXTEND_REQUEST_BY_IDENTIFY_YEAR(IDENTIFY, _YEAR);
            data_lct.then(function (datas) {
                $scope.LIST_EXTEND = datas.data;

            }, function () { });

        } else {
            var data_lct1 = CENTER_SV.SP_LCN_EXTEND_REQUEST_BY_IDENTIFY(IDENTIFY);
            data_lct1.then(function (datas) {
                $scope.LIST_EXTEND = datas.data;

            }, function () { });

        }

        var datakeep = CENTER_SV.SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(LCN_IDA);
        datakeep.then(function (datas) {
            $scope.DATA_KEEP_SHOW = datas.data;
        }, function () { });

        var dataPHR = CENTER_SV.SP_DALCN_PHR_BY_FK_IDA_2(LCN_IDA);
        dataPHR.then(function (datas) {
            $scope.DATA_PHR_SHOW = datas.data;
        }, function () { });
    };

    $scope.Pageload_modify = function () {

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT_MODIFY(sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.LCT_IDA, sessionStorage.LCN_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_LCN.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
        }, function () { });

        var data_keep = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_keep.then(function (datas) {
            $scope.REF_LOCATION_KEEP = datas.data;

        }, function () { });

        var data_lct = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1('1', sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_lct.then(function (datas) {
            $scope.REF_LOCATION = datas.data;

        }, function () { });
    };

    $scope.Pageload_subtitute = function () {

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT_SUBTITUTE_AND_MOVE(sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.PROCESS, sessionStorage.LCN_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_LCN.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
        }, function () { });

        var data_keep = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_keep.then(function (datas) {
            $scope.REF_LOCATION_KEEP = datas.data;

        }, function () { });

        var data_lct = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1('1', sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_lct.then(function (datas) {
            $scope.REF_LOCATION = datas.data;

        }, function () { });
    };
    $scope.LoadPreviewExtend = function () {

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT_EXTEND_LCN(sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.PROCESS, sessionStorage.LCN_IDA, sessionStorage.IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_EXTEND = datas.data;
            $scope.LIST_EXTEND.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_EXTEND.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
        }, function () { });
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/AUTHEN/FRM_STAFF_MAIN');
    };

    $scope.BTN_LCN_CONFIRM = function (STATUS_ID) {
        Swal.fire({
            title: 'คุณต้องการส่งใช่หรือไม่ ?',
            text: "กรุณาตรวจสอบความถูกต้องก่อนอนุมัติ!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'ใช่, ฉันต้องการส่งข้อมูล',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.value) {
                if (STATUS_ID == '3') {
                    success_data('success');

                    var data_stat = CENTER_SV.SP_STATUS_SELECT_LCN_STAFF(sessionStorage.IDA, 2);
                    data_stat.then(function (datas) {
                        $scope.STAT_LIST = datas.data;

                    }, function () { });


                    
                } else if (STATUS_ID == '5') {
                    REDIRECT('/LCN_STAFF/FRM_EDIT_REQUEST');
                } else
                    REDIRECT('/KCN_STAFF/FRM_DH_STAFF_REMARK');
            }
        });
    };

    $scope.BTN_REQUEST = function (DES, REQUEST_DATE) {
        Swal.fire({
            title: 'คุณต้องการส่งใช่หรือไม่ ?',
            text: "กรุณาตรวจสอบความถูกต้องก่อนส่ง!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'ใช่, ฉันต้องการส่งข้อมูล',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.value) {
                success_data('SUCCESS');
                REDIRECT('/AUTHEN/FRM_STAFF_MAIN');
            }
        });
        
    };

    $scope.ADD_FILE_LIST = function () {
        var obj = {
            TR_ID: '',
            DES: '',
            FILENAME: '',
            FILE_DATA: '',
            PATH: '',
            FLAG: '',
            TYPE: '',
            SIZE: 0
        };
        $scope.DOC_LIST.FILE_LISTs.push(obj);
    };
    $scope.deleteRow = function (datas, i) {

        if (datas.PIORITY == 'HIGH') {
            ERR_DATA(datas.DES + ' : เป็นเอกสารบังคับไม่สามารถลบออกได้');
        } else if (datas.PIORITY == 'LOW') {
            ERR_DATA(datas.DES + ' : ไม่สามารถลบออกได้');
        } else 
            $scope.DOC_LIST.FILE_LISTs.splice(i, 1);
    };
});