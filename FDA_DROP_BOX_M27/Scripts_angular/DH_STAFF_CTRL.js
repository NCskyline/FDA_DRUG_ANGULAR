

app.filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});
app.controller('DH_STAFF_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    //var LCN_IDA = sessionStorage.LCN_IDA;
    //var LCT_IDA = sessionStorage.LCT_IDA;
    //var PROCESS = QueryString("PROCESS");
    //var CITIZEN = '0105527028430'//'0105527028430';0000000000000
    var IDA = sessionStorage.IDA;
    var IDA_CHEM_RQT = 8721;
    Full_Model()
    Pageload_CHEM();

    function Pageload_CHEM() {
        var MODEL_CHEMICAL = CENTER_SV.SETMODEL_CHEMICAL();
        MODEL_CHEMICAL.then(function (datas) {

            $scope.LIST_CHEM = datas.data;

        }, function () { });

        //$scope.Getdetails_CHEM = function () {
        //    var data_location = CENTER_SV.GET_DETAIL_CHEM_RQT_STAFF(IDA_CHEM_RQT);
        //    data_location.then(function (datas) {
        //        $scope.LIST_CHEM = datas.data;
        //        $scope.LIST_CHEM.iowanm = datas.data[0].iowanm;
        //        $scope.LIST_CHEM.cas_number = datas.data[0].cas_number;
        //        $scope.LIST_CHEM.aori = datas.data[0].aori;
        //        $scope.LIST_CHEM.INN = datas.data[0].INN;
        //        $scope.LIST_CHEM.INN_TH = datas.data[0].INN_TH;
        //        $scope.LIST_CHEM.iowa = datas.data[0].iowa;
        //        $scope.LIST_CHEM.runno = datas.data[0].runno;
        //        $scope.LIST_CHEM.salt = datas.data[0].salt;
        //        $scope.LIST_CHEM.syn = datas.data[0].syn;

        //    }, function () { });
        //};

        var Getdetails_CHEM = CENTER_SV.GET_DETAIL_CHEM_RQT_STAFF(IDA_CHEM_RQT);
        Getdetails_CHEM.then(function (datas) {
            $scope.LIST_CHEM = datas.data;
          
            //$scope.LIST_CHEM.iowanm = datas.data[0].iowanm;
            //$scope.LIST_CHEM.cas_number = datas.data[0].cas_number;
            //$scope.LIST_CHEM.aori = datas.data[0].aori;
            //$scope.LIST_CHEM.INN = datas.data[0].INN;
            //$scope.LIST_CHEM.INN_TH = datas.data[0].INN_TH;
            //$scope.LIST_CHEM.iowa = datas.data[0].iowa;
            //$scope.LIST_CHEM.runno = datas.data[0].runno;
            //$scope.LIST_CHEM.salt = datas.data[0].salt;
            //$scope.LIST_CHEM.syn = datas.data[0].syn;
            $scope.LIST_CHEM.iowanm_show = $scope.LIST_CHEM.CHEMICAL_REQUEST.iowanm;
            $scope.LIST_CHEM.cas_number_show = $scope.LIST_CHEM.CHEMICAL_REQUEST.cas_number;
            $scope.LIST_CHEM.aori_show = $scope.LIST_CHEM.CHEMICAL_REQUEST.aori;

        }, function () { });

        var getData_LIST = CENTER_SV.SETMODEL_LIST();
        getData_LIST.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });
    }

    function Full_Model() {

        var MODLE_GMP = CENTER_SV.SETMODEL_DH();
        MODLE_GMP.then(function (datas) {

            $scope.LIST_GMP = datas.data;
            $scope.LIST_GMP.session = sessionStorage;

        }, function () { });
    }

    $scope.PREVIEW_CER = function () {
        //var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        //data_CNT.then(function (datas) {
        //    $scope.CNT_LIST = datas.data;

        //}, function () { });

        //var MODLE_GMP = CENTER_SV.SETMODEL_DH();
        //MODLE_GMP.then(function (datas) {

        //    $scope.LIST_GMP = datas.data;
        //    $scope.LIST_GMP.session = sessionStorage;

        //}, function () { });

        //var data_HEADER_CERT = CENTER_SV.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(CITIZEN, '');
        //data_HEADER_CERT.then(function (datas) {
        //    $scope.LCN_NAME = datas.data;

        //}, function () { });

        //var getData_LIST = CENTER_SV.SETMODEL_LIST();
        //getData_LIST.then(function (datas) {
        //    $scope.DOC_LIST = datas.data;
        //}, function () { });

        //var data_LCN_LCT = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LCT_IDA);
        //data_LCN_LCT.then(function (datas) {
        //    $scope.LCN_LCT = datas.data;

        //}, function () { });

        //var GetdataCHEM = CENTER_SV.SP_MAS_CHEMICAL_by_IOWANM_AND_AORI("", "A");
        //GetdataCHEM.then(function (datas) {
        //    $scope.LIST_CHEM = '';
        //    var auto = $scope.LIST_CHEM.length;
        //    $scope.currentPage = 1;
        //    $scope.entryLimit = 10;
        //    $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
        //    $scope.loading_profile = false;
        //    $scope.product_show = true;
        //}, function () { });

        //var data_LCN_SHOW = CENTER_SV.GET_LCNNO_SHOW(LCN_IDA);
        //data_LCN_SHOW.then(function (datas) {
        //    $scope.LCNNO_SHOW = datas.data.LCNNO_SHOW;
        //    $scope.TYPE_IMPORT = datas.data.TYPE_IMPORT;
        //    $scope.THANAMEPLACE = datas.data.THANAMEPLACE;
        //    $scope.thanameplace = datas.data.THANAMEPLACE;
        //    $scope.thanm = datas.data.NAME;
        //    $scope.fulladdr2 = datas.data.FULL_ADDR;
        //    $scope.tel = datas.data.TEL;
        //    $scope.fax = datas.data.FAX;
        //}, function () { });

        var Set_PREVIEW = CENTER_SV.GET_PREVIEW_CERT(sessionStorage.IDA);
        Set_PREVIEW.then(function (datas) {

            $scope.LIST_GMP = datas.data;
            $scope.LIST_GMP.session = sessionStorage;

            var TR_ID = $scope.LIST_GMP.CER.TR_ID;
            var PROCESS = $scope.LIST_GMP.CER.CER_TYPE;

            $scope.LIST_GMP.CER.DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_GMP.CER.DOCUMENT_DATE)));
            $scope.LIST_GMP.CER.EXP_DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_GMP.CER.EXP_DOCUMENT_DATE)));
            $scope.INPUT_CHEM = SET_URL_SV('/CERT/PREVIEW_CHEMICAL');

            var File = CENTER_SV.GETDATA_FILE_TR_ID_TYPE(TR_ID, PROCESS);
            File.then(function (datas) {
                $scope.LIST_File = datas.data;
            }, function () { });

        }, function () { });






    };

    $scope.PREVIEW_DH = function () {

        $scope.PROCESS_ID = sessionStorage.PROCESS_ID;
        if ($scope.PROCESS_ID == '14') {
            $scope.HEADER_PROCESS = 'เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ';
        }
        else if ($scope.PROCESS_ID == '15') {
            $scope.HEADER_PROCESS = 'เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา';
        }
        else if ($scope.PROCESS_ID == '16') {
            $scope.HEADER_PROCESS = 'ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยา';
        }
        else if ($scope.PROCESS_ID == '17') {
            $scope.HEADER_PROCESS = 'ไม่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยาผลิตในประเทศ';
        }

        var getdata = CENTER_SV.GET_INFORMARION_DH(sessionStorage.LCN_IDA);
        getdata.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.session = sessionStorage;

        }, function () { });

        var IDA = sessionStorage.IDA;
        var getdataDH = CENTER_SV.GET_PREVIEW_DH(IDA);
        getdataDH.then(function (datas) {

            $scope.LIST_DH = datas.data;
            $scope.LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE)));
            $scope.LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE)));

        }, function () { });

        var data_stat = CENTER_SV.SP_STATUS_SELECT_DH_STAFF(sessionStorage.IDA , 22);
        data_stat.then(function (datas) {
            $scope.STAT_LIST = datas.data;

        }, function () { });


    };

    $scope.BTN_BACK = function () {
        REDIRECT('/AUTHEN/FRM_STAFF_MAIN');
    };
    
    $scope.BTN_BACK_DH = function () {
        REDIRECT('/DH_STAFF/FRM_PREVIEW_CERT_STAFF');
    };

    $scope.BTN_SAVE_REMARK_CERT = function () {
        Swal.fire({
            title: 'คุณต้องการส่งใช่หรือไม่ ?',
            text: "กรุณาตรวจสอบความถูกต้องก่อนยกเลิกคำขอ!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'ใช่, ฉันต้องการยกเลิกคำขอ',
            cancelButtonText: 'ไม่ใช่'
        }).then((result) => {
            if (result.value) {
                var APP_DATA = CENTER_SV.SAVE_REMARK_CERT(LIST_GMP, sessionStorage.IDA, sessionStorage.CITIZEN_ID);
                APP_DATA.then(function (datas) {
                    var result = datas.data;
                    success_data(result);

                });
            }
        });


    };


    $scope.BTN_CERT_CONFIRM = function (STATUS_ID) {
        Swal.fire({
            title: 'คุณต้องการส่งใช่หรือไม่ ?',
            text: "กรุณาตรวจสอบความถูกต้องก่อนอนุมัติ!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'ใช่, ฉันต้องการอนุมัติ',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.value) {
                if (STATUS_ID == '8') {
                    var APP_DATA = CENTER_SV.APPROVE_CERT_STAFF(sessionStorage.IDA, sessionStorage.CITIZEN_ID);
                    APP_DATA.then(function (datas) {
                        var result = datas.data;
                        success_data(result);
                    });
                } else if (STATUS_ID == '7') {
                    REDIRECT('/DH_STAFF/FRM_STAFF_CER_REMARK');
                } else if (STATUS_ID == '5') {
                    REDIRECT('/DH_STAFF/FRM_EDIT_REQUEST');
                }
            }
        });
    };

    $scope.BTN_DH_CONFIRM = function (STATUS_ID) {
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
                if (STATUS_ID != '7') {
                    var APP_DATA = CENTER_SV.UPDATE_STATUS_DH_STAFF(STATUS_ID,sessionStorage.IDA, sessionStorage.CITIZEN_ID ,sessionStorage.PVCODE);
                    APP_DATA.then(function (datas) {
                        var result = datas.data;
                        success_data(result);
                    });
                } else  {
                    REDIRECT('/DH_STAFF/FRM_DH_STAFF_REMARK');
                }
            }
        });
    };

    $scope.BTN_REQUEST = function (DES,REQUEST_DATE) {
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
        } else {
            $scope.DOC_LIST.FILE_LISTs.splice(i, 1);
        }
    };
    //
    function CV_DATE(data) {
        return new Date(parseInt(data.replace('/Date(', '').replace(')/', ''))).toLocaleDateString();
    }

    function filwill(dateString) {
        try {
            var dateArray = dateString.split("/");
            dateString = dateArray[0]; //+ "/" + dateArray[0] + "/" + dateArray[2];
        }
        catch (err) {

        }
        return dateString;
    }

    //แปลงเวลา เข้าข้อมูล (แสดง)
    function CHANGE_FORMATDATE(DATE_CHANGE) {
        var dateString = DATE_CHANGE;
        var currentTime = new Date(dateString);
        var month = currentTime.getMonth() + 1;
        if (month == '01') {
            month = "ม.ค.";
        } else if (month == '02') {
            month = "ก.พ.";
        } else if (month == '03') {
            month = "มี.ค.";
        } else if (month == '04') {
            month = "เม.ย.";
        } else if (month == '05') {
            month = "พ.ค.";
        } else if (month == '06') {
            month = "มิ.ย.";
        } else if (month == '07') {
            month = "ก.ค.";
        } else if (month == '08') {
            month = "ส.ค.";
        } else if (month == '09') {
            month = "ก.ย.";
        } else if (month == '10') {
            month = "ต.ค.";
        } else if (month == '11') {
            month = "พ.ย.";
        } else if (month == '12') {
            month = "ธ.ค.";
        }
        var day = currentTime.getDate();
        var year = currentTime.getFullYear();
        if (year > 2500) {
            year = year - 543;
        } else {
            year = year + 543;
        }
        return DATE_CHANGE = day + " " + month + " " + year;
    }

});