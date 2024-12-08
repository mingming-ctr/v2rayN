param (
	[Parameter()]
	[ValidateNotNullOrEmpty()]
	[string]
	$OutputPath = './bin/v2rayN'
)

Write-Host 'Building'

dotnet publish `
	./v2rayN/v2rayN.csproj `
	-c Release `
	-r win-x64 `
	--self-contained false `
	-p:PublishReadyToRun=false `
	-p:PublishSingleFile=true `
	-o "$OutputPath/win-x64"

if ( -Not $? ) {
	exit $lastExitCode
	}

if ( Test-Path -Path ./bin/v2rayN ) {
    rm -Force "$OutputPath/win-x64/*.pdb"
    rm -Force "$OutputPath/win-x64/*.dll"
}

Write-Host 'Build done'

ls $OutputPath
# 7z a  v2rayN.zip $OutputPath
# start D:\gitsrv\v2rayN\v2rayN\bin\v2rayN\win-x64
copy D:\gitsrv\v2rayN\v2rayN\bin\v2rayN\win-x64\v2rayN.exe C:\Users\m\Downloads\zz_v2rayN-With-Core-SelfContained\v2rayN.exe
start C:\Users\m\Downloads\zz_v2rayN-With-Core-SelfContained\v2rayN.exe
exit 0