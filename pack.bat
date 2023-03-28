@echo %NUGET_API_KEY%
@REM echo required environment variables %NUGET_API_KEY% when %NUGET_API_KEY% is not set
if ""==%NUGET_API_KEY% (
    echo required environment variables %NUGET_API_KEY% when %NUGET_API_KEY% is not set
    exit /b 1
)


@REM Clean up solution
dotnet clean -c Release
@rem build solution file
dotnet build -c Release
@rem pack up Onvif
cd Onvif
python ..\increment_version.py Onvif.csproj
dotnet restore
dotnet pack -c Release
@REM Go to release folder
cd bin\Release
dotnet nuget push *.nupkg -k %NUGET_API_KEY% -s https://api.nuget.org/v3/index.json --skip-duplicate
xcopy /y *.nupkg ..\..\..\..\..
cd ..\..\..
@rem pack up Onvif.PTZ
cd Onvif.PTZ
python ..\increment_version.py Onvif.PTZ.csproj
dotnet pack -c Release
cd bin\Release
dotnet nuget push *.nupkg -k %NUGET_API_KEY% -s https://api.nuget.org/v3/index.json --skip-duplicate
cd ..\..\..
@rem pack up Onvif.Media
cd Onvif.Media
python ..\increment_version.py Onvif.Media.csproj
dotnet pack -c Release
cd bin\Release
dotnet nuget push *.nupkg -k %NUGET_API_KEY% -s https://api.nuget.org/v3/index.json --skip-duplicate
cd ..\..\..
@rem pack up Onvif.DeviceManagement
cd Onvif.DeviceManagement
python ..\increment_version.py Onvif.DeviceManagement.csproj
dotnet pack -c Release
cd bin\Release
dotnet nuget push *.nupkg -k %NUGET_API_KEY% -s https://api.nuget.org/v3/index.json --skip-duplicate
cd ..\..\..
pause