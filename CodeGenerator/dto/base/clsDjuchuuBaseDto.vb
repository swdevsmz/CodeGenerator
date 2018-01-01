Namespace app.dto.base
    Public Class clsDjuchuuBaseDto
        Inherits clsBaseDto

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JuchuuNO As String
                Get
                    Return _JuchuuNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_JuchuuNO, value, "JuchuuNO")
                End Set
            End Property
            Private _JuchuuNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DataKBN As Integer
                Get
                    Return _DataKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_DataKBN, value, "DataKBN")
                End Set
            End Property
            Private _DataKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UserKBN As Integer
                Get
                    Return _UserKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_UserKBN, value, "UserKBN")
                End Set
            End Property
            Private _UserKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SystemKBN As Integer
                Get
                    Return _SystemKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SystemKBN, value, "SystemKBN")
                End Set
            End Property
            Private _SystemKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KijunDate As Date
                Get
                    Return _KijunDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_KijunDate, value, "KijunDate")
                End Set
            End Property
            Private _KijunDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ZigyoushoCD As String
                Get
                    Return _ZigyoushoCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_ZigyoushoCD, value, "ZigyoushoCD")
                End Set
            End Property
            Private _ZigyoushoCD As String

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
            Public Property TantoushaCD As String
                Get
                    Return _TantoushaCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_TantoushaCD, value, "TantoushaCD")
                End Set
            End Property
            Private _TantoushaCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuDate As Date
                Get
                    Return _HacchuuDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_HacchuuDate, value, "HacchuuDate")
                End Set
            End Property
            Private _HacchuuDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KaikeiYYMM As Integer
                Get
                    Return _KaikeiYYMM
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_KaikeiYYMM, value, "KaikeiYYMM")
                End Set
            End Property
            Private _KaikeiYYMM As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NouhinDate As Date
                Get
                    Return _NouhinDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_NouhinDate, value, "NouhinDate")
                End Set
            End Property
            Private _NouhinDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KenshuuYoteiDate As Date
                Get
                    Return _KenshuuYoteiDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_KenshuuYoteiDate, value, "KenshuuYoteiDate")
                End Set
            End Property
            Private _KenshuuYoteiDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireYoteiDate As Date
                Get
                    Return _SiireYoteiDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_SiireYoteiDate, value, "SiireYoteiDate")
                End Set
            End Property
            Private _SiireYoteiDate As Date

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
            Public Property SiiresakiName As String
                Get
                    Return _SiiresakiName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiName, value, "SiiresakiName")
                End Set
            End Property
            Private _SiiresakiName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiCD As String
                Get
                    Return _SiharaisakiCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiCD, value, "SiharaisakiCD")
                End Set
            End Property
            Private _SiharaisakiCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiName As String
                Get
                    Return _SiharaisakiName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiName, value, "SiharaisakiName")
                End Set
            End Property
            Private _SiharaisakiName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouhizeiNaigaiHyoukiKBN As Integer
                Get
                    Return _ShouhizeiNaigaiHyoukiKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ShouhizeiNaigaiHyoukiKBN, value, "ShouhizeiNaigaiHyoukiKBN")
                End Set
            End Property
            Private _ShouhizeiNaigaiHyoukiKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property TuukaCD As String
                Get
                    Return _TuukaCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_TuukaCD, value, "TuukaCD")
                End Set
            End Property
            Private _TuukaCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property RateKBN As Integer
                Get
                    Return _RateKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_RateKBN, value, "RateKBN")
                End Set
            End Property
            Private _RateKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireRate As Decimal
                Get
                    Return _SiireRate
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireRate, value, "SiireRate")
                End Set
            End Property
            Private _SiireRate As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoukoCD As String
                Get
                    Return _SoukoCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoukoCD, value, "SoukoCD")
                End Set
            End Property
            Private _SoukoCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HaisouGyoushaCD As String
                Get
                    Return _HaisouGyoushaCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_HaisouGyoushaCD, value, "HaisouGyoushaCD")
                End Set
            End Property
            Private _HaisouGyoushaCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiChuumonNO As String
                Get
                    Return _SiiresakiChuumonNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiChuumonNO, value, "SiiresakiChuumonNO")
                End Set
            End Property
            Private _SiiresakiChuumonNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property AnkenNO As String
                Get
                    Return _AnkenNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_AnkenNO, value, "AnkenNO")
                End Set
            End Property
            Private _AnkenNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuDenpyouTekiyou As String
                Get
                    Return _HacchuuDenpyouTekiyou
                End Get
                Set(ByVal value As String)
                    SetProperty(_HacchuuDenpyouTekiyou, value, "HacchuuDenpyouTekiyou")
                End Set
            End Property
            Private _HacchuuDenpyouTekiyou As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouSiireHontaiKingaku As Decimal
                Get
                    Return _DenpyouSiireHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouSiireHontaiKingaku, value, "DenpyouSiireHontaiKingaku")
                End Set
            End Property
            Private _DenpyouSiireHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouSiireHenpinHontaiKingaku As Decimal
                Get
                    Return _DenpyouSiireHenpinHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouSiireHenpinHontaiKingaku, value, "DenpyouSiireHenpinHontaiKingaku")
                End Set
            End Property
            Private _DenpyouSiireHenpinHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouSiireNebikiHontaiKingaku As Decimal
                Get
                    Return _DenpyouSiireNebikiHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouSiireNebikiHontaiKingaku, value, "DenpyouSiireNebikiHontaiKingaku")
                End Set
            End Property
            Private _DenpyouSiireNebikiHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouSiireShouhizeiGaku As Decimal
                Get
                    Return _DenpyouSiireShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouSiireShouhizeiGaku, value, "DenpyouSiireShouhizeiGaku")
                End Set
            End Property
            Private _DenpyouSiireShouhizeiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouJoudaiHontaiKingaku As Decimal
                Get
                    Return _DenpyouJoudaiHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouJoudaiHontaiKingaku, value, "DenpyouJoudaiHontaiKingaku")
                End Set
            End Property
            Private _DenpyouJoudaiHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouJoudaiShouhizeiGaku As Decimal
                Get
                    Return _DenpyouJoudaiShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouJoudaiShouhizeiGaku, value, "DenpyouJoudaiShouhizeiGaku")
                End Set
            End Property
            Private _DenpyouJoudaiShouhizeiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouGaikaSiireHontaiKingaku As Decimal
                Get
                    Return _DenpyouGaikaSiireHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouGaikaSiireHontaiKingaku, value, "DenpyouGaikaSiireHontaiKingaku")
                End Set
            End Property
            Private _DenpyouGaikaSiireHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouGaikaSiireHenpinHontaiKingaku As Decimal
                Get
                    Return _DenpyouGaikaSiireHenpinHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouGaikaSiireHenpinHontaiKingaku, value, "DenpyouGaikaSiireHenpinHontaiKingaku")
                End Set
            End Property
            Private _DenpyouGaikaSiireHenpinHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouGaikaSiireNebikiHontaiKingaku As Decimal
                Get
                    Return _DenpyouGaikaSiireNebikiHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouGaikaSiireNebikiHontaiKingaku, value, "DenpyouGaikaSiireNebikiHontaiKingaku")
                End Set
            End Property
            Private _DenpyouGaikaSiireNebikiHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouGaikaSiireShouhizeiGaku As Decimal
                Get
                    Return _DenpyouGaikaSiireShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouGaikaSiireShouhizeiGaku, value, "DenpyouGaikaSiireShouhizeiGaku")
                End Set
            End Property
            Private _DenpyouGaikaSiireShouhizeiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouGaikaJoudaiHontaiKingaku As Decimal
                Get
                    Return _DenpyouGaikaJoudaiHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouGaikaJoudaiHontaiKingaku, value, "DenpyouGaikaJoudaiHontaiKingaku")
                End Set
            End Property
            Private _DenpyouGaikaJoudaiHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property DenpyouGaikaJoudaiShouhizeiGaku As Decimal
                Get
                    Return _DenpyouGaikaJoudaiShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_DenpyouGaikaJoudaiShouhizeiGaku, value, "DenpyouGaikaJoudaiShouhizeiGaku")
                End Set
            End Property
            Private _DenpyouGaikaJoudaiShouhizeiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaiKBN As Integer
                Get
                    Return _SiharaiKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SiharaiKBN, value, "SiharaiKBN")
                End Set
            End Property
            Private _SiharaiKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaiChouhaKBN As Integer
                Get
                    Return _SiharaiChouhaKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SiharaiChouhaKBN, value, "SiharaiChouhaKBN")
                End Set
            End Property
            Private _SiharaiChouhaKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaiHouhouCD As String
                Get
                    Return _SiharaiHouhouCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaiHouhouCD, value, "SiharaiHouhouCD")
                End Set
            End Property
            Private _SiharaiHouhouCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaiYoteiDate As Date
                Get
                    Return _SiharaiYoteiDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_SiharaiYoteiDate, value, "SiharaiYoteiDate")
                End Set
            End Property
            Private _SiharaiYoteiDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuushoTekiyou As String
                Get
                    Return _HacchuushoTekiyou
                End Get
                Set(ByVal value As String)
                    SetProperty(_HacchuushoTekiyou, value, "HacchuushoTekiyou")
                End Set
            End Property
            Private _HacchuushoTekiyou As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuushoHuyouFLG As Integer
                Get
                    Return _HacchuushoHuyouFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HacchuushoHuyouFLG, value, "HacchuushoHuyouFLG")
                End Set
            End Property
            Private _HacchuushoHuyouFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuushoHakkouTaishouFLG As Integer
                Get
                    Return _HacchuushoHakkouTaishouFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HacchuushoHakkouTaishouFLG, value, "HacchuushoHakkouTaishouFLG")
                End Set
            End Property
            Private _HacchuushoHakkouTaishouFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuushoHakkouFLG As Integer
                Get
                    Return _HacchuushoHakkouFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HacchuushoHakkouFLG, value, "HacchuushoHakkouFLG")
                End Set
            End Property
            Private _HacchuushoHakkouFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuushoHakkouDatetime As Datetime
                Get
                    Return _HacchuushoHakkouDatetime
                End Get
                Set(ByVal value As Datetime)
                    SetProperty(_HacchuushoHakkouDatetime, value, "HacchuushoHakkouDatetime")
                End Set
            End Property
            Private _HacchuushoHakkouDatetime As Datetime

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuNO As String
                Get
                    Return _HacchuuNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_HacchuuNO, value, "HacchuuNO")
                End Set
            End Property
            Private _HacchuuNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuGyouNO As Integer
                Get
                    Return _HacchuuGyouNO
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HacchuuGyouNO, value, "HacchuuGyouNO")
                End Set
            End Property
            Private _HacchuuGyouNO As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NyuukaYoteiKanryouKBN As Integer
                Get
                    Return _NyuukaYoteiKanryouKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_NyuukaYoteiKanryouKBN, value, "NyuukaYoteiKanryouKBN")
                End Set
            End Property
            Private _NyuukaYoteiKanryouKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NyuukaKanryouKBN As Integer
                Get
                    Return _NyuukaKanryouKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_NyuukaKanryouKBN, value, "NyuukaKanryouKBN")
                End Set
            End Property
            Private _NyuukaKanryouKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireKanryouKBN As Integer
                Get
                    Return _SiireKanryouKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SiireKanryouKBN, value, "SiireKanryouKBN")
                End Set
            End Property
            Private _SiireKanryouKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SubSystemDenpyouNO As String
                Get
                    Return _SubSystemDenpyouNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_SubSystemDenpyouNO, value, "SubSystemDenpyouNO")
                End Set
            End Property
            Private _SubSystemDenpyouNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property MitumoriNO As String
                Get
                    Return _MitumoriNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_MitumoriNO, value, "MitumoriNO")
                End Set
            End Property
            Private _MitumoriNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property MitumoriNOEdaban As Integer
                Get
                    Return _MitumoriNOEdaban
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_MitumoriNOEdaban, value, "MitumoriNOEdaban")
                End Set
            End Property
            Private _MitumoriNOEdaban As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property AnkenGuid As Boolean
                Get
                    Return _AnkenGuid
                End Get
                Set(ByVal value As Boolean)
                    SetProperty(_AnkenGuid, value, "AnkenGuid")
                End Set
            End Property
            Private _AnkenGuid As Boolean

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouninJoutaiKBN As Integer
                Get
                    Return _ShouninJoutaiKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ShouninJoutaiKBN, value, "ShouninJoutaiKBN")
                End Set
            End Property
            Private _ShouninJoutaiKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KihyouUserID As String
                Get
                    Return _KihyouUserID
                End Get
                Set(ByVal value As String)
                    SetProperty(_KihyouUserID, value, "KihyouUserID")
                End Set
            End Property
            Private _KihyouUserID As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property CurrentUserID As String
                Get
                    Return _CurrentUserID
                End Get
                Set(ByVal value As String)
                    SetProperty(_CurrentUserID, value, "CurrentUserID")
                End Set
            End Property
            Private _CurrentUserID As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouninUserID As String
                Get
                    Return _ShouninUserID
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShouninUserID, value, "ShouninUserID")
                End Set
            End Property
            Private _ShouninUserID As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouninDatetime As Datetime
                Get
                    Return _ShouninDatetime
                End Get
                Set(ByVal value As Datetime)
                    SetProperty(_ShouninDatetime, value, "ShouninDatetime")
                End Set
            End Property
            Private _ShouninDatetime As Datetime

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property MaeAnkenGuid As Boolean
                Get
                    Return _MaeAnkenGuid
                End Get
                Set(ByVal value As Boolean)
                    SetProperty(_MaeAnkenGuid, value, "MaeAnkenGuid")
                End Set
            End Property
            Private _MaeAnkenGuid As Boolean

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ZigyoushoGroup1CD As String
                Get
                    Return _ZigyoushoGroup1CD
                End Get
                Set(ByVal value As String)
                    SetProperty(_ZigyoushoGroup1CD, value, "ZigyoushoGroup1CD")
                End Set
            End Property
            Private _ZigyoushoGroup1CD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ZigyoushoGroup2CD As String
                Get
                    Return _ZigyoushoGroup2CD
                End Get
                Set(ByVal value As String)
                    SetProperty(_ZigyoushoGroup2CD, value, "ZigyoushoGroup2CD")
                End Set
            End Property
            Private _ZigyoushoGroup2CD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property BumonGroup1CD As String
                Get
                    Return _BumonGroup1CD
                End Get
                Set(ByVal value As String)
                    SetProperty(_BumonGroup1CD, value, "BumonGroup1CD")
                End Set
            End Property
            Private _BumonGroup1CD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property BumonGroup2CD As String
                Get
                    Return _BumonGroup2CD
                End Get
                Set(ByVal value As String)
                    SetProperty(_BumonGroup2CD, value, "BumonGroup2CD")
                End Set
            End Property
            Private _BumonGroup2CD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property BumonGroup3CD As String
                Get
                    Return _BumonGroup3CD
                End Get
                Set(ByVal value As String)
                    SetProperty(_BumonGroup3CD, value, "BumonGroup3CD")
                End Set
            End Property
            Private _BumonGroup3CD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiSeisikiName As String
                Get
                    Return _SiiresakiSeisikiName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiSeisikiName, value, "SiiresakiSeisikiName")
                End Set
            End Property
            Private _SiiresakiSeisikiName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiYuubinNO1 As String
                Get
                    Return _SiiresakiYuubinNO1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiYuubinNO1, value, "SiiresakiYuubinNO1")
                End Set
            End Property
            Private _SiiresakiYuubinNO1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiYuubinNO2 As String
                Get
                    Return _SiiresakiYuubinNO2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiYuubinNO2, value, "SiiresakiYuubinNO2")
                End Set
            End Property
            Private _SiiresakiYuubinNO2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiJuusho1 As String
                Get
                    Return _SiiresakiJuusho1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiJuusho1, value, "SiiresakiJuusho1")
                End Set
            End Property
            Private _SiiresakiJuusho1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiJuusho2 As String
                Get
                    Return _SiiresakiJuusho2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiJuusho2, value, "SiiresakiJuusho2")
                End Set
            End Property
            Private _SiiresakiJuusho2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiJuusho3 As String
                Get
                    Return _SiiresakiJuusho3
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiJuusho3, value, "SiiresakiJuusho3")
                End Set
            End Property
            Private _SiiresakiJuusho3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiJuusho4 As String
                Get
                    Return _SiiresakiJuusho4
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiJuusho4, value, "SiiresakiJuusho4")
                End Set
            End Property
            Private _SiiresakiJuusho4 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiJuusho5 As String
                Get
                    Return _SiiresakiJuusho5
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiJuusho5, value, "SiiresakiJuusho5")
                End Set
            End Property
            Private _SiiresakiJuusho5 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiTelNO1 As String
                Get
                    Return _SiiresakiTelNO1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiTelNO1, value, "SiiresakiTelNO1")
                End Set
            End Property
            Private _SiiresakiTelNO1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiTelNO2 As String
                Get
                    Return _SiiresakiTelNO2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiTelNO2, value, "SiiresakiTelNO2")
                End Set
            End Property
            Private _SiiresakiTelNO2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiTelNO3 As String
                Get
                    Return _SiiresakiTelNO3
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiTelNO3, value, "SiiresakiTelNO3")
                End Set
            End Property
            Private _SiiresakiTelNO3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiFaxNO1 As String
                Get
                    Return _SiiresakiFaxNO1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiFaxNO1, value, "SiiresakiFaxNO1")
                End Set
            End Property
            Private _SiiresakiFaxNO1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiFaxNO2 As String
                Get
                    Return _SiiresakiFaxNO2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiFaxNO2, value, "SiiresakiFaxNO2")
                End Set
            End Property
            Private _SiiresakiFaxNO2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiFaxNO3 As String
                Get
                    Return _SiiresakiFaxNO3
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiFaxNO3, value, "SiiresakiFaxNO3")
                End Set
            End Property
            Private _SiiresakiFaxNO3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiTel As String
                Get
                    Return _SiiresakiTel
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiTel, value, "SiiresakiTel")
                End Set
            End Property
            Private _SiiresakiTel As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiFax As String
                Get
                    Return _SiiresakiFax
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiFax, value, "SiiresakiFax")
                End Set
            End Property
            Private _SiiresakiFax As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiTantouBushoName As String
                Get
                    Return _SiiresakiTantouBushoName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiTantouBushoName, value, "SiiresakiTantouBushoName")
                End Set
            End Property
            Private _SiiresakiTantouBushoName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiTantoushaYakushoku As String
                Get
                    Return _SiiresakiTantoushaYakushoku
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiTantoushaYakushoku, value, "SiiresakiTantoushaYakushoku")
                End Set
            End Property
            Private _SiiresakiTantoushaYakushoku As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiiresakiTantoushaName As String
                Get
                    Return _SiiresakiTantoushaName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiiresakiTantoushaName, value, "SiiresakiTantoushaName")
                End Set
            End Property
            Private _SiiresakiTantoushaName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiSeisikiName As String
                Get
                    Return _SiharaisakiSeisikiName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiSeisikiName, value, "SiharaisakiSeisikiName")
                End Set
            End Property
            Private _SiharaisakiSeisikiName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiYuubinNO1 As String
                Get
                    Return _SiharaisakiYuubinNO1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiYuubinNO1, value, "SiharaisakiYuubinNO1")
                End Set
            End Property
            Private _SiharaisakiYuubinNO1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiYuubinNO2 As String
                Get
                    Return _SiharaisakiYuubinNO2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiYuubinNO2, value, "SiharaisakiYuubinNO2")
                End Set
            End Property
            Private _SiharaisakiYuubinNO2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiJuusho1 As String
                Get
                    Return _SiharaisakiJuusho1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiJuusho1, value, "SiharaisakiJuusho1")
                End Set
            End Property
            Private _SiharaisakiJuusho1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiJuusho2 As String
                Get
                    Return _SiharaisakiJuusho2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiJuusho2, value, "SiharaisakiJuusho2")
                End Set
            End Property
            Private _SiharaisakiJuusho2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiJuusho3 As String
                Get
                    Return _SiharaisakiJuusho3
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiJuusho3, value, "SiharaisakiJuusho3")
                End Set
            End Property
            Private _SiharaisakiJuusho3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiJuusho4 As String
                Get
                    Return _SiharaisakiJuusho4
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiJuusho4, value, "SiharaisakiJuusho4")
                End Set
            End Property
            Private _SiharaisakiJuusho4 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiJuusho5 As String
                Get
                    Return _SiharaisakiJuusho5
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiJuusho5, value, "SiharaisakiJuusho5")
                End Set
            End Property
            Private _SiharaisakiJuusho5 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiTelNO1 As String
                Get
                    Return _SiharaisakiTelNO1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiTelNO1, value, "SiharaisakiTelNO1")
                End Set
            End Property
            Private _SiharaisakiTelNO1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiTelNO2 As String
                Get
                    Return _SiharaisakiTelNO2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiTelNO2, value, "SiharaisakiTelNO2")
                End Set
            End Property
            Private _SiharaisakiTelNO2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiTelNO3 As String
                Get
                    Return _SiharaisakiTelNO3
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiTelNO3, value, "SiharaisakiTelNO3")
                End Set
            End Property
            Private _SiharaisakiTelNO3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiFaxNO1 As String
                Get
                    Return _SiharaisakiFaxNO1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiFaxNO1, value, "SiharaisakiFaxNO1")
                End Set
            End Property
            Private _SiharaisakiFaxNO1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiFaxNO2 As String
                Get
                    Return _SiharaisakiFaxNO2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiFaxNO2, value, "SiharaisakiFaxNO2")
                End Set
            End Property
            Private _SiharaisakiFaxNO2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiFaxNO3 As String
                Get
                    Return _SiharaisakiFaxNO3
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiFaxNO3, value, "SiharaisakiFaxNO3")
                End Set
            End Property
            Private _SiharaisakiFaxNO3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiTel As String
                Get
                    Return _SiharaisakiTel
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiTel, value, "SiharaisakiTel")
                End Set
            End Property
            Private _SiharaisakiTel As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiFax As String
                Get
                    Return _SiharaisakiFax
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiFax, value, "SiharaisakiFax")
                End Set
            End Property
            Private _SiharaisakiFax As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiTantouBushoName As String
                Get
                    Return _SiharaisakiTantouBushoName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiTantouBushoName, value, "SiharaisakiTantouBushoName")
                End Set
            End Property
            Private _SiharaisakiTantouBushoName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiTantoushaYakushoku As String
                Get
                    Return _SiharaisakiTantoushaYakushoku
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiTantoushaYakushoku, value, "SiharaisakiTantoushaYakushoku")
                End Set
            End Property
            Private _SiharaisakiTantoushaYakushoku As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaisakiTantoushaName As String
                Get
                    Return _SiharaisakiTantoushaName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaisakiTantoushaName, value, "SiharaisakiTantoushaName")
                End Set
            End Property
            Private _SiharaisakiTantoushaName As String

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
            Public Property UpdateJobID As String
                Get
                    Return _UpdateJobID
                End Get
                Set(ByVal value As String)
                    SetProperty(_UpdateJobID, value, "UpdateJobID")
                End Set
            End Property
            Private _UpdateJobID As String

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
            Public Property UpdateComputerName As String
                Get
                    Return _UpdateComputerName
                End Get
                Set(ByVal value As String)
                    SetProperty(_UpdateComputerName, value, "UpdateComputerName")
                End Set
            End Property
            Private _UpdateComputerName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UpdateComputerUserName As String
                Get
                    Return _UpdateComputerUserName
                End Get
                Set(ByVal value As String)
                    SetProperty(_UpdateComputerUserName, value, "UpdateComputerUserName")
                End Set
            End Property
            Private _UpdateComputerUserName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UpdateComputerDomainName As String
                Get
                    Return _UpdateComputerDomainName
                End Get
                Set(ByVal value As String)
                    SetProperty(_UpdateComputerDomainName, value, "UpdateComputerDomainName")
                End Set
            End Property
            Private _UpdateComputerDomainName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiName As String
                Get
                    Return _SoufusakiName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiName, value, "SoufusakiName")
                End Set
            End Property
            Private _SoufusakiName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiKana As String
                Get
                    Return _SoufusakiKana
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiKana, value, "SoufusakiKana")
                End Set
            End Property
            Private _SoufusakiKana As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiYuubinNO As String
                Get
                    Return _SoufusakiYuubinNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiYuubinNO, value, "SoufusakiYuubinNO")
                End Set
            End Property
            Private _SoufusakiYuubinNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiJuusho1 As String
                Get
                    Return _SoufusakiJuusho1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiJuusho1, value, "SoufusakiJuusho1")
                End Set
            End Property
            Private _SoufusakiJuusho1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiJuusho2 As String
                Get
                    Return _SoufusakiJuusho2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiJuusho2, value, "SoufusakiJuusho2")
                End Set
            End Property
            Private _SoufusakiJuusho2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiBushoName As String
                Get
                    Return _SoufusakiBushoName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiBushoName, value, "SoufusakiBushoName")
                End Set
            End Property
            Private _SoufusakiBushoName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiTantoushaName As String
                Get
                    Return _SoufusakiTantoushaName
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiTantoushaName, value, "SoufusakiTantoushaName")
                End Set
            End Property
            Private _SoufusakiTantoushaName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiTel As String
                Get
                    Return _SoufusakiTel
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiTel, value, "SoufusakiTel")
                End Set
            End Property
            Private _SoufusakiTel As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiFax As String
                Get
                    Return _SoufusakiFax
                End Get
                Set(ByVal value As String)
                    SetProperty(_SoufusakiFax, value, "SoufusakiFax")
                End Set
            End Property
            Private _SoufusakiFax As String

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
            Public Property OguchiFLG As Integer
                Get
                    Return _OguchiFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OguchiFLG, value, "OguchiFLG")
                End Set
            End Property
            Private _OguchiFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShoninFLG As Integer
                Get
                    Return _ShoninFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ShoninFLG, value, "ShoninFLG")
                End Set
            End Property
            Private _ShoninFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuDatetime As Datetime
                Get
                    Return _HacchuDatetime
                End Get
                Set(ByVal value As Datetime)
                    SetProperty(_HacchuDatetime, value, "HacchuDatetime")
                End Set
            End Property
            Private _HacchuDatetime As Datetime

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
            Public Property JuchuuDatetime As Datetime
                Get
                    Return _JuchuuDatetime
                End Get
                Set(ByVal value As Datetime)
                    SetProperty(_JuchuuDatetime, value, "JuchuuDatetime")
                End Set
            End Property
            Private _JuchuuDatetime As Datetime

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShukkaDate As Date
                Get
                    Return _ShukkaDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_ShukkaDate, value, "ShukkaDate")
                End Set
            End Property
            Private _ShukkaDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShukkaAnnaishoDatetime As Datetime
                Get
                    Return _ShukkaAnnaishoDatetime
                End Get
                Set(ByVal value As Datetime)
                    SetProperty(_ShukkaAnnaishoDatetime, value, "ShukkaAnnaishoDatetime")
                End Set
            End Property
            Private _ShukkaAnnaishoDatetime As Datetime

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
            Public Property TrackingNo As String
                Get
                    Return _TrackingNo
                End Get
                Set(ByVal value As String)
                    SetProperty(_TrackingNo, value, "TrackingNo")
                End Set
            End Property
            Private _TrackingNo As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NounyusakiName As String
                Get
                    Return _NounyusakiName
                End Get
                Set(ByVal value As String)
                    SetProperty(_NounyusakiName, value, "NounyusakiName")
                End Set
            End Property
            Private _NounyusakiName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property BinName As String
                Get
                    Return _BinName
                End Get
                Set(ByVal value As String)
                    SetProperty(_BinName, value, "BinName")
                End Set
            End Property
            Private _BinName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property BinNameBikou As String
                Get
                    Return _BinNameBikou
                End Get
                Set(ByVal value As String)
                    SetProperty(_BinNameBikou, value, "BinNameBikou")
                End Set
            End Property
            Private _BinNameBikou As String

   End Class

End Namespace
