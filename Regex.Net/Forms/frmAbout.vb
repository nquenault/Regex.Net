Public Class frmAbout
  Private Shared ReadOnly Property CurrentVersion As System.Version
    Get
      Return My.Application.Info.Version
    End Get
  End Property

  Private Shared ReadOnly Property VersionString As String
    Get
      Dim v As String = CurrentVersion.Major.ToString() & "." & CurrentVersion.Minor.ToString()

      If CurrentVersion.Build <> 0 Then
        v &= "." & CurrentVersion.Build.ToString()
      End If

      If CurrentVersion.Revision <> 0 Then
        v &= "." & CurrentVersion.Revision.ToString()
      End If

      Return v
    End Get
  End Property

  Public Sub New()
    InitializeComponent()

    ui_Version.Text = "version " & VersionString
  End Sub

  Private Sub ui_WebsiteLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ui_WebsiteLink.LinkClicked
    Process.Start(ui_WebsiteLink.Text)
  End Sub
End Class