<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        MainToolbar = New ToolStrip()
        Button_File = New ToolStripDropDownButton()
        Button_File_New = New ToolStripMenuItem()
        Button_File_Save = New ToolStripMenuItem()
        Button_File_Open = New ToolStripMenuItem()
        MainTextbox = New RichTextBox()
        OpenHandler = New OpenFileDialog()
        SaveHandler = New SaveFileDialog()
        Label_Title = New Label()
        Textbox_Title = New TextBox()
        Label_ID = New Label()
        Textbox_ID = New TextBox()
        Textbox_Desc = New TextBox()
        Label_Desc = New Label()
        Checkbox_Mission = New CheckBox()
        Button_Mission = New Button()
        Checkbox_Once = New CheckBox()
        Label_Image = New Label()
        Textbox_Image = New TextBox()
        Groupbox_Information = New GroupBox()
        Checkbox_Popup = New CheckBox()
        Groupbox_Triggers = New GroupBox()
        Combobox_TriggerType = New ComboBox()
        Button_Trigger_Delete = New Button()
        Button_Trigger_Add = New Button()
        Button_Trigger_Edit = New Button()
        Listbox_Triggers = New ListBox()
        Groupbox_Outcomes = New GroupBox()
        Textbox_OutcomeAI = New TextBox()
        Button_Outcome_Delete = New Button()
        Button_Outcome_Add = New Button()
        Button_Outcome_Edit = New Button()
        Listbox_Outcomes = New ListBox()
        MainToolbar.SuspendLayout()
        Groupbox_Information.SuspendLayout()
        Groupbox_Triggers.SuspendLayout()
        Groupbox_Outcomes.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainToolbar
        ' 
        MainToolbar.Items.AddRange(New ToolStripItem() {Button_File})
        MainToolbar.Location = New Point(0, 0)
        MainToolbar.Name = "MainToolbar"
        MainToolbar.Size = New Size(984, 25)
        MainToolbar.TabIndex = 0
        MainToolbar.Text = "ToolStrip1"
        ' 
        ' Button_File
        ' 
        Button_File.DisplayStyle = ToolStripItemDisplayStyle.Text
        Button_File.DropDownItems.AddRange(New ToolStripItem() {Button_File_New, Button_File_Save, Button_File_Open})
        Button_File.ImageTransparentColor = Color.Magenta
        Button_File.Name = "Button_File"
        Button_File.Size = New Size(38, 22)
        Button_File.Text = "File"
        ' 
        ' Button_File_New
        ' 
        Button_File_New.Name = "Button_File_New"
        Button_File_New.Size = New Size(103, 22)
        Button_File_New.Text = "New"
        ' 
        ' Button_File_Save
        ' 
        Button_File_Save.Name = "Button_File_Save"
        Button_File_Save.Size = New Size(103, 22)
        Button_File_Save.Text = "Save"
        ' 
        ' Button_File_Open
        ' 
        Button_File_Open.Name = "Button_File_Open"
        Button_File_Open.Size = New Size(103, 22)
        Button_File_Open.Text = "Open"
        ' 
        ' MainTextbox
        ' 
        MainTextbox.Location = New Point(12, 28)
        MainTextbox.Name = "MainTextbox"
        MainTextbox.Size = New Size(467, 494)
        MainTextbox.TabIndex = 1
        MainTextbox.Text = ""
        ' 
        ' OpenHandler
        ' 
        OpenHandler.Filter = "Event Files|*.txt"
        ' 
        ' SaveHandler
        ' 
        SaveHandler.Filter = "Event Files|*.txt"
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 15F)
        Label_Title.Location = New Point(6, 47)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(49, 28)
        Label_Title.TabIndex = 2
        Label_Title.Text = "Title"
        ' 
        ' Textbox_Title
        ' 
        Textbox_Title.Location = New Point(106, 52)
        Textbox_Title.Name = "Textbox_Title"
        Textbox_Title.Size = New Size(377, 23)
        Textbox_Title.TabIndex = 2
        ' 
        ' Label_ID
        ' 
        Label_ID.AutoSize = True
        Label_ID.Font = New Font("Segoe UI", 15F)
        Label_ID.Location = New Point(6, 19)
        Label_ID.Name = "Label_ID"
        Label_ID.Size = New Size(31, 28)
        Label_ID.TabIndex = 4
        Label_ID.Text = "ID"
        ' 
        ' Textbox_ID
        ' 
        Textbox_ID.Location = New Point(106, 24)
        Textbox_ID.Name = "Textbox_ID"
        Textbox_ID.Size = New Size(377, 23)
        Textbox_ID.TabIndex = 1
        ' 
        ' Textbox_Desc
        ' 
        Textbox_Desc.Location = New Point(106, 81)
        Textbox_Desc.Name = "Textbox_Desc"
        Textbox_Desc.Size = New Size(377, 23)
        Textbox_Desc.TabIndex = 3
        ' 
        ' Label_Desc
        ' 
        Label_Desc.AutoSize = True
        Label_Desc.Font = New Font("Segoe UI", 15F)
        Label_Desc.Location = New Point(6, 75)
        Label_Desc.Name = "Label_Desc"
        Label_Desc.Size = New Size(53, 28)
        Label_Desc.TabIndex = 6
        Label_Desc.Text = "Desc"
        ' 
        ' Checkbox_Mission
        ' 
        Checkbox_Mission.AutoSize = True
        Checkbox_Mission.Location = New Point(6, 145)
        Checkbox_Mission.Name = "Checkbox_Mission"
        Checkbox_Mission.Size = New Size(72, 19)
        Checkbox_Mission.TabIndex = 4
        Checkbox_Mission.Text = "Mission?"
        Checkbox_Mission.UseVisualStyleBackColor = True
        ' 
        ' Button_Mission
        ' 
        Button_Mission.Enabled = False
        Button_Mission.Location = New Point(106, 142)
        Button_Mission.Name = "Button_Mission"
        Button_Mission.Size = New Size(221, 23)
        Button_Mission.TabIndex = 5
        Button_Mission.Text = "Modify Mission"
        Button_Mission.UseVisualStyleBackColor = True
        ' 
        ' Checkbox_Once
        ' 
        Checkbox_Once.AutoSize = True
        Checkbox_Once.Location = New Point(349, 146)
        Checkbox_Once.Name = "Checkbox_Once"
        Checkbox_Once.Size = New Size(59, 19)
        Checkbox_Once.TabIndex = 6
        Checkbox_Once.Text = "Once?"
        Checkbox_Once.UseVisualStyleBackColor = True
        ' 
        ' Label_Image
        ' 
        Label_Image.AutoSize = True
        Label_Image.Font = New Font("Segoe UI", 15F)
        Label_Image.Location = New Point(6, 108)
        Label_Image.Name = "Label_Image"
        Label_Image.Size = New Size(66, 28)
        Label_Image.TabIndex = 11
        Label_Image.Text = "Image"
        ' 
        ' Textbox_Image
        ' 
        Textbox_Image.Location = New Point(106, 113)
        Textbox_Image.Name = "Textbox_Image"
        Textbox_Image.Size = New Size(377, 23)
        Textbox_Image.TabIndex = 4
        ' 
        ' Groupbox_Information
        ' 
        Groupbox_Information.Controls.Add(Checkbox_Popup)
        Groupbox_Information.Controls.Add(Label_ID)
        Groupbox_Information.Controls.Add(Button_Mission)
        Groupbox_Information.Controls.Add(Textbox_Image)
        Groupbox_Information.Controls.Add(Checkbox_Mission)
        Groupbox_Information.Controls.Add(Label_Title)
        Groupbox_Information.Controls.Add(Label_Image)
        Groupbox_Information.Controls.Add(Textbox_Title)
        Groupbox_Information.Controls.Add(Checkbox_Once)
        Groupbox_Information.Controls.Add(Textbox_ID)
        Groupbox_Information.Controls.Add(Label_Desc)
        Groupbox_Information.Controls.Add(Textbox_Desc)
        Groupbox_Information.Location = New Point(485, 28)
        Groupbox_Information.Name = "Groupbox_Information"
        Groupbox_Information.Size = New Size(487, 174)
        Groupbox_Information.TabIndex = 13
        Groupbox_Information.TabStop = False
        Groupbox_Information.Text = "Information"
        ' 
        ' Checkbox_Popup
        ' 
        Checkbox_Popup.AutoSize = True
        Checkbox_Popup.Location = New Point(414, 145)
        Checkbox_Popup.Name = "Checkbox_Popup"
        Checkbox_Popup.Size = New Size(67, 19)
        Checkbox_Popup.TabIndex = 7
        Checkbox_Popup.Text = "PopUp?"
        Checkbox_Popup.UseVisualStyleBackColor = True
        ' 
        ' Groupbox_Triggers
        ' 
        Groupbox_Triggers.Controls.Add(Combobox_TriggerType)
        Groupbox_Triggers.Controls.Add(Button_Trigger_Delete)
        Groupbox_Triggers.Controls.Add(Button_Trigger_Add)
        Groupbox_Triggers.Controls.Add(Button_Trigger_Edit)
        Groupbox_Triggers.Controls.Add(Listbox_Triggers)
        Groupbox_Triggers.Location = New Point(485, 208)
        Groupbox_Triggers.Name = "Groupbox_Triggers"
        Groupbox_Triggers.Size = New Size(483, 154)
        Groupbox_Triggers.TabIndex = 14
        Groupbox_Triggers.TabStop = False
        Groupbox_Triggers.Text = "Triggers"
        ' 
        ' Combobox_TriggerType
        ' 
        Combobox_TriggerType.DropDownStyle = ComboBoxStyle.DropDownList
        Combobox_TriggerType.FormattingEnabled = True
        Combobox_TriggerType.Items.AddRange(New Object() {"AND", "OR", "NOT"})
        Combobox_TriggerType.Location = New Point(402, 80)
        Combobox_TriggerType.Name = "Combobox_TriggerType"
        Combobox_TriggerType.Size = New Size(75, 23)
        Combobox_TriggerType.TabIndex = 11
        ' 
        ' Button_Trigger_Delete
        ' 
        Button_Trigger_Delete.Enabled = False
        Button_Trigger_Delete.Location = New Point(402, 123)
        Button_Trigger_Delete.Name = "Button_Trigger_Delete"
        Button_Trigger_Delete.Size = New Size(75, 23)
        Button_Trigger_Delete.TabIndex = 12
        Button_Trigger_Delete.Text = "Delete"
        Button_Trigger_Delete.UseVisualStyleBackColor = True
        ' 
        ' Button_Trigger_Add
        ' 
        Button_Trigger_Add.Location = New Point(402, 51)
        Button_Trigger_Add.Name = "Button_Trigger_Add"
        Button_Trigger_Add.Size = New Size(75, 23)
        Button_Trigger_Add.TabIndex = 10
        Button_Trigger_Add.Text = "Add"
        Button_Trigger_Add.UseVisualStyleBackColor = True
        ' 
        ' Button_Trigger_Edit
        ' 
        Button_Trigger_Edit.Enabled = False
        Button_Trigger_Edit.Location = New Point(402, 22)
        Button_Trigger_Edit.Name = "Button_Trigger_Edit"
        Button_Trigger_Edit.Size = New Size(75, 23)
        Button_Trigger_Edit.TabIndex = 9
        Button_Trigger_Edit.Text = "Edit"
        Button_Trigger_Edit.UseVisualStyleBackColor = True
        ' 
        ' Listbox_Triggers
        ' 
        Listbox_Triggers.FormattingEnabled = True
        Listbox_Triggers.ItemHeight = 15
        Listbox_Triggers.Location = New Point(6, 22)
        Listbox_Triggers.Name = "Listbox_Triggers"
        Listbox_Triggers.Size = New Size(382, 124)
        Listbox_Triggers.TabIndex = 8
        ' 
        ' Groupbox_Outcomes
        ' 
        Groupbox_Outcomes.Controls.Add(Textbox_OutcomeAI)
        Groupbox_Outcomes.Controls.Add(Button_Outcome_Delete)
        Groupbox_Outcomes.Controls.Add(Button_Outcome_Add)
        Groupbox_Outcomes.Controls.Add(Button_Outcome_Edit)
        Groupbox_Outcomes.Controls.Add(Listbox_Outcomes)
        Groupbox_Outcomes.Location = New Point(485, 368)
        Groupbox_Outcomes.Name = "Groupbox_Outcomes"
        Groupbox_Outcomes.Size = New Size(483, 154)
        Groupbox_Outcomes.TabIndex = 15
        Groupbox_Outcomes.TabStop = False
        Groupbox_Outcomes.Text = "Outcomes"
        ' 
        ' Textbox_OutcomeAI
        ' 
        Textbox_OutcomeAI.Location = New Point(405, 80)
        Textbox_OutcomeAI.Name = "Textbox_OutcomeAI"
        Textbox_OutcomeAI.PlaceholderText = "AI"
        Textbox_OutcomeAI.Size = New Size(72, 23)
        Textbox_OutcomeAI.TabIndex = 16
        Textbox_OutcomeAI.Text = "1"
        ' 
        ' Button_Outcome_Delete
        ' 
        Button_Outcome_Delete.Enabled = False
        Button_Outcome_Delete.Location = New Point(402, 123)
        Button_Outcome_Delete.Name = "Button_Outcome_Delete"
        Button_Outcome_Delete.Size = New Size(75, 23)
        Button_Outcome_Delete.TabIndex = 17
        Button_Outcome_Delete.Text = "Delete"
        Button_Outcome_Delete.UseVisualStyleBackColor = True
        ' 
        ' Button_Outcome_Add
        ' 
        Button_Outcome_Add.Location = New Point(402, 51)
        Button_Outcome_Add.Name = "Button_Outcome_Add"
        Button_Outcome_Add.Size = New Size(75, 23)
        Button_Outcome_Add.TabIndex = 15
        Button_Outcome_Add.Text = "Add"
        Button_Outcome_Add.UseVisualStyleBackColor = True
        ' 
        ' Button_Outcome_Edit
        ' 
        Button_Outcome_Edit.Enabled = False
        Button_Outcome_Edit.Location = New Point(402, 22)
        Button_Outcome_Edit.Name = "Button_Outcome_Edit"
        Button_Outcome_Edit.Size = New Size(75, 23)
        Button_Outcome_Edit.TabIndex = 14
        Button_Outcome_Edit.Text = "Edit"
        Button_Outcome_Edit.UseVisualStyleBackColor = True
        ' 
        ' Listbox_Outcomes
        ' 
        Listbox_Outcomes.FormattingEnabled = True
        Listbox_Outcomes.ItemHeight = 15
        Listbox_Outcomes.Location = New Point(6, 22)
        Listbox_Outcomes.Name = "Listbox_Outcomes"
        Listbox_Outcomes.Size = New Size(382, 124)
        Listbox_Outcomes.TabIndex = 13
        ' 
        ' StartForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 527)
        Controls.Add(Groupbox_Outcomes)
        Controls.Add(Groupbox_Triggers)
        Controls.Add(Groupbox_Information)
        Controls.Add(MainTextbox)
        Controls.Add(MainToolbar)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "StartForm"
        Text = "Age of History 3 - Event Creator"
        MainToolbar.ResumeLayout(False)
        MainToolbar.PerformLayout()
        Groupbox_Information.ResumeLayout(False)
        Groupbox_Information.PerformLayout()
        Groupbox_Triggers.ResumeLayout(False)
        Groupbox_Outcomes.ResumeLayout(False)
        Groupbox_Outcomes.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainToolbar As ToolStrip
    Friend WithEvents Button_File As ToolStripDropDownButton
    Friend WithEvents Button_File_New As ToolStripMenuItem
    Friend WithEvents Button_File_Save As ToolStripMenuItem
    Friend WithEvents Button_File_SaveAs As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainTextbox As RichTextBox
    Friend WithEvents Button_File_Open As ToolStripMenuItem
    Friend WithEvents OpenHandler As OpenFileDialog
    Friend WithEvents SaveHandler As SaveFileDialog
    Friend WithEvents Label_Title As Label
    Friend WithEvents Textbox_Title As TextBox
    Friend WithEvents Label_ID As Label
    Friend WithEvents Textbox_ID As TextBox
    Friend WithEvents Textbox_Desc As TextBox
    Friend WithEvents Label_Desc As Label
    Friend WithEvents Checkbox_Mission As CheckBox
    Friend WithEvents Button_Mission As Button
    Friend WithEvents Checkbox_Once As CheckBox
    Friend WithEvents Label_Image As Label
    Friend WithEvents Textbox_Image As TextBox
    Friend WithEvents Groupbox_Information As GroupBox
    Friend WithEvents Groupbox_Triggers As GroupBox
    Friend WithEvents Listbox_Triggers As ListBox
    Friend WithEvents Button_Trigger_Add As Button
    Friend WithEvents Button_Trigger_Edit As Button
    Friend WithEvents Button_Trigger_Delete As Button
    Friend WithEvents Combobox_TriggerType As ComboBox
    Friend WithEvents Checkbox_Popup As CheckBox
    Friend WithEvents Groupbox_Outcomes As GroupBox
    Friend WithEvents Button_Outcome_Delete As Button
    Friend WithEvents Button_Outcome_Add As Button
    Friend WithEvents Button_Outcome_Edit As Button
    Friend WithEvents Listbox_Outcomes As ListBox
    Friend WithEvents Textbox_OutcomeAI As TextBox

End Class
