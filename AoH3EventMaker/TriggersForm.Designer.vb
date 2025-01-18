<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TriggersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TriggersForm))
        Listbox_MainList = New ListBox()
        Button_Add = New Button()
        Button_Delete = New Button()
        Combobox_TriggerType = New ComboBox()
        Combobox_MainSelection = New ComboBox()
        Groupbox_Input1 = New GroupBox()
        Richtextbox_Desc1 = New RichTextBox()
        Textbox_Input1 = New TextBox()
        Groupbox_Input2 = New GroupBox()
        Richtextbox_Desc2 = New RichTextBox()
        Textbox_Input2 = New TextBox()
        Groupbox_Input3 = New GroupBox()
        Richtextbox_Desc3 = New RichTextBox()
        Textbox_Input3 = New TextBox()
        Groupbox_Input1.SuspendLayout()
        Groupbox_Input2.SuspendLayout()
        Groupbox_Input3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Listbox_MainList
        ' 
        Listbox_MainList.FormattingEnabled = True
        Listbox_MainList.ItemHeight = 15
        Listbox_MainList.Location = New Point(12, 12)
        Listbox_MainList.Name = "Listbox_MainList"
        Listbox_MainList.Size = New Size(256, 394)
        Listbox_MainList.TabIndex = 1
        ' 
        ' Button_Add
        ' 
        Button_Add.Location = New Point(12, 415)
        Button_Add.Name = "Button_Add"
        Button_Add.Size = New Size(75, 23)
        Button_Add.TabIndex = 2
        Button_Add.Text = "添加"
        Button_Add.UseVisualStyleBackColor = True
        ' 
        ' Button_Delete
        ' 
        Button_Delete.Enabled = False
        Button_Delete.Location = New Point(193, 415)
        Button_Delete.Name = "Button_Delete"
        Button_Delete.Size = New Size(75, 23)
        Button_Delete.TabIndex = 4
        Button_Delete.Text = "删除"
        Button_Delete.UseVisualStyleBackColor = True
        ' 
        ' Combobox_TriggerType
        ' 
        Combobox_TriggerType.DropDownStyle = ComboBoxStyle.DropDownList
        Combobox_TriggerType.FormattingEnabled = True
        Combobox_TriggerType.Items.AddRange(New Object() {"AND", "OR", "NOT"})
        Combobox_TriggerType.Location = New Point(93, 415)
        Combobox_TriggerType.Name = "Combobox_TriggerType"
        Combobox_TriggerType.Size = New Size(75, 23)
        Combobox_TriggerType.TabIndex = 3
        ' 
        ' Combobox_MainSelection
        ' 
        Combobox_MainSelection.DropDownStyle = ComboBoxStyle.DropDownList
        Combobox_MainSelection.FormattingEnabled = True
        Combobox_MainSelection.Items.AddRange(New Object() {"Variable =", "Variable !", "Economy Invest >", "Economy Invest <", "Growth Rate Increased >", "Growth Rate Increased <", "Tax Efficiency Increased >", "Tax Efficiency Increased <", "Manpower Increased >", "Manpower Increased <", "Infrastructure Developed >", "Infrastructure Developed <", "Total Buildings Constructed >", "Total Buildings Constructed <", "Administrative Buildings Constructed >", "Administrative Buildings Constructed <", "Economy Buildings Constructed >", "Economy Buildings Constructed <", "Military Buildings Constructed >", "Military Buildings Constructed <", "Unique Buildings Constructed >", "Unique Buildings Constructed <", "Conquered Provinces >", "Conquered Provinces <", "Wars >", "Wars <", "Player =", "Player !", "Religion =", "Religion !", "Goverment =", "Goverment !", "Provinces =", "Provinces >", "Provinces <", "Population >", "Population <", "Economy >", "Economy <", "Gold >", "Gold <", "Allies  >", "Allies <", "Defensive Pacts >", "Defensive Pacts <", "Non Argression Pacts >", "Non Argression Pacts <", "Vassals >", "Vassals <", "Neighbors >", "Neighbors <", "Random =", "Tag =", "Total Income >", "Total Income <", "Income Tax >", "Income Tax <", "Income Economy >", "Income Economy <", "Income Production >", "Income Production <", "Legacy/Month >", "Legacy/Month <", "Research/Month >", "Research/Month <", "Diplomacy Points >", "Diplomacy Points <", "Loans >", "Loans <", "Inflation >", "Infaltion <", "Legacy >", "Legacy <", "Legacies >", "Legacies <", "Technologies >", "Technologies <", "Advantages >", "Advantages <", "Rank >", "Rank <", "Prestige >", "Prestige <", "Resource =", "Resource >", "Production >", "Largest Producer >", "Largest Producer =", "Manpower >", "Manpower <", "Max Manpower >", "Max Manpower <", "Manpower Ratio >", "Manpower Ratio <", "Regiments >", "Regiments <", "Regiments Limit >", "Regiments Limit <", "Battle Width >", "Battle Width <", "Regiments Over Limit =", "Gold Over Max =", "Capital Buildings >", "Capital Buildings <", "Capital Tax Efficency >", "Capital Tax Efficency <", "Capital Economy >", "Capital Economy <", "Capital Manpower >", "Capital Manpower <", "Capital Growth Rate >", "Capital Growth Rate <", "Capital 基建 >", "Capital 基建 <", "Capital Population >", "Capital Population <", "Capital Fort >", "Capital Fort <", "Capital Income >", "Capital Income <", "Capital Unrest >", "Capital Unrest <", "Capital Religion =", "Capital Building =", "Capital Occupied =", "Capital Occupied !", "Capital Siege =", "Capital Continent =", "Capital Continent !", "Advisors >", "Advisors <", "Administrative Advisor Skill >", "Administrative Advisor Skill <", "Econimic Advisor Skill >", "Econimic Advisor Skill <", "Innovation Advisor Skill >", "Innovation Advisor Skill <", "Military Advisor Skill >", "Military Advisor Skill <", "Advisor Age >", "Advisor Production Efficency >", "Advisor Construction Cost >", "Military Academy >", "Military Academy <", "Gerneral Military Academy >", "Gerneral Military Academy <", "Capital >", "Capital <", "Court >", "Court <", "Reactor >", "Reactor <", "Tag Exists =", "Tag Exists !", "Any Tag Exists =", "Any Tag Exists !", "Puppet =", "Puppet !", "Puppet Tag =", "War =", "War !", "Wartime >", "Compare Provinces >", "Compare Population >", "Compare Economy >", "Compare Regiments Limit >", "Compare Regiments >", "Compare Ranking >", "Compare Technologies >", "Opinion >", "Opinion <", "Neighbors =", "Neighbors !", "Rivals =", "Rival =", "Rival !", "Wars =", "Wars !", "Defensive Pact =", "Non Argression Pact =", "Alliance =", "Truce =", "Military Access =", "Guarantee =", "Days >", "Days <", "Day =", "Year >", "Year <", "Random =", "Province =", "Province !", "Province Core =", "Province Economy >", "Province Economy <", "Province Growth Rate >", "Province Growth Rate <", "Province Population >", "Province Population <", "Province Tax Efficency >", "Province Tax Efficency <", "Province Manpower >", "Province Manpower <", "Province Income >", "Province Income <", "Province 基建 >", "Province 基建 <", "Province Occupied =", "Province Occupied !", "Province Siege =", "Province Buildings >", "Province Buildings <", "Province Buildings Limit >", "Province Buildings Limit <", "Province Defense >", "Province Defense <", "Province Capital =", "Province Building =", "HRE Leader =", "HRE Member =", "HRE Member !"})
        Combobox_MainSelection.Location = New Point(274, 12)
        Combobox_MainSelection.Name = "Combobox_MainSelection"
        Combobox_MainSelection.Size = New Size(514, 23)
        Combobox_MainSelection.TabIndex = 5
        ' 
        ' Groupbox_Input1
        ' 
        Groupbox_Input1.Controls.Add(Richtextbox_Desc1)
        Groupbox_Input1.Controls.Add(Textbox_Input1)
        Groupbox_Input1.Location = New Point(274, 62)
        Groupbox_Input1.Name = "Groupbox_Input1"
        Groupbox_Input1.Size = New Size(514, 100)
        Groupbox_Input1.TabIndex = 6
        Groupbox_Input1.TabStop = False
        Groupbox_Input1.Text = "参数 1"
        ' 
        ' Richtextbox_Desc1
        ' 
        Richtextbox_Desc1.Location = New Point(6, 51)
        Richtextbox_Desc1.Name = "Richtextbox_Desc1"
        Richtextbox_Desc1.ReadOnly = True
        Richtextbox_Desc1.Size = New Size(502, 43)
        Richtextbox_Desc1.TabIndex = 7
        Richtextbox_Desc1.Text = ""
        ' 
        ' Textbox_Input1
        ' 
        Textbox_Input1.Location = New Point(6, 22)
        Textbox_Input1.Name = "Textbox_Input1"
        Textbox_Input1.Size = New Size(502, 23)
        Textbox_Input1.TabIndex = 6
        ' 
        ' Groupbox_Input2
        ' 
        Groupbox_Input2.Controls.Add(Richtextbox_Desc2)
        Groupbox_Input2.Controls.Add(Textbox_Input2)
        Groupbox_Input2.Location = New Point(274, 168)
        Groupbox_Input2.Name = "Groupbox_Input2"
        Groupbox_Input2.Size = New Size(514, 100)
        Groupbox_Input2.TabIndex = 7
        Groupbox_Input2.TabStop = False
        Groupbox_Input2.Text = "参数 2"
        ' 
        ' Richtextbox_Desc2
        ' 
        Richtextbox_Desc2.Location = New Point(6, 51)
        Richtextbox_Desc2.Name = "Richtextbox_Desc2"
        Richtextbox_Desc2.ReadOnly = True
        Richtextbox_Desc2.Size = New Size(502, 43)
        Richtextbox_Desc2.TabIndex = 9
        Richtextbox_Desc2.Text = ""
        ' 
        ' Textbox_Input2
        ' 
        Textbox_Input2.Location = New Point(6, 22)
        Textbox_Input2.Name = "Textbox_Input2"
        Textbox_Input2.Size = New Size(502, 23)
        Textbox_Input2.TabIndex = 8
        ' 
        ' Groupbox_Input3
        ' 
        Groupbox_Input3.Controls.Add(Richtextbox_Desc3)
        Groupbox_Input3.Controls.Add(Textbox_Input3)
        Groupbox_Input3.Location = New Point(274, 274)
        Groupbox_Input3.Name = "Groupbox_Input3"
        Groupbox_Input3.Size = New Size(514, 100)
        Groupbox_Input3.TabIndex = 8
        Groupbox_Input3.TabStop = False
        Groupbox_Input3.Text = "参数 3"
        ' 
        ' Richtextbox_Desc3
        ' 
        Richtextbox_Desc3.Location = New Point(6, 51)
        Richtextbox_Desc3.Name = "Richtextbox_Desc3"
        Richtextbox_Desc3.ReadOnly = True
        Richtextbox_Desc3.Size = New Size(502, 43)
        Richtextbox_Desc3.TabIndex = 11
        Richtextbox_Desc3.Text = ""
        ' 
        ' Textbox_Input3
        ' 
        Textbox_Input3.Location = New Point(6, 22)
        Textbox_Input3.Name = "Textbox_Input3"
        Textbox_Input3.Size = New Size(502, 23)
        Textbox_Input3.TabIndex = 10
        ' 
        ' TriggersForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Groupbox_Input3)
        Controls.Add(Groupbox_Input2)
        Controls.Add(Groupbox_Input1)
        Controls.Add(Combobox_MainSelection)
        Controls.Add(Combobox_TriggerType)
        Controls.Add(Button_Delete)
        Controls.Add(Button_Add)
        Controls.Add(Listbox_MainList)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "TriggersForm"
        Text = "触发器"
        Groupbox_Input1.ResumeLayout(False)
        Groupbox_Input1.PerformLayout()
        Groupbox_Input2.ResumeLayout(False)
        Groupbox_Input2.PerformLayout()
        Groupbox_Input3.ResumeLayout(False)
        Groupbox_Input3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Listbox_MainList As ListBox
    Friend WithEvents Button_Add As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Combobox_TriggerType As ComboBox
    Friend WithEvents Combobox_MainSelection As ComboBox
    Friend WithEvents Groupbox_Input1 As GroupBox
    Friend WithEvents Richtextbox_Desc1 As RichTextBox
    Friend WithEvents Textbox_Input1 As TextBox
    Friend WithEvents Groupbox_Input2 As GroupBox
    Friend WithEvents Richtextbox_Desc2 As RichTextBox
    Friend WithEvents Textbox_Input2 As TextBox
    Friend WithEvents Groupbox_Input3 As GroupBox
    Friend WithEvents Richtextbox_Desc3 As RichTextBox
    Friend WithEvents Textbox_Input3 As TextBox
End Class
