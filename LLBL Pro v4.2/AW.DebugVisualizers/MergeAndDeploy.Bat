@echo off

setlocal EnableDelayedExpansion 

IF EXIST "%USERPROFILE%\My Documents" (
    echo Windows XP
) ELSE (
IF EXIST "!USERPROFILE!\Documents" (
    echo Vista
) 
)

set VisualizersDir= "%USERPROFILE%\My Documents\Visual Studio 2015\Visualizers"
IF EXIST "%USERPROFILE%\My Documents\Visual Studio 2015\Visualizers" (
  echo using 1 !VisualizersDir!
) else (
    echo !VisualizersDir! not found 1
    set VisualizersDir= "%USERPROFILE%\Documents\Visual Studio 2015\Visualizers"
    IF EXIST "%USERPROFILE%\Documents\Visual Studio 2015\Visualizers" (
      echo using 2 !VisualizersDir!
      ) else (
      echo !VisualizersDir! not found 2
      goto:eof
    )
 )
@echo on
MSBuild "..\AW.DebugVisualizers.sln" /p:Configuration="Release"
"..\packages\ilmerge.2.14.1208\tools\ILMerge.exe" /out:bin\release\AW.EnumerableVisualizer.2015.exe bin\release\AW.DebugVisualizers.exe bin\release\AW.Helper.dll bin\release\AW.Winforms.Helpers.dll bin\release\Dynamic.dll bin\release\ObjectListView.dll bin\release\sliver.Windows.Forms.StateBrowser.dll bin\release\Humanizer.dll bin\release\AdvancedDataGridView.dll bin\release\FastColoredTextBox.dll /keyfile:..\Ancillary\AdventureWorks.snk
 xcopy /y bin\release\AW.EnumerableVisualizer.2015.exe %VisualizersDir% 
pause