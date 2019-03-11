using QTapQuoteWrapperApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTapApiDemo
{
    public class CTapQuoteAPINotify : ITapQuoteAPINotify
    {
        public enum QuoteQryType
        {
            Contract
        }


        public delegate void OnRspLoginEventHandler(int errorCode, TapAPIQuotLoginRspInfo loginRspInfo);
        public event OnRspLoginEventHandler OnRspLoginEvent;
        public override void OnRspLogin(int errorCode, TapAPIQuotLoginRspInfo info)
        {
            if (OnRspLoginEvent != null)
            {
                OnRspLoginEvent(errorCode, info);
            }
        }

        public delegate void OnAPIReadyEventHandler();
        public event OnAPIReadyEventHandler OnAPIReadyEvent;
        public override void OnAPIReady()
        {
            if (OnAPIReadyEvent != null)
            {
                OnAPIReadyEvent();
            }
        }

        public delegate void OnDisconnectEventHandler(int reasonCode);
        public event OnDisconnectEventHandler OnDisconnectEvent;
        public override void OnDisconnect(int reasonCode)
        {
            if (OnDisconnectEvent != null)
            {
                OnDisconnectEvent(reasonCode);
            }
        }

        public Action<uint, int, char, TapAPIQuoteCommodityInfo> OnRspQryCommodityEvent;

        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPIQuoteCommodityInfo info)
        {
            if (OnRspQryCommodityEvent != null)
            {
                OnRspQryCommodityEvent(sessionID, errorCode, isLast, info);
                Console.WriteLine($"交易所：{info.Commodity.ExchangeNo}，品种编号：{info.Commodity.CommodityNo}，品种名称：{info.CommodityEngName}");
            }
        }




        public Action<uint, int, char, TapAPIQuoteContractInfo> OnRspQryContractEvent;

        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPIQuoteContractInfo info)
        {
            if (OnRspQryContractEvent != null)
            {
                OnRspQryContractEvent(sessionID, errorCode, isLast, info);
            }
        }


        public delegate void OnQuoteUpdateHandler();
        public event OnQuoteUpdateHandler OnQuoteUpdateEvent;
        public override void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info)
        {
            if (errorCode == 0)
            {
                if (info != null)
                {
                    Console.WriteLine(info.Contract.Commodity.ExchangeNo + " " + info.Contract.Commodity.CommodityNo + " " + info.Contract.StrikePrice1 + " " + info.Q5DAvgQty);
                }
            }
        }

        public override void OnRspUnSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIContract info)
        {

        }

        public override void OnRtnQuote(TapAPIQuoteWhole info)
        {
            //doubleArray temp = doubleArray.frompointer(info.QAskPrice);
            //double test=temp.getitem(0);
            //double test1 = temp.getitem(1);
            //double test2 = temp.getitem(2);
            //double test3 = temp.getitem(3);
            var askPrice = new double[5];
            info.GetQAskPrice(askPrice, 5);
            Console.WriteLine($"更新时间：{info.DateTimeStamp}，交易所：{info.Contract.Commodity.ExchangeNo}，品种：{info.Contract.Commodity.CommodityNo}，合约：{info.Contract.ContractNo1}，最后价格：{info.QLastPrice}，卖一：{askPrice[0]}");
        }
    }
}
