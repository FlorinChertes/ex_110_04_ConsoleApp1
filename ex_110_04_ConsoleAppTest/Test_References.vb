Imports System.Globalization

Public Module Test_References

    Public Function Test_AFNOR() As Boolean
        'the bolt object that will be populated
        Dim bolt As New Bolt()

        PropertiesRead(bolt, "data/tower_de/tower_de_001.xml")

        Dim size As Double = BoltCalculations.Calculate_with_factory(bolt)

        If (Double.IsNaN(size)) Then
            Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))
            Return False
        Else
            Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))
            Debug.Assert(Math.Abs(size - 30.213) < 0.000001, "Size ist nicht ungefähr " & 30.213)
            Return True
        End If

    End Function

    Public Function Test_BS() As Boolean
        'the bolt object that will be populated
        Dim bolt As New Bolt()

        PropertiesRead(bolt, "data/tower_de/tower_de_002.xml")

        Dim size As Double = BoltCalculations.Calculate_with_factory(bolt)
        If (Double.IsNaN(size)) Then
            Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))
            Return False
        Else
            Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))
            Debug.Assert(Math.Abs(size - 30.263) < 0.000001, "Size ist nicht ungefähr " & 30.263)
            Return True
        End If

    End Function

    Public Function Test_GOST() As Boolean
        'the bolt object that will be populated
        Dim bolt As New Bolt()

        PropertiesRead(bolt, "data/tower_de/tower_de_003.xml")

        Dim size As Double = BoltCalculations.Calculate_with_factory(bolt)
        If (Double.IsNaN(size)) Then
            Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))
            Return False
        Else
            Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))
            Debug.Assert(Math.Abs(size - 30.243) < 0.000001, "Size ist nicht ungefähr " & 30.243)
            Return True
        End If

    End Function


End Module
