Imports System.Globalization
Imports System.Diagnostics

Module BoltCalculationsTest

    Sub Print(bolt As Bolt)
        'print the bolt properties
        Console.WriteLine(
            "Bolt size: " & bolt.GetSize().ToString(CultureInfo.InvariantCulture) &
            ", grade: " & bolt.GetGrade().ToString(CultureInfo.InvariantCulture) &
            ", standard: " & bolt.GetStandard()
        )
    End Sub

    Sub Calculate_with_factory(bolt As Bolt)

        Dim standard As Standard_Base = Make_Standard(bolt.GetStandard())

        If standard Is Nothing Then
            Console.WriteLine("Not AFNOR, BS, or GOST")
            Return
        End If

        standard.Calculate(bolt)
        Dim size As Double = standard.Calculate_Size(bolt)
        Debug.Assert(Math.Abs(size - 30.213) < 0.000001, "Size ist nicht ungefähr 30.213")

        Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))

    End Sub

End Module