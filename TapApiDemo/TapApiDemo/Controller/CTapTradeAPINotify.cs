using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapTradeWrapperApi;
namespace TapApiDemo
{
    public class CTapTradeAPINotify:ITapTradeAPINotify
    {
        public enum TradeQryType
        {
            AccountNo,
            Fund,
            Order
        }

        public override void OnConnect()
        {
        }

        
        public event Action<int, TapAPITradeLoginRspInfo> OnRspLoginEvent;
        public event Action<int> OnAPIReadyEvent;
        public event Action<int> OnDisconnectEvent;

        public override void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo)
        {
            OnRspLoginEvent?.Invoke(errorCode, loginRspInfo);
        }

        public override void OnRspRequestVertificateCode(uint sessionID, int errorCode, TapAPIRequestVertificateCodeRsp rsp)
        {
           
        }

        public override void OnExpriationDate(string date, int days)
        {
            
        }

        public override void OnAPIReady(int errorCode)
        {
            OnAPIReadyEvent?.Invoke(errorCode);
        }

        public override void OnDisconnect(int reasonCode)
        {
            OnDisconnectEvent?.Invoke(reasonCode);
        }

        public override void OnRspChangePassword(uint sessionID, int errorCode)
        {
           
        }

        public override void OnRspAuthPassword(uint sessionID, int errorCode)
        {
           
        }

        public override void OnRspSetReservedInfo(uint sessionID, int errorCode, string info)
        {
           
        }

        public override void OnRspOrderAction(uint sessionID, int errorCode, TapAPIOrderActionRsp info)
        {
            Console.WriteLine($"OnRspOrderAction sessionID:{sessionID}, errorCode:{errorCode}");
           
        }

        public override void OnRspQryAccount(uint sessionID, uint errorCode, char isLast, TapAPIAccountInfo info)
        {
            Console.WriteLine($"OnRspQryAccount sessionID:{sessionID}, errorCode:{errorCode}");

        }

        public override void OnRspQryFund(uint sessionID, int errorCode, char isLast, TapAPIFundData info)
        {
            
        }

        public override void OnRspQryExchange(uint sessionID, int errorCode, char isLast, TapAPIExchangeInfo info)
        {
            
        }

        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPICommodityInfo info)
        {
            Console.WriteLine($"OnRspQryCommodity sessionID:{sessionID}, errorCode:{errorCode}");

        }
        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPITradeContractInfo info)
        {
            Console.WriteLine($"OnRspQryContract sessionID:{sessionID}, errorCode:{errorCode}");
        }
        public override void OnRspQryOrder(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            Console.WriteLine($"OnRspQryOrder sessionID:{sessionID}, errorCode:{errorCode}, isLast:{isLast}, info:{JsonConvert.SerializeObject(info)}");
        }
        public override void OnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            
        }
        public override void OnRspQryFill(uint sessionID, int errorCode, char isLast, TapAPIFillInfo info)
        {
            
        }
      
        public override void OnRspQryPosition(uint sessionID, int errorCode, char isLast, TapAPIPositionInfo info)
        {
            
        }

        public override void OnRspQryPositionSummary(uint sessionID, int errorCode, char isLast, TapAPIPositionSummary info)
        {
            
        }

        public override void OnRspQryCurrency(uint sessionID, int errorCode, char isLast, TapAPICurrencyInfo info)
        {
            
        }
        public override void OnRspQryTradeMessage(uint sessionID, int errorCode, char isLast, TapAPITradeMessage info)
        {
            Console.WriteLine($"OnRspQryTradeMessage sessionID:{sessionID}, errorCode:{errorCode}");
        }
        public override void OnRspQryHisOrder(uint sessionID, int errorCode, char isLast, TapAPIHisOrderQryRsp info)
        {
            
        }
        public override void OnRspQryHisOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIHisOrderQryRsp info)
        {
            
        }
        public override void OnRspQryHisMatch(uint sessionID, int errorCode, char isLast, TapAPIHisMatchQryRsp info)
        {
            
        }
        public override void OnRspQryHisPosition(uint sessionID, int errorCode, char isLast, TapAPIHisPositionQryRsp info)
        {
           
        }
        public override void OnRspQryHisDelivery(uint sessionID, int errorCode, char isLast, TapAPIHisDeliveryQryRsp info)
        {
            
        }
        public override void OnRspQryAccountCashAdjust(uint sessionID, int errorCode, char isLast, TapAPIAccountCashAdjustQryRsp info)
        {
            
        }
        public override void OnRspQryBill(uint sessionID, int errorCode, char isLast, TapAPIBillQryRsp info)
        {
           
        }
        public override void OnRspQryAccountFeeRent(uint sessionID, int errorCode, char isLast, TapAPIAccountFeeRentQryRsp info)
        {
            
        }
        public override void OnRspQryAccountMarginRent(uint sessionID, int errorCode, char isLast, TapAPIAccountMarginRentQryRsp info)
        {
            
        }
        public override void OnRspHKMarketOrderInsert(uint sessionID, int errorCode, TapAPIOrderMarketInsertRsp info)
        {
            
        }
        public override void OnRspHKMarketOrderDelete(uint sessionID, int errorCode, TapAPIOrderMarketInsertRsp info)
        {
            
        }
        public override void OnHKMarketQuoteNotice(TapAPIOrderQuoteMarketNotice info)
        {
           
        }
        public override void OnRspOrderLocalRemove(uint sessionID, int errorCode, TapAPIOrderLocalRemoveRsp info)
        {
            
        }
        public override void OnRspOrderLocalInput(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            
        }
        public override void OnRspOrderLocalModify(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            
        }
        public override void OnRspOrderLocalTransfer(uint sessionID, int errorCode, TapAPIOrderInfo info)
        {
            
        }
        public override void OnRspFillLocalInput(uint sessionID, int errorCode, TapAPIFillLocalInputReq info)
        {
            
        }
        public override void OnRspFillLocalRemove(uint sessionID, int errorCode, TapAPIFillLocalRemoveReq info)
        {
            
        }


        #region Rtn 主推

        public override void OnRtnContactInfo(int errorCode, char isLast, string ContactInfo)
        {
            
        }
        public override void OnRtnFund(TapAPIFundData info)
        {

        }
        public override void OnRtnContract(TapAPITradeContractInfo info)
        {

        }
        public override void OnRtnOrder(TapAPIOrderInfoNotice info)
        {
            
        }
        public override void OnRtnFill(TapAPIFillInfo info)
        {

        }
        public override void OnRtnPosition(TapAPIPositionInfo info)
        {
            
        }
        public override void OnRtnPositionSummary(TapAPIPositionSummary info)
        {
            
        }
        public override void OnRtnPositionProfit(TapAPIPositionProfitNotice info)
        {
            
        }
        public override void OnRtnTradeMessage(TapAPITradeMessage info)
        {
            
        }

        #endregion
    }
}
