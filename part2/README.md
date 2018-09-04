# PART 2: Study Identity Server 4 and Create a image on docker to Authentication.

1. How the Client Credentials is?

    a. How:
        Generating x509 Certificates Ready for Identity Server:

            https://developer.microsoft.com/en-us/windows/downloads/windows-10-sdk

            makecert -n "CN=IdentityServerCN" -a sha256 -sv IdentityServer4Auth.pvk -r IdentityServer4Auth.cer

            pvk2pfx -pvk IdentityServer4Auth.pvk -pi <yourpassword> -spc IdentityServer4Auth.cer -pfx IdentityServer4Auth.pfx -f

    b. Demo:
        - Create a empty solution in VS 2017 with name identityserver4.
        - Create a empty web project with name identity_server_1.

            In the Startus.cs file 



    Open `client-credentials` project and start (Ctr + Shift + B and Ctr + F5 or F5 to debug). 

    Goto `http://localhost:5000/.well-known/openid-configuration`

    

2. 
