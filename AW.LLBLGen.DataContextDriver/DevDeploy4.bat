rem
rem  You can simplify development by updating this batch file and then calling it from the 
rem  project's post-build event.
rem
rem  It copies the output .DLL (and .PDB) to LINQPad's drivers folder, so that LINQPad
rem  picks up the drivers immediately (without needing to click 'Add Driver').
rem
rem  NB: The target directory may not be correct for your computer!
rem  You can obtain the first part of the directory by running the following query:
rem
rem    Path.Combine (
rem       Environment.GetFolderPath (Environment.SpecialFolder.CommonApplicationData),
rem       @"LINQPad\Drivers\DataContext\3.5\")   
rem
rem  The final part of the directory is the name of the assembly plus its public key token in brackets.
echo 4.0 4ed8595102af593c
xcopy /i/y *.dll "C:\Documents and Settings\All Users\Application Data\LINQPad\Drivers\DataContext\4.0\AW.LLBLGen.DataContextDriver.50 (4ed8595102af593c)"
xcopy /i/y *.pdb "C:\Documents and Settings\All Users\Application Data\LINQPad\Drivers\DataContext\4.0\AW.LLBLGen.DataContextDriver.50 (4ed8595102af593c)"
echo %LOCALAPPDATA%
xcopy /i/y *.dll "%LOCALAPPDATA%\LINQPad\Drivers\DataContext\4.6\AW.LLBLGen.DataContextDriver.50 (4ed8595102af593c)"
xcopy /i/y *.pdb "%LOCALAPPDATA%\LINQPad\Drivers\DataContext\4.6\AW.LLBLGen.DataContextDriver.50 (4ed8595102af593c)"
pause