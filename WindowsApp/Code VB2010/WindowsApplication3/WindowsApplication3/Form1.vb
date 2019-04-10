Imports System
Imports System.IO.Ports
Imports System.IO


Public Class Form1
    Dim comPort As String
    Dim receivedData As String = ""
    Dim ok As Boolean = False
    Dim compteur As Integer = False
    Dim etatRelais As Boolean = 0
    Dim compteurEtatRelais As Integer = 0
    Const fichierIni As String = "config.ini"
    Dim etR1 As Boolean = 0
    Dim etR2 As Boolean = 0
    Dim etR3 As Boolean = 0
    Dim etR4 As Boolean = 0
    Dim etR5 As Boolean = 0
    Dim etR6 As Boolean = 0
    Dim etR7 As Boolean = 0
    Dim etR8 As Boolean = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        findComPort()
        loadIni()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (SerialPort1.IsOpen <> True) Then
            cbComPort.Items.Clear()
            cbComPort.Text = ""
            comPort = ""
            deconnecter()
            MsgBox("Liaison Port Comm Perdue")
        End If
        If (etatRelais = True) Then
            compteurEtatRelais += 1
            If (compteurEtatRelais = 5) Then
                SerialPort1.Write("12345")
                etatRelais = False
            End If
        End If
        If (SerialPort1.IsOpen) Then
            receivedData = SerialPort1.ReadExisting()

            If (receivedData <> "") Then
                Label3.Text = receivedData
                traiteCommande()
                If (ok = True) Then
                    SerialPort1.Write("7toi?")
                    If (receivedData <> "7moi!") Then
                        ok = False
                        MsgBox("Boite à relais introuvable sur ce port. Essayez un autre port.")
                        deconnecter()
                    Else
                        ok = False
                    End If
                End If
            End If
        End If
            If (ok <> False) Then
            SerialPort1.Write("7toi?")
                compteur = compteur + 1
                If (compteur >= 10) Then
                    deconnecter()
                    ok = False
                    MsgBox("Boite à relais introuvable sur ce port. Essayez un autre port.2")
                End If
            End If
    End Sub

    Function traiteCommande()
        If (receivedData = "ofR01") Then
            Button1.BackColor = Color.Red
            etR1 = 0
        End If
        If (receivedData = "onR01") Then
            Button1.BackColor = Color.Lime
            etR1 = 1
        End If
        If (receivedData = "ofR02") Then
            Button2.BackColor = Color.Red
            etR2 = 0
        End If
        If (receivedData = "onR02") Then
            Button2.BackColor = Color.Lime
            etR2 = 1
        End If
        If (receivedData = "ofR03") Then
            Button3.BackColor = Color.Red
            etR3 = 0
        End If
        If (receivedData = "onR03") Then
            Button3.BackColor = Color.Lime
            etR3 = 1
        End If
        If (receivedData = "ofR04") Then
            Button4.BackColor = Color.Red
            etR4 = 0
        End If
        If (receivedData = "onR04") Then
            Button4.BackColor = Color.Lime
            etR4 = 1
        End If
        If (receivedData = "ofR05") Then
            Button5.BackColor = Color.Red
            etR5 = 0
        End If
        If (receivedData = "onR05") Then
            Button5.BackColor = Color.Lime
            etR5 = 1
        End If
        If (receivedData = "ofR06") Then
            Button6.BackColor = Color.Red
            etR6 = 0
        End If
        If (receivedData = "onR06") Then
            Button6.BackColor = Color.Lime
            etR6 = 1
        End If
        If (receivedData = "ofR07") Then
            Button7.BackColor = Color.Red
            etR7 = 0
        End If
        If (receivedData = "onR07") Then
            Button7.BackColor = Color.Lime
            etR7 = 1
        End If
        If (receivedData = "ofR08") Then
            Button8.BackColor = Color.Red
            etR8 = 0
        End If
        If (receivedData = "onR08") Then
            Button8.BackColor = Color.Lime
            etR8 = 1
        End If


        Return ""
    End Function

#Region "menu"

    Private Sub NomDesBoutonsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomDesBoutonsToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuiterToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Serial"

    Private Sub btConnecter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConnecter.Click
        If (btConnecter.Text = "Connecter") Then
            If (comPort <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPort
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 1000
                SerialPort1.Open()
                SerialPort1.WriteLine("7toi?")
                ok = True
                etatRelais = True
                compteur = 0
                compteurEtatRelais = 0
                btConnecter.Text = "Deconnecter"
                Timer1.Interval = 100
                Timer1.Enabled = True
                lblStatusCom.Text = "Connecté au: " & comPort
                cbComPort.Enabled = False
                GroupBox1.Enabled = True
                btActualiser.Enabled = False
            Else
                MsgBox("Selectionner un port Comm d'abord.")
            End If
        Else
            deconnecter()
        End If
    End Sub

    Private Sub btActualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btActualiser.Click
        findComPort()
    End Sub

    Private Sub cbComPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbComPort.SelectedIndexChanged
        comPort = cbComPort.Text
    End Sub

    Function deconnecter()
        SerialPort1.Close()
        btConnecter.Text = "Connecter"
        Timer1.Enabled = False
        lblStatusCom.Text = "Connecté au: "
        cbComPort.Enabled = True
        GroupBox1.Enabled = False
        cbComPort.Text = ""
        comPort = ""
        btActualiser.Enabled = True
        Return ""
    End Function

    Function findComPort()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbComPort.Items.Clear()
            cbComPort.Items.Add(sp)
        Next
        Return ""
    End Function

#End Region

#Region "sauvegarde du nom des boutons"

    Function save()
        File.WriteAllLines(fichierIni, saveIni())
        Return ""
    End Function

    Function saveIni()
        Dim fichierIni(12) As String
        fichierIni(0) = ";Fichier de configuration de l'application RelaisUSB"
        fichierIni(2) = "[Nom des boutons]"
        fichierIni(4) = "cleRelais1" & "=" & Button1.Text
        fichierIni(5) = "cleRelais2" & "=" & Button2.Text
        fichierIni(6) = "cleRelais3" & "=" & Button3.Text
        fichierIni(7) = "cleRelais4" & "=" & Button4.Text
        fichierIni(8) = "cleRelais5" & "=" & Button5.Text
        fichierIni(9) = "cleRelais6" & "=" & Button6.Text
        fichierIni(10) = "cleRelais7" & "=" & Button7.Text
        fichierIni(11) = "cleRelais8" & "=" & Button8.Text
        Return fichierIni
    End Function

    Function cleLoadIni(ByVal cle As String) As String
        For Each ligne As String In File.ReadAllLines(fichierIni)
            If ligne.Split("=")(0) = cle Then
                Return ligne.Split("=")(1)
            End If
        Next
        Return ""
    End Function

    Function loadIni()
        If File.Exists(fichierIni) Then
            Button1.Text = cleLoadIni("cleRelais1")
            Button2.Text = cleLoadIni("cleRelais2")
            Button3.Text = cleLoadIni("cleRelais3")
            Button4.Text = cleLoadIni("cleRelais4")
            Button5.Text = cleLoadIni("cleRelais5")
            Button6.Text = cleLoadIni("cleRelais6")
            Button7.Text = cleLoadIni("cleRelais7")
            Button8.Text = cleLoadIni("cleRelais8")
        End If
        Return ""
    End Function

#End Region

#Region "Boutons Relais"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If etR1 = 0 Then
            SerialPort1.Write("r01on")
            Button1.BackColor = Color.Lime
            etR1 = 1
        Else
            SerialPort1.Write("r01of")
            Button1.BackColor = Color.Red
            etR1 = 0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If etR2 = 0 Then
            SerialPort1.Write("r02on")
            Button2.BackColor = Color.Lime
            etR2 = 1
        Else
            SerialPort1.Write("r02of")
            Button2.BackColor = Color.Red
            etR2 = 0
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If etR3 = 0 Then
            SerialPort1.Write("r03on")
            Button3.BackColor = Color.Lime
            etR3 = 1
        Else
            SerialPort1.Write("r03of")
            Button3.BackColor = Color.Red
            etR3 = 0
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If etR4 = 0 Then
            SerialPort1.Write("r04on")
            Button4.BackColor = Color.Lime
            etR4 = 4
        Else
            SerialPort1.Write("r04of")
            Button4.BackColor = Color.Red
            etR4 = 0
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If etR5 = 0 Then
            SerialPort1.Write("r05on")
            Button5.BackColor = Color.Lime
            etR5 = 1
        Else
            SerialPort1.Write("r05of")
            Button5.BackColor = Color.Red
            etR5 = 0
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If etR6 = 0 Then
            SerialPort1.Write("r06on")
            Button6.BackColor = Color.Lime
            etR6 = 1
        Else
            SerialPort1.Write("r06of")
            Button6.BackColor = Color.Red
            etR6 = 0
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If etR7 = 0 Then
            SerialPort1.Write("r07on")
            Button7.BackColor = Color.Lime
            etR7 = 1
        Else
            SerialPort1.Write("r07of")
            Button7.BackColor = Color.Red
            etR7 = 0
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If etR8 = 0 Then
            SerialPort1.Write("r08on")
            Button8.BackColor = Color.Lime
            etR8 = 1
        Else
            SerialPort1.Write("r08of")
            Button8.BackColor = Color.Red
            etR8 = 0
        End If
    End Sub

#End Region

End Class
