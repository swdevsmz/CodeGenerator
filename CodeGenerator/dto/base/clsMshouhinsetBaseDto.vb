Namespace app.dto.base
    Public Class clsMshouhinsetBaseDto
        Inherits clsBaseDto

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property RiyoukigyouCD As String
                Get
                    Return _RiyoukigyouCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_RiyoukigyouCD, value, "RiyoukigyouCD")
                End Set
            End Property
            Private _RiyoukigyouCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SetCD As String
                Get
                    Return _SetCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_SetCD, value, "SetCD")
                End Set
            End Property
            Private _SetCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SetName As String
                Get
                    Return _SetName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SetName, value, "SetName")
                End Set
            End Property
            Private _SetName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property TokuisakiCD As String
                Get
                    Return _TokuisakiCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_TokuisakiCD, value, "TokuisakiCD")
                End Set
            End Property
            Private _TokuisakiCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SetShubetu As Integer
                Get
                    Return _SetShubetu
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SetShubetu, value, "SetShubetu")
                End Set
            End Property
            Private _SetShubetu As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SetKakaku As Integer
                Get
                    Return _SetKakaku
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SetKakaku, value, "SetKakaku")
                End Set
            End Property
            Private _SetKakaku As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SetImage As Boolean
                Get
                    Return _SetImage
                End Get
                Set(ByVal value As Boolean)
                    SetProperty(_SetImage, value, "SetImage")
                End Set
            End Property
            Private _SetImage As Boolean

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Tesuuryouritu As Decimal
                Get
                    Return _Tesuuryouritu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_Tesuuryouritu, value, "Tesuuryouritu")
                End Set
            End Property
            Private _Tesuuryouritu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property InsertDatetime As Datetime
                Get
                    Return _InsertDatetime
                End Get
                Set(ByVal value As Datetime)
                    SetProperty(_InsertDatetime, value, "InsertDatetime")
                End Set
            End Property
            Private _InsertDatetime As Datetime

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UpdateDatetime As Datetime
                Get
                    Return _UpdateDatetime
                End Get
                Set(ByVal value As Datetime)
                    SetProperty(_UpdateDatetime, value, "UpdateDatetime")
                End Set
            End Property
            Private _UpdateDatetime As Datetime

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UpdateComputerName As Integer
                Get
                    Return _UpdateComputerName
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_UpdateComputerName, value, "UpdateComputerName")
                End Set
            End Property
            Private _UpdateComputerName As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UpdateUserID As String
                Get
                    Return _UpdateUserID
                End Get
                Set(ByVal value As String)
                    SetProperty(_UpdateUserID, value, "UpdateUserID")
                End Set
            End Property
            Private _UpdateUserID As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DeleteFLG As Integer
                Get
                    Return _DeleteFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_DeleteFLG, value, "DeleteFLG")
                End Set
            End Property
            Private _DeleteFLG As Integer

   End Class

End Namespace
