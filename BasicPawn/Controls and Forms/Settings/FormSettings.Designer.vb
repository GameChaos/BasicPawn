﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Apply = New System.Windows.Forms.Button()
        Me.ContextMenuStrip_Plugins = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_PluginsRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_OpenUrl = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_PluginsEnable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_PluginsDisable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip_Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList_Plugins = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New BasicPawn.ClassTabControlColor()
        Me.TabPage_Settings = New System.Windows.Forms.TabPage()
        Me.ClassTabControlColor1 = New BasicPawn.ClassTabControlColor()
        Me.TabPage_General = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button_ClearErrorLog = New System.Windows.Forms.Button()
        Me.Button_ViewErrorLog = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CheckBox_AssociateBasicPawnProject = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AssociateIncludes = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AssociateAmxMod = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AssociateSourcePawn = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_AutoOpenProjectFiles = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_AlwaysNewInstance = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoHoverScroll = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoShowStartPage = New System.Windows.Forms.CheckBox()
        Me.TabPage_Editor = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown_ThreadUpdateRate = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LinkLabel_ThreadUpdateRateHelp = New System.Windows.Forms.LinkLabel()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_IconBar = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_LineStateChanged = New System.Windows.Forms.RadioButton()
        Me.RadioButton_LineStateChangedSaved = New System.Windows.Forms.RadioButton()
        Me.RadioButton_LineStateNone = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NumericUpDown_LineStateCount = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Button_Font = New System.Windows.Forms.Button()
        Me.Label_Font = New System.Windows.Forms.Label()
        Me.CheckBox_InvertedColors = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_TabsToSpaces = New System.Windows.Forms.NumericUpDown()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CheckBox_TabsToSpace = New System.Windows.Forms.CheckBox()
        Me.TextBox_CustomSyntax = New System.Windows.Forms.TextBox()
        Me.Button_CustomSyntax = New System.Windows.Forms.Button()
        Me.LinkLabel_DefaultSyntax = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_MoreStyles = New System.Windows.Forms.LinkLabel()
        Me.CheckBox_RememberFolds = New System.Windows.Forms.CheckBox()
        Me.TabPage_Syntax = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_DoubleClickMark = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoMark = New System.Windows.Forms.CheckBox()
        Me.TabPage_Autocomplete = New System.Windows.Forms.TabPage()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_VarAutocompleteShowObjectBrowser = New System.Windows.Forms.CheckBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_WindowsToolTipPopup = New System.Windows.Forms.CheckBox()
        Me.CheckBox_WindowsToolTipNewlineMethods = New System.Windows.Forms.CheckBox()
        Me.CheckBox_WindowsToolTipDisplayTop = New System.Windows.Forms.CheckBox()
        Me.CheckBox_WindowsToolTipAnimations = New System.Windows.Forms.CheckBox()
        Me.CheckBox_OnScreenIntelliSense = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CommentsMethodIntelliSense = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CommentsAutocompleteIntelliSense = New System.Windows.Forms.CheckBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_FullAutcompleteMethods = New System.Windows.Forms.CheckBox()
        Me.CheckBox_FullAutocompleteReTagging = New System.Windows.Forms.CheckBox()
        Me.LinkLabel_FullAutocompleteReTaggingHelp = New System.Windows.Forms.LinkLabel()
        Me.CheckBox_AutoIndentBrackets = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CaseSensitive = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoCloseStrings = New System.Windows.Forms.CheckBox()
        Me.CheckBox_SwitchTabToAutocomplete = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoCloseBrackets = New System.Windows.Forms.CheckBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_AlwaysLoadDefaultIncludes = New System.Windows.Forms.CheckBox()
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_VarParseTab = New System.Windows.Forms.RadioButton()
        Me.RadioButton_VarParseTabInc = New System.Windows.Forms.RadioButton()
        Me.RadioButton_VarParseAll = New System.Windows.Forms.RadioButton()
        Me.TabPage_Configs = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Button_SaveConfig = New System.Windows.Forms.Button()
        Me.Label_ConfigName = New System.Windows.Forms.Label()
        Me.Button_ConfigRename = New System.Windows.Forms.Button()
        Me.TextBox_ConfigName = New System.Windows.Forms.TextBox()
        Me.Button_ConfigCopy = New System.Windows.Forms.Button()
        Me.Button_ConfigRemove = New System.Windows.Forms.Button()
        Me.Button_ConfigAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox_ConfigSettings = New System.Windows.Forms.GroupBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_Shell = New System.Windows.Forms.TextBox()
        Me.LinkLabel_ShowShellArguments = New System.Windows.Forms.LinkLabel()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ClientFolder = New System.Windows.Forms.TextBox()
        Me.Button_ClientFolder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_ServerFolder = New System.Windows.Forms.TextBox()
        Me.Button_ServerFolder = New System.Windows.Forms.Button()
        Me.TextBox_SourceModFolder = New System.Windows.Forms.TextBox()
        Me.Button_SourceModFolder = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel_DefaultConfigPathsHelp = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView_KnownFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button_KnownFileAdd = New System.Windows.Forms.Button()
        Me.Button_KnownFileRemove = New System.Windows.Forms.Button()
        Me.TextBox_AutoAssignPaths = New System.Windows.Forms.TextBox()
        Me.Button_AutoAssignPaths = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New BasicPawn.ClassTabControlColor()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBoxEx_CODefineConstantsSP = New BasicPawn.ClassTextboxWatermark()
        Me.TextBoxEx_COIgnoredWarningsSP = New BasicPawn.ClassTextboxWatermark()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ComboBox_COTreatWarningsAsErrorsSP = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBox_COVerbosityLevelSP = New System.Windows.Forms.ComboBox()
        Me.ComboBox_COOptimizationLevelSP = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ComboBox_COSymbolicInformationAMXX = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBoxEx_CODefineConstantsAMXX = New BasicPawn.ClassTextboxWatermark()
        Me.TextBoxEx_COIgnoredWarningsAMXX = New BasicPawn.ClassTextboxWatermark()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ComboBox_COTreatWarningsAsErrorsAMXX = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ComboBox_COVerbosityLevelAMXX = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox_Language = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton_ConfigSettingAutomatic = New System.Windows.Forms.RadioButton()
        Me.RadioButton_ConfigSettingManual = New System.Windows.Forms.RadioButton()
        Me.CheckBox_ConfigIsDefault = New System.Windows.Forms.CheckBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_CompilerPath = New System.Windows.Forms.TextBox()
        Me.Button_Compiler = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_IncludeFolder = New System.Windows.Forms.TextBox()
        Me.Button_IncludeFolder = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_OutputFolder = New System.Windows.Forms.TextBox()
        Me.Button_OutputFolder = New System.Windows.Forms.Button()
        Me.ListBox_Configs = New System.Windows.Forms.ListBox()
        Me.TabPage_Plugins = New System.Windows.Forms.TabPage()
        Me.LinkLabel_MorePlugins = New System.Windows.Forms.LinkLabel()
        Me.ListView_Plugins = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage_Database = New System.Windows.Forms.TabPage()
        Me.DatabaseListBox_Database = New BasicPawn.ClassDatabaseListBox()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClassPictureBoxQuality2 = New BasicPawn.ClassPictureBoxQuality()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button_AddDatabaseItem = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClassPictureBoxQuality1 = New BasicPawn.ClassPictureBoxQuality()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip_Plugins.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Settings.SuspendLayout()
        Me.ClassTabControlColor1.SuspendLayout()
        Me.TabPage_General.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage_Editor.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.NumericUpDown_ThreadUpdateRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumericUpDown_LineStateCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.NumericUpDown_TabsToSpaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Syntax.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.TabPage_Autocomplete.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage_Configs.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox_ConfigSettings.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.TabPage_Plugins.SuspendLayout()
        Me.TabPage_Database.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.ClassPictureBoxQuality2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ClassPictureBoxQuality1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Cancel.Location = New System.Drawing.Point(686, 1026)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(86, 23)
        Me.Button_Cancel.TabIndex = 1
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Apply
        '
        Me.Button_Apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button_Apply.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Apply.Location = New System.Drawing.Point(594, 1026)
        Me.Button_Apply.Name = "Button_Apply"
        Me.Button_Apply.Size = New System.Drawing.Size(86, 23)
        Me.Button_Apply.TabIndex = 2
        Me.Button_Apply.Text = "Apply"
        Me.Button_Apply.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip_Plugins
        '
        Me.ContextMenuStrip_Plugins.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_PluginsRefresh, Me.ToolStripSeparator1, Me.ToolStripMenuItem_OpenUrl, Me.ToolStripSeparator2, Me.ToolStripMenuItem_PluginsEnable, Me.ToolStripMenuItem_PluginsDisable})
        Me.ContextMenuStrip_Plugins.Name = "ContextMenuStrip_Plugins"
        Me.ContextMenuStrip_Plugins.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip_Plugins.Size = New System.Drawing.Size(128, 104)
        '
        'ToolStripMenuItem_PluginsRefresh
        '
        Me.ToolStripMenuItem_PluginsRefresh.Image = Global.BasicPawn.My.Resources.Resources.shell32_16739_16x16
        Me.ToolStripMenuItem_PluginsRefresh.Name = "ToolStripMenuItem_PluginsRefresh"
        Me.ToolStripMenuItem_PluginsRefresh.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem_PluginsRefresh.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(124, 6)
        '
        'ToolStripMenuItem_OpenUrl
        '
        Me.ToolStripMenuItem_OpenUrl.Image = Global.BasicPawn.My.Resources.Resources.imageres_5316_16x16
        Me.ToolStripMenuItem_OpenUrl.Name = "ToolStripMenuItem_OpenUrl"
        Me.ToolStripMenuItem_OpenUrl.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem_OpenUrl.Text = "Open URL"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(124, 6)
        '
        'ToolStripMenuItem_PluginsEnable
        '
        Me.ToolStripMenuItem_PluginsEnable.Name = "ToolStripMenuItem_PluginsEnable"
        Me.ToolStripMenuItem_PluginsEnable.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem_PluginsEnable.Text = "Enable"
        '
        'ToolStripMenuItem_PluginsDisable
        '
        Me.ToolStripMenuItem_PluginsDisable.Name = "ToolStripMenuItem_PluginsDisable"
        Me.ToolStripMenuItem_PluginsDisable.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItem_PluginsDisable.Text = "Disable"
        '
        'ToolTip_Info
        '
        Me.ToolTip_Info.AutoPopDelay = 30000
        Me.ToolTip_Info.InitialDelay = 500
        Me.ToolTip_Info.IsBalloon = True
        Me.ToolTip_Info.ReshowDelay = 100
        Me.ToolTip_Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip_Info.ToolTipTitle = "Information"
        '
        'ImageList_Plugins
        '
        Me.ImageList_Plugins.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList_Plugins.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList_Plugins.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage_Settings)
        Me.TabControl1.Controls.Add(Me.TabPage_Configs)
        Me.TabControl1.Controls.Add(Me.TabPage_Plugins)
        Me.TabControl1.Controls.Add(Me.TabPage_Database)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 1008)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Settings
        '
        Me.TabPage_Settings.Controls.Add(Me.ClassTabControlColor1)
        Me.TabPage_Settings.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Settings.Name = "TabPage_Settings"
        Me.TabPage_Settings.Size = New System.Drawing.Size(752, 982)
        Me.TabPage_Settings.TabIndex = 0
        Me.TabPage_Settings.Text = "Settings"
        Me.TabPage_Settings.UseVisualStyleBackColor = True
        '
        'ClassTabControlColor1
        '
        Me.ClassTabControlColor1.Controls.Add(Me.TabPage_General)
        Me.ClassTabControlColor1.Controls.Add(Me.TabPage_Editor)
        Me.ClassTabControlColor1.Controls.Add(Me.TabPage_Syntax)
        Me.ClassTabControlColor1.Controls.Add(Me.TabPage_Autocomplete)
        Me.ClassTabControlColor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassTabControlColor1.Location = New System.Drawing.Point(0, 0)
        Me.ClassTabControlColor1.Multiline = True
        Me.ClassTabControlColor1.Name = "ClassTabControlColor1"
        Me.ClassTabControlColor1.SelectedIndex = 0
        Me.ClassTabControlColor1.Size = New System.Drawing.Size(752, 982)
        Me.ClassTabControlColor1.TabIndex = 27
        '
        'TabPage_General
        '
        Me.TabPage_General.AutoScroll = True
        Me.TabPage_General.Controls.Add(Me.GroupBox9)
        Me.TabPage_General.Controls.Add(Me.GroupBox8)
        Me.TabPage_General.Controls.Add(Me.GroupBox7)
        Me.TabPage_General.Controls.Add(Me.GroupBox6)
        Me.TabPage_General.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_General.Name = "TabPage_General"
        Me.TabPage_General.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage_General.Size = New System.Drawing.Size(744, 956)
        Me.TabPage_General.TabIndex = 0
        Me.TabPage_General.Text = "General"
        Me.TabPage_General.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.Button_ClearErrorLog)
        Me.GroupBox9.Controls.Add(Me.Button_ViewErrorLog)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox9.Location = New System.Drawing.Point(6, 305)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(732, 59)
        Me.GroupBox9.TabIndex = 34
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Application Exceptions"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(9, 26)
        Me.Label30.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(147, 13)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "Application exception logs:"
        '
        'Button_ClearErrorLog
        '
        Me.Button_ClearErrorLog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ClearErrorLog.Location = New System.Drawing.Point(162, 21)
        Me.Button_ClearErrorLog.Name = "Button_ClearErrorLog"
        Me.Button_ClearErrorLog.Size = New System.Drawing.Size(150, 23)
        Me.Button_ClearErrorLog.TabIndex = 26
        Me.Button_ClearErrorLog.Text = "Clear log (Empty)"
        Me.Button_ClearErrorLog.UseVisualStyleBackColor = True
        '
        'Button_ViewErrorLog
        '
        Me.Button_ViewErrorLog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ViewErrorLog.Location = New System.Drawing.Point(318, 21)
        Me.Button_ViewErrorLog.Name = "Button_ViewErrorLog"
        Me.Button_ViewErrorLog.Size = New System.Drawing.Size(150, 23)
        Me.Button_ViewErrorLog.TabIndex = 27
        Me.Button_ViewErrorLog.Text = "View log"
        Me.Button_ViewErrorLog.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.CheckBox_AssociateBasicPawnProject)
        Me.GroupBox8.Controls.Add(Me.CheckBox_AssociateIncludes)
        Me.GroupBox8.Controls.Add(Me.CheckBox_AssociateAmxMod)
        Me.GroupBox8.Controls.Add(Me.CheckBox_AssociateSourcePawn)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(6, 161)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(732, 144)
        Me.GroupBox8.TabIndex = 33
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "File Association"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 21)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Associate BasicPawn with:"
        '
        'CheckBox_AssociateBasicPawnProject
        '
        Me.CheckBox_AssociateBasicPawnProject.AutoSize = True
        Me.CheckBox_AssociateBasicPawnProject.Checked = True
        Me.CheckBox_AssociateBasicPawnProject.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_AssociateBasicPawnProject.Enabled = False
        Me.CheckBox_AssociateBasicPawnProject.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AssociateBasicPawnProject.Location = New System.Drawing.Point(35, 112)
        Me.CheckBox_AssociateBasicPawnProject.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_AssociateBasicPawnProject.Name = "CheckBox_AssociateBasicPawnProject"
        Me.CheckBox_AssociateBasicPawnProject.Size = New System.Drawing.Size(200, 18)
        Me.CheckBox_AssociateBasicPawnProject.TabIndex = 24
        Me.CheckBox_AssociateBasicPawnProject.Text = "BasicPawn Project files (*.bpproj)"
        Me.CheckBox_AssociateBasicPawnProject.UseVisualStyleBackColor = True
        '
        'CheckBox_AssociateIncludes
        '
        Me.CheckBox_AssociateIncludes.AutoSize = True
        Me.CheckBox_AssociateIncludes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AssociateIncludes.Location = New System.Drawing.Point(35, 88)
        Me.CheckBox_AssociateIncludes.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_AssociateIncludes.Name = "CheckBox_AssociateIncludes"
        Me.CheckBox_AssociateIncludes.Size = New System.Drawing.Size(126, 18)
        Me.CheckBox_AssociateIncludes.TabIndex = 23
        Me.CheckBox_AssociateIncludes.Text = "Include files (*.inc)"
        Me.CheckBox_AssociateIncludes.UseVisualStyleBackColor = True
        '
        'CheckBox_AssociateAmxMod
        '
        Me.CheckBox_AssociateAmxMod.AutoSize = True
        Me.CheckBox_AssociateAmxMod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AssociateAmxMod.Location = New System.Drawing.Point(35, 64)
        Me.CheckBox_AssociateAmxMod.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_AssociateAmxMod.Name = "CheckBox_AssociateAmxMod"
        Me.CheckBox_AssociateAmxMod.Size = New System.Drawing.Size(152, 18)
        Me.CheckBox_AssociateAmxMod.TabIndex = 25
        Me.CheckBox_AssociateAmxMod.Text = "AMX Mod X files (*.sma)"
        Me.CheckBox_AssociateAmxMod.UseVisualStyleBackColor = True
        '
        'CheckBox_AssociateSourcePawn
        '
        Me.CheckBox_AssociateSourcePawn.AutoSize = True
        Me.CheckBox_AssociateSourcePawn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AssociateSourcePawn.Location = New System.Drawing.Point(35, 40)
        Me.CheckBox_AssociateSourcePawn.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_AssociateSourcePawn.Name = "CheckBox_AssociateSourcePawn"
        Me.CheckBox_AssociateSourcePawn.Size = New System.Drawing.Size(148, 18)
        Me.CheckBox_AssociateSourcePawn.TabIndex = 21
        Me.CheckBox_AssociateSourcePawn.Text = "SourcePawn files (*.sp)"
        Me.CheckBox_AssociateSourcePawn.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CheckBox_AutoOpenProjectFiles)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(6, 108)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(732, 53)
        Me.GroupBox7.TabIndex = 32
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Projects"
        '
        'CheckBox_AutoOpenProjectFiles
        '
        Me.CheckBox_AutoOpenProjectFiles.AutoSize = True
        Me.CheckBox_AutoOpenProjectFiles.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AutoOpenProjectFiles.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_AutoOpenProjectFiles.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AutoOpenProjectFiles.Name = "CheckBox_AutoOpenProjectFiles"
        Me.CheckBox_AutoOpenProjectFiles.Size = New System.Drawing.Size(336, 18)
        Me.CheckBox_AutoOpenProjectFiles.TabIndex = 29
        Me.CheckBox_AutoOpenProjectFiles.Text = "Automatically open all project files when opening a project"
        Me.CheckBox_AutoOpenProjectFiles.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckBox_AlwaysNewInstance)
        Me.GroupBox6.Controls.Add(Me.CheckBox_AutoHoverScroll)
        Me.GroupBox6.Controls.Add(Me.CheckBox_AutoShowStartPage)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(732, 102)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Behaviour"
        '
        'CheckBox_AlwaysNewInstance
        '
        Me.CheckBox_AlwaysNewInstance.AutoSize = True
        Me.CheckBox_AlwaysNewInstance.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AlwaysNewInstance.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_AlwaysNewInstance.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AlwaysNewInstance.Name = "CheckBox_AlwaysNewInstance"
        Me.CheckBox_AlwaysNewInstance.Size = New System.Drawing.Size(248, 18)
        Me.CheckBox_AlwaysNewInstance.TabIndex = 19
        Me.CheckBox_AlwaysNewInstance.Text = "Always open new instance instead of tabs"
        Me.CheckBox_AlwaysNewInstance.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoHoverScroll
        '
        Me.CheckBox_AutoHoverScroll.AutoSize = True
        Me.CheckBox_AutoHoverScroll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AutoHoverScroll.Location = New System.Drawing.Point(9, 69)
        Me.CheckBox_AutoHoverScroll.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AutoHoverScroll.Name = "CheckBox_AutoHoverScroll"
        Me.CheckBox_AutoHoverScroll.Size = New System.Drawing.Size(233, 18)
        Me.CheckBox_AutoHoverScroll.TabIndex = 30
        Me.CheckBox_AutoHoverScroll.Text = "Scroll inactive controls on mouse hover"
        Me.CheckBox_AutoHoverScroll.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoShowStartPage
        '
        Me.CheckBox_AutoShowStartPage.AutoSize = True
        Me.CheckBox_AutoShowStartPage.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AutoShowStartPage.Location = New System.Drawing.Point(9, 45)
        Me.CheckBox_AutoShowStartPage.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AutoShowStartPage.Name = "CheckBox_AutoShowStartPage"
        Me.CheckBox_AutoShowStartPage.Size = New System.Drawing.Size(235, 18)
        Me.CheckBox_AutoShowStartPage.TabIndex = 20
        Me.CheckBox_AutoShowStartPage.Text = "Show StartPage when no file is opened"
        Me.CheckBox_AutoShowStartPage.UseVisualStyleBackColor = True
        '
        'TabPage_Editor
        '
        Me.TabPage_Editor.AutoScroll = True
        Me.TabPage_Editor.Controls.Add(Me.GroupBox12)
        Me.TabPage_Editor.Controls.Add(Me.GroupBox11)
        Me.TabPage_Editor.Controls.Add(Me.GroupBox10)
        Me.TabPage_Editor.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Editor.Name = "TabPage_Editor"
        Me.TabPage_Editor.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage_Editor.Size = New System.Drawing.Size(744, 956)
        Me.TabPage_Editor.TabIndex = 1
        Me.TabPage_Editor.Text = "TextEditor"
        Me.TabPage_Editor.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label8)
        Me.GroupBox12.Controls.Add(Me.NumericUpDown_ThreadUpdateRate)
        Me.GroupBox12.Controls.Add(Me.Label14)
        Me.GroupBox12.Controls.Add(Me.LinkLabel_ThreadUpdateRateHelp)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox12.Location = New System.Drawing.Point(6, 373)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(732, 56)
        Me.GroupBox12.TabIndex = 35
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Threading"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 6, 3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Background thread update rate:"
        '
        'NumericUpDown_ThreadUpdateRate
        '
        Me.NumericUpDown_ThreadUpdateRate.Location = New System.Drawing.Point(185, 19)
        Me.NumericUpDown_ThreadUpdateRate.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.NumericUpDown_ThreadUpdateRate.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown_ThreadUpdateRate.Name = "NumericUpDown_ThreadUpdateRate"
        Me.NumericUpDown_ThreadUpdateRate.Size = New System.Drawing.Size(64, 22)
        Me.NumericUpDown_ThreadUpdateRate.TabIndex = 25
        Me.NumericUpDown_ThreadUpdateRate.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(258, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "ms"
        '
        'LinkLabel_ThreadUpdateRateHelp
        '
        Me.LinkLabel_ThreadUpdateRateHelp.AutoSize = True
        Me.LinkLabel_ThreadUpdateRateHelp.Location = New System.Drawing.Point(285, 24)
        Me.LinkLabel_ThreadUpdateRateHelp.Name = "LinkLabel_ThreadUpdateRateHelp"
        Me.LinkLabel_ThreadUpdateRateHelp.Size = New System.Drawing.Size(12, 13)
        Me.LinkLabel_ThreadUpdateRateHelp.TabIndex = 27
        Me.LinkLabel_ThreadUpdateRateHelp.TabStop = True
        Me.LinkLabel_ThreadUpdateRateHelp.Text = "?"
        Me.ToolTip_Info.SetToolTip(Me.LinkLabel_ThreadUpdateRateHelp, resources.GetString("LinkLabel_ThreadUpdateRateHelp.ToolTip"))
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CheckBox_IconBar)
        Me.GroupBox11.Controls.Add(Me.GroupBox5)
        Me.GroupBox11.Controls.Add(Me.Label16)
        Me.GroupBox11.Controls.Add(Me.Label15)
        Me.GroupBox11.Controls.Add(Me.NumericUpDown_LineStateCount)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox11.Location = New System.Drawing.Point(6, 193)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(732, 180)
        Me.GroupBox11.TabIndex = 34
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Icon Sidebar"
        '
        'CheckBox_IconBar
        '
        Me.CheckBox_IconBar.AutoSize = True
        Me.CheckBox_IconBar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_IconBar.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_IconBar.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_IconBar.Name = "CheckBox_IconBar"
        Me.CheckBox_IconBar.Size = New System.Drawing.Size(133, 18)
        Me.CheckBox_IconBar.TabIndex = 28
        Me.CheckBox_IconBar.Text = "Enable icon sidebar"
        Me.CheckBox_IconBar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton_LineStateChanged)
        Me.GroupBox5.Controls.Add(Me.RadioButton_LineStateChangedSaved)
        Me.GroupBox5.Controls.Add(Me.RadioButton_LineStateNone)
        Me.GroupBox5.Location = New System.Drawing.Point(35, 45)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(338, 94)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Line state style"
        '
        'RadioButton_LineStateChanged
        '
        Me.RadioButton_LineStateChanged.AutoSize = True
        Me.RadioButton_LineStateChanged.Location = New System.Drawing.Point(6, 67)
        Me.RadioButton_LineStateChanged.Name = "RadioButton_LineStateChanged"
        Me.RadioButton_LineStateChanged.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton_LineStateChanged.TabIndex = 32
        Me.RadioButton_LineStateChanged.TabStop = True
        Me.RadioButton_LineStateChanged.Text = "Changed only"
        Me.RadioButton_LineStateChanged.UseVisualStyleBackColor = True
        '
        'RadioButton_LineStateChangedSaved
        '
        Me.RadioButton_LineStateChangedSaved.AutoSize = True
        Me.RadioButton_LineStateChangedSaved.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton_LineStateChangedSaved.Name = "RadioButton_LineStateChangedSaved"
        Me.RadioButton_LineStateChangedSaved.Size = New System.Drawing.Size(128, 17)
        Me.RadioButton_LineStateChangedSaved.TabIndex = 31
        Me.RadioButton_LineStateChangedSaved.TabStop = True
        Me.RadioButton_LineStateChangedSaved.Text = "Changed and Saved"
        Me.RadioButton_LineStateChangedSaved.UseVisualStyleBackColor = True
        '
        'RadioButton_LineStateNone
        '
        Me.RadioButton_LineStateNone.AutoSize = True
        Me.RadioButton_LineStateNone.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton_LineStateNone.Name = "RadioButton_LineStateNone"
        Me.RadioButton_LineStateNone.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton_LineStateNone.TabIndex = 30
        Me.RadioButton_LineStateNone.TabStop = True
        Me.RadioButton_LineStateNone.Text = "None"
        Me.RadioButton_LineStateNone.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(230, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "(0 to show all)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 148)
        Me.Label15.Margin = New System.Windows.Forms.Padding(32, 6, 3, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Max line state history:"
        '
        'NumericUpDown_LineStateCount
        '
        Me.NumericUpDown_LineStateCount.Location = New System.Drawing.Point(160, 146)
        Me.NumericUpDown_LineStateCount.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.NumericUpDown_LineStateCount.Name = "NumericUpDown_LineStateCount"
        Me.NumericUpDown_LineStateCount.Size = New System.Drawing.Size(64, 22)
        Me.NumericUpDown_LineStateCount.TabIndex = 31
        Me.NumericUpDown_LineStateCount.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Button_Font)
        Me.GroupBox10.Controls.Add(Me.Label_Font)
        Me.GroupBox10.Controls.Add(Me.CheckBox_InvertedColors)
        Me.GroupBox10.Controls.Add(Me.NumericUpDown_TabsToSpaces)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.CheckBox_TabsToSpace)
        Me.GroupBox10.Controls.Add(Me.TextBox_CustomSyntax)
        Me.GroupBox10.Controls.Add(Me.Button_CustomSyntax)
        Me.GroupBox10.Controls.Add(Me.LinkLabel_DefaultSyntax)
        Me.GroupBox10.Controls.Add(Me.LinkLabel_MoreStyles)
        Me.GroupBox10.Controls.Add(Me.CheckBox_RememberFolds)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox10.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(732, 187)
        Me.GroupBox10.TabIndex = 33
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Editor"
        '
        'Button_Font
        '
        Me.Button_Font.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Font.Location = New System.Drawing.Point(9, 21)
        Me.Button_Font.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.Button_Font.Name = "Button_Font"
        Me.Button_Font.Size = New System.Drawing.Size(75, 23)
        Me.Button_Font.TabIndex = 11
        Me.Button_Font.Text = "Font"
        Me.Button_Font.UseVisualStyleBackColor = True
        '
        'Label_Font
        '
        Me.Label_Font.AutoSize = True
        Me.Label_Font.Location = New System.Drawing.Point(93, 26)
        Me.Label_Font.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.Label_Font.Name = "Label_Font"
        Me.Label_Font.Size = New System.Drawing.Size(73, 13)
        Me.Label_Font.TabIndex = 12
        Me.Label_Font.Text = "Current Font"
        '
        'CheckBox_InvertedColors
        '
        Me.CheckBox_InvertedColors.AutoSize = True
        Me.CheckBox_InvertedColors.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_InvertedColors.Location = New System.Drawing.Point(9, 50)
        Me.CheckBox_InvertedColors.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_InvertedColors.Name = "CheckBox_InvertedColors"
        Me.CheckBox_InvertedColors.Size = New System.Drawing.Size(134, 18)
        Me.CheckBox_InvertedColors.TabIndex = 13
        Me.CheckBox_InvertedColors.Text = "High contrast mode"
        Me.CheckBox_InvertedColors.UseVisualStyleBackColor = True
        '
        'NumericUpDown_TabsToSpaces
        '
        Me.NumericUpDown_TabsToSpaces.Location = New System.Drawing.Point(166, 70)
        Me.NumericUpDown_TabsToSpaces.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TabsToSpaces.Name = "NumericUpDown_TabsToSpaces"
        Me.NumericUpDown_TabsToSpaces.Size = New System.Drawing.Size(42, 22)
        Me.NumericUpDown_TabsToSpaces.TabIndex = 15
        Me.NumericUpDown_TabsToSpaces.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(9, 98)
        Me.Label32.Margin = New System.Windows.Forms.Padding(6, 3, 3, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(162, 13)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Custom syntax highlight path:"
        '
        'CheckBox_TabsToSpace
        '
        Me.CheckBox_TabsToSpace.AutoSize = True
        Me.CheckBox_TabsToSpace.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_TabsToSpace.Location = New System.Drawing.Point(9, 74)
        Me.CheckBox_TabsToSpace.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_TabsToSpace.Name = "CheckBox_TabsToSpace"
        Me.CheckBox_TabsToSpace.Size = New System.Drawing.Size(151, 18)
        Me.CheckBox_TabsToSpace.TabIndex = 14
        Me.CheckBox_TabsToSpace.Text = "Convert tabs to spaces:"
        Me.CheckBox_TabsToSpace.UseVisualStyleBackColor = True
        '
        'TextBox_CustomSyntax
        '
        Me.TextBox_CustomSyntax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CustomSyntax.Location = New System.Drawing.Point(9, 114)
        Me.TextBox_CustomSyntax.Name = "TextBox_CustomSyntax"
        Me.TextBox_CustomSyntax.Size = New System.Drawing.Size(679, 22)
        Me.TextBox_CustomSyntax.TabIndex = 19
        '
        'Button_CustomSyntax
        '
        Me.Button_CustomSyntax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_CustomSyntax.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_CustomSyntax.Location = New System.Drawing.Point(694, 114)
        Me.Button_CustomSyntax.Name = "Button_CustomSyntax"
        Me.Button_CustomSyntax.Size = New System.Drawing.Size(32, 23)
        Me.Button_CustomSyntax.TabIndex = 20
        Me.Button_CustomSyntax.Text = "..."
        Me.Button_CustomSyntax.UseVisualStyleBackColor = True
        '
        'LinkLabel_DefaultSyntax
        '
        Me.LinkLabel_DefaultSyntax.AutoSize = True
        Me.LinkLabel_DefaultSyntax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_DefaultSyntax.Location = New System.Drawing.Point(9, 139)
        Me.LinkLabel_DefaultSyntax.Margin = New System.Windows.Forms.Padding(6, 0, 3, 3)
        Me.LinkLabel_DefaultSyntax.Name = "LinkLabel_DefaultSyntax"
        Me.LinkLabel_DefaultSyntax.Size = New System.Drawing.Size(148, 13)
        Me.LinkLabel_DefaultSyntax.TabIndex = 21
        Me.LinkLabel_DefaultSyntax.TabStop = True
        Me.LinkLabel_DefaultSyntax.Text = "Default syntax highlighting"
        '
        'LinkLabel_MoreStyles
        '
        Me.LinkLabel_MoreStyles.AutoSize = True
        Me.LinkLabel_MoreStyles.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_MoreStyles.Location = New System.Drawing.Point(166, 139)
        Me.LinkLabel_MoreStyles.Margin = New System.Windows.Forms.Padding(6, 0, 3, 3)
        Me.LinkLabel_MoreStyles.Name = "LinkLabel_MoreStyles"
        Me.LinkLabel_MoreStyles.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel_MoreStyles.TabIndex = 22
        Me.LinkLabel_MoreStyles.TabStop = True
        Me.LinkLabel_MoreStyles.Text = "Get more syntax styles"
        '
        'CheckBox_RememberFolds
        '
        Me.CheckBox_RememberFolds.AutoSize = True
        Me.CheckBox_RememberFolds.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_RememberFolds.Location = New System.Drawing.Point(9, 158)
        Me.CheckBox_RememberFolds.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_RememberFolds.Name = "CheckBox_RememberFolds"
        Me.CheckBox_RememberFolds.Size = New System.Drawing.Size(132, 18)
        Me.CheckBox_RememberFolds.TabIndex = 23
        Me.CheckBox_RememberFolds.Text = "Remember foldings"
        Me.CheckBox_RememberFolds.UseVisualStyleBackColor = True
        '
        'TabPage_Syntax
        '
        Me.TabPage_Syntax.AutoScroll = True
        Me.TabPage_Syntax.Controls.Add(Me.GroupBox13)
        Me.TabPage_Syntax.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Syntax.Name = "TabPage_Syntax"
        Me.TabPage_Syntax.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage_Syntax.Size = New System.Drawing.Size(744, 956)
        Me.TabPage_Syntax.TabIndex = 2
        Me.TabPage_Syntax.Text = "Syntax Highlighting"
        Me.TabPage_Syntax.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.CheckBox_DoubleClickMark)
        Me.GroupBox13.Controls.Add(Me.CheckBox_AutoMark)
        Me.GroupBox13.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox13.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(732, 75)
        Me.GroupBox13.TabIndex = 18
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Word Marks"
        '
        'CheckBox_DoubleClickMark
        '
        Me.CheckBox_DoubleClickMark.AutoSize = True
        Me.CheckBox_DoubleClickMark.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_DoubleClickMark.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_DoubleClickMark.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_DoubleClickMark.Name = "CheckBox_DoubleClickMark"
        Me.CheckBox_DoubleClickMark.Size = New System.Drawing.Size(190, 18)
        Me.CheckBox_DoubleClickMark.TabIndex = 5
        Me.CheckBox_DoubleClickMark.Text = "Mark words using double click"
        Me.CheckBox_DoubleClickMark.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoMark
        '
        Me.CheckBox_AutoMark.AutoSize = True
        Me.CheckBox_AutoMark.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AutoMark.Location = New System.Drawing.Point(9, 45)
        Me.CheckBox_AutoMark.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AutoMark.Name = "CheckBox_AutoMark"
        Me.CheckBox_AutoMark.Size = New System.Drawing.Size(164, 18)
        Me.CheckBox_AutoMark.TabIndex = 17
        Me.CheckBox_AutoMark.Text = "Automatically mark words"
        Me.CheckBox_AutoMark.UseVisualStyleBackColor = True
        '
        'TabPage_Autocomplete
        '
        Me.TabPage_Autocomplete.AutoScroll = True
        Me.TabPage_Autocomplete.Controls.Add(Me.GroupBox17)
        Me.TabPage_Autocomplete.Controls.Add(Me.GroupBox16)
        Me.TabPage_Autocomplete.Controls.Add(Me.GroupBox15)
        Me.TabPage_Autocomplete.Controls.Add(Me.GroupBox14)
        Me.TabPage_Autocomplete.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Autocomplete.Name = "TabPage_Autocomplete"
        Me.TabPage_Autocomplete.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage_Autocomplete.Size = New System.Drawing.Size(744, 956)
        Me.TabPage_Autocomplete.TabIndex = 3
        Me.TabPage_Autocomplete.Text = "Autocomplete & IntelliSense"
        Me.TabPage_Autocomplete.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.CheckBox_VarAutocompleteShowObjectBrowser)
        Me.GroupBox17.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox17.Location = New System.Drawing.Point(6, 594)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(732, 51)
        Me.GroupBox17.TabIndex = 33
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Object Browser"
        '
        'CheckBox_VarAutocompleteShowObjectBrowser
        '
        Me.CheckBox_VarAutocompleteShowObjectBrowser.AutoSize = True
        Me.CheckBox_VarAutocompleteShowObjectBrowser.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_VarAutocompleteShowObjectBrowser.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_VarAutocompleteShowObjectBrowser.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_VarAutocompleteShowObjectBrowser.Name = "CheckBox_VarAutocompleteShowObjectBrowser"
        Me.CheckBox_VarAutocompleteShowObjectBrowser.Size = New System.Drawing.Size(224, 18)
        Me.CheckBox_VarAutocompleteShowObjectBrowser.TabIndex = 18
        Me.CheckBox_VarAutocompleteShowObjectBrowser.Text = "Show variables in the Object Browser"
        Me.CheckBox_VarAutocompleteShowObjectBrowser.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.GroupBox18)
        Me.GroupBox16.Controls.Add(Me.CheckBox_OnScreenIntelliSense)
        Me.GroupBox16.Controls.Add(Me.CheckBox_CommentsMethodIntelliSense)
        Me.GroupBox16.Controls.Add(Me.CheckBox_CommentsAutocompleteIntelliSense)
        Me.GroupBox16.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox16.Location = New System.Drawing.Point(6, 374)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(732, 220)
        Me.GroupBox16.TabIndex = 32
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "IntelliSense"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.CheckBox_WindowsToolTipPopup)
        Me.GroupBox18.Controls.Add(Me.CheckBox_WindowsToolTipNewlineMethods)
        Me.GroupBox18.Controls.Add(Me.CheckBox_WindowsToolTipDisplayTop)
        Me.GroupBox18.Controls.Add(Me.CheckBox_WindowsToolTipAnimations)
        Me.GroupBox18.Location = New System.Drawing.Point(35, 93)
        Me.GroupBox18.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(278, 120)
        Me.GroupBox18.TabIndex = 29
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "ToolTip Popup"
        '
        'CheckBox_WindowsToolTipPopup
        '
        Me.CheckBox_WindowsToolTipPopup.AutoSize = True
        Me.CheckBox_WindowsToolTipPopup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_WindowsToolTipPopup.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_WindowsToolTipPopup.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_WindowsToolTipPopup.Name = "CheckBox_WindowsToolTipPopup"
        Me.CheckBox_WindowsToolTipPopup.Size = New System.Drawing.Size(143, 18)
        Me.CheckBox_WindowsToolTipPopup.TabIndex = 16
        Me.CheckBox_WindowsToolTipPopup.Text = "Enable tooltip popup"
        Me.CheckBox_WindowsToolTipPopup.UseVisualStyleBackColor = True
        '
        'CheckBox_WindowsToolTipNewlineMethods
        '
        Me.CheckBox_WindowsToolTipNewlineMethods.AutoSize = True
        Me.CheckBox_WindowsToolTipNewlineMethods.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_WindowsToolTipNewlineMethods.Location = New System.Drawing.Point(35, 69)
        Me.CheckBox_WindowsToolTipNewlineMethods.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_WindowsToolTipNewlineMethods.Name = "CheckBox_WindowsToolTipNewlineMethods"
        Me.CheckBox_WindowsToolTipNewlineMethods.Size = New System.Drawing.Size(175, 18)
        Me.CheckBox_WindowsToolTipNewlineMethods.TabIndex = 22
        Me.CheckBox_WindowsToolTipNewlineMethods.Text = "Newline method arguments"
        Me.CheckBox_WindowsToolTipNewlineMethods.UseVisualStyleBackColor = True
        '
        'CheckBox_WindowsToolTipDisplayTop
        '
        Me.CheckBox_WindowsToolTipDisplayTop.AutoSize = True
        Me.CheckBox_WindowsToolTipDisplayTop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_WindowsToolTipDisplayTop.Location = New System.Drawing.Point(35, 93)
        Me.CheckBox_WindowsToolTipDisplayTop.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_WindowsToolTipDisplayTop.Name = "CheckBox_WindowsToolTipDisplayTop"
        Me.CheckBox_WindowsToolTipDisplayTop.Size = New System.Drawing.Size(169, 18)
        Me.CheckBox_WindowsToolTipDisplayTop.TabIndex = 28
        Me.CheckBox_WindowsToolTipDisplayTop.Text = "Display tooltip above caret"
        Me.CheckBox_WindowsToolTipDisplayTop.UseVisualStyleBackColor = True
        '
        'CheckBox_WindowsToolTipAnimations
        '
        Me.CheckBox_WindowsToolTipAnimations.AutoSize = True
        Me.CheckBox_WindowsToolTipAnimations.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_WindowsToolTipAnimations.Location = New System.Drawing.Point(35, 45)
        Me.CheckBox_WindowsToolTipAnimations.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_WindowsToolTipAnimations.Name = "CheckBox_WindowsToolTipAnimations"
        Me.CheckBox_WindowsToolTipAnimations.Size = New System.Drawing.Size(204, 18)
        Me.CheckBox_WindowsToolTipAnimations.TabIndex = 21
        Me.CheckBox_WindowsToolTipAnimations.Text = "Smooth tooltip popup movement"
        Me.CheckBox_WindowsToolTipAnimations.UseVisualStyleBackColor = True
        '
        'CheckBox_OnScreenIntelliSense
        '
        Me.CheckBox_OnScreenIntelliSense.AutoSize = True
        Me.CheckBox_OnScreenIntelliSense.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_OnScreenIntelliSense.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_OnScreenIntelliSense.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_OnScreenIntelliSense.Name = "CheckBox_OnScreenIntelliSense"
        Me.CheckBox_OnScreenIntelliSense.Size = New System.Drawing.Size(129, 18)
        Me.CheckBox_OnScreenIntelliSense.TabIndex = 2
        Me.CheckBox_OnScreenIntelliSense.Text = "Enable IntelliSense"
        Me.CheckBox_OnScreenIntelliSense.UseVisualStyleBackColor = True
        '
        'CheckBox_CommentsMethodIntelliSense
        '
        Me.CheckBox_CommentsMethodIntelliSense.AutoSize = True
        Me.CheckBox_CommentsMethodIntelliSense.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_CommentsMethodIntelliSense.Location = New System.Drawing.Point(35, 45)
        Me.CheckBox_CommentsMethodIntelliSense.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_CommentsMethodIntelliSense.Name = "CheckBox_CommentsMethodIntelliSense"
        Me.CheckBox_CommentsMethodIntelliSense.Size = New System.Drawing.Size(319, 18)
        Me.CheckBox_CommentsMethodIntelliSense.TabIndex = 6
        Me.CheckBox_CommentsMethodIntelliSense.Text = "Display comments for methods in on-screen IntelliSense"
        Me.CheckBox_CommentsMethodIntelliSense.UseVisualStyleBackColor = True
        '
        'CheckBox_CommentsAutocompleteIntelliSense
        '
        Me.CheckBox_CommentsAutocompleteIntelliSense.AutoSize = True
        Me.CheckBox_CommentsAutocompleteIntelliSense.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_CommentsAutocompleteIntelliSense.Location = New System.Drawing.Point(35, 69)
        Me.CheckBox_CommentsAutocompleteIntelliSense.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
        Me.CheckBox_CommentsAutocompleteIntelliSense.Name = "CheckBox_CommentsAutocompleteIntelliSense"
        Me.CheckBox_CommentsAutocompleteIntelliSense.Size = New System.Drawing.Size(356, 18)
        Me.CheckBox_CommentsAutocompleteIntelliSense.TabIndex = 7
        Me.CheckBox_CommentsAutocompleteIntelliSense.Text = "Display comments for autocompletion in on-screen IntelliSense"
        Me.CheckBox_CommentsAutocompleteIntelliSense.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.CheckBox_FullAutcompleteMethods)
        Me.GroupBox15.Controls.Add(Me.CheckBox_FullAutocompleteReTagging)
        Me.GroupBox15.Controls.Add(Me.LinkLabel_FullAutocompleteReTaggingHelp)
        Me.GroupBox15.Controls.Add(Me.CheckBox_AutoIndentBrackets)
        Me.GroupBox15.Controls.Add(Me.CheckBox_CaseSensitive)
        Me.GroupBox15.Controls.Add(Me.CheckBox_AutoCloseStrings)
        Me.GroupBox15.Controls.Add(Me.CheckBox_SwitchTabToAutocomplete)
        Me.GroupBox15.Controls.Add(Me.CheckBox_AutoCloseBrackets)
        Me.GroupBox15.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox15.Location = New System.Drawing.Point(6, 176)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(732, 198)
        Me.GroupBox15.TabIndex = 31
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Autocompletion"
        '
        'CheckBox_FullAutcompleteMethods
        '
        Me.CheckBox_FullAutcompleteMethods.AutoSize = True
        Me.CheckBox_FullAutcompleteMethods.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_FullAutcompleteMethods.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_FullAutcompleteMethods.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_FullAutcompleteMethods.Name = "CheckBox_FullAutcompleteMethods"
        Me.CheckBox_FullAutcompleteMethods.Size = New System.Drawing.Size(202, 18)
        Me.CheckBox_FullAutcompleteMethods.TabIndex = 3
        Me.CheckBox_FullAutcompleteMethods.Text = "Full autocompletion for methods"
        Me.CheckBox_FullAutcompleteMethods.UseVisualStyleBackColor = True
        '
        'CheckBox_FullAutocompleteReTagging
        '
        Me.CheckBox_FullAutocompleteReTagging.AutoSize = True
        Me.CheckBox_FullAutocompleteReTagging.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_FullAutocompleteReTagging.Location = New System.Drawing.Point(9, 45)
        Me.CheckBox_FullAutocompleteReTagging.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_FullAutocompleteReTagging.Name = "CheckBox_FullAutocompleteReTagging"
        Me.CheckBox_FullAutocompleteReTagging.Size = New System.Drawing.Size(281, 18)
        Me.CheckBox_FullAutocompleteReTagging.TabIndex = 8
        Me.CheckBox_FullAutocompleteReTagging.Text = "Full autocompletion for enums using re-tagging"
        Me.CheckBox_FullAutocompleteReTagging.UseVisualStyleBackColor = True
        '
        'LinkLabel_FullAutocompleteReTaggingHelp
        '
        Me.LinkLabel_FullAutocompleteReTaggingHelp.AutoSize = True
        Me.LinkLabel_FullAutocompleteReTaggingHelp.Location = New System.Drawing.Point(293, 47)
        Me.LinkLabel_FullAutocompleteReTaggingHelp.Name = "LinkLabel_FullAutocompleteReTaggingHelp"
        Me.LinkLabel_FullAutocompleteReTaggingHelp.Size = New System.Drawing.Size(12, 13)
        Me.LinkLabel_FullAutocompleteReTaggingHelp.TabIndex = 29
        Me.LinkLabel_FullAutocompleteReTaggingHelp.TabStop = True
        Me.LinkLabel_FullAutocompleteReTaggingHelp.Text = "?"
        Me.ToolTip_Info.SetToolTip(Me.LinkLabel_FullAutocompleteReTaggingHelp, "Make enums look more ""strongly typed"" using re-tagging." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Eg. 'Enum:Name' instead " &
        "of 'Name'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NOTE: This can not be used with SourcePawn transitional syntax.")
        '
        'CheckBox_AutoIndentBrackets
        '
        Me.CheckBox_AutoIndentBrackets.AutoSize = True
        Me.CheckBox_AutoIndentBrackets.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AutoIndentBrackets.Location = New System.Drawing.Point(9, 165)
        Me.CheckBox_AutoIndentBrackets.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AutoIndentBrackets.Name = "CheckBox_AutoIndentBrackets"
        Me.CheckBox_AutoIndentBrackets.Size = New System.Drawing.Size(236, 18)
        Me.CheckBox_AutoIndentBrackets.TabIndex = 26
        Me.CheckBox_AutoIndentBrackets.Text = "Automatically indent brackets on return"
        Me.CheckBox_AutoIndentBrackets.UseVisualStyleBackColor = True
        '
        'CheckBox_CaseSensitive
        '
        Me.CheckBox_CaseSensitive.AutoSize = True
        Me.CheckBox_CaseSensitive.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_CaseSensitive.Location = New System.Drawing.Point(9, 69)
        Me.CheckBox_CaseSensitive.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_CaseSensitive.Name = "CheckBox_CaseSensitive"
        Me.CheckBox_CaseSensitive.Size = New System.Drawing.Size(103, 18)
        Me.CheckBox_CaseSensitive.TabIndex = 15
        Me.CheckBox_CaseSensitive.Text = "Case sensitive"
        Me.CheckBox_CaseSensitive.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoCloseStrings
        '
        Me.CheckBox_AutoCloseStrings.AutoSize = True
        Me.CheckBox_AutoCloseStrings.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AutoCloseStrings.Location = New System.Drawing.Point(9, 141)
        Me.CheckBox_AutoCloseStrings.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AutoCloseStrings.Name = "CheckBox_AutoCloseStrings"
        Me.CheckBox_AutoCloseStrings.Size = New System.Drawing.Size(239, 18)
        Me.CheckBox_AutoCloseStrings.TabIndex = 25
        Me.CheckBox_AutoCloseStrings.Text = "Automatically close strings while writing"
        Me.CheckBox_AutoCloseStrings.UseVisualStyleBackColor = True
        '
        'CheckBox_SwitchTabToAutocomplete
        '
        Me.CheckBox_SwitchTabToAutocomplete.AutoSize = True
        Me.CheckBox_SwitchTabToAutocomplete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_SwitchTabToAutocomplete.Location = New System.Drawing.Point(9, 93)
        Me.CheckBox_SwitchTabToAutocomplete.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_SwitchTabToAutocomplete.Name = "CheckBox_SwitchTabToAutocomplete"
        Me.CheckBox_SwitchTabToAutocomplete.Size = New System.Drawing.Size(326, 18)
        Me.CheckBox_SwitchTabToAutocomplete.TabIndex = 20
        Me.CheckBox_SwitchTabToAutocomplete.Text = "Automatically switch tab to 'Autocomplete && IntelliSense'"
        Me.CheckBox_SwitchTabToAutocomplete.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoCloseBrackets
        '
        Me.CheckBox_AutoCloseBrackets.AutoSize = True
        Me.CheckBox_AutoCloseBrackets.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AutoCloseBrackets.Location = New System.Drawing.Point(9, 117)
        Me.CheckBox_AutoCloseBrackets.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AutoCloseBrackets.Name = "CheckBox_AutoCloseBrackets"
        Me.CheckBox_AutoCloseBrackets.Size = New System.Drawing.Size(247, 18)
        Me.CheckBox_AutoCloseBrackets.TabIndex = 24
        Me.CheckBox_AutoCloseBrackets.Text = "Automatically close brackets while writing"
        Me.CheckBox_AutoCloseBrackets.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.CheckBox_AlwaysLoadDefaultIncludes)
        Me.GroupBox14.Controls.Add(Me.CheckBox_OnlyUpdateSyntaxWhenFocused)
        Me.GroupBox14.Controls.Add(Me.GroupBox4)
        Me.GroupBox14.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox14.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(732, 170)
        Me.GroupBox14.TabIndex = 30
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Parsing Behaviour"
        '
        'CheckBox_AlwaysLoadDefaultIncludes
        '
        Me.CheckBox_AlwaysLoadDefaultIncludes.AutoSize = True
        Me.CheckBox_AlwaysLoadDefaultIncludes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_AlwaysLoadDefaultIncludes.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox_AlwaysLoadDefaultIncludes.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_AlwaysLoadDefaultIncludes.Name = "CheckBox_AlwaysLoadDefaultIncludes"
        Me.CheckBox_AlwaysLoadDefaultIncludes.Size = New System.Drawing.Size(198, 18)
        Me.CheckBox_AlwaysLoadDefaultIncludes.TabIndex = 19
        Me.CheckBox_AlwaysLoadDefaultIncludes.Text = "Always load default include files"
        Me.CheckBox_AlwaysLoadDefaultIncludes.UseVisualStyleBackColor = True
        '
        'CheckBox_OnlyUpdateSyntaxWhenFocused
        '
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.AutoSize = True
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.Location = New System.Drawing.Point(9, 45)
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.Name = "CheckBox_OnlyUpdateSyntaxWhenFocused"
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.Size = New System.Drawing.Size(248, 18)
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.TabIndex = 23
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.Text = "Only update when the window is focused"
        Me.CheckBox_OnlyUpdateSyntaxWhenFocused.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton_VarParseTab)
        Me.GroupBox4.Controls.Add(Me.RadioButton_VarParseTabInc)
        Me.GroupBox4.Controls.Add(Me.RadioButton_VarParseAll)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(437, 92)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Variable parsing behaviour"
        '
        'RadioButton_VarParseTab
        '
        Me.RadioButton_VarParseTab.AutoSize = True
        Me.RadioButton_VarParseTab.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton_VarParseTab.Location = New System.Drawing.Point(6, 67)
        Me.RadioButton_VarParseTab.Name = "RadioButton_VarParseTab"
        Me.RadioButton_VarParseTab.Size = New System.Drawing.Size(192, 18)
        Me.RadioButton_VarParseTab.TabIndex = 2
        Me.RadioButton_VarParseTab.Text = "Parse from active tab only (Fast)"
        Me.RadioButton_VarParseTab.UseVisualStyleBackColor = True
        '
        'RadioButton_VarParseTabInc
        '
        Me.RadioButton_VarParseTabInc.AutoSize = True
        Me.RadioButton_VarParseTabInc.Checked = True
        Me.RadioButton_VarParseTabInc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton_VarParseTabInc.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton_VarParseTabInc.Name = "RadioButton_VarParseTabInc"
        Me.RadioButton_VarParseTabInc.Size = New System.Drawing.Size(407, 18)
        Me.RadioButton_VarParseTabInc.TabIndex = 1
        Me.RadioButton_VarParseTabInc.TabStop = True
        Me.RadioButton_VarParseTabInc.Text = "Parse from active tab and all source includes (*.sp, * .sma, *.p, *.pwn) only"
        Me.RadioButton_VarParseTabInc.UseVisualStyleBackColor = True
        '
        'RadioButton_VarParseAll
        '
        Me.RadioButton_VarParseAll.AutoSize = True
        Me.RadioButton_VarParseAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton_VarParseAll.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton_VarParseAll.Name = "RadioButton_VarParseAll"
        Me.RadioButton_VarParseAll.Size = New System.Drawing.Size(180, 18)
        Me.RadioButton_VarParseAll.TabIndex = 0
        Me.RadioButton_VarParseAll.Text = "Parse from all includes (Slow)"
        Me.RadioButton_VarParseAll.UseVisualStyleBackColor = True
        '
        'TabPage_Configs
        '
        Me.TabPage_Configs.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage_Configs.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Configs.Name = "TabPage_Configs"
        Me.TabPage_Configs.Size = New System.Drawing.Size(752, 982)
        Me.TabPage_Configs.TabIndex = 1
        Me.TabPage_Configs.Text = "Configs"
        Me.TabPage_Configs.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox_Configs, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(752, 982)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel17, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(150, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(602, 982)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Button_SaveConfig)
        Me.Panel17.Controls.Add(Me.Label_ConfigName)
        Me.Panel17.Controls.Add(Me.Button_ConfigRename)
        Me.Panel17.Controls.Add(Me.TextBox_ConfigName)
        Me.Panel17.Controls.Add(Me.Button_ConfigCopy)
        Me.Panel17.Controls.Add(Me.Button_ConfigRemove)
        Me.Panel17.Controls.Add(Me.Button_ConfigAdd)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(602, 100)
        Me.Panel17.TabIndex = 0
        '
        'Button_SaveConfig
        '
        Me.Button_SaveConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_SaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_SaveConfig.Location = New System.Drawing.Point(471, 74)
        Me.Button_SaveConfig.Name = "Button_SaveConfig"
        Me.Button_SaveConfig.Size = New System.Drawing.Size(128, 23)
        Me.Button_SaveConfig.TabIndex = 12
        Me.Button_SaveConfig.Text = "Save Settings"
        Me.Button_SaveConfig.UseVisualStyleBackColor = True
        '
        'Label_ConfigName
        '
        Me.Label_ConfigName.AutoSize = True
        Me.Label_ConfigName.Location = New System.Drawing.Point(3, 0)
        Me.Label_ConfigName.Name = "Label_ConfigName"
        Me.Label_ConfigName.Size = New System.Drawing.Size(77, 13)
        Me.Label_ConfigName.TabIndex = 1
        Me.Label_ConfigName.Text = "Config Name:"
        '
        'Button_ConfigRename
        '
        Me.Button_ConfigRename.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ConfigRename.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ConfigRename.Location = New System.Drawing.Point(237, 44)
        Me.Button_ConfigRename.Name = "Button_ConfigRename"
        Me.Button_ConfigRename.Size = New System.Drawing.Size(86, 23)
        Me.Button_ConfigRename.TabIndex = 9
        Me.Button_ConfigRename.Text = "Rename"
        Me.Button_ConfigRename.UseVisualStyleBackColor = True
        '
        'TextBox_ConfigName
        '
        Me.TextBox_ConfigName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ConfigName.Location = New System.Drawing.Point(3, 16)
        Me.TextBox_ConfigName.Name = "TextBox_ConfigName"
        Me.TextBox_ConfigName.Size = New System.Drawing.Size(596, 22)
        Me.TextBox_ConfigName.TabIndex = 2
        '
        'Button_ConfigCopy
        '
        Me.Button_ConfigCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ConfigCopy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ConfigCopy.Location = New System.Drawing.Point(329, 44)
        Me.Button_ConfigCopy.Name = "Button_ConfigCopy"
        Me.Button_ConfigCopy.Size = New System.Drawing.Size(86, 23)
        Me.Button_ConfigCopy.TabIndex = 8
        Me.Button_ConfigCopy.Text = "Copy"
        Me.Button_ConfigCopy.UseVisualStyleBackColor = True
        '
        'Button_ConfigRemove
        '
        Me.Button_ConfigRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ConfigRemove.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ConfigRemove.Location = New System.Drawing.Point(513, 44)
        Me.Button_ConfigRemove.Name = "Button_ConfigRemove"
        Me.Button_ConfigRemove.Size = New System.Drawing.Size(86, 23)
        Me.Button_ConfigRemove.TabIndex = 4
        Me.Button_ConfigRemove.Text = "Remove"
        Me.Button_ConfigRemove.UseVisualStyleBackColor = True
        '
        'Button_ConfigAdd
        '
        Me.Button_ConfigAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ConfigAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ConfigAdd.Location = New System.Drawing.Point(421, 44)
        Me.Button_ConfigAdd.Name = "Button_ConfigAdd"
        Me.Button_ConfigAdd.Size = New System.Drawing.Size(86, 23)
        Me.Button_ConfigAdd.TabIndex = 5
        Me.Button_ConfigAdd.Text = "Add"
        Me.Button_ConfigAdd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.GroupBox_ConfigSettings)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 882)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox_ConfigSettings
        '
        Me.GroupBox_ConfigSettings.AutoSize = True
        Me.GroupBox_ConfigSettings.Controls.Add(Me.GroupBox21)
        Me.GroupBox_ConfigSettings.Controls.Add(Me.GroupBox20)
        Me.GroupBox_ConfigSettings.Controls.Add(Me.GroupBox1)
        Me.GroupBox_ConfigSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox_ConfigSettings.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_ConfigSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox_ConfigSettings.Name = "GroupBox_ConfigSettings"
        Me.GroupBox_ConfigSettings.Size = New System.Drawing.Size(585, 978)
        Me.GroupBox_ConfigSettings.TabIndex = 7
        Me.GroupBox_ConfigSettings.TabStop = False
        Me.GroupBox_ConfigSettings.Text = "Config Settings"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.Label10)
        Me.GroupBox21.Controls.Add(Me.TextBox_Shell)
        Me.GroupBox21.Controls.Add(Me.LinkLabel_ShowShellArguments)
        Me.GroupBox21.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox21.Location = New System.Drawing.Point(3, 875)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(579, 100)
        Me.GroupBox21.TabIndex = 29
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Misc"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Execute Shell:"
        '
        'TextBox_Shell
        '
        Me.TextBox_Shell.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Shell.BackColor = System.Drawing.Color.White
        Me.TextBox_Shell.Location = New System.Drawing.Point(6, 34)
        Me.TextBox_Shell.Name = "TextBox_Shell"
        Me.TextBox_Shell.Size = New System.Drawing.Size(567, 22)
        Me.TextBox_Shell.TabIndex = 29
        '
        'LinkLabel_ShowShellArguments
        '
        Me.LinkLabel_ShowShellArguments.AutoSize = True
        Me.LinkLabel_ShowShellArguments.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_ShowShellArguments.Location = New System.Drawing.Point(6, 59)
        Me.LinkLabel_ShowShellArguments.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.LinkLabel_ShowShellArguments.Name = "LinkLabel_ShowShellArguments"
        Me.LinkLabel_ShowShellArguments.Size = New System.Drawing.Size(136, 13)
        Me.LinkLabel_ShowShellArguments.TabIndex = 30
        Me.LinkLabel_ShowShellArguments.TabStop = True
        Me.LinkLabel_ShowShellArguments.Text = "Show all shell arguments"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.Label1)
        Me.GroupBox20.Controls.Add(Me.TextBox_ClientFolder)
        Me.GroupBox20.Controls.Add(Me.Button_ClientFolder)
        Me.GroupBox20.Controls.Add(Me.Label2)
        Me.GroupBox20.Controls.Add(Me.TextBox_ServerFolder)
        Me.GroupBox20.Controls.Add(Me.Button_ServerFolder)
        Me.GroupBox20.Controls.Add(Me.TextBox_SourceModFolder)
        Me.GroupBox20.Controls.Add(Me.Button_SourceModFolder)
        Me.GroupBox20.Controls.Add(Me.Label12)
        Me.GroupBox20.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox20.Location = New System.Drawing.Point(3, 728)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(579, 147)
        Me.GroupBox20.TabIndex = 45
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Debugging"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Client directory:"
        '
        'TextBox_ClientFolder
        '
        Me.TextBox_ClientFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ClientFolder.BackColor = System.Drawing.Color.White
        Me.TextBox_ClientFolder.Location = New System.Drawing.Point(6, 34)
        Me.TextBox_ClientFolder.Name = "TextBox_ClientFolder"
        Me.TextBox_ClientFolder.Size = New System.Drawing.Size(530, 22)
        Me.TextBox_ClientFolder.TabIndex = 39
        '
        'Button_ClientFolder
        '
        Me.Button_ClientFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ClientFolder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ClientFolder.Location = New System.Drawing.Point(542, 31)
        Me.Button_ClientFolder.Name = "Button_ClientFolder"
        Me.Button_ClientFolder.Size = New System.Drawing.Size(31, 24)
        Me.Button_ClientFolder.TabIndex = 40
        Me.Button_ClientFolder.Text = "..."
        Me.Button_ClientFolder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Server directory:"
        '
        'TextBox_ServerFolder
        '
        Me.TextBox_ServerFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ServerFolder.BackColor = System.Drawing.Color.White
        Me.TextBox_ServerFolder.Location = New System.Drawing.Point(6, 75)
        Me.TextBox_ServerFolder.Name = "TextBox_ServerFolder"
        Me.TextBox_ServerFolder.Size = New System.Drawing.Size(530, 22)
        Me.TextBox_ServerFolder.TabIndex = 32
        '
        'Button_ServerFolder
        '
        Me.Button_ServerFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ServerFolder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_ServerFolder.Location = New System.Drawing.Point(542, 72)
        Me.Button_ServerFolder.Name = "Button_ServerFolder"
        Me.Button_ServerFolder.Size = New System.Drawing.Size(31, 24)
        Me.Button_ServerFolder.TabIndex = 33
        Me.Button_ServerFolder.Text = "..."
        Me.Button_ServerFolder.UseVisualStyleBackColor = True
        '
        'TextBox_SourceModFolder
        '
        Me.TextBox_SourceModFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_SourceModFolder.BackColor = System.Drawing.Color.White
        Me.TextBox_SourceModFolder.Location = New System.Drawing.Point(6, 116)
        Me.TextBox_SourceModFolder.Name = "TextBox_SourceModFolder"
        Me.TextBox_SourceModFolder.Size = New System.Drawing.Size(530, 22)
        Me.TextBox_SourceModFolder.TabIndex = 36
        '
        'Button_SourceModFolder
        '
        Me.Button_SourceModFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_SourceModFolder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_SourceModFolder.Location = New System.Drawing.Point(542, 113)
        Me.Button_SourceModFolder.Name = "Button_SourceModFolder"
        Me.Button_SourceModFolder.Size = New System.Drawing.Size(31, 24)
        Me.Button_SourceModFolder.TabIndex = 37
        Me.Button_SourceModFolder.Text = "..."
        Me.Button_SourceModFolder.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "SourceMod directory:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel_DefaultConfigPathsHelp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox_AutoAssignPaths)
        Me.GroupBox1.Controls.Add(Me.Button_AutoAssignPaths)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Language)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RadioButton_ConfigSettingAutomatic)
        Me.GroupBox1.Controls.Add(Me.RadioButton_ConfigSettingManual)
        Me.GroupBox1.Controls.Add(Me.CheckBox_ConfigIsDefault)
        Me.GroupBox1.Controls.Add(Me.GroupBox19)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 710)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'LinkLabel_DefaultConfigPathsHelp
        '
        Me.LinkLabel_DefaultConfigPathsHelp.AutoSize = True
        Me.LinkLabel_DefaultConfigPathsHelp.Location = New System.Drawing.Point(209, 244)
        Me.LinkLabel_DefaultConfigPathsHelp.Name = "LinkLabel_DefaultConfigPathsHelp"
        Me.LinkLabel_DefaultConfigPathsHelp.Size = New System.Drawing.Size(12, 13)
        Me.LinkLabel_DefaultConfigPathsHelp.TabIndex = 44
        Me.LinkLabel_DefaultConfigPathsHelp.TabStop = True
        Me.LinkLabel_DefaultConfigPathsHelp.Text = "?"
        Me.ToolTip_Info.SetToolTip(Me.LinkLabel_DefaultConfigPathsHelp, "Opening a file from those paths will automatically switch to this config." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Howeve" &
        "r, files in 'Known files' overwrite this behaviour.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Default config paths (Seperate by ';'):"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.ListView_KnownFiles)
        Me.GroupBox3.Controls.Add(Me.Button_KnownFileAdd)
        Me.GroupBox3.Controls.Add(Me.Button_KnownFileRemove)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(567, 190)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Known Files"
        '
        'ListView_KnownFiles
        '
        Me.ListView_KnownFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_KnownFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.ListView_KnownFiles.Location = New System.Drawing.Point(6, 21)
        Me.ListView_KnownFiles.Name = "ListView_KnownFiles"
        Me.ListView_KnownFiles.Size = New System.Drawing.Size(555, 134)
        Me.ListView_KnownFiles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView_KnownFiles.TabIndex = 3
        Me.ListView_KnownFiles.UseCompatibleStateImageBehavior = False
        Me.ListView_KnownFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "File"
        '
        'Button_KnownFileAdd
        '
        Me.Button_KnownFileAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_KnownFileAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_KnownFileAdd.Location = New System.Drawing.Point(383, 161)
        Me.Button_KnownFileAdd.Name = "Button_KnownFileAdd"
        Me.Button_KnownFileAdd.Size = New System.Drawing.Size(86, 23)
        Me.Button_KnownFileAdd.TabIndex = 2
        Me.Button_KnownFileAdd.Text = "Add"
        Me.Button_KnownFileAdd.UseVisualStyleBackColor = True
        '
        'Button_KnownFileRemove
        '
        Me.Button_KnownFileRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_KnownFileRemove.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_KnownFileRemove.Location = New System.Drawing.Point(475, 161)
        Me.Button_KnownFileRemove.Name = "Button_KnownFileRemove"
        Me.Button_KnownFileRemove.Size = New System.Drawing.Size(86, 23)
        Me.Button_KnownFileRemove.TabIndex = 1
        Me.Button_KnownFileRemove.Text = "Remove"
        Me.Button_KnownFileRemove.UseVisualStyleBackColor = True
        '
        'TextBox_AutoAssignPaths
        '
        Me.TextBox_AutoAssignPaths.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_AutoAssignPaths.BackColor = System.Drawing.Color.White
        Me.TextBox_AutoAssignPaths.Location = New System.Drawing.Point(9, 260)
        Me.TextBox_AutoAssignPaths.Name = "TextBox_AutoAssignPaths"
        Me.TextBox_AutoAssignPaths.Size = New System.Drawing.Size(527, 22)
        Me.TextBox_AutoAssignPaths.TabIndex = 35
        '
        'Button_AutoAssignPaths
        '
        Me.Button_AutoAssignPaths.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_AutoAssignPaths.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_AutoAssignPaths.Location = New System.Drawing.Point(542, 258)
        Me.Button_AutoAssignPaths.Name = "Button_AutoAssignPaths"
        Me.Button_AutoAssignPaths.Size = New System.Drawing.Size(31, 24)
        Me.Button_AutoAssignPaths.TabIndex = 36
        Me.Button_AutoAssignPaths.Text = "..."
        Me.Button_AutoAssignPaths.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 315)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 191)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compiler Options"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 18)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(561, 170)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.TextBoxEx_CODefineConstantsSP)
        Me.TabPage1.Controls.Add(Me.TextBoxEx_COIgnoredWarningsSP)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.ComboBox_COTreatWarningsAsErrorsSP)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.ComboBox_COVerbosityLevelSP)
        Me.TabPage1.Controls.Add(Me.ComboBox_COOptimizationLevelSP)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 144)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SourcePawn"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(175, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Define constants (Separate by ';')"
        '
        'TextBoxEx_CODefineConstantsSP
        '
        Me.TextBoxEx_CODefineConstantsSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEx_CODefineConstantsSP.Location = New System.Drawing.Point(198, 115)
        Me.TextBoxEx_CODefineConstantsSP.m_WatermarkText = "sym=val;sym2=val..."
        Me.TextBoxEx_CODefineConstantsSP.Name = "TextBoxEx_CODefineConstantsSP"
        Me.TextBoxEx_CODefineConstantsSP.Size = New System.Drawing.Size(349, 22)
        Me.TextBoxEx_CODefineConstantsSP.TabIndex = 8
        '
        'TextBoxEx_COIgnoredWarningsSP
        '
        Me.TextBoxEx_COIgnoredWarningsSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEx_COIgnoredWarningsSP.Location = New System.Drawing.Point(198, 87)
        Me.TextBoxEx_COIgnoredWarningsSP.m_WatermarkText = "100;101..."
        Me.TextBoxEx_COIgnoredWarningsSP.Name = "TextBoxEx_COIgnoredWarningsSP"
        Me.TextBoxEx_COIgnoredWarningsSP.Size = New System.Drawing.Size(349, 22)
        Me.TextBoxEx_COIgnoredWarningsSP.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(180, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Ignored warnings (Separate by ';')"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(129, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Treat warnings as errors"
        '
        'ComboBox_COTreatWarningsAsErrorsSP
        '
        Me.ComboBox_COTreatWarningsAsErrorsSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_COTreatWarningsAsErrorsSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_COTreatWarningsAsErrorsSP.FormattingEnabled = True
        Me.ComboBox_COTreatWarningsAsErrorsSP.Location = New System.Drawing.Point(198, 60)
        Me.ComboBox_COTreatWarningsAsErrorsSP.Name = "ComboBox_COTreatWarningsAsErrorsSP"
        Me.ComboBox_COTreatWarningsAsErrorsSP.Size = New System.Drawing.Size(349, 21)
        Me.ComboBox_COTreatWarningsAsErrorsSP.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Verbosity level"
        '
        'ComboBox_COVerbosityLevelSP
        '
        Me.ComboBox_COVerbosityLevelSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_COVerbosityLevelSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_COVerbosityLevelSP.FormattingEnabled = True
        Me.ComboBox_COVerbosityLevelSP.Location = New System.Drawing.Point(198, 33)
        Me.ComboBox_COVerbosityLevelSP.Name = "ComboBox_COVerbosityLevelSP"
        Me.ComboBox_COVerbosityLevelSP.Size = New System.Drawing.Size(349, 21)
        Me.ComboBox_COVerbosityLevelSP.TabIndex = 2
        '
        'ComboBox_COOptimizationLevelSP
        '
        Me.ComboBox_COOptimizationLevelSP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_COOptimizationLevelSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_COOptimizationLevelSP.FormattingEnabled = True
        Me.ComboBox_COOptimizationLevelSP.Location = New System.Drawing.Point(198, 6)
        Me.ComboBox_COOptimizationLevelSP.Name = "ComboBox_COOptimizationLevelSP"
        Me.ComboBox_COOptimizationLevelSP.Size = New System.Drawing.Size(349, 21)
        Me.ComboBox_COOptimizationLevelSP.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Optimization level"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.ComboBox_COSymbolicInformationAMXX)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.TextBoxEx_CODefineConstantsAMXX)
        Me.TabPage2.Controls.Add(Me.TextBoxEx_COIgnoredWarningsAMXX)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.ComboBox_COTreatWarningsAsErrorsAMXX)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.ComboBox_COVerbosityLevelAMXX)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(553, 146)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "AMX Mod X"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(116, 13)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "Symbolic information"
        '
        'ComboBox_COSymbolicInformationAMXX
        '
        Me.ComboBox_COSymbolicInformationAMXX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_COSymbolicInformationAMXX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_COSymbolicInformationAMXX.FormattingEnabled = True
        Me.ComboBox_COSymbolicInformationAMXX.Location = New System.Drawing.Point(198, 6)
        Me.ComboBox_COSymbolicInformationAMXX.Name = "ComboBox_COSymbolicInformationAMXX"
        Me.ComboBox_COSymbolicInformationAMXX.Size = New System.Drawing.Size(349, 21)
        Me.ComboBox_COSymbolicInformationAMXX.TabIndex = 20
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(175, 13)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Define constants (Separate by ';')"
        '
        'TextBoxEx_CODefineConstantsAMXX
        '
        Me.TextBoxEx_CODefineConstantsAMXX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEx_CODefineConstantsAMXX.Location = New System.Drawing.Point(198, 115)
        Me.TextBoxEx_CODefineConstantsAMXX.m_WatermarkText = "sym=val;sym2=val..."
        Me.TextBoxEx_CODefineConstantsAMXX.Name = "TextBoxEx_CODefineConstantsAMXX"
        Me.TextBoxEx_CODefineConstantsAMXX.Size = New System.Drawing.Size(349, 22)
        Me.TextBoxEx_CODefineConstantsAMXX.TabIndex = 18
        '
        'TextBoxEx_COIgnoredWarningsAMXX
        '
        Me.TextBoxEx_COIgnoredWarningsAMXX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEx_COIgnoredWarningsAMXX.Location = New System.Drawing.Point(198, 87)
        Me.TextBoxEx_COIgnoredWarningsAMXX.m_WatermarkText = "100;101..."
        Me.TextBoxEx_COIgnoredWarningsAMXX.Name = "TextBoxEx_COIgnoredWarningsAMXX"
        Me.TextBoxEx_COIgnoredWarningsAMXX.Size = New System.Drawing.Size(349, 22)
        Me.TextBoxEx_COIgnoredWarningsAMXX.TabIndex = 17
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 90)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(180, 13)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Ignored warnings (Separate by ';')"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 63)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(129, 13)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Treat warnings as errors"
        '
        'ComboBox_COTreatWarningsAsErrorsAMXX
        '
        Me.ComboBox_COTreatWarningsAsErrorsAMXX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_COTreatWarningsAsErrorsAMXX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_COTreatWarningsAsErrorsAMXX.FormattingEnabled = True
        Me.ComboBox_COTreatWarningsAsErrorsAMXX.Location = New System.Drawing.Point(198, 60)
        Me.ComboBox_COTreatWarningsAsErrorsAMXX.Name = "ComboBox_COTreatWarningsAsErrorsAMXX"
        Me.ComboBox_COTreatWarningsAsErrorsAMXX.Size = New System.Drawing.Size(349, 21)
        Me.ComboBox_COTreatWarningsAsErrorsAMXX.TabIndex = 14
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 36)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 13)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "Verbosity level"
        '
        'ComboBox_COVerbosityLevelAMXX
        '
        Me.ComboBox_COVerbosityLevelAMXX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_COVerbosityLevelAMXX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_COVerbosityLevelAMXX.FormattingEnabled = True
        Me.ComboBox_COVerbosityLevelAMXX.Location = New System.Drawing.Point(198, 33)
        Me.ComboBox_COVerbosityLevelAMXX.Name = "ComboBox_COVerbosityLevelAMXX"
        Me.ComboBox_COVerbosityLevelAMXX.Size = New System.Drawing.Size(349, 21)
        Me.ComboBox_COVerbosityLevelAMXX.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 291)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Language:"
        '
        'ComboBox_Language
        '
        Me.ComboBox_Language.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Language.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox_Language.FormattingEnabled = True
        Me.ComboBox_Language.Location = New System.Drawing.Point(361, 288)
        Me.ComboBox_Language.Name = "ComboBox_Language"
        Me.ComboBox_Language.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox_Language.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(19, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(16, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(554, 28)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Automatically detect compiler path and include folder from currently opened sourc" &
    "e file."
        '
        'RadioButton_ConfigSettingAutomatic
        '
        Me.RadioButton_ConfigSettingAutomatic.AutoSize = True
        Me.RadioButton_ConfigSettingAutomatic.Checked = True
        Me.RadioButton_ConfigSettingAutomatic.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton_ConfigSettingAutomatic.Location = New System.Drawing.Point(9, 21)
        Me.RadioButton_ConfigSettingAutomatic.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.RadioButton_ConfigSettingAutomatic.Name = "RadioButton_ConfigSettingAutomatic"
        Me.RadioButton_ConfigSettingAutomatic.Size = New System.Drawing.Size(83, 18)
        Me.RadioButton_ConfigSettingAutomatic.TabIndex = 31
        Me.RadioButton_ConfigSettingAutomatic.TabStop = True
        Me.RadioButton_ConfigSettingAutomatic.Text = "Automatic"
        Me.RadioButton_ConfigSettingAutomatic.UseVisualStyleBackColor = True
        '
        'RadioButton_ConfigSettingManual
        '
        Me.RadioButton_ConfigSettingManual.AutoSize = True
        Me.RadioButton_ConfigSettingManual.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton_ConfigSettingManual.Location = New System.Drawing.Point(9, 73)
        Me.RadioButton_ConfigSettingManual.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.RadioButton_ConfigSettingManual.Name = "RadioButton_ConfigSettingManual"
        Me.RadioButton_ConfigSettingManual.Size = New System.Drawing.Size(70, 18)
        Me.RadioButton_ConfigSettingManual.TabIndex = 32
        Me.RadioButton_ConfigSettingManual.Text = "Manual"
        '
        'CheckBox_ConfigIsDefault
        '
        Me.CheckBox_ConfigIsDefault.AutoSize = True
        Me.CheckBox_ConfigIsDefault.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_ConfigIsDefault.Location = New System.Drawing.Point(9, 223)
        Me.CheckBox_ConfigIsDefault.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.CheckBox_ConfigIsDefault.Name = "CheckBox_ConfigIsDefault"
        Me.CheckBox_ConfigIsDefault.Size = New System.Drawing.Size(160, 18)
        Me.CheckBox_ConfigIsDefault.TabIndex = 39
        Me.CheckBox_ConfigIsDefault.Text = "Set this config as default"
        Me.CheckBox_ConfigIsDefault.UseVisualStyleBackColor = True
        '
        'GroupBox19
        '
        Me.GroupBox19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox19.Controls.Add(Me.Label4)
        Me.GroupBox19.Controls.Add(Me.TextBox_CompilerPath)
        Me.GroupBox19.Controls.Add(Me.Button_Compiler)
        Me.GroupBox19.Controls.Add(Me.Label5)
        Me.GroupBox19.Controls.Add(Me.TextBox_IncludeFolder)
        Me.GroupBox19.Controls.Add(Me.Button_IncludeFolder)
        Me.GroupBox19.Controls.Add(Me.Label6)
        Me.GroupBox19.Controls.Add(Me.TextBox_OutputFolder)
        Me.GroupBox19.Controls.Add(Me.Button_OutputFolder)
        Me.GroupBox19.Location = New System.Drawing.Point(6, 73)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(567, 144)
        Me.GroupBox19.TabIndex = 38
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "                    "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Compiler path:"
        '
        'TextBox_CompilerPath
        '
        Me.TextBox_CompilerPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CompilerPath.BackColor = System.Drawing.Color.White
        Me.TextBox_CompilerPath.Location = New System.Drawing.Point(6, 36)
        Me.TextBox_CompilerPath.Name = "TextBox_CompilerPath"
        Me.TextBox_CompilerPath.Size = New System.Drawing.Size(518, 22)
        Me.TextBox_CompilerPath.TabIndex = 8
        '
        'Button_Compiler
        '
        Me.Button_Compiler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Compiler.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Compiler.Location = New System.Drawing.Point(530, 34)
        Me.Button_Compiler.Name = "Button_Compiler"
        Me.Button_Compiler.Size = New System.Drawing.Size(31, 24)
        Me.Button_Compiler.TabIndex = 8
        Me.Button_Compiler.Text = "..."
        Me.Button_Compiler.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Include directory (Separate by ';'):"
        '
        'TextBox_IncludeFolder
        '
        Me.TextBox_IncludeFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_IncludeFolder.BackColor = System.Drawing.Color.White
        Me.TextBox_IncludeFolder.Location = New System.Drawing.Point(6, 75)
        Me.TextBox_IncludeFolder.Name = "TextBox_IncludeFolder"
        Me.TextBox_IncludeFolder.Size = New System.Drawing.Size(518, 22)
        Me.TextBox_IncludeFolder.TabIndex = 10
        '
        'Button_IncludeFolder
        '
        Me.Button_IncludeFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_IncludeFolder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_IncludeFolder.Location = New System.Drawing.Point(530, 73)
        Me.Button_IncludeFolder.Name = "Button_IncludeFolder"
        Me.Button_IncludeFolder.Size = New System.Drawing.Size(31, 24)
        Me.Button_IncludeFolder.TabIndex = 11
        Me.Button_IncludeFolder.Text = "..."
        Me.Button_IncludeFolder.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Output directory:"
        '
        'TextBox_OutputFolder
        '
        Me.TextBox_OutputFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_OutputFolder.BackColor = System.Drawing.Color.White
        Me.TextBox_OutputFolder.Location = New System.Drawing.Point(6, 114)
        Me.TextBox_OutputFolder.Name = "TextBox_OutputFolder"
        Me.TextBox_OutputFolder.Size = New System.Drawing.Size(518, 22)
        Me.TextBox_OutputFolder.TabIndex = 14
        '
        'Button_OutputFolder
        '
        Me.Button_OutputFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_OutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_OutputFolder.Location = New System.Drawing.Point(530, 112)
        Me.Button_OutputFolder.Name = "Button_OutputFolder"
        Me.Button_OutputFolder.Size = New System.Drawing.Size(31, 24)
        Me.Button_OutputFolder.TabIndex = 15
        Me.Button_OutputFolder.Text = "..."
        Me.Button_OutputFolder.UseVisualStyleBackColor = True
        '
        'ListBox_Configs
        '
        Me.ListBox_Configs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox_Configs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Configs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_Configs.FormattingEnabled = True
        Me.ListBox_Configs.HorizontalScrollbar = True
        Me.ListBox_Configs.ItemHeight = 21
        Me.ListBox_Configs.Location = New System.Drawing.Point(3, 3)
        Me.ListBox_Configs.Name = "ListBox_Configs"
        Me.ListBox_Configs.Size = New System.Drawing.Size(144, 976)
        Me.ListBox_Configs.TabIndex = 0
        '
        'TabPage_Plugins
        '
        Me.TabPage_Plugins.Controls.Add(Me.LinkLabel_MorePlugins)
        Me.TabPage_Plugins.Controls.Add(Me.ListView_Plugins)
        Me.TabPage_Plugins.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Plugins.Name = "TabPage_Plugins"
        Me.TabPage_Plugins.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Plugins.Size = New System.Drawing.Size(752, 982)
        Me.TabPage_Plugins.TabIndex = 2
        Me.TabPage_Plugins.Text = "Plugins"
        Me.TabPage_Plugins.UseVisualStyleBackColor = True
        '
        'LinkLabel_MorePlugins
        '
        Me.LinkLabel_MorePlugins.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_MorePlugins.AutoSize = True
        Me.LinkLabel_MorePlugins.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel_MorePlugins.Location = New System.Drawing.Point(6, 963)
        Me.LinkLabel_MorePlugins.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabel_MorePlugins.Name = "LinkLabel_MorePlugins"
        Me.LinkLabel_MorePlugins.Size = New System.Drawing.Size(105, 13)
        Me.LinkLabel_MorePlugins.TabIndex = 1
        Me.LinkLabel_MorePlugins.TabStop = True
        Me.LinkLabel_MorePlugins.Text = "Get more plugins..."
        '
        'ListView_Plugins
        '
        Me.ListView_Plugins.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Plugins.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9})
        Me.ListView_Plugins.ContextMenuStrip = Me.ContextMenuStrip_Plugins
        Me.ListView_Plugins.Location = New System.Drawing.Point(6, 6)
        Me.ListView_Plugins.Name = "ListView_Plugins"
        Me.ListView_Plugins.Size = New System.Drawing.Size(740, 951)
        Me.ListView_Plugins.SmallImageList = Me.ImageList_Plugins
        Me.ListView_Plugins.TabIndex = 0
        Me.ListView_Plugins.UseCompatibleStateImageBehavior = False
        Me.ListView_Plugins.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 75
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Author"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 75
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Version"
        Me.ColumnHeader5.Width = 75
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "URL"
        Me.ColumnHeader6.Width = 75
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Error"
        Me.ColumnHeader9.Width = 200
        '
        'TabPage_Database
        '
        Me.TabPage_Database.Controls.Add(Me.DatabaseListBox_Database)
        Me.TabPage_Database.Controls.Add(Me.Button_Refresh)
        Me.TabPage_Database.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage_Database.Controls.Add(Me.Button_AddDatabaseItem)
        Me.TabPage_Database.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage_Database.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Database.Name = "TabPage_Database"
        Me.TabPage_Database.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Database.Size = New System.Drawing.Size(752, 982)
        Me.TabPage_Database.TabIndex = 3
        Me.TabPage_Database.Text = "Database"
        Me.TabPage_Database.UseVisualStyleBackColor = True
        '
        'DatabaseListBox_Database
        '
        Me.DatabaseListBox_Database.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatabaseListBox_Database.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.DatabaseListBox_Database.FormattingEnabled = True
        Me.DatabaseListBox_Database.ItemHeight = 32
        Me.DatabaseListBox_Database.Location = New System.Drawing.Point(6, 75)
        Me.DatabaseListBox_Database.Name = "DatabaseListBox_Database"
        Me.DatabaseListBox_Database.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.DatabaseListBox_Database.Size = New System.Drawing.Size(740, 788)
        Me.DatabaseListBox_Database.TabIndex = 7
        '
        'Button_Refresh
        '
        Me.Button_Refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Refresh.Location = New System.Drawing.Point(646, 869)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(100, 23)
        Me.Button_Refresh.TabIndex = 6
        Me.Button_Refresh.Text = "Refresh"
        Me.Button_Refresh.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ClassPictureBoxQuality2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label18, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(740, 63)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'ClassPictureBoxQuality2
        '
        Me.ClassPictureBoxQuality2.Image = Global.BasicPawn.My.Resources.Resources.Bmp_DriveEncryption
        Me.ClassPictureBoxQuality2.Location = New System.Drawing.Point(3, 3)
        Me.ClassPictureBoxQuality2.m_HighQuality = True
        Me.ClassPictureBoxQuality2.Name = "ClassPictureBoxQuality2"
        Me.ClassPictureBoxQuality2.Size = New System.Drawing.Size(48, 48)
        Me.ClassPictureBoxQuality2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClassPictureBoxQuality2.TabIndex = 2
        Me.ClassPictureBoxQuality2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(60, 6)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(674, 26)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = resources.GetString("Label18.Text")
        '
        'Button_AddDatabaseItem
        '
        Me.Button_AddDatabaseItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_AddDatabaseItem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_AddDatabaseItem.Location = New System.Drawing.Point(540, 869)
        Me.Button_AddDatabaseItem.Name = "Button_AddDatabaseItem"
        Me.Button_AddDatabaseItem.Size = New System.Drawing.Size(100, 23)
        Me.Button_AddDatabaseItem.TabIndex = 4
        Me.Button_AddDatabaseItem.Text = "Add"
        Me.Button_AddDatabaseItem.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ClassPictureBoxQuality1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 922)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(740, 54)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ClassPictureBoxQuality1
        '
        Me.ClassPictureBoxQuality1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassPictureBoxQuality1.Image = Global.BasicPawn.My.Resources.Resources.Bmp_ShieldWarn
        Me.ClassPictureBoxQuality1.Location = New System.Drawing.Point(3, 3)
        Me.ClassPictureBoxQuality1.m_HighQuality = True
        Me.ClassPictureBoxQuality1.Name = "ClassPictureBoxQuality1"
        Me.ClassPictureBoxQuality1.Size = New System.Drawing.Size(32, 32)
        Me.ClassPictureBoxQuality1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClassPictureBoxQuality1.TabIndex = 2
        Me.ClassPictureBoxQuality1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(44, 6)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(688, 26)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Loaded BasicPawn plugins are able to read stored database entries. Make sure all " &
    "installed plugins are from a trustworthy publisher to prevent theft."
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(784, 1061)
        Me.Controls.Add(Me.Button_Apply)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ContextMenuStrip_Plugins.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Settings.ResumeLayout(False)
        Me.ClassTabControlColor1.ResumeLayout(False)
        Me.TabPage_General.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage_Editor.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.NumericUpDown_ThreadUpdateRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NumericUpDown_LineStateCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.NumericUpDown_TabsToSpaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Syntax.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.TabPage_Autocomplete.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage_Configs.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox_ConfigSettings.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.TabPage_Plugins.ResumeLayout(False)
        Me.TabPage_Plugins.PerformLayout()
        Me.TabPage_Database.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.ClassPictureBoxQuality2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ClassPictureBoxQuality1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As ClassTabControlColor
    Friend WithEvents TabPage_Settings As TabPage
    Friend WithEvents TabPage_Configs As TabPage
    Friend WithEvents CheckBox_OnScreenIntelliSense As CheckBox
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Apply As Button
    Friend WithEvents Button_ConfigAdd As Button
    Friend WithEvents Button_ConfigRemove As Button
    Friend WithEvents TextBox_ConfigName As TextBox
    Friend WithEvents Label_ConfigName As Label
    Friend WithEvents ListBox_Configs As ListBox
    Friend WithEvents GroupBox_ConfigSettings As GroupBox
    Friend WithEvents Button_SaveConfig As Button
    Friend WithEvents CheckBox_FullAutcompleteMethods As CheckBox
    Friend WithEvents Button_ConfigCopy As Button
    Friend WithEvents Button_ConfigRename As Button
    Friend WithEvents CheckBox_DoubleClickMark As CheckBox
    Friend WithEvents CheckBox_CommentsMethodIntelliSense As CheckBox
    Friend WithEvents CheckBox_CommentsAutocompleteIntelliSense As CheckBox
    Friend WithEvents CheckBox_FullAutocompleteReTagging As CheckBox
    Friend WithEvents Label_Font As Label
    Friend WithEvents Button_Font As Button
    Friend WithEvents CheckBox_InvertedColors As CheckBox
    Friend WithEvents CheckBox_CaseSensitive As CheckBox
    Friend WithEvents CheckBox_WindowsToolTipPopup As CheckBox
    Friend WithEvents CheckBox_AutoMark As CheckBox
    Friend WithEvents TabPage_Plugins As TabPage
    Friend WithEvents ListView_Plugins As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents CheckBox_AlwaysNewInstance As CheckBox
    Friend WithEvents CheckBox_VarAutocompleteShowObjectBrowser As CheckBox
    Friend WithEvents CheckBox_AlwaysLoadDefaultIncludes As CheckBox
    Friend WithEvents CheckBox_SwitchTabToAutocomplete As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabPage_Database As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ClassPictureBoxQuality1 As ClassPictureBoxQuality
    Friend WithEvents Label17 As Label
    Friend WithEvents ClassPictureBoxQuality2 As ClassPictureBoxQuality
    Friend WithEvents Button_AddDatabaseItem As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Button_Refresh As Button
    Friend WithEvents CheckBox_AutoShowStartPage As CheckBox
    Friend WithEvents CheckBox_WindowsToolTipAnimations As CheckBox
    Friend WithEvents NumericUpDown_TabsToSpaces As NumericUpDown
    Friend WithEvents CheckBox_TabsToSpace As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents CheckBox_AssociateSourcePawn As CheckBox
    Friend WithEvents CheckBox_AssociateIncludes As CheckBox
    Friend WithEvents CheckBox_AssociateBasicPawnProject As CheckBox
    Friend WithEvents CheckBox_AssociateAmxMod As CheckBox
    Friend WithEvents ContextMenuStrip_Plugins As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_PluginsRefresh As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_PluginsEnable As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_PluginsDisable As ToolStripMenuItem
    Friend WithEvents CheckBox_WindowsToolTipNewlineMethods As CheckBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Button_ViewErrorLog As Button
    Friend WithEvents Button_ClearErrorLog As Button
    Friend WithEvents LinkLabel_MorePlugins As LinkLabel
    Friend WithEvents Label32 As Label
    Friend WithEvents Button_CustomSyntax As Button
    Friend WithEvents TextBox_CustomSyntax As TextBox
    Friend WithEvents LinkLabel_DefaultSyntax As LinkLabel
    Friend WithEvents LinkLabel_MoreStyles As LinkLabel
    Friend WithEvents CheckBox_OnlyUpdateSyntaxWhenFocused As CheckBox
    Friend WithEvents CheckBox_AutoOpenProjectFiles As CheckBox
    Friend WithEvents CheckBox_AutoCloseBrackets As CheckBox
    Friend WithEvents CheckBox_AutoCloseStrings As CheckBox
    Friend WithEvents CheckBox_AutoIndentBrackets As CheckBox
    Friend WithEvents CheckBox_AutoHoverScroll As CheckBox
    Friend WithEvents DatabaseListBox_Database As ClassDatabaseListBox
    Friend WithEvents ClassTabControlColor1 As ClassTabControlColor
    Friend WithEvents TabPage_General As TabPage
    Friend WithEvents TabPage_Editor As TabPage
    Friend WithEvents TabPage_Syntax As TabPage
    Friend WithEvents TabPage_Autocomplete As TabPage
    Friend WithEvents CheckBox_RememberFolds As CheckBox
    Friend WithEvents ToolStripMenuItem_OpenUrl As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton_VarParseTab As RadioButton
    Friend WithEvents RadioButton_VarParseTabInc As RadioButton
    Friend WithEvents RadioButton_VarParseAll As RadioButton
    Friend WithEvents CheckBox_WindowsToolTipDisplayTop As CheckBox
    Friend WithEvents NumericUpDown_ThreadUpdateRate As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LinkLabel_ThreadUpdateRateHelp As LinkLabel
    Friend WithEvents ToolTip_Info As ToolTip
    Friend WithEvents LinkLabel_FullAutocompleteReTaggingHelp As LinkLabel
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ImageList_Plugins As ImageList
    Friend WithEvents CheckBox_IconBar As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButton_LineStateChanged As RadioButton
    Friend WithEvents RadioButton_LineStateChangedSaved As RadioButton
    Friend WithEvents RadioButton_LineStateNone As RadioButton
    Friend WithEvents NumericUpDown_LineStateCount As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabel_DefaultConfigPathsHelp As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListView_KnownFiles As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Button_KnownFileAdd As Button
    Friend WithEvents Button_KnownFileRemove As Button
    Friend WithEvents TextBox_AutoAssignPaths As TextBox
    Friend WithEvents Button_AutoAssignPaths As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl2 As ClassTabControlColor
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBoxEx_CODefineConstantsSP As ClassTextboxWatermark
    Friend WithEvents TextBoxEx_COIgnoredWarningsSP As ClassTextboxWatermark
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ComboBox_COTreatWarningsAsErrorsSP As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBox_COVerbosityLevelSP As ComboBox
    Friend WithEvents ComboBox_COOptimizationLevelSP As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label31 As Label
    Friend WithEvents ComboBox_COSymbolicInformationAMXX As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBoxEx_CODefineConstantsAMXX As ClassTextboxWatermark
    Friend WithEvents TextBoxEx_COIgnoredWarningsAMXX As ClassTextboxWatermark
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents ComboBox_COTreatWarningsAsErrorsAMXX As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents ComboBox_COVerbosityLevelAMXX As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox_Language As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton_ConfigSettingAutomatic As RadioButton
    Friend WithEvents RadioButton_ConfigSettingManual As RadioButton
    Friend WithEvents CheckBox_ConfigIsDefault As CheckBox
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_CompilerPath As TextBox
    Friend WithEvents Button_Compiler As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_IncludeFolder As TextBox
    Friend WithEvents Button_IncludeFolder As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_OutputFolder As TextBox
    Friend WithEvents Button_OutputFolder As Button
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_Shell As TextBox
    Friend WithEvents LinkLabel_ShowShellArguments As LinkLabel
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ClientFolder As TextBox
    Friend WithEvents Button_ClientFolder As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ServerFolder As TextBox
    Friend WithEvents Button_ServerFolder As Button
    Friend WithEvents TextBox_SourceModFolder As TextBox
    Friend WithEvents Button_SourceModFolder As Button
    Friend WithEvents Label12 As Label
End Class