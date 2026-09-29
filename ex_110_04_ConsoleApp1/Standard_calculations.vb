Public MustInherit Class Standard_Base
    Public MustOverride Sub Calculate(bolt As Bolt)
End Class

Public Class Standard_AFNOR
    Inherits Standard_Base

    Public Overrides Sub Calculate(bolt As Bolt)

        Console.WriteLine("AFNOR!")
        '... perform AFNOR-specific calculations here

    End Sub
End Class

Public Class Standard_BS
    Inherits Standard_Base

    Public Overrides Sub Calculate(bolt As Bolt)

        Console.WriteLine("BS")
        '... perform BS-specific calculations here

    End Sub
End Class

Public Class Standard_GOST
    Inherits Standard_Base

    Public Overrides Sub Calculate(bolt As Bolt)

        Console.WriteLine("GOST")
        '... perform GOST-specific calculations here

    End Sub
End Class

' Additional standard classes can be added here following the same pattern
