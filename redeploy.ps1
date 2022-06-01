pushd .\GippDev\Server
dotnet publish -c Release -r linux-x64
pushd .\bin\Release\net6.0\linux-x64\publish
scp -r * root@gipp.dev:/var/www/gipp
ssh root@gipp.dev "systemctl restart gippweb"
popd