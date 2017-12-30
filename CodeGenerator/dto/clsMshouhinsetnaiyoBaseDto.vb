Namespace app.dto
    Public Class clsMshouhinsetnaiyoBaseDto
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
            Public Property SetAutoNo As String
                Get
                    Return _SetAutoNo
                End Get
                Set(ByVal value As String)
                    SetProperty(_SetAutoNo, value, "SetAutoNo")
                End Set
            End Property
            Private _SetAutoNo As String

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
            Public Property ShouhinCD As String
                Get
                    Return _ShouhinCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShouhinCD, value, "ShouhinCD")
                End Set
            End Property
            Private _ShouhinCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Suuryou As Integer
                Get
                    Return _Suuryou
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_Suuryou, value, "Suuryou")
                End Set
            End Property
            Private _Suuryou As Integer

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
            Public Property HanbaiHontaiTanka As Decimal
                Get
                    Return _HanbaiHontaiTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_HanbaiHontaiTanka, value, "HanbaiHontaiTanka")
                End Set
            End Property
            Private _HanbaiHontaiTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HanbaiTankaShouhizei As Decimal
                Get
                    Return _HanbaiTankaShouhizei
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_HanbaiTankaShouhizei, value, "HanbaiTankaShouhizei")
                End Set
            End Property
            Private _HanbaiTankaShouhizei As Decimal

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
            Public Property SiireHontaiTanka As Decimal
                Get
                    Return _SiireHontaiTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireHontaiTanka, value, "SiireHontaiTanka")
                End Set
            End Property
            Private _SiireHontaiTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireTankaShouhizei As Decimal
                Get
                    Return _SiireTankaShouhizei
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireTankaShouhizei, value, "SiireTankaShouhizei")
                End Set
            End Property
            Private _SiireTankaShouhizei As Decimal

   End Class

End Namespace
