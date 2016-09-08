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
 REM these should be in GAC if you have VS bin\debug\Microsoft.ReportViewer.WinForms.dll bin\debug\Microsoft.ReportViewer.Common.dll 
@echo on
MSBuild "..\AW.DebugVisualizers.sln" /p:Configuration="debug"
"..\packages\ilmerge.2.14.1208\tools\ILMerge.exe" /out:bin\debug\AW.EnumerableVisualizer.2015.exe bin\debug\AW.DebugVisualizers.exe bin\debug\AW.Helper.dll bin\debug\AW.Winforms.Helpers.dll bin\debug\Dynamic.dll bin\debug\ObjectListView.dll bin\debug\sliver.Windows.Forms.StateBrowser.dll bin\debug\Humanizer.dll bin\debug\AdvancedDataGridView.dll bin\debug\FastColoredTextBox.dll /keyfile:..\Ancillary\AdventureWorks.snk
 xcopy /y bin\debug\AW.EnumerableVisualizer.2015.exe %VisualizersDir% 
pause