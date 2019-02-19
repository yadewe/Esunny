using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TapQuoteWrapperApi;

namespace TapApiDemo
{
    public class QuoteController
    {
        public CTapQuoteAPINotify QuoteNotify = null;
        private ITapQuoteAPI m_api = null;
        private uint m_sessionID = 0;

        public delegate void OnQuoteUpdateHandler();
        public event OnQuoteUpdateHandler OnQuoteUpdateEvent;

        public delegate void OnRspLoginHandler(int errorCode, TapAPIQuotLoginRspInfo loginRspInfo);
        public event OnRspLoginHandler OnRspLoginEvent;

        public delegate void OnDisconnectHandler(int reasonCode);
        public event OnDisconnectHandler OnDisconnectEvent;

        public delegate void OnQryContractFinishHandler();
        public event OnQryContractFinishHandler OnQryContractFinishEvent;

        public QuoteController()
        {
            QuoteNotify = new CTapQuoteAPINotify();
            InitEventHandler();
        }

        public int InitQuoteAPI()
        {
            TapAPIApplicationInfo appInfo = new TapAPIApplicationInfo();
            appInfo.AuthCode = "B112F916FE7D27BCE7B97EB620206457946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE9D6F622F72E25D5DEF7F47AA93A738EF5A51B81D8526AB6A9D19E65B41F59D6A946CED32E26C1EACCAF8D4C61E28E2B1ABD9B8F170E14F8847D3EA0BF4E191F5DCB1B791E63DC196D1576DEAF5EC563CA3E560313C0C3411B45076795F550EB050A62C4F74D5892D2D14892E812723FAC858DEBD8D4AF9410729FB849D5D8D6EA48A1B8DC67E037381A279CE9426070929D5DA085659772E24A6F5EA52CF92A4D403F9E46083F27B19A88AD99812DADA44100324759F9FD1964EBD4F2F0FB50B51CD31C0B02BB437";
            appInfo.KeyOperationLogPath = "c:\\log";
            int iResult = 0;
            m_api = TapQuoteWrapperAPI.CreateTapQuoteAPI(appInfo, out iResult);
            if (m_api != null)
            {
                m_api.SetAPINotify(QuoteNotify);
            }
            return iResult;
        }
        public void FreeApi()
        {
            ClearEventHandler();
            if (m_api != null)
            {
                TapQuoteWrapperAPI.FreeTapQuoteAPI(m_api);
            }
        }

        private void InitEventHandler()
        {
            QuoteNotify.OnRspLoginEvent += QuoteNotify_OnRspLoginEvent;
            QuoteNotify.OnAPIReadyEvent += QuoteNotify_OnAPIReadyEvent;
            QuoteNotify.OnQuoteUpdateEvent += QuoteNotify_OnQuoteUpdateEvent;
            QuoteNotify.OnDisconnectEvent += QuoteNotify_OnDisconnectEvent;
        }

        private void ClearEventHandler()
        {
            OnQuoteUpdateEvent = null;
            OnRspLoginEvent = null;
            OnDisconnectEvent = null;
            OnQryContractFinishEvent = null;
        }

        void QuoteNotify_OnDisconnectEvent(int reasonCode)
        {
            if (null != OnDisconnectEvent)
            {
                OnDisconnectEvent(reasonCode);
            }
        }

        void QuoteNotify_OnRspLoginEvent(int errorCode, TapAPIQuotLoginRspInfo loginRspInfo)
        {
            if (null != OnRspLoginEvent)
            {
                OnRspLoginEvent(errorCode, loginRspInfo);
            }
        }

        void QuoteNotify_OnQuoteUpdateEvent()
        {
            if (null != OnQuoteUpdateEvent)
            {
                OnQuoteUpdateEvent();
            }
        }
        void QuoteNotify_OnQryFinishEvent(CTapQuoteAPINotify.QuoteQryType qryType)
        {
            switch (qryType)
            {
                case CTapQuoteAPINotify.QuoteQryType.Contract:
                    {
                        if (OnQryContractFinishEvent != null)
                        {
                            OnQryContractFinishEvent();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        void QuoteNotify_OnAPIReadyEvent()
        {
            m_api.QryCommodity(out m_sessionID);
            //m_api.QryContract(out m_sessionID,null);
        }


        public bool Login(string ip, ushort port, string username, string password)
        {
            m_api.SetHostAddress(ip, port);
            TapAPIQuoteLoginAuth loginInfo = new TapAPIQuoteLoginAuth();
            loginInfo.UserNo = username;
            loginInfo.Password = password;
            loginInfo.ISDDA = 'N';
            loginInfo.ISModifyPassword = 'N';
            var result = m_api.Login(loginInfo);
            return result==0;
        }

        public void Disconnect()
        {
            m_api.Disconnect();
        }

    }
}
