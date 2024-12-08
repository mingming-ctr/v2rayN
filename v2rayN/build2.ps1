param (
	[Parameter()]
	[ValidateNotNullOrEmpty()]
	[string]
	$OutputPath = './bin/v2rayN'
)

Write-Host 'Building'

 

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