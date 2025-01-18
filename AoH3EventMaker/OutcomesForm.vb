Imports System.ComponentModel.Design.ObjectSelectorEditor

Public Class OutcomesForm
    Dim CurrentOutcome As String
    Dim CurrentDetails As String

    Sub Reload()
        StartForm.Reload()
        CurrentOutcome = Me.Text
        Dim Startline As Integer = Integer.Parse(CurrentOutcome.Split(New Char() {"_"})(0)) + 3
        Dim Endline As Integer = Integer.Parse(CurrentOutcome.Split(New Char() {"_"})(1)) - 1
        Me.Textbox_Name.Text = StartForm.MainTextbox.Lines(Me.Text.Split(New Char() {"_"})(0) + 1).Split(New Char() {"="})(1)
        Me.Listbox_MainList.Items.Clear()
        For Line2 As Int32 = Startline To Endline
            Dim Line = StartForm.MainTextbox.Lines(Line2)
            Dim NewString As String = Str(Line2) + "|"
            NewString += StartForm.MainTextbox.Lines(Line2).Split(New Char() {"="})(0)
            Me.Listbox_MainList.Items.Add(NewString)
        Next
    End Sub

    Private Sub OutcomesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combobox_MainSelection.SelectedIndex = 0
        Reload()
        CurrentDetails = GetOutcome()
    End Sub

    Function GetOutcome()
        Dim OutcomeData As String = ""
        Dim ArgsCount As Int16 = 1
        Dim OutcomeDesc1 As String = ""
        Dim OutcomeDesc2 As String = ""
        Dim OutcomeDesc3 As String = ""
        Select Case Me.Combobox_MainSelection.Items(Me.Combobox_MainSelection.SelectedIndex)
            Case "播放音乐"
                OutcomeData = "play_music"
                ArgsCount = 1
                OutcomeDesc1 = "文件名，不要携带.ogg扩展名"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增加黄金"
                OutcomeData = "gold"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增加每月黄金收入"
                OutcomeData = "gold_monthly_income"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "遗产 +"
                OutcomeData = "legacy"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "每月遗产增加 +"
                OutcomeData = "legacy_monthly"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "玩家游玩文明 ="
                OutcomeData = "player_set_civ"
                ArgsCount = 1
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "研究 +"
                OutcomeData = "research"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "优势点数 +"
                OutcomeData = "advantage_points"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "人力 +"
                OutcomeData = "人力"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "通货膨胀 +"
                OutcomeData = "inflation"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "AI侵略度 ="
                OutcomeData = "ai_aggression"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "侵略扩张 ="
                OutcomeData = "ae_set"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "首都"
                OutcomeData = "move_capital"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "宣战"
                OutcomeData = "declare_war2"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "结成同盟"
                OutcomeData = "add_alliance"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "签订互不侵犯条约"
                OutcomeData = "add_non_aggression"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "添加军事通行权"
                OutcomeData = "add_military_access"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "保证独立"
                OutcomeData = "add_guarantee"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "签订防御条约"
                OutcomeData = "add_defensive_pact"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "新增和约"
                OutcomeData = "add_truce"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "改变政体"
                OutcomeData = "change_ideology_civ"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "改变宗教"
                OutcomeData = "change_religion_civ"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "吞并"
                OutcomeData = "annex"
                ArgsCount = 1
                OutcomeDesc1 = "省份ID，以英文分号(;)分割"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "吞并，若省份被某文明控制"
                OutcomeData = "annex_by_civ_from_civ"
                ArgsCount = 3
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = "省份ID，以英文分号(;)分割"
            Case "吞并文明"
                OutcomeData = "annex_civ"
                ArgsCount = 1
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "被完全吞并"
                OutcomeData = "annexed_by_civ"
                ArgsCount = 1
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "新增附庸"
                OutcomeData = "make_puppet"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "设置文明Tag"
                OutcomeData = "set_civ_tag2"
                ArgsCount = 2
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "运行事件"
                OutcomeData = "run_event"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "添加随机将军"
                OutcomeData = "add_general"
                ArgsCount = 1
                OutcomeDesc1 = "布尔值"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "新增将军"
                OutcomeData = "add_general3"
                ArgsCount = 1
                OutcomeDesc1 = "Name"
                OutcomeDesc2 = "攻击加成, 设置为-1时，加成为随机值。"
                OutcomeDesc3 = "防御加成，设置为-1时，加成为随机值。"
            Case "新增随机顾问"
                OutcomeData = "add_advisor"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "新增顾问"
                OutcomeData = "add_advisor2"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "Name"
                OutcomeDesc3 = ""
            Case "更换统治者"
                OutcomeData = "add_ruler"
                ArgsCount = 3
                OutcomeDesc1 = "FirstName=LastName"
                OutcomeDesc2 = "IMG Name, No .png"
                OutcomeDesc3 = "D=M=Y"
            Case "设置随机省份经济"
                OutcomeData = "province_economy"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "设置首都经济"
                OutcomeData = "province_economy_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "设置文明经济"
                OutcomeData = "province_economy_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "设置省份经济"
                OutcomeData = "province_economy_id"
                ArgsCount = 2
                OutcomeDesc1 = "省份ID"
                OutcomeDesc2 = "数字，经济量"
                OutcomeDesc3 = ""
            Case "设置随机省份的税收率"
                OutcomeData = "province_tax_efficiency"
                ArgsCount = 1
                OutcomeDesc1 = "数字，税收率"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "设置首都的税收率"
                OutcomeData = "province_tax_efficiency_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "设置文明的税收率"
                OutcomeData = "province_tax_efficiency_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "设置省份的税收率"
                OutcomeData = "province_tax_efficiency_id"
                ArgsCount = 2
                OutcomeDesc1 = "省份ID"
                OutcomeDesc2 = "数字"
                OutcomeDesc3 = ""
            Case "设置随机省份的人力"
                OutcomeData = "province_manpower"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 人力 首都"
                OutcomeData = "province_manpower_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 人力 全部="
                OutcomeData = "province_manpower_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 人力 ID ="
                OutcomeData = "province_manpower_id"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "省份 增长率 ="
                OutcomeData = "province_growth_rate"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 增长率 首都"
                OutcomeData = "province_growth_rate_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 增长率 全部="
                OutcomeData = "province_growth_rate_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 增长率 ID ="
                OutcomeData = "province_growth_rate_id"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "省份 人口 ="
                OutcomeData = "province_population"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 人口 首都"
                OutcomeData = "province_population_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 人口 全部="
                OutcomeData = "province_population_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 人口 ID ="
                OutcomeData = "province_population_id"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "数字"
                OutcomeDesc3 = ""
            Case "省份 改变宗教"
                OutcomeData = "province_religion"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 Religion 首都"
                OutcomeData = "province_religion_capital"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 Religion 全部="
                OutcomeData = "province_religion_all"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 Religion ID ="
                OutcomeData = "province_religion_id"
                ArgsCount = 1
                OutcomeDesc1 = "省份 ID"
                OutcomeDesc2 = "ID"
                OutcomeDesc3 = ""
            Case "省份 荒废度 ="
                OutcomeData = "province_devastation"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 荒废度 首都"
                OutcomeData = "province_devastation_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 荒废度 全部="
                OutcomeData = "province_devastation_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 荒废度 ID ="
                OutcomeData = "province_devastation_id"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "数字"
                OutcomeDesc3 = ""
            Case "省份 Unrest ="
                OutcomeData = "province_unrest"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 Unrest 首都"
                OutcomeData = "province_unrest_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 Unrest 全部="
                OutcomeData = "province_unrest_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 Unrest ID ="
                OutcomeData = "province_unrest_id"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "数字"
                OutcomeDesc3 = ""
            Case "省份 基建 ="
                OutcomeData = "province_infrastructure"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 基建 首都"
                OutcomeData = "province_infrastructure_capital"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 基建 全部="
                OutcomeData = "province_infrastructure_all"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "省份 基建 ID ="
                OutcomeData = "province_infrastructure_id"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "数字"
                OutcomeDesc3 = ""
            Case "添加核心"
                OutcomeData = "province_add_core_civ"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "移除核心"
                OutcomeData = "province_remove_core_civ"
                ArgsCount = 2
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "文明Tag"
                OutcomeDesc3 = ""
            Case "新建军队"
                OutcomeData = "add_new_army"
                ArgsCount = 2
                OutcomeDesc1 = "Army ID"
                OutcomeDesc2 = "Unit ID"
                OutcomeDesc3 = ""
            Case "添加变量"
                OutcomeData = "add_variable2"
                ArgsCount = 2
                OutcomeDesc1 = "Civ"
                OutcomeDesc2 = "Variable"
                OutcomeDesc3 = ""
            Case "增益 有效期 ="
                OutcomeData = "bonus_duration"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Monthly Income ="
                OutcomeData = "bonus_monthly_income"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Monthly Legacy ="
                OutcomeData = "bonus_monthly_legacy"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Monthly Legacy % ="
                OutcomeData = "bonus_monthly_legacy_percentage"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Maximum Gold ="
                OutcomeData = "bonus_maximum_amount_of_gold"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 税收率 ="
                OutcomeData = "bonus_tax_efficiency"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 增长率 ="
                OutcomeData = "bonus_growth_rate"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 省份 Maintenance ="
                OutcomeData = "bonus_province_maintenance"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Buildings 维护费用  ="
                OutcomeData = "bonus_buildings_maintenance_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 维护费用  ="
                OutcomeData = "bonus_maintenance_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Production Efficency ="
                OutcomeData = "bonus_production_efficiency"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Income Production ="
                OutcomeData = "bonus_income_production"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Income Taxation ="
                OutcomeData = "bonus_income_taxation"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Income 经济 ="
                OutcomeData = "bonus_income_economy"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Corruption ="
                OutcomeData = "bonus_corruption"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Inflation ="
                OutcomeData = "bonus_inflation"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Research ="
                OutcomeData = "bonus_research"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Research Points ="
                OutcomeData = "bonus_research_points"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Max 人力 ="
                OutcomeData = "bonus_max_manpower"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Max 人力 % ="
                OutcomeData = "bonus_max_manpower_percentage"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 人力 Recovery Speed ="
                OutcomeData = "bonus_manpower_recovery_speed"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Reinforcement Speed ="
                OutcomeData = "bonus_reinforcement_speed"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Army Morale Recovery ="
                OutcomeData = "bonus_army_morale_recovery"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Army Maintenance ="
                OutcomeData = "bonus_army_maintenance"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Recruitment Time ="
                OutcomeData = "bonus_recruitment_time"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Recruit Cost ="
                OutcomeData = "bonus_recruit_army_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Recruit Cost First Line ="
                OutcomeData = "bonus_recruit_army_first_line_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Recruit Cost Second Line ="
                OutcomeData = "bonus_recruit_army_second_line_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Generals 攻击 ="
                OutcomeData = "bonus_generals_attack"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Generals 防御 ="
                OutcomeData = "bonus_generals_defense"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Units 攻击 ="
                OutcomeData = "bonus_units_attack"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Units 防御 ="
                OutcomeData = "bonus_units_defense"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Regiments Limit ="
                OutcomeData = "bonus_regiments_limit"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Battle Width ="
                OutcomeData = "bonus_battle_width"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Discipline ="
                OutcomeData = "bonus_discipline"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Siege Effectiveness ="
                OutcomeData = "bonus_siege_effectiveness"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Max Morale ="
                OutcomeData = "bonus_max_morale"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Army Speed ="
                OutcomeData = "bonus_army_movement_speed"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 人力 Recovery From Disbanding ="
                OutcomeData = "bonus_manpower_recovery_from_disbanded_army"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 War Score ="
                OutcomeData = "bonus_war_score_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Construction Cost ="
                OutcomeData = "bonus_construction_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Administration Building Cost ="
                OutcomeData = "bonus_administration_buildings_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Military Building Cost ="
                OutcomeData = "bonus_military_buildings_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 经济 Building Cost ="
                OutcomeData = "bonus_economy_buildings_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Construction Time ="
                OutcomeData = "bonus_construction_time"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Invest Cost ="
                OutcomeData = "bonus_invest_in_economy_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 人力 Cost ="
                OutcomeData = "bonus_increase_manpower_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 税收率 Cost ="
                OutcomeData = "bonus_increase_tax_efficiency_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 基建 Cost ="
                OutcomeData = "bonus_develop_infrastructure_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 增长率 Cost ="
                OutcomeData = "bonus_increase_growth_rate_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Diplomacy Points ="
                OutcomeData = "bonus_diplomacy_points"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Relations Modifier ="
                OutcomeData = "bonus_improve_relations_modifier"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Vassals Income ="
                OutcomeData = "bonus_income_from_vassals"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Agressive Expansion ="
                OutcomeData = "bonus_aggressive_expansion"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Core Cost ="
                OutcomeData = "bonus_core_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Religion Cost ="
                OutcomeData = "bonus_religion_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Revolution Risk ="
                OutcomeData = "bonus_revolutionary_risk"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Loan Interest ="
                OutcomeData = "bonus_loan_interest"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Loan Limit ="
                OutcomeData = "bonus_loans_limit"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Characters Age ="
                OutcomeData = "bonus_all_characters_life_expectancy"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Advisors Cost ="
                OutcomeData = "bonus_advisor_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Advisors Max Levels ="
                OutcomeData = "bonus_advisors_max_level"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 General Cost ="
                OutcomeData = "bonus_general_cost"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "增益 Desease Death Rate ="
                OutcomeData = "bonus_disease_death_rate"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Join HRE First Tier ="
                OutcomeData = "join_alliance_special_id_first_tier"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Join HRE Second Tier ="
                OutcomeData = "join_alliance_special_id_second_tier"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Leave HRE ="
                OutcomeData = "leave_alliance_special_id"
                ArgsCount = 1
                OutcomeDesc1 = "Boolean"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Kill Ruler ="
                OutcomeData = "kill_ruler"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Kill Advisor ="
                OutcomeData = "kill_ruler_chance"
                ArgsCount = 1
                OutcomeDesc1 = "%"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Promote Advisor ="
                OutcomeData = "promote_advisor"
                ArgsCount = 1
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Military Academy +"
                OutcomeData = "military_academy"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Military Academy General +"
                OutcomeData = "military_academy_generals"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Capital City +"
                OutcomeData = "capital_city_level"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Court +"
                OutcomeData = "supreme_court"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Reactor +"
                OutcomeData = "nuclear_reactor"
                ArgsCount = 1
                OutcomeDesc1 = "数字"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Explode ="
                OutcomeData = "explode"
                ArgsCount = 1
                OutcomeDesc1 = "文明Tag"
                OutcomeDesc2 = ""
                OutcomeDesc3 = ""
            Case "Price +"
                OutcomeData = "price_change_up"
                ArgsCount = 3
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "Base%=Random%"
                OutcomeDesc3 = "Base%=Random%"
            Case "Price -"
                OutcomeData = "price_change_random_down"
                ArgsCount = 3
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "Base%=Random%"
                OutcomeDesc3 = "Base%=Random%"
            Case "Price Group +"
                OutcomeData = "price_change_group_up"
                ArgsCount = 3
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "Base%=Random%"
                OutcomeDesc3 = "Base%=Random%"
            Case "Price Group -"
                OutcomeData = "price_change_group_down"
                ArgsCount = 3
                OutcomeDesc1 = "ID"
                OutcomeDesc2 = "Base%=Random%"
                OutcomeDesc3 = "Base%=Random%"
        End Select
        Groupbox_Input1.Visible = False
        Groupbox_Input2.Visible = False
        Groupbox_Input3.Visible = False
        Dim NewString As String = ""
        NewString += OutcomeData
        NewString += ("=" + Me.Textbox_Input1.Text)
        Richtextbox_Desc1.Text = OutcomeDesc1
        Groupbox_Input1.Visible = True
        If ArgsCount >= 2 Then
            NewString += ("=" + Me.Textbox_Input2.Text)
            Richtextbox_Desc2.Text = OutcomeDesc2
            Groupbox_Input2.Visible = True
        End If
        If ArgsCount = 3 Then
            NewString += ("=" + Me.Textbox_Input3.Text)
            Richtextbox_Desc3.Text = OutcomeDesc3
            Groupbox_Input3.Visible = True
        End If
        Return NewString
    End Function

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        CurrentDetails = GetOutcome()
        Dim Selected As String
        If Me.Listbox_MainList.SelectedIndex = -1 Then
            Selected = "" + Me.Text.Split(New Char() {"_"})(1) + "|add_variable"
        Else
            Selected = Me.Listbox_MainList.Items(Me.Listbox_MainList.SelectedIndex).ToString()
        End If
        Dim Endline = Integer.Parse(Selected.Split(New Char() {"|"})(0)) + 1
        Dim Lines As List(Of String) = StartForm.MainTextbox.Lines.ToList()
        If Me.Listbox_MainList.SelectedIndex = -1 Then
            Lines.Insert(Endline - 1, CurrentDetails)
        Else
            Lines.Insert(Endline + 1, CurrentDetails)
        End If
        StartForm.MainTextbox.Text = String.Join(Environment.NewLine, Lines)
        Me.Text = CurrentOutcome.Split(New Char() {"_"})(0) + "_" + Str(Int(CurrentOutcome.Split(New Char() {"_"})(1) + 1))
        Reload()
        Listbox_MainList_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        CurrentDetails = GetOutcome()
        Dim Selected = Me.Listbox_MainList.Items(Me.Listbox_MainList.SelectedIndex).ToString()
        Dim Startline = Selected.Split(New Char() {"|"})(0)
        Dim Lines As List(Of String) = StartForm.MainTextbox.Lines.ToList()
        Lines.RemoveAt(Startline)
        StartForm.MainTextbox.Text = String.Join(Environment.NewLine(), Lines)
        Me.Text = Me.Text.Split(New Char() {"_"})(0) + "_" + Str(Integer.Parse(Me.Text.Split(New Char() {"_"})(1) - 1))
        Reload()
        Listbox_MainList_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Combobox_MainSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combobox_MainSelection.SelectedIndexChanged
        CurrentDetails = GetOutcome()
    End Sub

    Private Sub Listbox_MainList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listbox_MainList.SelectedIndexChanged
        If Me.Listbox_MainList.SelectedIndex = -1 Then
            Me.Button_Delete.Enabled = False
        Else
            Me.Button_Delete.Enabled = True
        End If
    End Sub

    Private Sub Textbox_Name_TextChanged(sender As Object, e As EventArgs) Handles Textbox_Name.TextChanged
        Dim Lines = StartForm.MainTextbox.Lines
        Lines(Int(Me.Text.Split(New Char() {"_"})(0)) + 1) = "name=" + Textbox_Name.Text
        StartForm.MainTextbox.Lines = Lines
    End Sub
End Class