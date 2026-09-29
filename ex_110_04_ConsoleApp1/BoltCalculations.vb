Imports System.Globalization

Module BoltCalculations

    Sub Print(bolt As Bolt)
        'print the bolt properties
        Console.WriteLine(
            "Bolt size: " & bolt.GetSize().ToString(CultureInfo.InvariantCulture) &
            ", grade: " & bolt.GetGrade().ToString(CultureInfo.InvariantCulture) &
            ", standard: " & bolt.GetStandard()
        )
    End Sub

    Sub Calculate(bolt As Bolt)

        Select Case If(bolt.GetStandard, String.Empty).Trim().ToUpperInvariant()

            Case "AFNOR"
                Console.WriteLine("AFNOR")
                ' ... perform AFNOR-specific calculations here

            Case "BS"
                Console.WriteLine("BS")
                ' ... perform BS-specific calculations here

            Case "GOST"
                Console.WriteLine("GOST")
                ' ... perform GOST-specific calculations here

                ' ... other cases for different standards can be added here

            Case Else
                Console.WriteLine("Not AFNOR, BS, or GOST")
                ' ... perform default calculations here



        End Select

    End Sub

    Sub Calculate_with_factory(bolt As Bolt)

        Dim standard As Standard_Base = Make_Standard(bolt.GetStandard())

        If standard Is Nothing Then
            Console.WriteLine("Not AFNOR, BS, or GOST")
            Return
        End If

        standard.Calculate(bolt)
        Dim size As Double = standard.Calculate_Size(bolt)
        Console.WriteLine("Calculated size: " & size.ToString(CultureInfo.InvariantCulture))

    End Sub

End Module