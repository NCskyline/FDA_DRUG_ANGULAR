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
    var CITIZEN = '0000000000000'///'0105527028430';

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

        if (PROCESS_ID === '') {

            var getdata = CENTER_SV.GET_INFORMATION(LCN_IDA);
            getdata.then(function (datas) {
                $scope.LCNNO_NO = datas.data.lcnno;
                $scope.thanameplace = datas.data.thanameplace;
                $scope.nameOperator = datas.data.nameOperator;
            }, function () { });
        }
        


        var MODLE_DH = CENTER_SV.SETMODEL_DHA();

        MODLE_DH.then(function (datas) {

            $scope.LIST_DH = datas.data;


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

            $scope.currentPage = 1;
            $scope.entryLimit = 20;
            $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
            $scope.loading_profile = false;
            $scope.product_show = true;
        }, function () { });
    };

    $scope.loadmodel = function () {

        var getModel = CENTER_SV.SETMODEL_CHEM();
        getModel.then(function (datas) {
            $scope.LIST_CHEM = datas.data;
        });
    };

    $scope.INPUT_CERT = function () {
        REDIRECT('../CERT/HEADER_CERT');
    };

    $scope.INPUT_DH = function () {
        REDIRECT('../DH/HEADER_DH');
    };

    $scope.pageloadDH = function () {
        var PROCESS_ID = sessionStorage.DH_PROCESS_ID;
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

    $scope.ADD_CHEMICAL = function () {
        REDIRECT('../DH/INPUT_CHEMICAL_RQT');
    };

    $scope.BTN_BACK = function () {
        REDIRECT('../DH/FRM_MAIN_PAGE_PHESAJ');
    };

    

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);
//$state.transitionTo($state.current, $stateParams, {
//    reload: true, inherit: false, notify: true
//});

