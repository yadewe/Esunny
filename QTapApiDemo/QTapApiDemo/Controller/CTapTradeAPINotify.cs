using QTapTradeWrapperApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTapApiDemo
{
    public class CTapTradeAPINotify: ITapTradeAPINotify
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
        public event Action OnAPIReadyEvent;
        public event Action<int> OnDisconnectEvent;

        public override void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo)
        {
            OnRspLoginEvent?.Invoke(errorCode, loginRspInfo);
        }

        public override void OnAPIReady()
        {
            OnAPIReadyEvent?.Invoke();
        }

        public override void OnDisconnect(int reasonCode)
        {
            OnDisconnectEvent?.Invoke(reasonCode);
        }

        public override void OnRspChangePassword(uint sessionID, int errorCode)
        {

        }


        public override void OnRspSetReservedInfo(uint sessionID, int errorCode, string info)
        {

        }


        public override void OnRspQryAccount(uint sessionID, uint errorCode, char isLast, TapAPIAccountInfo info)
        {

        }

        public override void OnRspQryFund(uint sessionID, int errorCode, char isLast, TapAPIFundData info)
        {

        }

        public override void OnRspQryExchange(uint sessionID, int errorCode, char isLast, TapAPIExchangeInfo info)
        {

        }

        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPICommodityInfo info)
        {

        }
        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPITradeContractInfo info)
        {

        }
        public override void OnRspQryOrder(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {

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

       


        #region Rtn 主推

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

        #endregion
    }
}
