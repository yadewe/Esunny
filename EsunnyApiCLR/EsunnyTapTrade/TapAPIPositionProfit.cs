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
    /// �ͻ��ֲ�ӯ��
    /// </summary>
    public class TapAPIPositionProfit : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIPositionProfit(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIPositionProfit obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIPositionProfit()
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
                        TapTradeWrapperPINVOKE.delete_TapAPIPositionProfit(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// ���سֲֺţ���������д
        /// </summary>
        public string PositionNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIPositionProfit_PositionNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIPositionProfit_PositionNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ֲ�����
        /// </summary>
        public uint PositionStreamId
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIPositionProfit_PositionStreamId_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapTradeWrapperPINVOKE.TapAPIPositionProfit_PositionStreamId_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ֲ�ӯ��
        /// </summary>
        public double PositionProfit
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIPositionProfit_PositionProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIPositionProfit_PositionProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// LME�ֲ�ӯ��
        /// </summary>
        public double LMEPositionProfit
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIPositionProfit_LMEPositionProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIPositionProfit_LMEPositionProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��Ȩ��ֵ
        /// </summary>
        public double OptionMarketValue
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIPositionProfit_OptionMarketValue_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIPositionProfit_OptionMarketValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ����۸�
        /// </summary>
        public double CalculatePrice
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIPositionProfit_CalculatePrice_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIPositionProfit_CalculatePrice_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIPositionProfit() : this(TapTradeWrapperPINVOKE.new_TapAPIPositionProfit(), true)
        {
        }

    }

}