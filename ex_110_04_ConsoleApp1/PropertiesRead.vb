Imports System
Imports System.Collections.Generic
Imports System.Xml.Linq

Module PropertiesReader

    Public Sub PropertiesRead(ByRef bolt As Bolt, inputFileName As String)

        ' Dictionary mapping XML element names to the corresponding setter methods for the bolt properties
        Dim settersXml As Dictionary(Of String, Setter) = BoltSetterTable.CreateBoltSettersXml()

        'open sorce file
        Dim projectInfo As XElement = LoadProjectInfo(inputFileName)
        If projectInfo Is Nothing Then
            Throw New ApplicationException("Missing <ProjectInfo> element.")
        End If

        'iterate over the child elements of <ProjectInfo> and set the corresponding properties of the bolt
        For Each elem As XElement In projectInfo.Elements()

            Dim propertyName As String = elem.Name.LocalName
            Dim setter As Setter = Nothing

            If settersXml.TryGetValue(propertyName, setter) Then
                Dim propertyValue As String = elem.Value

                If propertyValue IsNot Nothing Then
                    setter.Invoke(bolt, propertyValue)
                End If
            End If
        Next

    End Sub

End Module
