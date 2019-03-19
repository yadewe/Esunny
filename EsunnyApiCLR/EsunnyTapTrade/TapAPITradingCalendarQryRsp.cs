//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi
{
    /// <summary>
    /// 系统交易日查询应答
    /// </summary>
    public class TapAPITradingCalendarQryRsp : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPITradingCalendarQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradingCalendarQryRsp obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPITradingCalendarQryRsp()
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
                        TapTradeWrapperPINVOKE.delete_TapAPITradingCalendarQryRsp(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 当前交易日
        /// </summary>
        public string CurrTradeDate
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_CurrTradeDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_CurrTradeDate_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上次结算日
        /// </summary>
        public string LastSettlementDate
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_LastSettlementDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_LastSettlementDate_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        ///  LME到期日
        /// </summary>
        public string PromptDate
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_PromptDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_PromptDate_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上日LME到期日
        /// </summary>
        public string LastPromptDate
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_LastPromptDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradingCalendarQryRsp_LastPromptDate_get(swigCPtr);
                return ret;
            }
        }

        public TapAPITradingCalendarQryRsp() : this(TapTradeWrapperPINVOKE.new_TapAPITradingCalendarQryRsp(), true)
        {
        }

    }

}
