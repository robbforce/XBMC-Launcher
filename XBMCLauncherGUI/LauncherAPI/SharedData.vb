
Public Delegate Function Invoker(ByVal proc As [Delegate]) As Object

Public Class SharedData
  Public Shared AppDataset As New AppData

  Public Enum Apptype
    Player = 1
    Application
  End Enum

  Public Shared ReadOnly Property AuditColumnOrdinal(ByVal ColumnName As String) As Integer
    Get
      Return AppDataset.App.Columns(ColumnName).Ordinal
    End Get
  End Property

  Public Shared Sub ReadDatasetFromXML(ByVal strDataPath As String)
    If FileIO.FileSystem.FileExists(strDataPath) Then
      Try
        Dim fsReadXml As New System.IO.FileStream(strDataPath, System.IO.FileMode.Open)
        AppDataset.ReadXml(fsReadXml, XmlReadMode.ReadSchema)
        fsReadXml.Close()
      Catch ex As Exception
        MsgBox("Unable to read the xml file that stores the application data." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + vbOKOnly, "Database Error!")
      End Try
    End If
  End Sub

  Public Shared Sub SaveDatasetToXML(ByVal strDataPath As String)
    Dim dsTemp As DataSet = New DataSet

    Try
      For Each dtTemp As DataTable In AppDataset.Tables
        dsTemp.Tables.Add(dtTemp.Copy)
      Next

      dsTemp.WriteXml(strDataPath, XmlWriteMode.WriteSchema)
    Catch ex As Exception
      MsgBox("Unable to create the xml file that stores the application data." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + vbOKOnly, "Database Error!")
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

        ' No need to set the id to autonumber. Once the settings are saved, all new rows will have 0's and will get assigned new permanent ids.
        tmpColumn = New DataColumn(AppDataset.App.id_AppColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(AppDataset.App.AppPathColumn.ColumnName, GetType(System.String))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(AppDataset.App.id_AppTypeColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(AppDataset.App.KeepFocusColumn.ColumnName, GetType(System.Boolean))
        tmpTable.Columns.Add(tmpColumn)

        If AppDataset.Tables(AppDataset.App.TableName).Rows.Count > 0 Then
          For Each tmpDataRow As DataRow In AppDataset.Tables(AppDataset.App.TableName).Select(AppDataset.App.id_AppTypeColumn.ColumnName & "=" & Apptype.Player)
            tmpTable.ImportRow(tmpDataRow)
          Next
        End If

      Case Apptype.Application  ' External app
        tmpTable = New DataTable("ExternalApps")

        Dim tmpColumn As DataColumn

        ' No need to set the id to autonumber. Once the settings are saved, all new rows will have 0's and will get assigned new permanent ids.
        tmpColumn = New DataColumn(AppDataset.App.id_AppColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(AppDataset.App.AppPathColumn.ColumnName, GetType(System.String))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(AppDataset.App.id_AppTypeColumn.ColumnName, GetType(System.Int32))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(AppDataset.App.StartWithKodiColumn.ColumnName, GetType(System.Boolean))
        tmpTable.Columns.Add(tmpColumn)
        tmpColumn = New DataColumn(AppDataset.App.KeepFocusColumn.ColumnName, GetType(System.Boolean))
        tmpTable.Columns.Add(tmpColumn)

        'Dim tmpDR As DataRow = tmpTable.NewRow
        'tmpDR(AppDataset.App.id_AppColumn.ColumnName) = 0
        'tmpDR(AppDataset.App.AppPathColumn.ColumnName) = "C:\test\test.exe"
        'tmpDR(AppDataset.App.id_AppTypeColumn.ColumnName) = Apptype.Application
        'tmpDR(AppDataset.App.StartWithKodiColumn.ColumnName) = False
        'tmpDR(AppDataset.App.KeepFocusColumn.ColumnName) = False
        'tmpTable.Rows.Add(tmpDR)
        'tmpTable.AcceptChanges()

        'tmpDR = tmpTable.NewRow
        'tmpDR(AppDataset.App.id_AppColumn.ColumnName) = 0
        'tmpDR(AppDataset.App.AppPathColumn.ColumnName) = "C:\test2\test.exe"
        'tmpDR(AppDataset.App.id_AppTypeColumn.ColumnName) = Apptype.Application
        'tmpDR(AppDataset.App.StartWithKodiColumn.ColumnName) = True
        'tmpDR(AppDataset.App.KeepFocusColumn.ColumnName) = False
        'tmpTable.Rows.Add(tmpDR)
        'tmpTable.AcceptChanges()

        If AppDataset.Tables(AppDataset.App.TableName).Rows.Count > 0 Then
          For Each tmpDataRow As DataRow In AppDataset.Tables(AppDataset.App.TableName).Select(AppDataset.App.id_AppTypeColumn.ColumnName & "=" & Apptype.Application)
            tmpTable.ImportRow(tmpDataRow)
          Next
        End If
    End Select

    ' Accept changes here so we can check the row state of each row later for deletes, during the save routine.
    tmpTable.AcceptChanges()

    Return tmpTable
  End Function

  Public Shared Sub SaveTable(ByVal dtIncoming As DataTable)
    Dim drApp As AppData.AppRow = Nothing
    Dim blnNewRow As Boolean = False         ' Used to control the logic to perform an insert.

    If dtIncoming IsNot Nothing AndAlso dtIncoming.Rows.Count > 0 Then
      Dim dvIncoming As New DataView(dtIncoming, "", "", DataViewRowState.Deleted)

      ' Handle the deleted rows first.
      For Each tmpRow As DataRowView In dvIncoming
        drApp = AppDataset.App.FindByid_App(tmpRow(AppDataset.App.id_AppColumn.ColumnName))

        If drApp IsNot Nothing Then
          drApp.Delete()
          drApp = Nothing
        End If
      Next

      For Each tmpRow As DataRow In dtIncoming.Rows
        If tmpRow.RowState = DataRowState.Added Then
          drApp = AppDataset.App.NewAppRow
          blnNewRow = True
        ElseIf tmpRow.RowState = DataRowState.Modified Then
          ' Set the row to the existing row instead.
          drApp = AppDataset.App.FindByid_App(tmpRow(AppDataset.App.id_AppColumn.ColumnName))

          ' If the id can't be found for some reason, treat this like a new row.
          If drApp Is Nothing Then
            drApp = AppDataset.App.NewAppRow
            blnNewRow = True
          End If
        End If

        ' Only process the new or modified rows. Deletes were handled already.
        If tmpRow.RowState = DataRowState.Added OrElse tmpRow.RowState = DataRowState.Modified Then
          For Each tmpColumn As DataColumn In dtIncoming.Columns
            ' Update all columns except the app id.
            If tmpColumn.ColumnName <> AppDataset.App.id_AppColumn.ColumnName Then
              drApp(tmpColumn.ColumnName) = tmpRow(tmpColumn.ColumnName)
            End If
          Next

          ' Insert the row and reset the boolean for the next row.
          If blnNewRow = True Then
            AppDataset.App.Rows.Add(drApp)
            blnNewRow = False
          End If

          drApp = Nothing
        End If
      Next
    End If

    AppDataset.App.AcceptChanges()
  End Sub
End Class
