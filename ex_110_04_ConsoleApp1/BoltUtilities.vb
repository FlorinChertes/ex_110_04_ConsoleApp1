Imports System.Globalization

Module BoltUtils

    ' Delegate type for setting bolt properties
    Delegate Sub Setter(bolt As Bolt, value As String)

    ' These methods will be used as delegates to set the properties of the bolt based on the XML data
    Sub GSetBoltSize(bolt As Bolt, sizeStr As String)
        bolt.SetSize(Double.Parse(sizeStr, CultureInfo.InvariantCulture))
    End Sub

    Sub GSetBoltGrade(bolt As Bolt, gradeStr As String)
        bolt.SetGrade(Integer.Parse(gradeStr, CultureInfo.InvariantCulture))
    End Sub

    Sub GSetBoltStandard(bolt As Bolt, standardStr As String)
        bolt.SetStandard(standardStr)
    End Sub

End Module