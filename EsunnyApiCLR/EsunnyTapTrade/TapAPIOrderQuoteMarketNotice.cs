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
    /// �۽���������ѯ��֪ͨ��
    /// </summary>
    public class TapAPIOrderQuoteMarketNotice : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIOrderQuoteMarketNotice(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderQuoteMarketNotice obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIOrderQuoteMarketNotice()
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
                        TapTradeWrapperPINVOKE.delete_TapAPIOrderQuoteMarketNotice(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string ExchangeNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ������
        /// </summary>
        public char CommodityType
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ�ֱ��
        /// </summary>
        public string CommodityNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CommodityNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��Լ
        /// </summary>
        public string ContractNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ContractNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_ContractNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ִ�м�
        /// </summary>
        public string StrikePrice
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_StrikePrice_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_StrikePrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���ǿ���
        /// </summary>
        public char CallOrPutFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CallOrPutFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_CallOrPutFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public char OrderSide
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderSide_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderSide_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ί����
        /// </summary>
        public uint OrderQty
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderQty_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapTradeWrapperPINVOKE.TapAPIOrderQuoteMarketNotice_OrderQty_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIOrderQuoteMarketNotice() : this(TapTradeWrapperPINVOKE.new_TapAPIOrderQuoteMarketNotice(), true)
        {
        }

    }

}