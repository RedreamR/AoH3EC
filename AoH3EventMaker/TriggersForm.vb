Imports System.ComponentModel.Design.ObjectSelectorEditor

Public Class TriggersForm
    Dim CurrentTrigger As String
    Dim CurrentDetails As String

    Sub Reload()
        StartForm.Reload()
        CurrentTrigger = Me.Text
        Dim Startline As Integer = Integer.Parse(CurrentTrigger.Split(New Char() {"_"})(1)) + 1
        Dim Endline As Integer = Integer.Parse(CurrentTrigger.Split(New Char() {"_"})(2)) - 1
        Me.Listbox_MainList.Items.Clear()
        For Line2 As Int32 = Startline To Endline
            Dim Line = StartForm.MainTextbox.Lines(Line2)
            Dim NewString As String = ""
            If Line = "next_and" Then
                NewString = "AND|" + Str(Line2) + "|"
            ElseIf Line = "next_or" Then
                NewString = "OR|" + Str(Line2) + "|"
            ElseIf Line = "next_not" Then
                NewString = "NOT|" + Str(Line2) + "|"
            End If
            If Line = "next_and" Or Line = "next_or" Or Line = "next_not" Then
                NewString += StartForm.MainTextbox.Lines(Line2 + 1).Split(New Char() {"="})(0)
                Me.Listbox_MainList.Items.Add(NewString)
            End If
        Next
    End Sub

    Private Sub TriggersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combobox_MainSelection.SelectedIndex = 0
        Combobox_TriggerType.SelectedIndex = 0
        Reload()
        CurrentDetails = GetTrigger()
    End Sub

    Function GetTrigger()
        Dim TriggerData As String = ""
        Dim ArgsCount As Int16 = 1
        Dim TriggerDesc1 As String = ""
        Dim TriggerDesc2 As String = ""
        Dim TriggerDesc3 As String = ""
        Select Case Me.Combobox_MainSelection.Items(Me.Combobox_MainSelection.SelectedIndex)
            Case "Variable ="
                TriggerData = "has_variable_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Variable"
                TriggerDesc3 = ""
            Case "Variable !"
                TriggerData = "has_variable_not"
                ArgsCount = 1
                TriggerDesc1 = "Variable"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Economy Invest >"
                TriggerData = "invested_in_economy_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Economy Invest <"
                TriggerData = "invested_in_economy_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Growth Rate Increased >"
                TriggerData = "increased_growth_rate_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Growth Rate Increased <"
                TriggerData = "increased_growth_rate_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Tax Efficiency Increased >"
                TriggerData = "increased_tax_efficiency_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Tax Efficiency Increased <"
                TriggerData = "increased_tax_efficiency_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Manpower Increased >"
                TriggerData = "increased_manpower_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Manpower Increased <"
                TriggerData = "increased_manpower_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Infrastructure Developed >"
                TriggerData = "developed_infrastructure_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Infrastructure Developed <"
                TriggerData = "developed_infrastructure_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Total Buildings Constructed >"
                TriggerData = "buildings_constructed_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Total Buildings Constructed <"
                TriggerData = "buildings_constructed_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Administrative Buildings Constructed >"
                TriggerData = "administrative_buildings_constructed_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Administrative Buildings Constructed <"
                TriggerData = "administrative_buildings_constructed_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Economy Buildings Constructed >"
                TriggerData = "economy_buildings_constructed_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Economy Buildings Constructed <"
                TriggerData = "economy_buildings_constructed_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Military Buildings Constructed >"
                TriggerData = "military_buildings_constructed_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Military Buildings Constructed <"
                TriggerData = "military_buildings_constructed_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Unique Buildings Constructed >"
                TriggerData = "unique_capital_buildings_constructed_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Unique Buildings Constructed <"
                TriggerData = "unique_capital_buildings_constructed_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Conquered Provinces >"
                TriggerData = "civ_conquered_provinces_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Conquered Provinces <"
                TriggerData = "civ_conquered_provinces_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Wars >"
                TriggerData = "civ_wars_total_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Wars <"
                TriggerData = "civ_wars_total_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Player ="
                TriggerData = "is_player"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Player !"
                TriggerData = "is_not_player"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Religion ="
                TriggerData = "civ_tag_religion_is"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "ID"
                TriggerDesc3 = ""
            Case "Religion !"
                TriggerData = "civ_tag_religion_is_not"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "ID"
                TriggerDesc3 = ""
            Case "Goverment ="
                TriggerData = "civ_tag_government_is"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "ID"
                TriggerDesc3 = ""
            Case "Goverment !"
                TriggerData = "civ_tag_government_is_not"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "ID"
                TriggerDesc3 = ""
            Case "Provinces ="
                TriggerData = "civ_provinces_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Provinces >"
                TriggerData = "civ_provinces_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Provinces <"
                TriggerData = "civ_provinces_equals"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Population >"
                TriggerData = "civ_population_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Population <"
                TriggerData = "civ_population_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Economy >"
                TriggerData = "civ_economy_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Economy <"
                TriggerData = "civ_economy_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Gold >"
                TriggerData = "civ_gold_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Gold <"
                TriggerData = "civ_gold_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Allies  >"
                TriggerData = "civ_allies_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Allies <"
                TriggerData = "civ_allies_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Defensive Pacts >"
                TriggerData = "civ_defensive_pacts_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Defensive Pacts <"
                TriggerData = "civ_defensive_pacts_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Non Argression Pacts <"
                TriggerData = "civ_non_aggression_pacts_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Non Argression Pacts <"
                TriggerData = "civ_non_aggression_pacts_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Vassals >"
                TriggerData = "civ_vassals_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Vassals <"
                TriggerData = "civ_vassals_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Neighbors >"
                TriggerData = "civ_neighbors_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Neighbors <"
                TriggerData = "civ_neighbors_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Random ="
                TriggerData = "random_chance"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Tag ="
                TriggerData = "is_civ"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Total Income >"
                TriggerData = "civ_total_income_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Total Income <"
                TriggerData = "civ_total_income_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Income Tax >"
                TriggerData = "civ_income_taxation_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Income Tax <"
                TriggerData = "civ_income_taxation_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Income Economy >"
                TriggerData = "civ_income_economy_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Income Economy <"
                TriggerData = "civ_income_economy_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Income Production >"
                TriggerData = "civ_income_production_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Income Production <"
                TriggerData = "civ_income_production_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Legacy/Month >"
                TriggerData = "civ_legacy_per_month_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Legacy/Month <"
                TriggerData = "civ_legacy_per_month_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Research/Month >"
                TriggerData = "civ_research_per_month_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Research/Month <"
                TriggerData = "civ_research_per_month_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Diplomacy Points >"
                TriggerData = "civ_diplomacy_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Diplomacy Points <"
                TriggerData = "civ_diplomacy_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Loans >"
                TriggerData = "civ_loans_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Loans <"
                TriggerData = "civ_loans_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Inflation >"
                TriggerData = "civ_inflation_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Infaltion <"
                TriggerData = "civ_inflation_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Legacy >"
                TriggerData = "civ_legacy_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Legacy <"
                TriggerData = "civ_legacy_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Legacies >"
                TriggerData = "civ_unlocked_legacies_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Legacies <"
                TriggerData = "civ_unlocked_legacies_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Technologies >"
                TriggerData = "civ_unlocked_technologies_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Technologies <"
                TriggerData = "civ_unlocked_technologies_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Advantages >"
                TriggerData = "civ_unlocked_advantages_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Advantages <"
                TriggerData = "civ_unlocked_advantages_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Rank >"
                TriggerData = "civ_rank_position_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Rank <"
                TriggerData = "civ_rank_position_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Prestige >"
                TriggerData = "civ_prestige_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Prestige <"
                TriggerData = "civ_prestige_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Resource ="
                TriggerData = "civ_has_resource"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Resource >"
                TriggerData = "civ_has_resource_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Production >"
                TriggerData = "civ_production_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Largest Producer >"
                TriggerData = "largest_producer_production_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Largest Producer ="
                TriggerData = "civ_is_largest_producer"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Manpower >"
                TriggerData = "civ_manpower_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Manpower <"
                TriggerData = "civ_manpower_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Max Manpower >"
                TriggerData = "civ_max_manpower_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Max Manpower <"
                TriggerData = "civ_max_manpower_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Manpower Ratio >"
                TriggerData = "civ_manpower_perc_over"
                ArgsCount = 1
                TriggerDesc1 = "Percent"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Manpower Ratio <"
                TriggerData = "civ_manpower_perc_below"
                ArgsCount = 1
                TriggerDesc1 = "Percent"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Regiments >"
                TriggerData = "civ_regiments_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Regiments <"
                TriggerData = "civ_regiments_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Regiments Limit >"
                TriggerData = "civ_regiments_limit_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Regiments Limit <"
                TriggerData = "civ_regiments_limit_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Battle Width >"
                TriggerData = "civ_battle_width_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Battle Width <"
                TriggerData = "civ_battle_width_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Regiments Over Limit ="
                TriggerData = "civ_regiments_over_regiments_limit"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Gold Over Max ="
                TriggerData = "civ_gold_over_max_amount_of_gold"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Buildings >"
                TriggerData = "civ_capital_buildings_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Buildings <"
                TriggerData = "civ_capital_buildings_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Tax Efficency >"
                TriggerData = "civ_capital_tax_efficiency_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Tax Efficency <"
                TriggerData = "civ_capital_tax_efficiency_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Economy >"
                TriggerData = "civ_capital_economy_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Economy <"
                TriggerData = "civ_capital_economy_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Manpower >"
                TriggerData = "civ_capital_manpower_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Manpower <"
                TriggerData = "civ_capital_manpower_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Growth Rate >"
                TriggerData = "civ_capital_growth_rate_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Growth Rate <"
                TriggerData = "civ_capital_growth_rate_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital 基建 >"
                TriggerData = "civ_capital_infrastructure_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital 基建 <"
                TriggerData = "civ_capital_infrastructure_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Population >"
                TriggerData = "civ_capital_population_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Population <"
                TriggerData = "civ_capital_population_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Fort >"
                TriggerData = "civ_capital_fort_level_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Fort <"
                TriggerData = "civ_capital_fort_level_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Income >"
                TriggerData = "civ_capital_income_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Income <"
                TriggerData = "civ_capital_income_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Unrest >"
                TriggerData = "civ_capital_unrest_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Unrest <"
                TriggerData = "civ_capital_unrest_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Religion ="
                TriggerData = "civ_capital_religion_is"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Building ="
                TriggerData = "civ_capital_has_building"
                ArgsCount = 2
                TriggerDesc1 = "Number"
                TriggerDesc2 = "ID"
                TriggerDesc3 = ""
            Case "Capital Occupied ="
                TriggerData = "civ_capital_is_occupied"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Occupied !"
                TriggerData = "civ_capital_is_not_occupied"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Siege ="
                TriggerData = "civ_capital_is_under_siege"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Continent ="
                TriggerData = "civ_capital_continent_is"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital Continent !"
                TriggerData = "civ_capital_continent_is_not"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Advisors >"
                TriggerData = "recruited_advisors_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Advisors <"
                TriggerData = "recruited_advisors_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Administrative Advisor Skill >"
                TriggerData = "civ_administrative_advisor_skill_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Administrative Advisor Skill <"
                TriggerData = "civ_administrative_advisor_skill_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Econimic Advisor Skill >"
                TriggerData = "civ_economic_advisor_skill_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Econimic Advisor Skill <"
                TriggerData = "civ_economic_advisor_skill_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Innovation Advisor Skill >"
                TriggerData = "civ_innovation_advisor_skill_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Innovation Advisor Skill <"
                TriggerData = "civ_innovation_advisor_skill_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Military Advisor Skill >"
                TriggerData = "civ_military_advisor_skill_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Military Advisor Skill <"
                TriggerData = "civ_military_advisor_skill_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Advisor Age >"
                TriggerData = "civ_advisor_age_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Advisor Production Efficency >"
                TriggerData = "civ_advisor_production_efficiency_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Advisor Construction Cost >"
                TriggerData = "civ_advisor_construction_cost_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Military Academy >"
                TriggerData = "civ_military_academy_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Military Academy <"
                TriggerData = "civ_military_academy_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Gerneral Military Academy >"
                TriggerData = "civ_military_academy_for_generals_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Gerneral Military Academy <"
                TriggerData = "civ_military_academy_for_generals_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital >"
                TriggerData = "civ_capital_city_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Capital <"
                TriggerData = "civ_capital_city_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Court >"
                TriggerData = "civ_supreme_court_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Court <"
                TriggerData = "civ_supreme_court_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Reactor >"
                TriggerData = "civ_nuclear_reactor_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Reactor <"
                TriggerData = "civ_nuclear_reactor_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Tag Exists ="
                TriggerData = "exists"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Tag Exists !"
                TriggerData = "exists_not"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Any Tag Exists ="
                TriggerData = "exists_any"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag (Non-Ideology Spefic)"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Any Tag Exists !"
                TriggerData = "exists_any_not"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag (Non-Ideology Spefic)"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Puppet ="
                TriggerData = "is_puppet"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Puppet !"
                TriggerData = "is_not_puppet"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Puppet Tag ="
                TriggerData = "civ_is_vassal_of_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag (Lord)"
                TriggerDesc3 = ""
            Case "War ="
                TriggerData = "civ_is_at_war"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "War !"
                TriggerData = "civ_is_not_at_war"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Wartime >"
                TriggerData = "civ_is_at_war_days_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Compare Provinces >"
                TriggerData = "civ_has_more_provinces_than_civ"
                ArgsCount = 1
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Compare Population >"
                TriggerData = "civ_has_larger_population_than_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Compare Economy >"
                TriggerData = "civ_has_larger_economy_than_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Compare Regiments Limit >"
                TriggerData = "civ_has_larger_regiments_limit_than_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Compare Regiments >"
                TriggerData = "civ_has_more_regiments_than_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Compare Ranking >"
                TriggerData = "civ_has_higher_ranking_than_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Compare Technologies >"
                TriggerData = "civ_has_more_technologies_than_civ"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Opinion >"
                TriggerData = "civs_opinion_over"
                ArgsCount = 3
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = "Number"
            Case "Opinion <"
                TriggerData = "civs_opinion_below"
                ArgsCount = 3
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = "Number"
            Case "Neighbors ="
                TriggerData = "civs_are_neighbors"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Neighbors !"
                TriggerData = "civs_are_not_neighbors"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Rivals ="
                TriggerData = "civs_are_rivals"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Rival ="
                TriggerData = "civ_has_rivalry"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Rival !"
                TriggerData = "civ_has_rivalry_not"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Wars ="
                TriggerData = "civs_are_at_war"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Wars !"
                TriggerData = "civs_are_not_at_war"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Defensive Pact ="
                TriggerData = "civs_have_defensive_pact"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Non Argression Pact ="
                TriggerData = "civs_have_non_aggression"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Alliance ="
                TriggerData = "civs_have_alliance"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Truce ="
                TriggerData = "civs_have_truce"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Military Access ="
                TriggerData = "civ_have_military_access"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Guarantee ="
                TriggerData = "civ_have_guarantee"
                ArgsCount = 2
                TriggerDesc1 = "Civ Tag"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Days >"
                TriggerData = "playing_time_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Days <"
                TriggerData = "playing_time_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Day ="
                TriggerData = "exact_day"
                ArgsCount = 3
                TriggerDesc1 = "Number (Day)"
                TriggerDesc2 = "Number (Month)"
                TriggerDesc3 = "Number (Year)"
            Case "Year >"
                TriggerData = "year_over"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Year <"
                TriggerData = "year_below"
                ArgsCount = 1
                TriggerDesc1 = "Number"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Random ="
                TriggerData = "random_chance"
                ArgsCount = 1
                TriggerDesc1 = "Percent"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Province ="
                TriggerData = "province_controlled_by"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Province !"
                TriggerData = "province_not_controlled_by"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Province Core ="
                TriggerData = "province_civ_has_core"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Civ Tag"
                TriggerDesc3 = ""
            Case "Province Economy >"
                TriggerData = "province_economy_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Economy <"
                TriggerData = "province_economy_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Growth Rate >"
                TriggerData = "province_growth_rate_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Growth Rate <"
                TriggerData = "province_growth_rate_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Population >"
                TriggerData = "province_population_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Population <"
                TriggerData = "province_population_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Tax Efficency >"
                TriggerData = "province_tax_efficiency_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Tax Efficency <"
                TriggerData = "province_tax_efficiency_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Manpower >"
                TriggerData = "province_manpower_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Manpower <"
                TriggerData = "province_manpower_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Income >"
                TriggerData = "province_income_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Income <"
                TriggerData = "province_income_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province 基建 >"
                TriggerData = "province_infrastructure_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province 基建 <"
                TriggerData = "province_infrastructure_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Occupied ="
                TriggerData = "province_is_occupied"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Province Occupied !"
                TriggerData = "province_is_not_occupied"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Province Siege ="
                TriggerData = "province_is_under_siege"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Province Buildings >"
                TriggerData = "province_buildings_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Buildings <"
                TriggerData = "province_buildings_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Buildings Limit >"
                TriggerData = "province_buildings_limit_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Buildings Limit <"
                TriggerData = "province_buildings_limit_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Defense >"
                TriggerData = "province_defense_lvl_over"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Defense <"
                TriggerData = "province_defense_lvl_below"
                ArgsCount = 2
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = ""
            Case "Province Capital ="
                TriggerData = "province_is_capital"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "Province Building ="
                TriggerData = "province_has_building"
                ArgsCount = 3
                TriggerDesc1 = "ID"
                TriggerDesc2 = "Number"
                TriggerDesc3 = "ID"
            Case "HRE Leader ="
                TriggerData = "alliance_special_is_leader_id"
                ArgsCount = 1
                TriggerDesc1 = "Boolean"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "HRE Member ="
                TriggerData = "alliance_special_is_member_id"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
            Case "HRE Member !"
                TriggerData = "alliance_special_is_not_member_id"
                ArgsCount = 1
                TriggerDesc1 = "ID"
                TriggerDesc2 = ""
                TriggerDesc3 = ""
        End Select
        Groupbox_Input1.Visible = False
        Groupbox_Input2.Visible = False
        Groupbox_Input3.Visible = False
        Dim NewString As String = ""
        NewString += TriggerData
        NewString += ("=" + Me.Textbox_Input1.Text)
        Richtextbox_Desc1.Text = TriggerDesc1
        Groupbox_Input1.Visible = True
        If ArgsCount >= 2 Then
            NewString += ("=" + Me.Textbox_Input2.Text)
            Richtextbox_Desc2.Text = TriggerDesc2
            Groupbox_Input2.Visible = True
        End If
        If ArgsCount = 3 Then
            NewString += ("=" + Me.Textbox_Input3.Text)
            Richtextbox_Desc3.Text = TriggerDesc3
            Groupbox_Input3.Visible = True
        End If
        Return NewString
    End Function

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        CurrentDetails = GetTrigger()
        Dim Selected As String
        If Me.Listbox_MainList.SelectedIndex = -1 Then
            Selected = "AND|" + Me.Text.Split(New Char() {"_"})(2) + "|exact_day"
        Else
            Selected = Me.Listbox_MainList.Items(Me.Listbox_MainList.SelectedIndex).ToString()
        End If
        Dim Endline = Integer.Parse(Selected.Split(New Char() {"|"})(1)) + 1
        Dim Lines As List(Of String) = StartForm.MainTextbox.Lines.ToList()
        If Me.Listbox_MainList.SelectedIndex = -1 Then
            Lines.Insert(Endline - 1, CurrentDetails)
            Lines.Insert(Endline - 1, "next_" + LCase(Me.Combobox_TriggerType.SelectedItem.ToString()))
        Else
            Lines.Insert(Endline + 1, CurrentDetails)
            Lines.Insert(Endline + 1, "next_" + LCase(Me.Combobox_TriggerType.SelectedItem.ToString()))
        End If
        StartForm.MainTextbox.Text = String.Join(Environment.NewLine, Lines)
        Me.Text = CurrentTrigger.Split(New Char() {"_"})(0) + "_" + CurrentTrigger.Split(New Char() {"_"})(1) + "_" + Str(Integer.Parse(CurrentTrigger.Split(New Char() {"_"})(2) + 2))
        Reload()
        Listbox_MainList_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        CurrentDetails = GetTrigger()
        Dim Selected = Me.Listbox_MainList.Items(Me.Listbox_MainList.SelectedIndex).ToString()
        Dim Startline = Selected.Split(New Char() {"|"})(1)
        Dim Endline = Startline + 1
        Dim Lines As List(Of String) = StartForm.MainTextbox.Lines.ToList()
        For Interval As Int32 = Startline To Endline
            Lines.RemoveAt(Startline)
        Next
        StartForm.MainTextbox.Text = String.Join(Environment.NewLine(), Lines)
        Me.Text = CurrentTrigger.Split(New Char() {"_"})(0) + "_" + CurrentTrigger.Split(New Char() {"_"})(1) + "_" + Str(Integer.Parse(CurrentTrigger.Split(New Char() {"_"})(2) - 2))
        Reload()
        Listbox_MainList_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Combobox_MainSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combobox_MainSelection.SelectedIndexChanged
        CurrentDetails = GetTrigger()
    End Sub

    Private Sub Listbox_MainList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listbox_MainList.SelectedIndexChanged
        If Me.Listbox_MainList.SelectedIndex = -1 Then
            Me.Button_Delete.Enabled = False
        Else
            Me.Button_Delete.Enabled = True
        End If
    End Sub
End Class