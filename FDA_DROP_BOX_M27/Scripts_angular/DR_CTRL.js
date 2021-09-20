app.controller('DR_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    pageload();
    
    function pageload() {


        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
            $scope.states = loadClaim($scope.CNT_LIST);
        }, function () { });

        var data_UNIT_PHYSIC = CENTER_SV.SP_DRUG_UNIT_PHYSIC();
        data_UNIT_PHYSIC.then(function (datas) {
            $scope.UNIT_PHYSIC = datas.data;
            $scope.states = loadClaim($scope.UNIT_PHYSIC);
        }, function () { });


        var data_dactg = CENTER_SV.SP_dactg();
        data_dactg.then(function (datas) {
            $scope.dactg = datas.data;
            $scope.states = loadClaim($scope.dactg);
        }, function () { });

        var data_drclass = CENTER_SV.SP_MASTER_drclass();
        data_drclass.then(function (datas) {
            $scope.drclass = datas.data;
            $scope.states = loadClaim($scope.drclass);
        }, function () { });

        var data_drdosage = CENTER_SV.SP_dosage_form();
        data_drdosage.then(function (datas) {
            $scope.drdosage = datas.data;
            $scope.states = loadClaim($scope.drdosage);
        }, function () { });

        var data_BIO_UNIT = CENTER_SV.GET_MAS_BIO_UNIT();
        data_BIO_UNIT.then(function (datas) {
            $scope.BIO_UNIT = datas.data;
            $scope.states = loadClaim($scope.BIO_UNIT);
        }, function () { });

        var data_DRUG_PACKAGING = CENTER_SV.GET_DRUG_PACKAGING();
        data_DRUG_PACKAGING.then(function (datas) {
            $scope.DRUG_PACKAGING = datas.data;
            $scope.states = loadClaim($scope.DRUG_PACKAGING);
        }, function () { });

        var data_DRUG_SHAPE = CENTER_SV.SP_MAS_DRUG_SHAPE();
        data_DRUG_SHAPE.then(function (datas) {
            $scope.DRUG_SHAPE = datas.data;
            $scope.states = loadClaim($scope.DRUG_SHAPE);
        }, function () { });

        
        var data_drkdofdrg = CENTER_SV.SP_drkdofdrg();
        data_drkdofdrg.then(function (datas) {
            $scope.drkdofdrg = datas.data;
            $scope.states = loadClaim($scope.drkdofdrg);
        }, function () { });

        
        var data_dramltype = CENTER_SV.GET_dramltype();
        data_dramltype.then(function (datas) {
            $scope.dramltype = datas.data;
            $scope.states = loadClaim($scope.dramltype);
        }, function () { });

        //var id = '@Html.IdFor( o => o.model )';
        //var dropdown = $("#" + id);
        //var vall = dropdown.val();
        var e = document.getElementById("ddl_dramltype");
        var vall = e.options[e.selectedIndex].value;
        var data_dramlsubtp = CENTER_SV.GET_dramlsubtp(vall);
        data_dramlsubtp.then(function (datas) {
            $scope.dramlsubtp = datas.data;
            $scope.states = loadClaim($scope.dramlsubtp);
        }, function () { });

        
        var e = document.getElementById("ddl_dramlsubtp");
        var val2 = e.options[e.selectedIndex].value;
        var data_dramlusetp = CENTER_SV.GET_dramlusetp(val2);
        data_dramlusetp.then(function (datas) {
            $scope.dramlusetp = datas.data;
            $scope.states = loadClaim($scope.dramlusetp);
        }, function () { });
    }

    

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);