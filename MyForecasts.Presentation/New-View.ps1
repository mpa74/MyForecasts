# Tip: to use in Visual Studio: 
# 1) In solution explorer, right-click the MyForecasts.Presentation project and select "Open in Terminal"
# 2) In the terminal window, type "new" + TAB to expand to ".\New-View.ps1", followed by the view name

Param(
    [Parameter(Mandatory, HelpMessage="The view name ('Page' suffix will be added)")]
    [string]
    $Name,

    [Parameter(HelpMessage="Select the update pattern to use for this view")]
    [ValidateSet("none", "mvvm", "mvux")]
    [string]$Presentation = "mvvm"
)

$SubNamespace = ""
$OutputParameter = ""
$lastDotPos = $Name.LastIndexOf('.')
if ($lastDotPos -ge 0)
{
    $OutputParameter = "-o " + $Name.Substring(0, $lastDotPos).Replace('.', '\')
    $SubNamespace = "." + $Name.Substring(0, $lastDotPos)
    $Name = $Name.Substring($lastDotPos + 1)
}

Invoke-Expression "dotnet new mcs-uno-view $OutputParameter -n $Name --namespace TestMvvm.Presentation$SubNamespace --presentation $Presentation"
