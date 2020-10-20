dotnet restore;
dotnet build -c Release;
dotnet pack --no-build -c Release 24NettbutikkSharp/24NettbutikkSharp.csproj;

$nupkg = (Get-ChildItem 24NettbutikkSharp/bin/Release/*.nupkg)[0];

# Push the nuget package to AppVeyor's artifact list.
Push-AppveyorArtifact $nupkg.FullName -FileName $nupkg.Name -DeploymentName "24NettbutikkSharp.nupkg";