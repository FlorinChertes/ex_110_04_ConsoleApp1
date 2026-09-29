Imports System
Imports System.Globalization
Imports Microsoft.SqlServer


Module Module1

    Sub Main()

        'the bolt object that will be populated with the data from the XML file
        Dim bolt As New Bolt()

        PropertiesRead(bolt, "data/tower_de/tower_de_001.xml")

        'print the bolt properties
        BoltCalculations.Print(bolt)

        ' BoltCalculations.Calculate(bolt)
        Dim size As Double = BoltCalculations.Calculate_with_factory(bolt)
        Console.WriteLine("Calculated size: " & size.ToString(CultureInfo.InvariantCulture))

    End Sub

End Module
