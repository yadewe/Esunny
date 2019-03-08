//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapTradeWrapperApi {

public class ITapTradeAPINotify : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITapTradeAPINotify(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITapTradeAPINotify obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITapTradeAPINotify() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_ITapTradeAPINotify(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void OnConnect() {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnConnect(swigCPtr);
  }

  public virtual void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspLogin(swigCPtr, errorCode, TapAPITradeLoginRspInfo.getCPtr(loginRspInfo));
  }

  public virtual void OnAPIReady() {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnAPIReady(swigCPtr);
  }

  public virtual void OnDisconnect(int reasonCode) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnDisconnect(swigCPtr, reasonCode);
  }

  public virtual void OnRspChangePassword(uint sessionID, int errorCode) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspChangePassword(swigCPtr, sessionID, errorCode);
  }

  public virtual void OnRspSetReservedInfo(uint sessionID, int errorCode, string info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspSetReservedInfo(swigCPtr, sessionID, errorCode, info);
  }

  public virtual void OnRspQryAccount(uint sessionID, uint errorCode, char isLast, TapAPIAccountInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryAccount(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountInfo.getCPtr(info));
  }

  public virtual void OnRspQryFund(uint sessionID, int errorCode, char isLast, TapAPIFundData info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryFund(swigCPtr, sessionID, errorCode, isLast, TapAPIFundData.getCPtr(info));
  }

  public virtual void OnRtnFund(TapAPIFundData info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnFund(swigCPtr, TapAPIFundData.getCPtr(info));
  }

  public virtual void OnRspQryExchange(uint sessionID, int errorCode, char isLast, TapAPIExchangeInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryExchange(swigCPtr, sessionID, errorCode, isLast, TapAPIExchangeInfo.getCPtr(info));
  }

  public virtual void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPICommodityInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryCommodity(swigCPtr, sessionID, errorCode, isLast, TapAPICommodityInfo.getCPtr(info));
  }

  public virtual void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPITradeContractInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryContract(swigCPtr, sessionID, errorCode, isLast, TapAPITradeContractInfo.getCPtr(info));
  }

  public virtual void OnRtnContract(TapAPITradeContractInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnContract(swigCPtr, TapAPITradeContractInfo.getCPtr(info));
  }

  public virtual void OnRtnOrder(TapAPIOrderInfoNotice info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnOrder(swigCPtr, TapAPIOrderInfoNotice.getCPtr(info));
  }

  public virtual void OnRspOrderAction(uint sessionID, uint errorCode, TapAPIOrderActionRsp info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspOrderAction(swigCPtr, sessionID, errorCode, TapAPIOrderActionRsp.getCPtr(info));
  }

  public virtual void OnRspQryOrder(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryOrder(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info));
  }

  public virtual void OnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryOrderProcess(swigCPtr, sessionID, errorCode, isLast, TapAPIOrderInfo.getCPtr(info));
  }

  public virtual void OnRspQryFill(uint sessionID, int errorCode, char isLast, TapAPIFillInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryFill(swigCPtr, sessionID, errorCode, isLast, TapAPIFillInfo.getCPtr(info));
  }

  public virtual void OnRtnFill(TapAPIFillInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnFill(swigCPtr, TapAPIFillInfo.getCPtr(info));
  }

  public virtual void OnRspQryPosition(uint sessionID, int errorCode, char isLast, TapAPIPositionInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryPosition(swigCPtr, sessionID, errorCode, isLast, TapAPIPositionInfo.getCPtr(info));
  }

  public virtual void OnRtnPosition(TapAPIPositionInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnPosition(swigCPtr, TapAPIPositionInfo.getCPtr(info));
  }

  public virtual void OnRspQryClose(uint sessionID, int errorCode, char isLast, TapAPICloseInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryClose(swigCPtr, sessionID, errorCode, isLast, TapAPICloseInfo.getCPtr(info));
  }

  public virtual void OnRtnClose(TapAPICloseInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnClose(swigCPtr, TapAPICloseInfo.getCPtr(info));
  }

  public virtual void OnRtnPositionProfit(TapAPIPositionProfitNotice info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnPositionProfit(swigCPtr, TapAPIPositionProfitNotice.getCPtr(info));
  }

  public virtual void OnRspQryDeepQuote(uint sessionID, int errorCode, char isLast, TapAPIDeepQuoteQryRsp info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryDeepQuote(swigCPtr, sessionID, errorCode, isLast, TapAPIDeepQuoteQryRsp.getCPtr(info));
  }

  public virtual void OnRspQryExchangeStateInfo(uint sessionID, int errorCode, char isLast, TapAPIExchangeStateInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspQryExchangeStateInfo(swigCPtr, sessionID, errorCode, isLast, TapAPIExchangeStateInfo.getCPtr(info));
  }

  public virtual void OnRtnExchangeStateInfo(TapAPIExchangeStateInfoNotice info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnExchangeStateInfo(swigCPtr, TapAPIExchangeStateInfoNotice.getCPtr(info));
  }

  public virtual void OnRtnReqQuoteNotice(TapAPIReqQuoteNotice info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRtnReqQuoteNotice(swigCPtr, TapAPIReqQuoteNotice.getCPtr(info));
  }

  public virtual void OnRspUpperChannelInfo(uint sessionID, int errorCode, char isLast, TapAPIUpperChannelInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspUpperChannelInfo(swigCPtr, sessionID, errorCode, isLast, TapAPIUpperChannelInfo.getCPtr(info));
  }

  public virtual void OnRspAccountRentInfo(uint sessionID, int errorCode, char isLast, TapAPIAccountRentInfo info) {
    QTapTradeApiPINVOKE.ITapTradeAPINotify_OnRspAccountRentInfo(swigCPtr, sessionID, errorCode, isLast, TapAPIAccountRentInfo.getCPtr(info));
  }

  public ITapTradeAPINotify() : this(QTapTradeApiPINVOKE.new_ITapTradeAPINotify(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnConnect", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateITapTradeAPINotify_0(SwigDirectorOnConnect);
    if (SwigDerivedClassHasMethod("OnRspLogin", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateITapTradeAPINotify_1(SwigDirectorOnRspLogin);
    if (SwigDerivedClassHasMethod("OnAPIReady", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateITapTradeAPINotify_2(SwigDirectorOnAPIReady);
    if (SwigDerivedClassHasMethod("OnDisconnect", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateITapTradeAPINotify_3(SwigDirectorOnDisconnect);
    if (SwigDerivedClassHasMethod("OnRspChangePassword", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateITapTradeAPINotify_4(SwigDirectorOnRspChangePassword);
    if (SwigDerivedClassHasMethod("OnRspSetReservedInfo", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateITapTradeAPINotify_5(SwigDirectorOnRspSetReservedInfo);
    if (SwigDerivedClassHasMethod("OnRspQryAccount", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateITapTradeAPINotify_6(SwigDirectorOnRspQryAccount);
    if (SwigDerivedClassHasMethod("OnRspQryFund", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateITapTradeAPINotify_7(SwigDirectorOnRspQryFund);
    if (SwigDerivedClassHasMethod("OnRtnFund", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateITapTradeAPINotify_8(SwigDirectorOnRtnFund);
    if (SwigDerivedClassHasMethod("OnRspQryExchange", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateITapTradeAPINotify_9(SwigDirectorOnRspQryExchange);
    if (SwigDerivedClassHasMethod("OnRspQryCommodity", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateITapTradeAPINotify_10(SwigDirectorOnRspQryCommodity);
    if (SwigDerivedClassHasMethod("OnRspQryContract", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateITapTradeAPINotify_11(SwigDirectorOnRspQryContract);
    if (SwigDerivedClassHasMethod("OnRtnContract", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateITapTradeAPINotify_12(SwigDirectorOnRtnContract);
    if (SwigDerivedClassHasMethod("OnRtnOrder", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateITapTradeAPINotify_13(SwigDirectorOnRtnOrder);
    if (SwigDerivedClassHasMethod("OnRspOrderAction", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateITapTradeAPINotify_14(SwigDirectorOnRspOrderAction);
    if (SwigDerivedClassHasMethod("OnRspQryOrder", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateITapTradeAPINotify_15(SwigDirectorOnRspQryOrder);
    if (SwigDerivedClassHasMethod("OnRspQryOrderProcess", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateITapTradeAPINotify_16(SwigDirectorOnRspQryOrderProcess);
    if (SwigDerivedClassHasMethod("OnRspQryFill", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateITapTradeAPINotify_17(SwigDirectorOnRspQryFill);
    if (SwigDerivedClassHasMethod("OnRtnFill", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateITapTradeAPINotify_18(SwigDirectorOnRtnFill);
    if (SwigDerivedClassHasMethod("OnRspQryPosition", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateITapTradeAPINotify_19(SwigDirectorOnRspQryPosition);
    if (SwigDerivedClassHasMethod("OnRtnPosition", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateITapTradeAPINotify_20(SwigDirectorOnRtnPosition);
    if (SwigDerivedClassHasMethod("OnRspQryClose", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateITapTradeAPINotify_21(SwigDirectorOnRspQryClose);
    if (SwigDerivedClassHasMethod("OnRtnClose", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateITapTradeAPINotify_22(SwigDirectorOnRtnClose);
    if (SwigDerivedClassHasMethod("OnRtnPositionProfit", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateITapTradeAPINotify_23(SwigDirectorOnRtnPositionProfit);
    if (SwigDerivedClassHasMethod("OnRspQryDeepQuote", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateITapTradeAPINotify_24(SwigDirectorOnRspQryDeepQuote);
    if (SwigDerivedClassHasMethod("OnRspQryExchangeStateInfo", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateITapTradeAPINotify_25(SwigDirectorOnRspQryExchangeStateInfo);
    if (SwigDerivedClassHasMethod("OnRtnExchangeStateInfo", swigMethodTypes26))
      swigDelegate26 = new SwigDelegateITapTradeAPINotify_26(SwigDirectorOnRtnExchangeStateInfo);
    if (SwigDerivedClassHasMethod("OnRtnReqQuoteNotice", swigMethodTypes27))
      swigDelegate27 = new SwigDelegateITapTradeAPINotify_27(SwigDirectorOnRtnReqQuoteNotice);
    if (SwigDerivedClassHasMethod("OnRspUpperChannelInfo", swigMethodTypes28))
      swigDelegate28 = new SwigDelegateITapTradeAPINotify_28(SwigDirectorOnRspUpperChannelInfo);
    if (SwigDerivedClassHasMethod("OnRspAccountRentInfo", swigMethodTypes29))
      swigDelegate29 = new SwigDelegateITapTradeAPINotify_29(SwigDirectorOnRspAccountRentInfo);
    QTapTradeApiPINVOKE.ITapTradeAPINotify_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25, swigDelegate26, swigDelegate27, swigDelegate28, swigDelegate29);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ITapTradeAPINotify));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnConnect() {
    OnConnect();
  }

  private void SwigDirectorOnRspLogin(int errorCode, global::System.IntPtr loginRspInfo) {
    OnRspLogin(errorCode, (loginRspInfo == global::System.IntPtr.Zero) ? null : new TapAPITradeLoginRspInfo(loginRspInfo, false));
  }

  private void SwigDirectorOnAPIReady() {
    OnAPIReady();
  }

  private void SwigDirectorOnDisconnect(int reasonCode) {
    OnDisconnect(reasonCode);
  }

  private void SwigDirectorOnRspChangePassword(uint sessionID, int errorCode) {
    OnRspChangePassword(sessionID, errorCode);
  }

  private void SwigDirectorOnRspSetReservedInfo(uint sessionID, int errorCode, string info) {
    OnRspSetReservedInfo(sessionID, errorCode, info);
  }

  private void SwigDirectorOnRspQryAccount(uint sessionID, uint errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryAccount(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIAccountInfo(info, false));
  }

  private void SwigDirectorOnRspQryFund(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryFund(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIFundData(info, false));
  }

  private void SwigDirectorOnRtnFund(global::System.IntPtr info) {
    OnRtnFund((info == global::System.IntPtr.Zero) ? null : new TapAPIFundData(info, false));
  }

  private void SwigDirectorOnRspQryExchange(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryExchange(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIExchangeInfo(info, false));
  }

  private void SwigDirectorOnRspQryCommodity(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryCommodity(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPICommodityInfo(info, false));
  }

  private void SwigDirectorOnRspQryContract(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryContract(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPITradeContractInfo(info, false));
  }

  private void SwigDirectorOnRtnContract(global::System.IntPtr info) {
    OnRtnContract((info == global::System.IntPtr.Zero) ? null : new TapAPITradeContractInfo(info, false));
  }

  private void SwigDirectorOnRtnOrder(global::System.IntPtr info) {
    OnRtnOrder((info == global::System.IntPtr.Zero) ? null : new TapAPIOrderInfoNotice(info, false));
  }

  private void SwigDirectorOnRspOrderAction(uint sessionID, uint errorCode, global::System.IntPtr info) {
    OnRspOrderAction(sessionID, errorCode, (info == global::System.IntPtr.Zero) ? null : new TapAPIOrderActionRsp(info, false));
  }

  private void SwigDirectorOnRspQryOrder(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryOrder(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIOrderInfo(info, false));
  }

  private void SwigDirectorOnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryOrderProcess(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIOrderInfo(info, false));
  }

  private void SwigDirectorOnRspQryFill(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryFill(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIFillInfo(info, false));
  }

  private void SwigDirectorOnRtnFill(global::System.IntPtr info) {
    OnRtnFill((info == global::System.IntPtr.Zero) ? null : new TapAPIFillInfo(info, false));
  }

  private void SwigDirectorOnRspQryPosition(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryPosition(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIPositionInfo(info, false));
  }

  private void SwigDirectorOnRtnPosition(global::System.IntPtr info) {
    OnRtnPosition((info == global::System.IntPtr.Zero) ? null : new TapAPIPositionInfo(info, false));
  }

  private void SwigDirectorOnRspQryClose(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryClose(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPICloseInfo(info, false));
  }

  private void SwigDirectorOnRtnClose(global::System.IntPtr info) {
    OnRtnClose((info == global::System.IntPtr.Zero) ? null : new TapAPICloseInfo(info, false));
  }

  private void SwigDirectorOnRtnPositionProfit(global::System.IntPtr info) {
    OnRtnPositionProfit((info == global::System.IntPtr.Zero) ? null : new TapAPIPositionProfitNotice(info, false));
  }

  private void SwigDirectorOnRspQryDeepQuote(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryDeepQuote(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIDeepQuoteQryRsp(info, false));
  }

  private void SwigDirectorOnRspQryExchangeStateInfo(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryExchangeStateInfo(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIExchangeStateInfo(info, false));
  }

  private void SwigDirectorOnRtnExchangeStateInfo(global::System.IntPtr info) {
    OnRtnExchangeStateInfo((info == global::System.IntPtr.Zero) ? null : new TapAPIExchangeStateInfoNotice(info, false));
  }

  private void SwigDirectorOnRtnReqQuoteNotice(global::System.IntPtr info) {
    OnRtnReqQuoteNotice((info == global::System.IntPtr.Zero) ? null : new TapAPIReqQuoteNotice(info, false));
  }

  private void SwigDirectorOnRspUpperChannelInfo(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspUpperChannelInfo(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIUpperChannelInfo(info, false));
  }

  private void SwigDirectorOnRspAccountRentInfo(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspAccountRentInfo(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIAccountRentInfo(info, false));
  }

  public delegate void SwigDelegateITapTradeAPINotify_0();
  public delegate void SwigDelegateITapTradeAPINotify_1(int errorCode, global::System.IntPtr loginRspInfo);
  public delegate void SwigDelegateITapTradeAPINotify_2();
  public delegate void SwigDelegateITapTradeAPINotify_3(int reasonCode);
  public delegate void SwigDelegateITapTradeAPINotify_4(uint sessionID, int errorCode);
  public delegate void SwigDelegateITapTradeAPINotify_5(uint sessionID, int errorCode, string info);
  public delegate void SwigDelegateITapTradeAPINotify_6(uint sessionID, uint errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_7(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_8(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_9(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_10(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_11(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_12(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_13(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_14(uint sessionID, uint errorCode, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_15(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_16(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_17(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_18(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_19(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_20(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_21(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_22(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_23(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_24(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_25(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_26(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_27(global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_28(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapTradeAPINotify_29(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);

  private SwigDelegateITapTradeAPINotify_0 swigDelegate0;
  private SwigDelegateITapTradeAPINotify_1 swigDelegate1;
  private SwigDelegateITapTradeAPINotify_2 swigDelegate2;
  private SwigDelegateITapTradeAPINotify_3 swigDelegate3;
  private SwigDelegateITapTradeAPINotify_4 swigDelegate4;
  private SwigDelegateITapTradeAPINotify_5 swigDelegate5;
  private SwigDelegateITapTradeAPINotify_6 swigDelegate6;
  private SwigDelegateITapTradeAPINotify_7 swigDelegate7;
  private SwigDelegateITapTradeAPINotify_8 swigDelegate8;
  private SwigDelegateITapTradeAPINotify_9 swigDelegate9;
  private SwigDelegateITapTradeAPINotify_10 swigDelegate10;
  private SwigDelegateITapTradeAPINotify_11 swigDelegate11;
  private SwigDelegateITapTradeAPINotify_12 swigDelegate12;
  private SwigDelegateITapTradeAPINotify_13 swigDelegate13;
  private SwigDelegateITapTradeAPINotify_14 swigDelegate14;
  private SwigDelegateITapTradeAPINotify_15 swigDelegate15;
  private SwigDelegateITapTradeAPINotify_16 swigDelegate16;
  private SwigDelegateITapTradeAPINotify_17 swigDelegate17;
  private SwigDelegateITapTradeAPINotify_18 swigDelegate18;
  private SwigDelegateITapTradeAPINotify_19 swigDelegate19;
  private SwigDelegateITapTradeAPINotify_20 swigDelegate20;
  private SwigDelegateITapTradeAPINotify_21 swigDelegate21;
  private SwigDelegateITapTradeAPINotify_22 swigDelegate22;
  private SwigDelegateITapTradeAPINotify_23 swigDelegate23;
  private SwigDelegateITapTradeAPINotify_24 swigDelegate24;
  private SwigDelegateITapTradeAPINotify_25 swigDelegate25;
  private SwigDelegateITapTradeAPINotify_26 swigDelegate26;
  private SwigDelegateITapTradeAPINotify_27 swigDelegate27;
  private SwigDelegateITapTradeAPINotify_28 swigDelegate28;
  private SwigDelegateITapTradeAPINotify_29 swigDelegate29;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(int), typeof(TapAPITradeLoginRspInfo) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(uint), typeof(int) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(uint), typeof(int), typeof(string) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(uint), typeof(uint), typeof(char), typeof(TapAPIAccountInfo) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIFundData) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(TapAPIFundData) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIExchangeInfo) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPICommodityInfo) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPITradeContractInfo) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(TapAPITradeContractInfo) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(TapAPIOrderInfoNotice) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] { typeof(uint), typeof(uint), typeof(TapAPIOrderActionRsp) };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIOrderInfo) };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIOrderInfo) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIFillInfo) };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] { typeof(TapAPIFillInfo) };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIPositionInfo) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(TapAPIPositionInfo) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPICloseInfo) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(TapAPICloseInfo) };
  private static global::System.Type[] swigMethodTypes23 = new global::System.Type[] { typeof(TapAPIPositionProfitNotice) };
  private static global::System.Type[] swigMethodTypes24 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIDeepQuoteQryRsp) };
  private static global::System.Type[] swigMethodTypes25 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIExchangeStateInfo) };
  private static global::System.Type[] swigMethodTypes26 = new global::System.Type[] { typeof(TapAPIExchangeStateInfoNotice) };
  private static global::System.Type[] swigMethodTypes27 = new global::System.Type[] { typeof(TapAPIReqQuoteNotice) };
  private static global::System.Type[] swigMethodTypes28 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIUpperChannelInfo) };
  private static global::System.Type[] swigMethodTypes29 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIAccountRentInfo) };
}

}
