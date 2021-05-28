app.controller('DH_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = sessionStorage.DH_PROCESS_ID;
    var CITIZEN = '0000000000000';
   
    $scope.pageload = function () {

        
        var getdata = CENTER_SV.GET_INFORMATION(LCN_IDA);
        getdata.then(function (datas) {
            $scope.LCNNO_NO = datas.data.lcnno;
            $scope.thanameplace = datas.data.thanameplace;
            $scope.nameOperator = datas.data.nameOperator;
        }, function () { });

       

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;

        }, function () { });

        var data_REF_CERT = CENTER_SV.SP_MASTER_CER_PK_BY_FK_IDA(24153);
        data_REF_CERT.then(function (datas) {
            $scope.REF_CERT = datas.data;

        }, function () { });

        if (sessionStorage.DH_PROCESS_ID == '31') {
            $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (Certificate of GMP)';
            $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');

            var dataGMP = CENTER_SV.SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden(LCN_IDA, PROCESS, CITIZEN);
            dataGMP.then(function (datas) {
                $scope.DATA_GMP = datas.data;
            }, function () { });
        }
        else if (sessionStorage.DH_PROCESS_ID == '32') {
            $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (ISO)';
            $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
        }
        else if (sessionStorage.DH_PROCESS_ID == '33') {
            $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (HACCP)';
            $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
        }
        else if (sessionStorage.DH_PROCESS_ID == '34') {
            $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (หลักฐานการขายไปยังประเทศที่มีระบบควบคุมคุณภาพการผลิตที่ อย ยอมรับ)';
            $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
        }
        else if (sessionStorage.DH_PROCESS_ID == '36') {
            $scope.HEADER = 'ลงทะเบียน GMP สถานที่ผลิต  (เอกสารอื่นๆ ที่ อย เห็นชอบ)';
            $scope.SUB_PATH = SET_URL_SV('../DH/FRM_MAIN_DH');
        }
        
    };

    $scope.INPUT_DH = function () {
        REDIRECT('../DH/HEADER_DH');
    };
     
    $scope.pageloadDH = function (KEY) {
       
        if (KEY == '31') {

            $scope.INPUT = SET_URL_SV('../DH/INPUT_CHEMICAL_RQT');

        }
       
        listree();

    };

    $scope.GET_LCN = function (KEY) {

        if (KEY == 'LCN') {
            var CITIZEN = sessionStorage.CITIZEN_ID_AUTHORIZE;
            var Getdata = CENTER_SV.SP_GET_LCN('0000000000000');
            Getdata.then(function (datas) {
                $scope.LIST_LCN = datas.data;
            });
        }   

    };

    $scope.DATA_GMP = function (PROCEESS) {

        if (PROCEESS == '31' || PROCEESS == '32' || PROCEESS == '33' || PROCEESS == '34' || PROCEESS == '36') {
            
            sessionStorage.DH_PROCESS_ID = PROCEESS;
            REDIRECT('../DH/FRM_SELECT_LCN');
            
        }

        listree();
    };

    $scope.SELECT_LCN = function (datas) {
        
        sessionStorage.LCN_IDA = datas.IDA;
        sessionStorage.LCT_IDA = datas.LCT_IDA;
        REDIRECT('../DH/FRM_MAIN_PAGE_PHESAJ');
        
        listree();
    };

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);