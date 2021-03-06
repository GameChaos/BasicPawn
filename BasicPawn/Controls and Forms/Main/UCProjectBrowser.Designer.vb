﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCProjectBrowser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.ListView_ProjectFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip_ProjectFiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_ProjectLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_ProjectSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_ProjectSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_ProjectClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_CompileAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_TestAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_PackFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_ExtractFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_DeletePack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_AddTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_AddAllTabs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_AddFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_RelativeRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_RelativeEnable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_RelativeNoIncludes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_Exlcude = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem_MenuProjectLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_MenuProjectSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox_MenuProjectPath = New System.Windows.Forms.ToolStripTextBox()
        Me.TextboxWatermark_Search = New BasicPawn.ClassTextboxWatermark()
        Me.ContextMenuStrip_ProjectFiles.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView_ProjectFiles
        '
        Me.ListView_ProjectFiles.AllowDrop = True
        Me.ListView_ProjectFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_ProjectFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView_ProjectFiles.ContextMenuStrip = Me.ContextMenuStrip_ProjectFiles
        Me.ListView_ProjectFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_ProjectFiles.FullRowSelect = True
        Me.ListView_ProjectFiles.HideSelection = False
        Me.ListView_ProjectFiles.Location = New System.Drawing.Point(0, 46)
        Me.ListView_ProjectFiles.Margin = New System.Windows.Forms.Padding(0)
        Me.ListView_ProjectFiles.Name = "ListView_ProjectFiles"
        Me.ListView_ProjectFiles.ShowItemToolTips = True
        Me.ListView_ProjectFiles.Size = New System.Drawing.Size(276, 447)
        Me.ListView_ProjectFiles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView_ProjectFiles.TabIndex = 0
        Me.ListView_ProjectFiles.UseCompatibleStateImageBehavior = False
        Me.ListView_ProjectFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Path"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Packed"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Relative"
        Me.ColumnHeader4.Width = 50
        '
        'ContextMenuStrip_ProjectFiles
        '
        Me.ContextMenuStrip_ProjectFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Open, Me.ToolStripSeparator7, Me.ToolStripMenuItem_ProjectLoad, Me.ToolStripMenuItem_ProjectSave, Me.ToolStripMenuItem_ProjectSaveAs, Me.ToolStripMenuItem_ProjectClose, Me.ToolStripSeparator1, Me.ToolStripMenuItem_Cut, Me.ToolStripMenuItem_Copy, Me.ToolStripMenuItem_Paste, Me.ToolStripSeparator4, Me.ToolStripMenuItem_CompileAll, Me.ToolStripMenuItem_TestAll, Me.ToolStripSeparator3, Me.ToolStripMenuItem_PackFile, Me.ToolStripMenuItem_ExtractFile, Me.ToolStripMenuItem_DeletePack, Me.ToolStripSeparator5, Me.ToolStripMenuItem_AddTab, Me.ToolStripMenuItem_AddAllTabs, Me.ToolStripMenuItem_AddFiles, Me.ToolStripSeparator2, Me.ToolStripMenuItem_RelativeRefresh, Me.ToolStripMenuItem_RelativeEnable, Me.ToolStripMenuItem_RelativeNoIncludes, Me.ToolStripSeparator6, Me.ToolStripMenuItem_Exlcude})
        Me.ContextMenuStrip_ProjectFiles.Name = "ContextMenuStrip_ProjectFiles"
        Me.ContextMenuStrip_ProjectFiles.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip_ProjectFiles.Size = New System.Drawing.Size(229, 486)
        '
        'ToolStripMenuItem_Open
        '
        Me.ToolStripMenuItem_Open.Image = Global.BasicPawn.My.Resources.Resources.imageres_5338_16x16
        Me.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open"
        Me.ToolStripMenuItem_Open.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_Open.Text = "Open"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem_ProjectLoad
        '
        Me.ToolStripMenuItem_ProjectLoad.Image = Global.BasicPawn.My.Resources.Resources.imageres_5339_16x16
        Me.ToolStripMenuItem_ProjectLoad.Name = "ToolStripMenuItem_ProjectLoad"
        Me.ToolStripMenuItem_ProjectLoad.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_ProjectLoad.Text = "Load Project"
        '
        'ToolStripMenuItem_ProjectSave
        '
        Me.ToolStripMenuItem_ProjectSave.Image = Global.BasicPawn.My.Resources.Resources.imageres_5304_16x16
        Me.ToolStripMenuItem_ProjectSave.Name = "ToolStripMenuItem_ProjectSave"
        Me.ToolStripMenuItem_ProjectSave.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_ProjectSave.Text = "Save Project"
        '
        'ToolStripMenuItem_ProjectSaveAs
        '
        Me.ToolStripMenuItem_ProjectSaveAs.Name = "ToolStripMenuItem_ProjectSaveAs"
        Me.ToolStripMenuItem_ProjectSaveAs.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_ProjectSaveAs.Text = "Save Project as..."
        '
        'ToolStripMenuItem_ProjectClose
        '
        Me.ToolStripMenuItem_ProjectClose.Image = Global.BasicPawn.My.Resources.Resources.imageres_5320_16x16
        Me.ToolStripMenuItem_ProjectClose.Name = "ToolStripMenuItem_ProjectClose"
        Me.ToolStripMenuItem_ProjectClose.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_ProjectClose.Text = "Close Project"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem_Cut
        '
        Me.ToolStripMenuItem_Cut.Image = Global.BasicPawn.My.Resources.Resources.shell32_16762_16x16
        Me.ToolStripMenuItem_Cut.Name = "ToolStripMenuItem_Cut"
        Me.ToolStripMenuItem_Cut.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_Cut.Text = "Cut"
        '
        'ToolStripMenuItem_Copy
        '
        Me.ToolStripMenuItem_Copy.Image = Global.BasicPawn.My.Resources.Resources.imageres_5350_16x16
        Me.ToolStripMenuItem_Copy.Name = "ToolStripMenuItem_Copy"
        Me.ToolStripMenuItem_Copy.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_Copy.Text = "Copy"
        '
        'ToolStripMenuItem_Paste
        '
        Me.ToolStripMenuItem_Paste.Image = Global.BasicPawn.My.Resources.Resources.shell32_16763_16x16
        Me.ToolStripMenuItem_Paste.Name = "ToolStripMenuItem_Paste"
        Me.ToolStripMenuItem_Paste.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_Paste.Text = "Paste"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem_CompileAll
        '
        Me.ToolStripMenuItem_CompileAll.Image = Global.BasicPawn.My.Resources.Resources.imageres_5341_16x16
        Me.ToolStripMenuItem_CompileAll.Name = "ToolStripMenuItem_CompileAll"
        Me.ToolStripMenuItem_CompileAll.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_CompileAll.Text = "Compile"
        '
        'ToolStripMenuItem_TestAll
        '
        Me.ToolStripMenuItem_TestAll.Image = Global.BasicPawn.My.Resources.Resources.imageres_5342_16x16
        Me.ToolStripMenuItem_TestAll.Name = "ToolStripMenuItem_TestAll"
        Me.ToolStripMenuItem_TestAll.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_TestAll.Text = "Test"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem_PackFile
        '
        Me.ToolStripMenuItem_PackFile.Image = Global.BasicPawn.My.Resources.Resources.imageres_5326_16x16
        Me.ToolStripMenuItem_PackFile.Name = "ToolStripMenuItem_PackFile"
        Me.ToolStripMenuItem_PackFile.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_PackFile.Text = "Pack"
        Me.ToolStripMenuItem_PackFile.ToolTipText = "Packs the file into the project file. Can be used to make portable project files"
        '
        'ToolStripMenuItem_ExtractFile
        '
        Me.ToolStripMenuItem_ExtractFile.Image = Global.BasicPawn.My.Resources.Resources.imageres_5320_16x16
        Me.ToolStripMenuItem_ExtractFile.Name = "ToolStripMenuItem_ExtractFile"
        Me.ToolStripMenuItem_ExtractFile.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_ExtractFile.Text = "Extract"
        Me.ToolStripMenuItem_ExtractFile.ToolTipText = "Extracts the packed file from the project file"
        '
        'ToolStripMenuItem_DeletePack
        '
        Me.ToolStripMenuItem_DeletePack.Image = Global.BasicPawn.My.Resources.Resources.imageres_5318_16x16
        Me.ToolStripMenuItem_DeletePack.Name = "ToolStripMenuItem_DeletePack"
        Me.ToolStripMenuItem_DeletePack.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_DeletePack.Text = "Remove packed file"
        Me.ToolStripMenuItem_DeletePack.ToolTipText = "Removes the packed file from the project file"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem_AddTab
        '
        Me.ToolStripMenuItem_AddTab.Image = Global.BasicPawn.My.Resources.Resources.imageres_5367_16x16
        Me.ToolStripMenuItem_AddTab.Name = "ToolStripMenuItem_AddTab"
        Me.ToolStripMenuItem_AddTab.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_AddTab.Text = "Add this tab"
        Me.ToolStripMenuItem_AddTab.ToolTipText = "Adds the current tab to the project"
        '
        'ToolStripMenuItem_AddAllTabs
        '
        Me.ToolStripMenuItem_AddAllTabs.Name = "ToolStripMenuItem_AddAllTabs"
        Me.ToolStripMenuItem_AddAllTabs.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_AddAllTabs.Text = "Add all tabs"
        Me.ToolStripMenuItem_AddAllTabs.ToolTipText = "Adds all tabs to the project."
        '
        'ToolStripMenuItem_AddFiles
        '
        Me.ToolStripMenuItem_AddFiles.Name = "ToolStripMenuItem_AddFiles"
        Me.ToolStripMenuItem_AddFiles.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_AddFiles.Text = "Add files..."
        Me.ToolStripMenuItem_AddFiles.ToolTipText = "Adds custom files to the project."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem_RelativeRefresh
        '
        Me.ToolStripMenuItem_RelativeRefresh.Image = Global.BasicPawn.My.Resources.Resources.shell32_16739_16x16
        Me.ToolStripMenuItem_RelativeRefresh.Name = "ToolStripMenuItem_RelativeRefresh"
        Me.ToolStripMenuItem_RelativeRefresh.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_RelativeRefresh.Text = "Refresh relative paths"
        '
        'ToolStripMenuItem_RelativeEnable
        '
        Me.ToolStripMenuItem_RelativeEnable.CheckOnClick = True
        Me.ToolStripMenuItem_RelativeEnable.Name = "ToolStripMenuItem_RelativeEnable"
        Me.ToolStripMenuItem_RelativeEnable.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_RelativeEnable.Text = "Enable relative paths"
        '
        'ToolStripMenuItem_RelativeNoIncludes
        '
        Me.ToolStripMenuItem_RelativeNoIncludes.CheckOnClick = True
        Me.ToolStripMenuItem_RelativeNoIncludes.Name = "ToolStripMenuItem_RelativeNoIncludes"
        Me.ToolStripMenuItem_RelativeNoIncludes.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_RelativeNoIncludes.Text = "Filter out relative include files"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem_Exlcude
        '
        Me.ToolStripMenuItem_Exlcude.Image = Global.BasicPawn.My.Resources.Resources.imageres_5337_16x16
        Me.ToolStripMenuItem_Exlcude.Name = "ToolStripMenuItem_Exlcude"
        Me.ToolStripMenuItem_Exlcude.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem_Exlcude.Text = "Exclude from project"
        Me.ToolStripMenuItem_Exlcude.ToolTipText = "Exclude files from the project."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_MenuProjectLoad, Me.ToolStripMenuItem_MenuProjectSave, Me.ToolStripTextBox_MenuProjectPath})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 22)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(276, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem_MenuProjectLoad
        '
        Me.ToolStripMenuItem_MenuProjectLoad.AutoToolTip = True
        Me.ToolStripMenuItem_MenuProjectLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem_MenuProjectLoad.Image = Global.BasicPawn.My.Resources.Resources.imageres_5339_16x16
        Me.ToolStripMenuItem_MenuProjectLoad.Name = "ToolStripMenuItem_MenuProjectLoad"
        Me.ToolStripMenuItem_MenuProjectLoad.Size = New System.Drawing.Size(28, 24)
        Me.ToolStripMenuItem_MenuProjectLoad.Text = "Load Project"
        Me.ToolStripMenuItem_MenuProjectLoad.ToolTipText = "Load Project"
        '
        'ToolStripMenuItem_MenuProjectSave
        '
        Me.ToolStripMenuItem_MenuProjectSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem_MenuProjectSave.Image = Global.BasicPawn.My.Resources.Resources.imageres_5304_16x16
        Me.ToolStripMenuItem_MenuProjectSave.Name = "ToolStripMenuItem_MenuProjectSave"
        Me.ToolStripMenuItem_MenuProjectSave.Size = New System.Drawing.Size(28, 24)
        Me.ToolStripMenuItem_MenuProjectSave.Text = "Save Project"
        Me.ToolStripMenuItem_MenuProjectSave.ToolTipText = "Save Project"
        '
        'ToolStripTextBox_MenuProjectPath
        '
        Me.ToolStripTextBox_MenuProjectPath.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox_MenuProjectPath.Name = "ToolStripTextBox_MenuProjectPath"
        Me.ToolStripTextBox_MenuProjectPath.ReadOnly = True
        Me.ToolStripTextBox_MenuProjectPath.Size = New System.Drawing.Size(100, 24)
        '
        'TextboxWatermark_Search
        '
        Me.TextboxWatermark_Search.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextboxWatermark_Search.Location = New System.Drawing.Point(0, 0)
        Me.TextboxWatermark_Search.m_WatermarkText = "Search..."
        Me.TextboxWatermark_Search.Margin = New System.Windows.Forms.Padding(0)
        Me.TextboxWatermark_Search.Name = "TextboxWatermark_Search"
        Me.TextboxWatermark_Search.Size = New System.Drawing.Size(276, 22)
        Me.TextboxWatermark_Search.TabIndex = 1
        '
        'UCProjectBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ListView_ProjectFiles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextboxWatermark_Search)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UCProjectBrowser"
        Me.Size = New System.Drawing.Size(276, 493)
        Me.ContextMenuStrip_ProjectFiles.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents TextboxWatermark_Search As ClassTextboxWatermark
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Public WithEvents ContextMenuStrip_ProjectFiles As ContextMenuStrip
    Public WithEvents ToolStripMenuItem_Open As ToolStripMenuItem
    Public WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents ToolStripMenuItem_Cut As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_Copy As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_Paste As ToolStripMenuItem
    Public WithEvents ToolStripSeparator2 As ToolStripSeparator
    Public WithEvents ToolStripMenuItem_Exlcude As ToolStripMenuItem
    Public WithEvents ToolStripSeparator3 As ToolStripSeparator
    Public WithEvents ToolStripMenuItem_AddTab As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_AddAllTabs As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_AddFiles As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_ProjectSave As ToolStripMenuItem
    Public WithEvents ToolStripSeparator4 As ToolStripSeparator
    Public WithEvents ToolStripMenuItem_CompileAll As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_TestAll As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_PackFile As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem_ExtractFile As ToolStripMenuItem
    Public WithEvents ToolStripSeparator5 As ToolStripSeparator
    Public WithEvents ToolStripMenuItem_DeletePack As ToolStripMenuItem
    Public WithEvents ListView_ProjectFiles As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ToolStripMenuItem_RelativeRefresh As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_RelativeEnable As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_RelativeNoIncludes As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_ProjectSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_ProjectClose As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_ProjectLoad As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem_MenuProjectLoad As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox_MenuProjectPath As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem_MenuProjectSave As ToolStripMenuItem
End Class
