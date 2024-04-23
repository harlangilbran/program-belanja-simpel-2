<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListHosting = New System.Windows.Forms.ComboBox()
        Me.THargaHosting = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ListDomain = New System.Windows.Forms.ComboBox()
        Me.THargaDomain = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TJumlahBayar = New System.Windows.Forms.TextBox()
        Me.TMasaAktif = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 87)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mulai Dengan Hosting Dari" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Peket Hosting"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Hosting"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Extensi Domain"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(385, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Domain"
        '
        'ListHosting
        '
        Me.ListHosting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListHosting.FormattingEnabled = True
        Me.ListHosting.Items.AddRange(New Object() {"ENTRY", "SMALL", "MEDIUM", "LARGE"})
        Me.ListHosting.Location = New System.Drawing.Point(111, 150)
        Me.ListHosting.Name = "ListHosting"
        Me.ListHosting.Size = New System.Drawing.Size(245, 24)
        Me.ListHosting.TabIndex = 5
        '
        'THargaHosting
        '
        Me.THargaHosting.Location = New System.Drawing.Point(382, 152)
        Me.THargaHosting.Name = "THargaHosting"
        Me.THargaHosting.Size = New System.Drawing.Size(144, 22)
        Me.THargaHosting.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(111, 180)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(141, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "TermasukDomain"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ListDomain
        '
        Me.ListDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListDomain.FormattingEnabled = True
        Me.ListDomain.Items.AddRange(New Object() {".COM", ".ID", ".ORG", ".SCH", ".AC.ID"})
        Me.ListDomain.Location = New System.Drawing.Point(111, 257)
        Me.ListDomain.Name = "ListDomain"
        Me.ListDomain.Size = New System.Drawing.Size(245, 24)
        Me.ListDomain.TabIndex = 8
        '
        'THargaDomain
        '
        Me.THargaDomain.Location = New System.Drawing.Point(382, 258)
        Me.THargaDomain.Name = "THargaDomain"
        Me.THargaDomain.Size = New System.Drawing.Size(144, 22)
        Me.THargaDomain.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.BtnHitung)
        Me.GroupBox1.Controls.Add(Me.TJumlahBayar)
        Me.GroupBox1.Controls.Add(Me.TMasaAktif)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(111, 311)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 188)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<< Perhitungan Tagihan >>"
        '
        'BtnHitung
        '
        Me.BtnHitung.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHitung.ForeColor = System.Drawing.Color.Black
        Me.BtnHitung.Location = New System.Drawing.Point(271, 70)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(102, 23)
        Me.BtnHitung.TabIndex = 4
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TJumlahBayar
        '
        Me.TJumlahBayar.Location = New System.Drawing.Point(32, 133)
        Me.TJumlahBayar.Name = "TJumlahBayar"
        Me.TJumlahBayar.Size = New System.Drawing.Size(341, 22)
        Me.TJumlahBayar.TabIndex = 3
        '
        'TMasaAktif
        '
        Me.TMasaAktif.Location = New System.Drawing.Point(32, 71)
        Me.TMasaAktif.Name = "TMasaAktif"
        Me.TMasaAktif.Size = New System.Drawing.Size(213, 22)
        Me.TMasaAktif.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Jumlah Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Masa Aktif (Bulan)"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(289, 518)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(87, 35)
        Me.BtnKeluar.TabIndex = 5
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(206, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "HARLAN G WEB MEDIA"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(724, 613)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.THargaDomain)
        Me.Controls.Add(Me.ListDomain)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.THargaHosting)
        Me.Controls.Add(Me.ListHosting)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDER PAKET HOSTING"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListHosting As ComboBox
    Friend WithEvents THargaHosting As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ListDomain As ComboBox
    Friend WithEvents THargaDomain As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnHitung As Button
    Friend WithEvents TJumlahBayar As TextBox
    Friend WithEvents TMasaAktif As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents Label8 As Label
End Class
