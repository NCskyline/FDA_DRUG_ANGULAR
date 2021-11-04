app.controller('LCN_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    $scope.CITIZEN = "";
    $scope.lcnno = "";
    $scope.SUB_PATH = "";
    $scope.COLLECT_KEEP = [];
    $scope.COLLECT_PHR = [];
    $scope.PDF = [];
    //var LCN_IDA = 70911;//sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;  //
    var PROCESS = sessionStorage.PROCESS; //QueryString("PROCESS");
    //var CITIZEN = '0105527028430';//'0105527028430';0000000000000
    //var BSN_IDENTIFY = "1710500118665";
    var IDENTIFY = sessionStorage.CITIZEN_ID_AUTHORIZE; //"0000000000000";
    //var IDENTIFY = '0000000000000';
    var HEAD_LCN_IDA = sessionStorage.HEAD_LCN_IDA;
    //var LCT_IDA = 117194;

    $scope.currentPage = 0;
    $scope.paging = {
        total: 10,
        current: 1,
        onPageChanged: loadPages
    };
    function loadPages() {
        console.log('Current page is : ' + $scope.paging.current);

    //    // TODO : Load current page Data here

      $scope.currentPage = $scope.paging.current;
    }

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
        //var data_prefix = CENTER_SV.SP_SYSPREFIX();
        //data_prefix.then(function (datas) {
        //    $scope.PREFIX = datas.data;

        //}, function () { });

    //}
        var data_prefix = CENTER_SV.SP_SYSPREFIX_PERSON();
        data_prefix.then(function (datas) {
            $scope.PREFIX = datas.data;
            dropdown();

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
        var process = sessionStorage.PROCESS; //QueryString("PROCESS");
        if (process == '101') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขย1)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '103') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขย3)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '104') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขย4)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '105') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(นย1)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '106') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ผย1)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '107') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ขยบ)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '108') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(นยบ)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '109') {
            sessionStorage.HEAD_LCN_IDA = 0;
            $scope.lcnnoType = '(ผยบ)';
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        } else if (process == '123' || process == '124' || process == '125' || process == '126' || process == '131' || process == '132' || process == '133' || process == '134' || process == '127' || process == '128') {

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
            } else if (process == '127' || process == '128') {
                if (process == '127') {
                    $scope.lcnnoType = '(ผย1) > (ผลิตวัตถุออกฤทธิ์ฯในประเภท ๓)';
                } else if (process == '128') {
                    $scope.lcnnoType = '(ผย1) > (ผลิตวัตถุออกฤทธิ์ฯในประเภท ๔)';
                }

            }

            sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');

        } else if (sessionStorage.PROCESS == '114' || sessionStorage.PROCESS == '115' || sessionStorage.PROCESS == '116' || sessionStorage.PROCESS == '117') {
            if (sessionStorage.PROCESS == '114') {
                $scope.lcnnoType = '(ผย1) > (ผลิตซึ่งยาเสพติดให้โทษในประเภท ๓)';
            } else if (sessionStorage.PROCESS == '115') {
                $scope.lcnnoType = '(ขย1) > (จำหน่ายหรือมีไว้ในครอบครองเพื่อจำหน่ายซึ่งยาเสพติดให้โทษในประเภท ๓)';
            } else if (sessionStorage.PROCESS == '116') {
                $scope.lcnnoType = '(นย1) > (นำเข้าซึ่งยาเสพติดให้โทษในประเภท ๓)';
            } else if (sessionStorage.PROCESS == '117') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกซึ่งยาเสพติดให้โทษในประเภท ๓)';
            }

            sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');

        } else if (process == '11103' || process == '11104' || process == '11105' || process == '11106' || process == '11107' || process == '11108' || process == '11109' || process == '11110') {
            if (process == '11105') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ขายยาแผนปัจจุบัน';
            } else if (process == '11106') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ผลิตยาแผนปัจจุบัน';
            } else if (process == '11107') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา นำหรือสั่งยาแผนปัจจุบัน';
            } else if (process == '11108') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาแผนโบราณสำหรับสัตว์';
            } else if (process == '11109') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาเสพติดให้โทษประเภทที่ 3';
            } else if (process == '11103') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตขายวัตถุออกฤทธิ์';
            } else if (process == '11104') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตผลิตวัตถุออกฤทธิ์';
            } else if (process == '11110') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตนำเข้าวัตถุออกฤทธิ์';
            }

            sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_EDIT_REQUEST');


            var dataLo = CENTER_SV.SP_DALCN_EDIT_REQUEST_BY_FK_IDA(sessionStorage.LCN_IDA);
            dataLo.then(function (datas) {
                $scope.DATA_EDIT_LCN_RQT = datas.data;


            }, function () { });

        } else if (process == '100701' || process == '100702' || process == '100703' || process == '100704' || process == '100705' || process == '100766' || process == '100767' || process == '100768' || process == '100769' || process == '100770' || process == '100771' || process == '100772' || process == '100773' || process == '100774'|| process == '100775' || process == '100776' || process == '100777' || process == '100791' || process == '100792' || process == '100793' || process == '100794') {
            if (process == '100701') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตสถานที่ขายยาแผนปัจจุบัน';
            } else if (process == '100702') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตสถานที่นำเข้ายาแผนปัจจุบัน';
            } else if (process == '100703') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตสถานที่ผลิตยาแผนปัจจุบัน';
            } else if (process == '100704') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตใบอนุญาตยาแผนโบราณ';
            } else if (process == '100705') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาต ยาเสพติดให้โทษประเภทที่ 3';
            } else if (process == '100766') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100767') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100768') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100769') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100770') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100771') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100772') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100773') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100774') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100775') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100776') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม';
            } else if (process == '100777') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม';
            } else if (sessionStorage.PROCESS == '100791') {
                $scope.lcnnoType = 'คำขอย้ายสถานที่ ขายยาแผนปัจจุบัน';
            } else if (sessionStorage.PROCESS == '100792') {
                $scope.lcnnoType = 'คำขอย้ายสถานที่ นำเข้ายาแผนปัจจุบัน';
            } else if (sessionStorage.PROCESS == '100793') {
                $scope.lcnnoType = 'คำขอย้ายสถานที่ ผลิตยาแผนปัจจุบัน';
            } else if (sessionStorage.PROCESS == '100794') {
                $scope.lcnnoType = 'คำขอคำขอย้ายสถานที่ ยาแผนโบราณ สำหรับสัตว์';
            } 

            sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_SUBSTITUTE_MAIN');


            var DATA_STT = CENTER_SV.SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA(sessionStorage.LCN_IDA);
            DATA_STT.then(function (datas) {

                $scope.DATA_SUBTITUTE = datas.data;
            }, function () { });
        } 

        var dataLo1 = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
        dataLo1.then(function (datas) {
                $scope.DATA_LCN_LIST = datas.data;
                if (process >= 123) {
                        sessionStorage.LCT_IDA = datas.data[0].LCT_IDA;
                }

               
        }, function () { });
        
        var data_lcn = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(sessionStorage.LCT_IDA, sessionStorage.PROCESS, sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_lcn.then(function (datas) {
            $scope.DATA_LCN_MAIN = datas.data;
            $scope.DATA_LCN_MAIN.lcnnoType = $scope.lcnnoType;
            //$scope.currentPage = 1;
            //$scope.entryLimit = 20;
            //$scope.noOfPages = Math.ceil($scope.DATA_LCN_MAIN.length / $scope.entryLimit);
            //$scope.loading_profile = false;
            //$scope.product_show = true;
            //$scope.filteredItems = $scope.DATA_LCN_MAIN.length; //Initially for no filter
            //$scope.totalItems = $scope.DATA_LCN_MAIN.length;
        }, function () { });

        //get data edit rqt
        var dataLo2 = CENTER_SV.SP_DALCN_EDIT_REQUEST_BY_FK_IDA(sessionStorage.LCN_IDA);
        dataLo2.then(function (datas) {
            $scope.DATA_LCN_LIST = datas.data;
           
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
            sessionStorage.PROCESS = process;
            //$scope.SUB_PATH = SET_URL_SV('/LCN/FRM_SELECT_LCT');
            REDIRECT('/LCN/FRM_SELECT_LCT?PROCESS=' + process);
            //REDIRECT('/LCN/FRM_SELECT_LCT?PROCESS=' + process);



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

            sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_NCT_SEARCH');
            var dataLo = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            dataLo.then(function (datas) {
                $scope.DATA_LCN_LIST = datas.data;
            }, function () { });

        } else if (process == '116' || process == '117' || process == '115') {
            if (process == '116') {
                $scope.lcnnoType = '(นย1) > (นำเข้ายาเสพติดให้โทษในประเภท ๓)';
            } else if (process == '117') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกยาเสพติดให้โทษในประเภท ๓)';
            } else if (process == '115') {
                $scope.lcnnoType = '(ขย1) > (จำหน่ายยาเสพติดให้โทษในประเภท ๓)';
            } else $scope.lcnnoType = '';
            sessionStorage.PROCESS = process;
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
        } else if (process == '11103' || process == '11104' || process == '11105' || process == '11106' || process == '11107' || process == '11108' || process == '11109' || process == '11110') {
            if (process == '11105') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ขายยาแผนปัจจุบัน';
            } else if (process == '11106') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ผลิตยาแผนปัจจุบัน';
            } else if (process == '11107') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา นำหรือสั่งยาแผนปัจจุบัน';
            } else if (process == '11108') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาแผนโบราณสำหรับสัตว์';
            } else if (process == '11109') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาเสพติดให้โทษประเภทที่ 3';
            } else if (process == '11103') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตขายวัตถุออกฤทธิ์';
            } else if (process == '11104') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตผลิตวัตถุออกฤทธิ์';
            } else if (process == '11110') {
                $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตนำเข้าวัตถุออกฤทธิ์';
            }

            sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_SELECT');
            var data3 = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN_ALIVE(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            data3.then(function (datas) {
                $scope.DATA_LCN_F_EDIT = datas.data;
            }, function () { });

        } else if (process == '100701' || process == '100702' || process == '100703' || process == '100704' || process == '100705' || process == '100766' || process == '100767' || process == '100768' || process == '100769' || process == '100770' || process == '100771' || process == '100772' || process == '100773' || process == '100774'|| process == '100775' || process == '100776' || process == '100777' || process == '100791' || process == '100792' || process == '100793' || process == '100794') {
            if (process == '100701') {
                $scope.lcnnoType = 'ใบแทน สถานที่ขายยาแผนปัจจุบัน';
            } else if (process == '100702') {
                $scope.lcnnoType = 'ใบแทน สถานที่นำเข้ายาแผนปัจจุบัน';
            } else if (process == '100703') {
                $scope.lcnnoType = 'ใบแทน สถานที่ผลิตยาแผนปัจจุบัน';
            } else if (process == '100704') {
                $scope.lcnnoType = 'ใบแทน ใบอนุญาตยาแผนโบราณ';
            } else if (process == '100705') {
                $scope.lcnnoType = 'ใบแทน ยาเสพติดให้โทษประเภทที่ 3';
            } else if (process == '100766') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100767') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100768') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100769') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100770') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100771') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100772') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100773') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100774') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3';
            } else if (process == '100775') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4';
            } else if (process == '100776') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม';
            } else if (process == '100777') {
                $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4 ประชุม';
            }

            else if (process == '100791') {
                $scope.lcnnoType = 'คำขอย้ายสถานที่ ขายยาแผนปัจจุบัน';
            } else if (process == '100792') {
                $scope.lcnnoType = 'คำขอย้ายสถานที่ นำเข้ายาแผนปัจจุบัน';
              
            } else if (process == '100793') {
                $scope.lcnnoType = 'คำขอย้ายสถานที่ ผลิตยาแผนปัจจุบัน';
              
            } else if (process == '100794') {
                $scope.lcnnoType = 'คำขอคำขอย้ายสถานที่ ยาแผนโบราณ สำหรับสัตว์';
                
            } 

            sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_SELECT');
            var data4 = CENTER_SV.SP_LCN_BY_PROCESS_AND_IDEN_ALIVE(process, sessionStorage.CITIZEN_ID_AUTHORIZE);
            data4.then(function (datas) {
                $scope.DATA_LCN_F_EDIT = datas.data;
            }, function () { });
        }

    };

    $scope.BTN_EDIT = function () {
        REDIRECT('/LCN/FRM_LCN_EDIT_RETURN');
    };

    $scope.BTN_INPUT = function () {

        if (sessionStorage.PROCESS == '101') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUTdalcn_output_1');
        } else if (sessionStorage.PROCESS == '103') {
            REDIRECT('/LCN/INPUTdalcn_output_3');
            sessionStorage.HEAD_LCN_IDA = 0;
        } else if (sessionStorage.PROCESS == '104') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUTdalcn_output_4');
        } else if (sessionStorage.PROCESS == '105') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUT_NORYOR_1');
        } else if (sessionStorage.PROCESS == '106') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUT_PORYOR_1');
        } else if (sessionStorage.PROCESS == '107' || sessionStorage.PROCESS == '108' || sessionStorage.PROCESS == '109') {
            sessionStorage.HEAD_LCN_IDA = 0;
            REDIRECT('/LCN/INPUT_DA_YORBOR?PROCESS=' + sessionStorage.PROCESS);
        } else if (sessionStorage.PROCESS == '123' || sessionStorage.PROCESS == '124' || sessionStorage.PROCESS == '125' || sessionStorage.PROCESS == '126' || sessionStorage.PROCESS == '131' || sessionStorage.PROCESS == '132' || sessionStorage.PROCESS == '133' || sessionStorage.PROCESS == '134') {
            if (sessionStorage.PROCESS == '123') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯในประเภท ๓)';
                REDIRECT('/LCN/INPUT_BOJOD_3_4_1');
            } else if (sessionStorage.PROCESS == '124') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯในประเภท ๔)';
                REDIRECT('/LCN/INPUT_BOJOD_3_4_1');
            } else if (sessionStorage.PROCESS == '125') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๓)';
                REDIRECT('/LCN/INPUT_BOJOD_3_4_2');
            } else if (sessionStorage.PROCESS == '126') {
                $scope.lcnnoType = '(ขย1) > (ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๔)';
                REDIRECT('/LCN/INPUT_BOJOD_3_4_2');
            } else if (sessionStorage.PROCESS == '131') {
                $scope.lcnnoType = '(นย1) > (นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๓)';

                REDIRECT('/LCN/INPUT_NORDOJ_3_4_1');
            } else if (sessionStorage.PROCESS == '132') {
                $scope.lcnnoType = '(นย1) > (นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๔)';
                REDIRECT('/LCN/INPUT_NORDOJ_3_4_1');
            } else if (sessionStorage.PROCESS == '133') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๓)';
                REDIRECT('/LCN/INPUT_SORDOJ_3_4_1');

            } else if (sessionStorage.PROCESS == '134') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๔)';
                REDIRECT('/LCN/INPUT_SORDOJ_3_4_1');
            } 
        } else if (sessionStorage.PROCESS == '114' || sessionStorage.PROCESS == '115' || sessionStorage.PROCESS == '116' || sessionStorage.PROCESS == '117') {
            if (sessionStorage.PROCESS == '114') {
                $scope.lcnnoType = '(ผย1) > (ผลิตซึ่งยาเสพติดให้โทษในประเภท ๓)';
                REDIRECT('/LCN/INPUT_PDF_YOR_SOR_3_1');
            } else if (sessionStorage.PROCESS == '115') {
                $scope.lcnnoType = '(ขย1) > (จำหน่ายหรือมีไว้ในครอบครองเพื่อจำหน่ายซึ่งยาเสพติดให้โทษในประเภท ๓)';
                REDIRECT('/LCN/INPUT_PDF_YOR_SOR_3_1');
            } else if (sessionStorage.PROCESS == '116') {
                $scope.lcnnoType = '(นย1) > (นำเข้าซึ่งยาเสพติดให้โทษในประเภท ๓)';
                REDIRECT('/LCN/INPUT_PDF_YOR_SOR_3_1');
            } else if (sessionStorage.PROCESS == '117') {
                $scope.lcnnoType = '(ขย1) > (ส่งออกซึ่งยาเสพติดให้โทษในประเภท ๓)';
                REDIRECT('/LCN/INPUT_PDF_YOR_SOR_3_1');
            }
        }
    };
    
    $scope.BTN_EDIT_INPUT = function () {
        if (sessionStorage.PROCESS == '11105') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ขายยาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_KORYOR17');
        } else if (sessionStorage.PROCESS == '11106') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ผลิตยาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_PORYOR12');
        } else if (sessionStorage.PROCESS == '11107') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา นำหรือสั่งยาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_NORYOR11');
        } else if (sessionStorage.PROCESS == '11108') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาแผนโบราณสำหรับสัตว์';
            REDIRECT('/LCN/INPUT_YORBOR16');
        } else if (sessionStorage.PROCESS == '11109') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาเสพติดให้โทษประเภทที่ 3';
            REDIRECT('/LCN/INPUT_YORSOR3_ALL_EDIT');
        } else if (sessionStorage.PROCESS == '11103') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตขายวัตถุออกฤทธิ์';
            REDIRECT('/LCN/INPUT_MODIFY_BOJOD3_4');
        } else if (sessionStorage.PROCESS == '11104') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตผลิตวัตถุออกฤทธิ์';
            REDIRECT('/LCN/INPUT_MODIFY_PORDOJ_3_2');
        } else if (sessionStorage.PROCESS == '11110') {
            $scope.lcnnoType = 'แก้ไขเปลี่ยนแปลงใบอนุญาตนำเข้าวัตถุออกฤทธิ์';
            REDIRECT('/LCN/INPUT_MODIFY_NORDOJ_3_4');
        }
    };

    $scope.BTN_INPUT_STT = function () {
        if (sessionStorage.PROCESS == '100701') {
            $scope.lcnnoType = 'ใบแทน สถานที่ขายยาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_KORYOR16');
        } else if (sessionStorage.PROCESS == '100702') {
            $scope.lcnnoType = 'ใบแทน สถานที่นำเข้ายาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_NORYOR10');
        } else if (sessionStorage.PROCESS == '100703') {
            $scope.lcnnoType = 'ใบแทน สถานที่ผลิตยาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_PORYOR10');
        } else if (sessionStorage.PROCESS == '100704') {
            $scope.lcnnoType = 'ใบแทน ใบอนุญาตยาแผนโบราณ';
            REDIRECT('/LCN/INPUT_YORBOR_14');
        } else if (sessionStorage.PROCESS == '100705') {
            $scope.lcnnoType = 'ใบแทน ยาเสพติดให้โทษประเภทที่ 3';
            REDIRECT('/LCN/INPUT_KORYOR17');
        } else if (sessionStorage.PROCESS == '100766') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 3';
            REDIRECT('/LCN/INPUT_BOJOD_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100767') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 4';
            REDIRECT('/LCN/INPUT_BOJOD_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100768') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 3';
            REDIRECT('/LCN/INPUT_PORDOJ_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100769') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 4';
            REDIRECT('/LCN/INPUT_PORDOJ_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100770') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 3';
            REDIRECT('/LCN/INPUT_NORDOJ_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100771') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 4';
            REDIRECT('/LCN/INPUT_NORDOJ_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100772') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 3';
            REDIRECT('/LCN/INPUT_SORDOJ_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100773') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 4';
            REDIRECT('/LCN/INPUT_SORDOJ_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100774') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3';
            REDIRECT('/LCN/INPUT_BOJOD_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100775') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4';
            REDIRECT('/LCN/INPUT_BOJOD_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100776') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม';
            REDIRECT('/LCN/INPUT_BOJOD_3_4_1_Tan');
        } else if (sessionStorage.PROCESS == '100777') {
            $scope.lcnnoType = 'คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม';
            REDIRECT('/LCN/INPUT_BOJOD_3_4_1_Tan');
        }

        else if (sessionStorage.PROCESS == '100791') {
            $scope.lcnnoType = 'คำขอย้ายสถานที่ ขายยาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_KORYOR16');
        } else if (sessionStorage.PROCESS == '100792') {
            $scope.lcnnoType = 'คำขอย้ายสถานที่ นำเข้ายาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_NORYOR10');
        } else if (sessionStorage.PROCESS == '100793') {
            $scope.lcnnoType = 'คำขอย้ายสถานที่ ผลิตยาแผนปัจจุบัน';
            REDIRECT('/LCN/INPUT_PORYOR10');
        } else if (sessionStorage.PROCESS == '100794') {
            $scope.lcnnoType = 'คำขอคำขอย้ายสถานที่ ยาแผนโบราณ สำหรับสัตว์';
            REDIRECT('/LCN/INPUT_YORBOR_14');
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

    $scope.EDIT_LCN = function () {
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
        } else $scope.lcnnoType = '';

        var getData_LIST = CENTER_SV.SETMODEL_LIST_LCN(process);
        getData_LIST.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT_V2(sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.LCT_IDA, LCN_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_LCN.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
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

    $scope.SELECT_LCTS = function (datas) {
        sessionStorage.LCT_IDA = datas.IDA;
        sessionStorage.PROCESS = QueryString("PROCESS");
        REDIRECT('/LCN/FRM_LCN_NEWS');
        //$scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');

        

        //REDIRECT('/LCN/FRM_LCN_DRUG?PROCESS=' + QueryString("PROCESS"));
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
        //$scope.SUB_PATH = SET_URL_SV('/LCN/FRM_LCN_DRUG');
        sessionStorage.HEAD_LCN_IDA = datas.IDA;
        $scope.FULL_MODEL.PROCESS = datas.PROCESS_LCN;
        REDIRECT("/LCN/FRM_LCN_NEWS");


        //$scope.FULL_MODEL.FUNC_CODE = "FUNC-DATA-REQUEST";
        //var data_keep = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(datas.LCT_IDA, datas.PROCESS_LCN, IDENTIFY);
        //data_keep.then(function (datas) {
        //    $scope.DATA_LCN_MAIN = datas.data;

        //}, function () { });
    };
    $scope.SELECT_LCN_EDIT = function (datas) {
        sessionStorage.LCN_IDA = datas.IDA;

        var url = "/LCN/FRM_LCN_NEWS";
        REDIRECT(url);
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

        var process = sessionStorage.PROCESS;
        var LCN_IDA = sessionStorage.LCN_IDA;
        $scope.FILE_ATTACH = SET_URL_SV('/LCN/INPUT_F_D2_198_1_UPFILE_N');
     
        var getData_LIST = CENTER_SV.SETMODEL_LIST_LCN(process);
        getData_LIST.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT_V2(sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.LCT_IDA, LCN_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_LCN.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
            var TR_ID = $scope.LIST_LCN.dalcn.TR_ID;
            var PROCESS = $scope.LIST_LCN.dalcn.PROCESS_ID;
            if (TR_ID != null) {
                var File = CENTER_SV.GETDATA_FILE_TR_ID_TYPE(TR_ID, PROCESS);
                File.then(function (datas) {
                    $scope.LIST_File = datas.data;
                }, function () { });
            }
            

        }, function () { });

        
        var MODEL_HEAD = CENTER_SV.GET_HEAD_LCN_INFORMATION_INPUT(LCN_IDA);
        MODEL_HEAD.then(function (datas) {

            $scope.LIST_HEAD_LCN = datas.data;
        }, function () { });
        
        var data_keep = CENTER_SV.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(sessionStorage.LCT_IDA, sessionStorage.PROCESS, sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_keep.then(function (datas) {
            $scope.DATA_LCN_MAIN = datas.data;
           
        }, function () { });



        var data_keep1 = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('1', sessionStorage.CITIZEN_ID_AUTHORIZE);
        data_keep1.then(function (datas) {
            $scope.REF_LOCATION_KEEP = datas.data;
            dropdown();
        }, function () { });

        var data_prefix = CENTER_SV.SP_SYSPREFIX_PERSON();
        data_prefix.then(function (datas) {
            $scope.PREFIX = datas.data;
            dropdown();
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

    function dropdown() {
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        });
    }

    $scope.pageload_modify = function () {

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

    
    $scope.pageload_subtitute = function () {

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
            $scope.LIST_LABEL = datas.data;
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


    $scope.getdetails_lct = function (LOCATION_ADDRESS_IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LOCATION_ADDRESS_IDA);
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
            $scope.TEMP_LCN = $scope.LIST_LCN;
            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = PROCESS;
            $scope.LIST_LCN.dalcn.WRITE_AT = $scope.TEMP_LCN.dalcn.WRITE_AT;
            $scope.LIST_LCN.dalcn.WRITE_DATE = $scope.TEMP_LCN.dalcn.WRITE_DATE;
            $scope.LIST_LCN.dalcn.NATION = $scope.TEMP_LCN.dalcn.NATION;
            $scope.LIST_LCN.dalcn.opentime = $scope.TEMP_LCN.dalcn.opentime;
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

    
    $scope.BTN_SAVE_STT = function () {

        var Getdata = CENTER_SV.INSERT_LCN_SUBTITUTE($scope.LIST_LCN , sessionStorage.LCN_IDA, PROCESS);
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

    $scope.BTN_LCN_BACK = function () {
        //REDIRECT('/LCN/FRM_LCN_DRUG?PROCESS=' + sessionStorage.PROCESS);
        REDIRECT('/LCN/FRM_LCN_NEWS');
    };

    $scope.BTN_PREVIEW = function (data) {
        sessionStorage.LCN_IDA = data.IDA;
        sessionStorage.PROCESS_ID = data.PROCESS_ID;
        REDIRECT('/LCN/PREVIEW_INPUT_LCN');
    };

    $scope.BTN_EDIT_PREVIEW = function (data) {
        sessionStorage.LCT_IDA = data.LCT_IDA;
        //sessionStorage.PROCESS = data.PROCESS;
        REDIRECT('/LCN/PREVIEW_EDIT_LCN');
    };

    $scope.BTN_SUBTITUTE_PREVIEW = function (data) {
        sessionStorage.LCN_IDA = data.IDA;
        REDIRECT('/LCN/PREVIEW_SUBTITUTE_LCN');
    };

    $scope.BTN_SAVE_LCN_INPUT = function () {
        $scope.LIST_LCN.session = sessionStorage;

        if (sessionStorage.PROCESS == '106') {
            if ($scope.LIST_LCN.dalcn.syslcnsid_identify == true) {
                $scope.LIST_LCN.dalcn.syslcnsid_identify = '1';
            } else {
                $scope.LIST_LCN.dalcn.syslcnsid_identify = '0';
            }

            if ($scope.LIST_LCN.dalcn.syslcnsid_lcnsid == true) {
                $scope.LIST_LCN.dalcn.syslcnsid_lcnsid = '1';
            } else {
                $scope.LIST_LCN.dalcn.syslcnsid_lcnsid = '0';
            }

            if ($scope.LIST_LCN.dalcn.lcnsid_crtlct == true) {
                $scope.LIST_LCN.dalcn.lcnsid_crtlct = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_crtlct = '0';
            }

            if ($scope.LIST_LCN.dalcn.lcnsid_chngwtcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_chngwtcd = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_chngwtcd = '0';
            }

            if ($scope.LIST_LCN.dalcn.lcnsid_ntcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_ntcd = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_ntcd = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_taxno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_taxno = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_taxno = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_trdregno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_trdregno = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_trdregno = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_ctzno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_ctzno = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_ctzno = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_remark == true) {
                $scope.LIST_LCN.dalcn.lcnsid_remark = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_remark = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_idst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_idst = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_idst = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_phrno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_phrno = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_phrno = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_stfcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_stfcd = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_stfcd = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_nmprnst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_nmprnst = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_nmprnst = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_lstfcd == true) {
                $scope.LIST_LCN.dalcn.lcnsid_lstfcd = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_lstfcd = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_lcnsidst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_lcnsidst = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_lcnsidst = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_scridst == true) {
                $scope.LIST_LCN.dalcn.lcnsid_scridst = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_scridst = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_url == true) {
                $scope.LIST_LCN.dalcn.lcnsid_url = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_url = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_cncremark == true) {
                $scope.LIST_LCN.dalcn.lcnsid_cncremark = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_cncremark = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_email == true) {
                $scope.LIST_LCN.dalcn.lcnsid_email = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_email = '0';
            }
            if ($scope.LIST_LCN.dalcn.lcnsid_otaxno == true) {
                $scope.LIST_LCN.dalcn.lcnsid_otaxno = '1';
            } else {
                $scope.LIST_LCN.dalcn.lcnsid_otaxno = '0';
            }

        }

        var Getdata = CENTER_SV.INSERT_LCN_INPUT_NEW($scope.LIST_LCN, $scope.COLLECT_KEEP, $scope.COLLECT_PHR, PROCESS, sessionStorage.LCT_IDA);
        Getdata.then(function (datas) {
            var DES = datas.data.MSG_DES;
            var TR_ID = datas.data.TR_ID;
            var PROCESS = datas.data.PROCESS;
            var obj = $scope.DOC_LIST.FILE_LISTs;
            angular.forEach(obj, function (value, key) {
                var FILEs = value.FILE_DATA;
                $scope.PDF.push(FILEs);
            });
            var upload = CENTER_SV.UPLOAD_PDF_ATTACH_LCN($scope.DOC_LIST.FILE_LISTs, TR_ID, PROCESS, $scope.PDF);
            upload.then(function (datas) {
                if (datas.data.result == 'SUCCESS') {
                    $scope.FLAG = 'PASS';
                }
            });
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย \n' + DES ,
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
                    PHR_JOB_TYPE: datas.PHR_JOB_TYPE,
                    PHR_VETERINARY_FIELD: datas.PHR_VETERINARY_FIELD
                };
            $scope.COLLECT_PHR.push(obj);

        }
    };

    $scope.deletePHR = function (data, i) {
        $scope.COLLECT_PHR.splice(i, 1);
    };

    $scope.selectFileforUpload = function (datas, file) {

        if (file.length == 0) {
            datas.FILE_DATA = '';
            datas.FILENAME = '';
        }
        else {
            if (file[0].type == 'application/pdf') {
                var b = file[0];
                datas.FILENAME = b.name;
                datas.SIZE = b.size;
                datas.TYPE = b.type;
            }
            else {
                Swal.fire({
                    title: 'Error!',
                    text: 'กรุณา UPLOAD FILE',
                    icon: 'error'
                });
                datas.FILE_DATA = '';
                datas.FILENAME = '';
            }
        }
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/LCN/FRM_LCN_NEWS');
    };

    $scope.BTN_SEND_LCN = function () {
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
                REDIRECT('/LCN/FRM_LCN_NEWS');
            }
        });
    };

    $scope.BTN_SEND_REQUEST = function () {
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
                REDIRECT('/LCN/FRM_LCN_NEWS');
            }
        });

    };
});