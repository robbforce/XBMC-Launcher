Public Class frmXBMCLauncherGUI

  Dim RegistrySettingsPath As String = "HKEY_CURRENT_USER\Software\XBMCLauncher"

#Region "FORM LOAD EVENTS"

  Private Sub frmXBMCLauncherGUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    On Error GoTo err

    'Startup Settings
    Me.chkStartXBMCatWinLogon.Checked = My.Settings.StartXBMCatWinLogon
    Me.chkStartXBMCatWinResume.Checked = My.Settings.StartXBMCatWinResume
    Me.chkStartXBMCPortable.Checked = My.Settings.StartXBMCPortable
    Me.txtStartupDelay.Text = My.Settings.StartupDelay / 1000

    'Focus Settings
    Me.chkDisableFocusPermanently.Checked = My.Settings.DisableFocusPermanently
    Me.chkFocusOnce.Checked = My.Settings.FocusOnce
    Me.txtFocusDelay.Text = My.Settings.FocusDelay / 1000 ' Focus delay in seconds.
    'Me.chkFocusExternalPlayer.Checked = My.Settings.FocusExternalPlayer

    'Exit Settings
    Me.chkCloseXBMCatSleep.Checked = My.Settings.CloseXBMCatSleep
    Me.chkForceCloseXBMC.Checked = My.Settings.ForceCloseXBMC
    Me.chkStartExplorer.Checked = My.Settings.StartExplorer
    Me.chkStartMetroUI.Checked = My.Settings.StartMetroUI
    If My.Computer.Info.OSVersion >= "6.2" Then Me.chkStartMetroUI.Visible = True ' Display the MetroUI option if running on windows 8.
    Me.GroupBox1.Visible = My.Settings.ShowCustomShutdownMenu
    Dim ShutdownAction = My.Settings.ShutdownAction

    If ShutdownAction = "u" Then
      Me.rdShutDown.Checked = True
    End If

    If ShutdownAction = "s" Then
      Me.rdSleep.Checked = True
    End If

    If ShutdownAction = "h" Then
      Me.rdHibernate.Checked = True
    End If

    'XBMC Path Settings

    Me.lblXBMCPath.Text = ShrinkPathText(My.Settings.XBMC_Path, lblXBMCPath)
    Me.lblXBMConIMONPath.Text = ShrinkPathText(My.Settings.XBMConiMON_Path, lblXBMConIMONPath)
    Me.lbliMONManagerPath.Text = ShrinkPathText(My.Settings.iMON_Path, lbliMONManagerPath)

    'External Players

    'Me.lblExtPlayer1.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "ExternalPlayer1_Path", ""), lblExtPlayer1)
    'Me.lblExtPlayer2.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "ExternalPlayer2_Path", ""), lblExtPlayer2)
    'Me.lblExtPlayer3.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "ExternalPlayer3_Path", ""), lblExtPlayer3)
    'Me.lblExtPlayer4.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "ExternalPlayer4_Path", ""), lblExtPlayer4)

    'Me.chkFocusExternalPlayer.Checked = My.Computer.Registry.GetValue(RegistrySettingsPath, "FocusExternalPlayer", "0")


    'EXTERNAL APPS

    'Me.lblApp1.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App1_Path", ""), lblApp1)
    'Me.lblApp2.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App2_Path", ""), lblApp2)
    'Me.lblApp3.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App3_Path", ""), lblApp3)
    'Me.lblApp4.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App4_Path", ""), lblApp4)
    'Me.lblApp5.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App5_Path", ""), lblApp5)
    'Me.lblApp6.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App6_Path", ""), lblApp6)
    'Me.lblApp7.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App7_Path", ""), lblApp7)
    'Me.lblApp8.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App8_Path", ""), lblApp8)
    'Me.lblApp9.Text = ShrinkPathText(My.Computer.Registry.GetValue(RegistrySettingsPath, "App9_Path", ""), lblApp9)

    'Me.chkStartExternalApps1.Checked = My.Computer.Registry.GetValue(RegistrySettingsPath, "StartApps1", "0")
    'Me.chkStartExternalApps2.Checked = My.Computer.Registry.GetValue(RegistrySettingsPath, "StartApps2", "0")
    'Me.chkStartExternalApps3.Checked = My.Computer.Registry.GetValue(RegistrySettingsPath, "StartApps3", "0")

    'Me.chkPreventFocusExternalApps1.Checked = My.Computer.Registry.GetValue(RegistrySettingsPath, "PreventFocusApps1", "0")
    'Me.chkPreventFocusExternalApps2.Checked = My.Computer.Registry.GetValue(RegistrySettingsPath, "PreventFocusApps2", "0")
    'Me.chkPreventFocusExternalApps3.Checked = My.Computer.Registry.GetValue(RegistrySettingsPath, "PreventFocusApps3", "0")



    ' Shell settings
    Me.lblShell.Text = ""
    Dim Shell As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", "Explorer.exe")
    If Shell.ToLower.Contains("explorer") Then
      Me.rdShellWindowsExplorer.Checked = True
    ElseIf Shell.Contains("XBMCLauncher.exe") Then
      Me.rdShellXBMCLauncher.Checked = True
    Else
      Me.rdShellOthers.Checked = True
      Me.lblShell.Text = Shell
    End If
    Exit Sub
err:
    MsgBox(Err.Description, vbOK + vbInformation)
  End Sub

#End Region

#Region "STARTUP SETTINGS"

  ' This generic check box handler requires the Tag property matches the appropriate setting name exactly.
  Private Sub chkChangeSetting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartXBMCatWinLogon.Click, _
    chkStartXBMCatWinResume.Click, chkStartXBMCPortable.Click, chkDisableFocusPermanently.Click, chkFocusOnce.Click, chkCloseXBMCatSleep.Click, _
    chkForceCloseXBMC.Click, chkStartExplorer.Click, chkStartMetroUI.Click

    Dim chkControl As CheckBox = sender
    My.Settings(chkControl.Tag) = chkControl.Checked
  End Sub

  Private Sub txtStartupDelay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStartupDelay.TextChanged
    My.Settings("StartupDelay") = Val(Me.txtStartupDelay.Text) * 1000
  End Sub

#End Region

#Region "FOCUS SETTINGS"

  Private Sub txtFocusDelay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFocusDelay.TextChanged
    My.Settings("FocusDelay") = Val(Me.txtFocusDelay.Text) * 1000
  End Sub

#End Region

#Region "EXIT SETTINGS"

  Private Sub rdShutDown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdShutDown.Click
    My.Settings("ShutdownAction") = "u"
  End Sub

  Private Sub rdSleep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSleep.Click
    My.Settings("ShutdownAction") = "s"
  End Sub

  Private Sub rdHibernate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdHibernate.Click
    My.Settings("ShutdownAction") = "h"
  End Sub

#End Region

#Region "XBMC PATH SETTINGS"

  Private Sub btnSelectXBMCPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectXBMCPath.Click
    Dim xbmcpath As String = My.Computer.Registry.GetValue(RegistrySettingsPath, "XBMC_Path", "")

    ' If the setting doesn't exist, then default to the most likely location of the XBMC executable.
    If xbmcpath = "" Then xbmcpath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\XBMC\XBMC.exe"

    ' Display the browser dialog to the user then change the setting if they clicked ok.
    OpenFileDialog1.Filter = "Executable File|*.exe"
    OpenFileDialog1.Title = "Select XBMC Path"
    OpenFileDialog1.AutoUpgradeEnabled = True
    OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.GetParentPath(xbmcpath)
    OpenFileDialog1.FileName = "XBMC.exe"

    If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      Application.DoEvents()
      xbmcpath = OpenFileDialog1.FileName
      My.Computer.Registry.SetValue(RegistrySettingsPath, "XBMC_Path", xbmcpath, Microsoft.Win32.RegistryValueKind.String)
      Me.lblXBMCPath.Text = ShrinkPathText(xbmcpath, Me.lblXBMCPath)
    End If
  End Sub

  Private Sub btnSelectXBMConIMONPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectXBMConIMONPath.Click
    Dim xbmconimonpath As String = My.Computer.Registry.GetValue(RegistrySettingsPath, "XBMConiMON_Path", "")

    ' If the setting doesn't exist, then default to the most likely location of the XBMC executable.
    If xbmconimonpath = "" Then xbmconimonpath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\XBMC\XBMC.exe"

    ' Display the browser dialog to the user then change the setting if they clicked ok.
    OpenFileDialog1.Filter = "Executable File|*.exe"
    OpenFileDialog1.Title = "Select XBMC on iMON Path"
    OpenFileDialog1.AutoUpgradeEnabled = True
    OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.GetParentPath(xbmconimonpath)
    OpenFileDialog1.FileName = "xbmconimon.exe"

    If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      Application.DoEvents()
      xbmconimonpath = OpenFileDialog1.FileName
      My.Computer.Registry.SetValue(RegistrySettingsPath, "XBMConiMON_Path", xbmconimonpath, Microsoft.Win32.RegistryValueKind.String)
      Me.lblXBMConIMONPath.Text = ShrinkPathText(xbmconimonpath, Me.lblXBMConIMONPath)
    End If
  End Sub

  Private Sub btnSelectiMONManagerPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectiMONManagerPath.Click
    Dim imonpath As String = My.Computer.Registry.GetValue(RegistrySettingsPath, "iMON_Path", "")

    ' If the setting doesn't exist, then default to the most likely location of the iMON executable.
    If imonpath = "" Then imonpath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\SoundGraph\iMON\iMON.exe"

    ' Display the browser dialog to the user then change the setting if they clicked ok.
    OpenFileDialog1.Filter = "Executable File|*.exe"
    OpenFileDialog1.Title = "Select iMON Manager Path"
    OpenFileDialog1.AutoUpgradeEnabled = True
    OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.GetParentPath(imonpath)
    OpenFileDialog1.FileName = "iMON.exe"

    If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'if ok button clicked
      Application.DoEvents() 'first close the selection window
      imonpath = OpenFileDialog1.FileName
      My.Computer.Registry.SetValue(RegistrySettingsPath, "iMON_Path", imonpath, Microsoft.Win32.RegistryValueKind.String)
      Me.lbliMONManagerPath.Text = ShrinkPathText(imonpath, lbliMONManagerPath)
    End If
  End Sub

  Private Sub btnClearXBMCPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearXBMCPath.Click
    My.Computer.Registry.SetValue(RegistrySettingsPath, "XBMC_Path", "", Microsoft.Win32.RegistryValueKind.String)
    Me.lblXBMCPath.Text = ""
  End Sub

  Private Sub btnClearXBMConIMONPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearXBMConIMONPath.Click
    My.Computer.Registry.SetValue(RegistrySettingsPath, "XBMConiMON_Path", "", Microsoft.Win32.RegistryValueKind.String)
    Me.lblXBMConIMONPath.Text = ""
  End Sub

  Private Sub btnCleariMONManagerPOath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCleariMONManagerPOath.Click
    My.Computer.Registry.SetValue(RegistrySettingsPath, "iMON_Path", "", Microsoft.Win32.RegistryValueKind.String)
    Me.lbliMONManagerPath.Text = ""
  End Sub

#End Region

#Region "EXTERNAL PLAYERS"


  'Private Sub chkFocusExternalPlayer_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim chk As Integer
  '  If Me.chkFocusExternalPlayer.Checked Then chk = 1 Else chk = 0
  '  My.Computer.Registry.SetValue(RegistrySettingsPath, "FocusExternalPlayer", chk, Microsoft.Win32.RegistryValueKind.String)
  'End Sub


  Private Sub btnAddExternalPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddExternalPlayer.Click
    OpenFileDialog1.Filter = "Executable File|*.exe"
    OpenFileDialog1.Title = "Select External Player Path"
    OpenFileDialog1.AutoUpgradeEnabled = True
    Dim externalplayerpath As String = My.Computer.Registry.GetValue(RegistrySettingsPath, "ExternalPlayer1_Path", "")
    If externalplayerpath = "" Then
      OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
    Else
      OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.GetParentPath(externalplayerpath)
    End If
    OpenFileDialog1.FileName = My.Computer.FileSystem.GetName(externalplayerpath)

    If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'if ok button clicked
      Application.DoEvents() 'first close the selection window
      externalplayerpath = OpenFileDialog1.FileName
      My.Computer.Registry.SetValue(RegistrySettingsPath, "ExternalPlayer1_Path", externalplayerpath, Microsoft.Win32.RegistryValueKind.String)
      'Me.lblExtPlayer1.Text = ShrinkPathText(externalplayerpath, lblExtPlayer1)
    End If
  End Sub

  Private Sub btnClearExternalPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    My.Computer.Registry.SetValue(RegistrySettingsPath, "ExternalPlayer1_Path", "", Microsoft.Win32.RegistryValueKind.String)
    'Me.lblExtPlayer1.Text = ""
  End Sub

#End Region

#Region "EXTERNAL APPS SETTINGS"

  Private Sub btnAddExternalApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddExternalApp.Click
    OpenFileDialog1.Filter = "Executable File|*.exe"
    OpenFileDialog1.Title = "Select External Application"
    OpenFileDialog1.AutoUpgradeEnabled = True
    Dim AppPath As String = My.Computer.Registry.GetValue(RegistrySettingsPath, "App1_Path", "")
    If AppPath = "" Then
      OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
    Else
      OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.GetParentPath(AppPath)
    End If

    OpenFileDialog1.FileName = My.Computer.FileSystem.GetName(AppPath)

    If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'if ok button clicked
      Application.DoEvents() 'first close the selection window
      AppPath = OpenFileDialog1.FileName
      My.Computer.Registry.SetValue(RegistrySettingsPath, "App1_Path", AppPath, Microsoft.Win32.RegistryValueKind.String)
      'Me.lblApp1.Text = ShrinkPathText(AppPath, lblApp1)
    End If
  End Sub

  'Private Sub chkStartExternalApps1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim chk As Integer
  '  'If Me.chkStartExternalApps1.Checked Then chk = 1 Else chk = 0
  '  My.Computer.Registry.SetValue(RegistrySettingsPath, "StartApps1", chk, Microsoft.Win32.RegistryValueKind.String)
  'End Sub

  'Private Sub chkPreventFocusExternalApps1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim chk As Integer
  '  'If Me.chkPreventFocusExternalApps1.Checked Then chk = 1 Else chk = 0
  '  My.Computer.Registry.SetValue(RegistrySettingsPath, "PreventFocusApps1", chk, Microsoft.Win32.RegistryValueKind.String)
  'End Sub


  ' --------------------------------------        CLEAR EXTERNAL APPS --------------------------------------------------------
  Private Sub btnClearExternalApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    My.Computer.Registry.SetValue(RegistrySettingsPath, "App1_Path", "", Microsoft.Win32.RegistryValueKind.String)
    'Me.lblApp1.Text = ""
  End Sub
#End Region

#Region "SHELL SETTINGS"

  Private Sub rdShellExplorer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdShellWindowsExplorer.Click
    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", "Explorer.exe", Microsoft.Win32.RegistryValueKind.String)
    Me.lblShell.Text = ""
  End Sub

  Private Sub rdShellLauncher_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdShellXBMCLauncher.Click
    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", My.Application.Info.DirectoryPath & "\XBMCLauncher.exe", Microsoft.Win32.RegistryValueKind.String)
    Me.lblShell.Text = ""
  End Sub

  Private Sub btnSelectShell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectShell.Click
    OpenFileDialog1.Filter = "Executable File|*.exe"
    OpenFileDialog1.Title = "Select Shell Application"
    OpenFileDialog1.AutoUpgradeEnabled = True
    Dim Shell As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", "Explorer.exe")
    If Shell = "" Or Shell.ToLower.Contains("explorer") Then
      OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
    Else
      OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.GetParentPath(Shell)
    End If
    OpenFileDialog1.FileName = My.Computer.FileSystem.GetName(Shell)

    If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'if ok button clicked
      Application.DoEvents() 'first close the selection window
      Shell = OpenFileDialog1.FileName
      My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", Shell, Microsoft.Win32.RegistryValueKind.String)
      Me.lblShell.Text = Shell
      Me.rdShellOthers.Checked = True
    End If
  End Sub
#End Region

  Private Sub EndApplication() Handles MyBase.FormClosed
    On Error Resume Next
    My.Settings.Save()
    My.Computer.Registry.SetValue(RegistrySettingsPath, "ReloadXBMCLauncher", 1, Microsoft.Win32.RegistryValueKind.String)
    Shell(My.Application.Info.DirectoryPath & "\XBMCLauncher.exe /r", AppWinStyle.Hide) 'Reload XBMCLauncher script.
  End Sub

  Public Function ShrinkPathText(ByVal sString As String, ByVal lbl As Label) As String

    Dim strWorking As String = String.Copy(sString)
    Dim strResult As String = ""
    Dim charResult As Char = ""
    Me.ToolTip1.SetToolTip(lbl, sString)

    TextRenderer.MeasureText(strWorking, lbl.Font, New Drawing.Size(lbl.Width, 0), TextFormatFlags.PathEllipsis Or TextFormatFlags.ModifyString)

    For Each charResult In strWorking
      If charResult = Nothing Then
        Exit For
      End If
      strResult &= charResult
    Next

    Return strResult

  End Function

  Private Sub lblXBMCPath_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblXBMCPath.TextChanged, lbliMONManagerPath.TextChanged, lblXBMConIMONPath.TextChanged
    If DirectCast(sender, Label).Text = "" Then
      Me.ToolTip1.SetToolTip(DirectCast(sender, Label), "")
    End If
  End Sub

End Class
