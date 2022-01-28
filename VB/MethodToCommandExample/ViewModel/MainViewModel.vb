Imports DevExpress.Mvvm.POCO
Imports System.Collections.ObjectModel
Imports MethodToCommandExample.Common

Namespace MethodToCommandExample.ViewModel

    Public Class MainViewModel

        Public Sub New()
            Users = New ObservableCollection(Of User)() From {User.Create(0, "Jack"), User.Create(1, "Ron"), User.Create(2, "John"), User.Create(3, "Antoni"), User.Create(4, "Paul")}
        End Sub

        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function

        Public Overridable Property Users As ObservableCollection(Of User)
    End Class
End Namespace
