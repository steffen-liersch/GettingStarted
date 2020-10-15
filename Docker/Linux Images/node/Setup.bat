::----------------------------------------------------------------------------
::
:: Copyright © 2020 Dipl.-Ing. (BA) Steffen Liersch
:: All rights reserved.
::
::----------------------------------------------------------------------------

@echo off

set name=
if "%name%"=="" (for %%f in ("%~dp0\.") do set name=%%~nxf)
pushd "%~dp0"

echo [1] Build image "%name%" and start new container "%name%" interactive
echo [2] Build image "%name%" and start new container "%name%"
echo [3] Start container "%name%"
echo [4] Stop container "%name%"
echo [R] Remove container "%name%" and image "%name%"
echo [E] Exit
echo.
choice /N /M "Choice: " /C 1234REQX
echo.
if %ERRORLEVEL%==1 goto make1
if %ERRORLEVEL%==2 goto make2
if %ERRORLEVEL%==3 goto start
if %ERRORLEVEL%==4 goto stop
if %ERRORLEVEL%==5 goto remove
goto end

:: Called as function
:build
docker rm --force %name%
docker rmi --force %name%
docker build -t %name% .
if not %ERRORLEVEL%==0 goto error
goto :eof

:make1
call :build
docker run --name %name% --tty --interactive %name%
goto end

:make2
call :build
docker run --name %name% %name%
goto end

:start
docker start --interactive %name%
if not %ERRORLEVEL%==0 goto error
goto end

:stop
docker stop --time 0 %name%
if not %ERRORLEVEL%==0 goto error
goto end

:remove
docker stop --time 0 %name%
docker rm --force %name%
docker rmi --force %name%
pause
goto end

:end
popd
goto :eof

:error
echo.
pause
popd
exit
