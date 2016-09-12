<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

  'Requise par le Concepteur Windows Form
  Private components As System.ComponentModel.IContainer

  'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
  'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
  'Ne la modifiez pas à l'aide de l'éditeur de code.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
    Me.ui_Version = New System.Windows.Forms.Label()
    Me.label4 = New System.Windows.Forms.Label()
    Me.label3 = New System.Windows.Forms.Label()
    Me.ui_WebsiteLink = New System.Windows.Forms.LinkLabel()
    Me.label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'ui_Version
    '
    Me.ui_Version.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.ui_Version.Location = New System.Drawing.Point(84, 44)
    Me.ui_Version.Name = "ui_Version"
    Me.ui_Version.Size = New System.Drawing.Size(186, 23)
    Me.ui_Version.TabIndex = 12
    Me.ui_Version.Text = "version"
    Me.ui_Version.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'label4
    '
    Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label4.Location = New System.Drawing.Point(24, 17)
    Me.label4.Name = "label4"
    Me.label4.Size = New System.Drawing.Size(307, 24)
    Me.label4.TabIndex = 11
    Me.label4.Text = "Regex.Net"
    Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'label3
    '
    Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.label3.AutoSize = True
    Me.label3.Location = New System.Drawing.Point(127, 71)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(100, 13)
    Me.label3.TabIndex = 10
    Me.label3.Text = "Website at GitHub :"
    '
    'ui_WebsiteLink
    '
    Me.ui_WebsiteLink.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.ui_WebsiteLink.Location = New System.Drawing.Point(12, 88)
    Me.ui_WebsiteLink.Name = "ui_WebsiteLink"
    Me.ui_WebsiteLink.Size = New System.Drawing.Size(331, 13)
    Me.ui_WebsiteLink.TabIndex = 9
    Me.ui_WebsiteLink.TabStop = True
    Me.ui_WebsiteLink.Text = "https://github.com/nquenault/regex.net"
    Me.ui_WebsiteLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'label1
    '
    Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(112, 127)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(130, 13)
    Me.label1.TabIndex = 7
    Me.label1.Text = "Code by Nicolas Quenault"
    '
    'About
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(355, 161)
    Me.Controls.Add(Me.ui_Version)
    Me.Controls.Add(Me.label4)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.ui_WebsiteLink)
    Me.Controls.Add(Me.label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "About"
    Me.Text = "About"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents ui_Version As System.Windows.Forms.Label
  Private WithEvents label4 As System.Windows.Forms.Label
  Private WithEvents label3 As System.Windows.Forms.Label
  Private WithEvents ui_WebsiteLink As System.Windows.Forms.LinkLabel
  Private WithEvents label1 As System.Windows.Forms.Label
End Class
