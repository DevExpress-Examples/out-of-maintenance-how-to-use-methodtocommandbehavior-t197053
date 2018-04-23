Imports System
Imports System.Linq
Imports System.Windows
Imports System.Collections.Generic

Namespace MethodToCommandExample
    Partial Public Class App
        Inherits Application

        Private Sub OnAppStartup_UpdateThemeName(ByVal sender As Object, ByVal e As StartupEventArgs)

            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName()
        End Sub
    End Class
End Namespace
