//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapQuoteWrapperApi {

public class TapAPIQuoteLoginAuth : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuoteLoginAuth(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuoteLoginAuth obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIQuoteLoginAuth() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapQuoteApiPINVOKE.delete_TapAPIQuoteLoginAuth(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserNo {
    set {
      QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public char ISModifyPassword {
    set {
      QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_ISModifyPassword_set(swigCPtr, value);
    } 
    get {
      char ret = QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_ISModifyPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_Password_set(swigCPtr, value);
    } 
    get {
      string ret = QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string NewPassword {
    set {
      QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_NewPassword_set(swigCPtr, value);
    } 
    get {
      string ret = QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_NewPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteTempPassword {
    set {
      QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_QuoteTempPassword_set(swigCPtr, value);
    } 
    get {
      string ret = QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_QuoteTempPassword_get(swigCPtr);
      return ret;
    } 
  }

  public char ISDDA {
    set {
      QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_ISDDA_set(swigCPtr, value);
    } 
    get {
      char ret = QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_ISDDA_get(swigCPtr);
      return ret;
    } 
  }

  public string DDASerialNo {
    set {
      QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_DDASerialNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapQuoteApiPINVOKE.TapAPIQuoteLoginAuth_DDASerialNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIQuoteLoginAuth() : this(QTapQuoteApiPINVOKE.new_TapAPIQuoteLoginAuth(), true) {
  }

}

}
