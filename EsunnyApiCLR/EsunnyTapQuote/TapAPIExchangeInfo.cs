//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapQuoteWrapperApi
{
    /// <summary>
    /// 交易所信息
    /// </summary>
    public class TapAPIExchangeInfo : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIExchangeInfo(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIExchangeInfo obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIExchangeInfo()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        TapQuoteWrapperPINVOKE.delete_TapAPIExchangeInfo(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 交易所编码
        /// </summary>
        public string ExchangeNo
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIExchangeInfo_ExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIExchangeInfo_ExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 交易所名称
        /// </summary>
        public string ExchangeName
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIExchangeInfo_ExchangeName_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIExchangeInfo_ExchangeName_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIExchangeInfo() : this(TapQuoteWrapperPINVOKE.new_TapAPIExchangeInfo(), true)
        {
        }

    }

}
