::----------------------------------------------------------------------------
::
:: Copyright © 2020 Dipl.-Ing. (BA) Steffen Liersch
:: All rights reserved.
::
::----------------------------------------------------------------------------

@echo off
pushd "%~dp0"

where /Q docker-compose
if not %ERRORLEVEL%==0 (echo The required "docker-compose" utility is not installed. & goto error)
docker-compose ps
echo.

echo [1] Start composition
echo [2] Stop composition
echo [E] Exit
echo.
choice /N /M "Choice: " /C 12EQX
echo.
if %ERRORLEVEL%==1 goto start
if %ERRORLEVEL%==2 goto stop
goto end

:start
docker-compose down -t 0
if not %ERRORLEVEL%==0 goto error

set temp=lighttpd_wp\~wordpress.zip
if not exist "%temp%" (
  echo Downloading latest WordPress to "%temp%"...
  powershell -Command Invoke-WebRequest 'https://wordpress.org/latest.zip' -OutFile '%temp%'
  if not exist "%temp%" goto error
)

docker-compose up --build
if not %ERRORLEVEL%==0 goto error
goto end

:stop
docker-compose down -t 0
if not %ERRORLEVEL%==0 goto error
goto end

:end
popd
goto :eof

:error
echo.
pause
popd
exit
