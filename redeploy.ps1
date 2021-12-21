dotnet publish -c Release -r linux-x64
pushd .\src\GippDev.BlazorApp\bin\Release\net6.0\publish\
scp -r .\wwwroot\ root@gipp.dev:/var/www/gipp
popd