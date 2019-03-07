
VC++=》包含目录-》$(SolutionDir)TapAPI;$(IncludePath)

VC++=》库目录=》$(SolutionDir)TapAPI\lib\windows;$(LibraryPath)


c/c++=》预处理器=》预处理器定义=》_WINDLL;%(PreprocessorDefinitions)


链接器=》输入=》附加依赖项=》iTapTradeAPI.lib;%(AdditionalDependencies)

在头文件TapTradeWrapperApi.h中替换 virtual void 为 virtual void TAP_CDECL