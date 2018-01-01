Namespace app.dto.base
    Public Class clsMshouhinBaseDto
        Inherits clsBaseDto

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
            Public Property ShouhinName As String
                Get
                    Return _ShouhinName
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShouhinName, value, "ShouhinName")
                End Set
            End Property
            Private _ShouhinName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouhinKanaName As String
                Get
                    Return _ShouhinKanaName
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShouhinKanaName, value, "ShouhinKanaName")
                End Set
            End Property
            Private _ShouhinKanaName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Kikaku As String
                Get
                    Return _Kikaku
                End Get
                Set(ByVal value As String)
                    SetProperty(_Kikaku, value, "Kikaku")
                End Set
            End Property
            Private _Kikaku As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShokutiFLG As Integer
                Get
                    Return _ShokutiFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ShokutiFLG, value, "ShokutiFLG")
                End Set
            End Property
            Private _ShokutiFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ZaikoKanriHuyouFLG As Integer
                Get
                    Return _ZaikoKanriHuyouFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ZaikoKanriHuyouFLG, value, "ZaikoKanriHuyouFLG")
                End Set
            End Property
            Private _ZaikoKanriHuyouFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ToriatukaiKaisiDate As Date
                Get
                    Return _ToriatukaiKaisiDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_ToriatukaiKaisiDate, value, "ToriatukaiKaisiDate")
                End Set
            End Property
            Private _ToriatukaiKaisiDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ToriatukaiShuuryouDate As Date
                Get
                    Return _ToriatukaiShuuryouDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_ToriatukaiShuuryouDate, value, "ToriatukaiShuuryouDate")
                End Set
            End Property
            Private _ToriatukaiShuuryouDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SeizouChuusiDate As Date
                Get
                    Return _SeizouChuusiDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_SeizouChuusiDate, value, "SeizouChuusiDate")
                End Set
            End Property
            Private _SeizouChuusiDate As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property TaniCD As String
                Get
                    Return _TaniCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_TaniCD, value, "TaniCD")
                End Set
            End Property
            Private _TaniCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JANCD As String
                Get
                    Return _JANCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_JANCD, value, "JANCD")
                End Set
            End Property
            Private _JANCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ITFCD As String
                Get
                    Return _ITFCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_ITFCD, value, "ITFCD")
                End Set
            End Property
            Private _ITFCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HinshuCD As String
                Get
                    Return _HinshuCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_HinshuCD, value, "HinshuCD")
                End Set
            End Property
            Private _HinshuCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShuyouSiiresakiCD As String
                Get
                    Return _ShuyouSiiresakiCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShuyouSiiresakiCD, value, "ShuyouSiiresakiCD")
                End Set
            End Property
            Private _ShuyouSiiresakiCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Size1 As String
                Get
                    Return _Size1
                End Get
                Set(ByVal value As String)
                    SetProperty(_Size1, value, "Size1")
                End Set
            End Property
            Private _Size1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Size2 As String
                Get
                    Return _Size2
                End Get
                Set(ByVal value As String)
                    SetProperty(_Size2, value, "Size2")
                End Set
            End Property
            Private _Size2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property Size3 As String
                Get
                    Return _Size3
                End Get
                Set(ByVal value As String)
                    SetProperty(_Size3, value, "Size3")
                End Set
            End Property
            Private _Size3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouhinJuuryou As Decimal
                Get
                    Return _ShouhinJuuryou
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_ShouhinJuuryou, value, "ShouhinJuuryou")
                End Set
            End Property
            Private _ShouhinJuuryou As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShuukeiCD1 As String
                Get
                    Return _ShuukeiCD1
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShuukeiCD1, value, "ShuukeiCD1")
                End Set
            End Property
            Private _ShuukeiCD1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShuukeiCD2 As String
                Get
                    Return _ShuukeiCD2
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShuukeiCD2, value, "ShuukeiCD2")
                End Set
            End Property
            Private _ShuukeiCD2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShuukeiCD3 As String
                Get
                    Return _ShuukeiCD3
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShuukeiCD3, value, "ShuukeiCD3")
                End Set
            End Property
            Private _ShuukeiCD3 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NisugataKanriHuyouFLG As Integer
                Get
                    Return _NisugataKanriHuyouFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_NisugataKanriHuyouFLG, value, "NisugataKanriHuyouFLG")
                End Set
            End Property
            Private _NisugataKanriHuyouFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property LotKanriFLG As Integer
                Get
                    Return _LotKanriFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_LotKanriFLG, value, "LotKanriFLG")
                End Set
            End Property
            Private _LotKanriFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property YuukouKigenKanriFLG As Integer
                Get
                    Return _YuukouKigenKanriFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_YuukouKigenKanriFLG, value, "YuukouKigenKanriFLG")
                End Set
            End Property
            Private _YuukouKigenKanriFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property YuukouKigenConvertKBN As Integer
                Get
                    Return _YuukouKigenConvertKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_YuukouKigenConvertKBN, value, "YuukouKigenConvertKBN")
                End Set
            End Property
            Private _YuukouKigenConvertKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SetHinFLG As Integer
                Get
                    Return _SetHinFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SetHinFLG, value, "SetHinFLG")
                End Set
            End Property
            Private _SetHinFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HanbaiKanouShouhinRank As Integer
                Get
                    Return _HanbaiKanouShouhinRank
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HanbaiKanouShouhinRank, value, "HanbaiKanouShouhinRank")
                End Set
            End Property
            Private _HanbaiKanouShouhinRank As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property TanaorosiHyoukaKijun As Integer
                Get
                    Return _TanaorosiHyoukaKijun
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_TanaorosiHyoukaKijun, value, "TanaorosiHyoukaKijun")
                End Set
            End Property
            Private _TanaorosiHyoukaKijun As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouhizeiNaigaiKBN As Integer
                Get
                    Return _ShouhizeiNaigaiKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ShouhizeiNaigaiKBN, value, "ShouhizeiNaigaiKBN")
                End Set
            End Property
            Private _ShouhizeiNaigaiKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouhizeirituKBN As Integer
                Get
                    Return _ShouhizeirituKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ShouhizeirituKBN, value, "ShouhizeirituKBN")
                End Set
            End Property
            Private _ShouhizeirituKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KobetuZaikoHyoukaTankaKeisanKBN As Integer
                Get
                    Return _KobetuZaikoHyoukaTankaKeisanKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_KobetuZaikoHyoukaTankaKeisanKBN, value, "KobetuZaikoHyoukaTankaKeisanKBN")
                End Set
            End Property
            Private _KobetuZaikoHyoukaTankaKeisanKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property LotKobetuZaikoHyoukaFLG As Integer
                Get
                    Return _LotKobetuZaikoHyoukaFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_LotKobetuZaikoHyoukaFLG, value, "LotKobetuZaikoHyoukaFLG")
                End Set
            End Property
            Private _LotKobetuZaikoHyoukaFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HanbaiGenkaKeisanKBN As Integer
                Get
                    Return _HanbaiGenkaKeisanKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HanbaiGenkaKeisanKBN, value, "HanbaiGenkaKeisanKBN")
                End Set
            End Property
            Private _HanbaiGenkaKeisanKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HyoujunGenkaTanka As Decimal
                Get
                    Return _HyoujunGenkaTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_HyoujunGenkaTanka, value, "HyoujunGenkaTanka")
                End Set
            End Property
            Private _HyoujunGenkaTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property YuukouKigenCheckTukiSuu As Integer
                Get
                    Return _YuukouKigenCheckTukiSuu
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_YuukouKigenCheckTukiSuu, value, "YuukouKigenCheckTukiSuu")
                End Set
            End Property
            Private _YuukouKigenCheckTukiSuu As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property CannotDeleteFLG As Integer
                Get
                    Return _CannotDeleteFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_CannotDeleteFLG, value, "CannotDeleteFLG")
                End Set
            End Property
            Private _CannotDeleteFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property EiziShouhinName1 As String
                Get
                    Return _EiziShouhinName1
                End Get
                Set(ByVal value As String)
                    SetProperty(_EiziShouhinName1, value, "EiziShouhinName1")
                End Set
            End Property
            Private _EiziShouhinName1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property EiziShouhinName2 As String
                Get
                    Return _EiziShouhinName2
                End Get
                Set(ByVal value As String)
                    SetProperty(_EiziShouhinName2, value, "EiziShouhinName2")
                End Set
            End Property
            Private _EiziShouhinName2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KijunRyou1 As Decimal
                Get
                    Return _KijunRyou1
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_KijunRyou1, value, "KijunRyou1")
                End Set
            End Property
            Private _KijunRyou1 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property KijunRyou2 As Decimal
                Get
                    Return _KijunRyou2
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_KijunRyou2, value, "KijunRyou2")
                End Set
            End Property
            Private _KijunRyou2 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SeikyuushuruiKBN As Integer
                Get
                    Return _SeikyuushuruiKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SeikyuushuruiKBN, value, "SeikyuushuruiKBN")
                End Set
            End Property
            Private _SeikyuushuruiKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property UriageKBN As String
                Get
                    Return _UriageKBN
                End Get
                Set(ByVal value As String)
                    SetProperty(_UriageKBN, value, "UriageKBN")
                End Set
            End Property
            Private _UriageKBN As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ZitaKBN As Integer
                Get
                    Return _ZitaKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ZitaKBN, value, "ZitaKBN")
                End Set
            End Property
            Private _ZitaKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HanyouhinhenkanKBN As Integer
                Get
                    Return _HanyouhinhenkanKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HanyouhinhenkanKBN, value, "HanyouhinhenkanKBN")
                End Set
            End Property
            Private _HanyouhinhenkanKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HanyouhinShouhinCD As String
                Get
                    Return _HanyouhinShouhinCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_HanyouhinShouhinCD, value, "HanyouhinShouhinCD")
                End Set
            End Property
            Private _HanyouhinShouhinCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi01 As String
                Get
                    Return _OskYobi01
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi01, value, "OskYobi01")
                End Set
            End Property
            Private _OskYobi01 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi02 As String
                Get
                    Return _OskYobi02
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi02, value, "OskYobi02")
                End Set
            End Property
            Private _OskYobi02 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi03 As String
                Get
                    Return _OskYobi03
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi03, value, "OskYobi03")
                End Set
            End Property
            Private _OskYobi03 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi04 As String
                Get
                    Return _OskYobi04
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi04, value, "OskYobi04")
                End Set
            End Property
            Private _OskYobi04 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi05 As String
                Get
                    Return _OskYobi05
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi05, value, "OskYobi05")
                End Set
            End Property
            Private _OskYobi05 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi06 As String
                Get
                    Return _OskYobi06
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi06, value, "OskYobi06")
                End Set
            End Property
            Private _OskYobi06 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi07 As String
                Get
                    Return _OskYobi07
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi07, value, "OskYobi07")
                End Set
            End Property
            Private _OskYobi07 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi08 As String
                Get
                    Return _OskYobi08
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi08, value, "OskYobi08")
                End Set
            End Property
            Private _OskYobi08 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi09 As String
                Get
                    Return _OskYobi09
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi09, value, "OskYobi09")
                End Set
            End Property
            Private _OskYobi09 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi10 As String
                Get
                    Return _OskYobi10
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi10, value, "OskYobi10")
                End Set
            End Property
            Private _OskYobi10 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi11 As String
                Get
                    Return _OskYobi11
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi11, value, "OskYobi11")
                End Set
            End Property
            Private _OskYobi11 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi12 As String
                Get
                    Return _OskYobi12
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi12, value, "OskYobi12")
                End Set
            End Property
            Private _OskYobi12 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi13 As String
                Get
                    Return _OskYobi13
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi13, value, "OskYobi13")
                End Set
            End Property
            Private _OskYobi13 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi14 As String
                Get
                    Return _OskYobi14
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi14, value, "OskYobi14")
                End Set
            End Property
            Private _OskYobi14 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi15 As String
                Get
                    Return _OskYobi15
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi15, value, "OskYobi15")
                End Set
            End Property
            Private _OskYobi15 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi16 As String
                Get
                    Return _OskYobi16
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi16, value, "OskYobi16")
                End Set
            End Property
            Private _OskYobi16 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi17 As String
                Get
                    Return _OskYobi17
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi17, value, "OskYobi17")
                End Set
            End Property
            Private _OskYobi17 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi18 As String
                Get
                    Return _OskYobi18
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi18, value, "OskYobi18")
                End Set
            End Property
            Private _OskYobi18 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi19 As String
                Get
                    Return _OskYobi19
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi19, value, "OskYobi19")
                End Set
            End Property
            Private _OskYobi19 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi20 As String
                Get
                    Return _OskYobi20
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi20, value, "OskYobi20")
                End Set
            End Property
            Private _OskYobi20 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi21 As String
                Get
                    Return _OskYobi21
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi21, value, "OskYobi21")
                End Set
            End Property
            Private _OskYobi21 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi22 As String
                Get
                    Return _OskYobi22
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi22, value, "OskYobi22")
                End Set
            End Property
            Private _OskYobi22 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi23 As String
                Get
                    Return _OskYobi23
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi23, value, "OskYobi23")
                End Set
            End Property
            Private _OskYobi23 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi24 As String
                Get
                    Return _OskYobi24
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi24, value, "OskYobi24")
                End Set
            End Property
            Private _OskYobi24 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi25 As String
                Get
                    Return _OskYobi25
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi25, value, "OskYobi25")
                End Set
            End Property
            Private _OskYobi25 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi26 As String
                Get
                    Return _OskYobi26
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi26, value, "OskYobi26")
                End Set
            End Property
            Private _OskYobi26 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi27 As String
                Get
                    Return _OskYobi27
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi27, value, "OskYobi27")
                End Set
            End Property
            Private _OskYobi27 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi28 As String
                Get
                    Return _OskYobi28
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi28, value, "OskYobi28")
                End Set
            End Property
            Private _OskYobi28 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi29 As String
                Get
                    Return _OskYobi29
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi29, value, "OskYobi29")
                End Set
            End Property
            Private _OskYobi29 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi30 As String
                Get
                    Return _OskYobi30
                End Get
                Set(ByVal value As String)
                    SetProperty(_OskYobi30, value, "OskYobi30")
                End Set
            End Property
            Private _OskYobi30 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi31 As Integer
                Get
                    Return _OskYobi31
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi31, value, "OskYobi31")
                End Set
            End Property
            Private _OskYobi31 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi32 As Integer
                Get
                    Return _OskYobi32
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi32, value, "OskYobi32")
                End Set
            End Property
            Private _OskYobi32 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi33 As Integer
                Get
                    Return _OskYobi33
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi33, value, "OskYobi33")
                End Set
            End Property
            Private _OskYobi33 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi34 As Integer
                Get
                    Return _OskYobi34
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi34, value, "OskYobi34")
                End Set
            End Property
            Private _OskYobi34 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi35 As Integer
                Get
                    Return _OskYobi35
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi35, value, "OskYobi35")
                End Set
            End Property
            Private _OskYobi35 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi36 As Integer
                Get
                    Return _OskYobi36
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi36, value, "OskYobi36")
                End Set
            End Property
            Private _OskYobi36 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi37 As Integer
                Get
                    Return _OskYobi37
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi37, value, "OskYobi37")
                End Set
            End Property
            Private _OskYobi37 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi38 As Integer
                Get
                    Return _OskYobi38
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi38, value, "OskYobi38")
                End Set
            End Property
            Private _OskYobi38 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi39 As Integer
                Get
                    Return _OskYobi39
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi39, value, "OskYobi39")
                End Set
            End Property
            Private _OskYobi39 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi40 As Integer
                Get
                    Return _OskYobi40
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi40, value, "OskYobi40")
                End Set
            End Property
            Private _OskYobi40 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi41 As Integer
                Get
                    Return _OskYobi41
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi41, value, "OskYobi41")
                End Set
            End Property
            Private _OskYobi41 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi42 As Integer
                Get
                    Return _OskYobi42
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi42, value, "OskYobi42")
                End Set
            End Property
            Private _OskYobi42 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi43 As Integer
                Get
                    Return _OskYobi43
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi43, value, "OskYobi43")
                End Set
            End Property
            Private _OskYobi43 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi44 As Integer
                Get
                    Return _OskYobi44
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi44, value, "OskYobi44")
                End Set
            End Property
            Private _OskYobi44 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi45 As Integer
                Get
                    Return _OskYobi45
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi45, value, "OskYobi45")
                End Set
            End Property
            Private _OskYobi45 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi46 As Integer
                Get
                    Return _OskYobi46
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi46, value, "OskYobi46")
                End Set
            End Property
            Private _OskYobi46 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi47 As Integer
                Get
                    Return _OskYobi47
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi47, value, "OskYobi47")
                End Set
            End Property
            Private _OskYobi47 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi48 As Integer
                Get
                    Return _OskYobi48
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi48, value, "OskYobi48")
                End Set
            End Property
            Private _OskYobi48 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi49 As Integer
                Get
                    Return _OskYobi49
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi49, value, "OskYobi49")
                End Set
            End Property
            Private _OskYobi49 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi50 As Integer
                Get
                    Return _OskYobi50
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_OskYobi50, value, "OskYobi50")
                End Set
            End Property
            Private _OskYobi50 As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi51 As Decimal
                Get
                    Return _OskYobi51
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi51, value, "OskYobi51")
                End Set
            End Property
            Private _OskYobi51 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi52 As Decimal
                Get
                    Return _OskYobi52
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi52, value, "OskYobi52")
                End Set
            End Property
            Private _OskYobi52 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi53 As Decimal
                Get
                    Return _OskYobi53
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi53, value, "OskYobi53")
                End Set
            End Property
            Private _OskYobi53 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi54 As Decimal
                Get
                    Return _OskYobi54
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi54, value, "OskYobi54")
                End Set
            End Property
            Private _OskYobi54 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi55 As Decimal
                Get
                    Return _OskYobi55
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi55, value, "OskYobi55")
                End Set
            End Property
            Private _OskYobi55 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi56 As Decimal
                Get
                    Return _OskYobi56
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi56, value, "OskYobi56")
                End Set
            End Property
            Private _OskYobi56 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi57 As Decimal
                Get
                    Return _OskYobi57
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi57, value, "OskYobi57")
                End Set
            End Property
            Private _OskYobi57 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi58 As Decimal
                Get
                    Return _OskYobi58
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi58, value, "OskYobi58")
                End Set
            End Property
            Private _OskYobi58 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi59 As Decimal
                Get
                    Return _OskYobi59
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi59, value, "OskYobi59")
                End Set
            End Property
            Private _OskYobi59 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi60 As Decimal
                Get
                    Return _OskYobi60
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi60, value, "OskYobi60")
                End Set
            End Property
            Private _OskYobi60 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi61 As Decimal
                Get
                    Return _OskYobi61
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi61, value, "OskYobi61")
                End Set
            End Property
            Private _OskYobi61 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi62 As Decimal
                Get
                    Return _OskYobi62
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi62, value, "OskYobi62")
                End Set
            End Property
            Private _OskYobi62 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi63 As Decimal
                Get
                    Return _OskYobi63
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi63, value, "OskYobi63")
                End Set
            End Property
            Private _OskYobi63 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi64 As Decimal
                Get
                    Return _OskYobi64
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi64, value, "OskYobi64")
                End Set
            End Property
            Private _OskYobi64 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi65 As Decimal
                Get
                    Return _OskYobi65
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi65, value, "OskYobi65")
                End Set
            End Property
            Private _OskYobi65 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi66 As Decimal
                Get
                    Return _OskYobi66
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi66, value, "OskYobi66")
                End Set
            End Property
            Private _OskYobi66 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi67 As Decimal
                Get
                    Return _OskYobi67
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi67, value, "OskYobi67")
                End Set
            End Property
            Private _OskYobi67 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi68 As Decimal
                Get
                    Return _OskYobi68
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi68, value, "OskYobi68")
                End Set
            End Property
            Private _OskYobi68 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi69 As Decimal
                Get
                    Return _OskYobi69
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi69, value, "OskYobi69")
                End Set
            End Property
            Private _OskYobi69 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi70 As Decimal
                Get
                    Return _OskYobi70
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_OskYobi70, value, "OskYobi70")
                End Set
            End Property
            Private _OskYobi70 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi71 As Date
                Get
                    Return _OskYobi71
                End Get
                Set(ByVal value As Date)
                    SetProperty(_OskYobi71, value, "OskYobi71")
                End Set
            End Property
            Private _OskYobi71 As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi72 As Date
                Get
                    Return _OskYobi72
                End Get
                Set(ByVal value As Date)
                    SetProperty(_OskYobi72, value, "OskYobi72")
                End Set
            End Property
            Private _OskYobi72 As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi73 As Date
                Get
                    Return _OskYobi73
                End Get
                Set(ByVal value As Date)
                    SetProperty(_OskYobi73, value, "OskYobi73")
                End Set
            End Property
            Private _OskYobi73 As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi74 As Date
                Get
                    Return _OskYobi74
                End Get
                Set(ByVal value As Date)
                    SetProperty(_OskYobi74, value, "OskYobi74")
                End Set
            End Property
            Private _OskYobi74 As Date

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property OskYobi75 As Date
                Get
                    Return _OskYobi75
                End Get
                Set(ByVal value As Date)
                    SetProperty(_OskYobi75, value, "OskYobi75")
                End Set
            End Property
            Private _OskYobi75 As Date

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

   End Class

End Namespace
