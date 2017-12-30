Namespace app.dto
    Public Class clsMuserBaseDto
        Inherits clsBaseDto

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property username As String
                Get
                    Return _username
                End Get
                Set(ByVal value As String)
                    SetProperty(_username, value, "username")
                End Set
            End Property
            Private _username As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property password As String
                Get
                    Return _password
                End Get
                Set(ByVal value As String)
                    SetProperty(_password, value, "password")
                End Set
            End Property
            Private _password As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
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
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UserNameKanji As String
                Get
                    Return _UserNameKanji
                End Get
                Set(ByVal value As String)
                    SetProperty(_UserNameKanji, value, "UserNameKanji")
                End Set
            End Property
            Private _UserNameKanji As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UserShubetu As Integer
                Get
                    Return _UserShubetu
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_UserShubetu, value, "UserShubetu")
                End Set
            End Property
            Private _UserShubetu As Integer

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

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuShouninKengenFLG As Integer
                Get
                    Return _HacchuuShouninKengenFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HacchuuShouninKengenFLG, value, "HacchuuShouninKengenFLG")
                End Set
            End Property
            Private _HacchuuShouninKengenFLG As Integer

   End Class

End Namespace
