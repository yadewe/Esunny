
VC++=》包含目录-》$(SolutionDir)TapAPI;$(IncludePath)

VC++=》库目录=》$(SolutionDir)TapAPI\lib;$(LibraryPath)


c/c++=》预处理器=》预处理器定义=》_WINDLL;%(PreprocessorDefinitions)

c/c++=》语言=》符合模式=》是 (/permissive-)


链接器=》输入=》附加依赖项=》TapQuoteAPI.lib;%(AdditionalDependencies)