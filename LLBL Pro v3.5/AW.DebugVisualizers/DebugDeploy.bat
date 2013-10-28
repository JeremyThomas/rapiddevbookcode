@echo off
set VisualizersDir= %USERPROFILE%\My Documents\Visual Studio 2012\Visualizers
IF EXIST %VisualizersDir% (
  echo using 1 %VisualizersDir%
) else (
    echo %VisualizersDir% not found 1
    set VisualizersDir= "%USERPROFILE%\Documents\Visual Studio 2012\Visualizers" 
    IF EXIST %VisualizersDir% (
      echo using 2 %VisualizersDir%
      ) else (
      echo %VisualizersDir% not found 2
      goto:eof
    )
 )

xcopy /y  bin\debug\AW.DebugVisualizers.* %VisualizersDir%
xcopy /y  bin\debug\AW.Helper.* %VisualizersDir%
xcopy /y  bin\debug\AW.Winforms.Helpers.* %VisualizersDir%
xcopy /y  bin\debug\Dynamic.* %VisualizersDir%
xcopy /y  bin\debug\ObjectListView.* %VisualizersDir%
xcopy /y  bin\debug\sliver.Windows.Forms.StateBrowser.* %VisualizersDir%
xcopy /y  bin\debug\Newtonsoft.Json.dll %VisualizersDir%
pause