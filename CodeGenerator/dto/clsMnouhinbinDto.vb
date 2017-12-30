Namespace app.dto
    Public Class clsMnouhinbinBaseDto
        Inherits clsBaseDto

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property AutoID As Integer
                Get
                    Return _AutoID
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_AutoID, value, "AutoID")
                End Set
            End Property
            Private _AutoID As Integer

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
            Public Property NouhinbinName As String
                Get
                    Return _NouhinbinName
                End Get
                Set(ByVal value As String)
                    SetProperty(_NouhinbinName, value, "NouhinbinName")
                End Set
            End Property
            Private _NouhinbinName As String

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
