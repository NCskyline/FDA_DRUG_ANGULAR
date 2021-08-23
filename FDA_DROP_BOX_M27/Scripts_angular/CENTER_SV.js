app.service("CENTER_SV", function ($http, Upload) {

    this.GET_FULL_MODEL_LCN = function () {
        return $http.get("../LCN_CENTER/GET_FULL_MODEL");
    };

    this.GET_FULLDATA_LCN = function (MODEL) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/LCN_CENTER/CODE_CENTER"),
            dataType: "json",
            data: {
                MODEL: MODEL
            }
        });
        return response;
    };

    
    this.GET_FULLDATA_LCN_EDIT = function (MODEL) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/LCN_CENTER/CODE_CENTER"),
            dataType: "json",
            data: {
                MODEL: MODEL
            }
        });
        return response;
    };


    this.SP_GET_BOX_CTZNO = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_CTZNO"),
            params: { 
                LCN_IDA: LCN_ID,
                CTZNO: CITIZEN_NO,
                LCN_TYPE: LCN_TYPE,
                TOKEN: TOKEN
            }
        });
        return response;
    };

    this.SP_MASTER_CER_PK_BY_FK_IDA = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_MASTER_CER_PK_BY_FK_IDA"),
            params: {
                IDA: IDA
            }
        });
        return response;
    };
    
    this.GET_LCN_EDIT = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_LCN_EDIT"),
            params: {
                IDA: IDA
            }
        });
        return response;
    };
    this.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY = function (identify,lcnsid) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY"),
            params: {
                identify: identify,
                lcnsid: lcnsid
            }
        });
        return response;
    };
    
    this.GET_LCN_INFORMATION_INPUT = function (BSN_IDENTIFY, IDENTIFY, LCT_IDA, HEAD_LCN_IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_LCN_INFORMATION_INPUT"),
            params: {
                BSN_IDENTIFY: BSN_IDENTIFY,
                IDENTIFY: IDENTIFY,
                LCT_IDA: LCT_IDA,
                HEAD_LCN_IDA: HEAD_LCN_IDA
            }
        });
        return response;
    };
    
    this.GET_LCN_SUBTITUTE_INPUT = function (BSN_IDENTIFY, LCN_IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_LCN_SUBTITUTE_INPUT"),
            params: {
                BSN_IDENTIFY: BSN_IDENTIFY,
                LCN_IDA: LCN_IDA
            }
        });
        return response;
    };
    
    
    this.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP = function (LOCATION_TYPE_CD, IDENTIFY) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP"),
            params: {
                LOCATION_TYPE_CD: LOCATION_TYPE_CD,
                IDENTIFY: IDENTIFY
            }
        });
        return response;
    };
    
    this.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1 = function (LOCATION_TYPE_CD, IDENTIFY) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1"),
            params: {
                LOCATION_TYPE_CD: LOCATION_TYPE_CD,
                IDENTIFY: IDENTIFY
            }
        });
        return response;
    };

    //this.GET_LCN_INFORMATION_BSN_INPUT = function (LOCATION_TYPE_CD,iden) {
    //    var response = $http({
    //        method: "post",
    //        url: SET_URL_SV("/SV_CENTER/SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP"),
    //        params: {
    //            LOCATION_TYPE_CD: LOCATION_TYPE_CD,
    //            iden: iden
    //        }
    //    });
    //    return response;
    //};

    this.GET_LCN_INFORMATION_BSN_INPUT = function (BSN_IDENTIFY) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_LCN_INFORMATION_BSN_INPUT"),
            params: {
                BSN_IDENTIFY: BSN_IDENTIFY
            }
        });
        return response;
    };
    
    this.GET_REF_CERT_DH = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_REF_CERT_DH"),
            params: {
                IDA: IDA
            }
        });
        return response;
    };



    this.INSERT_DH = function (data, ProcessID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/INSERT_DH"),
            dataType: "json",
            data: {
                XML_DH: JSON.stringify(data),
                _ProcessID: ProcessID
            }
        });
        return response;
    };



    this.INSERT_CERT_GMP = function (aa,bb,ProcessID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/INSERT_CERT_GMP"),
            dataType: "json",
            data: {
                XML_CERT: JSON.stringify(aa),
                XML_CHEM: JSON.stringify(bb),
                _ProcessID: ProcessID
                
            }
        });
        return response;
    };

    
    this.INSERT_LCN_EDIT_RQT = function (aa, ProcessID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/INSERT_LCN_EDIT_RQT"),
            dataType: "json",
            data: {
                XML_EDIT: JSON.stringify(aa),
                _ProcessID: ProcessID

            }
        });
        return response;
    };


    
    this.INSERT_CHEM_RQT = function (LIST_GMP, PROCEESS, FK_IDA, MAIN_TYPE, SUB_TYPE, aori) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/INSERT_CHEM_RQT"),
            dataType: "json",
            data: {
                XML_CHEM: JSON.stringify(LIST_GMP),
                _ProcessID: PROCEESS,
                FK_IDA: FK_IDA,
                MAIN_TYPE: MAIN_TYPE,
                SUB_TYPE: SUB_TYPE,
                aori: aori
            }
        });
        return response;
    };

    
    this.UPDATE_CHEM_RQT = function (LIST_GMP, IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_CHEM_RQT"),
            dataType: "json",
            data: {
                XML_CHEM: JSON.stringify(LIST_GMP),
               IDA:IDA
            }
        });
        return response;
    };

    this.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA = function (LOCATION_ADDRESS_IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA"),
            params: {
                LOCATION_ADDRESS_IDA: LOCATION_ADDRESS_IDA
            }
        });
        return response;
    };

    this.GET_LCNNO_SHOW = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_LCN_NO"),
            params: {
                IDA: IDA
            }
        });
        return response;
    };


    this.GET_PREVIEW_CERT = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_PREVIEW_CERT"),
            params: {
                IDA: IDA
            }
        });
        return response;
    };



    this.UPDATE_BOX_INV = function (model, model2) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_BOX_INV"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                XML: JSON.stringify(model),
                XML2: JSON.stringify(model2)
            }
        });
        return response;
    };


    this.GETDATA_FILE_TR_ID = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_FILE_TR_ID"),
            params: {
                TR_ID: TR_ID
            }
        });
        return response;
    };

    this.SP_GET_BOX_STAFF = function (ORG) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_STAFF"),
            params: {
                ORG: ORG
            }
        });
        return response;
    };

    this.SP_GET_BOX_APPROVE = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_APPROVE"),
            params: {
                TR_ID: TR_ID
            }
        });
        return response;
    };

    this.SP_GET_BOX_STAFF_STATUS = function (ORG,STATUS) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_BOX_STAFF_STATUS"),
            params: {
                ORG: ORG,
                STATUS: STATUS
            }
        });
        return response;
    };
    

    this.SP_GET_PRODUCT_TYPE = function (PRODUCT_GROUP) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_PRODUCT_TYPE"),
            params: {
                PRODUCT_GROUP: PRODUCT_GROUP
            }
        });
        return response;
    };
    //
    this.SP_MASTER_sysisocnt = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_MASTER_sysisocnt")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };

    this.SP_dactg = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_dactg")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    this.SP_DRUG_UNIT_PHYSIC = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_DRUG_UNIT_PHYSIC")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    
    this.SP_SYSPREFIX = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_SYSPREFIX")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    this.SP_SYSPREFIX_PERSON = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_SYSPREFIX_PERSON")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    this.GET_dramltype = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_dramltype")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    this.GET_dramlsubtp = function (amltpcd) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_dramlsubtp"),
            params: {
                amltpcd: amltpcd
            }
        });
        return response;
    };
    this.GET_dramlsubtp = function (amlsubcd) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_dramlusetp"),
            params: {
                amlsubcd: amlsubcd
            }
        });
        return response;
    };

    this.SP_MASTER_drclass = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_MASTER_drclass")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    
    this.SP_dosage_form = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_dosage_form")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    
    this.GET_MAS_BIO_UNIT = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_MAS_BIO_UNIT")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    
    this.GET_DRUG_PACKAGING = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_DRUG_PACKAGING")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };
    
    this.SP_MAS_DRUG_SHAPE = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_MAS_DRUG_SHAPE")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };

    this.SP_drkdofdrg = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_drkdofdrg")
            //params: {
            //    PRODUCT_GROUP: PRODUCT_GROUP
            //}
        });
        return response;
    };

    this.SP_GET_ISO = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_ISO"),
            params: {
                CTZNO: CITIZEN_NO,
                TOKEN: TOKEN
            }
        });
        return response;
    };
    this.SP_GET_PROCESS  = function (ORG) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_PROCESS"),
            params: {
                ORG: ORG,
                PROCESS_TYPE : LCN_TYPE
            }
        });
        return response;
    };
    
    this.GETDATA_FILE_TEMPLATE = function (PROCESS) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_FILE_TEMPLATE"),
            params: {
                PROCESS: PROCESS,
                LCN_TYPE: LCN_TYPE
            }
        });
        return response;
    };

    this.GET_LIST_LCN = function (IDENTIFY) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_LIST_LCN"),
            params: {
                IDENTIFY: IDENTIFY,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.GETDATA_SYSISOCNT = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_SYSISOCNT")
            
        });
        return response;
    };

    this.GETDATA_SIP_UNIT = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_SIP_UNIT")

        });
        return response;
    };

    this.GET_AUTHEN_DATA = function (TOKEN) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_AUTHEN"),
            params: {
                TOKEN: TOKEN
            }
        });
        return response;
    };

    this.GETDATA_DRDOSAGE = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_DRDOSAGE")

        });
        return response;
    };

   
    
    this.SET_MODEL = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL")
        });
        return response;
    };

    this.SETMODEL_DH = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL_DH")
        });
        return response;
    };

    this.SETMODEL_CHEM = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL_CHEM")
        });
        return response;
    };


    this.SETMODEL_EDIT_LCN = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL_EDIT_LCN")
        });
        return response;
    };

    this.SETMODEL_CHEMICAL = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL_CHEMICAL")
        });
        return response;
    };

    this.GET_DATAPROCESS = function (P_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_DATAPROCESS"),
            params: {
                P_ID: P_ID,
                LCN_TYPE: LCN_TYPE
            }
        });
        return response;
    };

    
    this.GET_INFORMARION_DH = function (LCN_IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_INFORMARION_DH"),
            params: {
                LCN_IDA: LCN_IDA
            }
        });
        return response;
    };


    this.GETDATA_DRUG_PRODUCT = function (register) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_DRUG_PRODUCT_ESUB"),
            params: {
                register : register
            }
        });
        return response; 
    };

    this.SETMODEL_LIST = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL_LIST")
        });
        return response;
    };
    
    this.GETDATA_INV_ITEM = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_INV_ITEM"),
            params: {
                TR_ID: TR_ID,
                CTZNO: CITIZEN_NO,
                TOKEN: TOKEN
            }
        });
        return response;
    };

    this.UPLOAD_PDF = function (CITIZEN_ID, TOKEN, file) { //เรียก Full model
        var response = Upload.upload({
            // url: host + "FOOD_CUST/UPLOAD_PDF",
            url: SET_URL_SV("/SV_CENTER/UPLOAD_PDF"),
            data: {
                CITIZEN_ID: CITIZEN_ID,
                TOKEN: TOKEN,
                files: file
            }
        });
        return response;
    };



    this.UPLOAD_PDF_V2 = function (model, file) { //เรียก Full model

        var response = Upload.upload({
            // url: host + "FOOD_CUST/UPLOAD_PDF",
            url: SET_URL_SV("/SV_CENTER/UPLOAD_PDF_V2"),
            data: {
                model: JSON.stringify(model),
                files: file
            }
        });
        return response;
    };


    this.UPLOAD_PDF_V3 = function (model, file) { //เรียก Full model

        var response = Upload.upload({
            // url: host + "FOOD_CUST/UPLOAD_PDF",
            url: SET_URL_SV("/SV_CENTER/UPLOAD_PDF_V3"),
            data: {
                model: JSON.stringify(model),
                files: file
            }
        });
        return response;
    };

    this.ADD_DATA_INV = function (model, model2) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/ADD_DATA_INV"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                XML: JSON.stringify(model),
                XML2: JSON.stringify(model2),
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.GETDATA_BOX_TR_ID = function (TR_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_BOX_TR_ID"),
            params: {
                TR_ID: TR_ID,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.UPDATE_DATA = function (TR_ID, STATUS_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_DATA"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                TR_ID: TR_ID,
                STATUS_ID: STATUS_ID,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };


    


    this.UPDATE_ITEM_INVOICE_STATUS = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_ITEM_INVOICE_STATUS"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                IDA: IDA
            }
        });
        return response;
    };

    
    this.GET_DETAIL_CHEM_RQT_STAFF = function (IDA_CHEM_RQT) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_DETAIL_CHEM_RQT_STAFF"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                IDA_CHEM_RQT: IDA_CHEM_RQT
            }
        });
        return response;
    };


    this.UPDATE_DATA_STAFF = function (TR_ID, STATUS_ID, REMARK) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/UPDATE_DATA_STAFF"), //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                TR_ID: TR_ID,
                STATUS_ID: STATUS_ID,
                REMARK: REMARK,
                TOKEN: TOKEN,
                CTZNO: CITIZEN_NO
            }
        });
        return response;
    };

    this.SP_GET_INV_HISTORY = function (CTZNO) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_INV_HISTORY"),
            params: {
                CTZNO: CTZNO
            }
        });
        return response;
    };

    this.SP_GET_DATA_LCN = function (CITIZEN,lcnno,pvncd) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_DATA_LCN"),
            params: {
                CITIZEN: CITIZEN,
                lcnno: lcnno,
                pvncd: pvncd
            }
        });
        return response;
    };

    this.GET_TREEVIEW = function (GROUP_NAME , HEAD_ID) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_TREEVIEW"),
            params: {
               
                GROUP_NAME: GROUP_NAME,
                HEAD_ID: HEAD_ID
            }
        });
        return response;
    };
    this.SP_GET_LCN = function (CITIZEN) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_GET_LCN"),
            params: {
                CITIZEN: CITIZEN
            }
        });
        return response;
    };
    this.GET_INFORMATION = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_INFORMATION"),
            params: {
                IDA: IDA
            }
        });
        return response;
    };

    this.SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden = function (IDA,CER_TYPE,IDEN) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden"),
            params: {
                IDA: IDA,
                CER_TYPE: CER_TYPE,
                IDEN: IDEN
            }
        });
        return response;
    };

    this.SP_DH15RQT_BY_IDA = function (lcn_ida,process_id) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_DH15RQT_BY_IDA"),
            params: {
                lcn_ida: lcn_ida,
                process_id: process_id
            }
        });
        return response;
    };

    this.SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE = function (IDEN,MT,ST,AORI) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE"),
            params: {
                IDEN: IDEN,
                MT: MT,
                ST: ST,
                AORI: AORI
            }
        });
        return response;
    };

    this.SP_MAS_CHEMICAL_by_IOWANM_AND_AORI = function (IOWANM, AORI) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SP_MAS_CHEMICAL_by_IOWANM_AND_AORI"),
            params: {
               
                IOWANM: IOWANM,
                AORI: AORI
            }
        });
        return response;
    };
    this.GETDATA_CHEMICAL = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GETDATA_CHEMICAL"),
            params: {
                IDA: IDA
            }
        });
        return response;
    };

    this.SETMODEL_DHA = function () {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/SETMODEL_DHA"),
            params: {
                
            }
        });
        return response;
    };

    this.GET_PREVIEW_DH = function (IDA) {
        var response = $http({
            method: "post",
            url: SET_URL_SV("/SV_CENTER/GET_PREVIEW_DH"),
            params: {
                IDA:IDA
            }
        });
        return response;
    };

    this.GET_LOT_RELEASE = function (Month, Year) {
        var requestData = {
            Month: Month,
            Year: Year
        };
        var response = $http({
            method: "post",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'charset': 'utf-8'
            },
            url: "https://ilabplus.dmsc.moph.go.th/DMSC_Service/GetLotReleaseInfo",
            dataType: "json",
            data: JSON.stringify(requestData)
        });
        return response; 
    };
});



