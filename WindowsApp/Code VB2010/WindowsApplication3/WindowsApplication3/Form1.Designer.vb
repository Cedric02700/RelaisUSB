<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConrigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NomDesBoutonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblStatusCom = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btConnecter = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbComPort = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btActualiser = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConrigurationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(289, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConrigurationToolStripMenuItem
        '
        Me.ConrigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomDesBoutonsToolStripMenuItem, Me.QuiterToolStripMenuItem})
        Me.ConrigurationToolStripMenuItem.Name = "ConrigurationToolStripMenuItem"
        Me.ConrigurationToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ConrigurationToolStripMenuItem.Text = "Menu"
        '
        'NomDesBoutonsToolStripMenuItem
        '
        Me.NomDesBoutonsToolStripMenuItem.Name = "NomDesBoutonsToolStripMenuItem"
        Me.NomDesBoutonsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.NomDesBoutonsToolStripMenuItem.Text = "Nom des boutons"
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.QuiterToolStripMenuItem.Text = "Quiter"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(8, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Relais 1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(8, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Relais 2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(8, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Relais 3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(8, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(260, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Relais 4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblStatusCom
        '
        Me.lblStatusCom.AutoSize = True
        Me.lblStatusCom.Location = New System.Drawing.Point(2, 309)
        Me.lblStatusCom.Name = "lblStatusCom"
        Me.lblStatusCom.Size = New System.Drawing.Size(71, 13)
        Me.lblStatusCom.TabIndex = 7
        Me.lblStatusCom.Text = "Connecté au:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Serial"
        '
        'btConnecter
        '
        Me.btConnecter.Location = New System.Drawing.Point(178, 21)
        Me.btConnecter.Name = "btConnecter"
        Me.btConnecter.Size = New System.Drawing.Size(94, 23)
        Me.btConnecter.TabIndex = 9
        Me.btConnecter.Text = "Connecter"
        Me.btConnecter.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'cbComPort
        '
        Me.cbComPort.FormattingEnabled = True
        Me.cbComPort.Location = New System.Drawing.Point(79, 21)
        Me.cbComPort.Name = "cbComPort"
        Me.cbComPort.Size = New System.Drawing.Size(93, 21)
        Me.cbComPort.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(8, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(260, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Relais 5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(8, 164)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(260, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Relais 6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(8, 193)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(260, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Relais 7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Red
        Me.Button8.Location = New System.Drawing.Point(8, 222)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(260, 23)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "Relais 8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(4, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 256)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'btActualiser
        '
        Me.btActualiser.Location = New System.Drawing.Point(4, 21)
        Me.btActualiser.Name = "btActualiser"
        Me.btActualiser.Size = New System.Drawing.Size(69, 23)
        Me.btActualiser.TabIndex = 18
        Me.btActualiser.Text = "Actualiser"
        Me.btActualiser.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(289, 327)
        Me.Controls.Add(Me.btActualiser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbComPort)
        Me.Controls.Add(Me.btConnecter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStatusCom)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(305, 365)
        Me.Name = "Form1"
        Me.Text = "Relais USB"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConrigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NomDesBoutonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents lblStatusCom As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btConnecter As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cbComPort As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btActualiser As System.Windows.Forms.Button

End Class
