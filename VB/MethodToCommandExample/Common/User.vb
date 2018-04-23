Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.Mvvm.POCO

Namespace MethodToCommandExample.Common
    Public Class User
        Protected Sub New(ByVal name As String, ByVal iD As Integer)
            Me.Name = name
            Me.ID = iD
        End Sub
        Public Shared Function Create(ByVal id As Integer, ByVal name As String) As User
            Return ViewModelSource.Create(Function() New User(name, id))
        End Function

        Public Property Name() As String
        Public Property ID() As Integer
    End Class
End Namespace
