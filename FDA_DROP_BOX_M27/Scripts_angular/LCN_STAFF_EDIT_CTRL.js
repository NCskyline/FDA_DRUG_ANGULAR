app.controller('LCN_STAFF_EDIT_CTRL', function ($scope, CENTER_SV, $http, $location) {
    var LCN_IDA = 6421;//sessionStorage.LCN_IDA;
    var LCT_IDA = 69778;
    var LOCATION_ADDRESS_IDA = LCT_IDA;

    //$scope.currentPage = 0;
    //$scope.paging = {
    //    total: 20,
    //    current: 1,
    //    onPageChanged: loadPages
    //};

    $scope.pageload = function () {
        var data_cnc = CENTER_SV.bind_ddl_lcn_stat();
        data_cnc.then(function (datas) {
            $scope.CNC_LIST = datas.data;

        }, function () { });

        var MODLE_GMP = CENTER_SV.SETMODEL_EDIT_LCN();
        MODLE_GMP.then(function (datas) {

            $scope.INFO_LIST = datas.data;
            $scope.INFO_LIST.session = sessionStorage;

        }, function () { });

        var data_LCN_SHOW = CENTER_SV.GET_LCN_NO_STAFF_EDIT(LCN_IDA);
        data_LCN_SHOW.then(function (datas) {
            $scope.INFO_LIST = datas.data;
            $scope.LCNNO_SHOW = datas.data.LCNNO_SHOW;
            $scope.TYPE_IMPORT = datas.data.TYPE_IMPORT;
            $scope.LCNNAME = datas.data.LCNNAME;
            $scope.thanameplace = datas.data.thanameplace;
            $scope.thanm = datas.data.NAME;
            $scope.fulladdr2 = datas.data.FULL_ADDR;
            $scope.tel = datas.data.TEL;
            $scope.fax = datas.data.FAX;
            $scope.CITIZEN_ID_AUTHORIZE = datas.data.CITIZEN_ID_AUTHORIZE;
            $scope.BSN_THAIFULLNAME = datas.data.BSN_THAIFULLNAME;
            //$scope.INFO_LIST.dalcn.cncdate = filwill(CHANGE_FORMATDATE(CV_DATE($scope.INFO_LIST.dalcn.cncdate)));
        }, function () { });


        var dataLo = CENTER_SV.GET_LOCATION_STAFF_EDIT(LCN_IDA);
        dataLo.then(function (datas) {
            $scope.DATA_LCT = datas.data;  
        }, function () { });

        
        var datakeep = CENTER_SV.SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(LCN_IDA);
        datakeep.then(function (datas) {
            $scope.DATA_KEEP = datas.data;          
        }, function () { });
        

        var databsn = CENTER_SV.SP_LOCATION_BSN_BY_LCN_IDA(LCN_IDA);
        databsn.then(function (datas) {
            $scope.DATA_BSN = datas.data;
        }, function () { });

        
        var databsn = CENTER_SV.GET_LCNSNM_STAFF_EDIT(LCN_IDA);
        databsn.then(function (datas) {
            $scope.DATA_LCNS = datas.data;
        }, function () { });

        var databsn = CENTER_SV.SP_DALCN_PHR_BY_FK_IDA_2(LCN_IDA);
        databsn.then(function (datas) {
            $scope.DATA_PHR = datas.data;
        }, function () { });

        //var data_LCN_SHOW = CENTER_SV.SET_LCN_NO_STAFF_EDIT(LCN_IDA);
        //data_LCN_SHOW.then(function (datas) {
        //    $scope.INFO_LIST = datas.data;

        //}, function () { });

    };

    


});