<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_RefreshCOMPort = New System.Windows.Forms.Button()
        Me.cb_COMPort = New System.Windows.Forms.ComboBox()
        Me.btn_CloseComPort = New System.Windows.Forms.Button()
        Me.btn_ConnectToSelectedPort = New System.Windows.Forms.Button()
        Me.lb_serialwindow = New System.Windows.Forms.ListBox()
        Me.tb_serialwindow = New System.Windows.Forms.TextBox()
        Me.tb_send = New System.Windows.Forms.TextBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.lbox_baudrate = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbox_DataBits = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbox_Parity = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbox_StopBits = New System.Windows.Forms.ListBox()
        Me.chkbox_keppData = New System.Windows.Forms.CheckBox()
        Me.tb_bufferSize = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_RefreshCOMPort
        '
        Me.btn_RefreshCOMPort.Location = New System.Drawing.Point(96, 12)
        Me.btn_RefreshCOMPort.Name = "btn_RefreshCOMPort"
        Me.btn_RefreshCOMPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_RefreshCOMPort.TabIndex = 5
        Me.btn_RefreshCOMPort.Text = "refresh"
        Me.btn_RefreshCOMPort.UseVisualStyleBackColor = True
        '
        'cb_COMPort
        '
        Me.cb_COMPort.FormattingEnabled = True
        Me.cb_COMPort.Location = New System.Drawing.Point(193, 12)
        Me.cb_COMPort.Name = "cb_COMPort"
        Me.cb_COMPort.Size = New System.Drawing.Size(75, 21)
        Me.cb_COMPort.TabIndex = 4
        '
        'btn_CloseComPort
        '
        Me.btn_CloseComPort.Enabled = False
        Me.btn_CloseComPort.Location = New System.Drawing.Point(12, 41)
        Me.btn_CloseComPort.Name = "btn_CloseComPort"
        Me.btn_CloseComPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_CloseComPort.TabIndex = 17
        Me.btn_CloseComPort.Text = "disconnect"
        Me.btn_CloseComPort.UseVisualStyleBackColor = True
        '
        'btn_ConnectToSelectedPort
        '
        Me.btn_ConnectToSelectedPort.Location = New System.Drawing.Point(12, 12)
        Me.btn_ConnectToSelectedPort.Name = "btn_ConnectToSelectedPort"
        Me.btn_ConnectToSelectedPort.Size = New System.Drawing.Size(75, 23)
        Me.btn_ConnectToSelectedPort.TabIndex = 18
        Me.btn_ConnectToSelectedPort.Text = "connect"
        Me.btn_ConnectToSelectedPort.UseVisualStyleBackColor = True
        '
        'lb_serialwindow
        '
        Me.lb_serialwindow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_serialwindow.FormattingEnabled = True
        Me.lb_serialwindow.Location = New System.Drawing.Point(221, 52)
        Me.lb_serialwindow.Name = "lb_serialwindow"
        Me.lb_serialwindow.Size = New System.Drawing.Size(313, 446)
        Me.lb_serialwindow.TabIndex = 19
        '
        'tb_serialwindow
        '
        Me.tb_serialwindow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_serialwindow.Location = New System.Drawing.Point(539, 52)
        Me.tb_serialwindow.Multiline = True
        Me.tb_serialwindow.Name = "tb_serialwindow"
        Me.tb_serialwindow.Size = New System.Drawing.Size(410, 447)
        Me.tb_serialwindow.TabIndex = 20
        '
        'tb_send
        '
        Me.tb_send.Enabled = False
        Me.tb_send.Location = New System.Drawing.Point(275, 12)
        Me.tb_send.Name = "tb_send"
        Me.tb_send.Size = New System.Drawing.Size(593, 20)
        Me.tb_send.TabIndex = 21
        '
        'btn_send
        '
        Me.btn_send.Enabled = False
        Me.btn_send.Location = New System.Drawing.Point(875, 12)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(75, 23)
        Me.btn_send.TabIndex = 22
        Me.btn_send.Text = "send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'lbox_baudrate
        '
        Me.lbox_baudrate.FormattingEnabled = True
        Me.lbox_baudrate.Items.AddRange(New Object() {"75", "110", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.lbox_baudrate.Location = New System.Drawing.Point(12, 92)
        Me.lbox_baudrate.Name = "lbox_baudrate"
        Me.lbox_baudrate.Size = New System.Drawing.Size(75, 147)
        Me.lbox_baudrate.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Baudrate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "DataBits:"
        '
        'lbox_DataBits
        '
        Me.lbox_DataBits.FormattingEnabled = True
        Me.lbox_DataBits.Items.AddRange(New Object() {"5", "6", "7", "8", "9"})
        Me.lbox_DataBits.Location = New System.Drawing.Point(96, 92)
        Me.lbox_DataBits.Name = "lbox_DataBits"
        Me.lbox_DataBits.Size = New System.Drawing.Size(47, 69)
        Me.lbox_DataBits.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Parity:"
        '
        'lbox_Parity
        '
        Me.lbox_Parity.FormattingEnabled = True
        Me.lbox_Parity.Items.AddRange(New Object() {"Even", "Mark", "None", "Odd", "Space"})
        Me.lbox_Parity.Location = New System.Drawing.Point(150, 92)
        Me.lbox_Parity.Name = "lbox_Parity"
        Me.lbox_Parity.Size = New System.Drawing.Size(65, 69)
        Me.lbox_Parity.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "StopBits:"
        '
        'lbox_StopBits
        '
        Me.lbox_StopBits.FormattingEnabled = True
        Me.lbox_StopBits.Items.AddRange(New Object() {"none", "1", "1.5", "2"})
        Me.lbox_StopBits.Location = New System.Drawing.Point(96, 185)
        Me.lbox_StopBits.Name = "lbox_StopBits"
        Me.lbox_StopBits.Size = New System.Drawing.Size(47, 56)
        Me.lbox_StopBits.TabIndex = 30
        '
        'chkbox_keppData
        '
        Me.chkbox_keppData.AutoSize = True
        Me.chkbox_keppData.Location = New System.Drawing.Point(96, 45)
        Me.chkbox_keppData.Name = "chkbox_keppData"
        Me.chkbox_keppData.Size = New System.Drawing.Size(74, 17)
        Me.chkbox_keppData.TabIndex = 31
        Me.chkbox_keppData.Text = "keep data"
        Me.chkbox_keppData.UseVisualStyleBackColor = True
        '
        'tb_bufferSize
        '
        Me.tb_bufferSize.Location = New System.Drawing.Point(99, 247)
        Me.tb_bufferSize.Name = "tb_bufferSize"
        Me.tb_bufferSize.Size = New System.Drawing.Size(58, 20)
        Me.tb_bufferSize.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Buffer-Size (byte):"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 510)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_bufferSize)
        Me.Controls.Add(Me.chkbox_keppData)
        Me.Controls.Add(Me.lbox_StopBits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbox_Parity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbox_DataBits)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbox_baudrate)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.tb_send)
        Me.Controls.Add(Me.tb_serialwindow)
        Me.Controls.Add(Me.lb_serialwindow)
        Me.Controls.Add(Me.btn_ConnectToSelectedPort)
        Me.Controls.Add(Me.btn_CloseComPort)
        Me.Controls.Add(Me.btn_RefreshCOMPort)
        Me.Controls.Add(Me.cb_COMPort)
        Me.Name = "Form1"
        Me.Text = "ArduinoSerialTester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_RefreshCOMPort As System.Windows.Forms.Button
    Friend WithEvents cb_COMPort As System.Windows.Forms.ComboBox
    Friend WithEvents btn_CloseComPort As System.Windows.Forms.Button
    Friend WithEvents btn_ConnectToSelectedPort As System.Windows.Forms.Button
    Friend WithEvents lb_serialwindow As System.Windows.Forms.ListBox
    Friend WithEvents tb_serialwindow As System.Windows.Forms.TextBox
    Friend WithEvents tb_send As System.Windows.Forms.TextBox
    Friend WithEvents btn_send As System.Windows.Forms.Button
    Friend WithEvents lbox_baudrate As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbox_DataBits As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbox_Parity As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbox_StopBits As System.Windows.Forms.ListBox
    Friend WithEvents chkbox_keppData As System.Windows.Forms.CheckBox
    Friend WithEvents tb_bufferSize As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
