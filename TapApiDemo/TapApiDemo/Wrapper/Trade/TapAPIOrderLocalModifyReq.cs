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

public class TapAPIOrderLocalModifyReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderLocalModifyReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderLocalModifyReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIOrderLocalModifyReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperAPIPINVOKE.delete_TapAPIOrderLocalModifyReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TapAPIOrderLocalInputReq req {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderLocalModifyReq_req_set(swigCPtr, TapAPIOrderLocalInputReq.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapTradeWrapperAPIPINVOKE.TapAPIOrderLocalModifyReq_req_get(swigCPtr);
      TapAPIOrderLocalInputReq ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIOrderLocalInputReq(cPtr, false);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderLocalModifyReq_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderLocalModifyReq_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIOrderLocalModifyReq_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIOrderLocalModifyReq_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderLocalModifyReq() : this(TapTradeWrapperAPIPINVOKE.new_TapAPIOrderLocalModifyReq(), true) {
  }

}

}