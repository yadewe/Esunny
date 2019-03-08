swig -csharp -c++ -namespace QTapQuoteWrapperApi -o QTapQuoteWrapperApi.cpp -dllimport QTapQuoteWrapperApi.dll -outdir cs i.idl


在头文件中替换 virtual void 为 virtual void TAP_CDECL