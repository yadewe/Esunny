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
    /// �ͻ��ʽ������ѯӦ��ṹ
    /// </summary>
    public class TapAPIAccountCashAdjustQryRsp : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIAccountCashAdjustQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountCashAdjustQryRsp obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIAccountCashAdjustQryRsp()
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
                        TapTradeWrapperPINVOKE.delete_TapAPIAccountCashAdjustQryRsp(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        ///  ����
        /// </summary>
        public string Date
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_Date_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_Date_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ͻ��ʽ��˺�
        /// </summary>
        public string AccountNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_AccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ʽ��������
        /// </summary>
        public char CashAdjustType
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CashAdjustType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CashAdjustType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string CurrencyGroupNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CurrencyGroupNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CurrencyGroupNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���ֺ�
        /// </summary>
        public string CurrencyNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CurrencyNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CurrencyNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ʽ�������
        /// </summary>
        public double CashAdjustValue
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CashAdjustValue_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CashAdjustValue_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ʽ������ע
        /// </summary>
        public string CashAdjustRemark
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CashAdjustRemark_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CashAdjustRemark_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string OperateTime
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_OperateTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_OperateTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ����Ա
        /// </summary>
        public string OperatorNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_OperatorNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_OperatorNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ͻ�����
        /// </summary>
        public string AccountBank
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_AccountBank_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_AccountBank_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ͻ������˺�
        /// </summary>
        public string BankAccount
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_BankAccount_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_BankAccount_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ͻ�����ұ�ʶ
        /// </summary>
        public char AccountLWFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_AccountLWFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_AccountLWFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��˾����
        /// </summary>
        public string CompanyBank
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CompanyBank_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CompanyBank_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��˾�����˻�
        /// </summary>
        public string InternalBankAccount
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_InternalBankAccount_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_InternalBankAccount_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��˾����ұ�ʶ
        /// </summary>
        public char CompanyLWFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CompanyLWFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIAccountCashAdjustQryRsp_CompanyLWFlag_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIAccountCashAdjustQryRsp() : this(TapTradeWrapperPINVOKE.new_TapAPIAccountCashAdjustQryRsp(), true)
        {
        }

    }

}