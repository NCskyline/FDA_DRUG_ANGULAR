app.controller('LCN_STAFF_EDIT_CTRL', function ($scope, CENTER_SV, $http, $location) {
    var LCN_IDA = sessionStorage.LCN_IDA;//sessionStorage.LCN_IDA;//sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var CITIZEN_ID = sessionStorage.CITIZEN_ID_AUTHORIZE;
    var LOCATION_ADDRESS_IDA = LCT_IDA;
    //var CITIZEN_ID_AUTHORIZE = '0105522020724';
    var CITIZEN_ID_AUTHORIZE = sessionStorage.CITIZEN_ID_AUTHORIZE;
    var LOCATION_TYPE = QueryString("LOCATION_TYPE");

    //$scope.currentPage = 0;
    //$scope.paging = {
    //    total: 20,
    //    current: 1,
    //    onPageChanged: loadPages
    //};
   
    function Rundata() {
        //var MODEL_EDIT_LCN = CENTER_SV.SETMODEL_EDIT_LCN();
        //MODEL_EDIT_LCN.then(function (datas) {

           //$scope.LIST_EDIT_LCN = datas.data;

        //}, function () { });  

       // //var data_LCN_SHOW = CENTER_SV.GET_LCN_NO_STAFF_EDIT(LCN_IDA);
        //data_LCN_SHOW.then(function (datas) {
        //    //$scope.INFO_LIST = datas.data;
        //    sessionStorage.CITIZEN_ID_AUTHORIZE = datas.data.CITIZEN_ID_AUTHORIZE;
        //    //$scope.INFO_LIST.dalcn.cncdate = filwill(CHANGE_FORMATDATE(CV_DATE($scope.INFO_LIST.dalcn.cncdate)));
        //}, function () { });


        

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;

        }, function () { });

        var data_CHNT = CENTER_SV.SP_SYSCHNGWT();
        data_CHNT.then(function (datas) {
            $scope.REF_CHNGWT = datas.data;

        }, function () { });

        var data_AMP = CENTER_SV.SP_SYSAMPHR();
         data_AMP.then(function (datas) {
        $scope.REF_AMP = datas.data;

        }, function () { });

        
        var data_TMB = CENTER_SV.SP_SYSTHMBL();
        data_TMB.then(function (datas) {
            $scope.REF_TMB = datas.data;

        }, function () { });


    }


    $scope.pageload = function () {
        var data_cnc = CENTER_SV.bind_ddl_lcn_stat();
        data_cnc.then(function (datas) {
            $scope.CNC_LIST = datas.data;

        }, function () { });

        
        var data_pre = CENTER_SV.SP_SYSPREFIX();
        data_pre.then(function (datas) {
            $scope.PREFIX_LIST = datas.data;

        }, function () { });

        
        var data_pfrs = CENTER_SV.SP_MASTER_DAPHRCD();
        data_pfrs.then(function (datas) {
            $scope.CNT_daphrcd = datas.data;

        }, function () { });

        var data_phr_job = CENTER_SV.SP_PHR_JOB();
        data_phr_job.then(function (datas) {
            $scope.CNT_functnm = datas.data;

        }, function () { });

        var LOAD_MODEL = CENTER_SV.SETMODEL_EDIT_LCN();
        LOAD_MODEL.then(function (datas) {

            $scope.INFO_LIST = datas.data;
            //$scope.INFO_LIST.dalcn.cncdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.cncdate); 
            //$scope.INFO_LIST.dalcn.frtappdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.frtappdate); 
            //$scope.INFO_LIST.dalcn.appdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.appdate); 
            //$scope.INFO_LIST.dalcn.lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lmdfdate); 

            //$scope.INFO_LIST.dalcn.rcvdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.rcvdate); 
            //$scope.INFO_LIST.dalcn.LOCATION_ADDRESS_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.LOCATION_ADDRESS_lmdfdate); 
            //$scope.INFO_LIST.dalcn.LOCATION_ADDRESS_rcvdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.LOCATION_ADDRESS_rcvdate); 
            //$scope.INFO_LIST.dalcn.CREATE_DATE = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.CREATE_DATE); 
            //$scope.INFO_LIST.dalcn.syslcnsnm_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_lmdfdate); 

            //$scope.INFO_LIST.dalcn.syslcnsnm_validdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_validdate); 
            //$scope.INFO_LIST.dalcn.syslcnsnm_create_date = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_create_date); 
            //$scope.INFO_LIST.dalcn.syslcnsnm_update_date = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_update_date); 
            //$scope.INFO_LIST.dalcn.lcnsid_birthdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_birthdate); 
            //$scope.INFO_LIST.dalcn.lcnsid_cncdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_cncdate); 

            //$scope.INFO_LIST.dalcn.lcnsid_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_lmdfdate); 
            //$scope.INFO_LIST.dalcn.syslctaddr_validdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslctaddr_validdate); 
            //$scope.INFO_LIST.dalcn.syslctaddr_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslctaddr_lmdfdate); 
            //$scope.INFO_LIST.dalcn.FIRST_APP_DATE = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.FIRST_APP_DATE); 
            //$scope.INFO_LIST.dalcn.expdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.expdate); 

            $scope.LIST_EDIT_LCN = datas.data;
            $scope.INFO_LIST.session = sessionStorage;


            

        }, function () { });
        Rundata();


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
            $scope.INFO_LIST.dalcn.cnccscd = datas.data.dalcn.cnccscd;

            //$scope.INFO_LIST.dalcn.cncdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.cncdate); //filwill(CHANGE_FORMATDATE(CV_DATE($scope.INFO_LIST.dalcn.cncdate)));
            $scope.INFO_LIST.dalcn.cncdate = filwill_DATE(CHANGE_FORMATDATEPICKER($scope.INFO_LIST.dalcn.cncdate));
            //$scope.INFO_LIST.dalcn.frtappdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.frtappdate);
            //$scope.INFO_LIST.dalcn.appdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.appdate);
            $scope.INFO_LIST.dalcn.appdate = filwill_DATE(CHANGE_FORMATDATEPICKER($scope.INFO_LIST.dalcn.appdate));
            //$scope.INFO_LIST.dalcn.lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lmdfdate);

            //$scope.INFO_LIST.dalcn.rcvdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.rcvdate);
            //$scope.INFO_LIST.dalcn.LOCATION_ADDRESS_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.LOCATION_ADDRESS_lmdfdate);
            //$scope.INFO_LIST.dalcn.LOCATION_ADDRESS_rcvdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.LOCATION_ADDRESS_rcvdate);
            //$scope.INFO_LIST.dalcn.CREATE_DATE = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.CREATE_DATE);
            //$scope.INFO_LIST.dalcn.syslcnsnm_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_lmdfdate);

            //$scope.INFO_LIST.dalcn.syslcnsnm_validdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_validdate);
            //$scope.INFO_LIST.dalcn.syslcnsnm_create_date = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_create_date);
            //$scope.INFO_LIST.dalcn.syslcnsnm_update_date = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_update_date);
            //$scope.INFO_LIST.dalcn.lcnsid_birthdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_birthdate);
            //$scope.INFO_LIST.dalcn.lcnsid_cncdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_cncdate);

            //$scope.INFO_LIST.dalcn.lcnsid_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_lmdfdate);
            //$scope.INFO_LIST.dalcn.syslctaddr_validdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslctaddr_validdate);
            //$scope.INFO_LIST.dalcn.syslctaddr_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslctaddr_lmdfdate);
            //$scope.INFO_LIST.dalcn.FIRST_APP_DATE = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.FIRST_APP_DATE);
            //$scope.INFO_LIST.dalcn.expdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.expdate);



            sessionStorage.CITIZEN_ID_AUTHORIZE = datas.data.CITIZEN_ID_AUTHORIZE;

            //$scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.LOCATION_TYPE = '2';


            var data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1('1', datas.data.CITIZEN_ID_AUTHORIZE);
            data_location.then(function (datas) {

                $scope.REF_LOCATION = datas.data;

            }, function () { });



            var data_keep = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', datas.data.CITIZEN_ID_AUTHORIZE);
            data_keep.then(function (datas) {
                $scope.REF_LOCATION_KEEP = datas.data;

            }, function () { });


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
            $scope.DATA_BSN.DALCN_LOCATION_BSN = datas.data[0];


            var data_TMB = CENTER_SV.SP_SYSTHMBL_BY_CHNGWTCD_AND_AMPHRCD(datas.data[0].CHANGWAT_ID, datas.data[0].AMPHR_ID);
            data_TMB.then(function (datas) {
                $scope.REF_TMB = datas.data;
                //$scope.LIST_EDIT_LCN.fulladdr = datas.data.fulladdr;
            }, function () { });

        }, function () { });

        
        var databsn1 = CENTER_SV.GET_LCNSNM_STAFF_EDIT(LCN_IDA);
        databsn1.then(function (datas) {
            $scope.DATA_LCNS = datas.data;
        }, function () { });

        var databsn2 = CENTER_SV.SP_DALCN_PHR_BY_FK_IDA_2(LCN_IDA);
        databsn2.then(function (datas) {
            $scope.DATA_PHR = datas.data;
        }, function () { });

        //var data_LCN_SHOW = CENTER_SV.SET_LCN_NO_STAFF_EDIT(LCN_IDA);
        //data_LCN_SHOW.then(function (datas) {
        //    $scope.INFO_LIST = datas.data;

        //}, function () { });

        
        var dataphr = CENTER_SV.GET_PHR_DATA_EDIT(sessionStorage.PHR_IDA);
        dataphr.then(function (datas) {
            $scope.LIST_EDIT_PHR = datas.data;
        }, function () { });



    };






    $scope.Bind_Data_ddl = function (IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
        Data_location.then(function (datas) {
            $scope.LIST_LABEL = datas.data;
            //$scope.LIST_EDIT_LCN.fulladdr = datas.data.fulladdr;
        }, function () { });
    };
   
   

    $scope.Bind_dll_amp = function (CHNGWTCD) {

        var data_AMP = CENTER_SV.SP_SYSAMPHR_BY_CHNGWTCD(CHNGWTCD);
        data_AMP.then(function (datas) {
            $scope.REF_AMP = datas.data;
            //$scope.LIST_EDIT_LCN.fulladdr = datas.data.fulladdr;
        }, function () { });
    };

    $scope.Bind_dll_tmb = function (CHNGWTCD, AMPHRCD) {

        var data_TMB = CENTER_SV.SP_SYSTHMBL_BY_CHNGWTCD_AND_AMPHRCD(CHNGWTCD, AMPHRCD);
        data_TMB.then(function (datas) {
            $scope.REF_TMB = datas.data;
            //$scope.LIST_EDIT_LCN.fulladdr = datas.data.fulladdr;
        }, function () { });
    };

    $scope.CHENGE_LCT = function () {
        //sessionStorage.LCN_IDA = datas.IDA;
        //sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN_ID_AUTHORIZE;
        REDIRECT('/LCN_STAFF_EDIT/FRM_STAFF_LCN_ADD_LOCATION?LOCATION_TYPE=1');
    };
    
    $scope.CHENGE_KEEP = function () {
        //sessionStorage.LCN_IDA = datas.IDA;
        //sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN_ID_AUTHORIZE;
        REDIRECT('/LCN_STAFF_EDIT/FRM_STAFF_LCN_ADD_LOCATION_KEEP?LOCATION_TYPE=2');
    };
    
    $scope.CHENGE_BSN = function () {
        //sessionStorage.LCN_IDA = datas.IDA;
        //sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN_ID_AUTHORIZE;
        REDIRECT('/LCN_STAFF_EDIT/FRM_STAFF_LCN_CHANGE_BSN');
    };
    
    $scope.CHENGE_LCNSNM = function () {
        //sessionStorage.LCN_IDA = datas.IDA;
        //sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN_ID_AUTHORIZE;
        REDIRECT('/LCN_STAFF_EDIT/FRM_STAFF_LCN_CHANGE_LCNSNM');
    };


    $scope.getdetails_1 = function (LOCATION_ADDRESS_IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LOCATION_ADDRESS_IDA);
        Data_location.then(function (datas) {
            $scope.LIST_LABEL = datas.data;
            $scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr;
        }, function () { });

    };

    $scope.Getdetails_Location = function (IDA) {
        var data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
       
        data_location.then(function (datas) {
            //$scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS = datas.data;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.LOCATION_SELECT = IDA;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.LOCATION_TYPE = LOCATION_TYPE;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thanameplace = datas.data[0].thanameplace;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thabuilding = datas.data[0].thabuilding;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thafloor = datas.data[0].thafloor;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.tharoom = datas.data[0].tharoom;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.engnameplace = datas.data[0].engnameplace;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.HOUSENO = datas.data[0].HOUSENO;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thaaddr = datas.data[0].thaaddr;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thamu = datas.data[0].thamu;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thasoi = datas.data[0].thasoi;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.tharoad = datas.data[0].tharoad;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.zipcode = datas.data[0].zipcode;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.tel = datas.data[0].tel;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.Mobile = datas.data[0].Mobile;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.fax = datas.data[0].fax;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.chngwtcd = datas.data[0].chngwtcd;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.amphrcd = datas.data[0].amphrcd;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.thmblcd = datas.data[0].thmblcd;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.latitude = datas.data[0].latitude;
            $scope.LIST_EDIT_LCN.DALCN_LOCATION_ADDRESS.longitude = datas.data[0].longitude;

            var data_TMB = CENTER_SV.SP_SYSTHMBL_BY_CHNGWTCD_AND_AMPHRCD(datas.data[0].chngwtcd, datas.data[0].amphrcd);
            data_TMB.then(function (datas) {
                $scope.REF_TMB = datas.data;
                //$scope.LIST_EDIT_LCN.fulladdr = datas.data.fulladdr;
            }, function () { });



        }, function () { });
    };

    $scope.Search_lcnno = function (CITIZEN, lcnno, pvncd) {
        var GetData = CENTER_SV.SP_GET_DATA_LCN(CITIZEN, lcnno, pvncd);
        GetData.then(function (datas) {
            $scope.LIST_LCN = datas.data;
        }, function () { });
    };

    
    $scope.Search_Bsn = function (iden) {
        var GetData = CENTER_SV.GET_BSN_NEW(iden);
        GetData.then(function (datas) {
            $scope.LIST_BSN = datas.data;
        }, function () { });
    };

    $scope.Search_Phr_name = function (iden) {
        var GetData = CENTER_SV.GET_BSN_NEW(iden);
        GetData.then(function (datas) {
            $scope.LIST_EDIT_LCN.DALCN_PHR.PHR_NAME = datas.data.PHR_NAME;
        }, function () { });
    };

    $scope.Search_lcns = function (iden) {
        var GetData = CENTER_SV.GET_LCNSNM_NEW(iden);
        GetData.then(function (datas) {
            $scope.LIST_LCNS = datas.data;
        }, function () { });
    };


    $scope.SELECT_LCN = function (datas) {
        sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN;
        sessionStorage.LCNNO = datas.lcnno;
        sessionStorage.LCN_IDA = datas.IDA;
        sessionStorage.LCT_IDA = datas.LCT_IDA;
        var url = "/LCN_STAFF_EDIT/FRM_LCN_STAFF_LCN_INFORMATION";
        REDIRECT(url);
    };

    $scope.SELECT_BSN_EDIT = function () {
        //sessionStorage.IDA = datas.IDA;
        REDIRECT('/LCN_STAFF_EDIT/FRM_STAFF_LCN_BSN_EDIT_ADDR');
    };
    
    $scope.BTN_INSERT_PHR = function () {
        //sessionStorage.IDA = datas.IDA;
        REDIRECT('/LCN_STAFF_EDIT/FRM_STAFF_LCN_PHR_INSERT');
    };

    $scope.BTN_CHOOSE_EDIT_PHR = function (datas) {
        //sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN;
        //sessionStorage.LCNNO = datas.lcnno;
        sessionStorage.PHR_IDA = datas.PHR_IDA;
        var url = "/LCN_STAFF_EDIT/FRM_STAFF_LCN_PHR_EDIT";
        REDIRECT(url);
    };


    $scope.BTN_BACK_TO_INFORMATION = function () {
        //sessionStorage.IDA = datas.IDA;
        REDIRECT('/LCN_STAFF_EDIT/FRM_LCN_STAFF_LCN_INFORMATION');
    };


    $scope.BTN_SAVE_PHR = function () {

        var Getdata = CENTER_SV.INSERT_PHR($scope.LIST_EDIT_LCN,sessionStorage.LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

  

    $scope.BTN_SAVE_KEEP = function (KEEP_ID) {

        var Getdata = CENTER_SV.INSERT_LCN_STAFF_EDIT_KEEP(KEEP_ID, sessionStorage.LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };
    
    $scope.BTN_SAVE_LCT = function (LCT_ID) {

        var Getdata = CENTER_SV.INSERT_LCN_STAFF_EDIT_LCT(LCT_ID, sessionStorage.LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

    $scope.BTN_SAVE_LCT_COPY = function () {

        var Getdata = CENTER_SV.INSERT_LCN_STAFF_EDIT_LCT_COPY($scope.LIST_EDIT_LCN, sessionStorage.LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

    $scope.BTN_UPDATE_LCNSNM = function () {

        var Getdata = CENTER_SV.UPDATE_NAME_LCNS(LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'อัพเดตข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

    
    $scope.BTN_UPDATE_STAT_LCN = function (cncdate,cnccscd) {
        //$scope.INFO_LIST.dalcn.frtappdate = CV_DATE($scope.INFO_LIST.dalcn.frtappdate);
        //$scope.INFO_LIST.dalcn.appdate = CV_DATE($scope.INFO_LIST.dalcn.appdate);
       
        //$scope.INFO_LIST.dalcn.lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lmdfdate);

        //$scope.INFO_LIST.dalcn.rcvdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.rcvdate);
        //$scope.INFO_LIST.dalcn.LOCATION_ADDRESS_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.LOCATION_ADDRESS_lmdfdate);
        //$scope.INFO_LIST.dalcn.LOCATION_ADDRESS_rcvdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.LOCATION_ADDRESS_rcvdate);
        //$scope.INFO_LIST.dalcn.CREATE_DATE = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.CREATE_DATE);
        //$scope.INFO_LIST.dalcn.syslcnsnm_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_lmdfdate);

        //$scope.INFO_LIST.dalcn.syslcnsnm_validdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_validdate);
        //$scope.INFO_LIST.dalcn.syslcnsnm_create_date = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_create_date);
        //$scope.INFO_LIST.dalcn.syslcnsnm_update_date = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslcnsnm_update_date);
        //$scope.INFO_LIST.dalcn.lcnsid_birthdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_birthdate);
        //$scope.INFO_LIST.dalcn.lcnsid_cncdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_cncdate);

        //$scope.INFO_LIST.dalcn.lcnsid_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.lcnsid_lmdfdate);
        //$scope.INFO_LIST.dalcn.syslctaddr_validdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslctaddr_validdate);
        //$scope.INFO_LIST.dalcn.syslctaddr_lmdfdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.syslctaddr_lmdfdate);
        //$scope.INFO_LIST.dalcn.FIRST_APP_DATE = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.FIRST_APP_DATE);
        //$scope.INFO_LIST.dalcn.expdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.expdate); 
        var Getdata = CENTER_SV.UPDATE_STAT_LCN(cncdate, cnccscd, LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'อัพเดตข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

    $scope.BTN_UPDATE_OPENTIME_LCN = function () {
        $scope.INFO_LIST.dalcn.appdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.appdate);
        //$scope.INFO_LIST.dalcn.expdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.expdate); 
        var Getdata = CENTER_SV.UPDATE_OPENTIME_LCN($scope.INFO_LIST, LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'อัพเดตข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

    $scope.BTN_UPDATE_TEMPLATE_LCN = function () {
        $scope.INFO_LIST.dalcn.appdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.appdate);
        //$scope.INFO_LIST.dalcn.expdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.expdate); 
        var Getdata = CENTER_SV.UPDATE_TEMPLATE_LCN($scope.INFO_LIST, LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'อัพเดตข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };
    
    $scope.BTN_UPDATE_APPDATE_LCN = function () {
        $scope.INFO_LIST.dalcn.appdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.appdate);
        //$scope.INFO_LIST.dalcn.expdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.expdate); 
        var Getdata = CENTER_SV.UPDATE_APPDATE_LCN($scope.INFO_LIST, LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'อัพเดตข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };
    $scope.BTN_UPDATE_EXPYEAR_LCN = function () {
        $scope.INFO_LIST.dalcn.appdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.appdate);
        //$scope.INFO_LIST.dalcn.expdate = ConvertJsonDateToDate($scope.INFO_LIST.dalcn.expdate); 
        var Getdata = CENTER_SV.UPDATE_EXPYEAR_LCN($scope.INFO_LIST, LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'อัพเดตข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
        });
    };

    function CV_DATE(data) {
        return new Date(parseInt(data.replace('/Date(', '').replace(')/', ''))).toLocaleDateString();
    }

    function ConvertJsonDateToDate(date) {
        var parsedDate = new Date(parseInt(date.substr(6)));
        var newDate = new Date(parsedDate);
        var month = ('0' + (newDate.getMonth() + 1)).slice(-2);
        var day = ('0' + newDate.getDate()).slice(-2);
        var year = newDate.getFullYear();
        return day + "/" + month + "/" + year;
    }

    $scope.BTN_EDIT_PHR = function () {

        var Getdata = CENTER_SV.UPDATE_PHR(sessionStorage.PHR_IDA, $scope.LIST_EDIT_PHR, sessionStorage.LCN_IDA, CITIZEN_ID, sessionStorage.CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: 'บันทึกข้อมูลเรียบร้อย',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'

            });
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

    /// ---------- แปลงวันที่ เข้า DATEPICKER -------------
    function CV_DATEPICKER(data) {
        return new Date(parseInt(data.replace('/Date(', '').replace(')/', ''))).toLocaleDateString('th-TH');
    }

    function filwill_DATE(dateString) {
        try {
            var dateArray = dateString.split("/");
            dateString = dateArray[1] + "/" + dateArray[0] + "/" + dateArray[2];
        }
        catch (err) {

        }
        return dateString;
    }

    function CHANGE_FORMATDATEPICKER(DATE_CHANGE) {
        var dateString = DATE_CHANGE.substr(6);
        var currentTime = new Date(parseInt(dateString));
        var month = currentTime.getMonth() + 1;
        var day = currentTime.getDate();
        var year = currentTime.getFullYear();
        return DATE_CHANGE = day + "/" + month + "/" + year;
    }
});