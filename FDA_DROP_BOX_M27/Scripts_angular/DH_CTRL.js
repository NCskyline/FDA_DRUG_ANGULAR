app.filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});
app.controller('DH_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = QueryString("PROCESS");
    var CITIZEN = '0105527028430'//'0105527028430';0000000000000
    var IDA_CHEM_RQT = 8728 ;
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

        var PROCESS_ID = sessionStorage.DH_PROCESS_ID;

        var getdata = CENTER_SV.GET_INFORMATION(LCN_IDA);
        getdata.then(function (datas) {
            $scope.LCNNO_NO = datas.data.lcnno;
            $scope.thanameplace = datas.data.thanameplace;
            $scope.nameOperator = datas.data.nameOperator;
        }, function () { });
 
        
        if (PROCESS_ID == '31' || PROCESS_ID == '32' || PROCESS_ID == '33' || PROCESS_ID == '34' || PROCESS_ID == '36') {

            if (PROCESS_ID == '31') {
                $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (Certificate of GMP)';
                $scope.SUB_PATH = SET_URL_SV('../CERT/FRM_CERT_MAIN');

            }
            else if (PROCESS_ID == '32') {
                $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (ISO)';
                $scope.SUB_PATH = SET_URL_SV('../CERT/FRM_CERT_MAIN');
            }
            else if (PROCESS_ID == '33') {
                $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (HACCP)';
                $scope.SUB_PATH = SET_URL_SV('../CERT/FRM_CERT_MAIN');
            }
            else if (PROCESS_ID == '34') {
                $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (หลักฐานการขายไปยังประเทศที่มีระบบควบคุมคุณภาพการผลิตที่ อย ยอมรับ)';
                $scope.SUB_PATH = SET_URL_SV('../CERT/FRM_CERT_MAIN');
            }
            else if (PROCESS_ID == '36') {
                $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (เอกสารอื่นๆ ที่ อย เห็นชอบ)';
                $scope.SUB_PATH = SET_URL_SV('../CERT/FRM_CERT_MAIN');
            }

            var dataGMP = CENTER_SV.SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden(LCN_IDA, PROCESS_ID, CITIZEN);
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
                $scope.HEADER = '( เป็นสารออกฤทธิ์ตามทะเบียนตำรับยา )';
                $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
            }
            else if (PROCESS_ID == '15') {
                $scope.HEADER = '( เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา )';
                $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
            }
            else if (PROCESS_ID == '16') {
                $scope.HEADER = '( ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยา )';
                $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
            }
            else if (PROCESS_ID == '17') {
                $scope.HEADER = '( ไม่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา )';
                $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
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


    


    $scope.DATA_CHE1 = function (PROCESS) {

        $scope.HEADER = 'เพิ่มสารเคมีที่มีส่วนผสมของสารออกฤทธิ์ชนิดสารเดี่ยว';
        $scope.SUB_PATH = SET_URL_SV('../DH/FRM_CHEMICAL_MAIN');

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
        $scope.SUB_PATH = SET_URL_SV('../DH/FRM_CHEMICAL_MAIN');

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
        $scope.SUB_PATH = SET_URL_SV('../DH/FRM_CHEMICAL_MAIN');

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
        $scope.SUB_PATH = SET_URL_SV('../DH/FRM_CHEMICAL_MAIN');

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

        var IDA = sessionStorage.IDA

        var getModel = CENTER_SV.SETMODEL_CHEM();
        getModel.then(function (datas) {
            $scope.LIST_CHEM = datas.data;
        });

        var dataEDIT = CENTER_SV.GETDATA_CHEMICAL(IDA);
        dataEDIT.then(function (datas) {
            $scope.DATA_CHEM = datas.data;
            $scope.DATA_CHEM.REQUEST_DATE = filwill(CHANGE_FORMATDATE($scope.DATA_CHEM.REQUEST_DATE));

        }, function () { });
    };

    $scope.INPUT_CERT = function () {
        REDIRECT('../CERT/HEADER_CERT');
    };

    $scope.INPUT_DH = function () {
        REDIRECT('../DH/HEADER_DH');
    };

    $scope.pageloadDH = function () {

        var PROCESS_ID = sessionStorage.DH_PROCESS_ID;
        var IDA = sessionStorage.IDA;

        if (PROCESS_ID == '14') {
            $scope.INPUT = SET_URL_SV('../DH/INPUT_DH_AR');
        }
        else if (PROCESS_ID == '15') {
            $scope.INPUT = SET_URL_SV('../DH/INPUT_DH_AN');
        }
        else if (PROCESS_ID == '16') {
            $scope.INPUT = SET_URL_SV('../DH/INPUT_DH_IR');
        }
        else if (PROCESS_ID == '17') {
            $scope.INPUT = SET_URL_SV('../DH/INPUT_DH_IN');
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

        }, function () { });  

        var getdataDH = CENTER_SV.GET_PREVIEW_DH(IDA);
        getdataDH.then(function (datas) {

            $scope.LIST_DH = datas.data;
            $scope.LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE = filwill(CHANGE_FORMATDATE($scope.LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE));
            $scope.LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE = filwill(CHANGE_FORMATDATE($scope.LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE));

        }, function () { });
        
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
        REDIRECT('../DH/PREVIEW_CHEMICAL');
    };

    $scope.DATA_GMP = function (PROCEESS) {

        sessionStorage.DH_PROCESS_ID = PROCEESS;
        REDIRECT('../DH/FRM_SELECT_LCN');
       
    };

    $scope.SELECT_LCN = function (datas) {
        
        sessionStorage.LCN_IDA = datas.IDA;
        sessionStorage.LCT_IDA = datas.LCT_IDA;
        REDIRECT('../DH/FRM_MAIN_PAGE_PHESAJ');
        
    };

    $scope.SELECT_CER = function (datas) {
        sessionStorage.IDA = datas.IDA;
        REDIRECT('../CERT/PREVIEW_CERT');
    };

    $scope.SELECT_DH = function (datas) {
        sessionStorage.IDA = datas.IDA;
        REDIRECT('../DH/PREVIEW_DH');
    };

    $scope.ADD_CHEMICAL = function () {
        REDIRECT('../DH/INPUT_CHEMICAL_RQT');
    };

    $scope.BTN_BACK = function () {
        REDIRECT('../DH/FRM_MAIN_PAGE_PHESAJ');
    };

    function CV_DATE(data) {
        return new Date(parseInt(data.replace('/Date(', '').replace(')/', ''))).toLocaleDateString('th-TH');
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
        var dateString = DATE_CHANGE.substr(6);
        var currentTime = new Date(parseInt(dateString));
        var month = currentTime.getMonth() + 1;
        if (month == '01') {
            month = "ม.ค.";
        } else if (month == '02') {
            month = "ก.พ.";
        } else if (month == '03') {
            month = "มี.ค.";
        } else if (month == '04') {
            month = "เม.ษ.";
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
        var year = currentTime.getFullYear()+543;
        return DATE_CHANGE = day + " " + month + " " + year;
    }

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);
//$state.transitionTo($state.current, $stateParams, {
//    reload: true, inherit: false, notify: true
//});

