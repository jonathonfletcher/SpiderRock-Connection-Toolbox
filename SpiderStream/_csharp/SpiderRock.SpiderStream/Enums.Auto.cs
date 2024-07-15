// ------------------------------------------------------------------------------------------------------------------------------
//
// Machine generated.  Do not edit directly.
//
// Copyright 2023, SpiderRock Technology
//
// ------------------------------------------------------------------------------------------------------------------------------

namespace SpiderRock.SpiderStream;
public enum AdjConvention : byte { None=0,Original=1,OSI=2,SpcOnly=3,OSIAlt=4 };		
 public enum AssetType : byte { None=0,EQT=1,IDX=2,BND=3,CUR=4,COM=5,FUT=6,SYN=7,WAR=8,FLX=9,MUT=10,SPD=11,MM=12,MF=13,COIN=14,TOKEN=15,ANY=16 };		
 public enum AuctionEvent : byte { None=0,Start=1,Update=2,End=3 };		
 public enum AuctionLimitType : byte { None=0,Market=1,Limit=2 };		
 public enum AuctionReason : byte { None=0,Open=1,Market=2,Halt=3,Closing=4,RegulatoryImbalance=5 };		
 public enum AuctionStatus : byte { None=0,WillRunOpenAndClose=1,WillRunInterest=2,WillNotRunImbalance=3,WillNotRunClsAuction=4 };		
 public enum AuctionType : byte { None=0,Exposure=1,Improvement=2,Facilitation=3,Solicitation=4,Opening=5,Closing=6,RFQ=7,Block=8,Flash=9 };		
 public enum BuySell : byte { None=0,Buy=1,Sell=2 };		
 public enum CalcPriceType : byte { None=0,Equity=1,Future=2 };		
 public enum CalcSource : byte { None=0,Tick=1,Loop=2 };		
 public enum CallPut : byte { Call=0,Put=1,Pair=2 };		
 public enum ClsMarkState : byte { None=0,LastPrt=1,SRClose=2,ExchClose=4,Final=8 };		
 public enum ContractUnit : byte { None=0,AUD=1,BBL=2,BDFT=3,BRL=4,BU=5,CAD=6,CHF=7,CTRCT=8,CUR=36,CWT=9,CZK=10,EUR=11,GAL=12,GBP=13,HUF=14,ILS=15,IPNT=16,JPY=17,KRW=18,LBS=19,MMBTU=20,MWH=21,MXN=35,MYR=22,NOK=23,NZD=24,PLN=25,RMB=26,RUR=27,SEK=28,TON=29,TRY=31,TRYOZ=32,USD=33,ZAR=34 };		
 public enum Currency : byte { None=0,AUD=1,BRL=2,CAD=3,CHF=4,CNH=5,CNY=6,EUR=7,GBP=8,JPY=9,KRW=10,MXN=11,MYR=12,NOK=13,NZD=14,SEK=15,TRY=16,USD=17,USDCents=18,CZK=19,ZAR=20,HUF=21,USX=22,GBX=23 };		
 public enum DDivSource : byte { None=0,Announced=1,Forecast=2 };		
 public enum ExchOrderStatus : byte { None=0,Open=1,Cancelled=2,Filled=3,Retry=4 };		
 public enum ExchOrderType : byte { None=0,Market=1,Limit=2,Auction=3 };		
 public enum ExchPrtType : byte { None=0 };		
 public enum ExecQualifier : byte { None=0,AllOrNone=1 };		
 public enum ExerciseTime : byte { None=0,PM=1,AM=2 };		
 public enum ExerciseType : byte { None=0,American=1,European=2,Asian=3,Cliquet=4 };		
 public enum ExpirationMap : byte { None=0,ExactMatch=1,UnderlierMap=2 };		
 public enum FirmType : byte { None=0,Customer=1,Firm=2,MarketMaker=3,ProCustomer=4,BrokerDealer=5,AwayMM=6,FirmJBO=7,BrkrDlrCust=8 };		
 public enum FutExch : byte { None=0,CFE=1,CME=2,CBOT=3,COMEX=4,NYMEX=5,ICE=6,EUREX=7,CEDX=8,NXAM=9,NXBR=10,NXLS=11,NXML=12,NXOS=13,NXP=14,ICEFE=15 };		
 public enum GridType : byte { None=0,Unused=1,SRCubic=2,SRCubic2=3,BSpline=4,BSpline2=5 };		
 public enum IdxDataSource : byte { None=0,SpiderRock=1,OPRA=2,SIP=3,CBOE=4,CME=5,MIAX=6 };		
 public enum IdxSrc : byte { Unknown=0,Indication=1,Quote=2 };		
 public enum ImbalanceSide : byte { None=0,Buy=1,Sell=2,NoImbalance=3,InsufOrdsToCalc=4 };		
 public enum ImpliedQuoteError : byte { None=0,InvalidUPrc=1,InvalidSVol=2,PricingError=3 };		
 public enum MLinkStreamState : byte { None=0,Begin=1,Active=2,Complete=3,Replaced=4,Terminated=5 };		
 public enum MarkSource : byte { None=0,NbboMid=1,SRVol=2,LoBound=3,HiBound=4,SRPricer=5,SRQuote=6,CloseMark=7,OpenMark=8 };		
 public enum MarketQualifier : byte { None=0,NA=1,Opening=2,Implied=3 };		
 public enum MarketSession : byte { None=0,PreMkt=1,RegMkt=2,PostMkt=3,PreRegMkt=4,RegPostMkt=5,AllDay=6 };		
 public enum MarketStatus : byte { None=0,PreOpen=1,PreCross=2,Cross=3,Open=4,Closed=5,Halted=6,AfterHours=7 };		
 public enum MoneynessType : byte { None=0,PctStd=1,LogStd=2,NormStd=3 };		
 public enum Multihedge : byte { None=0,Simple=1,Complex=2,AllCash=3,Binary=4,Fragment=5 };		
 public enum NoticeShape : byte { None=0,Single=1,MLeg=2 };		
 public enum OTCPrimaryMarket : byte { None=0,OTCLink=1,OTCBB=2,OTCLinkBB=3,GreyMarket=4,OTCBonds=5 };		
 public enum OTCTier : byte { None=0,OtcNoTier=1,OTCQXUSPrem=2,OTCQXUS=3,OTCQXIntPrem=4,OTCQXInt=5,OTCQB=6,OTCBBOnly=7,PinkCurr=8,PinkLim=9,PinkNoInfo=10,Grey=11,Expert=12,OTCBonds=13 };		
 public enum OptExch : byte { None=0,AMEX=1,BOX=2,CBOE=3,ISE=4,NYSE=5,PHLX=6,NSDQ=7,BATS=8,C2=9,NQBX=10,MIAX=11,GMNI=12,CME=13,CBOT=14,NYMEX=15,COMEX=16,ICE=17,EDGO=18,MCRY=19,MPRL=20,SDRK=21,DQTE=22,EMLD=23,CFE=24,MEMX=25,EUREX=26,CEDX=27,NXAM=28,NXBR=29,NXLS=30,NXML=31,NXOS=32,NXP=33,ICEFE=34 };		
 [System.Flags] public enum OptMktType : byte { None=0,Rotation=1,TradingHalted=2,CustInterest=4,QuoteNotFirm=8,Indicative=16,AutoEligible=32,Regular=64 };		
 public enum OptPriceInc : byte { None=0,PartPenny=1,PartNickle=2,FullPenny=3 };		
 public enum OptionType : byte { None=0,Equity=1,Index=2,Future=3,Binary=4,Warrant=5,Flex=6,MapError=99 };		
 public enum PositionType : byte { None=0,Opening=1,Closing=2,Auto=3 };		
 public enum PriceFormat : byte { None=0,N0=1,N1=2,N2=3,N3=4,N4=5,N5=6,N6=7,N7=8,F4=9,F8=10,Q8=11,F16=12,F32=13,H32=14,Q32=15,F64=16,H64=17,FullPenny=18,PartPenny=19,PartNickle=20,EQT=21,V1=22,V2=23,V3=24,V4=25,V5=26,V6=27,V7=28,V8=29,V9=30,V10=31,V11=32,V12=33,V13=34,V14=35,V15=36,A0=37,A1=38,A2=39,A3=40,A4=41,A5=42,A6=43,A7=44,E32=45 };		
 public enum PriceQuoteType : byte { None=0,Price=1,Vol=2 };		
 public enum PricingModel : byte { None=0,Equity=1,FutureApprox=2,FutureExact=3,NormalApprox=4,NormalExact=5 };		
 public enum PricingSource_V7 : byte { None=0,Native=1,SyntheticExpiry=2 };		
 public enum PrimaryExchange : byte { None=0,NYSE=1,NYSEArca=2,NYSEMkt=3,NASDAQ=4,NASDAQBOS=5,BATS=6,PHLX=7,IEXG=8,CSE=9,NSE=10,FINRA=11,PORTAL=12,OTC=13,CME=14,CBOT=15,NYMEX=16,COMEX=17,ICE=18,EUREX=19,XETRA=20,CDEX=21,BXE=22,CXE=23,DXE=24,LSE=25,NXAM=26,NXBR=27,NXDUB=28,NXLS=29,NXLDN=30,NXML=31,NXMLT=32,NXOS=33,NXP=34 };		
 public enum ProductClass : byte { None=0,Equity=1,Index=2,Future=3,Option=4,Spread=5 };		
 public enum ProductIndexType : byte { None=0,NextDay=1,FirstOfMonth=2,VWA=3,Russel=4 };		
 public enum ProductTerm : byte { None=0,Month=1,Day=2,Week=3,BalanceOfMonth=4,Quarter=5,Season=6,BalanceOfWeek=7,CalendarYear=8,Variable=9,Custom=10,SameDay=11,NextDay=12,Weekly=13,Pack=14,Bundle=15,IRSAndCDSTenor=16,Year=17 };		
 public enum ProductType : byte { None=0,Outright=1,CalSpr=2,EqCalSpr=3,FXCalSpr=4,RedTick=5,BFly=6,Condor=7,Strip=8,InterCmd=9,Pack=10,MnPack=11,PackBFly=12,DblBFly=13,PackSpr=14,Crck=15,Bndl=16,BndlSpr=17,EnrStrp=18,BalStrp=19,UnbalStrp=20,EnICStrp=21,IRICStrp=22,ITRICSpr=23,UserDef=24,Combo=25,TAS=26,TASCalSpr=27,TAA=28,TIC=29,BIC=30,TAP=31,Index=32 };		
 public enum PrtSide : byte { None=0,Mid=1,Bid=2,Ask=3 };		
 public enum PrtType : byte { None=0,CANC=1,OSEQ=2,CNCL=3,LATE=4,CNCO=5,OPEN=6,CNOL=7,OPNL=8,AUTO=9,REOP=10,ISOI=11,SLAN=12,SLAI=13,SLCN=14,SCLI=15,SLFT=16,MLET=17,MLAT=18,MLCT=19,MLFT=20,MESL=21,TLAT=22,MASL=23,MFSL=24,TLET=25,TLCT=26,TLFT=27,TESL=28,TASL=29,TFSL=30,CBMO=31,MCTP=32,EXHT=33 };		
 public enum RunStatus : byte { None=0,Prod=1,Beta=2,UAT=3,SysTest=4 };		
 public enum SpdrKeyType : byte { None=0,Stock=1,Future=2,Option=3,MLeg=4 };		
 public enum StkExch : byte { None=0,AMEX=1,NQBX=2,NSX=3,FNRA=4,ISE=5,EDGA=6,EDGX=7,CHX=8,NYSE=9,ARCA=10,NSDQ=11,CBSX=12,PSX=13,BTSY=14,BATS=15,CBIDX=16,IEX=17,OTC=18,MPRL=19,LTSE=20,MEMX=21,MXIDX=22,DJIDX=23,BXE=24,CXE=25,DXE=26,XETRA=27,NXAM=28,NXBR=29,NXDUB=30,NXLS=31,NXLDN=32,NXML=33,NXMLT=34,NXOS=35,NXP=36 };		
 public enum StkPriceInc : byte { None=0,FullPenny=1,Nickle=2 };		
 public enum StkPrintType : byte { None=0,RegularSequence=1,OutOfSequence=2,VolumeOnly=3,ExtendedHours=4,OddLot=5,OddLotExtendedHours=6 };		
 public enum StrategyClass : byte { None=0,Single=1,Covered=2,Synthetic=3,Straddle=4,RevCon=5,OptRoll=6,Box=7,Vertical=8,Horizontal=9,Mixed=10 };		
 public enum SurfaceResult : byte { None=0,OK=1,EOD=2,Init=3,Cache=4,PrevDay=5,NullExpIdx=6,NoStrikes=7,NoBaseCurve=8,BadBootAtm=9,NoGoodStrikes=10,BadAtmVol=11,Bootstrap=12,NoUPrc=13,NoIVols=14,NoModelPts=15,ZeroYears=16,NoSimpleVol=17,OptMktNotOpn=18,NoBaseSurface=19,UPrcOffCnt=20,SkewKnotCnt=21,Exception=22,AxisError=23,CAskFit1Err=24,CAskFit2Err=25,PAskFit1Err=26,PAskFit2Err=27,CBidFit1Err=28,CBidFit2Err=29,PBidFit1Err=30,PBidFit2Err=31,CobsSampleErr=32,NoPrcFit=33,NumStrikes=34,CMidFitErr=35,PMidFitErr=36,StrikeCount=37,VolKnotCnt=38,InterpError=39,NoAtmStrike=40,CobsConvexFitErr=41,CobsMidFitErr=42,ProxyError=43,NoOptExp=44,Expired=45,NoUnderlier=46,NoBaseUnderlier=47,InvalidUPrc=48,ZeroUPrc=49,WideUMkt=50,StalePrcFit=51,NoPrcCurves=52,PriceError=53,ConvergeFail=54,NoUPrcRatio=55,NoSDivValue=56 };		
 public enum SymbolType : byte { None=0,Equity=1,ADR=2,ETF=3,CashIndex=4,MutualFund=5,ShortETF=6,Future=7,Bond=8,DepReceipts=9,PreferredSec=10,PreferenceShare=11,StructuredProd=12,StapledSec=13,TradeableRights=14,Unit=15,Warrant=16,WhenIssued=17,ForeignIssue=18 };		
 public enum SyntheticSource : byte { None=0,Future=1,FutureRoll=2,Stock=3 };		
 public enum SysEnvironment : byte { None=0,Neptune=1,Pluto=2,V7_Stable=3,V7_Latest=4,Saturn=5,Venus=6,Mars=7,SysTest=8,V7_Current=9 };		
 public enum SysRealm : byte { None=0,SysTest=1,NMS=2,CME=3,FR2=4,LD4=5,DR=6 };		
 public enum TickerSrc : byte { None=0,SR=1,NMS=2,CME=3,ICE=4,CFE=5,CBOT=6,NYMEX=7,COMEX=8,RUT=9,CIDX=10,ARCA=11,NYSE=12,OTC=13,NSDQ=14,MFQS=15,MIAX=16,DJI=17,CUSIP=18,ISIN=19,BXE=20,ESX=21,ANY=22,CXE=23,DXE=24,NXAM=25,NXBR=26,NXDUB=27,NXLS=28,NXLDN=29,NXML=30,NXMLT=31,NXOS=32,NXP=33,EUREX=34,CEDX=35,ICEFE=36 };		
 public enum TimeInForce : byte { None=0,Day=1,IOC=2,GTD=3,ExtDay=4,Week=5,ExtWeek=6 };		
 public enum TimeMetric : byte { None=0,D252=1,D365=2,SPX=3,WK1=4,WK2=5,WK3=6,WK4=7 };		
 public enum TkDefSource : byte { None=0,Vendor=1,OTC=2,SR=3,Exchange=4 };		
 public enum TkStatusFlag : byte { None=0,Active=1,Delisted=2 };		
 public enum ToolSpreadClass : byte { None=0,Stk=1,Fut=2,Call=3,Put=4,Synth=5,RevCon=6,Box=7,JRoll=8,Roll=9,Straddle=10,Strangle=11,CSpread=12,PSpread=13,VStrip=14,VSpread=15,HStrip=16,HSpread=17,BFly=18,RiskRev=19,Mixed=20,VarSwap=21 };		
 public enum TradeableStatus : byte { None=0,OK=1,SurfaceErr=2,LowCCnt=3,LowPCnt=4,FitPrcErr=5,BidAskMiss=6,LowCounter=7,DefaultSkew=8,SessionMiss=9,BaseErr=10,SwitchDelay=11,WideMktV=12,WideMktP=13,WideUMkt=14,UWidthEma=15,CCntEma=16,PCntEma=17,VWidthEma=18,PWidthEma=19,Closed=20 };		
 public enum UnderlierMode : byte { None=0,Actual=1,FrontMonth=2,UPrcAdj=3 };		
 public enum UpdateType : byte { None=0,PrcChange=1,SizeOnly=2,PrevPeriod=3 };		
 public enum VolumeTier : byte { None=0,Top50=1 };		
 public enum YesNo : byte { None=0,Yes=1,No=2 };		

