
# DAY 1: Create New Enviroment for study Microservice.

I was created a enviroment that it's a way to study about docker for you.

We have:
### 1. Asp.net core project.
- Install .Net Core SDK.
- Install Git
- Install Visual Studio Code or Visual Studio 2017
- Create a repo on the Githup (please following in How to use command line on Githup)
- Create new project on CMD or PowerShell

        cd Desktop
        
        mkdir Docker

        cd Docker

        mkdir aspnetcore-hello

        cd aspnetcore-hello

    Result of CMD or PowerShell is C:\Users\ [Window UserName] \Desktop\aspnetcore-hello

        dotnet new web

### 2. Dockerfile.
Create Dockerfile on `C:\Users\ [Window UserName] \Desktop\Docker\aspnetcore-hello` with content: 

        FROM microsoft/dotnet:latest AS build-env
        WORKDIR /app

        COPY *.csproj ./
        RUN dotnet restore

        COPY . ./
        RUN dotnet publish -c Release -o out

        FROM microsoft/dotnet:aspnetcore-runtime
        WORKDIR /app
        COPY --from=build-env /app/out .

        CMD ASPNETCORE_URLS=http://*:$PORT dotnet aspnetcore-hello.dll

### 3. Deploy the all on your Githup.

        git add .
        
        git commit -m "this is a your command."
                
        git config --global user.email "vokenghiep@gmail.com"
        
        git config --global user.name "Nghiep Vo"
        
        git push

### 4. A Ubutun Server Enviroment to host docker.

- Install Ubuntu 18 Server on VMware.
- Install Docker on (https://docs.docker.com/install/linux/docker-ce/ubuntu/).

### 5. Pull your source on Ubuntu Server.

- Connect Ubuntu 18 Server by Putty (download and install https://www.putty.org/)
- Get source code from Githup 

        git clone https://github.com/vknvnn/docker-day-1.git

### 7. Build first image on docker.

        docker build -f aspnetcore-hello .

-f: By default run with Dockerfile file.

-rm: Remove all containers mediate when the command runs successfully.

### 8. Run first container on docker.

        docker run -it aspnetcore-hello

-it: direct to run container with image aspnetcore-hello

### 8. Enjoy.

# How to use command line on Githup.

This is base command line:

### 1. create a repo on git

### 2. Get repo

        git clone https://github.com/vknvnn/docker-day-1.git

### 3. (Optional) if you have any change in your project let user the command line bellow to update on your project Githup.

        git add .

        git commit -m "this is a your command."
    
        git config --global user.email "vokenghiep@gmail.com"

        git config --global user.name "Nghiep Vo"
        
        git push

### 4. If you have any change from other source for your project. let user it to get your new code.

	git pull

# Docker with database images note.

### 1. Working with SQL Server image

- Create container:

		docker run \
		-e 'ACCEPT_EULA=Y' \
		-e 'MSSQL_SA_PASSWORD=P@ssw0rd' \
		-p 1433:1433 \
		--name mssql-dev \
		-v /home/nv/mssql:/var/opt/mssql \
		-d --restart always microsoft/mssql-server-linux

- SQL Server Run Inner:

		docker exec -it mssql-dev "bash"
	
		/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'P@ssw0rd'

- Exit:

		quit
	
		exit

### 2. Working with Postgresql image

- Create container:

		docker run \
		-e POSTGRES_PASSWORD=P@ssw0rd \
		-p 5432:5432 \
		--name pg-dev \
		-v /home/nv/pgdata:/data \   
		-d --restart always postgres

- Postgresql Run Inner:

		docker exec -it pg-dev psql -U postgres

- Exit:

		\q
