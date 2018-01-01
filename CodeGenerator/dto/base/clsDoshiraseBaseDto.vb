Namespace app.dto.base
    Public Class clsDoshiraseBaseDto
        Inherits clsBaseDto

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property guideid As Integer
                Get
                    Return _guideid
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_guideid, value, "guideid")
                End Set
            End Property
            Private _guideid As Integer

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
            Public Property testmode As Integer
                Get
                    Return _testmode
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_testmode, value, "testmode")
                End Set
            End Property
            Private _testmode As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property guide As String
                Get
                    Return _guide
                End Get
                Set(ByVal value As String)
                    SetProperty(_guide, value, "guide")
                End Set
            End Property
            Private _guide As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property information As String
                Get
                    Return _information
                End Get
                Set(ByVal value As String)
                    SetProperty(_information, value, "information")
                End Set
            End Property
            Private _information As String

   End Class

End Namespace
