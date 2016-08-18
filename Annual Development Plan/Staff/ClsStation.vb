Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Public Class ClsStation
    Private straddno As String = String.Empty
    Private stramphur_id As String = String.Empty
    Private strbuilding As String = String.Empty
    Private strcommercial_no As String = String.Empty
    Private strcorp As String = String.Empty
    Private strcountry_id As String = String.Empty
    Private strcreate_by As String = String.Empty
    Private strcreate_date As String = String.Empty
    Private strdescrip_01 As String = String.Empty
    Private strdescrip_02 As String = String.Empty
    Private strdistrict_id As String = String.Empty
    Private strfax As String = String.Empty
    Private strfloor As String = String.Empty
    Private strid As String = String.Empty
    Private strjob_descrip_01 As String = String.Empty
    Private strjob_descrip_02 As String = String.Empty
    Private strlast_action As String = String.Empty
    Private strlast_udt As String = String.Empty
    Private strlock_data As String = String.Empty
    Private strlock_detail As String = String.Empty
    Private strmoo As String = String.Empty
    Private strname_01 As String = String.Empty
    Private strname_02 As String = String.Empty
    Private stroth_code As String = String.Empty
    Private stroth_id As String = String.Empty
    Private strowner_id As String = String.Empty
    Private strparent_id As String = String.Empty
    Private strposition_count As String = String.Empty
    Private strpostal As String = String.Empty
    Private strprovince_id As String = String.Empty
    Private strres_val_01 As String = String.Empty
    Private strres_val_02 As String = String.Empty
    Private strres_val_03 As String = String.Empty
    Private strres_val_04 As String = String.Empty
    Private strres_val_05 As String = String.Empty
    Private strroad As String = String.Empty
    Private strroomno As String = String.Empty
    Private strroot_id As String = String.Empty
    Private strsession_id As String = String.Empty
    Private strsocial_no As String = String.Empty
    Private strsoi As String = String.Empty
    Private strst_code As String = String.Empty
    Private strst_color As String = String.Empty
    Private strst_level As String = String.Empty
    Private strst_link As String = String.Empty
    Private strst_order As String = String.Empty
    Private strst_type As String = String.Empty
    Private strstatus As String = String.Empty
    Private strtax_no As String = String.Empty
    Private strtel As String = String.Empty
    Private strudt_app As String = String.Empty
    Private strudt_code As String = String.Empty
    Private struser_id As String = String.Empty
    Private strvat_no As String = String.Empty
    Private strEm_code As String = String.Empty
    Private strChild_id As String = String.Empty
    Public Property addno() As String
        Get
            Return straddno
        End Get
        Set(ByVal value As String)
            straddno = value
        End Set
    End Property
    Public Property amphur_id() As String
        Get
            Return stramphur_id
        End Get
        Set(ByVal value As String)
            stramphur_id = value
        End Set
    End Property
    Public Property building() As String
        Get
            Return strbuilding
        End Get
        Set(ByVal value As String)
            strbuilding = value
        End Set
    End Property
    Public Property commercial_no() As String
        Get
            Return strcommercial_no
        End Get
        Set(ByVal value As String)
            strcommercial_no = value
        End Set
    End Property
    Public Property corp() As String
        Get
            Return strcorp
        End Get
        Set(ByVal value As String)
            strcorp = value
        End Set
    End Property
    Public Property country_id() As String
        Get
            Return strcountry_id
        End Get
        Set(ByVal value As String)
            strcountry_id = value
        End Set
    End Property
    Public Property create_by() As String
        Get
            Return strcreate_by
        End Get
        Set(ByVal value As String)
            strcreate_by = value
        End Set
    End Property
    Public Property create_date() As String
        Get
            Return strcreate_date
        End Get
        Set(ByVal value As String)
            strcreate_date = value
        End Set
    End Property
    Public Property descrip_01() As String
        Get
            Return strdescrip_01
        End Get
        Set(ByVal value As String)
            strdescrip_01 = value
        End Set
    End Property
    Public Property descrip_02() As String
        Get
            Return strdescrip_02
        End Get
        Set(ByVal value As String)
            strdescrip_02 = value
        End Set
    End Property
    Public Property district_id() As String
        Get
            Return strdistrict_id
        End Get
        Set(ByVal value As String)
            strdistrict_id = value
        End Set
    End Property
    Public Property fax() As String
        Get
            Return strfax
        End Get
        Set(ByVal value As String)
            strfax = value
        End Set
    End Property
    Public Property floor() As String
        Get
            Return strfloor
        End Get
        Set(ByVal value As String)
            strfloor = value
        End Set
    End Property
    Public Property id() As String
        Get
            Return strid
        End Get
        Set(ByVal value As String)
            strid = value
        End Set
    End Property
    Public Property job_descrip_01() As String
        Get
            Return strjob_descrip_01
        End Get
        Set(ByVal value As String)
            strjob_descrip_01 = value
        End Set
    End Property
    Public Property job_descrip_02() As String
        Get
            Return strjob_descrip_02
        End Get
        Set(ByVal value As String)
            strjob_descrip_02 = value
        End Set
    End Property
    Public Property last_action() As String
        Get
            Return strlast_action
        End Get
        Set(ByVal value As String)
            strlast_action = value
        End Set
    End Property
    Public Property last_udt() As String
        Get
            Return strlast_udt
        End Get
        Set(ByVal value As String)
            strlast_udt = value
        End Set
    End Property
    Public Property lock_data() As String
        Get
            Return strlock_data
        End Get
        Set(ByVal value As String)
            strlock_data = value
        End Set
    End Property
    Public Property lock_detail() As String
        Get
            Return strlock_detail
        End Get
        Set(ByVal value As String)
            strlock_detail = value
        End Set
    End Property
    Public Property moo() As String
        Get
            Return strmoo
        End Get
        Set(ByVal value As String)
            strmoo = value
        End Set
    End Property
    Public Property name_01() As String
        Get
            Return strname_01
        End Get
        Set(ByVal value As String)
            strname_01 = value
        End Set
    End Property
    Public Property name_02() As String
        Get
            Return strname_02
        End Get
        Set(ByVal value As String)
            strname_02 = value
        End Set
    End Property
    Public Property oth_code() As String
        Get
            Return stroth_code
        End Get
        Set(ByVal value As String)
            stroth_code = value
        End Set
    End Property
    Public Property oth_id() As String
        Get
            Return stroth_id
        End Get
        Set(ByVal value As String)
            stroth_id = value
        End Set
    End Property
    Public Property owner_id() As String
        Get
            Return strowner_id
        End Get
        Set(ByVal value As String)
            strowner_id = value
        End Set
    End Property
    Public Property parent_id() As String
        Get
            Return strparent_id
        End Get
        Set(ByVal value As String)
            strparent_id = value
        End Set
    End Property
    Public Property position_count() As String
        Get
            Return strposition_count
        End Get
        Set(ByVal value As String)
            strposition_count = value
        End Set
    End Property
    Public Property postal() As String
        Get
            Return strpostal
        End Get
        Set(ByVal value As String)
            strpostal = value
        End Set
    End Property
    Public Property province_id() As String
        Get
            Return strprovince_id
        End Get
        Set(ByVal value As String)
            strprovince_id = value
        End Set
    End Property
    Public Property res_val_01() As String
        Get
            Return strres_val_01
        End Get
        Set(ByVal value As String)
            strres_val_01 = value
        End Set
    End Property
    Public Property res_val_02() As String
        Get
            Return strres_val_02
        End Get
        Set(ByVal value As String)
            strres_val_02 = value
        End Set
    End Property
    Public Property res_val_03() As String
        Get
            Return strres_val_03
        End Get
        Set(ByVal value As String)
            strres_val_03 = value
        End Set
    End Property
    Public Property res_val_04() As String
        Get
            Return strres_val_04
        End Get
        Set(ByVal value As String)
            strres_val_04 = value
        End Set
    End Property
    Public Property res_val_05() As String
        Get
            Return strres_val_05
        End Get
        Set(ByVal value As String)
            strres_val_05 = value
        End Set
    End Property
    Public Property road() As String
        Get
            Return strroad
        End Get
        Set(ByVal value As String)
            strroad = value
        End Set
    End Property
    Public Property roomno() As String
        Get
            Return strroomno
        End Get
        Set(ByVal value As String)
            strroomno = value
        End Set
    End Property
    Public Property root_id() As String
        Get
            Return strroot_id
        End Get
        Set(ByVal value As String)
            strroot_id = value
        End Set
    End Property
    Public Property session_id() As String
        Get
            Return strsession_id
        End Get
        Set(ByVal value As String)
            strsession_id = value
        End Set
    End Property
    Public Property social_no() As String
        Get
            Return strsocial_no
        End Get
        Set(ByVal value As String)
            strsocial_no = value
        End Set
    End Property
    Public Property soi() As String
        Get
            Return strsoi
        End Get
        Set(ByVal value As String)
            strsoi = value
        End Set
    End Property
    Public Property st_code() As String
        Get
            Return strst_code
        End Get
        Set(ByVal value As String)
            strst_code = value
        End Set
    End Property
    Public Property st_color() As String
        Get
            Return strst_color
        End Get
        Set(ByVal value As String)
            strst_color = value
        End Set
    End Property
    Public Property st_level() As String
        Get
            Return strst_level
        End Get
        Set(ByVal value As String)
            strst_level = value
        End Set
    End Property
    Public Property st_link() As String
        Get
            Return strst_link
        End Get
        Set(ByVal value As String)
            strst_link = value
        End Set
    End Property
    Public Property st_order() As String
        Get
            Return strst_order
        End Get
        Set(ByVal value As String)
            strst_order = value
        End Set
    End Property
    Public Property st_type() As String
        Get
            Return strst_type
        End Get
        Set(ByVal value As String)
            strst_type = value
        End Set
    End Property
    Public Property status() As String
        Get
            Return strstatus
        End Get
        Set(ByVal value As String)
            strstatus = value
        End Set
    End Property
    Public Property tax_no() As String
        Get
            Return strtax_no
        End Get
        Set(ByVal value As String)
            strtax_no = value
        End Set
    End Property
    Public Property tel() As String
        Get
            Return strtel
        End Get
        Set(ByVal value As String)
            strtel = value
        End Set
    End Property
    Public Property udt_app() As String
        Get
            Return strudt_app
        End Get
        Set(ByVal value As String)
            strudt_app = value
        End Set
    End Property
    Public Property udt_code() As String
        Get
            Return strudt_code
        End Get
        Set(ByVal value As String)
            strudt_code = value
        End Set
    End Property
    Public Property user_id() As String
        Get
            Return struser_id
        End Get
        Set(ByVal value As String)
            struser_id = value
        End Set
    End Property
    Public Property vat_no() As String
        Get
            Return strvat_no
        End Get
        Set(ByVal value As String)
            strvat_no = value
        End Set
    End Property


    Public Property Em_Code() As String
        Get
            Return strEm_code
        End Get
        Set(ByVal value As String)
            strEm_code = value
        End Set
    End Property

    Public Property Child_id() As String
        Get
            Return strChild_id
        End Get
        Set(ByVal value As String)
            strChild_id = value
        End Set
    End Property
    Public Function RetreiveBranch()
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim str_sttype As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB
        If st_type.Length > 0 Then
            str_sttype = strcommand & vbCrLf & "and st_type='" & st_type.ToString() & "'"
        End If


        strcommand = "select st_link as id,name_01,name_02  "
        strcommand = strcommand & vbCrLf & "from station  "
        strcommand = strcommand & vbCrLf & "where status='1' "
        strcommand = strcommand & vbCrLf & "and isnull(parent_id,'') =''"
        strcommand = strcommand & vbCrLf & "and corp='" & GBCorp.ToString() & "'" & str_sttype & "Order by st_link"

        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function

    Public Function RetreiveBranch_report()
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB
        If st_type.Length > 0 Then
            strwc = strwc & vbCrLf & "and st_type='" & st_type.ToString() & "'"
        End If


        strcommand = "select st_link as id,name_01,name_02  "
        strcommand = strcommand & vbCrLf & "from station  "
        strcommand = strcommand & vbCrLf & "where status='1' "
        strcommand = strcommand & vbCrLf & "and corp='" & GBCorp.ToString() & "'" & strwc

        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function
    Public Function RetreiveBranchType()
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB
        strcommand = "select id,name_01,name_02   "
        strcommand = strcommand & vbCrLf & "from station_type  "
        strcommand = strcommand & vbCrLf & "where status='1' "
        strcommand = strcommand & vbCrLf & "and short_code ='B'"
        strcommand = strcommand & vbCrLf & "and corp='" & GBCorp.ToString() & "'"

        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function

    Public Function RetreiveParent()
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB
        strcommand = "select id,name_01,name_02  "
        strcommand = strcommand & vbCrLf & "from station  "
        strcommand = strcommand & vbCrLf & "where status='1' "
        strcommand = strcommand & vbCrLf & "and parent_id ='" & id.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and corp='" & GBCorp.ToString() & "'"

        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function

    Public Function Retreiveid()
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB
        strcommand = "select id,name_01,name_02  "
        strcommand = strcommand & vbCrLf & "from station  "
        strcommand = strcommand & vbCrLf & "where status='1' "
        strcommand = strcommand & vbCrLf & "and id ='" & id.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and corp='" & GBCorp.ToString() & "'"

        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function
    Function Retrive_StationType() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim SqlDB As New Cls_SqlDB
        Dim strwc As String = ""

        strcommand = "select distinct station_type.id,station_type.name_01,station_type.name_02,station_type.st_level"
        strcommand = strcommand & vbCrLf & "from station_type inner join station"
        strcommand = strcommand & vbCrLf & "on station_type.id=station.st_type"
        strcommand = strcommand & vbCrLf & "where station_type.status='1'"
        strcommand = strcommand & vbCrLf & "and station_type.corp='" & GBCorp.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and isnull(short_code,'')not in ('B','H') "
        strcommand = strcommand & vbCrLf & "and st_link like '" & st_link & "%'"
        strcommand = strcommand & vbCrLf & "order by station_type.st_level "
        'strcommand = strcommand & vbCrLf & "order by station_type.name_01 asc"



        dt = SqlDB.GetDataTable(strcommand)
        Return dt

    End Function


    Function Retrive_Station() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim SqlDB As New Cls_SqlDB
        Dim strwc As String = ""

        strcommand = "select st_link,name_01,name_02,id"
        strcommand = strcommand & vbCrLf & "from station"
        strcommand = strcommand & vbCrLf & "where corp='" & GBCorp.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and status='1'"
        strcommand = strcommand & vbCrLf & "and st_type = '" & st_type.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and st_link like '" & st_link & "%' Order by name_01,name_02"
        dt = SqlDB.GetDataTable(strcommand)
        Return dt

    End Function
    Function Retrieve_EmpCode() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB

        If st_link.Length > 0 Then
            strwc = vbCrLf & " and station_id in (select id from station where corp='" & GBCorp & "' and st_link like '" & st_link & "%' and status='1')"
        End If

        strcommand = "select distinct position_level,em_code "
        strcommand = strcommand & vbCrLf & "from position left join per_position"
        strcommand = strcommand & vbCrLf & "on per_position.position_id=position.id"
        strcommand = strcommand & vbCrLf & "and per_position.corp=position.corp"
        strcommand = strcommand & vbCrLf & "inner join person_data"
        strcommand = strcommand & vbCrLf & "on person_data.id=per_position.person_id"
        strcommand = strcommand & vbCrLf & "and person_data.corp=position.corp"
        strcommand = strcommand & vbCrLf & "inner join position_level"
        strcommand = strcommand & vbCrLf & "on position.position_level=position_level.id"
        strcommand = strcommand & vbCrLf & "and position_level.corp=position.corp"
        strcommand = strcommand & vbCrLf & "where position.corp='" & GBCorp.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and position.status='1'"
        strcommand = strcommand & vbCrLf & "and per_position.status='1'"
        strcommand = strcommand & vbCrLf & "and position_type='1'"
        strcommand = strcommand & vbCrLf & "and position_level.status='1'" & strwc




        dt = SqlDB.GetDataTable(strcommand)
        Return dt

    End Function
    Function Retrieve_Empname() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB

        If st_link.Length > 0 Then
            strwc = vbCrLf & " and station_id in (select id from station where corp='" & GBCorp & "' and st_link like '" & st_link & "%' and status='1')"
        End If

        strcommand = "select distinct position_level,person_data.prefix_01+' ' + person_data.name_01  +' '+ person_data.sname_01 as empname "
        strcommand = strcommand & vbCrLf & ",person_data.prefix_02+' ' + person_data.name_02  +' '+ person_data.sname_02 as empnameEN "
        strcommand = strcommand & vbCrLf & "from position left join per_position"
        strcommand = strcommand & vbCrLf & "on per_position.position_id=position.id"
        strcommand = strcommand & vbCrLf & "and per_position.corp=position.corp"
        strcommand = strcommand & vbCrLf & "inner join person_data"
        strcommand = strcommand & vbCrLf & "on person_data.id=per_position.person_id"
        strcommand = strcommand & vbCrLf & "and person_data.corp=position.corp"
        strcommand = strcommand & vbCrLf & "inner join position_level"
        strcommand = strcommand & vbCrLf & "on position.position_level=position_level.id"
        strcommand = strcommand & vbCrLf & "and position_level.corp=position.corp"
        strcommand = strcommand & vbCrLf & "where position.corp='" & GBCorp.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and position.status='1'"
        strcommand = strcommand & vbCrLf & "and per_position.status='1'"
        strcommand = strcommand & vbCrLf & "and position_type='1'"
        strcommand = strcommand & vbCrLf & "and position_level.status='1'" & strwc
        If Em_Code.Length > 0 Then
            strcommand = strcommand & vbCrLf & "and em_code='" & Em_Code.ToString() & "'"
        End If

        dt = SqlDB.GetDataTable(strcommand)
        Return dt

    End Function
    Function Retrieve_EmpCode_Higth_empworkage(ByVal strDummy_1 As String) As DataTable

        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB

        If st_link.Length > 0 Then
            strwc = vbCrLf & " and station_id in (select id from station where corp='" & GBCorp & "' and st_link like '" & st_link & "%' and status='1')"
        End If


        strcommand = "select distinct person_data.id ,em_code,em_code as emp_code "
        strcommand = strcommand & vbCrLf & "from person_data"
        strcommand = strcommand & vbCrLf & "left join per_position"
        strcommand = strcommand & vbCrLf & "on person_data.id=per_position.person_id"
        strcommand = strcommand & vbCrLf & "and person_data.corp=per_position.corp"
        strcommand = strcommand & vbCrLf & "left join position"
        strcommand = strcommand & vbCrLf & "on per_position.position_id=position.id"
        strcommand = strcommand & vbCrLf & "and person_data.corp=position.corp"
        strcommand = strcommand & vbCrLf & "left join position_level on position.position_level = position_level.id "
        strcommand = strcommand & vbCrLf & "where position.corp='" & GBCorp.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and person_data.status='1'"
        strcommand = strcommand & vbCrLf & "and position.status='1'"
        strcommand = strcommand & vbCrLf & "and per_position.status='1'"
        strcommand = strcommand & vbCrLf & "and position_type='1'" & strwc & strDummy_1
        strcommand = strcommand & vbCrLf & " and per_position.position_status='1'"

        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function
    Function Retrieve_Empname_empworkage(ByVal strDummy_1 As String) As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB

        If st_link.Length > 0 Then
            strwc = vbCrLf & " and station_id in (select id from station where corp='" & GBCorp & "' and st_link like '" & st_link & "%' and status='1')"
        End If

        strcommand = "select distinct person_data.id,person_data.prefix_01+' ' + person_data.name_01  +' '+ person_data.sname_01 as empname "
        strcommand = strcommand & vbCrLf & ",person_data.prefix_02+' ' + person_data.name_02  +' '+ person_data.sname_02 as empname_02"
        strcommand = strcommand & vbCrLf & "from person_data"
        strcommand = strcommand & vbCrLf & "left join per_position"
        strcommand = strcommand & vbCrLf & "on person_data.id=per_position.person_id"
        strcommand = strcommand & vbCrLf & "and person_data.corp=per_position.corp"
        strcommand = strcommand & vbCrLf & "left join position"
        strcommand = strcommand & vbCrLf & "on per_position.position_id=position.id"
        strcommand = strcommand & vbCrLf & "and person_data.corp=position.corp"
        strcommand = strcommand & vbCrLf & "left join position_level on position.position_level = position_level.id "
        strcommand = strcommand & vbCrLf & "where position.corp='" & GBCorp.ToString() & "'"
        strcommand = strcommand & vbCrLf & "and person_data.status='1'"
        strcommand = strcommand & vbCrLf & "and position.status='1'"
        strcommand = strcommand & vbCrLf & "and per_position.status='1'"
        strcommand = strcommand & vbCrLf & "and position_type='1'" & strwc & strDummy_1
        strcommand = strcommand & vbCrLf & " and per_position.position_status='1'"


        If id.Length > 0 Then
            strcommand = strcommand & vbCrLf & "and person_data.id='" & id.ToString() & "'"
        End If

        dt = SqlDB.GetDataTable(strcommand)
        Return dt

    End Function
    Function Retrieve_Parent() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB


        strcommand = "select branch.id parent_id,branch.name_01 parent_name"
        strcommand = strcommand & vbCrLf & ",station.id as child_id,station.name_01 child_name"
        strcommand = strcommand & vbCrLf & "from station  inner join station as branch"
        strcommand = strcommand & vbCrLf & "on station.parent_id=branch.id"
        strcommand = strcommand & vbCrLf & "and station.corp=branch.corp"
        strcommand = strcommand & vbCrLf & "and station.status='1'"
        strcommand = strcommand & vbCrLf & "and branch.status='1'"
        strcommand = strcommand & vbCrLf & "and branch.corp='" & GBCorp.ToString() & "'"

        dt = SqlDB.GetDataTable(strcommand)
        Return dt

    End Function

    Function Retrieve_Stationid() As String
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB
        Dim strStation_id As String = String.Empty

        If GBParent_id.Length > 0 Then
            strwc = " and branch.id='" & parent_id.ToString & "'"
        End If

        If GBChild_id.Length > 0 Then
            strwc = " and station.id='" & Child_id.ToString & "'"
        End If





        strcommand = strcommand & vbCrLf & "select station.id as child_id"
        strcommand = strcommand & vbCrLf & "from station  inner join station as branch"
        strcommand = strcommand & vbCrLf & "on station.parent_id=branch.id"
        strcommand = strcommand & vbCrLf & "and station.corp=branch.corp"
        strcommand = strcommand & vbCrLf & "and station.status='1'"
        strcommand = strcommand & vbCrLf & "and branch.status='1'" & strwc
        strcommand = strcommand & vbCrLf & "and branch.corp='" & GBCorp.ToString() & "'"


        dt = SqlDB.GetDataTable(strcommand)
        If Not dt Is Nothing Then
            If dt.Rows.Count = 1 Then
                strStation_id = dt.Rows(0).Item("child_id").ToString()
            Else
                strStation_id = ""
            End If
        Else
            strStation_id = ""
        End If

        Return strStation_id

    End Function


    Function Retrieve_st_link() As String
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB

        Dim strstlink As String = String.Empty

        If st_type.Length > 0 Then
            strwc = strwc & vbCrLf & "and st_type = '" & st_type.ToString() & "'"
        End If
        'If id.Length > 0 Then
        '    strwc = strwc & vbCrLf & "and id ='" & id.ToString() & "'"
        'End If
        If st_link.Length > 0 Then
            strwc = strwc & vbCrLf & "and  st_link like '" & st_link & "%' "
        End If
        strcommand = "select st_link from station "
        strcommand = strcommand & vbCrLf & "where station.status='1' "
        strcommand = strcommand & vbCrLf & "and corp='" & GBCorp.ToString() & "'" & strwc
        dt = SqlDB.GetDataTable(strcommand)
        If dt.Rows.Count > 0 Then
            strstlink = dt.Rows(0)(0).ToString()
        Else
            strstlink = st_link.ToString
        End If
        Return strstlink

    End Function

    Function Retrieve_branch() As String
        Dim strbranch As String
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim strwc As String = ""
        Dim SqlDB As New Cls_SqlDB
        strcommand = "select name_01 from station "
        strcommand = strcommand & vbCrLf & "where station.status='1' "
        strcommand = strcommand & vbCrLf & "and corp='" & GBCorp.ToString() & "' and st_link='" & st_link & "'"
        dt = SqlDB.GetDataTable(strcommand)
        If dt.Rows.Count > 0 Then
            strbranch = dt.Rows(0)(0).ToString()
        Else
            strbranch = st_link.ToString
        End If
        Return strbranch

    End Function
    Function Retrieve_companynm() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim SqlDB As New Cls_SqlDB
        Dim pathfilenm As String = String.Empty

        strcommand = "select * from corp_pic where corp='" & GBCorp.ToString & "'"
        dt = SqlDB.GetDataTable(strcommand)
        If dt.Rows.Count > 0 Then
            pathfilenm = AppDomain.CurrentDomain.BaseDirectory.Replace("'", "''") & dt.Rows(0).Item("corp_logo").ToString
        Else
            pathfilenm = AppDomain.CurrentDomain.BaseDirectory.Replace("'", "''") & "image\nologo.png"
        End If

        strcommand = "select corpnm,addno+soi_01+road_01+subdestrict_01+destrict_01+province+country+postal as corpaddress"
        strcommand = strcommand & vbCrLf & ",tel+fax as corptel,'" & pathfilenm & "' as logo"
        strcommand = strcommand & vbCrLf & "from"
        strcommand = strcommand & vbCrLf & "(select id,case when corp_type='1' then  name_01 else '' end as corpnm"
        strcommand = strcommand & vbCrLf & ",case when  addno IS not null and addno<>'' then 'เลขที่ ' + addno else '' end as addno"
        strcommand = strcommand & vbCrLf & ",case when  soi_01 IS not null and soi_01<>'' then ' ซอย' + soi_01 else '' end as soi_01  "
        strcommand = strcommand & vbCrLf & ",case when  road_01 IS not null and road_01<>'' then ' ถนน' + road_01 else '' end as road_01  "
        strcommand = strcommand & vbCrLf & ",case when  subdestrict_01 IS not null and subdestrict_01<>'' then ' แขวง' + "
        strcommand = strcommand & vbCrLf & "(select district_name from district inner join amphur on district.amphur_id=amphur.amphur_id where district_id=subdestrict_01 and  district.amphur_id=destrict_01)"
        strcommand = strcommand & vbCrLf & "else '' end as subdestrict_01  "
        strcommand = strcommand & vbCrLf & ",case when  destrict_01 IS not null and destrict_01<>'' then ' เขต' + "
        strcommand = strcommand & vbCrLf & "(select amphur_name from amphur where amphur_id=destrict_01)"
        strcommand = strcommand & vbCrLf & "else '' end as destrict_01  "
        strcommand = strcommand & vbCrLf & ",case when  province IS not null and province<>'' then ' จังหวัด' + (select rtrim(province_name) from province where province_id = corp.province ) else '' end as province"
        strcommand = strcommand & vbCrLf & ",case when  country IS not null and country<>'' then ' ประเทศ' + (select rtrim(name_01) from country where country_id = corp.country )else '' end as country"
        strcommand = strcommand & vbCrLf & ",case when  postal IS not null and postal<>'' then ' รหัสไปรษณีย์ ' + postal else '' end as postal"
        strcommand = strcommand & vbCrLf & ",case when  tel IS not null and tel<>'' then 'โทรศัพท์ : ' + tel else '' end as tel"
        strcommand = strcommand & vbCrLf & ",case when  fax IS not null and fax<>'' then ' โทรสาร : ' + fax else '' end as fax"
        strcommand = strcommand & vbCrLf & "from corp  "
        strcommand = strcommand & vbCrLf & "where id='" & GBCorp & "') as corp "
        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function
    Function Retrieve_companynmENG() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim SqlDB As New Cls_SqlDB
        Dim pathfilenm As String = String.Empty

        strcommand = "select * from corp_pic where corp='" & GBCorp.ToString & "'"
        dt = SqlDB.GetDataTable(strcommand)
        If dt.Rows.Count > 0 Then
            pathfilenm = AppDomain.CurrentDomain.BaseDirectory.Replace("'", "''") & dt.Rows(0).Item("corp_logo").ToString
        Else
            pathfilenm = AppDomain.CurrentDomain.BaseDirectory.Replace("'", "''") & "image\nologo.png"
        End If

        strcommand = "select corpnm,addno+soi_01+road_01+subdestrict_01+destrict_01+province+country+postal as corpaddress"
        strcommand = strcommand & vbCrLf & ",tel+fax as corptel,'" & pathfilenm & "' as logo"
        strcommand = strcommand & vbCrLf & "from"
        strcommand = strcommand & vbCrLf & "(select id,case when corp_type='1' then name_02 else '' end as corpnm"
        strcommand = strcommand & vbCrLf & ",case when  addno IS not null and addno<>'' then 'Address No. ' + addno else '' end as addno"
        strcommand = strcommand & vbCrLf & ",case when  soi_02 IS not null and soi_02<>'' then ', Soi.' + soi_02 else '' end as soi_01  "
        strcommand = strcommand & vbCrLf & ",case when  road_02 IS not null and road_02<>'' then  road_02+' Road., ' else '' end as road_01 "
        strcommand = strcommand & vbCrLf & ",case when  subdestrict_02 IS not null and subdestrict_01<>'' then "
        strcommand = strcommand & vbCrLf & "(select district_name_02 from district inner join amphur on district.amphur_id=amphur.amphur_id where district_id=subdestrict_01 and  district.amphur_id=destrict_01) + ', '"
        strcommand = strcommand & vbCrLf & "else '' end as subdestrict_01  "
        strcommand = strcommand & vbCrLf & ",case when  destrict_01 IS not null and destrict_01<>'' then "
        strcommand = strcommand & vbCrLf & "(select amphur_name_02 from amphur where amphur_id=destrict_01) +', '"
        strcommand = strcommand & vbCrLf & "else '' end as destrict_01  "
        strcommand = strcommand & vbCrLf & ",case when  province IS not null and province<>'' then  (select rtrim(province_name_02) from province where province_id = corp.province ) +', ' else '' end as province"
        strcommand = strcommand & vbCrLf & ",case when  country IS not null and country<>'' then(select rtrim(name_02) from country where country_id = corp.country ) +', ' else '' end as country"
        strcommand = strcommand & vbCrLf & ",case when  postal IS not null and postal<>'' then  postal else '' end as postal"
        strcommand = strcommand & vbCrLf & ",case when  tel IS not null and tel<>'' then ' Tel. : ' + tel else '' end as tel"
        strcommand = strcommand & vbCrLf & ",case when  fax IS not null and fax<>'' then ' Fax. : ' + fax else '' end as fax"
        strcommand = strcommand & vbCrLf & "from corp  "
        strcommand = strcommand & vbCrLf & "where id='" & GBCorp & "') as corp "
        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function
    Function Retreive_Stlinknm() As DataTable
        Dim dt As New DataTable
        Dim strcommand As String = ""
        Dim SqlDB As New Cls_SqlDB
        strcommand = "select * from station where st_link='" & st_link.Trim & "'"
        dt = SqlDB.GetDataTable(strcommand)
        Return dt
    End Function
End Class
