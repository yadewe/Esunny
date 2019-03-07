swig -csharp -c++ -namespace TapTradeWrapperApi -o TapTradeWrapperApi.cpp -dllimport TapTradeWrapperApi.dll -outdir E:\SwigTest\Esunny\swig-TapTradeApi\cs i.idl



在头文件TapTradeWrapperApi.h中替换 virtual void 为 virtual void TAP_CDECL