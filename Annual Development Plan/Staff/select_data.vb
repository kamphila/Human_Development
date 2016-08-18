Namespace Database
    Namespace Table
        Public Class select_data
            Inherits SQLServerconnection
            Public Function dsListPer(Optional ByVal strCorp = "", Optional ByVal strStation = "") As DataSet
                Dim strSQL As String = "SELECT T1.id,T1.em_code,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person,T1.work_start," & _
                                       " T3.name_01 as Name_Position,T4.name_01 as Name_Station" & _
                                       " From person_data T1" & _
                                       " Left Outer Join per_position T2 On T1.id = T2.person_id and T2.status = 1 and T2.position_status = 1 " & _
                                       " Left Outer Join position T3 On T2.position_id = T3.id " & _
                                       " Left Outer Join station T4 On T3.station_id = T4.id " & _
                                       " Where T1.per_type = '1' and T1.status = '1' and T1.corp = '" & strCorp & "' and T4.id = '" & strStation & "'" & _
                                       " ORDER BY T1.em_code Asc"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPerAll(Optional ByVal strCorp = "") As DataSet
                Dim strSQL As String = "SELECT id,em_code,((prefix_01)+' '+(name_01)+'  '+(sname_01))as Name_person," & _
                                       " work_start From person_data Where per_type = '1' and status = '1' and corp = '" & strCorp & "'" & _
                                       " ORDER BY em_code Asc"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPerLeave(ByVal strPerson As String, ByVal strCorp As String, ByVal strDateNow As String) As DataSet
                Dim strSQL As String = "SELECT T2.name_01 as Name_Group,T4.startshift,T4.endshift,T3.date_startshift,T3.date_endshift," & _
                                       " T2.mon,T2.tue,T2.wed,T2.thu,T2.fri,T2.sat,T2.sun " & _
                                       " from  per_shift_group T1 left join S_shift_group T2 on T1.group_id = T2.id" & _
                                       " left join work_schedule T3 on T2.id = T3.grp_id left join type_shift T4 on T3.shift_id = T4.id " & _
                                       " Where T1.person_id = '" & strPerson & "' and T1.status = '1' and T1.corp = '" & strCorp & "'" & _
                                       " and " & strDateNow & " between T3.date_startshift and T3.date_endshift "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPersonAll(Optional ByVal strCorp As String = "", Optional ByVal strstation As String = "", Optional ByVal strCondition As String = "") As DataSet
                Dim strSQL As String = "select T1.id,T1.em_code,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person " & _
                                       "from person_data T1 " & _
                                       "Left Outer Join per_position T5 On T1.id = T5.person_id and T5.status = 1 and T5.position_status = 1 " & _
                                       "Left Outer Join position T6 On T5.position_id = T6.id " & _
                                       "Left Outer Join station T7 On T6.station_id = T7.id " & _
                                       "where T1.corp=  '" & strCorp & "' and T1.status='1' and T1.per_type = '1' " & _
                                       "and T7.id = '" & strstation & "' "
                If strCondition <> "" Then
                    strSQL &= strCondition
                End If
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsPer_editsalary(Optional ByVal strCondition = "") As DataSet
                Dim strSQL As String = "SELECT T1.id,T1.em_code,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person, " & _
                                     "T1.work_start,T2.per_payperiod, T2.per_payby, T2.employment_rate, T2.per_conditiontax " & _
                                     "From person_data T1 " & _
                                     "Inner Join per_payment T2 on T1.id = T2.person_id " & _
                                     "Where T1.per_type = '1' "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListGroup_Inc_Dec(Optional ByVal strCondition = "") As DataSet
                Dim strSQL As String = "select id,name_01,name_02,group_type,inc_dec_des from S_Group_Inc_Dec "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsPer_AddInc(Optional ByVal strCondition = "") As DataSet
                Dim strSQL As String = "SELECT id,em_code,((prefix_01)+' '+(name_01)+'  '+(sname_01))as Name_person," & _
                                       " work_start" & _
                                       " From person_data Where per_type = '1' "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListBranch(Optional ByVal strCorp = "") As DataSet
                Dim strSQL As String = "SELECT id,name_01,st_link " & _
                                       "FROM station  WHERE Len (st_link) = 3 and corp = '" & strCorp & "'and status = '1' "
                Return SQL_DataSet(strSQL)
            End Function
            'Public Function dsList_Period(ByVal strcorp_id As String) As DataSet
            '    Dim strSQL As String
            '    strSQL = "select id,period_no,pe_start_date,pe_startmonth,pe_end_date,pe_endmonth,pe_datepay,pe_paymonth " & _
            '             "from S_period where corp = '" & strcorp_id & "' and status = '1'"
            '    Return SQL_DataSet(strSQL)
            'End Function
            Public Function ListPeriod_1(ByVal strcorp_id As String, ByVal strdate As String, ByVal strdate1 As String, ByVal str_period As String) As DataSet
                Dim strSQL As String
                strSQL = "select id,period_no,pe_start_date,pe_pay, " & _
                         "case when pe_startmonth='0' then MONTH('" & strdate & "') when pe_startmonth ='1' then MONTH(dateadd(month,1,'" & strdate & "')) else 0 end AS Startmonth," & _
                         "DATEDIFF(day,'" & strdate & "',convert(varchar(8),dateadd(month,1,'" & strdate1 & "'),120)+'01') as pe_end_date," & _
                         "case when pe_endmonth='0' then MONTH('" & strdate & "') when pe_endmonth='1' then MONTH(dateadd(month,1,'" & strdate & "')) else 0 end AS Endmonth, " & _
                         "pe_datepay,DATEPART(month,DATEADD(Month,pe_paymonth,'" & strdate & "')) AS Paymonth " & _
                         "from S_period where corp = '" & strcorp_id & "' and status = '1' and id = '" & str_period & "' "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function ListEnd_Period(ByVal strcorp_id As String, ByVal strdate As String, ByVal strdate1 As String, ByVal str_period As String) As DataSet
                Dim strSQL As String
                strSQL = "select id,period_no,pe_start_date, " & vbCrLf &
                        "case when pe_pay = '0'then DATEDIFF(day,'" & strdate & "',convert(varchar(8),dateadd(month,1,'" & strdate1 & "'),120)+'01') else pe_pay end AS pe_pay," & vbCrLf &
                         "case when pe_startmonth='0' then MONTH('" & strdate & "') when pe_startmonth ='1' then MONTH(dateadd(month,1,'" & strdate & "')) else 0 end AS Startmonth," & vbCrLf &
                         "case when pe_end_date = '31'then DATEDIFF(day,'" & strdate & "',convert(varchar(8),dateadd(month,1,'" & strdate1 & "'),120)+'01') else pe_end_date end AS pe_end_date," & vbCrLf &
                         "case when pe_endmonth='0' then MONTH('" & strdate & "') when pe_endmonth='1' then MONTH(dateadd(month,1,'" & strdate & "')) else 0 end AS Endmonth, " & vbCrLf &
                         "pe_datepay,case when pe_paymonth='0' then MONTH('" & strdate & "') when pe_paymonth='1' then MONTH(dateadd(month,1,'" & strdate1 & "')) else 0 end AS Paymonth, " & vbCrLf &
                         "case when pe_paymonth='0' then year('" & strdate & "') when pe_paymonth='1' then year(dateadd(month,1,'" & strdate1 & "')) else 0 end AS Payyear " & vbCrLf &
                         "from S_period where corp = '" & strcorp_id & "' and status = '1' and id = '" & str_period & "' "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsList_Period(ByVal strcorp_id As String, ByVal strpackage_id As String) As DataSet
                Dim strSQL As String
                strSQL = "select id,period_no,pe_start_date,pe_startmonth,pe_end_date,pe_endmonth,pe_datepay,pe_paymonth,total_period " & _
                         "from S_period where corp = '" & strcorp_id & "' and status = '1' and pay_package_id = '" & strpackage_id & "'"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListSide(Optional ByVal strid = "") As DataSet
                Dim strSQL As String = "select id,name_01,st_link from station " & _
                                       " where status = '1'and LEN(st_link) = 6 " & _
                                       "and parent_id ='" & strid & "'"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPosition(Optional ByVal strcorp = "") As DataSet
                Dim strSQL As String = "select * from position " & _
                                       "where corp = '" & strcorp & "' and status = '1' "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function Position_level(Optional ByVal strcorp = "", Optional ByVal strlevel_id = "", Optional ByVal strbranch_id = "") As DataSet
                Dim strSQL As String = "select T1.id,T1.name_01,T1.name_02,T3.id,T3.em_code,((T3.prefix_01)+' '+(T3.name_01)+'  '+(T3.sname_01))as Name_person, " & _
                                       "((T3.prefix_02)+' '+(T3.name_02)+'  '+(T3.sname_02))as Name_person2 " & _
                                       "from position T1 Left Outer Join per_position T2 On T1.id = T2.position_id and T2.status = 1 and T2.position_status = 1 " & _
                                       "Left Outer Join person_data T3 on T2.person_id = T3.id " & _
                                       "where T1.corp = '" & strcorp & "' and T1.status = '1' and T1.position_level = '" & strlevel_id & "' order by T3.em_code "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPosition_Branch(Optional ByVal strcorp = "", Optional ByVal strbranch_id = "") As DataSet
                Dim strSQL As String = "select position.id,position.position_code,position.name_01 as position_name01,position.name_02 as position_name02," & vbCrLf &
                                       "station.id as station_id,station.st_link,station.st_code,station.name_01,station.name_02, " & vbCrLf &
                                       "t5.st_link,T5.name_01 as branch_name1,T5.name_02 as branch_name2" & vbCrLf &
                                       "from position Left join station on position.station_id = station.id " & vbCrLf &
                                       "Left join station T5  on LEFT (station.st_link,3) = T5.st_link and station.corp = t5.corp " & vbCrLf &
                                       "left join position_level on position.position_level = position_level.id " & vbCrLf &
                                       "where position.corp= '" & strcorp & "' and position.status = '1' and station.status = '1' " & vbCrLf &
                                       "and left(station.st_link,3) Like '" & strbranch_id & "%' order by position.name_01,position.name_02 "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function Position_level_Branch(Optional ByVal strcorp = "", Optional ByVal strlevel_id = "", Optional ByVal strbranch_id = "") As DataSet
                Dim strSQL As String = "select T1.id,T1.name_01,T1.name_02,T3.id,T3.em_code,((T3.prefix_01)+' '+(T3.name_01)+'  '+(T3.sname_01))as Name_person, " & _
                                       "((T3.prefix_02)+' '+(T3.name_02)+'  '+(T3.sname_02))as Name_person2 " & _
                                       "from position T1 Left Outer Join per_position T2 On T1.id = T2.position_id and T2.status = 1 and T2.position_status = 1 " & _
                                       "Left Outer Join person_data T3 on T2.person_id = T3.id " & _
                                       "where T1.corp = '" & strcorp & "' and T1.status = '1' and T1.position_level = '" & strlevel_id & "' and T1.station_id = '" & strbranch_id & "' order by T3.em_code "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPerson_Branch(Optional ByVal strCorp As String = "", Optional ByVal strstation As String = "", Optional ByVal strCondition As String = "") As DataSet
                Dim strSQL As String = "select T1.id,T1.em_code,((isnull(T1.prefix_01,''))+''+(isnull(T1.name_01,''))+'  '+(isnull(T1.sname_01,'')))as Name_person, " & vbCrLf &
                                       "((isnull(T1.prefix_02,''))+''+(isnull(T1.name_02,''))+'  '+(isnull(T1.sname_02,'')))as Name_person_2, " & vbCrLf &
                                       "T6.name_01 as position_name01,T6.name_02 as position_name02,T7.name_01 as station_name01,T7.name_02 as station_name02 from person_data T1 " & vbCrLf &
                                       "Left Outer Join per_position T5 On T1.id = T5.person_id and T5.status = 1 and T5.position_status = 1 " & vbCrLf &
                                       "Left Outer Join position T6 On T5.position_id = T6.id " & vbCrLf &
                                       "Left Outer Join station T7 On T6.station_id = T7.id " & vbCrLf &
                                       "where T1.corp=  '" & strCorp & "' and T1.status='1' and T1.per_type = '1' " & vbCrLf &
                                       "and T7.st_link Like '" & strstation & "%' order by T1.em_code"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPosition_STD(Optional ByVal strcorp = "") As DataSet
                Dim strSQL As String = "select * from position " & _
                                       "where corp = '" & strcorp & "' and position_list_id = 'STD_POSITION' and status = '1'  Order by position_code "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPosition_level(Optional ByVal strcorp = "") As DataSet
                Dim strSQL As String = "select * from position_level " & _
                                       "where corp = '" & strcorp & "' and status = '1' Order by level_no"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPer_AddOT(Optional ByVal strCorp = "") As DataSet
                Dim strSQL As String = "SELECT id,em_code,((prefix_01)+' '+(name_01)+'  '+(sname_01))as Name_person" & _
                                       " From person_data Where per_type = '1' and status = '1' and corp = '" & strCorp & "'" & _
                                       " ORDER BY em_code Asc"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsList_OT(Optional ByVal strCondition As String = "") As DataSet
                Dim strSQL As String = "SELECT * " & _
                                        "From ot_type " & _
                                        "where corp='" & strCondition & "' and status='1' order by ot_code  "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsList_Person_OT(Optional ByVal strCorp As String = "") As DataSet
                Dim strSQL As String = "SELECT T1.id,T1.em_code,T1.em_type,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person, " & _
                                       " T.slip_period,T.slip_month,T.slip_year " & _
                                        "From person_data T1 Left Outer Join detail_inc_dec T On T1.id = T.person_id  " & _
                                        "where T1.corp='" & strCorp & "' and T1.status='1' and T1.per_type = '1' order by T1.em_code  "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsList_Person_INC(Optional ByVal strCorp As String = "") As DataSet
                Dim strSQL As String = "SELECT T1.id,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person " & _
                                       "From person_data T1  " & _
                                        "where T1.corp='" & strCorp & "' and T1.status='1' and T1.per_type = '1' order by T1.em_code  "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsPerson_INC(ByVal strstation As String, ByVal strCorp As String) As DataSet
                Dim strSQL As String = "SELECT DISTINCT T1.id,T1.em_code,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person, " & _
                                       "T6.name_01 as position From person_data T1 " & _
                                       "Left Outer Join per_position T5 On T1.id = T5.person_id and T5.status = 1 and T5.position_status = 1 " & _
                                       "Left Outer Join position T6 On T5.position_id = T6.id " & _
                                       "Left Outer Join station T7 On T6.station_id = T7.id " & _
                                       "where T7.id = '" & strstation & "' and T1.corp= '" & strCorp & "' and T1.status='1' and T1.per_type = '1' " & _
                                       "order by T1.em_code "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function Person_Select(ByVal strstation As String, ByVal strCorp As String) As DataSet
                Dim strSQL As String = "select DISTINCT T1.id,T1.em_code,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person " & _
                                       "from person_data T1  " & _
                                       "Left Outer Join per_position T5 On T1.id = T5.person_id and T5.status = 1 and T5.position_status = 1 " & _
                                       "Left Outer Join position T6 On T5.position_id = T6.id " & _
                                       "Left Outer Join station T7 On T6.station_id = T7.id " & _
                                       "where T7.id = '" & strstation & "' and T1.corp= '" & strCorp & "' and T1.status='1' and T1.per_type = '1' " & _
                                       "order by T1.id "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function Person_INC(ByVal strstation As String, ByVal strCorp As String, ByVal stryear As String, ByVal strmonth As String, _
                                       ByVal strperiod As String) As DataSet
                Dim strSQL As String = "select DISTINCT T1.id,T1.em_code,((T1.prefix_01)+' '+(T1.name_01)+'  '+(T1.sname_01))as Name_person," & _
                                       "T6.name_01 as name_position " & _
                                       "from person_data T1  " & _
                                       "Left Join detail_inc_dec T2 On T1.id = T2.person_id and T2.status = 1 " & _
                                       "Left Outer Join S_Pay_info_List T3 on T2.inc_id = T3.id and T3.status = 1 " & _
                                       "Left Outer Join per_position T5 On T1.id = T5.person_id and T5.status = 1 and T5.position_status = 1 " & _
                                       "Left Outer Join position T6 On T5.position_id = T6.id " & _
                                       "Left Outer Join station T7 On T6.station_id = T7.id " & _
                                       "where T7.id = '" & strstation & "' and T1.corp= '" & strCorp & "' and T1.status='1' and T1.per_type = '1' " & _
                                       "order by T1.em_code "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPeriod(Optional ByVal strCorp_Id = "") As DataSet
                Dim strSQL As String = "select id,period_code from S_Period where status = '1' and corp = '" & strCorp_Id & "' ORDER BY id Asc "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListINC_DED(ByVal strCorp As String, ByVal strType As String, ByVal str_branch As String) As DataSet
                Dim strSQL As String = "select id as inc_id,name_01,name_02 from S_Pay_info_List " & vbCrLf &
                                       "where status = '1' and corp = '" & strCorp & "' and type_list = '" & strType & "'" & vbCrLf &
                                       "" & str_branch & " ORDER BY name_01,name_02 "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListmonth(Optional ByVal strCorp_Id = "") As DataSet
                Dim strSQL As String = "select id,initial_name_01,initial_name_02 from initial_data " & _
                                       " where initial_system = 'TimeAttendance' and initial_subsystem = 'month' and status = '1'" & _
                                       " and corp = '" & strCorp_Id & "' ORDER BY initial_seq Asc "
                Return SQL_DataSet(strSQL)
            End Function
            Public Function OT_Select(ByVal Condition As String) As Integer

                Dim strSQL As String = Condition

                Return SQL_Execute(strSQL)
            End Function
            Public Function OT_SelectColum(Optional ByVal strCondition = "") As DataSet

                Dim strSQL As String = strCondition

                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPerson_salary(Optional ByVal strCorp As String = "", Optional ByVal strstation As String = "", Optional ByVal strCondition As String = "", Optional ByVal str_date As String = "", Optional ByVal log_id As String = "") As DataSet
                Dim strSQL As String = "select salary_P.person_id,salary_P.em_code,salary_P.Name_person,salary_P.Name_person_2,salary_P.work_start," & vbCrLf &
                                       "salary_P.position_list_id,salary_P.position_id,salary_P.position, " & vbCrLf &
                                       "salary_P.position_level,salary_P.position_2,salary_P.station_id,salary_P.name_station, " & vbCrLf &
                                       "salary_P.name_station_2,salary_P.st_link,salary_P.position_id,'' as remark  from " & vbCrLf &
                                       "(select person_data.id as person_id,person_data.em_code, " & vbCrLf &
                                       "((isnull(person_data.prefix_01,''))+''+(isnull(person_data.name_01,''))+'  '+(isnull(person_data.sname_01,'')))as Name_person," & vbCrLf &
                                       "((isnull(person_data.prefix_02,''))+''+(isnull(person_data.name_02,''))+'  '+(isnull(person_data.sname_02,'')))as Name_person_2," & vbCrLf &
                                       "person_data.work_start,position.position_list_id,position.id as position_id,position.name_01 as position, " & vbCrLf &
                                       "position.name_02 as position_2,position_level.id as position_level," & vbCrLf &
                                       "station.id as station_id,station.name_01 as name_station,station.name_02 as name_station_2,station.st_link " & vbCrLf &
                                       "from person_data " & vbCrLf &
                                       "Left  join per_position  on person_data.id = per_position.person_id " & vbCrLf &
                                       "and per_position.position_type = '1' and per_position.position_status = '1'" & vbCrLf &
                                       "and per_position.status = '1' " & vbCrLf &
                                       "left join position  on per_position.position_id = position.id and position.corp = '" & strCorp & "'" & vbCrLf &
                                       "left join position_level on position.position_level = position_level.id " & vbCrLf &
                                       "left join station  on position.station_id = station.id " & vbCrLf &
                                       "where person_data.per_type = '1' " & vbCrLf &
                                       "and person_data.status	= '1' " & vbCrLf &
                                       "and person_data.em_status not in ('LF','R') " & vbCrLf &
                                       "and person_data.corp = '" & strCorp & "' " & vbCrLf &
                                       "and left(station.st_link,3) Like '" & strstation & "%' ) as salary_P " & vbCrLf &
                                       "where " & strCondition & vbCrLf &
                                       "order by  salary_P.em_code "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListPerson_salary_Edit(Optional ByVal strCorp As String = "", Optional ByVal strstation As String = "", Optional ByVal strCondition As String = "", Optional ByVal str_date As String = "") As DataSet
                Dim strSQL As String = "select salary_P.person_id,salary_P.em_code,salary_P.Name_person,salary_P.Name_person_2,salary_P.work_start," & vbCrLf &
                                       "salary_P.salary_id,salary_P.salary_value,salary_P.salary_unit,salary_P.begin_date,salary_P.position,salary_P.position_2,salary_P.station_id,salary_P.name_station, " & vbCrLf &
                                       "salary_P.name_station_2,salary_P.st_link,salary_P.log_id,salary_P.salary_adjust,salary_P.position_id, " & vbCrLf &
                                       "salary_P.adjust_type,salary_P.adjust_rate,salary_P.effective_date,'' as remark from " & vbCrLf &
                                       "(select person_data.id as person_id,person_data.em_code, " & vbCrLf &
                                       "((isnull(person_data.prefix_01,''))+''+(isnull(person_data.name_01,''))+'  '+(isnull(person_data.sname_01,'')))as Name_person," & vbCrLf &
                                       "((isnull(person_data.prefix_02,''))+''+(isnull(person_data.name_02,''))+'  '+(isnull(person_data.sname_02,'')))as Name_person_2," & vbCrLf &
                                       "person_data.work_start,salary.salary_value,salary_unit,salary.begin_date,position.id as position_id,position.name_01 as position,position.name_02 as position_2," & vbCrLf &
                                       "station.id as station_id,station.name_01 as name_station,station.name_02 as name_station_2,station.st_link, " & vbCrLf &
                                       "salary_adjust_log.id as log_id,salary_adjust_detail_log.salary_id,salary_adjust_detail_log.salary_adjust,salary_adjust_log.adjust_type,salary_adjust_log.adjust_rate,salary_adjust_log.effective_date " & vbCrLf &
                                       "from person_data" & vbCrLf &
                                       "Left join salary on person_data.id = salary.person_id " & vbCrLf &
                                       "and salary.id = (select top 1 id as salary_id from salary " & vbCrLf &
                                       "where salary.person_id = person_data.id " & vbCrLf &
                                       "and salary.begin_date <= '" & str_date & "' and salary.end_date is not null " & vbCrLf &
                                       "order by end_date desc) " & vbCrLf &
                                       "Left  join per_position  on person_data.id = per_position.person_id " & vbCrLf &
                                       "and per_position.position_type = '1' and per_position.position_status = '1'" & vbCrLf &
                                       "and per_position.status = '1' " & vbCrLf &
                                       "left join position  on per_position.position_id = position.id and position.corp = '" & strCorp & "'" & vbCrLf &
                                       "left join position_level on position.position_level = position_level.id " & vbCrLf &
                                       "left join station  on position.station_id = station.id " & vbCrLf &
                                       "left join salary_adjust_detail_log on person_data.id = salary_adjust_detail_log.person_id " & vbCrLf &
                                       "and salary_adjust_detail_log.log_id = '" & strCondition & "'" & vbCrLf &
                                       "left join salary_adjust_log on salary_adjust_detail_log.log_id = salary_adjust_log.id " & vbCrLf &
                                       "where person_data.per_type = '1' " & vbCrLf &
                                       "and person_data.status	= '1' " & vbCrLf &
                                       "and person_data.em_status not in ('LF','R') " & vbCrLf &
                                       "and person_data.corp = '" & strCorp & "' " & vbCrLf &
                                       "and left(station.st_link,3) Like '" & strstation & "%' ) as salary_P " & vbCrLf &
                                       "where salary_P.salary_value is not null and salary_P.log_id = '" & strCondition & "'" & vbCrLf &
                                       "order by  salary_P.em_code "

                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsListSalary_adjust(ByVal strCorp As String, ByVal str_year As String, ByVal str_branchid As String) As DataSet
                Dim strSQL As String = "SELECT * from salary_adjust_log " & vbCrLf &
                                       "Where corp = '" & strCorp & "' and status = '1' " & vbCrLf &
                                       "and adjust_year = '" & str_year & "'" & str_branchid & _
                                       "ORDER BY create_date Desc"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsList_PeriodCal(ByVal strCorp As String, ByVal str_year As String, ByVal str_month As String, ByVal str_package As String, ByVal str_period As String) As DataSet
                Dim strSQL As String = "select  T1.period_id,T1.lock_code,T3.name_package_01,T3.name_package_02,T2.period_no " & vbCrLf &
                                       "from payroll_cal_list T1 " & vbCrLf &
                                       "left join S_Period T2 on T1.period_id = T2.id " & vbCrLf &
                                       "left join payment_package T3 on T2.pay_package_id = T3.id " & vbCrLf &
                                       "Where T1.corp = '" & strCorp & "' and cal_year = '" & str_year & "' and cal_month = '" & str_month & "' " & vbCrLf &
                                       "and T1.status = '1' and T2.status = '1' and T2.status = '1'" & str_period & str_package & vbCrLf &
                                       "ORDER BY T3.name_package_01,T3.name_package_02"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsSalary_adjust_log_Delete(ByVal strlog_id As String) As Integer
                Dim strSQL As String
                strSQL = "UPDATE salary_adjust_log " & _
                         "SET status ='" & "4" & "' " & _
                         "WHERE id = '" & strlog_id & "'"
                Return SQL_Execute(strSQL)
            End Function
            Public Function dsSalary_adjust_detail_log_Delete(ByVal strlog_id As String) As Integer
                Dim strSQL As String
                strSQL = "UPDATE salary_adjust_detail_log " & _
                         "SET status ='" & "4" & "' " & _
                         "WHERE log_id = '" & strlog_id & "'"
                Return SQL_Execute(strSQL)
            End Function
            Public Function dsSalary_Delete(ByVal strsalary_id As String) As Integer
                Dim strSQL As String
                strSQL = "UPDATE salary " & _
                         "SET status ='" & "4" & "' " & _
                         "WHERE id = '" & strsalary_id & "'"
                Return SQL_Execute(strSQL)
            End Function
            Public Function dsSalary_select(ByVal strCorp As String, ByVal str_date As String, ByVal str_personid As String) As DataSet
                Dim strSQL As String = "SELECT id,person_id,salary_value from salary " & vbCrLf &
                                       "Where corp = '" & strCorp & "' and status = '1' " & vbCrLf &
                                       "and end_date = '" & str_date & "'and person_id = '" & str_personid & "'"
                Return SQL_DataSet(strSQL)
            End Function
            Public Function dsSalary_UpdateEnd_date(ByVal strsalary_id As String) As Integer
                Dim strSQL As String
                strSQL = "UPDATE salary " & _
                         "SET end_date = NULL " & _
                         "WHERE id = '" & strsalary_id & "'"
                Return SQL_Execute(strSQL)
            End Function
            Public Function dsSalary_Update(ByVal strsalary_id As String) As Integer
                Dim strSQL As String
                strSQL = "UPDATE salary " & _
                         "SET status = 4 " & _
                         "WHERE id = '" & strsalary_id & "'"
                Return SQL_Execute(strSQL)
            End Function
        End Class
    End Namespace
End Namespace