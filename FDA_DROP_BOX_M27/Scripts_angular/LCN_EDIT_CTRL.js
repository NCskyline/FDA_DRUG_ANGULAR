app.controller('LCN_EDIT_CTRL', function ($scope, CENTER_SV, $http, $location) {

    $scope.CITIZEN = "";
    $scope.lcnno = "";
    var IDA = sessionStorage.IDA;
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = QueryString("PROCESS");
    var CITIZEN = '0105527028430';//'0105527028430';0000000000000
    var BSN_IDENTIFY = "";
    IDA = 66254;
    var IDENTIFY = '0107542000011';
    var LCT_IDA = 117194;
    Pageload();
    //LOAD_MODEL();
    //MODEL_EDIT_LCN
    //function LOAD_MODEL() {

    //    var data = CENTER_SV.GET_FULLDATA_LCN_EDIT();
    //    data.then(function (datas) {
    //        $scope.FULL_MODEL = datas.data;

    //    }, function () { });
    //}
    function Pageload() {
        var MODEL_EDIT_LCN = CENTER_SV.SETMODEL_EDIT_LCN();
        MODEL_EDIT_LCN.then(function (datas) {

            $scope.LIST_EDIT_LCN = datas.data;

        }, function () { });  

        var data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1('1', IDENTIFY);
        data_location.then(function (datas) {
            $scope.REF_LOCATION = datas.data;

        }, function () { });



        var data_keep = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', IDENTIFY);
        data_keep.then(function (datas) {
            $scope.REF_LOCATION_KEEP = datas.data;

    }, function () { });

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;

        }, function () { });


        //var GET_LCN_EDIT = CENTER_SV.GET_LCN_EDIT(IDA);
        //GET_LCN_EDIT.then(function (datas) {

        //    $scope.LIST_EDIT_LCN = datas.data;


        //}, function () { });
    }

    
    $scope.Bind_Data_ddl = function (IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
        Data_location.then(function (datas) {
            $scope.LIST_LABEL = datas.data;
            //$scope.LIST_EDIT_LCN.fulladdr = datas.data.fulladdr;
        }, function () { });
    };
    
    $scope.getdetails = function (IDA) {
    
            var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
            Data_location.then(function (datas) {
                $scope.LIST_LABEL = datas.data;
                $scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr; 
            }, function () { });
    
    };

    $scope.Getdetails_Location = function (IDA) {
        var data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
            data_location.then(function (datas) {
                $scope.LIST_EDIT_LCN = datas.data;
                $scope.LIST_EDIT_LCN.LOCATION_SELECT = IDA;
                $scope.LIST_EDIT_LCN.LOCATION_TYPE = '2';
                $scope.LIST_EDIT_LCN.thanameplace = datas.data[0].thanameplace; 
                $scope.LIST_EDIT_LCN.thabuilding = datas.data[0].thabuilding; 
                $scope.LIST_EDIT_LCN.thafloor = datas.data[0].thafloor; 
                $scope.LIST_EDIT_LCN.tharoom = datas.data[0].tharoom; 
                $scope.LIST_EDIT_LCN.engnameplace = datas.data[0].engnameplace; 
                $scope.LIST_EDIT_LCN.HOUSENO = datas.data[0].HOUSENO; 
                $scope.LIST_EDIT_LCN.thaaddr = datas.data[0].thaaddr; 
                $scope.LIST_EDIT_LCN.thamu = datas.data[0].thamu; 
                $scope.LIST_EDIT_LCN.thasoi = datas.data[0].thasoi; 
                $scope.LIST_EDIT_LCN.tharoad = datas.data[0].tharoad; 
                $scope.LIST_EDIT_LCN.zipcode = datas.data[0].zipcode; 
                $scope.LIST_EDIT_LCN.tel = datas.data[0].tel; 
                $scope.LIST_EDIT_LCN.Mobile = datas.data[0].Mobile;
                $scope.LIST_EDIT_LCN.fax = datas.data[0].fax; 
                $scope.LIST_EDIT_LCN.chngwtcd = datas.data[0].chngwtcd; 
                $scope.LIST_EDIT_LCN.amphrcd = datas.data[0].amphrcd; 
                $scope.LIST_EDIT_LCN.thmblcd = datas.data[0].thmblcd; 
                $scope.LIST_EDIT_LCN.latitude = datas.data[0].latitude;
                $scope.LIST_EDIT_LCN.longitude = datas.data[0].longitude;

            }, function () { });
    };


    $scope.BTN_SAVE = function (IDA) {
        if (IDA != null) {
            //var Getdata = CENTER_SV.INSERT_CERT_GMP($scope.LIST_GMP, $scope.GMP_CHEM, PROCESS);
            //Getdata.then(function (datas) {
            //    Swal.fire({
            //        title: 'ERROR',
            //        text: 'บันทึกข้อมูลเรียบร้อย',
            //        icon: 'ดฟสหำ',
            //        confirmButtonColor: '#3085d6',
            //        confirmButtonText: 'OK'

            //    });
            alert(IDA);
            //});
        } else {
            Swal.fire({
                title: 'ERROR',
                text: 'กรุณาเลือกสถานที่เก็บ/ที่ตั้ง',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });

        }


    };

});