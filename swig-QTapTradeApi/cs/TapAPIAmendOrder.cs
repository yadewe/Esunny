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

public class TapAPIAmendOrder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAmendOrder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAmendOrder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAmendOrder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_TapAPIAmendOrder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TapAPINewOrder ReqData {
    set {
      QTapTradeApiPINVOKE.TapAPIAmendOrder_ReqData_set(swigCPtr, TapAPINewOrder.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = QTapTradeApiPINVOKE.TapAPIAmendOrder_ReqData_get(swigCPtr);
      TapAPINewOrder ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPINewOrder(cPtr, false);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      QTapTradeApiPINVOKE.TapAPIAmendOrder_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPIAmendOrder_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      QTapTradeApiPINVOKE.TapAPIAmendOrder_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIAmendOrder_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAmendOrder() : this(QTapTradeApiPINVOKE.new_TapAPIAmendOrder(), true) {
  }

}

}
