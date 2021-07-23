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
    var IDA_CHEM_RQT = 8721;
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

    };








});