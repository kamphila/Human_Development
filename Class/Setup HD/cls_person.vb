Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Net.Dns
Imports System.Configuration
Public Class cls_person
    'Dim cls_log As New cls_log
    'Dim cls_myfunc As New cls_myfunc
    Private strempcd As String
    Private strpcnm As String
    Private strdate As String
    Private strsessionid As String
    Public message As String = ""
    Private strperson_id As String

    Private strapp_code As String
    Private strid As String
    Private strper_type As String
    Private strprefix_01 As String
    Private strprefix_02 As String
    Private strname_01 As String
    Private strname_02 As String
    Private strsname_01 As String
    Private strsname_02 As String
    Private strwork_start As String
    Private strnickname_01 As String
    Private strbirthdate As String
    Private strbirth_province As String
    Private stridcard_no As String
    Private strid_start_date As String
    Private strid_expire_date As String
    Private strblood As String
    Private strheight As String
    Private strweight As String
    Private strnation As String
    Private strrace As String
    Private strreligion As String
    Private strmobile As String
    Private stremail As String
    Private strcreate_by As String
    Private strcreate_date As String
    Private strstatus As String
    Private strcorp As String

    Property empcd()
        Get
            Return strempcd
        End Get
        Set(ByVal value)
            strempcd = value
        End Set
    End Property
    Property pcnm()
        Get
            Return strpcnm
        End Get
        Set(ByVal value)
            strpcnm = value
        End Set
    End Property
    Property date_app()
        Get
            Return strdate
        End Get
        Set(ByVal value)
            strdate = value
        End Set
    End Property
#Region "AutoGenerateOT_Type_ID"
    Property person_id()
        Get
            Return strperson_id
        End Get
        Set(ByVal value)
            strperson_id = value
        End Set
    End Property

    Property app_code()
        Get
            Return strapp_code
        End Get
        Set(ByVal value)
            strapp_code = value
        End Set
    End Property
    Property id()
        Get
            Return strid
        End Get
        Set(ByVal value)
            strid = value
        End Set
    End Property
    Property per_type()
        Get
            Return strper_type
        End Get
        Set(ByVal value)
            strper_type = value
        End Set
    End Property
    Property prefix_01()
        Get
            Return strprefix_01
        End Get
        Set(ByVal value)
            strprefix_01 = value
        End Set
    End Property
    Property name_01()
        Get
            Return strname_01
        End Get
        Set(ByVal value)
            strname_01 = value
        End Set
    End Property
    Property sname_01()
        Get
            Return strsname_01
        End Get
        Set(ByVal value)
            strsname_01 = value
        End Set
    End Property
    Property prefix_02()
        Get
            Return strprefix_02
        End Get
        Set(ByVal value)
            strprefix_02 = value
        End Set
    End Property
    Property name_02()
        Get
            Return strname_02
        End Get
        Set(ByVal value)
            strname_02 = value
        End Set
    End Property
    Property sname_02()
        Get
            Return strsname_02
        End Get
        Set(ByVal value)
            strsname_02 = value
        End Set
    End Property
    Property work_start()
        Get
            Return strwork_start
        End Get
        Set(ByVal value)
            strwork_start = value
        End Set
    End Property
    Property nickname_01()
        Get
            Return strnickname_01
        End Get
        Set(ByVal value)
            strnickname_01 = value
        End Set
    End Property
    Property birthdate()
        Get
            Return strbirthdate
        End Get
        Set(ByVal value)
            strbirthdate = value
        End Set
    End Property
    Property birth_province()
        Get
            Return strbirth_province
        End Get
        Set(ByVal value)
            strbirth_province = value
        End Set
    End Property
    Property idcard_no()
        Get
            Return stridcard_no
        End Get
        Set(ByVal value)
            stridcard_no = value
        End Set
    End Property
    Property id_start_date()
        Get
            Return strid_start_date
        End Get
        Set(ByVal value)
            strid_start_date = value
        End Set
    End Property
    Property id_expire_date()
        Get
            Return strid_expire_date
        End Get
        Set(ByVal value)
            strid_expire_date = value
        End Set
    End Property
    Property blood()
        Get
            Return strblood
        End Get
        Set(ByVal value)
            strblood = value
        End Set
    End Property
    Property height()
        Get
            Return strheight
        End Get
        Set(ByVal value)
            strheight = value
        End Set
    End Property
    Property weight()
        Get
            Return strweight
        End Get
        Set(ByVal value)
            strweight = value
        End Set
    End Property
    Property nation()
        Get
            Return strnation
        End Get
        Set(ByVal value)
            strnation = value
        End Set
    End Property
    Property race()
        Get
            Return strrace
        End Get
        Set(ByVal value)
            strrace = value
        End Set
    End Property
    Property religion()
        Get
            Return strreligion
        End Get
        Set(ByVal value)
            strreligion = value
        End Set
    End Property
    Property mobile()
        Get
            Return strmobile
        End Get
        Set(ByVal value)
            strmobile = value
        End Set
    End Property
    Property email()
        Get
            Return stremail
        End Get
        Set(ByVal value)
            stremail = value
        End Set
    End Property
    Property create_by()
        Get
            Return strcreate_by
        End Get
        Set(ByVal value)
            strcreate_by = value
        End Set
    End Property
    Property create_date()
        Get
            Return strcreate_date
        End Get
        Set(ByVal value)
            strcreate_date = value
        End Set
    End Property
    Property status()
        Get
            Return strstatus
        End Get
        Set(ByVal value)
            strstatus = value
        End Set
    End Property
    Property corp()
        Get
            Return strcorp
        End Get
        Set(ByVal value)
            strcorp = value
        End Set
    End Property
#End Region

    Public Sub New()
    End Sub
    Public Sub New(id As String)
        Dim dt As DataTable
        If String.Empty.Equals(id) = False Then
            'aaa
            person_id = id
            dt = Me.Get_Person_Name_Man()
            If dt.Rows.Count > 0 Then
                empcd = cNull(dt.Rows(0)("em_code"), "S")
                prefix_01 = cNull(dt.Rows(0)("prefix_01"), "S")
                name_01 = cNull(dt.Rows(0)("name_01"), "S")
                sname_01 = cNull(dt.Rows(0)("sname_01"), "S")
            End If

        End If
    End Sub

    'Public Function Add()
    '    Dim sqlDb As New Cls_SqlDB
    '    Dim sqlCommand As String
    '    Dim dt As New DataTable
    '    Try
    '        sqlCommand = "select * from tbt_applications where app_code='" + cls_myfunc.f_rpl_pk(app_code) + "'"
    '        dt = sqlDb.GetDataTable(sqlCommand)
    '        If dt.Rows.Count > 0 Then
    '            sqlDb.BeginTrans()
    '            sqlCommand = "INSERT INTO person_data "
    '            sqlCommand &= "(id,per_type,prefix_01,name_01,sname_01,prefix_02,name_02,sname_02,nickname_01,work_start,"
    '            sqlCommand &= "birthdate,birth_province,idcard_no,id_start_date,id_expire_date,blood,height,weight,nation,"
    '            sqlCommand &= "race,religion,mobile,email,create_by,create_date,status,corp)"
    '            sqlCommand &= "VALUES('" + cls_myfunc.f_rpl_pk(id) + "',"
    '            sqlCommand &= "'1',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_title_thai").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_firstname_thai").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_lastname_thai").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_title_eng").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_firstname_eng").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_lastname_eng").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_nickname").ToString) + "',"
    '            sqlCommand &= "'" + Convert.ToDateTime(work_start).ToString("yyyy-MM-dd") + "',"
    '            'sqlCommand &= "'" + Convert.ToDateTime(work_start).ToString("yyyy-dd-MM") + "',"
    '            sqlCommand &= "'" + Convert.ToDateTime(dt.Rows(0).Item("app_birthday")).ToString("yyyy-MM-dd") + "',"
    '            'sqlCommand &= "'" + Convert.ToDateTime(dt.Rows(0).Item("app_birthday")).ToString("yyyy-dd-MM") + "',"
    '            sqlCommand &= cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_place_birth").ToString) + ","
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_idcard").ToString) + "',"
    '            sqlCommand &= "'" + Convert.ToDateTime(dt.Rows(0).Item("app_date_issue")).ToString("yyyy-MM-dd") + "',"
    '            'sqlCommand &= "'" + Convert.ToDateTime(dt.Rows(0).Item("app_date_issue")).ToString("yyyy-dd-MM") + "',"
    '            sqlCommand &= "'" + Convert.ToDateTime(dt.Rows(0).Item("app_date_expiry")).ToString("yyyy-MM-dd") + "',"
    '            'sqlCommand &= "'" + Convert.ToDateTime(dt.Rows(0).Item("app_date_expiry")).ToString("yyyy-dd-MM") + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_blood").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_stature").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_weight").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_nationality").ToString) + "',"

    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_race").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_religion").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_present_mobile").ToString) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(dt.Rows(0).Item("app_present_email").ToString) + "',"

    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(create_by) + "',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(create_date) + "','1',"
    '            sqlCommand &= "'" + cls_myfunc.f_rpl_text(corp) + "')"
    '            sqlDb.Exec(sqlCommand)

    '            sqlCommand = "update tbt_applications set status='5'  where app_code='" + cls_myfunc.f_rpl_pk(app_code) + "'"
    '            sqlDb.Exec(sqlCommand)
    '            sqlDb.CommitTrans()
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        cls_log.WriteError("cls_person", "Function Add()", ex.Message)
    '        sqlDb.RollbackTrans()
    '        Return False
    '    End Try
    'End Function

    Public Function Get_Payment(ByVal person_id)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.em_status in('W','P','RR')"
        Dim sql As String
        Try
            If person_id <> "" Then
                where &= " and person_data.id='" & person_id & "'"
            End If
            sql = "select "
            sql &= " person_data.id,"
            sql &= " S_Period.id  as payment_id,"
            sql &= " S_Period.period_no "
            sql &= " from person_data "
            sql &= " left join payment_package on person_data.period_no=payment_package.id"
            sql &= " left join S_Period on S_Period.pay_package_id=payment_package.id " & where
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Name()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Name()
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.em_status in('W','P','RR')"
        Dim sql As String
        Try
            If person_id <> "" Then
                where &= " and id='" & person_id & "'"
            End If
            sql = "select prefix_01,name_01,sname_01 "
            sql &= "from person_data " & where
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Name()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Name_Man()
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.em_status in('W','P','RR')"
        Dim sql As String
        Try
            If person_id <> "" Then
                where &= " and id='" & person_id & "'"
            End If
            sql = "select * "
            sql &= "from person_data " & where
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Name_Man()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Shift()
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = ""
        Dim sql As String
        Try
            If person_id <> "" Then
                where = " where T1.person_id='" & person_id & "' and T2.code<>'' and work_date='" & sqlDB.GetDataTable("SELECT convert(varchar(10),getdate(),120)").Rows(0)(0).ToString & "' "
            End If
            sql = "select T2.code as shift_code,T2.name_01 as shift_name, T3.code as group_code,T3.name_01 as group_name "
            sql &= "FROM work_tab T1 LEFT OUTER JOIN shift T2 "
            sql &= "ON T1.shift_id = T2.id and T2.status = '1' LEFT OUTER JOIN S_shift_group T3 "
            sql &= "ON T1.group_id = T3.id and T3.status = '1' "
            sql &= where
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Shift()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Req1(ByVal con, ByVal welfare_code)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.id<>'' and person_data.em_status in('W','P','RR')"
        Dim sql As String
        Try
            If con <> "" Then
                where &= con
            End If
            sql = "select"
            sql &= " position.id as position_id,"
            sql &= " position.position_code as position_code,"
            sql &= " position.name_01 as position_name,"
            sql &= " position.station_id,"
            sql &= " person_data.id as person_id,"
            sql &= " person_data.em_code as person_code,"
            sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name,"
            sql &= " isnull(person_data.budget_total,0) as budget_total,"
            sql &= " isnull(person_data.budget_use,0) as budget_use,"
            sql &= " isnull(person_data.budget_remain,0) as budget_remain"
            sql &= " from position "
            sql &= " left join per_position on position.id=per_position.position_id"
            sql &= " left join person_data on per_position.person_id=person_data.id "
            sql &= " left join position_level on position_level.id=position.position_level"
            sql &= where
            sql &= " and person_data.id not in("
            sql &= " select "
            sql &= " tbt_welfare_request_dtl.welfare_request_person_code"
            sql &= " from tbt_welfare_request "
            sql &= " left join tbt_welfare_request_dtl on tbt_welfare_request_dtl.welfare_request_code=tbt_welfare_request.welfare_request_code"
            sql &= " left join tbm_welfare on tbm_welfare.welfare_code=tbt_welfare_request.welfare_request_welfare_code"
            sql &= " where"
            sql &= " tbm_welfare.welfare_status='Active'"
            sql &= " and tbm_welfare.welfare_code='" & welfare_code & "'"
            sql &= " )"
            sql &= " order by person_data.id"
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Req1()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Req2(ByVal con, ByVal welfare_code)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.id<>'' and person_data.em_status in('W','P','RR') "
        Dim sql As String
        Try
            If con <> "" Then
                where &= con
            End If
            sql = "select"
            sql &= " position.id as position_id,"
            sql &= " position.position_code as position_code,"
            sql &= " position.name_01 as position_name,"
            sql &= " position.station_id,"
            sql &= " person_data.id as person_id,"
            sql &= " person_data.em_code as person_code,"
            sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name,"
            sql &= " isnull(person_data.budget_total,0) as budget_total,"
            sql &= " isnull(person_data.budget_use,0) as budget_use,"
            sql &= " isnull(person_data.budget_remain,0) as budget_remain"
            sql &= " from position "
            sql &= " left join per_position on position.id=per_position.position_id"
            sql &= " left join person_data on per_position.person_id=person_data.id "
            sql &= " left join position as position_std on position_std.id=position.position_list_id"
            sql &= where
            sql &= " and person_data.id not in("
            sql &= " select "
            sql &= " tbt_welfare_request_dtl.welfare_request_person_code"
            sql &= " from tbt_welfare_request "
            sql &= " left join tbt_welfare_request_dtl on tbt_welfare_request_dtl.welfare_request_code=tbt_welfare_request.welfare_request_code"
            sql &= " left join tbm_welfare on tbm_welfare.welfare_code=tbt_welfare_request.welfare_request_welfare_code"
            sql &= " where"
            sql &= " tbm_welfare.welfare_status='Active'"
            sql &= " and tbm_welfare.welfare_code='" & welfare_code & "'"
            sql &= " )"
            sql &= " order by person_data.id"
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Req2()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Req3(ByVal con, ByVal welfare_code)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.id<>'' and person_data.em_status in('W','P','RR') "
        Dim sql As String
        Try
            If con <> "" Then
                where &= con
            End If
            sql = "select"
            sql &= " position.id as position_id,"
            sql &= " position.position_code as position_code,"
            sql &= " position.name_01 as position_name,"
            sql &= " position.station_id,"
            sql &= " person_data.id as person_id,"
            sql &= " person_data.em_code as person_code,"
            sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name,"
            sql &= " isnull(person_data.budget_total,0) as budget_total,"
            sql &= " isnull(person_data.budget_use,0) as budget_use,"
            sql &= " isnull(person_data.budget_remain,0) as budget_remain"
            sql &= " from position "
            sql &= " left join per_position on position.id=per_position.position_id"
            sql &= " left join person_data on per_position.person_id=person_data.id "
            sql &= where
            sql &= " and person_data.id not in("
            sql &= " select "
            sql &= " tbt_welfare_request_dtl.welfare_request_person_code"
            sql &= " from tbt_welfare_request "
            sql &= " left join tbt_welfare_request_dtl on tbt_welfare_request_dtl.welfare_request_code=tbt_welfare_request.welfare_request_code"
            sql &= " left join tbm_welfare on tbm_welfare.welfare_code=tbt_welfare_request.welfare_request_welfare_code"
            sql &= " where"
            sql &= " tbm_welfare.welfare_status='Active'"
            sql &= " and tbm_welfare.welfare_code='" & welfare_code & "'"
            sql &= " )"
            sql &= " order by person_data.id"
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Req3()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Req4(ByVal con, ByVal welfare_code)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.id<>'' and person_data.em_status in('W','P','RR') "
        Dim sql As String
        Try
            If con <> "" Then
                where &= con
            End If
            sql = "select"
            sql &= " position.id as position_id,"
            sql &= " position.position_code as position_code,"
            sql &= " position.name_01 as position_name,"
            sql &= " position.station_id,"
            sql &= " person_data.id as person_id,"
            sql &= " person_data.em_code as person_code,"
            sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name,"
            sql &= " isnull(person_data.budget_total,0) as budget_total,"
            sql &= " isnull(person_data.budget_use,0) as budget_use,"
            sql &= " isnull(person_data.budget_remain,0) as budget_remain"
            sql &= " from position "
            sql &= " left join per_position on position.id=per_position.position_id"
            sql &= " left join person_data on per_position.person_id=person_data.id "
            sql &= where
            sql &= " and person_data.id not in("
            sql &= " select "
            sql &= " tbt_welfare_request_dtl.welfare_request_person_code"
            sql &= " from tbt_welfare_request "
            sql &= " left join tbt_welfare_request_dtl on tbt_welfare_request_dtl.welfare_request_code=tbt_welfare_request.welfare_request_code"
            sql &= " left join tbm_welfare on tbm_welfare.welfare_code=tbt_welfare_request.welfare_request_welfare_code"
            sql &= " where"
            sql &= " tbm_welfare.welfare_status='Active'"
            sql &= " and tbm_welfare.welfare_code='" & welfare_code & "'"
            sql &= " )"
            sql &= " order by person_data.id"
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Req4()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Req5(ByVal con, ByVal welfare_code)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.id<>'' and person_data.em_status in('W','P','RR') "
        Dim sql As String
        Try
            If con <> "" Then
                where &= con
            End If
            sql = "select"
            sql &= " position.id as position_id,"
            sql &= " position.position_code as position_code,"
            sql &= " position.name_01 as position_name,"
            sql &= " position.station_id,"
            sql &= " person_data.id as person_id,"
            sql &= " person_data.em_code as person_code,"
            sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name,"
            sql &= " isnull(person_data.budget_total,0) as budget_total,"
            sql &= " isnull(person_data.budget_use,0) as budget_use,"
            sql &= " isnull(person_data.budget_remain,0) as budget_remain"
            sql &= " from position "
            sql &= " left join per_position on position.id=per_position.position_id"
            sql &= " left join person_data on per_position.person_id=person_data.id "
            sql &= where
            sql &= " and person_data.id not in("
            sql &= " select "
            sql &= " tbt_welfare_request_dtl.welfare_request_person_code"
            sql &= " from tbt_welfare_request "
            sql &= " left join tbt_welfare_request_dtl on tbt_welfare_request_dtl.welfare_request_code=tbt_welfare_request.welfare_request_code"
            sql &= " left join tbm_welfare on tbm_welfare.welfare_code=tbt_welfare_request.welfare_request_welfare_code"
            sql &= " where"
            sql &= " tbm_welfare.welfare_status='Active'"
            sql &= " and tbm_welfare.welfare_code='" & welfare_code & "'"
            sql &= " )"
            sql &= " order by person_data.id"
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Req5()", ex.Message)
        End Try
        Return dt
    End Function

    Public Function Get_Person_Req(ByVal con)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.status=1 and position.corp ='" & GBCorp & "' and per_position.status=1 and per_position.position_type = '1' and per_position.position_status = '1'  "
        Dim sql As String
        Try
            If con <> "" Then
                where &= con
            End If
            If GBLangIndex = 1 Then
                sql = "select"
                sql &= " person_data.id as person_id,"
                sql &= " person_data.em_code as person_code,"
                sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name,"
                sql &= " per_position.position_id as position_id,"
                sql &= " position.position_code,"
                sql &= " position.name_01 as position_name,"
                sql &= " position_level.id as position_level_id,"
                sql &= " position_level.name_01 as position_level_name,"
                sql &= " branch.id as branch_id,"
                sql &= " branch.name_01 as branch_name,"
                sql &= " station.id as station_id,isnull(DATEDIFF (Year,person_data.work_start,GETDATE()),0) as yesr_work,"
                sql &= " station.name_01 as station_name"
            Else
                sql = "select"
                sql &= " person_data.id as person_id,"
                sql &= " person_data.em_code as person_code,"
                sql &= " person_data.prefix_02 +''+person_data.name_02 +' '+person_data.sname_02 as person_name,"
                sql &= " per_position.position_id as position_id,"
                sql &= " position.position_code,"
                sql &= " position.name_02 as position_name,"
                sql &= " position_level.id as position_level_id,"
                sql &= " position_level.name_02 as position_level_name,"
                sql &= " branch.id as branch_id,"
                sql &= " branch.name_02 as branch_name,"
                sql &= " station.id as station_id,isnull(DATEDIFF (Year,person_data.work_start,GETDATE()),0) as yesr_work,"
                sql &= " station.name_02 as station_name"
            End If
            sql &= " from person_data "
            sql &= " left join per_position on per_position.person_id=person_data.id"
            sql &= " left join position on position.id=per_position.position_id"
            sql &= " left join position_level on position_level.id=position.position_level"
            sql &= " left join station on station.id=position.station_id"
            sql &= " left join"
            sql &= " ("
            sql &= " select id,name_01,name_02,st_link from station where corp ='" & GBCorp & "' And status = 1 "
            sql &= " )as branch on branch.st_link=LEFT(station.st_link,3) "
            sql &= where
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Req()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Family_All(ByVal person_id)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where person_data.corp ='" & GBCorp & "' and person_data.status=1 and person_data.per_type=2  "
        Dim sql As String
        Try
            If person_id <> "" Then
                If GBLangIndex = 1 Then
                    sql = "select"
                    sql &= " person_data.id as person_id,"
                    sql &= " person_data.em_code as person_code,"
                    sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name"
                    sql &= " ,case when family.relation_type ='1' then 'บิดา'"
                    sql &= " when family.relation_type ='2' then 'มารดา'"
                    sql &= " when family.relation_type ='3' then 'บุตร'"
                    sql &= " when family.relation_type ='4' then 'พี่น้อง'"
                    sql &= " when family.relation_type ='5' then 'คู่สมรส'"
                    sql &= " end as relation_name"
                Else
                    sql = "select"
                    sql &= " person_data.id as person_id,"
                    sql &= " person_data.em_code as person_code,"
                    sql &= " person_data.prefix_02 +''+person_data.name_02 +' '+person_data.sname_02 as person_name"
                    sql &= " ,case when family.relation_type ='1' then 'Father'"
                    sql &= " when family.relation_type ='2' then 'Mother'"
                    sql &= " when family.relation_type ='3' then 'Children'"
                    sql &= " when family.relation_type ='4' then 'Brothers'"
                    sql &= " when family.relation_type ='5' then 'Spouse'"
                    sql &= " end as relation_name"
                End If
                sql &= " from person_data "
                sql &= " left join family on family.family_id=person_data.id"
                sql &= where
                sql &= " and family.person_id='" & person_id & "'"
                sql &= " and person_data.id not in ("
                sql &= " select welfare_request_family_id from tbt_welfare_request_person_V2 "
                sql &= " where gb_corpid='" & GBCorp & "' "
                sql &= " and welfare_request_family_id<>'' and welfare_request_status in(0,1) "
                sql &= " and welfare_request_person_code='" & person_id & "')"
                dt = sqlDB.GetDataTable(sql)
            End If

        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Family_All()", ex.Message)
        End Try
        Return dt
    End Function
    Public Function Get_Person_Req_Edit(ByVal person)
        Dim sqlDB As Cls_SqlDB = New Cls_SqlDB
        Dim dt As DataTable = New DataTable
        Dim where As String = " where position.corp ='" & GBCorp & "' and per_position.status=1 and per_position.position_type = '1' and per_position.position_status = '1' and person_data.em_status in('W','P','RR') "
        Dim sql As String
        Try
            If person <> "" Then
                where &= " and person_data.id='" & person & "'"
            End If
            If GBLangIndex = 1 Then
                sql = "select"
                sql &= " person_data.id as person_id,"
                sql &= " person_data.em_code as person_code,"
                sql &= " person_data.prefix_01 +''+person_data.name_01 +' '+person_data.sname_01 as person_name,"
                sql &= " per_position.position_id as position_id,"
                sql &= " position.position_code,"
                sql &= " position.name_01 as position_name,"
                sql &= " position_level.id as position_level_id,"
                sql &= " position_level.name_01 as position_level_name,"
                sql &= " branch.id as branch_id,"
                sql &= " branch.name_01 as branch_name,"
                sql &= " station.id as station_id,isnull(DATEDIFF (Year,person_data.work_start,GETDATE()),0) as yesr_work,"
                sql &= " station.name_01 as station_name"
            Else
                sql = "select"
                sql &= " person_data.id as person_id,"
                sql &= " person_data.em_code as person_code,"
                sql &= " person_data.prefix_02 +''+person_data.name_02 +' '+person_data.sname_02 as person_name,"
                sql &= " per_position.position_id as position_id,"
                sql &= " position.position_code,"
                sql &= " position.name_02 as position_name,"
                sql &= " position_level.id as position_level_id,"
                sql &= " position_level.name_02 as position_level_name,"
                sql &= " branch.id as branch_id,"
                sql &= " branch.name_02 as branch_name,"
                sql &= " station.id as station_id,isnull(DATEDIFF (Year,person_data.work_start,GETDATE()),0) as yesr_work,"
                sql &= " station.name_02 as station_name"
            End If
            sql &= " from person_data "
            sql &= " left join per_position on per_position.person_id=person_data.id"
            sql &= " left join position on position.id=per_position.position_id"
            sql &= " left join position_level on position_level.id=position.position_level"
            sql &= " left join station on station.id=position.station_id"
            sql &= " left join"
            sql &= " ("
            sql &= " select id,name_01,name_02,st_link from station where corp ='" & GBCorp & "' And status = 1 "
            sql &= " )as branch on branch.st_link=LEFT(station.st_link,3) "
            sql &= where
            dt = sqlDB.GetDataTable(sql)
        Catch ex As Exception
            'cls_log.WriteError("cls_person", "Function Get_Person_Req()", ex.Message)
        End Try
        Return dt
    End Function

End Class
