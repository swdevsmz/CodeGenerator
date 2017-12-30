Namespace app.dto
    Public Class clsMsiiresakihatsubanBaseDto
        Inherits clsBaseDto

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiCD As String
                Get
                    Return _SiiresakiCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiCD, value, "SiiresakiCD")
                End Set
            End Property
            Private _SiiresakiCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property RenbanName As String
                Get
                    Return _RenbanName
                End Get
                Set(ByVal value As String)
                    SetProperty(_RenbanName, value, "RenbanName")
                End Set
            End Property
            Private _RenbanName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Settoji As String
                Get
                    Return _Settoji
                End Get
                Set(ByVal value As String)
                    SetProperty(_Settoji, value, "Settoji")
                End Set
            End Property
            Private _Settoji As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Renban As Integer
                Get
                    Return _Renban
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_Renban, value, "Renban")
                End Set
            End Property
            Private _Renban As Integer

   End Class

End Namespace
