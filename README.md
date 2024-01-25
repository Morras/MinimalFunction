To deploy via pipeline you must change connectedServiceNameARM and appName in the AzureFunctionApp@2 task.

From the root:

dotnet publish .\MinimalFunction\MinimalFunction.csproj --runtime win-x64 --configuration Release --output ./tmp

(then zip the content of tmp folder (not the folder it self) into app.zip)

az functionapp deployment source config-zip -g "RG-MinimalFunction" -n "morasm-minimal-function" --src "app.zip" --subscription "XXX-XXX"