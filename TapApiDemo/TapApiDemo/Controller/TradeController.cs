using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapTradeWrapperApi;

namespace TapApiDemo
{
    public class TradeController
    {
        public CTapTradeAPINotify TradeNotify = null;
        private ITapTradeAPI m_api = null;
        private uint m_sessionID = 0;
        TapAPITradeLoginAuth m_loginInfo;

        public TradeController()
        {
            TradeNotify = new CTapTradeAPINotify();
            InitEventHandler();
        }

        public int InitTradeAPI()
        {
            TapAPIApplicationInfo appInfo = new TapAPIApplicationInfo();
            appInfo.KeyOperationLogPath = "LogEsTrade";
            appInfo.AuthCode = "67EA896065459BECDFDB924B29CB7DF1946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE41BCBAB68D525B0D111A0884D847D57163FF7F329FA574E7946CED32E26C1EAC946CED32E26C1EAC733827B0CE853869ABD9B8F170E14F8847D3EA0BF4E191F5D97B3DFE4CCB1F01842DD2B3EA2F4B20CAD19B8347719B7E20EA1FA7A3D1BFEFF22290F4B5C43E6C520ED5A40EC1D50ACDF342F46A92CCF87AEE6D73542C42EC17818349C7DEDAB0E4DB16977714F873D505029E27B3D57EB92D5BEDA0A710197EB67F94BB1892B30F58A3F211D9C3B3839BE2D73FD08DD776B9188654853DDA57675EBB7D6FBBFC";
            int iResult = -1;
            m_api = TapTradeWrapper.CreateITapTradeAPI(appInfo, out iResult);            
            if (m_api != null)
            {
                try
                {
                    var t = m_api.SetAPINotify(TradeNotify);
                }catch(Exception ex)
                {

                }
            }
            return iResult;
        }

        public void FreeApi()
        {
            //ClearEventHandler();
            if (m_api != null)
            {
                TapTradeWrapper.FreeITapTradeAPI(m_api);
            }
        }

        public bool Login(string ip, ushort port, string username, string password)
        {
            m_api.SetHostAddress("123.161.206.213", 8383);
            m_loginInfo = new TapAPITradeLoginAuth();
            m_loginInfo.UserNo = username;
            m_loginInfo.Password = password;
            m_loginInfo.ISModifyPassword = 'N';
            return (0 == m_api.Login(m_loginInfo));
        }

        private void InitEventHandler()
        {
            TradeNotify.OnRspLoginEvent += TradeNotify_OnRspLoginEvent;
            TradeNotify.OnAPIReadyEvent += TradeNotify_OnAPIReadyEvent;
            TradeNotify.OnDisconnectEvent += TradeNotify_OnDisconnectEvent;
        }

        private void TradeNotify_OnDisconnectEvent(int reasonCode)
        {
            Console.WriteLine($"TradeNotify_OnDisconnectEvent code:{reasonCode}");
        }

        private void TradeNotify_OnAPIReadyEvent(int errorCode)
        {
            Console.WriteLine($"TradeNotify_OnAPIReadyEvent code:{errorCode}");
            m_api.QryAccount(out m_sessionID, null);
            m_api.QryOrder(out m_sessionID, new TapAPIOrderQryReq() { AccountNo = m_loginInfo.UserNo, CommodityNo = "HSI" });
            m_api.QryExchange(out m_sessionID);
            var order = new TapAPINewOrder()
            {
                AccountNo = m_loginInfo.UserNo,
                ContractNo = "1908",
                CommodityNo = "HSI",
                ExchangeNo = "HKEX",
                OrderType = '2',
                OrderPrice = 1234,
                TacticsType = 'N',
                PositionEffect = 'C',
                CommodityType = 'F',
                OrderSide = 'S'
            };
            var result = m_api.InsertOrder(out m_sessionID, "", order);
            Console.WriteLine($"InsertOrder result:{result}");
        }

        private void TradeNotify_OnRspLoginEvent(int errorCode, TapAPITradeLoginRspInfo loginRspInfo)
        {
            if (errorCode == 0)
            {
                Console.WriteLine("登录成功");
            }
        }
    }
}
