Imports System.Globalization
Imports System.Diagnostics

Module BoltCalculationsTest

    Sub Calculate_with_factory(bolt As Bolt, size_ref As Double)

        Dim standard As Standard_Base = Make_Standard(bolt.GetStandard())

        If standard Is Nothing Then
            Console.WriteLine("Not AFNOR, BS, or GOST")
            Return
        End If

        standard.Calculate(bolt)
        Dim size As Double = standard.Calculate_Size(bolt)
        Debug.Assert(Math.Abs(size - size_ref) < 0.000001, "Size ist nicht ungefähr " & size_ref)

        Console.WriteLine("Calculated & assert, size: " & size.ToString(CultureInfo.InvariantCulture))

    End Sub

End Module