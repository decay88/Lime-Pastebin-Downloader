<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ChTheme1 = New Lime_Downloader.CHTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChTextbox1 = New Lime_Downloader.CHTextbox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ChControlbutton1 = New Lime_Downloader.CHControlbutton()
        Me.ChTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChTheme1
        '
        Me.ChTheme1.BackColor = System.Drawing.Color.Black
        Me.ChTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ChTheme1.Controls.Add(Me.Label1)
        Me.ChTheme1.Controls.Add(Me.ChTextbox1)
        Me.ChTheme1.Controls.Add(Me.RichTextBox1)
        Me.ChTheme1.Controls.Add(Me.ChControlbutton1)
        Me.ChTheme1.Customization = "FxcX/wD/AP8="
        Me.ChTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ChTheme1.Image = Nothing
        Me.ChTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ChTheme1.Movable = True
        Me.ChTheme1.Name = "ChTheme1"
        Me.ChTheme1.NoRounding = True
        Me.ChTheme1.Sizable = False
        Me.ChTheme1.Size = New System.Drawing.Size(549, 244)
        Me.ChTheme1.SmartBounds = True
        Me.ChTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ChTheme1.TabIndex = 1
        Me.ChTheme1.Text = "Lime Pastebin Downloader v1"
        Me.ChTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChTheme1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pastebin Developer API Key"
        '
        'ChTextbox1
        '
        Me.ChTextbox1.BackColor = System.Drawing.Color.Transparent
        Me.ChTextbox1.Colors = New Lime_Downloader.Bloom(-1) {}
        Me.ChTextbox1.Customization = ""
        Me.ChTextbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Lime_Downloader.My.MySettings.Default, "API", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChTextbox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ChTextbox1.Image = Nothing
        Me.ChTextbox1.Location = New System.Drawing.Point(17, 90)
        Me.ChTextbox1.MaxCharacters = 0
        Me.ChTextbox1.Name = "ChTextbox1"
        Me.ChTextbox1.NoRounding = False
        Me.ChTextbox1.Size = New System.Drawing.Size(514, 25)
        Me.ChTextbox1.TabIndex = 4
        Me.ChTextbox1.Text = Global.Lime_Downloader.My.MySettings.Default.API
        Me.ChTextbox1.Transparent = True
        Me.ChTextbox1.UsePasswordMask = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.EnableAutoDragDrop = True
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 137)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ShortcutsEnabled = False
        Me.RichTextBox1.Size = New System.Drawing.Size(514, 84)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "DROP HERE"
        '
        'ChControlbutton1
        '
        Me.ChControlbutton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChControlbutton1.ControlButton = Lime_Downloader.CHControlbutton.Button.Close
        Me.ChControlbutton1.Location = New System.Drawing.Point(503, 13)
        Me.ChControlbutton1.Margin = New System.Windows.Forms.Padding(0)
        Me.ChControlbutton1.MaximumSize = New System.Drawing.Size(28, 28)
        Me.ChControlbutton1.MinimumSize = New System.Drawing.Size(28, 28)
        Me.ChControlbutton1.Name = "ChControlbutton1"
        Me.ChControlbutton1.Size = New System.Drawing.Size(28, 28)
        Me.ChControlbutton1.TabIndex = 0
        Me.ChControlbutton1.Text = "ChControlbutton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 244)
        Me.Controls.Add(Me.ChTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lime Pastebin Downloader v1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChTheme1.ResumeLayout(False)
        Me.ChTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChTheme1 As CHTheme
    Friend WithEvents ChControlbutton1 As CHControlbutton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChTextbox1 As CHTextbox
End Class
