swig -csharp -c++ -namespace TapQuoteWrapperApi -o TapQuoteWrapperApi.cpp -dllimport TapQuoteWrapperApi.dll i.idl



swig -csharp -c++ -namespace TapQuoteWrapperApi -o TapQuoteWrapperApi.cpp -dllimport TapQuoteWrapperApi.dll -outdir E:\SwigTest\Esunny\swig-TapQuoteApi\cs i.idl


在头文件中TapQuoteWrapperApi.h 把 virtual void 替换为 virtual void TAP_CDECL