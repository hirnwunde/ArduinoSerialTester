Public Class main

    Dim WithEvents CNCComPort As New System.IO.Ports.SerialPort
    Delegate Sub SetTextCallback([text] As String)

    Private Sub btn_ConnectToSelectedPort_Click(sender As System.Object, e As System.EventArgs) Handles btn_ConnectToSelectedPort.Click

        If Not chkbox_keppData.Checked Then

            lb_serialwindow.Items.Clear()
            tb_serialwindow.Clear()

        End If

        If Not IsNumeric(tb_bufferSize.Text) Then
            MsgBox("Buffer-Size has to be numeric")
            Exit Sub
        End If


        If cb_COMPort.Items.Count > 0 And Not cb_COMPort.SelectedText = "NO COM AVAIL" Then
            Try
                CNCComPort.PortName = cb_COMPort.Text
                CNCComPort.BaudRate = lbox_baudrate.SelectedItem
                CNCComPort.DataBits = lbox_DataBits.SelectedItem
                CNCComPort.RtsEnable = True
                CNCComPort.DtrEnable = True

                If lbox_Parity.SelectedItem = "Even" Then CNCComPort.Parity = System.IO.Ports.Parity.Even
                If lbox_Parity.SelectedItem = "Mark" Then CNCComPort.Parity = System.IO.Ports.Parity.Mark
                If lbox_Parity.SelectedItem = "None" Then CNCComPort.Parity = System.IO.Ports.Parity.None
                If lbox_Parity.SelectedItem = "Odd" Then CNCComPort.Parity = System.IO.Ports.Parity.Odd
                If lbox_Parity.SelectedItem = "Space" Then CNCComPort.Parity = System.IO.Ports.Parity.Space

                If lbox_StopBits.SelectedItem = "none" Then CNCComPort.StopBits = System.IO.Ports.StopBits.None
                If lbox_StopBits.SelectedItem = "1" Then CNCComPort.StopBits = System.IO.Ports.StopBits.One
                If lbox_StopBits.SelectedItem = "1.5" Then CNCComPort.StopBits = System.IO.Ports.StopBits.OnePointFive
                If lbox_StopBits.SelectedItem = "2" Then CNCComPort.StopBits = System.IO.Ports.StopBits.Two


                CNCComPort.ReadBufferSize = tb_bufferSize.Text
                CNCComPort.Open()
                btn_ConnectToSelectedPort.Enabled = False
                btn_CloseComPort.Enabled = True
                tb_send.Enabled = True
                btn_send.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No COM-Port available.")
        End If
    End Sub

    Private Sub btn_send_Click(sender As System.Object, e As System.EventArgs) Handles btn_send.Click
        If CNCComPort.IsOpen Then
            Try
                CNCComPort.WriteLine(tb_send.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_CloseComPort_Click(sender As System.Object, e As System.EventArgs) Handles btn_CloseComPort.Click
        If CNCComPort.IsOpen Then
            Try
                CNCComPort.Close()
                btn_ConnectToSelectedPort.Enabled = True
                btn_CloseComPort.Enabled = False
                tb_send.Enabled = False
                btn_send.Enabled = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refreshCOMPort()
        btn_CloseComPort.Enabled = False

        lbox_baudrate.SelectedItem = "57600"
        lbox_DataBits.SelectedItem = "8"
        lbox_Parity.SelectedItem = "None"
        lbox_StopBits.SelectedItem = "1"
        tb_bufferSize.Text = "64"

    End Sub

    Private Sub refreshCOMPort()
        cb_COMPort.Items.Clear()
        For Each comport As String In System.IO.Ports.SerialPort.GetPortNames
            cb_COMPort.Items.Add(comport)
        Next
        If cb_COMPort.Items.Count = 1 Then cb_COMPort.SelectedIndex = 0
        If cb_COMPort.Items.Count = 0 Then cb_COMPort.Items.Add("NO COM AVAIL")
    End Sub

    Private Sub CNCComPort_ErrorReceived(sender As Object, e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles CNCComPort.ErrorReceived
        MsgBox(e.ToString)
    End Sub

    Private Sub CNCComPort_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles CNCComPort.DataReceived
        Try
            Me.SetText(CNCComPort.ReadLine)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetText(ByVal [text] As String)
        If Me.lb_serialwindow.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.tb_serialwindow.AppendText([text])
            Me.lb_serialwindow.Items.Add([text])
        End If
    End Sub

End Class
