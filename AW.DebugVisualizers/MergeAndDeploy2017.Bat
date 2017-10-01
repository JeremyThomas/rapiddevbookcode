@echo off

setlocal EnableDelayedExpansion 

IF EXIST "%USERPROFILE%\My Documents" (
    echo Windows XP
) ELSE (
IF EXIST "!USERPROFILE!\Documents" (
    echo Vista
) 
)

set VisualizersDir= "%VisualStudioDir%\Visualizers"
IF EXIST "%VisualizersDir%" (
 echo using VisualStudioDir !VisualizersDir!
 goto build
) else (
set VisualizersDir= "%USERPROFILE%\My Documents\Visual Studio 2017\Visualizers"
IF EXIST "%USERPROFILE%\My Documents\Visual Studio 2017\Visualizers" (
  echo using 1 !VisualizersDir!
) else (
    echo !VisualizersDir! not found 1
    set VisualizersDir= "%USERPROFILE%\Documents\Visual Studio 2017\Visualizers"
    IF EXIST "%USERPROFILE%\Documents\Visual Studio 2017\Visualizers" (
      echo using 2 !VisualizersDir!
      ) else (
      echo !VisualizersDir! not found 2
      goto:eof
    )
 )
 )
:build
@echo on
MSBuild "..\AW.DebugVisualizers.sln" /p:Configuration="Release 2017"
"..\packages\ilmerge.2.14.1208\tools\ILMerge.exe" /out:"bin\Release 2017\AW.EnumerableVisualizer.2017.exe" "bin\Release 2017\AW.DebugVisualizers.exe" "bin\Release 2017\AW.Helper.dll" "bin\Release 2017\AW.Winforms.Helpers.dll" "bin\Release 2017\Dynamic.dll" "bin\Release 2017\ObjectListView.dll" "bin\Release 2017\sliver.Windows.Forms.StateBrowser.dll" "bin\Release 2017\Humanizer.dll" "bin\Release 2017\AdvancedDataGridView.dll" "bin\Release 2017\FastColoredTextBox.dll" "bin\Release 2017\Microsoft.VisualStudio.DebuggerVisualizers.dll" /keyfile:..\Ancillary\AdventureWorks.snk
 xcopy /y "bin\Release 2017\AW.EnumerableVisualizer.2017.exe" %VisualizersDir% 
pause