Module Module1
    Sub Main()
        Dim myPerson As New Person()
        myPerson.Walk(12)

    End Sub

    Private _BirthDate As Date

    Public ReadOnly Property Age() As Integer
        Get
            Return CInt(DateDiff(DateInterval.Year, _BirthDate, Now))
        End Get
    End Property
End Module

Public Class TheClass
    Private _Name As String
    Private _BirthDate As Date
End Class

Public Class Person
    Private mName As String
    Private mBirthDate As Date
    Private mTotalDistance As Integer

    Public Sub Walk(ByVal distance As Integer)
        mTotalDistance += distance
    End Sub

    Public Function Age() As Integer
        Return CInt(DateDiff(DateInterval.Year, mBirthDate, Now()))
    End Function
End Class


