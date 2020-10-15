::----------------------------------------------------------------------------
::
:: Copyright © 2020 Dipl.-Ing. (BA) Steffen Liersch
:: All rights reserved.
::
::----------------------------------------------------------------------------

@echo off

set base=%~dp0
echo Current folder:
echo %base%

echo.
choice /N /M "Do you really want to clean up the current folder? [y/n]" /C YN
if not %ERRORLEVEL%==1 goto END

echo.
echo Deleting temporary files...
for /r "%base%" %%d in (*.user) do (
  if exist "%%d" (
    echo %%d
    del /f /q "%%d"
  )
)

del /f /q /s     *.suo 2> nul
del /f /q /s /ah *.suo 2> nul

echo.
echo Deleting temporary folders...
for /d /r "%base%" %%d in (bin, obj, .vs) do (
  if exist "%%d" (
    echo %%d
    cmd /c rd /s /q "%%d"
  )
)

echo.
pause

:end
