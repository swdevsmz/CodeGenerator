Namespace app.dto
    Public Class clsMriyoukigyouBaseDto
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
            Public Property KaishaMei1 As String
                Get
                    Return _KaishaMei1
                End Get
                Set(ByVal value As String)
                    SetProperty(_KaishaMei1, value, "KaishaMei1")
                End Set
            End Property
            Private _KaishaMei1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KaishaMei2 As String
                Get
                    Return _KaishaMei2
                End Get
                Set(ByVal value As String)
                    SetProperty(_KaishaMei2, value, "KaishaMei2")
                End Set
            End Property
            Private _KaishaMei2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KaishaMeiKana As String
                Get
                    Return _KaishaMeiKana
                End Get
                Set(ByVal value As String)
                    SetProperty(_KaishaMeiKana, value, "KaishaMeiKana")
                End Set
            End Property
            Private _KaishaMeiKana As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property YuubinNO As String
                Get
                    Return _YuubinNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_YuubinNO, value, "YuubinNO")
                End Set
            End Property
            Private _YuubinNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Juusho1 As String
                Get
                    Return _Juusho1
                End Get
                Set(ByVal value As String)
                    SetProperty(_Juusho1, value, "Juusho1")
                End Set
            End Property
            Private _Juusho1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Juusho2 As String
                Get
                    Return _Juusho2
                End Get
                Set(ByVal value As String)
                    SetProperty(_Juusho2, value, "Juusho2")
                End Set
            End Property
            Private _Juusho2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Tel As String
                Get
                    Return _Tel
                End Get
                Set(ByVal value As String)
                    SetProperty(_Tel, value, "Tel")
                End Set
            End Property
            Private _Tel As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Fax As String
                Get
                    Return _Fax
                End Get
                Set(ByVal value As String)
                    SetProperty(_Fax, value, "Fax")
                End Set
            End Property
            Private _Fax As String

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
            Public Property BinJohoFLG As Integer
                Get
                    Return _BinJohoFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_BinJohoFLG, value, "BinJohoFLG")
                End Set
            End Property
            Private _BinJohoFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KMS_FLG As Integer
                Get
                    Return _KMS_FLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_KMS_FLG, value, "KMS_FLG")
                End Set
            End Property
            Private _KMS_FLG As Integer

   End Class

End Namespace
