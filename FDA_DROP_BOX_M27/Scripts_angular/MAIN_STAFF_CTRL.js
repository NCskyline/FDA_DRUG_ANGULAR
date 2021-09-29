app.controller('MAIN_STAFF_CTRL', function ($scope, CENTER_SV, $http, $location) {

    $scope.BTN_MENU_STAFF = function (process) {
        if (process == '1001') {
            //sessionStorage.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('/LCN_STAFF/FRM_LCN_DRUG');

            if (sessionStorage.PVCODE == '10') {
                var dataLo = CENTER_SV.SP_STAFF_DALCN();
                dataLo.then(function (datas) {
                    $scope.DATA_LCN_STAFF = datas.data;
                }, function () { });
            } else {
                var dataLo = CENTER_SV.SP_STAFF_DALCN_BY_PVNCD(sessionStorage.PVCODE);
                dataLo.then(function (datas) {
                    $scope.DATA_LCN_STAFF = datas.data;
                }, function () { });

            }

        } else if (process == '1002') {
            $scope.SUB_PATH = SET_URL_SV('/LCN_STAFF/FRM_EDIT_LCN_STAFF_MAIN');
            
        } else if (process == '1003') {


        } else if (process == '2001') {


        } else if (process == '2002') {


        } else if (process == '2003') {


        } else if (process == '2004') {


        } else if (process == '2005') {


        } else if (process == '3001') {
           
            $scope.SUB_PATH = SET_URL_SV('/DH_STAFF/FRM_STAFF_CER_MAIN');
        } else if (process == '3002') {
           
            $scope.SUB_PATH = SET_URL_SV('/DH_STAFF/FRM_DH_MAIN_STAFF');
        } else if (process == '3003') {
            
            $scope.SUB_PATH = SET_URL_SV('/DH_STAFF/FRM_CHEMICAL_STAFF_MAIN');
        } else if (process == '3004') {
            $scope.SUB_PATH = SET_URL_SV('/DH_STAFF/FRM_DH_SEARCH');
        } else if (process == '3005') {
            $scope.SUB_PATH = SET_URL_SV('/DH_STAFF/FRM_CHEMICAL_STAFF_SEARCH');
            
        } else if (process == '3006') {
            $scope.SUB_PATH = SET_URL_SV('/DH_STAFF/FRM_CER_STAFF_SEARCH');
            
        }


    };



});