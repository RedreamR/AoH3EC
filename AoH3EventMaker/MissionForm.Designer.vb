<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MissionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MissionForm))
        Button_Done = New Button()
        Label_MissionDesc = New Label()
        Textbox_MissionDesc = New RichTextBox()
        Label_Image = New Label()
        Textbox_Image = New TextBox()
        SuspendLayout()
        ' 
        ' Button_Done
        ' 
        Button_Done.Location = New Point(12, 172)
        Button_Done.Name = "Button_Done"
        Button_Done.Size = New Size(556, 23)
        Button_Done.TabIndex = 0
        Button_Done.Text = "完成"
        Button_Done.UseVisualStyleBackColor = True
        ' 
        ' Label_MissionDesc
        ' 
        Label_MissionDesc.AutoSize = True
        Label_MissionDesc.Location = New Point(12, 9)
        Label_MissionDesc.Name = "Label_MissionDesc"
        Label_MissionDesc.Size = New Size(67, 15)
        Label_MissionDesc.TabIndex = 1
        Label_MissionDesc.Text = "描述"
        ' 
        ' Textbox_MissionDesc
        ' 
        Textbox_MissionDesc.Location = New Point(12, 27)
        Textbox_MissionDesc.Multiline = False
        Textbox_MissionDesc.Name = "Textbox_MissionDesc"
        Textbox_MissionDesc.Size = New Size(556, 104)
        Textbox_MissionDesc.TabIndex = 2
        Textbox_MissionDesc.Text = ""
        ' 
        ' Label_Image
        ' 
        Label_Image.AutoSize = True
        Label_Image.Location = New Point(12, 146)
        Label_Image.Name = "Label_Image"
        Label_Image.Size = New Size(40, 15)
        Label_Image.TabIndex = 3
        Label_Image.Text = "图片"
        ' 
        ' Textbox_Image
        ' 
        Textbox_Image.Location = New Point(58, 143)
        Textbox_Image.Name = "Textbox_Image"
        Textbox_Image.Size = New Size(510, 23)
        Textbox_Image.TabIndex = 4
        ' 
        ' MissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(580, 207)
        Controls.Add(Textbox_Image)
        Controls.Add(Label_Image)
        Controls.Add(Textbox_MissionDesc)
        Controls.Add(Label_MissionDesc)
        Controls.Add(Button_Done)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MissionForm"
        Text = "任务"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_Done As Button
    Friend WithEvents Label_MissionDesc As Label
    Friend WithEvents Textbox_MissionDesc As RichTextBox
    Friend WithEvents Label_Image As Label
    Friend WithEvents Textbox_Image As TextBox
End Class
