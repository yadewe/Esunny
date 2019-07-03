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
    /// �ͻ�������Ӧ������ṹ
    /// </summary>
    public class TapAPIOrderMarketInsertRsp : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIOrderMarketInsertRsp(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderMarketInsertRsp obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIOrderMarketInsertRsp()
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
                        TapTradeWrapperPINVOKE.delete_TapAPIOrderMarketInsertRsp(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// �ͻ��ʽ��ʺ�
        /// </summary>
        public string AccountNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_AccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string ExchangeNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ExchangeNo_get(swigCPtr);
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
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_CommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_CommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ�ֱ�������
        /// </summary>
        public string CommodityNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_CommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_CommodityNo_get(swigCPtr);
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
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ContractNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ContractNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ִ�м۸�
        /// </summary>
        public string StrikePrice
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_StrikePrice_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_StrikePrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���ſ���
        /// </summary>
        public char CallOrPutFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_CallOrPutFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_CallOrPutFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ί������
        /// </summary>
        public char OrderType
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ί����Ч����
        /// </summary>
        public char TimeInForce
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_TimeInForce_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_TimeInForce_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��Ч����(GTD�����ʹ��)
        /// </summary>
        public string ExpireTime
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ExpireTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ExpireTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ί����Դ
        /// </summary>
        public char OrderSource
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSource_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSource_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ƽ��־
        /// </summary>
        public char BuyPositionEffect
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_BuyPositionEffect_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_BuyPositionEffect_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ����ƽ��־
        /// </summary>
        public char SellPositionEffect
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_SellPositionEffect_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_SellPositionEffect_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ί�м�
        /// </summary>
        public double OrderBuyPrice
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderBuyPrice_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderBuyPrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ί�м�
        /// </summary>
        public double OrderSellPrice
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSellPrice_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSellPrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ί����
        /// </summary>
        public uint OrderBuyQty
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderBuyQty_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderBuyQty_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ί����
        /// </summary>
        public uint OrderSellQty
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSellQty_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSellQty_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���׷����ʶ
        /// </summary>
        public char ServerFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ServerFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ServerFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ί�к�
        /// </summary>
        public string OrderBuyNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderBuyNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderBuyNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ί�к�
        /// </summary>
        public string OrderSellNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSellNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderSellNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �Ƿ�T+1��Ч
        /// </summary>
        public char AddOneIsValid
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_AddOneIsValid_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_AddOneIsValid_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �µ���
        /// </summary>
        public string OrderMarketUserNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderMarketUserNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderMarketUserNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �µ�ʱ��
        /// </summary>
        public string OrderMarketTime
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderMarketTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_OrderMarketTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���Ͳο�ֵ
        /// </summary>
        public int RefInt
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_RefInt_set(swigCPtr, value);
            }
            get
            {
                int ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_RefInt_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ����ο�ֵ
        /// </summary>
        public double RefDouble
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_RefDouble_set(swigCPtr, value);
            }
            get
            {
                double ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_RefDouble_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ַ����ο�ֵ
        /// </summary>
        public string RefString
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_RefString_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_RefString_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �򱾵�ί�б��
        /// </summary>
        public string ClientBuyOrderNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientBuyOrderNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientBuyOrderNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ������ί�б��
        /// </summary>
        public string ClientSellOrderNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientSellOrderNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientSellOrderNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ������Ϣ��
        /// </summary>
        public uint ErrorCode
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ErrorCode_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ErrorCode_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string ErrorText
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ErrorText_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ErrorText_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ն˱���IP��ַ���ͻ�����д��
        /// </summary>
        public string ClientLocalIP
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientLocalIP_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientLocalIP_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ն˱���Mac��ַ���ͻ�����д��
        /// </summary>
        public string ClientMac
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientMac_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientMac_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ǰ�ü�¼���ն�IP��ַ��ǰ����д��
        /// </summary>
        public string ClientIP
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientIP_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_ClientIP_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_Remark_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderMarketInsertRsp_Remark_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIOrderMarketInsertRsp() : this(TapTradeWrapperPINVOKE.new_TapAPIOrderMarketInsertRsp(), true)
        {
        }

    }

}