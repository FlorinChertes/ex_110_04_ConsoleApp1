Public MustInherit Class Standard_Base
    Public MustOverride Sub Calculate(bolt As Bolt)
    Public MustOverride Function Calculate_Size(bolt As Bolt) As Double
End Class

Public Class Standard_AFNOR
    Inherits Standard_Base

    Public Overrides Sub Calculate(bolt As Bolt)

        Console.WriteLine("AFNOR!")
        '... perform AFNOR-specific calculations here

    End Sub

    Public Overrides Function Calculate_Size(bolt As Bolt) As Double

        Console.WriteLine("AFNOR Size!")
        '... perform AFNOR-specific size calculations here
        Return bolt.GetSize()

    End Function
End Class

Public Class Standard_BS
    Inherits Standard_Base

    Public Overrides Sub Calculate(bolt As Bolt)

        Console.WriteLine("BS")
        '... perform BS-specific calculations here

    End Sub

    Public Overrides Function Calculate_Size(bolt As Bolt) As Double

        Console.WriteLine("BS Size!")
        '... perform BS-specific size calculations here
        Return bolt.GetSize()

    End Function
End Class

Public Class Standard_GOST
    Inherits Standard_Base

    Public Overrides Sub Calculate(bolt As Bolt)

        Console.WriteLine("GOST")
        '... perform GOST-specific calculations here

    End Sub

    Public Overrides Function Calculate_Size(bolt As Bolt) As Double

        Console.WriteLine("GOST Size!")
        '... perform GOST-specific size calculations here
        Return bolt.GetSize()

    End Function
End Class

' Additional standard classes can be added here following the same pattern
