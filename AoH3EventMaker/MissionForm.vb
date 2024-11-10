Public Class MissionForm

    Function FindAndReplace(Text As String, Value As String)
        Dim Interval As Int16 = 0
        For Each Line In StartForm.MainTextbox.Lines
            If Line.Split(New Char() {"="})(0) = Text Then
                Dim NewLine = Text + "=" + Value
                Dim Lines = StartForm.MainTextbox.Lines
                Lines(Interval) = NewLine
                StartForm.MainTextbox.Lines = Lines
                Return NewLine
            End If
            Interval += 1
        Next
        Return Nothing
    End Function

    Private Sub MissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Done_Click(sender As Object, e As EventArgs) Handles Button_Done.Click
        FindAndReplace("mission_desc", Me.Textbox_MissionDesc.Text)
        FindAndReplace("mission_image", Me.Textbox_Image.Text + ".png")
        Me.Hide()
    End Sub
End Class