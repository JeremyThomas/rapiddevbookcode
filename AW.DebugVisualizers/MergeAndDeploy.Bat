rem "%PROGRAMFILES%\Microsoft\ILMerge\ILMerge.exe" /out:bin\release\AW.EnumerableVisualizer.dll bin\release\AW.DebugVisualizers.dll bin\release\AW.Helper.dll bin\release\AW.Winforms.Helpers.dll bin\release\Dynamic.dll bin\release\ObjectListView.dll bin\release\sliver.Windows.Forms.StateBrowser.dll bin\release\CSScriptLibrary.dll
rem xcopy /y bin\release\AW.EnumerableVisualizer.dll "%userprofile%\My Documents\Visual Studio 2012\Visualizers" 

"%PROGRAMFILES(X86)%\Microsoft\ILMerge\ILMerge.exe" /out:bin\release\AW.EnumerableVisualizer.dll bin\release\AW.DebugVisualizers.dll bin\release\AW.Helper.dll bin\release\AW.Winforms.Helpers.dll 
bin\release\Dynamic.dll bin\release\ObjectListView.dll bin\release\sliver.Windows.Forms.StateBrowser.dll bin\release\CSScriptLibrary.dll bin\release\Newtonsoft.Json.dll
xcopy /y bin\release\AW.EnumerableVisualizer.dll "%userprofile%\My Documents\Visual Studio 2012\Visualizers" 
pause