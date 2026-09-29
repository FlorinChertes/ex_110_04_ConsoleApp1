Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Xml.Linq
Imports Microsoft.SqlServer



Module Program
    Sub Main(args As String())

        Test_References.Test_AFNOR()
        Test_References.Test_BS()
        Test_References.Test_GOST()

    End Sub
End Module
