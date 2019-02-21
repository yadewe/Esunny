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

        public TradeController()
        {
            TradeNotify = new CTapTradeAPINotify();
            //TapAPIApplicationInfo appInfo = new TapAPIApplicationInfo();
            //appInfo.KeyOperationLogPath = @"E:\SwigTest\Esunny\TapApiDemo\TapApiDemo\bin\Debug\LogsESTrade";
            //appInfo.AuthCode = "67EA896065459BECDFDB924B29CB7DF1946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE41BCBAB68D525B0D111A0884D847D57163FF7F329FA574E7946CED32E26C1EAC946CED32E26C1EAC733827B0CE853869ABD9B8F170E14F8847D3EA0BF4E191F5D97B3DFE4CCB1F01842DD2B3EA2F4B20CAD19B8347719B7E20EA1FA7A3D1BFEFF22290F4B5C43E6C520ED5A40EC1D50ACDF342F46A92CCF87AEE6D73542C42EC17818349C7DEDAB0E4DB16977714F873D505029E27B3D57EB92D5BEDA0A710197EB67F94BB1892B30F58A3F211D9C3B3839BE2D73FD08DD776B9188654853DDA57675EBB7D6FBBFC";
            //int iResult = 0;
            //TapTradeWrapperAPI.SetITapTradeAPIDataPath(@"E:\SwigTest\Esunny\TapApiDemo\TapApiDemo\bin\Debug\LogsESTrade");
            //TapTradeWrapperAPI.SetITapTradeAPILogLevel('D');
            //m_api = TapTradeWrapperAPI.CreateITapTradeAPI(appInfo, out iResult);
            InitEventHandler();
        }

        public int InitTradeAPI()
        {
            TapAPIApplicationInfo appInfo = new TapAPIApplicationInfo();
            appInfo.KeyOperationLogPath = @"E:\SwigTest\Esunny\TapApiDemo\TapApiDemo\bin\Debug\LogsESTrade";
            appInfo.AuthCode = "67EA896065459BECDFDB924B29CB7DF1946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE41BCBAB68D525B0D111A0884D847D57163FF7F329FA574E7946CED32E26C1EAC946CED32E26C1EAC733827B0CE853869ABD9B8F170E14F8847D3EA0BF4E191F5D97B3DFE4CCB1F01842DD2B3EA2F4B20CAD19B8347719B7E20EA1FA7A3D1BFEFF22290F4B5C43E6C520ED5A40EC1D50ACDF342F46A92CCF87AEE6D73542C42EC17818349C7DEDAB0E4DB16977714F873D505029E27B3D57EB92D5BEDA0A710197EB67F94BB1892B30F58A3F211D9C3B3839BE2D73FD08DD776B9188654853DDA57675EBB7D6FBBFC";
            int iResult = 0;
            m_api = TapTradeWrapperAPI.CreateITapTradeAPI(appInfo, out iResult);
            TapTradeWrapperAPI.SetITapTradeAPIDataPath(@"E:\SwigTest\Esunny\TapApiDemo\TapApiDemo\bin\Debug\LogsESTrade");
            TapTradeWrapperAPI.SetITapTradeAPILogLevel('D');
            if (m_api != null)
            {
                var t=m_api.SetAPINotify(TradeNotify);
            }
            return iResult;
        }

        public void FreeApi()
        {
            //ClearEventHandler();
            if (m_api != null)
            {
                TapTradeWrapperAPI.FreeITapTradeAPI(m_api);
            }
        }

        public bool Login(string ip, ushort port, string username, string password)
        {
            TapTradeWrapperAPI.SetITapTradeAPIDataPath(@"E:\SwigTest\Esunny\TapApiDemo\TapApiDemo\bin\Debug\LogsESTrade");
            TapTradeWrapperAPI.SetITapTradeAPILogLevel('D');
            m_api.SetHostAddress("123.161.206.213", 8383);
            TapAPITradeLoginAuth loginInfo = new TapAPITradeLoginAuth();
            loginInfo.UserNo = username;
            loginInfo.Password = password;
            loginInfo.ISModifyPassword = 'N';
            return (0 == m_api.Login(loginInfo));
        }

        private void InitEventHandler()
        {
            TradeNotify.OnRspLoginEvent += TradeNotify_OnRspLoginEvent;
            TradeNotify.OnAPIReadyEvent += TradeNotify_OnAPIReadyEvent;
            TradeNotify.OnDisconnectEvent += TradeNotify_OnDisconnectEvent;
        }

        private void TradeNotify_OnDisconnectEvent(int reasonCode)
        {
            
        }

        private void TradeNotify_OnAPIReadyEvent(int errorCode)
        {
            m_api.QryAccount(out m_sessionID, null);
            m_api.QryOrder(out m_sessionID, null);
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
