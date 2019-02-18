using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TapQuoteWrapperApi;

namespace TapApiDemo
{
    public class CTapQuoteAPINotify:ITapQuoteAPINotify
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

        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPIQuoteCommodityInfo info)
        {
            //throw new NotImplementedException();
        }




        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPIQuoteContractInfo info)
        {
        }


        public delegate void OnQuoteUpdateHandler();
        public event OnQuoteUpdateHandler OnQuoteUpdateEvent;
        public override void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info)
        {
            
        }

        public override void OnRspUnSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIContract info)
        {
           
        }

        public override void OnRtnQuote(TapAPIQuoteWhole info)
        {
            
        }
    }
}
