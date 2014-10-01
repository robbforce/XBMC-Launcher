
Public Delegate Function Invoker(ByVal proc As [Delegate]) As Object

Public Class SharedData
  Protected Shared m_AppData As New AppData

  Public Enum Apptype
    Player = 1
    Application
  End Enum

  Public Shared ReadOnly Property AuditColumnOrdinal(ByVal ColumnName As String) As Integer
    Get
      Return m_AppData.App.Columns(ColumnName).Ordinal
    End Get
  End Property

  Public Shared Sub ReadDatasetFromXML(ByVal strDataPath As String)
    If FileIO.FileSystem.FileExists(strDataPath) Then
      Try
        Dim fsReadXml As New System.IO.FileStream(strDataPath, System.IO.FileMode.Open)
        m_AppData.ReadXml(fsReadXml, XmlReadMode.ReadSchema)
        fsReadXml.Close()
      Catch ex As Exception
        MsgBox("Unable to read the xml file that stores the application data." & vbCrLf & vbCrLf & ex.ToString(), MsgBoxStyle.Exclamation + vbOKOnly, "Database Error!")
      End Try
    End If
  End Sub

  Public Shared Sub SaveDatasetToXML(ByVal strDataPath As String)
    Dim dsTemp As DataSet = New DataSet

    Try
      For Each dtTemp As DataTable In m_AppData.Tables
        dsTemp.Tables.Add(dtTemp.Copy)
      Next

      dsTemp.WriteXml(strDataPath, XmlWriteMode.WriteSchema)
    Catch ex As Exception
      MsgBox("Unable to create the xml file that stores the application data." & vbCrLf & vbCrLf & ex.ToString(), MsgBoxStyle.Exclamation + vbOKOnly, "Database Error!")
    Finally
      dsTemp.Dispose()
    End Try
  End Sub

  Public Shared Function GetTable(ByVal strAppType As String) As DataTable
    Dim tmpTable As DataTable = Nothing

    Select Case strAppType
      Case Apptype.Player     ' External player
        tmpTable = New DataTable("ExternalPlayers")

        Dim tmpColumn As DataColumn
        tmpColumn = New DataColumn(m_AppData.App.id_AppColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(m_AppData.App.AppPathColumn.ColumnName, GetType(System.String))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(m_AppData.App.id_AppTypeColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(m_AppData.App.KeepFocusColumn.ColumnName, GetType(System.Boolean))
        tmpTable.Columns.Add(tmpColumn)

        If m_AppData.Tables(m_AppData.App.TableName).Rows.Count > 0 Then
          For Each tmpDataRow As DataRow In m_AppData.Tables(m_AppData.App.TableName).Select(m_AppData.App.id_AppTypeColumn.ColumnName & "=" & Apptype.Player)
            tmpTable.Rows.Add(tmpDataRow)
          Next
        End If

      Case Apptype.Application  ' External app
        tmpTable = New DataTable("ExternalApps")

        Dim tmpColumn As DataColumn
        tmpColumn = New DataColumn(m_AppData.App.id_AppColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(m_AppData.App.AppPathColumn.ColumnName, GetType(System.String))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(m_AppData.App.id_AppTypeColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(m_AppData.App.StartWithKodiColumn.ColumnName, GetType(System.Boolean))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(m_AppData.App.KeepFocusColumn.ColumnName, GetType(System.Boolean))
        tmpTable.Columns.Add(tmpColumn)

        tmpTable.Rows.Add(New Object() {1, "C:\test\test.exe", Apptype.Application, False, False})
        tmpTable.Rows.Add(New Object() {2, "C:\test2\test.exe", Apptype.Application, True, False})

        'If m_AppData.Tables("App").Rows.Count > 0 Then
        '  For Each tmpDataRow As DataRow In m_AppData.Tables(m_AppData.App.TableName).Select(m_AppData.App.id_AppTypeColumn.ColumnName & "=" & Apptype.Application)
        '    tmpTable.Rows.Add(New Object() {True, "Yes"})
        '  Next
        'End If
    End Select

    Return tmpTable

  End Function
End Class
