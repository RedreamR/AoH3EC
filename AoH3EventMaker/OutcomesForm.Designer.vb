<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutcomesForm
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
        Groupbox_Input3 = New GroupBox()
        Richtextbox_Desc3 = New RichTextBox()
        Textbox_Input3 = New TextBox()
        Groupbox_Input2 = New GroupBox()
        Richtextbox_Desc2 = New RichTextBox()
        Textbox_Input2 = New TextBox()
        Groupbox_Input1 = New GroupBox()
        Richtextbox_Desc1 = New RichTextBox()
        Textbox_Input1 = New TextBox()
        Combobox_MainSelection = New ComboBox()
        Button_Delete = New Button()
        Button_Add = New Button()
        Listbox_MainList = New ListBox()
        Label_Name = New Label()
        Textbox_Name = New TextBox()
        Groupbox_Input3.SuspendLayout()
        Groupbox_Input2.SuspendLayout()
        Groupbox_Input1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Groupbox_Input3
        ' 
        Groupbox_Input3.Controls.Add(Richtextbox_Desc3)
        Groupbox_Input3.Controls.Add(Textbox_Input3)
        Groupbox_Input3.Location = New Point(274, 274)
        Groupbox_Input3.Name = "Groupbox_Input3"
        Groupbox_Input3.Size = New Size(514, 100)
        Groupbox_Input3.TabIndex = 16
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
        ' Groupbox_Input2
        ' 
        Groupbox_Input2.Controls.Add(Richtextbox_Desc2)
        Groupbox_Input2.Controls.Add(Textbox_Input2)
        Groupbox_Input2.Location = New Point(274, 168)
        Groupbox_Input2.Name = "Groupbox_Input2"
        Groupbox_Input2.Size = New Size(514, 100)
        Groupbox_Input2.TabIndex = 15
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
        ' Groupbox_Input1
        ' 
        Groupbox_Input1.Controls.Add(Richtextbox_Desc1)
        Groupbox_Input1.Controls.Add(Textbox_Input1)
        Groupbox_Input1.Location = New Point(274, 62)
        Groupbox_Input1.Name = "Groupbox_Input1"
        Groupbox_Input1.Size = New Size(514, 100)
        Groupbox_Input1.TabIndex = 14
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
        ' Combobox_MainSelection
        ' 
        Combobox_MainSelection.DropDownStyle = ComboBoxStyle.DropDownList
        Combobox_MainSelection.FormattingEnabled = True
        Combobox_MainSelection.Items.AddRange(New Object() {"播放音乐", "增加黄金", "增加每月黄金收入", "遗产 +", "每月遗产增加 +", "玩家游玩文明 =", "研究 +", "优势点数 +", "人力 +", "通货膨胀 +", "AI侵略度 =", "侵略扩张 =", "首都", "宣战", "结成同盟", "签订互不侵犯条约", "添加军事通行权", "保证独立", "签订防御条约", "新增和约", "改变政体", "改变宗教", "吞并", "吞并，若省份被某文明控制", "吞并文明", "被完全吞并", "新增附庸", "设置文明Tag", "运行事件", "添加随机将军", "新增将军", "新增随机顾问", "新增顾问", "更换统治者", "设置随机省份经济", "设置首都经济", "设置文明经济", "设置省份经济", "设置随机省份的税收率", "设置首都的税收率", "设置文明的税收率", "设置省份的税收率", "设置随机省份的人力", "省份 人力 首都", "省份 人力 全部=", "省份 人力 ID =", "省份 增长率 =", "省份 增长率 首都", "省份 增长率 全部=", "省份 增长率 ID =", "省份 人口 =", "省份 人口 首都", "省份 人口 全部=", "省份 人口 ID =", "省份 改变宗教", "省份 Religion 首都", "省份 Religion 全部=", "省份 Religion ID =", "省份 荒废度 =", "省份 荒废度 首都", "省份 荒废度 全部=", "省份 荒废度 ID =", "省份 Unrest =", "省份 Unrest 首都", "省份 Unrest 全部=", "省份 Unrest ID =", "省份 基建 =", "省份 基建 首都", "省份 基建 全部=", "省份 基建 ID =", "添加核心", "移除核心", "新建军队", "添加变量", "增益 有效期 =", "增益 Monthly Income =", "增益 Monthly Legacy =", "增益 Monthly Legacy % =", "增益 Maximum Gold =", "增益 税收率 =", "增益 增长率 =", "增益 省份 Maintenance =", "增益 Buildings 维护费用  =", "增益 Production Efficency =", "增益 Income Production =", "增益 Income Taxation =", "增益 Income 经济 =", "增益 Corruption =", "增益 Inflation =", "增益 Research =", "增益 Research Points =", "增益 Max 人力 =", "增益 Max 人力 % =", "增益 人力 Recovery Speed =", "增益 Reinforcement Speed =", "增益 Army Morale Recovery =", "增益 Army Maintenance =", "增益 Recruitment Time =", "增益 Recruit Cost =", "增益 Recruit Cost First Line =", "增益 Recruit Cost Second Line =", "增益 Generals 攻击 =", "增益 Generals 防御 =", "增益 Units 攻击 =", "增益 Units 防御 =", "增益 Regiments Limit =", "增益 Battle Width =", "增益 Discipline =", "增益 Siege Effectiveness =", "增益 Max Morale =", "增益 Army Speed =", "增益 人力 Recovery From Disbanding =", "增益 War Score =", "增益 Construction Cost =", "增益 Administration Building Cost =", "增益 Military Building Cost =", "增益 经济 Building Cost =", "增益 Construction Time =", "增益 Invest Cost =", "增益 人力 Cost =", "增益 税收率 Cost =", "增益 基建 Cost =", "增益 增长率 Cost =", "增益 Diplomacy Points =", "增益 Relations Modifier =", "增益 Vassals Income =", "增益 Agressive Expansion =", "增益 Core Cost =", "增益 Religion Cost =", "增益 Revolution Risk =", "增益 Loan Interest =", "增益 Loan Limit =", "增益 Characters Age =", "增益 Advisors Cost =", "增益 Advisors Max Levels =", "增益 General Cost =", "增益 Disease Death Rate =", "Join HRE First Tier =", "Join HRE Second Tier =", "Leave HRE =", "Kill Ruler =", "Kill Advisor =", "Promote Advisor =", "Military Academy +", "Military Academy General +", "Capital City +", "Court +", "Reactor +", "Explode =", "Price +", "Price -", "Price Group +", "Price Group -"})
        Combobox_MainSelection.Location = New Point(274, 12)
        Combobox_MainSelection.Name = "Combobox_MainSelection"
        Combobox_MainSelection.Size = New Size(514, 23)
        Combobox_MainSelection.TabIndex = 13
        ' 
        ' Button_Delete
        ' 
        Button_Delete.Enabled = False
        Button_Delete.Location = New Point(193, 415)
        Button_Delete.Name = "Button_Delete"
        Button_Delete.Size = New Size(75, 23)
        Button_Delete.TabIndex = 12
        Button_Delete.Text = "删除"
        Button_Delete.UseVisualStyleBackColor = True
        ' 
        ' Button_Add
        ' 
        Button_Add.Location = New Point(12, 415)
        Button_Add.Name = "Button_Add"
        Button_Add.Size = New Size(75, 23)
        Button_Add.TabIndex = 10
        Button_Add.Text = "添加"
        Button_Add.UseVisualStyleBackColor = True
        ' 
        ' Listbox_MainList
        ' 
        Listbox_MainList.FormattingEnabled = True
        Listbox_MainList.ItemHeight = 15
        Listbox_MainList.Location = New Point(12, 12)
        Listbox_MainList.Name = "Listbox_MainList"
        Listbox_MainList.Size = New Size(256, 394)
        Listbox_MainList.TabIndex = 9
        ' 
        ' Label_Name
        ' 
        Label_Name.AutoSize = True
        Label_Name.Location = New Point(280, 391)
        Label_Name.Name = "Label_Name"
        Label_Name.Size = New Size(39, 15)
        Label_Name.TabIndex = 17
        Label_Name.Text = "按钮名"
        ' 
        ' Textbox_Name
        ' 
        Textbox_Name.Location = New Point(325, 388)
        Textbox_Name.Name = "Textbox_Name"
        Textbox_Name.Size = New Size(463, 23)
        Textbox_Name.TabIndex = 12
        ' 
        ' OutcomesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Textbox_Name)
        Controls.Add(Label_Name)
        Controls.Add(Groupbox_Input3)
        Controls.Add(Groupbox_Input2)
        Controls.Add(Groupbox_Input1)
        Controls.Add(Combobox_MainSelection)
        Controls.Add(Button_Delete)
        Controls.Add(Button_Add)
        Controls.Add(Listbox_MainList)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "OutcomesForm"
        Text = "决议"
        Groupbox_Input3.ResumeLayout(False)
        Groupbox_Input3.PerformLayout()
        Groupbox_Input2.ResumeLayout(False)
        Groupbox_Input2.PerformLayout()
        Groupbox_Input1.ResumeLayout(False)
        Groupbox_Input1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Groupbox_Input3 As GroupBox
    Friend WithEvents Richtextbox_Desc3 As RichTextBox
    Friend WithEvents Textbox_Input3 As TextBox
    Friend WithEvents Groupbox_Input2 As GroupBox
    Friend WithEvents Richtextbox_Desc2 As RichTextBox
    Friend WithEvents Textbox_Input2 As TextBox
    Friend WithEvents Groupbox_Input1 As GroupBox
    Friend WithEvents Richtextbox_Desc1 As RichTextBox
    Friend WithEvents Textbox_Input1 As TextBox
    Friend WithEvents Combobox_MainSelection As ComboBox
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Add As Button
    Friend WithEvents Listbox_MainList As ListBox
    Friend WithEvents Label_Name As Label
    Friend WithEvents Textbox_Name As TextBox
End Class
