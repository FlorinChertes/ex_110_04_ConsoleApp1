Public Module Test_References

    Public Function Test_AFNOR()
        'the bolt object that will be populated
        Dim bolt As New Bolt()

        bolt.SetSize(30.213)
        bolt.SetGrade(9)
        bolt.SetStandard("AFNOR")

        BoltCalculationsTest.Calculate_with_factory(bolt, 30.213)
    End Function

    Public Function Test_BS()
        'the bolt object that will be populated
        Dim bolt As New Bolt()

        bolt.SetSize(30.263)
        bolt.SetGrade(9)
        bolt.SetStandard("BS")

        BoltCalculationsTest.Calculate_with_factory(bolt, 30.263)
    End Function

    Public Function Test_GOST()
        'the bolt object that will be populated
        Dim bolt As New Bolt()

        bolt.SetSize(30.243)
        bolt.SetGrade(9)
        bolt.SetStandard("GOST")

        BoltCalculationsTest.Calculate_with_factory(bolt, 30.243)
    End Function


End Module
