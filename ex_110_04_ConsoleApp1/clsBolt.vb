
Public Class Bolt
    Private size_ As Double
    Private grade_ As Integer
    Private standard_ As String

    Public Sub New()
        size_ = 0.0
        grade_ = 0
        standard_ = ""
    End Sub

    Public Sub New(size As Double, grade As Integer)
        size_ = size
        grade_ = grade
    End Sub

    Public Function GetSize() As Double
        Return size_
    End Function
    Public Sub SetSize(size As Double)
        size_ = size
    End Sub

    Public Function GetGrade() As Integer
        Return grade_
    End Function
    Public Sub SetGrade(grade As Integer)
        grade_ = grade
    End Sub

    Public Function GetStandard() As String
        Return standard_
    End Function
    Public Sub SetStandard(standard As String)
        standard_ = standard
    End Sub

End Class

