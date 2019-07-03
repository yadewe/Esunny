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
    /// �����Լ��Ϣ
    /// </summary>
    public class TapAPIQuoteContractInfo : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIQuoteContractInfo(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuoteContractInfo obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIQuoteContractInfo()
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
                        TapQuoteWrapperPINVOKE.delete_TapAPIQuoteContractInfo(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// ��Լ
        /// </summary>
        public TapAPIContract Contract
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_Contract_set(swigCPtr, TapAPIContract.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_Contract_get(swigCPtr);
                TapAPIContract ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIContract(cPtr, false);
                return ret;
            }
        }
        /// <summary>
        /// ��Լ����,'1'��ʾ���������Լ,'2'��ʾ�����Լ
        /// </summary>
        public char ContractType
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_ContractType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_ContractType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ������ʵ��Լ
        /// </summary>
        public string QuoteUnderlyingContract
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_QuoteUnderlyingContract_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_QuoteUnderlyingContract_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��Լ����
        /// </summary>
        public string ContractName
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_ContractName_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_ContractName_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��Լ������
        /// </summary>
        public string ContractExpDate
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_ContractExpDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_ContractExpDate_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string LastTradeDate
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_LastTradeDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_LastTradeDate_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �״�֪ͨ��
        /// </summary>
        public string FirstNoticeDate
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_FirstNoticeDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuoteContractInfo_FirstNoticeDate_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIQuoteContractInfo() : this(TapQuoteWrapperPINVOKE.new_TapAPIQuoteContractInfo(), true)
        {
        }

    }

}