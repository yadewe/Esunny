下载最新的接口时注意要修改iTapTradeAPI.h前面的#define为下面

#ifndef ITAP_TRADE_API_H
#define ITAP_TRADE_API_H

#include "iTapTradeAPIDataType.h"

#ifdef _WIN32
#define TAP_CDECL  __cdecl
#define TAP_DLLEXPORT __declspec(dllexport)
#else
#define TAP_CDECL
#define TAP_DLLEXPORT
#endif