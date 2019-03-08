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

public class TapAPITradeLoginRspInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeLoginRspInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeLoginRspInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPITradeLoginRspInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_TapAPITradeLoginRspInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public int UserType {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_UserType_set(swigCPtr, value);
    } 
    get {
      int ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteTempPassword {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_QuoteTempPassword_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_QuoteTempPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string ReservedInfo {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_ReservedInfo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_ReservedInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginIP {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint LastLoginProt {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginProt_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginProt_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginTime {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLogoutTime {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLogoutTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastLogoutTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastSettleTime {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastSettleTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_LastSettleTime_get(swigCPtr);
      return ret;
    } 
  }

  public string StartTime {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_StartTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_StartTime_get(swigCPtr);
      return ret;
    } 
  }

  public string InitTime {
    set {
      QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_InitTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPITradeLoginRspInfo_InitTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeLoginRspInfo() : this(QTapTradeApiPINVOKE.new_TapAPITradeLoginRspInfo(), true) {
  }

}

}
