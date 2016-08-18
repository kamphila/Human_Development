Public Class ClsSelect
    Inherits SQLServerconnection
    Public Function GetDateNowDB() As DataSet
        Dim strsql As String
        strsql = "SELECT CONVERT (varchar,GETDATE(),103) AS DateNowDB, " & _
                 "Convert (varchar, Getdate(),20) as dateTimeNowDB"
        Return SQL_Dataset(strSQL)
    End Function
    Public Function dsLeaveType() As DataSet
        Dim strSQL As String
        strSQL = "SELECT id,code,name_01 from leave_type"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsBranch(ByVal strcorp_id As String, ByVal strshort_code As String) As DataSet
        Dim strSQL As String
        strSQL = "select id,name_01,name_02,isnull(short_code,'') as short_code from station_type " & _
                 " where corp = '" & strcorp_id & "' and status = '1' and (isnull(short_code,'') <> 'B' and isnull(short_code,'') <> 'H') order by type_code "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsBranch_search(ByVal strcorp_id As String, ByVal strshort_code As String, ByVal strlang_index As String) As DataSet
        Dim strSQL As String
        If strlang_index = 1 Then
            strSQL = "select id,name_01,name_02,short_code from station_type " & _
                     " where corp = '" & strcorp_id & "' and status = '1' and short_code NOT IN ('B','H') order by st_level "
        Else
            strSQL = "select id,name_01,name_02,short_code from station_type " & _
                    " where corp = '" & strcorp_id & "' and status = '1' and short_code NOT IN ('B','H') order by st_level "
        End If
        Return SQL_DataSet(strSQL)
    End Function
    Public Function ds_GetBranch(ByVal strcorp_id As String, ByVal str_link As String) As DataSet
        Dim strSQL As String
        strSQL = "Select T1.id as branch_id,T1.name_01 as branch_name_01,T1.name_02 as branch_name_02, " & vbCrLf &
                 "T1.status,T1.st_link as branch_st_link FROM station T1 " & vbCrLf &
                 "WHERE T1.st_link Like '" & str_link & "' and T1.corp='" & strcorp_id & "' " & vbCrLf &
                 "and T1.status=1 order by T1.st_link "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsIncList(ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select * from S_Pay_info_List " & _
                 " where type_list = '1' and corp = '" & strcorp_id & "' and status = '1' Order by name_01,name_02 "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsIncList_branch(ByVal strcorp_id As String, ByVal strbranch_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select * from S_Pay_info_List " & _
                 " where type_list = '1' and corp = '" & strcorp_id & "' and status = '1'" & strbranch_id & "Order by name_01,name_02 "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsIncList_Select(ByVal str_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select * from S_Pay_info_List " & _
                 " where id = '" & str_id & "' Order by name_01,name_02 "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsList_PayInfo_Branch(Optional ByVal strcorp = "", Optional ByVal str_branch = "") As DataSet
        Dim strSQL As String = "select id,name_01,name_02 from S_Pay_info_List " & _
                               "WHERE corp = '" & strcorp & "' and type_list = '1' and status = '1' " & str_branch & " Order by name_01,name_02"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsDedList_PayInfo_Branch(Optional ByVal strcorp = "", Optional ByVal str_branch = "") As DataSet
        Dim strSQL As String = "select id,name_01,name_02 from S_Pay_info_List " & _
                               "WHERE corp = '" & strcorp & "' and type_list = '-1' and status = '1' " & str_branch & " Order by name_01,name_02"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsDedList(ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select * from S_Pay_info_List " & _
                 " where type_list = '-1' and corp = '" & strcorp_id & "' order by name_01,name_02 "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsDedList_branch(ByVal strcorp_id As String, ByVal strbranch_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select * from S_Pay_info_List " & _
                 " where type_list = '-1' and corp = '" & strcorp_id & "'" & strbranch_id & " order by name_01,name_02 "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsBranchList(ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select T1.id,T1.name_01,T1.name_02,T1.st_link,T2.id as id_type from station T1  " & _
                 "Left Join station_type T2 on T1.st_type = T2.id  " & _
                 " where T2.short_code in ('B','H') and T1.status = '1' and T1.corp = '" & strcorp_id & "' order by T1.st_link "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsBranch_SSo(ByVal strcorp_id As String, ByVal str_branch As String) As DataSet
        Dim strSQL As String
        strSQL = "select T1.id,T1.name_01 as branch_name_01,T1.name_02 as branch_name_02, " & vbCrLf &
                 "T1.st_link as branch_st_link,T2.id as id_type from station T1  " & vbCrLf &
                 "Left Join station_type T2 on T1.st_type = T2.id  " & vbCrLf &
                 "where T2.short_code in ('B','H') and T1.status = '1' " & vbCrLf &
                 "and T1.corp = '" & strcorp_id & "' " & str_branch & " order by T1.st_link "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsBranch_List(ByVal strcorp_id As String, ByVal strshort_code As String) As DataSet
        Dim strSQL As String
        strSQL = "select id,name_01,short_code from station_type " & _
                 " where corp = '" & strcorp_id & "' and status = '1' and id NOT IN ('" & strshort_code & "') "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsPositionLevel(ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select top 1 id,name_01 from position_level  " & _
                 " where corp = '" & strcorp_id & "'"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsType_station(ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select * from station_type " & _
                 " where  corp = '" & strcorp_id & "' "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function ds_stLink(ByVal str_code As String, ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select st_link from station " & _
                 " where id = '" & str_code & "' and corp = '" & strcorp_id & "' and status = '1'"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function ds_station(ByVal strshort_code As String, ByVal strcorp_id As String) As DataSet
        'Dim strSQL As String
        'strSQL = "select T1.id,T1.name_01 from station T1 " & _
        '         " Left Join station_type T2 on T1.st_type = T2.id   " & _
        '         " where T2.id = '" & strshort_code & "' and T1.corp = '" & strcorp_id & "' and T1.status = '1'"
        'Return SQL_DataSet(strSQL)
        Dim strSQL As String
        strSQL = "select T1.id,T1.name_01,T1.name_02 from station T1 " & _
                 " Left Join station_type T2 on T1.st_type = T2.id   " & _
                 " where T2.id = '" & strshort_code & "' and T1.corp = '" & strcorp_id & "' and T1.status = '1' Order by T1.name_01,T1.name_02"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function ds_station_Edit(ByVal strshort_code As String, ByVal strcorp_id As String, ByVal strlink As String) As DataSet
        Dim strSQL As String
        strSQL = "select T1.id,T1.name_01,T1.st_link,T1.name_02 from station T1 " & _
                 " Left Join station_type T2 on T1.st_type = T2.id   " & _
                 " where T2.id = '" & strshort_code & "' and T1.corp = '" & strcorp_id & "' and T1.status = '1'" & _
                 " and left(T1.st_link,3) Like '%" & strlink & "' Order by T1.name_01,T1.name_02 "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function ds_station_1(ByVal strshort_code As String, ByVal strcorp_id As String, ByVal strparent_id As String) As DataSet
        'Dim strSQL As String
        'strSQL = "select T1.id,T1.name_01 from station T1 " & _
        '         " Left Join station_type T2 on T1.st_type = T2.id   " & _
        '         " where T2.id = '" & strshort_code & "' and T1.corp = '" & strcorp_id & "' and T1.status = '1'"
        'Return SQL_DataSet(strSQL)
        Dim strSQL As String
        strSQL = "select T1.id,T1.name_01,T1.name_02 from station T1 " & _
                 " Left Join station_type T2 on T1.st_type = T2.id   " & _
                 " where T2.id = '" & strshort_code & "' and T1.corp = '" & strcorp_id & "' and T1.status = '1' and T1.parent_id = '" & strparent_id & "'"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsListPayment_PackageCombo(Optional ByVal strcorp = "") As DataSet
        Dim strSQL As String = "select * from payment_package  " & _
                               "WHERE corp = '" & strcorp & "'and status = '1'"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsListPayment_PackageCombo_branch(Optional ByVal strcorp = "", Optional ByVal str_branch = "") As DataSet
        Dim strSQL As String = "select * from payment_package  " & _
                               "WHERE corp = '" & strcorp & "' and status = '1'" & str_branch & " Order by payment_package.name_package_01,payment_package.name_package_02 "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsList_PayInfo(Optional ByVal strcorp = "") As DataSet
        Dim strSQL As String = "select id,name_01,name_02 from S_Pay_info_List " & _
                               "WHERE corp = '" & strcorp & "' and type_list = '1' and status = '1' "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsList_PayInfo_Ded(Optional ByVal strcorp = "") As DataSet
        Dim strSQL As String = "select id,name_01,name_02 from S_Pay_info_List " & _
                               "WHERE corp = '" & strcorp & "' and type_list = '-1' and status = '1' "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function ds_ListPackage(ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "select * from payment_package " & _
                 " where corp = '" & strcorp_id & "' and status = '1'"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function Retrieve_branch(ByVal corp_id As String, ByVal userlogin_id As String) As DataSet
        Dim strcommand As String = String.Empty
        If userlogin_id <> "HROD" Then
            strcommand = "select branch_id ,station.name_01 branch_name,station.name_02 branch_name_2,"
            strcommand = strcommand & vbCrLf & "station.st_link,station_type.id as id_type"
            strcommand = strcommand & vbCrLf & "from sc_permission_corp inner join station"
            strcommand = strcommand & vbCrLf & "on sc_permission_corp.branch_id=station.id"
            strcommand = strcommand & vbCrLf & "and sc_permission_corp.corp_id=station.corp"
            strcommand = strcommand & vbCrLf & "inner join station_type  on station.st_type = station_type.id "
            strcommand = strcommand & vbCrLf & "where sc_permission_corp.corp_id='" & corp_id & "' "
            strcommand = strcommand & vbCrLf & "and userlogin_id='" & userlogin_id & "' "
            strcommand = strcommand & vbCrLf & "and station.status=1"
            strcommand = strcommand & vbCrLf & "and sc_permission_corp.status=1"
        Else
            strcommand = "select station.id as branch_id ,station.name_01 branch_name,station.name_02 branch_name_2,"
            strcommand = strcommand & vbCrLf & "station.st_link,station_type.id as id_type"
            strcommand = strcommand & vbCrLf & "from station inner join station_type"
            strcommand = strcommand & vbCrLf & "on station.st_type=station_type.id"
            strcommand = strcommand & vbCrLf & "and station.corp=station_type.corp"
            strcommand = strcommand & vbCrLf & "where station.corp='" & corp_id & "' "
            strcommand = strcommand & vbCrLf & "and station.status=1"
            strcommand = strcommand & vbCrLf & "and station_type.status=1"
            strcommand = strcommand & vbCrLf & "and short_code='B'"
        End If
        Return SQL_DataSet(strcommand)
    End Function
    Public Function dsget_branchSocial(ByVal strCorp As String, ByVal str_branch_id As String) As DataSet
        Dim strSQL As String = "select id,branch_id from detail_socialsecurity where corp = '" & strCorp & "' and  branch_id = '" & str_branch_id & "'"
        Return SQL_DataSet(strSQL)
    End Function

    Public Function dsListSocialSecurity(ByVal strcorpid As String, ByVal strbranch_id As String) As DataSet
        Dim strSQL As String = " select * from " & vbCrLf &
                               "(select T1.id,T1.name_branch,T2.name_01 as NameBranch,T1.num_branch,T1.position_approve,T1.name_approve, " & vbCrLf &
                               "T1.position_sent,T1.name_sent,T1.social_office,T1.social_code,T1.social_no,T1.branch_id " & vbCrLf &
                               "From detail_socialsecurity T1 " & vbCrLf &
                               "Left Outer Join station T2 on T1.name_branch = T2.id " & vbCrLf &
                               "WHERE T1.corp = '" & strcorpid & "' and T1.branch_id = 'All' and T1.status = '1'" & vbCrLf &
                               "union " & vbCrLf &
                               "select T1.id,T1.name_branch,T2.name_01 as NameBranch,T1.num_branch,T1.position_approve,T1.name_approve, " & vbCrLf &
                               "T1.position_sent,T1.name_sent,T1.social_office,T1.social_code,T1.social_no,T1.branch_id " & vbCrLf &
                               "From detail_socialsecurity T1 " & vbCrLf &
                               "Left Outer Join station T2 on T1.name_branch = T2.id " & vbCrLf &
                               "WHERE T1.corp = '" & strcorpid & "' and T1.branch_id = '" & strbranch_id & "' and T1.status = '1') as detail_sso " & vbCrLf &
                               "WHERE detail_sso.branch_id = '" & strbranch_id & "'"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsEmpList_check_level(ByVal strcorp_id As String, ByVal strlink As String, ByVal strCondition_1 As String) As DataSet
        Dim strSQL As String
        strSQL = "select T1.id,T1.em_code,((isnull(T1.prefix_01,''))+' '+(isnull(T1.name_01,''))+'  '+(isnull(T1.sname_01,'')))as Name_person,T1.name_01,T1.name_02, " & vbCrLf &
                 "((isnull(T1.prefix_02,''))+' '+(isnull(T1.name_02,''))+'  '+(isnull(T1.sname_02,'')))as Name_person2" & vbCrLf &
                 "from person_data T1  " & vbCrLf &
                 "Left outer Join per_position T2 On T1.id = T2.person_id and T2.status = '1' and T2.position_status = '1'and T2.position_type = '1' " & vbCrLf &
                 "Left Outer Join position T3 On T2.position_id = T3.id " & vbCrLf &
                 "left Outer join position_level T4 on T3.position_level = T4.id " & vbCrLf &
                 "Left Outer Join station T5 On T3.station_id = T5.id " & vbCrLf &
                 "where T1.corp = '" & strcorp_id & "' and T1.status = '1' and T1.per_type = '1' " & vbCrLf &
                 "and em_status not in ('R','LF') " & strlink & " " & strCondition_1 & " and T3.status = '1' order by T1.em_code "


        Return SQL_DataSet(strSQL)
    End Function
    'Public Function dsEmpList_check_level_PNG(ByVal strcorp_id As String, ByVal strlink As String, ByVal strCondition_1 As String, ByVal str_year As String) As DataSet
    '    Dim strSQL As String
    '    strSQL = "select T1.id,T1.em_code,((isnull(T1.prefix_01,''))+' '+(isnull(T1.name_01,''))+'  '+(isnull(T1.sname_01,'')))as Name_person, " & vbCrLf &
    '             "((isnull(T1.prefix_02,''))+' '+(isnull(T1.name_02,''))+'  '+(isnull(T1.sname_02,'')))as Name_person2" & vbCrLf &
    '             "from person_data T1  " & vbCrLf &
    '             "Left join ps_per_resign T6 on T1.id = T6.person_id and T6.status = 1 " & vbCrLf &
    '             "Left outer Join per_position T2 On T1.id = T2.person_id and T2.position_type = '1' " & vbCrLf &
    '             "and T2.position_status = CASE " & vbCrLf &
    '             "WHEN (T1.em_status in('R','LF') " & vbCrLf &
    '             "and (Year(T2.end_date) >= " & str_year & ") and Year(T2.end_date) <= Year(T6.resign_date))" & vbCrLf &
    '             "THEN  '2'" & vbCrLf &
    '             "ELSE '1' END and T2.status = '1' " & vbCrLf &
    '             "Left Outer Join position T3 On T2.position_id = T3.id " & vbCrLf &
    '             "left Outer join position_level T4 on T3.position_level = T4.id " & vbCrLf &
    '             "Left Outer Join station T11 On T3.station_id = T11.id " & vbCrLf &
    '             "where T1.corp = '" & strcorp_id & "' and T1.status = '1'  " & vbCrLf &
    '             "and T1.per_type = '1' " & strlink & " " & strCondition_1 & " and T3.status = '1' order by T1.em_code "
    '    Return SQL_DataSet(strSQL)
    'End Function
    Public Function dsEmpList_check_level_PNG(ByVal strcorp_id As String, ByVal strlink As String, ByVal strCondition_1 As String, ByVal str_year As String) As DataSet
        Dim strSQL As String
        strSQL = "select T1.person_id as id,T2.prefix_01,T2.name_01,T2.sname_01," & vbCrLf &
                 "T2.em_code,((isnull(T2.prefix_01,''))+' '+(isnull(T2.name_01,''))+'  '+(isnull(T2.sname_01,'')))as Name_person," & vbCrLf &
                 "((isnull(T2.prefix_02,''))+' '+(isnull(T2.name_02,''))+'  '+(isnull(T2.sname_02,'')))as Name_person2 " & vbCrLf &
                 "from slip T1  left outer join person_data T2 on T1.person_id = T2.id " & vbCrLf &
                 "left outer join per_payment T3 on T1.person_id = T3.person_id  " & vbCrLf &
                 "left outer join corp T4 on T1.corp = T4.id " & vbCrLf &
                 "left outer join per_position T5 on T1.person_id = T5.person_id " & vbCrLf &
                 "and T5.id= " & vbCrLf &
                 "(select top 1 J1.id from per_position J1 " & vbCrLf &
                 "Where J1.person_id=T1.person_id and J1.status=1 and Year(j1.begin_date)<='" & str_year & "' " & vbCrLf &
                 "and (Year(J1.end_date) is null or Year(J1.end_date) >='" & str_year & "') order by begin_date desc)" & vbCrLf &
                 "left outer join position T6 on T5.position_id = T6.id " & vbCrLf &
                 "left outer join station T7 on T6.station_id = T7.id  " & vbCrLf &
                 "Left outer join  per_social T8 on T1.person_id = T8.person_id and T8.status = '1' " & vbCrLf &
                 "Left join station station_a on station_a.st_link = SUBSTRING(T7.st_link,1,3)" & vbCrLf &
                 "where T1.corp = '" & strcorp_id & "' and T3.status = '1' and T1.status = '1' " & vbCrLf &
                 "and T1.slip_year = '" & str_year & "' " & vbCrLf &
                 "and ((T3.per_conditiontax = '1'OR T3.per_conditiontax = '2' ) OR (T3.per_conditiontax = '3' and T8.res_val_01 = '1'))" & vbCrLf &
                 "" & strlink & " " & strCondition_1 & " and T3.status = '1'" & vbCrLf &
                 "group by T1.person_id,T2.em_code,T2.prefix_01,T2.name_01,T2.sname_01,T2.prefix_02,T2.name_02,T2.sname_02 order by T2.em_code"
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsList_Effective_date(ByVal strcorp_id As String) As DataSet
        Dim strSQL As String
        strSQL = "SELECT DISTINCT(convert(datetime, effective_date, 103)) as effective_date,convert(datetime, effective_date, 103) as show_effective_date " & vbCrLf &
                 "from salary_adjust_log where corp = '" & strcorp_id & "' " & vbCrLf &
                 "order by effective_date "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function GetEmployeeByPngr91(ByVal strcorp_id As String, ByVal strlink As String, ByVal strCondition_1 As String, ByVal str_year As String, ByVal taxYear As Integer) As DataSet
        Dim strSQL As String
        strSQL = "SELECT T2.id, T2.em_code," & vbCrLf &
                 "((ISNULL(T2.prefix_01, '')) + ' ' + (ISNULL(T2.name_01, '')) + '  ' + (ISNULL(T2.sname_01, ''))) AS Name" & vbCrLf &
                 "FROM pngr_91 T1" & vbCrLf &
                 "INNER JOIN person_data T2" & vbCrLf &
                 "ON T1.person_id = T2.id" & vbCrLf &
                 "LEFT JOIN ps_per_resign T3" & vbCrLf &
                 "ON T2.id = T3.person_id" & vbCrLf &
                 "AND T3.status = 1" & vbCrLf &
                 "LEFT JOIN per_position T4" & vbCrLf &
                 "ON T2.id = T4.person_id" & vbCrLf &
                 "AND T4.position_type = '1'" & vbCrLf &
                 "AND T4.position_status = CASE WHEN (T2.em_status IN ('R','LF')" & vbCrLf &
                 "AND (Year(T4.end_date) >= " & str_year & ") AND Year(T4.end_date) <= Year(T3.resign_date))" & vbCrLf &
                 "THEN  '2'" & vbCrLf &
                 "ELSE '1' END" & vbCrLf &
                 "AND T4.status = '1'" & vbCrLf &
                 "LEFT JOIN position T5" & vbCrLf &
                 "ON T4.position_id = T5.id" & vbCrLf &
                 "LEFT JOIN position_level T6" & vbCrLf &
                 "ON T5.position_level = T6.id" & vbCrLf &
                 "LEFT JOIN station T7" & vbCrLf &
                 "ON T5.station_id = T7.id" & vbCrLf &
                 "WHERE	T2.corp = '" & strcorp_id & "'AND" & vbCrLf &
                 "T1.tax_year = " & taxYear & " AND" & vbCrLf &
                 "T2.status = '1' AND" & vbCrLf &
                 "T2.per_type = '1' " & strlink & " " & strCondition_1 & " and T5.status = '1' order by T2.em_code "
        Return SQL_DataSet(strSQL)
    End Function
    Public Function dsEmpList_check_auto(ByVal strcorp_id As String, ByVal str_year As String) As DataSet
        Dim strSQL As String
        strSQL = "select T1.id,T1.em_code,((isnull(T1.prefix_01,''))+' '+(isnull(T1.name_01,''))+'  '+(isnull(T1.sname_01,'')))as Name_person,T1.name_01,T1.name_02, " & vbCrLf &
                 "((isnull(T1.prefix_02,''))+' '+(isnull(T1.name_02,''))+'  '+(isnull(T1.sname_02,'')))as Name_person2" & vbCrLf &
                 "from person_data T1  " & vbCrLf &
                 "Left outer Join per_position T2 On T1.id = T2.person_id and T2.status = '1' and T2.position_type = '1' " & vbCrLf &
                 "and T2.id= " & vbCrLf &
                 "(select top 1 J1.id from per_position J1 " & vbCrLf &
                 "Where J1.person_id=T1.id and J1.status=1 and Year(j1.begin_date)<='" & str_year & "' " & vbCrLf &
                 "and (Year(J1.end_date) is null or Year(J1.end_date) >='" & str_year & "') order by begin_date desc)" & vbCrLf &
                 "Left Outer Join position T3 On T2.position_id = T3.id and T3.status = '1' " & vbCrLf &
                 "left Outer join position_level T4 on T3.position_level = T4.id " & vbCrLf &
                 "Left Outer Join station T5 On T3.station_id = T5.id " & vbCrLf &
                 "where T1.corp = '" & strcorp_id & "' and T1.status = '1' and T1.per_type = '1' " & vbCrLf &
                 "order by T1.em_code "


        Return SQL_DataSet(strSQL)
    End Function
    Public Function showbank(ByVal strcorp_id As String, ByVal str_branch As String) As DataSet
        Dim strSQL As String
        strSQL = "Select T1.id as id,T1.code_bank as code_bank,T1.name_01 as name_01,T1.name_02 as name_02, " & vbCrLf &
                 "T1.branch_code as branch_code,T2.id as bank_id, " & vbCrLf &
                 "T2.ben_bank_code as ben_bank_code FROM S_Bank T1 " & vbCrLf &
                 "Left Outer Join bank_list T2 On T1.code_bank = T2.bank_code and T2.status = 1 " & vbCrLf &
                 "Left Outer Join corp T3 On T1.corp=T3.id" & vbCrLf &
                 "and T3.status=1  Where T1.status = 1" & vbCrLf &
                 "and T1.branch_id = '" & str_branch & "' and T1.corp= '" & strcorp_id & "'"

        Return SQL_DataSet(strSQL)
    End Function
End Class
   
