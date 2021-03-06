app.controller('AUTHEN_STAFF_CTRL', function ($scope, CENTER_SV, $http, $location) {


    //$scope.loading = true;

    $scope.DOC_ID = 0;
    $scope.DOC_TITLE = "TEST";
    $scope.IS_USE = 0;

   

    pageload();

    function pageload() {
        $scope.FILE_ATTACH = SET_URL_SV('/DR/INPUT_RECLASS_ATTACH');
        var token = '';
        if (location.hostname == 'localhost') {
            token = "PASS";
        } else {
            token = QueryString("Token");
        }
        sessionStorage.token = token;

        //var getData = CENTER_SV.GET_AUTHEN_DATA(token);
        var getData = CENTER_SV.GET_AUTHEN_DATA(token);

        getData.then(function (datas) {
            $scope.AUTHEN = datas.data;
            if (datas.data.CODE == '900') {
                sessionStorage.CITIZEN_ID = datas.data.CITIZEN_ID;
                sessionStorage.CITIZEN_ID_AUTHORIZE = datas.data.CITIZEN_ID_AUTHORIZE;
                sessionStorage.THANM = datas.data.THANM;
                sessionStorage.PVCODE = datas.data.PVCODE;
                $scope.SET_MAIN_PAGE1 = datas.data.SET_MAIN_PAGE1;
                $scope.SET_MAIN_PAGE2 = datas.data.SET_MAIN_PAGE2;
                $scope.SET_MAIN_PAGE3 = datas.data.SET_MAIN_PAGE3;
                $scope.SET_MAIN_PAGE4 = datas.data.SET_MAIN_PAGE4;

                //window.location = "/FDA_DRUG_ANGULAR_DEMO/AUTHEN/FRM_STAFF_MAIN";

                if (datas.data.menuid == '') {
                    //window.location = "/AUTHEN/FRM_DATA_REQUEST"; // << ปิดเวลาอัพขึ้นเซิร์ฟ เปิดแถวล่าง

                } else {
                    //window.location = "/Master_Page/MAIN_MASTER"; // << ปิดเวลาอัพขึ้นเซิร์ฟ เปิดแถวล่าง
                    //window.location = "/DRUG_DROPBOX/HOME/FRM_STAFF_LIST"; 
                }
                
            }
            else {

                window.location = "http://privus.fda.moph.go.th";
              //  
            }
            //LOAD_JS();
        }, function () { });

      //  GET_LIST_WAIT();
        var getData_LIST = CENTER_SV.SETMODEL_LIST();
        getData_LIST.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });

        
        //var GET_LIST_STAFF = CENTER_SV.SP_STAFF_OFFER_DDL_BY_PVNCD(sessionStorage.PVCODE);
        //GET_LIST_STAFF.then(function (datas) {
        //    $scope.LIST_STAFF_OFFER = datas.data;
        //}, function () { });

       

    }



    function pageload_lcn_approve() {
        
        var getData_app = CENTER_SV.GET_LCN_APPROVE_INFORMATION_INPUT();
        getData_app.then(function (datas) {
            $scope.LIST_APP_LCN = datas.data;
        }, function () { });
    }

    $scope.pageload_reclass_pv = function () {

        //set model data reclass
        var data = CENTER_SV.SETMODEL_RECLASS();
        data.then(function (datas) {
            $scope.LIST_DRRC = datas.data;

        }, function () { });

        var data_RC = CENTER_SV.SP_GET_DATA_RECLASS_BY_IDA(sessionStorage.IDA);
        data_RC.then(function (datas) {
            $scope.LIST_DRRC = datas.data[0];
        }, function () { });

        var data_RC = CENTER_SV.SP_GET_READ_DATA_RECLASS_STAFF_BY_IDA(sessionStorage.IDA);
        data_RC.then(function (datas) {
            $scope.LIST_READ_RC = datas.data[0];
        }, function () { });

        //STATUS

    };
    $scope.BTN_BACK = function () {
        REDIRECT('/AUTHEN/FRM_STAFF_MAIN');
    };


    $scope.BTN_SUB_MENU_CLICK = function (BTN_GROUP, IDgroup, SEQ) {

        if (BTN_GROUP == '0') {
            
            if (SEQ == '5') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/MASTER_DATA/FRM_PROFESSIONAL_MAIN');
                var dataedit = CENTER_SV.SP_GET_ALL_PROFESSIONAL();
                dataedit.then(function (datas) {
                    $scope.DATA_PROFESS = datas.data;
                }, function () { });
            }

        } else if (BTN_GROUP == '1') {
            if (SEQ == '4') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/LCN_STAFF/FRM_LOCATION_STAFF_MAIN');
            } else if (SEQ == '5') {
                alert('ระบบยังไม่เปิดใช้งาน');
            } else if (SEQ == '6') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/LCN_STAFF/FRM_LCN_DRUG_STAFF');
                if (sessionStorage.PVCODE == '10') {
                    var dataLcn = CENTER_SV.SP_STAFF_DALCN();
                    dataLcn.then(function (datas) {
                        $scope.DATA_LCN_STAFF = datas.data;
                    }, function () { });
                } else {
                    var dataLcn1 = CENTER_SV.SP_STAFF_DALCN_BY_PVNCD(sessionStorage.PVCODE);
                    dataLcn1.then(function (datas) {
                        $scope.DATA_LCN_STAFF = datas.data;
                    }, function () { });

                }
            } else if (SEQ == '7') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/LCN_STAFF/FRM_EDIT_LCN_STAFF_MAIN');

                var dataedit1 = CENTER_SV.SP_DALCN_EDIT_REQUEST_STAFF();
                dataedit1.then(function (datas) {
                    $scope.DATA_LCN_EDIT_STAFF = datas.data;
                }, function () { });
            } else if (SEQ == '8') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/LCN_STAFF/FRM_EXTEND_TIME_LOCATION_STAFF_MAIN');
     
                //var dataedit7 = CENTER_SV.SP_STAFF_EXTEND(sessionStorage.GROUPS, sessionStorage.PVCODE);
                var dataedit7 = CENTER_SV.SP_STAFF_EXTEND(21020, 10);
                dataedit7.then(function (datas) {
                    $scope.DATA_LCN_EXTEND_STAFF = datas.data;
                }, function () { });
            } else if (SEQ == '10') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/MASTER_DATA/FRM_STAFF_OFFER');

                //var dataedit = CENTER_SV.SP_DALCN_EDIT_REQUEST_STAFF();
                //dataedit.then(function (datas) {
                //    $scope.DATA_LCN_EDIT_STAFF = datas.data;
                //}, function () { });
            } else if (SEQ == '98') {
                //$scope.SUB_MAIN_PAGE = SET_URL_SV('../LCN_STAFF_EDIT/FRM_STAFF_LCN_SEARCH');
                REDIRECT('/LCN_STAFF_EDIT/FRM_STAFF_LCN_SEARCH');

            } else if (SEQ == '99') {
                //ค่นหา
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/LCN/FRM_LCN_DRUG_SEARCH');


            } else if (SEQ == '998') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/LCN_STAFF/FRM_SUBSTITUTE_NCT_MAIN_STAFF');
                var dataedit6 = CENTER_SV.SP_DALCN_NCT_SUBSTITUTE_STAFF();
                dataedit6.then(function (datas) {
                    $scope.DATA_LCN_STT_STAFF = datas.data;
                }, function () { });
                
            } else if (SEQ == '999') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/LCN_STAFF/FRM_EDIT_LCN_STAFF_MAIN');
                var dataedit5 = CENTER_SV.SP_DALCN_EDIT_REQUEST_STAFF();
                dataedit5.then(function (datas) {
                    $scope.DATA_LCN_EDIT_STAFF = datas.data;
                }, function () { });
                
            } 


        } else if (BTN_GROUP == '2') {
            if (SEQ == '2') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/TABEAN_YA_MAIN_STAFF');

                //var dataedit4 = CENTER_SV.SP_DRRGT_TABEAN_STAFF();
                //dataedit4.then(function (datas) {
                //    $scope.DATA_TABEAN_STAFF = datas.data;
                //}, function () { });
            } else if (SEQ == '3') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_TABEAN_SEARCH');
                //FRM_TABEAN_SEARCH
            } else if (SEQ == '4') {

                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_RGT_EDIT_MAIN_STAFF');

                var dataedit3 = CENTER_SV.SP_DRRGT_EDIT_REQUEST_STAFF_PROCESS('130099');
                dataedit3.then(function (datas) {
                    $scope.DATA_EDIT_TABEAN_STAFF = datas.data;
                }, function () { });
            } else if (SEQ == '5') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_STAFF_MAIN_NYM');


            } else if (SEQ == '6') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_DS_STAFF_DRUG');
                
                var dataedit2 = CENTER_SV.SP_STAFF_DS();
                dataedit2.then(function (datas) {
                    $scope.DATA_DS_STAFF = datas.data;
                }, function () { });

            } else if (SEQ == '7') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_STAFF_DR_RECLASS_MAIN');

                var DATA_RC = CENTER_SV.SP_DR_RECLASS_STAFF();
                DATA_RC.then(function (datas) {
                    $scope.DATA_RECLASS = datas.data;
                }, function () { });
                
            } else if (SEQ == '996') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_SUBSTITUTE_TABEAN_STAFF_MAIN');
                var dataedit4 = CENTER_SV.SP_DRRGT_SUBSTITUTE_STAFF();
                dataedit4.then(function (datas) {
                    $scope.DATA_STT_TABEAN_STAFF = datas.data;
                }, function () { });
                
            } else if (SEQ == '997') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_FRGN_ADD_MAIN');

            } else if (SEQ == '998') {
                REDIRECT('https://medicina.fda.moph.go.th/FDA_DRUG_AN/AUTHEN/AUTHEN_GATEWAY?Token=' & sessionStorage.TOKEN);

            } else if (SEQ == '999') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DR_STAFF/FRM_TABEAN_YA_CHANGE_STATUS');

            }


            
        } else if (BTN_GROUP == '3') {

            if (SEQ == '1') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DH_STAFF/FRM_STAFF_CER_MAIN');
                var dataLo = CENTER_SV.SP_STAFF_CER();
                dataLo.then(function (datas) {
                    $scope.LIST_GMP_STAFF = datas.data;
                }, function () { });
            } else if (SEQ == '2') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DH_STAFF/FRM_DH_MAIN_STAFF');
                var dataLo1 = CENTER_SV.SP_STAFF_DH15RQT();
                dataLo1.then(function (datas) {
                    $scope.LIST_DH_STAFF = datas.data;
                }, function () { });
            } else if (SEQ == '3') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DH_STAFF/FRM_CHEMICAL_STAFF_MAIN');
            } else if (SEQ == '4') {
                
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DH_STAFF/FRM_DH_SEARCH');
                
                var DATASTAT = CENTER_SV.SP_STATUS_CERT_STAFF_FIX();
                DATASTAT.then(function (datas) {
                    $scope.LIST_STATUS = datas.data;
                }, function () { });





                //var dataLo3 = CENTER_SV.SP_STAFF_DH15RQT_V2();
                //dataLo3.then(function (datas) {
                //    $scope.LIST_DRM = datas.data;
                //    $scope.currentPage = 0;
                //    $scope.entryLimit = 20;
                //    $scope.noOfPages = Math.ceil($scope.LIST_DRM.Length / $scope.entryLimit);
                //    $scope.loading_profile = false;
                //    $scope.product_show = true;
                //}, function () { });



            } else if (SEQ == '5') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DH_STAFF/FRM_CHEMICAL_STAFF_SEARCH');
                
                //var dataLo4 = CENTER_SV.SP_STAFF_IOWA_SEARCH();
                //dataLo4.then(function (datas) {
                //    $scope.LIST_CHEM = datas.data;
                //}, function () { });
                
            } else if (SEQ == '6') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('/DH_STAFF/FRM_CER_STAFF_SEARCH');
                //var dataLo2 = CENTER_SV.SP_CER_SEARCH();
                //dataLo2.then(function (datas) {
                //    $scope.LIST_CERT = datas.data;
                //}, function () { });

            }


        }
    };

    //$scope.SELECT_STAFF_LCN = function (data) {
    //    if (data.LCT_IDA == undefined) {
    //        sessionStorage.LCT_IDA = data.la_IDA;
    //    } else if (data.la_IDA == undefined) {
    //        sessionStorage.LCT_IDA = data.LCT_IDA;
    //    }
    //    sessionStorage.LCN_IDA = data.IDA;
    //    sessionStorage.PROCESS = data.PROCESS_ID;
    //    REDIRECT('/LCN_STAFF/PREVIEW_LCN_STAFF');
    //};
    $scope.SELECT_STAFF_LCN = function (data) {
        sessionStorage.LCT_IDA = data.la_IDA;
        sessionStorage.LCN_IDA = data.IDA;
        sessionStorage.PROCESS = data.PROCESS_ID;
        REDIRECT('/LCN_STAFF/PREVIEW_LCN_STAFF');
    };
    //$scope.SELECT_STAFF_LCN_EDIT = function (data) {
    //    if (data.LCT_IDA == undefined) {
    //        sessionStorage.LCT_IDA = data.la_IDA;
    //    } else if (data.la_IDA == undefined) {
    //        sessionStorage.LCT_IDA = data.LCT_IDA;
    //    }
    //    sessionStorage.IDA = data.IDA;
    //    sessionStorage.PROCESS = data.PROCESS_ID;
    //    REDIRECT('/LCN_STAFF/PREVIEW_LCN_EDIT_STAFF');
    //};
    $scope.SELECT_STAFF_EXTEND_LCN = function (data) {
        //if (data.LCT_IDA == undefined) {
        //    sessionStorage.LCT_IDA = data.la_IDA;
        //} else if (data.la_IDA == undefined) {
        //    sessionStorage.LCT_IDA = data.LCT_IDA;
        //}
        sessionStorage.IDA = data.IDA;
        sessionStorage.PROCESS = data.PROCESS_ID;
        REDIRECT('/LCN_STAFF/PREVIEW_LCN_EXTEND_STAFF');
    };

    $scope.SELECT_STAFF_STT_LCN = function (data) {
        //if (data.LCT_IDA == undefined) {
        //    sessionStorage.LCT_IDA = data.la_IDA;
        //} else if (data.la_IDA == undefined) {
        //    sessionStorage.LCT_IDA = data.LCT_IDA;
        //}
        sessionStorage.LCN_IDA = data.IDA;
        sessionStorage.LCT_IDA = data.LCT_IDA;
        sessionStorage.PROCESS = data.PROCESS_ID;
        REDIRECT('/LCN_STAFF/PREVIEW_LCN_STT_STAFF');
    };

    $scope.SELECT_STAFF_EDIT_LCN = function (data) {
        sessionStorage.LCT_IDA = data.LCT_IDA;
        sessionStorage.LCN_IDA = data.IDA;
        sessionStorage.PROCESS = data.PROCESS_ID;
        REDIRECT('/LCN_STAFF/PREVIEW_LCN_EDIT_STAFF');
    };

    
    $scope.SELECT_NYM = function (data) {
        sessionStorage.PROCESS = data.PROCESS_ID;
        REDIRECT('/DR_STAFF/FRM_NYM_STAFF_CONFIRM');
    };

    $scope.BTN_PREVIEW_DR = function () {
        REDIRECT('/DR_STAFF/FRM_DR_STAFF_CONFIRM');
    };

    $scope.BTN_RQT = function () {
        REDIRECT('/DR/FRM_RQT_REGIST_INFORMATION');
    };

    $scope.SELECT_CER = function (data) {
        sessionStorage.IDA = data.IDA;
        sessionStorage.LCN_IDA = data.FK_IDA;
        //sessionStorage.STAGE = 'SHOW';
        //sessionStorage.PREVIEW_CERT_IDA = datas.IDA;
        REDIRECT('/DH_STAFF/FRM_PREVIEW_CERT_STAFF');
    };

    $scope.SELECT_DH = function (data) {
        sessionStorage.IDA = data.IDA;
        sessionStorage.LCN_IDA = data.FK_IDA;
        sessionStorage.PROCESS_ID = data.PROCESS_ID;
        //sessionStorage.PREVIEW_CERT_IDA = datas.IDA;
        REDIRECT('/DH_STAFF/FRM_PREVIEW_DH_STAFF');
    };

    $scope.BTN_LOT_RELEASE = function (Month, Year) {
        var getdata = CENTER_SV.GET_LOT_RELEASE(Month, Year);
        getdata.then(function (datas) {
            $scope.data = datas.data;
        });
    };
    
    $scope.BTN_PREVIEW_RGT_EDIT = function (data) {
        //sessionStorage.IDA = data.IDA;
        //sessionStorage.LCN_IDA = data.FK_IDA;
        //sessionStorage.PROCESS_ID = data.PROCESS_ID;
        //sessionStorage.PREVIEW_CERT_IDA = datas.IDA;
        REDIRECT('/DR_STAFF/PREVIEW_RGT_EDIT');
    };
    $scope.SELECT_RECLASS = function (data) {
        sessionStorage.IDA = data.IDA;
        //sessionStorage.LCN_IDA = data.FK_IDA;
        //sessionStorage.PROCESS_ID = data.PROCESS_ID;
        //sessionStorage.PREVIEW_CERT_IDA = datas.IDA;
        REDIRECT('/DR_STAFF/PREVIEW_RECLASS_STAFF');
    };

    $scope.BTN_SEARCH_TABEAN = function (txt) {
        var getdata = CENTER_SV.SP_DRRGT_FOR_SEARCH_FROM_SAI(txt);
        getdata.then(function (datas) {
            $scope.DATA_TABEAN_SEARCH = datas.data;
        });
    };

    $scope.BTN_SEARCH_NYM = function (process_id) {
        var getdata = CENTER_SV.SP_STAFF_NYM_ALL(process_id);
        getdata.then(function (datas) {
            $scope.DATA_NYM_STAFF = datas.data;
        });
    };

    
    $scope.BTN_SEARCH_DH_STAFF = function (STATUS_ID, TR_ID, DRM, CAS_NAME, thanm, frgn) {
        var getdata = CENTER_SV.SP_STAFF_DH15RQT_SEARCH(STATUS_ID, TR_ID, DRM, CAS_NAME, thanm, frgn);
        getdata.then(function (datas) {
            $scope.LIST_DRM = datas.data;
        });
    };
    
    $scope.BTN_SEARCH_IOWA_STAFF = function (IOWANM,IOWACD) {
        var getdata = CENTER_SV.SP_STAFF_IOWA_SEARCH(IOWANM, IOWACD);
        getdata.then(function (datas) {
            $scope.LIST_SEARCH_CHEM = datas.data;
        });
    };
    

    $scope.BTN_SEARCH_CERT_STAFF = function (CER_FORMAT, FOREIGN_LOCATION_NAME, TR_ID, thanm) {
        var getdata = CENTER_SV.SP_STAFF_CERT_SEARCH(CER_FORMAT, FOREIGN_LOCATION_NAME, TR_ID, thanm);
        getdata.then(function (datas) {
            $scope.LIST_CERT = datas.data;
        });
    };
    $scope.BTN_SAVE_APP = function () {
        var APP_DATA = CENTER_SV.UPDATE_APPROVE_NAME(LIST_APP_LCN, sessionStorage.LCN_IDA,sessionStorage.CITIZEN_ID);
        APP_DATA.then(function (datas) {
            var result = datas.data;
            if (result == 'กรุณากรอกข้อมูลให้ครบถ้วน') {
                ERR_DATA(result);
            } else {
                success_data(datas.data);
            }
        });
    };
    $scope.BTN_SEARCH_NAME_PRO = function (txt_search) {

        var GetdataPRO = CENTER_SV.SP_SEARCH_PERSON(txt_search);
        GetdataPRO.then(function (datas) {
            $scope.LIST_PROFESSIONAL = datas.data;

        }, function () { });
    };

    $scope.BTN_ADD_PROFESS = function (datas) {

        var obj = {
            tha_fullnm: datas.tha_fullnm,
            identify: datas.identify,

        };
        $scope.PROFESS_DATA.push(obj);
    };
    $scope.deletePROFESS = function (data, i) {
        $scope.PROFESS_DATA.splice(i, 1);
    };

    $scope.BTN_SAVE_PROFESS = function () {

        var Getdata = CENTER_SV.INSERT_PROFESSIONAL($scope.PROFESS_DATA);
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

    $scope.BTN_SAVE_CSD = function () {
        var APP_DATA = CENTER_SV.SAVE_LCN_CONSIDER(LIST_APP_LCN, sessionStorage.LCN_IDA, sessionStorage.CITIZEN_ID , sessionStorage.PVCODE);
        APP_DATA.then(function (datas) {
            var result = datas.data;
            if (result == 'SUCCESS') {
                success_data('บันทึกเรียบร้อย');
            } else if (result == 'POSITION') {
                ERR_DATA('กรุณากรอกตำแหน่ง');
            } else if (result == 'DATE') {
                ERR_DATA('ตรวจสอบการใส่วันที่');
            }
        });
    };
    
    $scope.BTN_SAVE_REMARK = function () {
        var APP_DATA = CENTER_SV.SAVE_LCN_REMARK(LIST_APP_LCN, sessionStorage.LCN_IDA, sessionStorage.CITIZEN_ID, sessionStorage.PVCODE);
        APP_DATA.then(function (datas) {
            var result = datas.data;
            success_data(result);
          
            });
    };
    
    $scope.BTN_SAVE_PAYNOTE = function () {
        var APP_DATA = CENTER_SV.SAVE_LCN_PAYNOTE(LIST_APP_LCN, sessionStorage.LCN_IDA, sessionStorage.CITIZEN_ID, sessionStorage.PVCODE);
        APP_DATA.then(function (datas) {
            var result = datas.data;
            success_data(result);

        });
    };
    $scope.BTN_SAVE_STAFF_OFFER = function () {
        var APP_DATA = CENTER_SV.SAVE_LCN_REMARK(LIST_APP_LCN, sessionStorage.LCN_IDA, sessionStorage.CITIZEN_ID, sessionStorage.PVCODE);
        APP_DATA.then(function (datas) {
            var result = datas.data;
            success_data(result);

        });
    };
    
    $scope.BTN_UPDATE_LCN_EDIT_CONS = function () {
        var APP_DATA = CENTER_SV.UPDATE_LCN_EDIT_CONSIDER(LIST_LCN, sessionStorage.IDA, sessionStorage.CITIZEN_ID);
        APP_DATA.then(function (datas) {
            var result = datas.data;
            success_data(result);

        });
    };
    
    $scope.BTN_UPDATE_LCN_EDIT_REMARK = function () {
        var APP_DATA = CENTER_SV.UPDATE_REMARK_LCN_EDIT(LIST_LCN, sessionStorage.IDA, sessionStorage.CITIZEN_ID);
        APP_DATA.then(function (datas) {
            var result = datas.data;
            success_data(result);

        });
    };

    $scope.BTN_SEND_STATUS = function (_type_select, val1, val2, val3, val4, val5) {
        var setdata = CENTER_SV.SEND_STATUS_PAY_TABEAN(_type_select, val1, val2, val3, val4, val5,sessionStorage.CITIZEN_ID);
        setdata.then(function (datas) {
            success_data(datas.data);
        });
    };

    $scope.UPLOAD_PDFs = function (values) {
        var files = values.FILE_DATA;
        var ADDFILE = CENTER_SV.UPLOAD_PDF(CITIZEN_NO, TOKEN, files);
        ADDFILE.then(function (datas) {
            var result = datas.data;
            if (result.MSG_RESULT == "ERR") {
                ERR_DATA('การบันทึกไฟล์ของท่านมีปัญหา');
            }
            else if (result.MSG_RESULT == "SUCCESS") {
                values.PATH = result.DATA_VALUE;
                values.FLAG = "PASS";
                $scope.Upload = "PASS";
            }
            OPEN_BUTTON();
        }, function () {
            ERR_DATA('การบันทึกไฟล์ของท่านมีปัญหา');
            OPEN_BUTTON();
        });


    };

    $scope.ADD_DATA = function () {
        var getData = CENTER_SV.UPDATE_BOX_INV($scope.DOC, $scope.INV_LIST);
        getData.then(function (datas) {
            var TR_ID = QueryString('TR_ID');
            $scope.filedata = [];
            var obj = $scope.DOC_LIST.FILE_LISTs;
            angular.forEach(obj, function (value, key) {
                var DES = value.DES;
                var FILEs = value.FILE_DATA;
                value.TR_ID = TR_ID;
                value.FILE_DATA = '';

            });

            var ADDFILE = CENTER_SV.UPLOAD_PDF_V2($scope.DOC_LIST.FILE_LISTs, $scope.filedata);
            ADDFILE.then(function (datas) {
                success_data('ดำเนินการแก้ไขเรียบร้อย');
                REDIRECT("/HOME/FRM_CUSTOMER_LIST");
            }, function () {

                success_data('ดำเนินการแก้ไขเรียบร้อย');
            });

        }, function () { });
    };

    $scope.ADD_FILE_LIST = function () {
        var obj = {
            TR_ID: '',
            DES: '',
            FILENAME: '',
            FILE_DATA: '',
            PATH: '',
            FLAG: ''
        };
        $scope.DOC_LIST.FILE_LISTs.push(obj);
    };

    $scope.deleteRow = function (datas, i) {
        if (datas.PIORITY == 'HIGH') {
            ERR_DATA(datas.DES + ' : เป็นเอกสารบังคับไม่สามารถลบออกได้');
        }
        else if (datas.PIORITY == 'LOW') {

            ERR_DATA(datas.DES + ' : ไม่สามารถลบออกได้');
        }
        else {
            $scope.DOC_LIST.FILE_LISTs.splice(i, 1);
        }
    };

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

app.filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});


