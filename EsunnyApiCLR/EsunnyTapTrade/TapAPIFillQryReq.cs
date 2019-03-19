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
    /// 成交查询请求结构
    /// </summary>
    public class TapAPIFillQryReq : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIFillQryReq(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFillQryReq obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIFillQryReq()
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
                        TapTradeWrapperPINVOKE.delete_TapAPIFillQryReq(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 客户资金帐号
        /// </summary>
        public string AccountNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_AccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 交易所编号
        /// </summary>
        public string ExchangeNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_ExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_ExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 品种类型
        /// </summary>
        public char CommodityType
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_CommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_CommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 品种编码类型
        /// </summary>
        public string CommodityNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_CommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_CommodityNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 合约1
        /// </summary>
        public string ContractNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_ContractNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_ContractNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 执行价格
        /// </summary>
        public string StrikePrice
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_StrikePrice_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_StrikePrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 看张看跌
        /// </summary>
        public char CallOrPutFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_CallOrPutFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_CallOrPutFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托来源
        /// </summary>
        public char MatchSource
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_MatchSource_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_MatchSource_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 买入卖出
        /// </summary>
        public char MatchSide
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_MatchSide_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_MatchSide_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 开平标志1
        /// </summary>
        public char PositionEffect
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_PositionEffect_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_PositionEffect_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 服务器标识
        /// </summary>
        public char ServerFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_ServerFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_ServerFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托编码
        /// </summary>
        public string OrderNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_OrderNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_OrderNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 上手号
        /// </summary>
        public string UpperNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_UpperNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_UpperNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托成交删除标
        /// </summary>
        public char IsDeleted
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_IsDeleted_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_IsDeleted_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 是否为T+1单
        /// </summary>
        public char IsAddOne
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIFillQryReq_IsAddOne_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIFillQryReq_IsAddOne_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIFillQryReq() : this(TapTradeWrapperPINVOKE.new_TapAPIFillQryReq(), true)
        {
        }

    }

}
