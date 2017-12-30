Namespace app.dto
    Public Class clsDjuchuumeisaiBaseDto
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
            Public Property JuchuuGyouNO As Integer
                Get
                    Return _JuchuuGyouNO
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_JuchuuGyouNO, value, "JuchuuGyouNO")
                End Set
            End Property
            Private _JuchuuGyouNO As Integer

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
            Public Property SaimuKamokuKBN As Integer
                Get
                    Return _SaimuKamokuKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SaimuKamokuKBN, value, "SaimuKamokuKBN")
                End Set
            End Property
            Private _SaimuKamokuKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GyouHyouziJun As Integer
                Get
                    Return _GyouHyouziJun
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_GyouHyouziJun, value, "GyouHyouziJun")
                End Set
            End Property
            Private _GyouHyouziJun As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HinshuCategoryCD As String
                Get
                    Return _HinshuCategoryCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_HinshuCategoryCD, value, "HinshuCategoryCD")
                End Set
            End Property
            Private _HinshuCategoryCD As String

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
            Public Property Kakeritu As Decimal
                Get
                    Return _Kakeritu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_Kakeritu, value, "Kakeritu")
                End Set
            End Property
            Private _Kakeritu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property AitesakiHinNO As String
                Get
                    Return _AitesakiHinNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_AitesakiHinNO, value, "AitesakiHinNO")
                End Set
            End Property
            Private _AitesakiHinNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property AitesakiHinName As String
                Get
                    Return _AitesakiHinName
                End Get
                Set(ByVal value As String)
                    SetProperty(_AitesakiHinName, value, "AitesakiHinName")
                End Set
            End Property
            Private _AitesakiHinName As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NisugataTaniCD As String
                Get
                    Return _NisugataTaniCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_NisugataTaniCD, value, "NisugataTaniCD")
                End Set
            End Property
            Private _NisugataTaniCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property IriSuu As Decimal
                Get
                    Return _IriSuu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_IriSuu, value, "IriSuu")
                End Set
            End Property
            Private _IriSuu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NiSuu As Decimal
                Get
                    Return _NiSuu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_NiSuu, value, "NiSuu")
                End Set
            End Property
            Private _NiSuu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NisugataTaniCD2 As String
                Get
                    Return _NisugataTaniCD2
                End Get
                Set(ByVal value As String)
                    SetProperty(_NisugataTaniCD2, value, "NisugataTaniCD2")
                End Set
            End Property
            Private _NisugataTaniCD2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property IriSuu2 As Decimal
                Get
                    Return _IriSuu2
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_IriSuu2, value, "IriSuu2")
                End Set
            End Property
            Private _IriSuu2 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NiSuu2 As Decimal
                Get
                    Return _NiSuu2
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_NiSuu2, value, "NiSuu2")
                End Set
            End Property
            Private _NiSuu2 As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property BaraSuu As Decimal
                Get
                    Return _BaraSuu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_BaraSuu, value, "BaraSuu")
                End Set
            End Property
            Private _BaraSuu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuSuu As Decimal
                Get
                    Return _HacchuuSuu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_HacchuuSuu, value, "HacchuuSuu")
                End Set
            End Property
            Private _HacchuuSuu As Decimal

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
            Public Property KariTankaKBN As Integer
                Get
                    Return _KariTankaKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_KariTankaKBN, value, "KariTankaKBN")
                End Set
            End Property
            Private _KariTankaKBN As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireTanka As Decimal
                Get
                    Return _SiireTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireTanka, value, "SiireTanka")
                End Set
            End Property
            Private _SiireTanka As Decimal

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
            Public Property SiireKingaku As Decimal
                Get
                    Return _SiireKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireKingaku, value, "SiireKingaku")
                End Set
            End Property
            Private _SiireKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireHontaiKingaku As Decimal
                Get
                    Return _SiireHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireHontaiKingaku, value, "SiireHontaiKingaku")
                End Set
            End Property
            Private _SiireHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireShouhizeiGaku As Decimal
                Get
                    Return _SiireShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireShouhizeiGaku, value, "SiireShouhizeiGaku")
                End Set
            End Property
            Private _SiireShouhizeiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireShouhizeiChouseiGaku As Decimal
                Get
                    Return _SiireShouhizeiChouseiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireShouhizeiChouseiGaku, value, "SiireShouhizeiChouseiGaku")
                End Set
            End Property
            Private _SiireShouhizeiChouseiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JoudaiTanka As Decimal
                Get
                    Return _JoudaiTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_JoudaiTanka, value, "JoudaiTanka")
                End Set
            End Property
            Private _JoudaiTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JoudaiTankaShouhizei As Decimal
                Get
                    Return _JoudaiTankaShouhizei
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_JoudaiTankaShouhizei, value, "JoudaiTankaShouhizei")
                End Set
            End Property
            Private _JoudaiTankaShouhizei As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JoudaiHontaiTanka As Decimal
                Get
                    Return _JoudaiHontaiTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_JoudaiHontaiTanka, value, "JoudaiHontaiTanka")
                End Set
            End Property
            Private _JoudaiHontaiTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JoudaiKingaku As Decimal
                Get
                    Return _JoudaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_JoudaiKingaku, value, "JoudaiKingaku")
                End Set
            End Property
            Private _JoudaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JoudaiHontaiKingaku As Decimal
                Get
                    Return _JoudaiHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_JoudaiHontaiKingaku, value, "JoudaiHontaiKingaku")
                End Set
            End Property
            Private _JoudaiHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property JoudaiShouhizeiGaku As Decimal
                Get
                    Return _JoudaiShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_JoudaiShouhizeiGaku, value, "JoudaiShouhizeiGaku")
                End Set
            End Property
            Private _JoudaiShouhizeiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaSiireTanka As Decimal
                Get
                    Return _GaikaSiireTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaSiireTanka, value, "GaikaSiireTanka")
                End Set
            End Property
            Private _GaikaSiireTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaSiireTankaShouhizei As Decimal
                Get
                    Return _GaikaSiireTankaShouhizei
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaSiireTankaShouhizei, value, "GaikaSiireTankaShouhizei")
                End Set
            End Property
            Private _GaikaSiireTankaShouhizei As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaSiireHontaiTanka As Decimal
                Get
                    Return _GaikaSiireHontaiTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaSiireHontaiTanka, value, "GaikaSiireHontaiTanka")
                End Set
            End Property
            Private _GaikaSiireHontaiTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaSiireKingaku As Decimal
                Get
                    Return _GaikaSiireKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaSiireKingaku, value, "GaikaSiireKingaku")
                End Set
            End Property
            Private _GaikaSiireKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaSiireHontaiKingaku As Decimal
                Get
                    Return _GaikaSiireHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaSiireHontaiKingaku, value, "GaikaSiireHontaiKingaku")
                End Set
            End Property
            Private _GaikaSiireHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaSiireShouhizeiGaku As Decimal
                Get
                    Return _GaikaSiireShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaSiireShouhizeiGaku, value, "GaikaSiireShouhizeiGaku")
                End Set
            End Property
            Private _GaikaSiireShouhizeiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaSiireShouhizeiChouseiGaku As Decimal
                Get
                    Return _GaikaSiireShouhizeiChouseiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaSiireShouhizeiChouseiGaku, value, "GaikaSiireShouhizeiChouseiGaku")
                End Set
            End Property
            Private _GaikaSiireShouhizeiChouseiGaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaJoudaiTanka As Decimal
                Get
                    Return _GaikaJoudaiTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaJoudaiTanka, value, "GaikaJoudaiTanka")
                End Set
            End Property
            Private _GaikaJoudaiTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaJoudaiTankaShouhizei As Decimal
                Get
                    Return _GaikaJoudaiTankaShouhizei
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaJoudaiTankaShouhizei, value, "GaikaJoudaiTankaShouhizei")
                End Set
            End Property
            Private _GaikaJoudaiTankaShouhizei As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaJoudaiHontaiTanka As Decimal
                Get
                    Return _GaikaJoudaiHontaiTanka
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaJoudaiHontaiTanka, value, "GaikaJoudaiHontaiTanka")
                End Set
            End Property
            Private _GaikaJoudaiHontaiTanka As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaJoudaiKingaku As Decimal
                Get
                    Return _GaikaJoudaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaJoudaiKingaku, value, "GaikaJoudaiKingaku")
                End Set
            End Property
            Private _GaikaJoudaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaJoudaiHontaiKingaku As Decimal
                Get
                    Return _GaikaJoudaiHontaiKingaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaJoudaiHontaiKingaku, value, "GaikaJoudaiHontaiKingaku")
                End Set
            End Property
            Private _GaikaJoudaiHontaiKingaku As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property GaikaJoudaiShouhizeiGaku As Decimal
                Get
                    Return _GaikaJoudaiShouhizeiGaku
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_GaikaJoudaiShouhizeiGaku, value, "GaikaJoudaiShouhizeiGaku")
                End Set
            End Property
            Private _GaikaJoudaiShouhizeiGaku As Decimal

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
            Public Property HacchuuMeisaiTekiyou As String
                Get
                    Return _HacchuuMeisaiTekiyou
                End Get
                Set(ByVal value As String)
                    SetProperty(_HacchuuMeisaiTekiyou, value, "HacchuuMeisaiTekiyou")
                End Set
            End Property
            Private _HacchuuMeisaiTekiyou As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property ShouninJoutaiKBN As String
                Get
                    Return _ShouninJoutaiKBN
                End Get
                Set(ByVal value As String)
                    SetProperty(_ShouninJoutaiKBN, value, "ShouninJoutaiKBN")
                End Set
            End Property
            Private _ShouninJoutaiKBN As String

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
            Public Property ZaikoKBN As Integer
                Get
                    Return _ZaikoKBN
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_ZaikoKBN, value, "ZaikoKBN")
                End Set
            End Property
            Private _ZaikoKBN As Integer

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
            Public Property ZaikoBashoCD As String
                Get
                    Return _ZaikoBashoCD
                End Get
                Set(ByVal value As String)
                    SetProperty(_ZaikoBashoCD, value, "ZaikoBashoCD")
                End Set
            End Property
            Private _ZaikoBashoCD As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NyuukaYoteiHoryuuFLG As Integer
                Get
                    Return _NyuukaYoteiHoryuuFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_NyuukaYoteiHoryuuFLG, value, "NyuukaYoteiHoryuuFLG")
                End Set
            End Property
            Private _NyuukaYoteiHoryuuFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NyuukaHoryuuFLG As Integer
                Get
                    Return _NyuukaHoryuuFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_NyuukaHoryuuFLG, value, "NyuukaHoryuuFLG")
                End Set
            End Property
            Private _NyuukaHoryuuFLG As Integer

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
            Public Property NyuukaYoteiSuu As Decimal
                Get
                    Return _NyuukaYoteiSuu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_NyuukaYoteiSuu, value, "NyuukaYoteiSuu")
                End Set
            End Property
            Private _NyuukaYoteiSuu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property NyuukaSuu As Decimal
                Get
                    Return _NyuukaSuu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_NyuukaSuu, value, "NyuukaSuu")
                End Set
            End Property
            Private _NyuukaSuu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiireSuu As Decimal
                Get
                    Return _SiireSuu
                End Get
                Set(ByVal value As Decimal)
                    SetProperty(_SiireSuu, value, "SiireSuu")
                End Set
            End Property
            Private _SiireSuu As Decimal

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SegmentCD1 As String
                Get
                    Return _SegmentCD1
                End Get
                Set(ByVal value As String)
                    SetProperty(_SegmentCD1, value, "SegmentCD1")
                End Set
            End Property
            Private _SegmentCD1 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SegmentCD2 As String
                Get
                    Return _SegmentCD2
                End Get
                Set(ByVal value As String)
                    SetProperty(_SegmentCD2, value, "SegmentCD2")
                End Set
            End Property
            Private _SegmentCD2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SegmentCD3 As String
                Get
                    Return _SegmentCD3
                End Get
                Set(ByVal value As String)
                    SetProperty(_SegmentCD3, value, "SegmentCD3")
                End Set
            End Property
            Private _SegmentCD3 As String

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
            Public Property TorikesiFLG As Integer
                Get
                    Return _TorikesiFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_TorikesiFLG, value, "TorikesiFLG")
                End Set
            End Property
            Private _TorikesiFLG As Integer

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
            Public Property SubSystemDenpyouGyouNO As Integer
                Get
                    Return _SubSystemDenpyouGyouNO
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_SubSystemDenpyouGyouNO, value, "SubSystemDenpyouGyouNO")
                End Set
            End Property
            Private _SubSystemDenpyouGyouNO As Integer

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
            Public Property MitumoriGenkaGyouNO As Integer
                Get
                    Return _MitumoriGenkaGyouNO
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_MitumoriGenkaGyouNO, value, "MitumoriGenkaGyouNO")
                End Set
            End Property
            Private _MitumoriGenkaGyouNO As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SiharaiIraiNO As String
                Get
                    Return _SiharaiIraiNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_SiharaiIraiNO, value, "SiharaiIraiNO")
                End Set
            End Property
            Private _SiharaiIraiNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuIraiNO As String
                Get
                    Return _HacchuuIraiNO
                End Get
                Set(ByVal value As String)
                    SetProperty(_HacchuuIraiNO, value, "HacchuuIraiNO")
                End Set
            End Property
            Private _HacchuuIraiNO As String

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property HacchuuIraiGyouNO As Integer
                Get
                    Return _HacchuuIraiGyouNO
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_HacchuuIraiGyouNO, value, "HacchuuIraiGyouNO")
                End Set
            End Property
            Private _HacchuuIraiGyouNO As Integer

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
            Public Property JoutaiFLG As Integer
                Get
                    Return _JoutaiFLG
                End Get
                Set(ByVal value As Integer)
                    SetProperty(_JoutaiFLG, value, "JoutaiFLG")
                End Set
            End Property
            Private _JoutaiFLG As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Property SoufusakiNouhinKibouDate As Date
                Get
                    Return _SoufusakiNouhinKibouDate
                End Get
                Set(ByVal value As Date)
                    SetProperty(_SoufusakiNouhinKibouDate, value, "SoufusakiNouhinKibouDate")
                End Set
            End Property
            Private _SoufusakiNouhinKibouDate As Date

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

   End Class

End Namespace
