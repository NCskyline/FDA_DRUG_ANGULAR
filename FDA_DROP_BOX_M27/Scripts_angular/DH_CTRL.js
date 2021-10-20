
app.controller('DH_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var DO_ST = QueryString("do");
    var PROCESS = QueryString("PROCESS");
    var CITIZEN = CITIZEN_ID_AUTHORIZE;//'0000000000000';//'0105527028430';0000000000000
    var IDA_CHEM_RQT = 8728;
    var STAGE = sessionStorage.STAGE;
    $scope.PROCESS_CHEM = '';
    //------------------------------ PAGINGNATION ---------------------------//
   
    $scope.currentPage = 0;
    $scope.paging = {
        total: 20,
        current: 1,
        onPageChanged: loadPages
    };
    function loadPages() {
        console.log('Current page is : ' + $scope.paging.current);

        // TODO : Load current page Data here

        $scope.currentPage = $scope.paging.current;
    }

    //----------------------------------------------------------------------//
    
    $scope.pageload = function () {
        if (DO_ST == '1') {
            sessionStorage.DH_PROCESS_ID = '';
            sessionStorage.LCN_IDA = '0';
        }

        var PROCESS_ID = sessionStorage.DH_PROCESS_ID;

        var getdata = CENTER_SV.GET_INFORMATION(LCN_IDA);
        getdata.then(function (datas) {
            $scope.LCNNO_NO = datas.data.lcnno;
            $scope.thanameplace = datas.data.thanameplace;
            $scope.nameOperator = datas.data.nameOperator;
        }, function () { });
 
        
        if (PROCESS_ID == '31' || PROCESS_ID == '32' || PROCESS_ID == '33' || PROCESS_ID == '34' || PROCESS_ID == '36') {

            if (PROCESS_ID == '31') {
                $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยมาตรฐาน GMP (Registration of Manufacturer with GMP Standard)';
                $scope.SUB_PATH = SET_URL_SV('/CERT/FRM_CERT_MAIN');

            }
            else if (PROCESS_ID == '32') {
                $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยมาตรฐาน ISO (Registration of Manufacturer with ISO Standard)';
                $scope.SUB_PATH = SET_URL_SV('/CERT/FRM_CERT_MAIN');
            }
            else if (PROCESS_ID == '33') {
                $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยมาตรฐาน HACCP (Registration of Manufacturer with HACCP Standard)';
                $scope.SUB_PATH = SET_URL_SV('/CERT/FRM_CERT_MAIN');
            }
            else if (PROCESS_ID == '34') {
                $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยเอกสารหลักฐานการขายไปยังประเทศที่มีระบบคุณภาพที่ อย. ยอมรับ (Registration of Manufacturer with Purchase Order Document from Country with FDA equivalent Quality Control System)';
                $scope.SUB_PATH = SET_URL_SV('/CERT/FRM_CERT_MAIN');
            }
            else if (PROCESS_ID == '36') {
                $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยเอกสารอื่นๆ ที่ อย.เห็นชอบ (Registration of Manfacturer with FDA Approved Document)';
                $scope.SUB_PATH = SET_URL_SV('/CERT/FRM_CERT_MAIN');
            }

            var dataGMP = CENTER_SV.SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden(sessionStorage.LCN_IDA, PROCESS_ID, CITIZEN);
            dataGMP.then(function (datas) {
                $scope.DATA_GMP = datas.data;
                $scope.currentPage = 1;
                $scope.entryLimit = 20;
                $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
                $scope.loading_profile = false;
                $scope.product_show = true;
            }, function () { });
        }
        else if (PROCESS_ID == '14' || PROCESS_ID == '15' || PROCESS_ID == '16' || PROCESS_ID == '17') {

            if (PROCESS_ID == '14') {
                $scope.HEADER = '( ที่เป็นสารออกฤทธิ์ในทะเบียนตำรับยาผลิตในประเทศ (Active Substance in Locally Manufactured Drug Products) )';
                $scope.SUB_PATH = SET_URL_SV('/DH/FRM_MAIN_DH');
            }
            else if (PROCESS_ID == '15') {
                $scope.HEADER = '( ที่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยาผลิตในประเทศ (Active Substance not in Locally Manufactured Drug Products) )';
                $scope.SUB_PATH = SET_URL_SV('/DH/FRM_MAIN_DH');
            }
            else if (PROCESS_ID == '16') {
                $scope.HEADER = '( ที่เป็นสารไม่ออกฤทธิ์ในทะเบียนตำรับยาผลิตในประเทศ (Excipient in Locally Manufactured Drug Products) )';
                $scope.SUB_PATH = SET_URL_SV('/DH/FRM_MAIN_DH');
            }
            else if (PROCESS_ID == '17') {
                $scope.HEADER = '( ไม่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา )';
                $scope.SUB_PATH = SET_URL_SV('/DH/FRM_MAIN_DH');
            }

            var dataDH = CENTER_SV.SP_DH15RQT_BY_IDA(LCN_IDA, PROCESS_ID);
            dataDH.then(function (datas) {
                $scope.DATA_DH = datas.data;
                $scope.currentPage = 1;
                $scope.entryLimit = 20;
                $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
                $scope.loading_profile = false;
                $scope.product_show = true;
            }, function () { });
        }
    };

    $scope.DH_EDIT = function () {
        $scope.PROCESS_ID = sessionStorage.DH_PROCESS_ID;
        if ($scope.PROCESS_ID == '14') {
            $scope.HEADER_PROCESS = 'เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ';
        }
        else if ($scope.PROCESS_ID == '15') {
            $scope.HEADER_PROCESS = 'เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา';
        }
        else if ($scope.PROCESS_ID == '16') {
            $scope.HEADER_PROCESS = 'ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยา';
        }
        else if (PROCESS_ID == '17') {
            $scope.HEADER_PROCESS = 'ไม่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยาผลิตในประเทศ';
        }

        var getdata = CENTER_SV.GET_INFORMARION_DH(LCN_IDA);
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

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;

        }, function () { });

        var data_REF_CERT = CENTER_SV.SP_MASTER_CER_PK_BY_FK_IDA(LCN_IDA);
        data_REF_CERT.then(function (datas) {
            $scope.REF_CERT = datas.data;

        }, function () { });
        
    };
    
    $scope.BTN_EDIT = function () {
        REDIRECT('/DH/FRM_DH_EDIT_REQUEST');
    };


    $scope.DATA_CHE1 = function (PROCESS) {

        $scope.HEADER = 'เพิ่มสารเคมีที่มีส่วนผสมของสารออกฤทธิ์ชนิดสารเดี่ยว';
        $scope.SUB_PATH = SET_URL_SV('/DH/FRM_CHEMICAL_MAIN');

        var dataCHE = CENTER_SV.SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE(CITIZEN, '1', '1', 'A');
        dataCHE.then(function (datas) {
            $scope.DATA_CHEMICAL = datas.data;
            $scope.PROCESS_CHEM = PROCESS;

            $scope.currentPage = 1;
            $scope.entryLimit = 20;
            $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
            $scope.loading_profile = false;
            $scope.product_show = true;

        }, function () { });
    };

    $scope.DATA_CHE2 = function (PROCESS) {

        $scope.HEADER = 'เพิ่มสารเคมีที่มีส่วนผสมของสารออกฤทธิ์ชนิดสารผสม';
        $scope.SUB_PATH = SET_URL_SV('/DH/FRM_CHEMICAL_MAIN');

        var dataCHE = CENTER_SV.SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE(CITIZEN, '1', '2', 'A');
        dataCHE.then(function (datas) {
            $scope.DATA_CHEMICAL = datas.data;
            $scope.PROCESS_CHEM = PROCESS;

            $scope.currentPage = 1;
            $scope.entryLimit = 20;
            $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
            $scope.loading_profile = false;
            $scope.product_show = true;
        }, function () { });
    };

    $scope.DATA_CHE3 = function (PROCESS) {

        $scope.HEADER = 'เพิ่มสารเคมีที่ไม่มีส่วนผสมของสารออกฤทธิ์ชนิดสารเดี่ยว';
        $scope.SUB_PATH = SET_URL_SV('/DH/FRM_CHEMICAL_MAIN');

        dataCHE = CENTER_SV.SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE(CITIZEN, '1', '1', 'I');
        dataCHE.then(function (datas) {
            $scope.DATA_CHEMICAL = datas.data;
            $scope.PROCESS_CHEM = PROCESS;

            $scope.currentPage = 1;
            $scope.entryLimit = 20;
            $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
            $scope.loading_profile = false;
            $scope.product_show = true;
        }, function () { });
    };

    $scope.DATA_CHE4 = function (PROCESS) {

        $scope.HEADER = 'เพิ่มสารเคมีที่ไม่มีส่วนผสมของสารออกฤทธิ์ชนิดสารผสม';
        $scope.SUB_PATH = SET_URL_SV('/DH/FRM_CHEMICAL_MAIN');

        dataCHE = CENTER_SV.SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE(CITIZEN, '1', '2', 'I');
        dataCHE.then(function (datas) {
            $scope.DATA_CHEMICAL = datas.data;
            $scope.PROCESS_CHEM = PROCESS;

            $scope.currentPage = 1;
            $scope.entryLimit = 20;
            $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
            $scope.loading_profile = false;
            $scope.product_show = true;
        }, function () { });
    };

    $scope.loadmodel = function () {

        var IDA = sessionStorage.IDA;

        var getModel = CENTER_SV.SETMODEL_CHEM();
        getModel.then(function (datas) {
            $scope.LIST_CHEM = datas.data;
            $scope.LIST_CHEM.session = sessionStorage;
        });

        var dataEDIT = CENTER_SV.GETDATA_CHEMICAL(IDA);
        dataEDIT.then(function (datas) {
            $scope.DATA_CHEM = datas.data;
            $scope.DATA_CHEM.REQUEST_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.DATA_CHEM.REQUEST_DATE)));

        }, function () { });
    };

    $scope.INPUT_CERT = function () {
        sessionStorage.IDA = '0';
        //sessionStorage.PREVIEW_CERT_IDA = '0';
        REDIRECT('/CERT/HEADER_CERT');
    };

    $scope.INPUT_DH = function () {
        sessionStorage.IDA = '0';
        REDIRECT('/DH/HEADER_DH');
    };

    $scope.pageloadDH = function () {

        $scope.PROCESS_ID = sessionStorage.DH_PROCESS_ID;
        var IDA = sessionStorage.IDA;
        
        if ($scope.PROCESS_ID  == '14') {
            $scope.INPUT = SET_URL_SV('/DH/INPUT_DH_AR');
        }
        else if ($scope.PROCESS_ID  == '15') {
            $scope.INPUT = SET_URL_SV('/DH/INPUT_DH_AN');
        }
        else if ($scope.PROCESS_ID  == '16') {
            $scope.INPUT = SET_URL_SV('/DH/INPUT_DH_IR');
        }
        else if (PROCESS_ID == '17') {
            $scope.INPUT = SET_URL_SV('/DH/INPUT_DH_IN');
        }

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;

        }, function () { });

        var data_REF_CERT = CENTER_SV.SP_MASTER_CER_PK_BY_FK_IDA(LCN_IDA);
        data_REF_CERT.then(function (datas) {
            $scope.REF_CERT = datas.data;

        }, function () { });

        var MODLE_DH = CENTER_SV.SETMODEL_DHA();
        MODLE_DH.then(function (datas) {

            $scope.LIST_DH = datas.data;
            $scope.LIST_DH.session = sessionStorage;

        }, function () { });  

        var getdata = CENTER_SV.GET_INFORMARION_DH(LCN_IDA);
        getdata.then(function (datas) {

            $scope.LIST_DH = datas.data;
            $scope.LIST_DH.session = sessionStorage;

        }, function () { });

    };

    $scope.PREVIEW = function () {

        $scope.PROCESS_ID = sessionStorage.DH_PROCESS_ID;
        if ($scope.PROCESS_ID == '14') {
            $scope.HEADER_PROCESS = 'เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ';
        }
        else if ($scope.PROCESS_ID == '15') {
            $scope.HEADER_PROCESS = 'เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา';
        }
        else if ($scope.PROCESS_ID == '16') {
            $scope.HEADER_PROCESS = 'ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยา';
        }
        else if (PROCESS_ID == '17') {
            $scope.HEADER_PROCESS = 'ไม่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยาผลิตในประเทศ';
        }

        var getdata = CENTER_SV.GET_INFORMARION_DH(LCN_IDA);
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
    };

    $scope.REF_CER = function (IDA) {
        var obj = $scope.REF_CERT;
        angular.forEach(obj,function(value){
            if (IDA == value.IDA) {
                $scope.LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME = value.FOREIGN_LOCATION_NAME;
                $scope.LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME = value.engcntnm;
                $scope.LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(value.DOCUMENT_DATE));
                $scope.LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(value.EXP_DOCUMENT_DATE));
            }
        });
    };

    $scope.GET_LCN = function (KEY) {

        if (KEY == 'LCN') {
           
            var Getdata = CENTER_SV.SP_GET_LCN(CITIZEN);
            Getdata.then(function (datas) {
                $scope.LIST_LCN = datas.data;
            });
        }   
        sessionStorage.DH_PROCESS_ID = PROCESS;
    };

    $scope.BTN_ADD_CHEM = function (datas) {

        var obj = {

            IDA: Int32Array,
            ROW_ID: '',
            CAS_ID: datas.IDA,
            CAS_NO: '',
            CAS_NAME: datas.iowanm,
            FK_IDA: Int32Array,
            TR_ID: Int32Array,
            INN_NAME: ''

        };
        $scope.GMP_CHEM.push(obj);
    };

    $scope.BTN_SEARCH_CHEM = function (IOWANM) {

        var GetdataCHEM = CENTER_SV.SP_MAS_CHEMICAL_by_IOWANM_AND_AORI(IOWANM, "A");
        GetdataCHEM.then(function (datas) {
            $scope.LIST_CHEM = datas.data;

        }, function () { });
    };

    $scope.EDIT_CHEM = function (IDA) {
        sessionStorage.IDA = IDA;
        REDIRECT('/DH/PREVIEW_CHEMICAL');
    };

    $scope.DATA_GMP = function (PROCEESS) {

        sessionStorage.DH_PROCESS_ID = PROCEESS;
        REDIRECT('/DH/FRM_SELECT_LCN');
       
    };

    $scope.SELECT_LCN = function (datas) {
        
        sessionStorage.LCN_IDA = datas.IDA;
        sessionStorage.LCT_IDA = datas.LCT_IDA;
        REDIRECT('/DH/FRM_MAIN_PAGE_PHESAJ');
        
    };

    $scope.SELECT_CER = function (datas) {
        sessionStorage.IDA = datas.IDA;
        //sessionStorage.STAGE = 'SHOW';
        //sessionStorage.PREVIEW_CERT_IDA = datas.IDA;
        REDIRECT('/CERT/PREVIEW_CERT');
    };

    $scope.SELECT_DH = function (datas) {
        sessionStorage.IDA = datas.IDA;
        REDIRECT('/DH/PREVIEW_DH');
    };

    $scope.ADD_CHEMICAL = function () {
        REDIRECT('/DH/INPUT_CHEMICAL_RQT');
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/DH/FRM_MAIN_PAGE_PHESAJ');
    };

    $scope.BTN_SAVE_CHEM = function () {
        var cEmpty = 0;
        if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
            cEmpty = cEmpty + 1;
        }

        //if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
        //    cEmpty = cEmpty + 1;
        //}
        //if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
        //    cEmpty = cEmpty + 1;
        //}
        //if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
        //    cEmpty = cEmpty + 1;
        //}

        if (cEmpty == 0) {
            var Getdata = CENTER_SV.INSERT_CHEM_RQT($scope.LIST_GMP, PROCEESS, FK_IDA, MAIN_TYPE, SUB_TYPE, aori);
            Getdata.then(function (datas) {
                Swal.fire({
                    title: 'SUCCESS',
                    text: 'บันทึกข้อมูลเรียบร้อย',
                    icon: 'ดฟสหำ',
                    confirmButtonColor: '#3085d6',
                    confirmButtonText: 'OK'

                });
            });
        } else {
            Swal.fire({
                title: 'ERROR',
                text: 'กรุณากรอกชื่อสาร',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });

        }

    };

    $scope.BTN_EDIT_CHEM = function () {
        var cEmpty = 0;
        if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
            cEmpty = cEmpty + 1;
        }

        //if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
        //    cEmpty = cEmpty + 1;
        //}
        //if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
        //    cEmpty = cEmpty + 1;
        //}
        //if (LIST_CHEM.CHEMICAL_REQUEST.iowanm.trim().length < 2) {
        //    cEmpty = cEmpty + 1;
        //}

        if (cEmpty == 0) {
            var Getdata = CENTER_SV.UPDATE_CHEM_RQT($scope.LIST_GMP,IDA);
            Getdata.then(function (datas) {
                Swal.fire({
                    title: 'SUCCESS',
                    text: 'บันทึกข้อมูลเรียบร้อย',
                    icon: 'ดฟสหำ',
                    confirmButtonColor: '#3085d6',
                    confirmButtonText: 'OK'

                });
            });
        } else {
            Swal.fire({
                title: 'ERROR',
                text: 'กรุณากรอกชื่อสาร',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });

        }

    };

    $scope.BTN_SEND_DH = function () {
        var Getdata = CENTER_SV.UPDATE_STATUS_DH(sessionStorage.IDA, sessionStorage.CITIZEN);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: datas.data,
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });

    };

    $scope.Getdetails_REF_CER = function (IDA) {
        var data_location = CENTER_SV.GET_REF_CERT_DH(IDA);
        data_location.then(function (datas) {
            $scope.LIST_REF_CERT = datas.data;
            $scope.LIST_REF_CERT.CER.DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_REF_CERT.CER.DOCUMENT_DATE)));
            $scope.LIST_REF_CERT.CER.EXP_DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_REF_CERT.CER.EXP_DOCUMENT_DATE)));
            //$scope.LIST_REF_CERT.LOCATION_SELECT = IDA;
            //$scope.LIST_REF_CERT.LOCATION_TYPE = '2';
            //$scope.LIST_REF_CERT.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME = datas.data[0].thanameplace;

        }, function () { });
    };



    $scope.BTN_SAVE_DH = function () {
        
        var Getdata = CENTER_SV.INSERT_DH($scope.LIST_DH, $scope.PROCESS_ID);
        Getdata.then(function (datas) {
            if (datas.data.Result == "success") {
                Swal.fire({
                    title: 'SUCCESS',
                    text: 'บันทึกข้อมูลเรียบร้อย',
                    icon: 'ดฟสหำ',
                    confirmButtonColor: '#3085d6',
                    confirmButtonText: 'OK'

                });
            } else {
                Swal.fire({
                    title: 'ERROR',
                    text: 'กรุณากรอกข้อมูลให้ถูกต้อง',
                    icon: 'ดฟสหำ',
                    confirmButtonColor: '#3085d6',
                    confirmButtonText: 'OK'

                });
            }
        });
    };

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

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);
//$state.transitionTo($state.current, $stateParams, {
//    reload: true, inherit: false, notify: true
//});
app.filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});