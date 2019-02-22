//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapQuoteWrapperApi {

public class ITapQuoteAPINotify : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITapQuoteAPINotify(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITapQuoteAPINotify obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITapQuoteAPINotify() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapQuoteApiPINVOKE.delete_ITapQuoteAPINotify(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void OnRspLogin(int errorCode, TapAPIQuotLoginRspInfo info) {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnRspLogin(swigCPtr, errorCode, TapAPIQuotLoginRspInfo.getCPtr(info));
  }

  public virtual void OnAPIReady() {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnAPIReady(swigCPtr);
  }

  public virtual void OnDisconnect(int reasonCode) {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnDisconnect(swigCPtr, reasonCode);
  }

  public virtual void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPIQuoteCommodityInfo info) {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnRspQryCommodity(swigCPtr, sessionID, errorCode, isLast, TapAPIQuoteCommodityInfo.getCPtr(info));
  }

  public virtual void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPIQuoteContractInfo info) {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnRspQryContract(swigCPtr, sessionID, errorCode, isLast, TapAPIQuoteContractInfo.getCPtr(info));
  }

  public virtual void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info) {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnRspSubscribeQuote(swigCPtr, sessionID, errorCode, isLast, TapAPIQuoteWhole.getCPtr(info));
  }

  public virtual void OnRspUnSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIContract info) {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnRspUnSubscribeQuote(swigCPtr, sessionID, errorCode, isLast, TapAPIContract.getCPtr(info));
  }

  public virtual void OnRtnQuote(TapAPIQuoteWhole info) {
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_OnRtnQuote(swigCPtr, TapAPIQuoteWhole.getCPtr(info));
  }

  public ITapQuoteAPINotify() : this(QTapQuoteApiPINVOKE.new_ITapQuoteAPINotify(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnRspLogin", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateITapQuoteAPINotify_0(SwigDirectorOnRspLogin);
    if (SwigDerivedClassHasMethod("OnAPIReady", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateITapQuoteAPINotify_1(SwigDirectorOnAPIReady);
    if (SwigDerivedClassHasMethod("OnDisconnect", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateITapQuoteAPINotify_2(SwigDirectorOnDisconnect);
    if (SwigDerivedClassHasMethod("OnRspQryCommodity", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateITapQuoteAPINotify_3(SwigDirectorOnRspQryCommodity);
    if (SwigDerivedClassHasMethod("OnRspQryContract", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateITapQuoteAPINotify_4(SwigDirectorOnRspQryContract);
    if (SwigDerivedClassHasMethod("OnRspSubscribeQuote", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateITapQuoteAPINotify_5(SwigDirectorOnRspSubscribeQuote);
    if (SwigDerivedClassHasMethod("OnRspUnSubscribeQuote", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateITapQuoteAPINotify_6(SwigDirectorOnRspUnSubscribeQuote);
    if (SwigDerivedClassHasMethod("OnRtnQuote", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateITapQuoteAPINotify_7(SwigDirectorOnRtnQuote);
    QTapQuoteApiPINVOKE.ITapQuoteAPINotify_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ITapQuoteAPINotify));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnRspLogin(int errorCode, global::System.IntPtr info) {
    OnRspLogin(errorCode, (info == global::System.IntPtr.Zero) ? null : new TapAPIQuotLoginRspInfo(info, false));
  }

  private void SwigDirectorOnAPIReady() {
    OnAPIReady();
  }

  private void SwigDirectorOnDisconnect(int reasonCode) {
    OnDisconnect(reasonCode);
  }

  private void SwigDirectorOnRspQryCommodity(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryCommodity(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIQuoteCommodityInfo(info, false));
  }

  private void SwigDirectorOnRspQryContract(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspQryContract(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIQuoteContractInfo(info, false));
  }

  private void SwigDirectorOnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspSubscribeQuote(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIQuoteWhole(info, false));
  }

  private void SwigDirectorOnRspUnSubscribeQuote(uint sessionID, int errorCode, char isLast, global::System.IntPtr info) {
    OnRspUnSubscribeQuote(sessionID, errorCode, isLast, (info == global::System.IntPtr.Zero) ? null : new TapAPIContract(info, false));
  }

  private void SwigDirectorOnRtnQuote(global::System.IntPtr info) {
    OnRtnQuote((info == global::System.IntPtr.Zero) ? null : new TapAPIQuoteWhole(info, false));
  }

  public delegate void SwigDelegateITapQuoteAPINotify_0(int errorCode, global::System.IntPtr info);
  public delegate void SwigDelegateITapQuoteAPINotify_1();
  public delegate void SwigDelegateITapQuoteAPINotify_2(int reasonCode);
  public delegate void SwigDelegateITapQuoteAPINotify_3(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapQuoteAPINotify_4(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapQuoteAPINotify_5(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapQuoteAPINotify_6(uint sessionID, int errorCode, char isLast, global::System.IntPtr info);
  public delegate void SwigDelegateITapQuoteAPINotify_7(global::System.IntPtr info);

  private SwigDelegateITapQuoteAPINotify_0 swigDelegate0;
  private SwigDelegateITapQuoteAPINotify_1 swigDelegate1;
  private SwigDelegateITapQuoteAPINotify_2 swigDelegate2;
  private SwigDelegateITapQuoteAPINotify_3 swigDelegate3;
  private SwigDelegateITapQuoteAPINotify_4 swigDelegate4;
  private SwigDelegateITapQuoteAPINotify_5 swigDelegate5;
  private SwigDelegateITapQuoteAPINotify_6 swigDelegate6;
  private SwigDelegateITapQuoteAPINotify_7 swigDelegate7;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(int), typeof(TapAPIQuotLoginRspInfo) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIQuoteCommodityInfo) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIQuoteContractInfo) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIQuoteWhole) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(uint), typeof(int), typeof(char), typeof(TapAPIContract) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(TapAPIQuoteWhole) };
}

}
