Public Module Standard_factory

    Public Function Make_Standard(standardName As String) As Standard_Base
        Select Case If(standardName, String.Empty).Trim().ToUpperInvariant()

            Case "AFNOR"
                Return New Standard_AFNOR()

            Case "BS"
                Return New Standard_BS()

            Case "GOST"
                Return New Standard_GOST()

                ' ... other cases for different standards can be added here

            Case Else
                Return Nothing

        End Select
    End Function

End Module
