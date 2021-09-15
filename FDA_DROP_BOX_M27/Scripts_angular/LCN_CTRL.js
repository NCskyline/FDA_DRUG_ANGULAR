app.controller('LCN_CTRL', function ($scope, CENTER_SV, $http, $location) {

   // CHK_TOKEN();
    $scope.CITIZEN = "";
    $scope.lcnno = "";
    $scope.COLLECT_KEEP = [];
    $scope.COLLECT_PHR = [];
    //var LCN_IDA = 70911;//sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;  //
    var PROCESS = sessionStorage.PROCESS; //QueryString("PROCESS");
    var CITIZEN = '0105527028430';//'0105527028430';0000000000000
    //var BSN_IDENTIFY = "1710500118665";
    var IDENTIFY = sessionStorage.CITIZEN_ID_AUTHORIZE; //"0000000000000";
    //var IDENTIFY = '0000000000000';
    var HEAD_LCN_IDA = sessionStorage.HEAD_LCN_IDA;
    //var LCT_IDA = 117194;
    

    Pageload();
    LOAD_MODEL();

    function LOAD_MODEL() {

        var data = CENTER_SV.GET_FULLDATA_LCN();
        data.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

        }, function () { });
    }

    function Pageload() {

        //listree();
    //    var data_prefix = CENTER_SV.SP_SYSPREFIX();
    //    data_prefix.then(function (datas) {
    //        $scope.PREFIX = datas.data;

    //    }, function () { });

    //}
        var data_prefix = CENTER_SV.SP_SYSPREFIX_PERSON();
        data_prefix.then(function (datas) {
            $scope.PREFIX = datas.data;

        }, function () { });

        var data_phr_job = CENTER_SV.SP_PHR_JOB();
        data_phr_job.then(function (datas) {
            $scope.CNT_functnm = datas.data;

        }, function () { });

        //$scope.PROCESS_ID = '101';//sessionStorage.DH_PROCESS_ID;
        //var IDA = sessionStorage.IDA;

        //if ($scope.PROCESS_ID == '101') {
        //    $scope.INPUT = SET_URL_SV('/LCN/INPUTdalcn_output_1');
        //}
        //else if ($scope.PROCESS_ID == '102') {
        //    $scope.INPUT = SET_URL_SV('/LCN/INPUTdalcn_output_2');
        //}
        //else if ($scope.PROCESS_ID == '103') {
        //    $scope.INPUT = SET_URL_SV('/LCN/INPUTdalcn_output_3');
        //}
        //else if ($scope.PROCESS_ID == '104') {
        //    $scope.INPUT = SET_URL_SV('/LCN/INPUTdalcn_output_4');
        //}
        var process = QueryString("PROCESS");
        if (process == '101') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขย1)';
        } else if (process == '103') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขย3)';
        } else if (process == '104') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขย4)';
        } else if (process == '105') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(นย1)';
        } else if (process == '106') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ผย1)';
        } else if (process == '107') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขยบ)';
        } else if (process == '108') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(นยบ)';
        } else if (process == '109') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ผยบ)';
        } else $scope.lcnnoType = '';



          var data_lcn = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(sessionStorage.LCT_IDA, QueryString("PROCESS"), sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_lcn.then(function (datas) {
            $scope.DATA_LCN_MAIN = datas.data;
            //$scope.DATA_LCN_MAIN.lcnnoType = $scope.lcnnoType;
        }, function () { });



    }


    $scope.BTN_MENU = function (process) {

        if (process == '101' || process == '103' || process == '104' || process == '105' || process == '106' || process == '107' || process == '108' || process == '109') {
            if (process == '101') {
                $scope.lcnnoType = '(ขย1)';
            } else if (process == '103') {
                $scope.lcnnoType = '(ขย3)';
            } else if (process == '104') {
                $scope.lcnnoType = '(ขย4)';
            } else if (process == '105') {
                $scope.lcnnoType = '(นย1)';
            } else if (process == '106') {
                $scope.lcnnoType = '(ผย1)';
            } else if (process == '107') {
                $scope.lcnnoType = '(ขยบ)';
            } else if (process == '108') {
                $scope.lcnnoType = '(นยบ)';
            } else if (process == '109') {
                $scope.lcnnoType = '(ผยบ)';
            } else $scope.lcnnoType = '';

            $scope.FULL_MODEL.PROCESS = process;
            //$scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
            REDIRECT('/LCN/FRM_SELECT_LCT?PROCESS=' + process);



            //$scope.FULL_MODEL.FUNC_CODE = "FUNC-DATA-REQUEST";
            ////var Getdata = CENTER_SV.GET_FULLDATA_LCN($scope.FULL_MODEL);
            ////Getdata.then(function (datas) {
            ////    $scope.DATA_LCN_MAIN = datas.data;
            ////}, function () { });

            //var data_lcn = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(LCT_IDA, process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            //data_lcn.then(function (datas) {
            //    $scope.DATA_LCN_MAIN = datas.data;

            //}, function () { });

        } else if (process == '123' || process == '124' || process == '125' || process == '126' || process == '131' || process == '132' || process == '133' || process == '134') {
            if (process == '123') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯในประเภท ๓)';
            } else if (process == '124') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯในประเภท ๔)';
            } else if (process == '125') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๓)';
            } else if (process == '126') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๔)';
            } else if (process == '131') {
                $scope.lcnnoType = '(นย1) > (นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๓)';
            } else if (process == '132') {
                $scope.lcnnoType = '(นย1) > (นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๔)';
            } else if (process == '133') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๓)';
            } else if (process == '134') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๔)';
            } else $scope.lcnnoType = '';

            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_NCT_SEARCH');
            var dataLo = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            dataLo.then(function (datas) {
                $scope.DATA_LCN_LIST = datas.data;
            }, function () { });

        } else if (process == '14' || process == '15' || process == '16') {
            if (process == '14') {
                $scope.lcnnoType = '(นย1) > (นำเข้ายาเสพติดให้โทษในประเภท ๓)';
            } else if (process == '15') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกยาเสพติดให้โทษในประเภท ๓)';
            } else if (process == '16') {
                $scope.lcnnoType = '(ขย1) > (จำหน่ายยาเสพติดให้โทษในประเภท ๓)';
            } else $scope.lcnnoType = '';

            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_NCT_SEARCH');
            var data = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            data.then(function (datas) {
                $scope.DATA_LCN_LIST = datas.data;
            }, function () { });

        } else if (process == '127' || process == '128') {
            if (process == '127') {
                $scope.lcnnoType = '(ผย1) > (ผลิตวัตถุออกฤทธิ์ฯในประเภท ๓)';
            } else if (process == '128') {
                $scope.lcnnoType = '(ผย1) > (ผลิตวัตถุออกฤทธิ์ฯในประเภท ๔)';
            } else $scope.lcnnoType = '';

            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_NCT_SEARCH');
            var data1 = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            data1.then(function (datas) {
                $scope.DATA_LCN_LIST = datas.data;
            }, function () { });

        } else if (process == '114') {
            $scope.lcnnoType = '(ผย1) > (ผลิตยาเสพติดให้โทษในประเภท ๓)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_NCT_SEARCH');
            var data2 = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            data2.then(function (datas) {
                $scope.DATA_LCN_LIST = datas.data;
            }, function () { });
        }
    };

    $scope.BTN_INPUT = function () {

        if (QueryString("PROCESS") == '101') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUTdalcn_output_1');
        } else if (QueryString("PROCESS") == '103') {
            REDIRECT('/LCN/INPUTdalcn_output_3');
            sessionStorage.HEAD_LCN_IDA = 0;
        } else if (QueryString("PROCESS") == '104') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUTdalcn_output_4');
        } else if (QueryString("PROCESS") == '105') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUT_NORYOR_1');
        } else if (QueryString("PROCESS") == '106') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUT_PORYOR_1');
        } else if (QueryString("PROCESS") == '107' || QueryString("PROCESS") == '108' || QueryString("PROCESS") == '109') {         
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUT_DA_YORBOR?PROCESS=' + QueryString("PROCESS"));
        }
    };

    $scope.YORBOR = function () {
        if ($scope.PROCESS == '107') {
            $scope.headLCN = 'ขายยาแผนโบราณ';
        } else if ($scope.PROCESS == '108') {
            $scope.headLCN = 'นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร';
        } else if ($scope.PROCESS == '109') {
            $scope.headLCN = 'ผลิตยาแผนโบราณ';
        }
    };

    $scope.Search_lcnno = function (CITIZEN, lcnno, pvncd) {
        var GetData = CENTER_SV.SP_GET_DATA_LCN(CITIZEN, lcnno, pvncd);
        GetData.then(function (datas) {
            $scope.LIST_LCN = datas.data;
        }, function () { });
    };

    
    $scope.GET_LCT_LIST = function () {
        var GetData = CENTER_SV.SP_CUSTOMER_DALCN_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_LCNSID('1', sessionStorage.CITIZEN_ID_AUTHORIZE);
        GetData.then(function (datas) {
            $scope.LIST_LCTS = datas.data;
        }, function () { });
    };

    $scope.SELECT_LCTS = function (datas) {
        sessionStorage.LCT_IDA = datas.IDA;
        sessionStorage.PROCESS = QueryString("PROCESS");
        //REDIRECT('/LCN/FRM_LCN_NEWS');
        //$scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');

        

        REDIRECT('/LCN/FRM_LCN_DRUG?PROCESS=' + QueryString("PROCESS"));
        //$scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
       


        //$scope.FULL_MODEL.FUNC_CODE = "FUNC-DATA-REQUEST";
        //var data_lcn = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(sessionStorage.LCT_IDA, process, sessionStorage.CITIZEN_ID_AUTHORIZE);
        //data_lcn.then(function (datas) {
        //    $scope.DATA_LCN_MAIN = datas.data;
        //    //$scope.DATA_LCN_MAIN.lcnnoType = $scope.lcnnoType;
        //}, function () { });

    };




    $scope.SELECT_LCN = function (datas) {
        sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN;
        sessionStorage.LCNNO = datas.lcnno;
       
        var url = "/LCN/FRM_LCN_STAFF_LCN_INFORMATION";
        REDIRECT(url);
    };

    $scope.SELECT_LCN_HEAD = function (datas, lcnnotype) {
        $scope.lcnnoType = lcnnotype;
        $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        $scope.FULL_MODEL.PROCESS = datas.PROCESS_LCN;

        //$scope.FULL_MODEL.FUNC_CODE = "FUNC-DATA-REQUEST";
        var data_keep = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(datas.LCT_IDA, datas.PROCESS_LCN, IDENTIFY);
        data_keep.then(function (datas) {
            $scope.DATA_LCN_MAIN = datas.data;

        }, function () { });
    };


    $scope.BTN_EXTEND = function () {
        if (QueryString('staff') == '') {
            var url = 'https://medicina.fda.moph.go.th/FDA_DRUG_EXT/AUTHEN/AUTHEN_GATEWAY?Token=' + sessionStorage.TOKEN + '&identify=' + sessionStorage.IDENTIFY;
            window.open(url, '_blank').focus();
            //REDIRECT();
        } else {
            var url1 = 'https://medicina.fda.moph.go.th/FDA_DRUG_EXT/AUTHEN/AUTHEN_GATEWAY?Token=' + sessionStorage.TOKEN + '&identify=' + sessionStorage.IDENTIFY + '&staff=1';
            window.open(url1, '_blank').focus();
            //REDIRECT();
        }
        
    };
    $scope.RELOAD_PAGE = function () {
        location.reload();
    };
    $scope.pageload = function () {
        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT(BSN_IDENTIFY, IDENTIFY, LCT_IDA, HEAD_LCN_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_LCN.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
        }, function () { });

        
        //var data_keep = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(LCT_IDA, PROCESS,IDENTIFY);
        //data_keep.then(function (datas) {
        //    $scope.DATA_LCN_MAIN = datas.data;

        //}, function () { });

        var data_keep1 = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', IDENTIFY);
        data_keep1.then(function (datas) {
            $scope.REF_LOCATION_KEEP = datas.data;

        }, function () { });

        //var data_lct = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2('1', IDENTIFY);
        //data_lct.then(function (datas) {
        //    $scope.REF_LOCATION = datas.data;

        //}, function () { });

        //if ($scope.LIST_EXTEND.YEAR_SELECT == "1") {
        //    var _YEAR = new Date().getFullYear();
        //    if (_YEAR < 2500) {
        //        _YEAR = _YEAR + 544;
        //    }
        //    var data_lct1 = CENTER_SV.SP_LCN_EXTEND_REQUEST_BY_IDENTIFY_YEAR(IDENTIFY, _YEAR);
        //    data_lct1.then(function (datas) {
        //        $scope.LIST_EXTEND = datas.data;

        //    }, function () { });

        //} else {
        //    var data_lct2 = CENTER_SV.SP_LCN_EXTEND_REQUEST_BY_IDENTIFY(IDENTIFY);
        //    data_lct2.then(function (datas) {
        //        $scope.LIST_EXTEND = datas.data;

        //    }, function () { });

        //}

        var datakeep = CENTER_SV.SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(LCN_IDA);
        datakeep.then(function (datas) {
            $scope.DATA_KEEP_SHOW = datas.data;
        }, function () { });

        var dataPHR = CENTER_SV.SP_DALCN_PHR_BY_FK_IDA_2(LCN_IDA);
        dataPHR.then(function (datas) {
            $scope.DATA_PHR_SHOW = datas.data;
        }, function () { });

        var localist = CENTER_SV.SETMODEL_LOCATION();
        localist.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });
    };





    //var myApp = angular.module("ANGULAR_APP", []);
    //myApp.controller("LCN_CTRL", function ($scope) {
    //    $scope.BSN_IDEN = '';
    //    $scope.getData_bsn = function (LIST_LCN) {
    //        BSN_IDENTIFY = angular.copy(LIST_LCN.BSN_IDENTIFY);
    //    };
    //});



    ////var BSN_IDEN = document.getElementsByName('txt_bsn_identify')[0].value
    //$scope.Search_BSN = function () {
    //    var GetData = CENTER_SV.GET_LCN_INFORMATION_BSN_INPUT(BSN_IDENTIFY);
    //    GetData.then(function (datas) {
    //        $scope.LIST_LCN = datas.data;
    //    }, function () { });
    //};
    $scope.getdetails = function (IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
        Data_location.then(function (datas) {
            //$scope.LIST_LABEL = datas.data;
            //$scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr;
            
        }, function () { });

    };

    $scope.getdetails_extend = function (ddl_selected) {
        var _YEAR = new Date().getFullYear();
        if (_YEAR < 2500) {
            _YEAR = _YEAR + 544;
        }

        if (ddl_selected == "1") {

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
    };

    $scope.SELECT_LCN = function (datas) {
        sessionStorage.LCN_IDA = datas.IDA;
        //sessionStorage.STAGE = 'SHOW';
        //sessionStorage.PREVIEW_CERT_IDA = datas.IDA;
        REDIRECT('/LCN/PREVIEW_INPUT_LCN');
    };


    $scope.getdetails_lct = function (IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
        Data_location.then(function (datas) {
            $scope.LIST_LABEL_LCT = datas.data;
            //$scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr;
        }, function () { });

    };

    $scope.getdetails_onload = function () {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LCT_IDA);
        Data_location.then(function (datas) {
            $scope.LIST_LABEL = datas.data;
            //$scope.LIST_LABEL.thanameplace = datas.data[0].thanameplace;
            //$scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr;
        }, function () { });

    };
    $scope.getdetails_phr = function () {
        var data_phr = CENTER_SV.GET_LCN_SUBTITUTE_INPUT(BSN_IDENTIFY, LCN_IDA);
        data_phr.then(function (datas) {

            $scope.LIST_PHR = datas.data;
        }, function () { });

    };
    
    $scope.getdetails_keep = function () {
        var data_phr = CENTER_SV.GET_LCN_SUBTITUTE_INPUT(BSN_IDENTIFY, LCN_IDA);
        data_phr.then(function (datas) {

            $scope.LIST_KEEP = datas.data;
        }, function () { });

    };

    $scope.BTN_Search_BSN = function (BSN_IDENTIFY) {

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT(BSN_IDENTIFY, sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.LCT_IDA);
        MODLE_LCN.then(function (datas) {
            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = PROCESS;
        }, function () { });
    };

    $scope.BTN_SAVE_EDIT = function () {

        var Getdata = CENTER_SV.INSERT_LCN_EDIT_RQT($scope.LIST_LCN,PROCESS);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/LCN/FRM_LCN_NEWS');
    };


    $scope.BTN_SAVE_LCN_INPUT = function () {
        $scope.LIST_LCN.session = sessionStorage;

        if (sessionStorage.PROCESS == '106') {
            if ($scope.LIST_LCN.dalcn.syslcnsid_identify == true) {
                $scope.LIST_LCN.dalcn.syslcnsid_identify = '1'
            } else {
                $scope.LIST_LCN.dalcn.syslcnsid_identify = '0'
            }

            if ($scope.LIST_LCN.dalcn.syslcnsid_lcnsid == true) {
                $scope.LIST_LCN.dalcn.syslcnsid_lcnsid = '1'
            } else {
                $scope.LIST_LCN.dalcn.syslcnsid_lcnsid = '0'
            }

            if ($scope.LIST_LCN.dalcn.lcnsid_crtlct == true) {
                $scope.LIST_LCN.dalcn.lcnsid_crtlct = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_crtlct = '0'
            }

            if ($scope.LIST_LCN.dalcn.lcnsid_chngwtcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_chngwtcd = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_chngwtcd = '0'
            }

            if ($scope.LIST_LCN.dalcn.lcnsid_ntcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_ntcd = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_ntcd = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_taxno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_taxno = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_taxno = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_trdregno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_trdregno = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_trdregno = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_ctzno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_ctzno = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_ctzno = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_remark == true) {
                $scope.LIST_LCN.dalcn.lcnsid_remark = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_remark = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_idst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_idst = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_idst = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_phrno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_phrno = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_phrno = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_stfcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_stfcd = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_stfcd = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_nmprnst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_nmprnst = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_nmprnst = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_lstfcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_lstfcd = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_lstfcd = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_lcnsidst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_lcnsidst = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_lcnsidst = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_scridst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_scridst = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_scridst = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_url == true) {
                $scope.LIST_LCN.dalcn.lcnsid_url = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_url = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_cncremark == true) {
                $scope.LIST_LCN.dalcn.lcnsid_cncremark = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_cncremark = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_email == true) {
                $scope.LIST_LCN.dalcn.lcnsid_email = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_email = '0'
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_otaxno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_otaxno = '1'
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_otaxno = '0'
            }

        }

        var Getdata = CENTER_SV.INSERT_LCN_INPUT_NEW($scope.LIST_LCN, $scope.COLLECT_KEEP,$scope.COLLECT_PHR, PROCESS,sessionStorage.LCT_IDA);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });

            //REDIRECT('/LCN/FRM_LCN_DRUG?PROCESS=' + sessionStorage.PROCESS);
        });

    };

    $scope.BTN_ADD_KEEP = function (datas,IDA) {
        if (IDA == '') {
            Swal.fire({
                title: 'ERROR',
                text: 'กรุณาเลือกสถานที่เก็บ',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'
            });

        } else {
            var obj = {

                LOCATION_IDA: IDA,
                thanameplace: datas[0].thanameplace,
                fulladdr: datas[0].fulladdr

            };
            $scope.COLLECT_KEEP.push(obj);
        }

    };

    $scope.deleteKEEP = function (data, i) {
        $scope.COLLECT_KEEP.splice(i, 1);
    };

    $scope.BTN_ADD_PHR = function (datas) {

        if (datas.PHR_PREFIX_ID == '0' || datas.PHR_PREFIX_ID == '' || datas.PHR_NAME == '' || datas.PHR_CTZNO == '' || datas.PHR_TEXT_NUM == '') {
            Swal.fire({
                title: 'ERROR',
                text: 'กรุณากรอกข้อมูลให้ครบถ้วน',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'
            });

        } else {
            var obj = {
                    //IDA: Int32Array,
                    PHR_PREFIX_ID: datas.PHR_PREFIX_ID,
                    PHR_LEVEL: datas.PHR_LEVEL,
                    PHR_NAME: datas.PHR_NAME,
                    PHR_CTZNO: datas.PHR_CTZNO,
                    PHR_TEXT_NUM: datas.PHR_TEXT_NUM,
                    PHR_CHK_JOB: datas.PHR_CHK_JOB,
                    PHR_JOB_TYPE: datas.PHR_JOB_TYPE
                };
                $scope.COLLECT_PHR.push(obj);

        }
        


    };

    $scope.deletePHR = function (data, i) {
        $scope.COLLECT_PHR.splice(i, 1);
    };


});