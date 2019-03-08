swig -csharp -c++ -namespace QTapTradeWrapperApi -o QTapTradeWrapperApi.cpp -dllimport QTapTradeWrapperApi.dll -outdir cs i.idl



在头文件QTapTradeWrapperApi.h中替换 virtual void 为 virtual void TAP_CDECL