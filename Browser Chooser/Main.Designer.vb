﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
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
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.btnApp1 = New System.Windows.Forms.PictureBox()
        Me.browserButtonContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddUrlToAutoOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyUrlToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOptions = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApp2 = New System.Windows.Forms.PictureBox()
        Me.btnApp3 = New System.Windows.Forms.PictureBox()
        Me.btnApp4 = New System.Windows.Forms.PictureBox()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.btnApp5 = New System.Windows.Forms.PictureBox()
        Me.btn1TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn2TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn3TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn4TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn5TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.RememberForThisURL = New System.Windows.Forms.CheckBox()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.PictureBox()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.browserButtonContextMenu.SuspendLayout()
        CType(Me.btnOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApp3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApp4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApp5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.Image = Global.Browser_Chooser.My.Resources.Resources._122
        Me.btnInfo.Location = New System.Drawing.Point(12, 12)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(16, 16)
        Me.btnInfo.TabIndex = 0
        Me.btnInfo.TabStop = False
        '
        'btnApp1
        '
        Me.btnApp1.BackColor = System.Drawing.Color.Transparent
        Me.btnApp1.ContextMenuStrip = Me.browserButtonContextMenu
        Me.btnApp1.Image = Global.Browser_Chooser.My.Resources.Resources.Firefox
        Me.btnApp1.Location = New System.Drawing.Point(56, 1)
        Me.btnApp1.Name = "btnApp1"
        Me.btnApp1.Size = New System.Drawing.Size(75, 80)
        Me.btnApp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnApp1.TabIndex = 2
        Me.btnApp1.TabStop = False
        Me.btnApp1.Visible = False
        '
        'browserButtonContextMenu
        '
        Me.browserButtonContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUrlToAutoOpenToolStripMenuItem, Me.CopyUrlToClipboardToolStripMenuItem})
        Me.browserButtonContextMenu.Name = "btn1ContextMenu"
        Me.browserButtonContextMenu.Size = New System.Drawing.Size(212, 48)
        '
        'AddUrlToAutoOpenToolStripMenuItem
        '
        Me.AddUrlToAutoOpenToolStripMenuItem.Name = "AddUrlToAutoOpenToolStripMenuItem"
        Me.AddUrlToAutoOpenToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.AddUrlToAutoOpenToolStripMenuItem.Text = "Add Url To Auto Open List"
        '
        'CopyUrlToClipboardToolStripMenuItem
        '
        Me.CopyUrlToClipboardToolStripMenuItem.Name = "CopyUrlToClipboardToolStripMenuItem"
        Me.CopyUrlToClipboardToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CopyUrlToClipboardToolStripMenuItem.Text = "Copy Url To Clipboard"
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.Transparent
        Me.btnOptions.Image = Global.Browser_Chooser.My.Resources.Resources._128
        Me.btnOptions.Location = New System.Drawing.Point(478, 12)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(16, 16)
        Me.btnOptions.TabIndex = 5
        Me.btnOptions.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(370, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(0, 0)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnApp2
        '
        Me.btnApp2.BackColor = System.Drawing.Color.Transparent
        Me.btnApp2.ContextMenuStrip = Me.browserButtonContextMenu
        Me.btnApp2.Image = Global.Browser_Chooser.My.Resources.Resources.InternetExplorer
        Me.btnApp2.Location = New System.Drawing.Point(137, 1)
        Me.btnApp2.Name = "btnApp2"
        Me.btnApp2.Size = New System.Drawing.Size(75, 80)
        Me.btnApp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnApp2.TabIndex = 7
        Me.btnApp2.TabStop = False
        Me.btnApp2.Visible = False
        '
        'btnApp3
        '
        Me.btnApp3.BackColor = System.Drawing.Color.Transparent
        Me.btnApp3.ContextMenuStrip = Me.browserButtonContextMenu
        Me.btnApp3.Image = Global.Browser_Chooser.My.Resources.Resources.GoogleChrome
        Me.btnApp3.Location = New System.Drawing.Point(218, 1)
        Me.btnApp3.Name = "btnApp3"
        Me.btnApp3.Size = New System.Drawing.Size(75, 80)
        Me.btnApp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnApp3.TabIndex = 8
        Me.btnApp3.TabStop = False
        Me.btnApp3.Visible = False
        '
        'btnApp4
        '
        Me.btnApp4.BackColor = System.Drawing.Color.Transparent
        Me.btnApp4.ContextMenuStrip = Me.browserButtonContextMenu
        Me.btnApp4.Image = Global.Browser_Chooser.My.Resources.Resources.Safari
        Me.btnApp4.Location = New System.Drawing.Point(299, 1)
        Me.btnApp4.Name = "btnApp4"
        Me.btnApp4.Size = New System.Drawing.Size(75, 80)
        Me.btnApp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnApp4.TabIndex = 9
        Me.btnApp4.TabStop = False
        Me.btnApp4.Visible = False
        '
        'lblEmpty
        '
        Me.lblEmpty.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblEmpty.Location = New System.Drawing.Point(60, 29)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(392, 23)
        Me.lblEmpty.TabIndex = 10
        Me.lblEmpty.Text = "Please choose your browsers in the options!"
        Me.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEmpty.Visible = False
        '
        'btnApp5
        '
        Me.btnApp5.BackColor = System.Drawing.Color.Transparent
        Me.btnApp5.ContextMenuStrip = Me.browserButtonContextMenu
        Me.btnApp5.Image = Global.Browser_Chooser.My.Resources.Resources.InternetExplorer
        Me.btnApp5.Location = New System.Drawing.Point(380, 1)
        Me.btnApp5.Name = "btnApp5"
        Me.btnApp5.Size = New System.Drawing.Size(75, 80)
        Me.btnApp5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnApp5.TabIndex = 11
        Me.btnApp5.TabStop = False
        Me.btnApp5.Visible = False
        '
        'RememberForThisURL
        '
        Me.RememberForThisURL.AutoSize = True
        Me.RememberForThisURL.Location = New System.Drawing.Point(56, 88)
        Me.RememberForThisURL.Name = "RememberForThisURL"
        Me.RememberForThisURL.Size = New System.Drawing.Size(197, 17)
        Me.RememberForThisURL.TabIndex = 12
        Me.RememberForThisURL.Text = "Remember my selection for this URL"
        Me.RememberForThisURL.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUrl.Location = New System.Drawing.Point(12, 111)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(477, 20)
        Me.txtUrl.TabIndex = 13
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.BackColor = System.Drawing.Color.Transparent
        Me.btnCopy.Image = Global.Browser_Chooser.My.Resources.Resources.CopyIcon
        Me.btnCopy.Location = New System.Drawing.Point(478, 36)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(16, 16)
        Me.btnCopy.TabIndex = 14
        Me.btnCopy.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(501, 142)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.RememberForThisURL)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.btnApp5)
        Me.Controls.Add(Me.btnApp4)
        Me.Controls.Add(Me.btnApp3)
        Me.Controls.Add(Me.btnApp2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnApp1)
        Me.Controls.Add(Me.btnInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose a Browser"
        Me.TopMost = True
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.browserButtonContextMenu.ResumeLayout(False)
        CType(Me.btnOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApp3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApp4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApp5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnApp1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOptions As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApp2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnApp3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnApp4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpty As System.Windows.Forms.Label
    Friend WithEvents btnApp5 As System.Windows.Forms.PictureBox
    Friend WithEvents btn1TT As System.Windows.Forms.ToolTip
    Friend WithEvents btn2TT As System.Windows.Forms.ToolTip
    Friend WithEvents btn3TT As System.Windows.Forms.ToolTip
    Friend WithEvents btn4TT As System.Windows.Forms.ToolTip
    Friend WithEvents btn5TT As System.Windows.Forms.ToolTip
    Friend WithEvents browserButtonContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddUrlToAutoOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyUrlToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RememberForThisURL As CheckBox
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents btnCopy As PictureBox
End Class
