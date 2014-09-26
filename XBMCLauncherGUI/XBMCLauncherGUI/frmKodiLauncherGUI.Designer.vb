<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKodiLauncherGUI
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKodiLauncherGUI))
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.rdShellWindowsExplorer = New System.Windows.Forms.RadioButton()
    Me.rdShellXBMCLauncher = New System.Windows.Forms.RadioButton()
    Me.rdShellOthers = New System.Windows.Forms.RadioButton()
    Me.chkCloseXBMCatSleep = New System.Windows.Forms.CheckBox()
    Me.chkStartExplorer = New System.Windows.Forms.CheckBox()
    Me.chkStartMetroUI = New System.Windows.Forms.CheckBox()
    Me.rdShutDown = New System.Windows.Forms.RadioButton()
    Me.rdSleep = New System.Windows.Forms.RadioButton()
    Me.rdHibernate = New System.Windows.Forms.RadioButton()
    Me.chkForceCloseXBMC = New System.Windows.Forms.CheckBox()
    Me.chkDisableFocusPermanently = New System.Windows.Forms.CheckBox()
    Me.txtFocusDelay = New System.Windows.Forms.TextBox()
    Me.chkFocusOnce = New System.Windows.Forms.CheckBox()
    Me.chkStartXBMCatWinLogon = New System.Windows.Forms.CheckBox()
    Me.chkStartXBMCatWinResume = New System.Windows.Forms.CheckBox()
    Me.chkStartXBMCPortable = New System.Windows.Forms.CheckBox()
    Me.txtStartupDelay = New System.Windows.Forms.TextBox()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.TabPage6 = New System.Windows.Forms.TabPage()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.lblShell = New System.Windows.Forms.Label()
    Me.btnSelectShell = New System.Windows.Forms.Button()
    Me.TabPage5 = New System.Windows.Forms.TabPage()
    Me.dgvApps = New System.Windows.Forms.DataGridView()
    Me.btnAddExternalApp = New System.Windows.Forms.Button()
    Me.TabPage9 = New System.Windows.Forms.TabPage()
    Me.dgvExternalPlayers = New System.Windows.Forms.DataGridView()
    Me.btnAddExternalPlayer = New System.Windows.Forms.Button()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.lblXBMCPath = New System.Windows.Forms.Label()
    Me.lblXBMConIMONPath = New System.Windows.Forms.Label()
    Me.lbliMONManagerPath = New System.Windows.Forms.Label()
    Me.btnCleariMONManagerPOath = New System.Windows.Forms.Button()
    Me.btnClearXBMConIMONPath = New System.Windows.Forms.Button()
    Me.btnClearXBMCPath = New System.Windows.Forms.Button()
    Me.btnSelectiMONManagerPath = New System.Windows.Forms.Button()
    Me.btnSelectXBMConIMONPath = New System.Windows.Forms.Button()
    Me.btnSelectXBMCPath = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colPlayerKeepFocus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.colApp = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colStartWithXBMC = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.colAppKeepFocus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.colDeleteApp = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.TabPage6.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    CType(Me.dgvApps, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage9.SuspendLayout()
    CType(Me.dgvExternalPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage4.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolTip1
    '
    Me.ToolTip1.IsBalloon = True
    Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
    Me.ToolTip1.ToolTipTitle = "XBMCLauncher"
    '
    'rdShellWindowsExplorer
    '
    Me.rdShellWindowsExplorer.AutoSize = True
    Me.rdShellWindowsExplorer.Location = New System.Drawing.Point(10, 20)
    Me.rdShellWindowsExplorer.Name = "rdShellWindowsExplorer"
    Me.rdShellWindowsExplorer.Size = New System.Drawing.Size(126, 19)
    Me.rdShellWindowsExplorer.TabIndex = 0
    Me.rdShellWindowsExplorer.TabStop = True
    Me.rdShellWindowsExplorer.Text = "Windows Explorer"
    Me.ToolTip1.SetToolTip(Me.rdShellWindowsExplorer, "Set Windows Explorer as the shell.")
    Me.rdShellWindowsExplorer.UseVisualStyleBackColor = True
    '
    'rdShellXBMCLauncher
    '
    Me.rdShellXBMCLauncher.AutoSize = True
    Me.rdShellXBMCLauncher.Location = New System.Drawing.Point(10, 60)
    Me.rdShellXBMCLauncher.Name = "rdShellXBMCLauncher"
    Me.rdShellXBMCLauncher.Size = New System.Drawing.Size(101, 19)
    Me.rdShellXBMCLauncher.TabIndex = 1
    Me.rdShellXBMCLauncher.TabStop = True
    Me.rdShellXBMCLauncher.Text = "KodiLauncher"
    Me.ToolTip1.SetToolTip(Me.rdShellXBMCLauncher, "Set XBMCLauncher as the shell.")
    Me.rdShellXBMCLauncher.UseVisualStyleBackColor = True
    '
    'rdShellOthers
    '
    Me.rdShellOthers.AutoSize = True
    Me.rdShellOthers.Location = New System.Drawing.Point(10, 100)
    Me.rdShellOthers.Name = "rdShellOthers"
    Me.rdShellOthers.Size = New System.Drawing.Size(58, 19)
    Me.rdShellOthers.TabIndex = 2
    Me.rdShellOthers.TabStop = True
    Me.rdShellOthers.Text = "Other"
    Me.ToolTip1.SetToolTip(Me.rdShellOthers, "Set any other .exe file as shell. XBMCLauncehr will not start.")
    Me.rdShellOthers.UseVisualStyleBackColor = True
    '
    'chkCloseXBMCatSleep
    '
    Me.chkCloseXBMCatSleep.AutoSize = True
    Me.chkCloseXBMCatSleep.Location = New System.Drawing.Point(10, 20)
    Me.chkCloseXBMCatSleep.Name = "chkCloseXBMCatSleep"
    Me.chkCloseXBMCatSleep.Size = New System.Drawing.Size(194, 19)
    Me.chkCloseXBMCatSleep.TabIndex = 2
    Me.chkCloseXBMCatSleep.Tag = "CloseXBMCatSleep"
    Me.chkCloseXBMCatSleep.Text = "Close Kodi on System Suspend"
    Me.ToolTip1.SetToolTip(Me.chkCloseXBMCatSleep, "Force close XBMC during Sleep or Hibernation.")
    Me.chkCloseXBMCatSleep.UseVisualStyleBackColor = True
    '
    'chkStartExplorer
    '
    Me.chkStartExplorer.AutoSize = True
    Me.chkStartExplorer.Location = New System.Drawing.Point(10, 60)
    Me.chkStartExplorer.Name = "chkStartExplorer"
    Me.chkStartExplorer.Size = New System.Drawing.Size(269, 19)
    Me.chkStartExplorer.TabIndex = 3
    Me.chkStartExplorer.Tag = "StartExplorer"
    Me.chkStartExplorer.Text = "Start Windows Explorer when Kodi is closed"
    Me.ToolTip1.SetToolTip(Me.chkStartExplorer, "Start Explorer when XBMC is closed in shell mode.")
    Me.chkStartExplorer.UseVisualStyleBackColor = True
    '
    'chkStartMetroUI
    '
    Me.chkStartMetroUI.AutoSize = True
    Me.chkStartMetroUI.Location = New System.Drawing.Point(10, 100)
    Me.chkStartMetroUI.Name = "chkStartMetroUI"
    Me.chkStartMetroUI.Size = New System.Drawing.Size(250, 19)
    Me.chkStartMetroUI.TabIndex = 4
    Me.chkStartMetroUI.Tag = "StartMetroUI"
    Me.chkStartMetroUI.Text = "Start Metro Start UI when Kodi is closed"
    Me.ToolTip1.SetToolTip(Me.chkStartMetroUI, "Start Metro UI when XBMC is closed.")
    Me.chkStartMetroUI.UseVisualStyleBackColor = True
    Me.chkStartMetroUI.Visible = False
    '
    'rdShutDown
    '
    Me.rdShutDown.AutoSize = True
    Me.rdShutDown.ForeColor = System.Drawing.Color.Black
    Me.rdShutDown.Location = New System.Drawing.Point(10, 25)
    Me.rdShutDown.Name = "rdShutDown"
    Me.rdShutDown.Size = New System.Drawing.Size(82, 19)
    Me.rdShutDown.TabIndex = 0
    Me.rdShutDown.TabStop = True
    Me.rdShutDown.Text = "Shutdown"
    Me.ToolTip1.SetToolTip(Me.rdShutDown, "XBMC Shutdown button will shutdown the system.")
    Me.rdShutDown.UseVisualStyleBackColor = True
    '
    'rdSleep
    '
    Me.rdSleep.AutoSize = True
    Me.rdSleep.ForeColor = System.Drawing.Color.Black
    Me.rdSleep.Location = New System.Drawing.Point(10, 50)
    Me.rdSleep.Name = "rdSleep"
    Me.rdSleep.Size = New System.Drawing.Size(56, 19)
    Me.rdSleep.TabIndex = 1
    Me.rdSleep.TabStop = True
    Me.rdSleep.Text = "Sleep"
    Me.ToolTip1.SetToolTip(Me.rdSleep, "XBMC Shutdown button will suspend the system.")
    Me.rdSleep.UseVisualStyleBackColor = True
    '
    'rdHibernate
    '
    Me.rdHibernate.AutoSize = True
    Me.rdHibernate.ForeColor = System.Drawing.Color.Black
    Me.rdHibernate.Location = New System.Drawing.Point(10, 75)
    Me.rdHibernate.Name = "rdHibernate"
    Me.rdHibernate.Size = New System.Drawing.Size(81, 19)
    Me.rdHibernate.TabIndex = 2
    Me.rdHibernate.TabStop = True
    Me.rdHibernate.Text = "Hibernate"
    Me.ToolTip1.SetToolTip(Me.rdHibernate, "XBMC Shutdown button will hibernate the system.")
    Me.rdHibernate.UseVisualStyleBackColor = True
    '
    'chkForceCloseXBMC
    '
    Me.chkForceCloseXBMC.AutoSize = True
    Me.chkForceCloseXBMC.ForeColor = System.Drawing.Color.Black
    Me.chkForceCloseXBMC.Location = New System.Drawing.Point(10, 117)
    Me.chkForceCloseXBMC.Name = "chkForceCloseXBMC"
    Me.chkForceCloseXBMC.Size = New System.Drawing.Size(117, 19)
    Me.chkForceCloseXBMC.TabIndex = 6
    Me.chkForceCloseXBMC.Tag = "ForceCloseXBMC"
    Me.chkForceCloseXBMC.Text = "Force Close Kodi"
    Me.ToolTip1.SetToolTip(Me.chkForceCloseXBMC, "Applicable for the custom confluence skin only. XBMC will be force closed when th" & _
        "e shutown button is clicked.")
    Me.chkForceCloseXBMC.UseVisualStyleBackColor = True
    '
    'chkDisableFocusPermanently
    '
    Me.chkDisableFocusPermanently.AutoSize = True
    Me.chkDisableFocusPermanently.Location = New System.Drawing.Point(10, 20)
    Me.chkDisableFocusPermanently.Name = "chkDisableFocusPermanently"
    Me.chkDisableFocusPermanently.Size = New System.Drawing.Size(174, 19)
    Me.chkDisableFocusPermanently.TabIndex = 7
    Me.chkDisableFocusPermanently.Tag = "DisableFocusPermanently"
    Me.chkDisableFocusPermanently.Text = "Disable Focus Permanently"
    Me.ToolTip1.SetToolTip(Me.chkDisableFocusPermanently, "Disble XBMC from focussing permanently.")
    Me.chkDisableFocusPermanently.UseVisualStyleBackColor = True
    '
    'txtFocusDelay
    '
    Me.txtFocusDelay.Location = New System.Drawing.Point(88, 96)
    Me.txtFocusDelay.Name = "txtFocusDelay"
    Me.txtFocusDelay.Size = New System.Drawing.Size(73, 23)
    Me.txtFocusDelay.TabIndex = 13
    Me.ToolTip1.SetToolTip(Me.txtFocusDelay, "Delay between focus commands. Focus is sent only if XBMC is inactive.")
    '
    'chkFocusOnce
    '
    Me.chkFocusOnce.AutoSize = True
    Me.chkFocusOnce.Location = New System.Drawing.Point(10, 60)
    Me.chkFocusOnce.Name = "chkFocusOnce"
    Me.chkFocusOnce.Size = New System.Drawing.Size(117, 19)
    Me.chkFocusOnce.TabIndex = 14
    Me.chkFocusOnce.Tag = "FocusOnce"
    Me.chkFocusOnce.Text = "Focus Once Only"
    Me.ToolTip1.SetToolTip(Me.chkFocusOnce, "XBMC is focussed only once after the time specified in 'Focus Delay'.")
    Me.chkFocusOnce.UseVisualStyleBackColor = True
    '
    'chkStartXBMCatWinLogon
    '
    Me.chkStartXBMCatWinLogon.AutoSize = True
    Me.chkStartXBMCatWinLogon.Location = New System.Drawing.Point(10, 20)
    Me.chkStartXBMCatWinLogon.Name = "chkStartXBMCatWinLogon"
    Me.chkStartXBMCatWinLogon.Size = New System.Drawing.Size(204, 19)
    Me.chkStartXBMCatWinLogon.TabIndex = 0
    Me.chkStartXBMCatWinLogon.Tag = "StartXBMCatWinLogon"
    Me.chkStartXBMCatWinLogon.Text = "Start Kodi when Windows starts"
    Me.ToolTip1.SetToolTip(Me.chkStartXBMCatWinLogon, "Start XBMC when XBMCLauncher starts at Windows logon.")
    Me.chkStartXBMCatWinLogon.UseVisualStyleBackColor = True
    '
    'chkStartXBMCatWinResume
    '
    Me.chkStartXBMCatWinResume.AutoSize = True
    Me.chkStartXBMCatWinResume.Location = New System.Drawing.Point(10, 60)
    Me.chkStartXBMCatWinResume.Name = "chkStartXBMCatWinResume"
    Me.chkStartXBMCatWinResume.Size = New System.Drawing.Size(301, 19)
    Me.chkStartXBMCatWinResume.TabIndex = 1
    Me.chkStartXBMCatWinResume.Tag = "StartXBMCatWinResume"
    Me.chkStartXBMCatWinResume.Text = "Start Kodi when Windows resumes from Suspend"
    Me.ToolTip1.SetToolTip(Me.chkStartXBMCatWinResume, "Start XBMC when resuming from Sleep or Hibernation.")
    Me.chkStartXBMCatWinResume.UseVisualStyleBackColor = True
    '
    'chkStartXBMCPortable
    '
    Me.chkStartXBMCPortable.AutoSize = True
    Me.chkStartXBMCPortable.Location = New System.Drawing.Point(10, 100)
    Me.chkStartXBMCPortable.Name = "chkStartXBMCPortable"
    Me.chkStartXBMCPortable.Size = New System.Drawing.Size(180, 19)
    Me.chkStartXBMCPortable.TabIndex = 2
    Me.chkStartXBMCPortable.Tag = "StartXBMCPortable"
    Me.chkStartXBMCPortable.Text = "Start Kodi in Portable Mode"
    Me.ToolTip1.SetToolTip(Me.chkStartXBMCPortable, "Start XBMC with -P switch.")
    Me.chkStartXBMCPortable.UseVisualStyleBackColor = True
    '
    'txtStartupDelay
    '
    Me.txtStartupDelay.Location = New System.Drawing.Point(150, 136)
    Me.txtStartupDelay.Name = "txtStartupDelay"
    Me.txtStartupDelay.Size = New System.Drawing.Size(73, 23)
    Me.txtStartupDelay.TabIndex = 7
    Me.ToolTip1.SetToolTip(Me.txtStartupDelay, "Delay before XBMC starts.")
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'TabPage6
    '
    Me.TabPage6.Controls.Add(Me.GroupBox3)
    Me.TabPage6.Location = New System.Drawing.Point(4, 24)
    Me.TabPage6.Name = "TabPage6"
    Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage6.Size = New System.Drawing.Size(800, 214)
    Me.TabPage6.TabIndex = 5
    Me.TabPage6.Text = "Shell"
    Me.TabPage6.UseVisualStyleBackColor = True
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.lblShell)
    Me.GroupBox3.Controls.Add(Me.btnSelectShell)
    Me.GroupBox3.Controls.Add(Me.rdShellOthers)
    Me.GroupBox3.Controls.Add(Me.rdShellXBMCLauncher)
    Me.GroupBox3.Controls.Add(Me.rdShellWindowsExplorer)
    Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(794, 208)
    Me.GroupBox3.TabIndex = 0
    Me.GroupBox3.TabStop = False
    '
    'lblShell
    '
    Me.lblShell.AutoSize = True
    Me.lblShell.Location = New System.Drawing.Point(171, 102)
    Me.lblShell.Name = "lblShell"
    Me.lblShell.Size = New System.Drawing.Size(34, 15)
    Me.lblShell.TabIndex = 4
    Me.lblShell.Text = "Shell"
    '
    'btnSelectShell
    '
    Me.btnSelectShell.Location = New System.Drawing.Point(74, 98)
    Me.btnSelectShell.Name = "btnSelectShell"
    Me.btnSelectShell.Size = New System.Drawing.Size(75, 23)
    Me.btnSelectShell.TabIndex = 3
    Me.btnSelectShell.Text = "Select"
    Me.btnSelectShell.UseVisualStyleBackColor = True
    '
    'TabPage5
    '
    Me.TabPage5.Controls.Add(Me.dgvApps)
    Me.TabPage5.Controls.Add(Me.btnAddExternalApp)
    Me.TabPage5.Location = New System.Drawing.Point(4, 24)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage5.Size = New System.Drawing.Size(800, 214)
    Me.TabPage5.TabIndex = 4
    Me.TabPage5.Text = "External Applications"
    Me.TabPage5.UseVisualStyleBackColor = True
    '
    'dgvApps
    '
    Me.dgvApps.AllowUserToAddRows = False
    Me.dgvApps.AllowUserToDeleteRows = False
    Me.dgvApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvApps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colApp, Me.colStartWithXBMC, Me.colAppKeepFocus, Me.colDeleteApp})
    Me.dgvApps.Location = New System.Drawing.Point(87, 6)
    Me.dgvApps.Name = "dgvApps"
    Me.dgvApps.RowHeadersVisible = False
    Me.dgvApps.Size = New System.Drawing.Size(705, 200)
    Me.dgvApps.TabIndex = 17
    '
    'btnAddExternalApp
    '
    Me.btnAddExternalApp.Location = New System.Drawing.Point(6, 6)
    Me.btnAddExternalApp.Name = "btnAddExternalApp"
    Me.btnAddExternalApp.Size = New System.Drawing.Size(75, 27)
    Me.btnAddExternalApp.TabIndex = 6
    Me.btnAddExternalApp.Text = "Add New"
    Me.btnAddExternalApp.UseVisualStyleBackColor = True
    '
    'TabPage9
    '
    Me.TabPage9.Controls.Add(Me.dgvExternalPlayers)
    Me.TabPage9.Controls.Add(Me.btnAddExternalPlayer)
    Me.TabPage9.Location = New System.Drawing.Point(4, 24)
    Me.TabPage9.Name = "TabPage9"
    Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage9.Size = New System.Drawing.Size(800, 214)
    Me.TabPage9.TabIndex = 8
    Me.TabPage9.Text = "External Players"
    Me.TabPage9.UseVisualStyleBackColor = True
    '
    'dgvExternalPlayers
    '
    Me.dgvExternalPlayers.AllowUserToAddRows = False
    Me.dgvExternalPlayers.AllowUserToDeleteRows = False
    Me.dgvExternalPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvExternalPlayers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colPlayerKeepFocus, Me.DataGridViewButtonColumn1})
    Me.dgvExternalPlayers.Location = New System.Drawing.Point(87, 6)
    Me.dgvExternalPlayers.Name = "dgvExternalPlayers"
    Me.dgvExternalPlayers.RowHeadersVisible = False
    Me.dgvExternalPlayers.Size = New System.Drawing.Size(705, 200)
    Me.dgvExternalPlayers.TabIndex = 22
    '
    'btnAddExternalPlayer
    '
    Me.btnAddExternalPlayer.Location = New System.Drawing.Point(6, 6)
    Me.btnAddExternalPlayer.Name = "btnAddExternalPlayer"
    Me.btnAddExternalPlayer.Size = New System.Drawing.Size(75, 27)
    Me.btnAddExternalPlayer.TabIndex = 21
    Me.btnAddExternalPlayer.Text = "Add New"
    Me.btnAddExternalPlayer.UseVisualStyleBackColor = True
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.lblXBMCPath)
    Me.TabPage4.Controls.Add(Me.lblXBMConIMONPath)
    Me.TabPage4.Controls.Add(Me.lbliMONManagerPath)
    Me.TabPage4.Controls.Add(Me.btnCleariMONManagerPOath)
    Me.TabPage4.Controls.Add(Me.btnClearXBMConIMONPath)
    Me.TabPage4.Controls.Add(Me.btnClearXBMCPath)
    Me.TabPage4.Controls.Add(Me.btnSelectiMONManagerPath)
    Me.TabPage4.Controls.Add(Me.btnSelectXBMConIMONPath)
    Me.TabPage4.Controls.Add(Me.btnSelectXBMCPath)
    Me.TabPage4.Controls.Add(Me.Label7)
    Me.TabPage4.Controls.Add(Me.Label6)
    Me.TabPage4.Controls.Add(Me.Label5)
    Me.TabPage4.Location = New System.Drawing.Point(4, 24)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(800, 214)
    Me.TabPage4.TabIndex = 3
    Me.TabPage4.Text = "Kodi Path"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'lblXBMCPath
    '
    Me.lblXBMCPath.AutoEllipsis = True
    Me.lblXBMCPath.Location = New System.Drawing.Point(429, 20)
    Me.lblXBMCPath.Name = "lblXBMCPath"
    Me.lblXBMCPath.Size = New System.Drawing.Size(241, 15)
    Me.lblXBMCPath.TabIndex = 22
    Me.lblXBMCPath.Text = "Application 1"
    '
    'lblXBMConIMONPath
    '
    Me.lblXBMConIMONPath.Location = New System.Drawing.Point(429, 60)
    Me.lblXBMConIMONPath.Name = "lblXBMConIMONPath"
    Me.lblXBMConIMONPath.Size = New System.Drawing.Size(241, 15)
    Me.lblXBMConIMONPath.TabIndex = 23
    Me.lblXBMConIMONPath.Text = "Application 2"
    '
    'lbliMONManagerPath
    '
    Me.lbliMONManagerPath.Location = New System.Drawing.Point(429, 100)
    Me.lbliMONManagerPath.Name = "lbliMONManagerPath"
    Me.lbliMONManagerPath.Size = New System.Drawing.Size(241, 15)
    Me.lbliMONManagerPath.TabIndex = 24
    Me.lbliMONManagerPath.Text = "Application 3"
    '
    'btnCleariMONManagerPOath
    '
    Me.btnCleariMONManagerPOath.Location = New System.Drawing.Point(325, 94)
    Me.btnCleariMONManagerPOath.Name = "btnCleariMONManagerPOath"
    Me.btnCleariMONManagerPOath.Size = New System.Drawing.Size(75, 27)
    Me.btnCleariMONManagerPOath.TabIndex = 20
    Me.btnCleariMONManagerPOath.Text = "Clear"
    Me.btnCleariMONManagerPOath.UseVisualStyleBackColor = True
    '
    'btnClearXBMConIMONPath
    '
    Me.btnClearXBMConIMONPath.Location = New System.Drawing.Point(325, 54)
    Me.btnClearXBMConIMONPath.Name = "btnClearXBMConIMONPath"
    Me.btnClearXBMConIMONPath.Size = New System.Drawing.Size(75, 27)
    Me.btnClearXBMConIMONPath.TabIndex = 19
    Me.btnClearXBMConIMONPath.Text = "Clear"
    Me.btnClearXBMConIMONPath.UseVisualStyleBackColor = True
    '
    'btnClearXBMCPath
    '
    Me.btnClearXBMCPath.Location = New System.Drawing.Point(325, 14)
    Me.btnClearXBMCPath.Name = "btnClearXBMCPath"
    Me.btnClearXBMCPath.Size = New System.Drawing.Size(75, 27)
    Me.btnClearXBMCPath.TabIndex = 18
    Me.btnClearXBMCPath.Text = "Clear"
    Me.btnClearXBMCPath.UseVisualStyleBackColor = True
    '
    'btnSelectiMONManagerPath
    '
    Me.btnSelectiMONManagerPath.Location = New System.Drawing.Point(232, 94)
    Me.btnSelectiMONManagerPath.Name = "btnSelectiMONManagerPath"
    Me.btnSelectiMONManagerPath.Size = New System.Drawing.Size(75, 27)
    Me.btnSelectiMONManagerPath.TabIndex = 16
    Me.btnSelectiMONManagerPath.Text = "Select"
    Me.btnSelectiMONManagerPath.UseVisualStyleBackColor = True
    '
    'btnSelectXBMConIMONPath
    '
    Me.btnSelectXBMConIMONPath.Location = New System.Drawing.Point(232, 54)
    Me.btnSelectXBMConIMONPath.Name = "btnSelectXBMConIMONPath"
    Me.btnSelectXBMConIMONPath.Size = New System.Drawing.Size(75, 27)
    Me.btnSelectXBMConIMONPath.TabIndex = 15
    Me.btnSelectXBMConIMONPath.Text = "Select"
    Me.btnSelectXBMConIMONPath.UseVisualStyleBackColor = True
    '
    'btnSelectXBMCPath
    '
    Me.btnSelectXBMCPath.Location = New System.Drawing.Point(232, 14)
    Me.btnSelectXBMCPath.Name = "btnSelectXBMCPath"
    Me.btnSelectXBMCPath.Size = New System.Drawing.Size(75, 27)
    Me.btnSelectXBMCPath.TabIndex = 14
    Me.btnSelectXBMCPath.Text = "Select"
    Me.btnSelectXBMCPath.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(10, 100)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(119, 15)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "iMON Manager Path"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(10, 60)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(115, 15)
    Me.Label6.TabIndex = 1
    Me.Label6.Text = "XBMConiMON Path"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(10, 20)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(60, 15)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Kodi Path"
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.GroupBox1)
    Me.TabPage3.Controls.Add(Me.chkStartMetroUI)
    Me.TabPage3.Controls.Add(Me.chkStartExplorer)
    Me.TabPage3.Controls.Add(Me.chkCloseXBMCatSleep)
    Me.TabPage3.Location = New System.Drawing.Point(4, 24)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(800, 214)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "Exit Settings"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.chkForceCloseXBMC)
    Me.GroupBox1.Controls.Add(Me.rdHibernate)
    Me.GroupBox1.Controls.Add(Me.rdSleep)
    Me.GroupBox1.Controls.Add(Me.rdShutDown)
    Me.GroupBox1.ForeColor = System.Drawing.Color.Red
    Me.GroupBox1.Location = New System.Drawing.Point(320, 20)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(360, 163)
    Me.GroupBox1.TabIndex = 5
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Shutdown Button Action for Custom Confluence Skin"
    Me.GroupBox1.Visible = False
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.chkFocusOnce)
    Me.TabPage2.Controls.Add(Me.txtFocusDelay)
    Me.TabPage2.Controls.Add(Me.Label3)
    Me.TabPage2.Controls.Add(Me.Label4)
    Me.TabPage2.Controls.Add(Me.chkDisableFocusPermanently)
    Me.TabPage2.Location = New System.Drawing.Point(4, 24)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(800, 214)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Focus Settings"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(167, 100)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(53, 15)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "Seconds"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(10, 100)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(72, 15)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Focus Delay"
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.txtStartupDelay)
    Me.TabPage1.Controls.Add(Me.Label2)
    Me.TabPage1.Controls.Add(Me.Label1)
    Me.TabPage1.Controls.Add(Me.chkStartXBMCPortable)
    Me.TabPage1.Controls.Add(Me.chkStartXBMCatWinResume)
    Me.TabPage1.Controls.Add(Me.chkStartXBMCatWinLogon)
    Me.TabPage1.Location = New System.Drawing.Point(4, 24)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(800, 214)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Startup Settings"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(229, 140)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(53, 15)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Seconds"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(10, 140)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(125, 15)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Delay Kodi startup by"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Controls.Add(Me.TabPage4)
    Me.TabControl1.Controls.Add(Me.TabPage9)
    Me.TabControl1.Controls.Add(Me.TabPage5)
    Me.TabControl1.Controls.Add(Me.TabPage6)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Multiline = True
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(808, 242)
    Me.TabControl1.TabIndex = 0
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "Player"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Width = 400
    '
    'colPlayerKeepFocus
    '
    Me.colPlayerKeepFocus.HeaderText = "Keep Focus"
    Me.colPlayerKeepFocus.Name = "colPlayerKeepFocus"
    Me.colPlayerKeepFocus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.colPlayerKeepFocus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.colPlayerKeepFocus.Width = 150
    '
    'DataGridViewButtonColumn1
    '
    Me.DataGridViewButtonColumn1.HeaderText = ""
    Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
    Me.DataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewButtonColumn1.Text = "Clear"
    '
    'colApp
    '
    Me.colApp.HeaderText = "Application"
    Me.colApp.Name = "colApp"
    Me.colApp.ReadOnly = True
    Me.colApp.Width = 400
    '
    'colStartWithXBMC
    '
    Me.colStartWithXBMC.HeaderText = "Start with KodiLauncher"
    Me.colStartWithXBMC.Name = "colStartWithXBMC"
    Me.colStartWithXBMC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.colStartWithXBMC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    '
    'colAppKeepFocus
    '
    Me.colAppKeepFocus.HeaderText = "Keep Focus"
    Me.colAppKeepFocus.Name = "colAppKeepFocus"
    Me.colAppKeepFocus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.colAppKeepFocus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    '
    'colDeleteApp
    '
    Me.colDeleteApp.HeaderText = ""
    Me.colDeleteApp.Name = "colDeleteApp"
    Me.colDeleteApp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.colDeleteApp.Text = "Clear"
    '
    'frmKodiLauncherGUI
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(808, 242)
    Me.Controls.Add(Me.TabControl1)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "frmKodiLauncherGUI"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Kodi Launcher GUI"
    Me.TopMost = True
    Me.TabPage6.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.TabPage5.ResumeLayout(False)
    CType(Me.dgvApps, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage9.ResumeLayout(False)
    CType(Me.dgvExternalPlayers, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage4.ResumeLayout(False)
    Me.TabPage4.PerformLayout()
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage3.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents lblShell As System.Windows.Forms.Label
  Friend WithEvents btnSelectShell As System.Windows.Forms.Button
  Friend WithEvents rdShellOthers As System.Windows.Forms.RadioButton
  Friend WithEvents rdShellXBMCLauncher As System.Windows.Forms.RadioButton
  Friend WithEvents rdShellWindowsExplorer As System.Windows.Forms.RadioButton
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents dgvApps As System.Windows.Forms.DataGridView
  Friend WithEvents btnAddExternalApp As System.Windows.Forms.Button
  Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
  Friend WithEvents btnAddExternalPlayer As System.Windows.Forms.Button
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents lblXBMCPath As System.Windows.Forms.Label
  Friend WithEvents lblXBMConIMONPath As System.Windows.Forms.Label
  Friend WithEvents lbliMONManagerPath As System.Windows.Forms.Label
  Friend WithEvents btnCleariMONManagerPOath As System.Windows.Forms.Button
  Friend WithEvents btnClearXBMConIMONPath As System.Windows.Forms.Button
  Friend WithEvents btnClearXBMCPath As System.Windows.Forms.Button
  Friend WithEvents btnSelectiMONManagerPath As System.Windows.Forms.Button
  Friend WithEvents btnSelectXBMConIMONPath As System.Windows.Forms.Button
  Friend WithEvents btnSelectXBMCPath As System.Windows.Forms.Button
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents chkForceCloseXBMC As System.Windows.Forms.CheckBox
  Friend WithEvents rdHibernate As System.Windows.Forms.RadioButton
  Friend WithEvents rdSleep As System.Windows.Forms.RadioButton
  Friend WithEvents rdShutDown As System.Windows.Forms.RadioButton
  Friend WithEvents chkStartMetroUI As System.Windows.Forms.CheckBox
  Friend WithEvents chkStartExplorer As System.Windows.Forms.CheckBox
  Friend WithEvents chkCloseXBMCatSleep As System.Windows.Forms.CheckBox
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents chkFocusOnce As System.Windows.Forms.CheckBox
  Friend WithEvents txtFocusDelay As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents chkDisableFocusPermanently As System.Windows.Forms.CheckBox
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents txtStartupDelay As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents chkStartXBMCPortable As System.Windows.Forms.CheckBox
  Friend WithEvents chkStartXBMCatWinResume As System.Windows.Forms.CheckBox
  Friend WithEvents chkStartXBMCatWinLogon As System.Windows.Forms.CheckBox
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents dgvExternalPlayers As System.Windows.Forms.DataGridView
  Friend WithEvents colApp As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colStartWithXBMC As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents colAppKeepFocus As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents colDeleteApp As System.Windows.Forms.DataGridViewButtonColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colPlayerKeepFocus As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn

End Class
