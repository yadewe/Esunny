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

public class TapAPIUpperChannelInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIUpperChannelInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIUpperChannelInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIUpperChannelInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_TapAPIUpperChannelInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UpperChannelNo {
    set {
      QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelName {
    set {
      QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelName_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelName_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperUserNo {
    set {
      QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPIUpperChannelInfo_UpperUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIUpperChannelInfo() : this(QTapTradeApiPINVOKE.new_TapAPIUpperChannelInfo(), true) {
  }

}

}
