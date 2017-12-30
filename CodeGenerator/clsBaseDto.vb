Imports System.ComponentModel

Namespace app.dto

    Public Class clsBaseDto
        Implements INotifyPropertyChanged

        Protected Event PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs) _
                              Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub SetProperty(Of T)(ByRef storage As T, ByVal value As T,
                                      ByVal propertyName As String)
            'If Object.Equals(storage, value) Then
            '    Return
            'End If
            storage = value
            OnPropertyChanged(propertyName)
        End Sub

        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

    End Class

End Namespace
