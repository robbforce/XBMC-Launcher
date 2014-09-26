Imports System.Drawing
Imports System.Xml.Serialization
Imports System.IO

Namespace AppSettings

  <Serializable()> _
  Public Class clsSettings
    Public Setting As New Generic.List(Of clsSetting)

    <Serializable()> _
    Public Class clsSetting
      Public Key As String
      Public Value As Object
    End Class
  End Class

  <Serializable()> _
  Public Class sFont
    Public FontName As String
    Public Size As Single
    Public Style As Integer
  End Class

  <Serializable()> _
  Public Class sColor
    Public A As Byte
    Public R As Byte
    Public G As Byte
    Public B As Byte
  End Class

End Namespace

Namespace My

  Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase

    Private strAppFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & My.Application.Info.Title
    Private strConfigFile As String = strAppFolder & "\" & "settings.xml"

    Public Sub userOverride_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
      If FileIO.FileSystem.FileExists(strConfigFile) Then
        Try
          Dim serializer As XmlSerializer = New XmlSerializer(GetType(AppSettings.clsSettings), New Type() {GetType(Color), GetType(System.Drawing.Size)})
          Dim streamSettings As New StreamReader(strConfigFile)
          Dim clsSettings As AppSettings.clsSettings

          clsSettings = serializer.Deserialize(streamSettings)
          streamSettings.Close()

          For Each Item As AppSettings.clsSettings.clsSetting In clsSettings.Setting

            Try
              If TypeOf Item.Value Is System.Array Then
                If TypeOf Item.Value(0) Is System.Xml.XmlAttribute Then
                  Dim ValueType As System.Xml.XmlAttribute = Item.Value(0)

                  Select Case ValueType.Value
                    Case "sColor"
                      Dim sColor As Color = Color.FromArgb(Item.Value(1).innertext, Item.Value(2).innertext, Item.Value(3).innertext, Item.Value(4).innertext)

                      Me(Item.Key) = sColor

                    Case "sFont"
                      Dim FS As FontStyle = Item.Value(3).innertext
                      Dim sFont As New Font(CStr(Item.Value(1).innertext), CSng(Item.Value(2).innertext), FS)

                      Me(Item.Key) = sFont
                  End Select
                End If
              Else
                Me(Item.Key) = Item.Value
              End If

            Catch ex As Exception

            End Try
          Next

        Catch ex As Exception

        End Try
      End If
    End Sub

    Private Sub userOverride_SettingsSaving(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.SettingsSaving
      If Not FileIO.FileSystem.DirectoryExists(strAppFolder) Then FileIO.FileSystem.CreateDirectory(strAppFolder)

      Dim clssettings As New AppSettings.clsSettings

      For Each appProperty As System.Configuration.SettingsProperty In My.Settings.Properties
        Dim clsSetting As New AppSettings.clsSettings.clsSetting

        clsSetting.Key = appProperty.Name

        If TypeOf Me(appProperty.Name) Is Font Then
          Dim OrigValue As Font = Me(appProperty.Name)
          Dim ValueItem As New AppSettings.sFont

          ValueItem.FontName = OrigValue.OriginalFontName
          ValueItem.Style = OrigValue.Style
          ValueItem.Size = OrigValue.Size
          clsSetting.Value = ValueItem

        ElseIf TypeOf Me(appProperty.Name) Is Color Then
          Dim OrigValue As Color = Me(appProperty.Name)
          Dim ValueItem As New AppSettings.sColor

          ValueItem.A = OrigValue.A
          ValueItem.R = OrigValue.R
          ValueItem.G = OrigValue.G
          ValueItem.B = OrigValue.B
          clsSetting.Value = ValueItem

        Else
          clsSetting.Value = Me(appProperty.Name)
        End If

        clssettings.Setting.Add(clsSetting)
      Next

      Dim serializer As XmlSerializer = New XmlSerializer(GetType(AppSettings.clsSettings), New Type() {GetType(Color), GetType(System.Drawing.Size), GetType(AppSettings.sFont), GetType(AppSettings.sColor)})
      Dim tw As TextWriter = New StreamWriter(strConfigFile)
      serializer.Serialize(tw, clssettings)
      tw.Close()
    End Sub
  End Class
End Namespace
