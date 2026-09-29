' File: BoltSetterTable.vb

Imports System.Collections.Generic

Module BoltSetterTable
    Public Function CreateBoltSettersXml() As Dictionary(Of String, Setter)

        Return New Dictionary(Of String, Setter) From {
            {"PoleBoltSize", AddressOf GSetBoltSize},
            {"PoleBoltGrade", AddressOf GSetBoltGrade},
            {"PoleBoltStandard", AddressOf GSetBoltStandard}
        }

    End Function

End Module