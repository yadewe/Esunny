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

public class TapAPIAccountFeeRentQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountFeeRentQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountFeeRentQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAccountFeeRentQryRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIAccountFeeRentQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public char CalculateMode {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CalculateMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CalculateMode_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenCloseFee {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_OpenCloseFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_OpenCloseFee_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayFee {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CloseTodayFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CloseTodayFee_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountFeeRentQryRsp() : this(TapTradeWrapperPINVOKE.new_TapAPIAccountFeeRentQryRsp(), true) {
  }

}

}
