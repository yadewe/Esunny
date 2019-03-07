//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi {

public class TapAPICloseInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPICloseInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPICloseInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPICloseInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPICloseInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char CloseSide {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseSide_get(swigCPtr);
      return ret;
    } 
  }

  public uint CloseQty {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseQty_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenPrice {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePrice {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_ClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_ClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenMatchNo {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_OpenMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_OpenMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenMatchDateTime {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_OpenMatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_OpenMatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CloseMatchNo {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CloseMatchDateTime {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseMatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseMatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public uint CloseStreamId {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseStreamId_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseStreamId_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrencyGroup {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrency {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CommodityCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPICloseInfo_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPICloseInfo() : this(TapTradeWrapperPINVOKE.new_TapAPICloseInfo(), true) {
  }

}

}
