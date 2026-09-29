Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Xml.Linq
Imports Microsoft.SqlServer


Module Module1

    Sub Main()

        'the bolt object that will be populated with the data from the XML file
        Dim bolt As New Bolt()

        ' Dictionary mapping XML element names to the corresponding setter methods for the bolt properties
        Dim settersXml As Dictionary(Of String, Setter) = BoltSetterTable.CreateBoltSettersXml()

        'open sorce file
        Dim projectInfo As XElement = LoadProjectInfo("data/tower_de/tower_de_001.xml")
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

        'print the bolt properties
        BoltCalculations.Print(bolt)

        ' BoltCalculations.Calculate(bolt)
        BoltCalculations.Calculate_with_factory(bolt)

        BoltCalculationsTest.Calculate_with_factory(bolt)



    End Sub

    End Module
