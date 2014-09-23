@echo off

setlocal EnableDelayedExpansion 

IF EXIST "%USERPROFILE%\My Documents" (
    echo Windows XP
) ELSE (
IF EXIST "!USERPROFILE!\Documents" (
    echo Vista
) 
)

set VisualizersDir= "%USERPROFILE%\My Documents\Visual Studio 2013\Visualizers"
IF EXIST "%USERPROFILE%\My Documents\Visual Studio 2013\Visualizers" (
  echo using 1 !VisualizersDir!
) else (
    echo !VisualizersDir! not found 1
    set VisualizersDir= "%USERPROFILE%\Documents\Visual Studio 2013\Visualizers"
    IF EXIST "%USERPROFILE%\Documents\Visual Studio 2013\Visualizers" (
      echo using 2 !VisualizersDir!
      ) else (
      echo !VisualizersDir! not found 2
      goto:eof
    )
 )

xcopy /y  bin\debug\ObjectSourceVisualizer.2013.* %VisualizersDir%
xcopy /y  bin\debug\AW.Helper.* %VisualizersDir%
xcopy /y  bin\debug\AW.Winforms.Helpers.* %VisualizersDir%
pause