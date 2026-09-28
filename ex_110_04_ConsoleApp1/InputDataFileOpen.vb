Imports System.Xml.Linq

Module InputDataFileOpen
    Public Function LoadProjectInfo(inputFileName As String) As XElement

        Dim doc As XDocument

        Try
            doc = XDocument.Load(inputFileName)
        Catch ex As Exception
            Throw New ApplicationException(
            $"Could not load XML file '{inputFileName}'.", ex)
        End Try

        Dim root As XElement = doc.Element("DesignData")

        If root Is Nothing Then
            Throw New ApplicationException("Missing <DesignData> element.")
        End If

        Dim projectInfo As XElement = root.Element("ProjectInfo")

        If projectInfo Is Nothing Then
            Throw New ApplicationException("Missing <ProjectInfo> element.")
        End If

        Return projectInfo

    End Function
End Module