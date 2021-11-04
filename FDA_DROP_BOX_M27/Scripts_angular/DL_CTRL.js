app.controller('DL_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();

    pageload();

    function pageload() {

        $scope.Process_ID = sessionStorage.PROCESS_ID;
        $scope.DL_PATH = SET_URL_SV('/DL/FRM_REGISTRATION_OTHER_DETAIL');
        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
            
        }, function () { });

        var data_UNIT_PHYSIC = CENTER_SV.SP_DRUG_UNIT_PHYSIC();
        data_UNIT_PHYSIC.then(function (datas) {
            $scope.UNIT_PHYSIC = datas.data;
          
        }, function () { });

        
        var data_dactg = CENTER_SV.SP_dactg();
        data_dactg.then(function (datas) {
            $scope.dactg = datas.data;
          
        }, function () { });
        
        var data_drclass = CENTER_SV.SP_MASTER_drclass();
        data_drclass.then(function (datas) {
            $scope.drclass = datas.data;
         
        }, function () { });

        var data_drdosage = CENTER_SV.SP_dosage_form();
        data_drdosage.then(function (datas) {
            $scope.drdosage = datas.data;
           
        }, function () { });
        
        var data_BIO_UNIT = CENTER_SV.GET_MAS_BIO_UNIT();
        data_BIO_UNIT.then(function (datas) {
            $scope.BIO_UNIT = datas.data;
           
        }, function () { });

        var data_DRUG_PACKAGING = CENTER_SV.GET_DRUG_PACKAGING();
        data_DRUG_PACKAGING.then(function (datas) {
            $scope.DRUG_PACKAGING = datas.data;
          
        }, function () { });

        var data_DRUG_SHAPE = CENTER_SV.SP_MAS_DRUG_SHAPE();
        data_DRUG_SHAPE.then(function (datas) {
            $scope.DRUG_SHAPE = datas.data;
            
        }, function () { });
        var data_drkdofdrg = CENTER_SV.SP_drkdofdrg();
        data_drkdofdrg.then(function (datas) {
            $scope.drkdofdrg = datas.data;
            
        }, function () { });
    }

   

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);