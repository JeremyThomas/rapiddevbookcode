rem "%PROGRAMFILES%\Microsoft\ILMerge\ILMerge.exe" /out:bin\release\AW.EnumerableVisualizer.dll bin\release\AW.DebugVisualizers.dll bin\release\AW.Helper.dll bin\release\AW.Winforms.Helpers.dll bin\release\Dynamic.dll bin\release\ObjectListView.dll
rem xcopy /y bin\release\AW.EnumerableVisualizer.dll "%userprofile%\My Documents\Visual Studio 2008\Visualizers" 

"%PROGRAMFILES(X86)%\Microsoft\ILMerge\ILMerge.exe" /out:bin\release\AW.EnumerableVisualizer.dll bin\release\AW.DebugVisualizers.dll bin\release\AW.Helper.dll bin\release\AW.Winforms.Helpers.dll bin\release\Dynamic.dll bin\release\ObjectListView.dll
xcopy /y bin\release\AW.EnumerableVisualizer.dll "%userprofile%\My Documents\Visual Studio 2008\Visualizers" 