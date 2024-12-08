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
7z a  v2rayN.zip $OutputPath
exit 0