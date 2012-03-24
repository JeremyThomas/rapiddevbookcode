rem
rem  You can simplify development by updating this batch file and then calling it from the 
rem  project's post-build event.
rem
xcopy /i/y *.dll "C:\Users\Jeremy Thomas\Documents\LINQPad Plugins"
xcopy /i/y *.pdb "C:\Users\Jeremy Thomas\Documents\LINQPad Plugins"
pause