﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTipOfTheDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTipOfTheDay))
        Me.Panel_FooterControl = New System.Windows.Forms.Panel()
        Me.CheckBox_DoNotShow = New System.Windows.Forms.CheckBox()
        Me.Panel_FooterDarkControl = New System.Windows.Forms.Panel()
        Me.TextBox_Tips = New System.Windows.Forms.TextBox()
        Me.LinkLabel_PreviousTip = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_NextTip = New System.Windows.Forms.LinkLabel()
        Me.ClassPictureBoxQuality1 = New BasicPawn.ClassPictureBoxQuality()
        Me.Panel_FooterControl.SuspendLayout()
        CType(Me.ClassPictureBoxQuality1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_FooterControl
        '
        Me.Panel_FooterControl.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_FooterControl.Controls.Add(Me.LinkLabel_PreviousTip)
        Me.Panel_FooterControl.Controls.Add(Me.LinkLabel_NextTip)
        Me.Panel_FooterControl.Controls.Add(Me.CheckBox_DoNotShow)
        Me.Panel_FooterControl.Controls.Add(Me.Panel_FooterDarkControl)
        Me.Panel_FooterControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_FooterControl.Location = New System.Drawing.Point(0, 193)
        Me.Panel_FooterControl.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_FooterControl.Name = "Panel_FooterControl"
        Me.Panel_FooterControl.Size = New System.Drawing.Size(404, 48)
        Me.Panel_FooterControl.TabIndex = 2
        '
        'CheckBox_DoNotShow
        '
        Me.CheckBox_DoNotShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_DoNotShow.AutoSize = True
        Me.CheckBox_DoNotShow.Location = New System.Drawing.Point(12, 17)
        Me.CheckBox_DoNotShow.Name = "CheckBox_DoNotShow"
        Me.CheckBox_DoNotShow.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox_DoNotShow.TabIndex = 1
        Me.CheckBox_DoNotShow.Text = "Do not show again"
        Me.CheckBox_DoNotShow.UseVisualStyleBackColor = True
        '
        'Panel_FooterDarkControl
        '
        Me.Panel_FooterDarkControl.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_FooterDarkControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_FooterDarkControl.Location = New System.Drawing.Point(0, 0)
        Me.Panel_FooterDarkControl.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_FooterDarkControl.Name = "Panel_FooterDarkControl"
        Me.Panel_FooterDarkControl.Size = New System.Drawing.Size(404, 1)
        Me.Panel_FooterDarkControl.TabIndex = 0
        '
        'TextBox_Tips
        '
        Me.TextBox_Tips.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Tips.BackColor = System.Drawing.Color.White
        Me.TextBox_Tips.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Tips.Location = New System.Drawing.Point(82, 12)
        Me.TextBox_Tips.Margin = New System.Windows.Forms.Padding(3, 3, 3, 9)
        Me.TextBox_Tips.Multiline = True
        Me.TextBox_Tips.Name = "TextBox_Tips"
        Me.TextBox_Tips.ReadOnly = True
        Me.TextBox_Tips.Size = New System.Drawing.Size(310, 172)
        Me.TextBox_Tips.TabIndex = 3
        '
        'LinkLabel_PreviousTip
        '
        Me.LinkLabel_PreviousTip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_PreviousTip.AutoSize = True
        Me.LinkLabel_PreviousTip.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_PreviousTip.Location = New System.Drawing.Point(325, 26)
        Me.LinkLabel_PreviousTip.Name = "LinkLabel_PreviousTip"
        Me.LinkLabel_PreviousTip.Size = New System.Drawing.Size(67, 13)
        Me.LinkLabel_PreviousTip.TabIndex = 5
        Me.LinkLabel_PreviousTip.TabStop = True
        Me.LinkLabel_PreviousTip.Text = "Previous tip"
        '
        'LinkLabel_NextTip
        '
        Me.LinkLabel_NextTip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_NextTip.AutoSize = True
        Me.LinkLabel_NextTip.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_NextTip.Location = New System.Drawing.Point(345, 9)
        Me.LinkLabel_NextTip.Margin = New System.Windows.Forms.Padding(3, 9, 3, 0)
        Me.LinkLabel_NextTip.Name = "LinkLabel_NextTip"
        Me.LinkLabel_NextTip.Size = New System.Drawing.Size(47, 13)
        Me.LinkLabel_NextTip.TabIndex = 6
        Me.LinkLabel_NextTip.TabStop = True
        Me.LinkLabel_NextTip.Text = "Next tip"
        '
        'ClassPictureBoxQuality1
        '
        Me.ClassPictureBoxQuality1.Image = Global.BasicPawn.My.Resources.Resources.Bmp_Tip
        Me.ClassPictureBoxQuality1.Location = New System.Drawing.Point(12, 12)
        Me.ClassPictureBoxQuality1.m_HighQuality = True
        Me.ClassPictureBoxQuality1.Name = "ClassPictureBoxQuality1"
        Me.ClassPictureBoxQuality1.Size = New System.Drawing.Size(64, 64)
        Me.ClassPictureBoxQuality1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClassPictureBoxQuality1.TabIndex = 4
        Me.ClassPictureBoxQuality1.TabStop = False
        '
        'FormTipOfTheDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 241)
        Me.Controls.Add(Me.ClassPictureBoxQuality1)
        Me.Controls.Add(Me.TextBox_Tips)
        Me.Controls.Add(Me.Panel_FooterControl)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 280)
        Me.Name = "FormTipOfTheDay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Did you know..."
        Me.Panel_FooterControl.ResumeLayout(False)
        Me.Panel_FooterControl.PerformLayout()
        CType(Me.ClassPictureBoxQuality1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_FooterControl As Panel
    Friend WithEvents Panel_FooterDarkControl As Panel
    Friend WithEvents CheckBox_DoNotShow As CheckBox
    Friend WithEvents TextBox_Tips As TextBox
    Friend WithEvents ClassPictureBoxQuality1 As ClassPictureBoxQuality
    Friend WithEvents LinkLabel_PreviousTip As LinkLabel
    Friend WithEvents LinkLabel_NextTip As LinkLabel
End Class
