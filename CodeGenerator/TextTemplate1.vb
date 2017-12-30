


Namespace app.dto

    ''' <summary>
    ''' 部門マスタDto
    ''' </summary>
    ''' <remarks></remarks>
    Public Class clsMbumonDto
        Inherits clsBaseDto

   

        ''' <summary>
        ''' 部門コード
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BumonCD As String
            Get
                Return _BumonCD
            End Get
            Set(ByVal value As String)
                SetProperty(_BumonCD, value, "BumonCD")
            End Set
        End Property
        Private _BumonCD As String

   

        ''' <summary>
        ''' 部門コード
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BumonName As String
            Get
                Return _BumonName
            End Get
            Set(ByVal value As String)
                SetProperty(_BumonName, value, "BumonName")
            End Set
        End Property
        Private _BumonName As String


    End Class

End Namespace