
Public Class Bolt
    Private size_ As Double
    Private grade_ As Integer

    Public Sub New()
        size_ = 0.0
        grade_ = 0
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
End Class

