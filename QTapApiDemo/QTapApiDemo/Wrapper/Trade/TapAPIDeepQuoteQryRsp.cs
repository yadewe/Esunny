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

public class TapAPIDeepQuoteQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIDeepQuoteQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIDeepQuoteQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIDeepQuoteQryRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_TapAPIDeepQuoteQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TapAPIContract Contract {
    set {
      QTapTradeApiPINVOKE.TapAPIDeepQuoteQryRsp_Contract_set(swigCPtr, TapAPIContract.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = QTapTradeApiPINVOKE.TapAPIDeepQuoteQryRsp_Contract_get(swigCPtr);
      TapAPIContract ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIContract(cPtr, false);
      return ret;
    } 
  }

  public TapAPIDeepQuoteInfo DeepQuote {
    set {
      QTapTradeApiPINVOKE.TapAPIDeepQuoteQryRsp_DeepQuote_set(swigCPtr, TapAPIDeepQuoteInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = QTapTradeApiPINVOKE.TapAPIDeepQuoteQryRsp_DeepQuote_get(swigCPtr);
      TapAPIDeepQuoteInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIDeepQuoteInfo(cPtr, false);
      return ret;
    } 
  }

  public TapAPIDeepQuoteQryRsp() : this(QTapTradeApiPINVOKE.new_TapAPIDeepQuoteQryRsp(), true) {
  }

}

}
