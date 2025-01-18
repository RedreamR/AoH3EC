Imports System.IO
Imports System.Threading

Public Class StartForm
    Public DefaultEvent As String =
        ("id=
title=
desc=
mission_desc=

image=.png

show_in_missions=false
mission_image=.png

only_once=true
popUp=true")

    Function FindAndReplace(Text As String, Value As String)
        Dim Interval As Int16 = 0
        For Each Line In Me.MainTextbox.Lines
            If Line.Split(New Char() {"="})(0) = Text Then
                Dim NewLine = Text + "=" + Value
                Dim Lines = Me.MainTextbox.Lines
                Lines(Interval) = NewLine
                Me.MainTextbox.Lines = Lines
                Return NewLine
            End If
            Interval += 1
        Next
        Return 0
        Reload()
    End Function

    Function Find(Text As String)
        Dim TargetLine As Int16 = 0
        For Each Line In Me.MainTextbox.Lines
            If Line.Split(New Char() {"="})(0) = Text Then
                Return TargetLine
            End If
            TargetLine += 1
        Next
        Return TargetLine
        Reload()
    End Function

    Sub Reload()
        Me.Textbox_ID.Text = MainTextbox.Lines(Find("id")).Split(New Char() {"="})(1)
        Me.Textbox_Title.Text = MainTextbox.Lines(Find("title")).Split(New Char() {"="})(1)
        Me.Textbox_Desc.Text = MainTextbox.Lines(Find("desc")).Split(New Char() {"="})(1)
        If MainTextbox.Lines(Find("show_in_missions")).Split(New Char() {"="})(1) = "true" Then
            Me.Checkbox_Mission.Checked = True
        Else
            Me.Checkbox_Mission.Checked = False
        End If
        If Me.Checkbox_Mission.Checked = True Then
            MissionForm.Textbox_Image.Text = MainTextbox.Lines(Find("mission_image")).Split(New Char() {"="})(1).Split(New Char() {"."})(0)
            MissionForm.Textbox_MissionDesc.Text = MainTextbox.Lines(Find("mission_desc")).Split(New Char() {"="})(1)
        Else
            MissionForm.Textbox_Image.Text = ""
            MissionForm.Textbox_MissionDesc.Text = ""
        End If
        If MainTextbox.Lines(Find("only_once")).Split(New Char() {"="})(1) = "true" Then
            Me.Checkbox_Once.Checked = True
        Else
            Me.Checkbox_Once.Checked = False
        End If
        Me.Textbox_Image.Text = MainTextbox.Lines(Find("image")).Split(New Char() {"="})(1).Split(New Char() {"."})(0)
        Me.Listbox_Triggers.Items.Clear()
        Me.Listbox_Outcomes.Items.Clear()
        Dim Interval As Int16 = 0
        For Each Line In Me.MainTextbox.Lines
            Dim NewString As String = ""
            If Line = "trigger_and" Then
                NewString = NewString + "AND_" + Str(Interval) + "_"
            ElseIf Line = "trigger_or" Then
                NewString = NewString + "OR_" + Str(Interval) + "_"
            ElseIf Line = "trigger_not" Then
                NewString = NewString + "NOT_" + Str(Interval) + "_"
            End If
            If Line = "trigger_and" Or Line = "trigger_or" Or Line = "trigger_not" Then
                Dim Found As Boolean = False
                Dim Interval2 As Int16 = 1
                While Found = False
                    If Me.MainTextbox.Lines(Interval + Interval2).Split(New Char() {"_"})(0) = "trigger" Then
                        NewString = NewString + Str(Interval + Interval2)
                        Found = True
                    End If
                    Interval2 += 1
                End While
                Me.Listbox_Triggers.Items.Add(NewString)
            End If
            If Line = "option_btn" Then
                NewString = Str(Interval) + "_"
            End If
            If Line = "option_btn" Then
                Dim Found As Boolean = False
                Dim Interval2 As Int16 = 1
                While Found = False
                    If Me.MainTextbox.Lines(Interval + Interval2) = "option_end" Then
                        NewString = NewString + Str(Interval + Interval2)
                        Found = True
                    End If
                    Interval2 += 1
                End While
                Me.Listbox_Outcomes.Items.Add(NewString)
            End If
            Interval += 1
        Next
        If MainTextbox.Lines(Find("popUp")).Split(New Char() {"="})(1) = "true" Then
            Me.Checkbox_Popup.Checked = True
        Else
            Me.Checkbox_Popup.Checked = False
        End If
    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MainTextbox.Text = DefaultEvent
        Combobox_TriggerType.SelectedIndex = 0
        Reload()
    End Sub

    Private Sub Button_File_New_Click(sender As Object, e As EventArgs) Handles Button_File_New.Click
        If MsgBox("你确定要新建一个事件吗？", 4, "新事件") = MsgBoxResult.Yes Then
            Me.MainTextbox.Text = DefaultEvent
            Reload()
        End If
    End Sub

    Private Sub Button_File_Open_Click(sender As Object, e As EventArgs) Handles Button_File_Open.Click
        If Me.OpenHandler.ShowDialog() = DialogResult.OK Then
            If File.Exists(OpenHandler.FileName) = True Then
                Dim Reader As StreamReader = New StreamReader(OpenHandler.FileName)
                Me.MainTextbox.Text = Reader.ReadToEnd()
                Reader.Close()
            End If
        End If
        Reload()
    End Sub

    Private Sub Button_File_Save_Click(sender As Object, e As EventArgs) Handles Button_File_Save.Click
        If Me.SaveHandler.ShowDialog() = DialogResult.OK Then
            Using FStream As FileStream = New FileStream(SaveHandler.FileName, FileMode.Create)
                Using Writer As StreamWriter = New StreamWriter(FStream)
                    Writer.Write(Me.MainTextbox.Text)
                End Using
            End Using
        End If
    End Sub

    Private Sub Textbox_ID_TextChanged(sender As Object, e As EventArgs) Handles Textbox_ID.TextChanged
        FindAndReplace("id", Me.Textbox_ID.Text)
    End Sub

    Private Sub Textbox_Title_TextChanged(sender As Object, e As EventArgs) Handles Textbox_Title.TextChanged
        FindAndReplace("title", Me.Textbox_Title.Text)
    End Sub

    Private Sub Textbox_Desc_TextChanged(sender As Object, e As EventArgs) Handles Textbox_Desc.TextChanged
        FindAndReplace("desc", Me.Textbox_Desc.Text)
    End Sub

    Private Sub Checkbox_Mission_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Mission.CheckedChanged
        Me.Button_Mission.Enabled = Not Me.Button_Mission.Enabled
        If Me.Checkbox_Mission.Checked = True Then
            FindAndReplace("show_in_missions", "true")
        Else
            FindAndReplace("show_in_missions", "false")
        End If
    End Sub

    Private Sub Button_Mission_Click(sender As Object, e As EventArgs) Handles Button_Mission.Click
        MissionForm.Show()
    End Sub

    Private Sub Checkbox_Once_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Once.CheckedChanged
        If Me.Checkbox_Once.Checked = True Then
            FindAndReplace("only_once", "true")
        Else
            FindAndReplace("only_once", "false")
        End If
    End Sub

    Private Sub Checkbox_Popup_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Popup.CheckedChanged
        If Me.Checkbox_Popup.Checked = True Then
            FindAndReplace("popUp", "true")
        Else
            FindAndReplace("popUp", "false")
        End If
    End Sub

    Private Sub Textbox_Image_TextChanged(sender As Object, e As EventArgs) Handles Textbox_Image.TextChanged
        FindAndReplace("image", Me.Textbox_Image.Text + ".png")
    End Sub

    Private Sub Button_Trigger_Edit_Click(sender As Object, e As EventArgs) Handles Button_Trigger_Edit.Click
        Dim NewForm = New TriggersForm
        NewForm.Text = Me.Listbox_Triggers.Items(Me.Listbox_Triggers.SelectedIndex)
        NewForm.Show()
        Reload()
        Listbox_Triggers_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button_Trigger_Delete_Click(sender As Object, e As EventArgs) Handles Button_Trigger_Delete.Click
        Dim Selected = Listbox_Triggers.Items(Listbox_Triggers.SelectedIndex).ToString
        Dim Startline = Selected.Split(New Char() {"_"})(1)
        Dim Endline = Selected.Split(New Char() {"_"})(2) + 1
        Dim Lines = MainTextbox.Lines.ToList
        For i As Short = 1 To 100
            Lines.Add("")
        Next
        For Interval As Integer = Startline To Endline
            Lines.RemoveAt(Startline)
        Next
        For i = Lines.Count - 1 To 0 Step -1
            If Not String.IsNullOrWhiteSpace(Lines(i)) Then
                Exit For
            End If
            Lines.RemoveAt(i)
        Next
        MainTextbox.Text = String.Join(Environment.NewLine, Lines)
        Reload()
        Listbox_Triggers_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button_Trigger_Add_Click(sender As Object, e As EventArgs) Handles Button_Trigger_Add.Click
        Dim Selected As String
        Dim RealOption As String
        If Me.Combobox_TriggerType.SelectedItem = "和" Then
            RealOption = "and"
        ElseIf Me.Combobox_TriggerType.SelectedItem = "或" Then
            RealOption = "or"
        ElseIf Me.Combobox_TriggerType.SelectedItem = "非" Then
            RealOption = "not"
        End If
        If Me.Listbox_Triggers.SelectedIndex = -1 Then
            Selected = "AND_12_12"
        Else
            Selected = Me.Listbox_Triggers.Items(Me.Listbox_Triggers.SelectedIndex).ToString()
        End If
        Dim Endline = Selected.Split(New Char() {"_"})(2)
        Dim Lines As List(Of String) = Me.MainTextbox.Lines.ToList()
        For i As Int16 = 1 To 100
            Lines.Add("")
        Next
        If Selected = "AND_12_12" Then
            Lines.Insert(Endline + 1, "trigger_" + RealOption)
            Lines.Insert(Endline + 2, "trigger_" + RealOption + "_end")
            Lines.Insert(Endline + 3, "")
        Else
            Lines.Insert(Endline + 2, "trigger_" + RealOption)
            Lines.Insert(Endline + 3, "trigger_" + RealOption + "_end")
            Lines.Insert(Endline + 4, "")
        End If
        For i As Integer = Lines.Count - 1 To 0 Step -1
            If Not String.IsNullOrWhiteSpace(Lines(i)) Then
                Exit For
            End If
            Lines.RemoveAt(i)
        Next
        Me.MainTextbox.Text = String.Join(Environment.NewLine(), Lines)
        Reload()
        Listbox_Triggers_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Listbox_Triggers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listbox_Triggers.SelectedIndexChanged
        If Me.Listbox_Triggers.SelectedIndex >= 0 Then
            Me.Button_Trigger_Delete.Enabled = True
            Me.Button_Trigger_Edit.Enabled = True
        Else
            Me.Button_Trigger_Delete.Enabled = False
            Me.Button_Trigger_Edit.Enabled = False
        End If
    End Sub
    Private Sub Listbox_Outcomes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listbox_Outcomes.SelectedIndexChanged
        If Me.Listbox_Outcomes.SelectedIndex >= 0 Then
            Me.Button_Outcome_Delete.Enabled = True
            Me.Button_Outcome_Edit.Enabled = True
        Else
            Me.Button_Outcome_Delete.Enabled = False
            Me.Button_Outcome_Edit.Enabled = False
        End If
    End Sub

    Private Sub Button_Outcome_Edit_Click(sender As Object, e As EventArgs) Handles Button_Outcome_Edit.Click
        Dim NewForm = New OutcomesForm
        NewForm.Text = Me.Listbox_Outcomes.Items(Me.Listbox_Outcomes.SelectedIndex)
        NewForm.Show()
        Reload()
        Listbox_Outcomes_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button_Outcome_Add_Click(sender As Object, e As EventArgs) Handles Button_Outcome_Add.Click
        Dim Selected As String
        If Me.Listbox_Outcomes.SelectedIndex = -1 Then
            Selected = Str(Me.MainTextbox.Lines.GetLength(0) - 1) + "_" + Str(Me.MainTextbox.Lines.GetLength(0) - 1)
        Else
            Selected = Me.Listbox_Outcomes.Items(Me.Listbox_Outcomes.SelectedIndex).ToString()
        End If
        Dim Endline = Selected.Split(New Char() {"_"})(1)
        Dim Lines As List(Of String) = Me.MainTextbox.Lines.ToList()
        For i As Int16 = 1 To 100
            Lines.Add("")
        Next
        Lines.Insert(Endline + 2, "option_btn")
        Lines.Insert(Endline + 3, "name=")
        Lines.Insert(Endline + 4, "ai=" + Me.Textbox_OutcomeAI.Text)
        Lines.Insert(Endline + 5, "option_end")
        Lines.Insert(Endline + 6, "")
        For i As Integer = Lines.Count - 1 To 0 Step -1
            If Not String.IsNullOrWhiteSpace(Lines(i)) Then
                Exit For
            End If
            Lines.RemoveAt(i)
        Next
        Me.MainTextbox.Text = String.Join(Environment.NewLine(), Lines)
        Reload()
        Listbox_Outcomes_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Button_Outcome_Delete_Click(sender As Object, e As EventArgs) Handles Button_Outcome_Delete.Click
        Dim Selected = Listbox_Outcomes.Items(Listbox_Outcomes.SelectedIndex).ToString
        Dim Startline = Selected.Split(New Char() {"_"})(0)
        Dim Endline = Selected.Split(New Char() {"_"})(1) + 1
        Dim Lines = MainTextbox.Lines.ToList
        For i As Short = 1 To 100
            Lines.Add("")
        Next
        For Interval As Integer = Startline To Endline
            Lines.RemoveAt(Startline)
        Next
        For i = Lines.Count - 1 To 0 Step -1
            If Not String.IsNullOrWhiteSpace(Lines(i)) Then
                Exit For
            End If
            Lines.RemoveAt(i)
        Next
        MainTextbox.Text = String.Join(Environment.NewLine, Lines)
        Reload()
        Listbox_Outcomes_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Combobox_TriggerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combobox_TriggerType.SelectedIndexChanged

    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        MsgBox("原作者：Modemsorn158
汉化&修复bug：RedreamR", 0, "关于")
    End Sub
End Class
