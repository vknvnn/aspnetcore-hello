# Create New Enviroment for study microservice.

This is the fist day: Hello world about Microservice.

I was created a enviroment that it's a way to study about docker for you.

We have:
### 1. Asp.net core project.
### 2. Dockerfile.
### 3. Deploy the all on your Githup.
### 4. A Ubutun Server Enviroment to host docker.
    - Install Docker.
### 5. Pull your source on Ubuntu Server.
### 6. Run first container on docker.
### 7. Enjoy.

# How to use command line on Githup, this is base command line:

### 1. create a repo on git

### 2. Get repo

        git clone https://github.com/vknvnn/docker-day-1.git

### 3. (Optional) if you have any change in your project let user the command line bellow to update on your project Githup.

        git add .

		git commit -m "this is a your command."
		
		git config --global user.email "vokenghiep@gmail.com"
	
		git config --global user.name "Nghiep Vo"
	
		git push

4. If you have any change from other source for your project. let user it to get your new code.

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






