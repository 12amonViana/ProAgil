# Projeto .NET Core

## Commandos

## Informações
'''
dotnet -h
dotnet --help
'''
## Criar Projetos
'''
dotnet new [Tipo de projeto] -n [Nome do projeto]
ex: dotnet new web -n ProAgil.Web
'''
### Build

'''
dotnet run
dotnet build
dotnet rebuild
dotnet clean
'''

### Migrations

Criar _migrations_

'''
dotnet ef migrations add [nome]
'''

Atualizar banco de dados

'''
dotnet ef database update
'''

Remove _migrations_

'''
dotnet ef migrations remove
'''

Gera scripts _migrations_

'''
dotnet ef migrations script
'''

Criando a partir de outro projeto

'''
dotnet ef --startup-project ../ProAgil.API comando
'''
### Instalando o angular
'''
npm install -g @angular/cli
ng new ProAgil-App

ng serve -o
'''

### Instalando Bootstrap e fontawesome-free
npm i  --save bootstrap @fortawesome/fontawesome-free

### Criando projeto classlib
$ dotnet new classlib -n ProAgil.Domain

### Criando Solution
$ dotnet new sln -n ProAgil

### Excluindo arquivo do projeto ProAgil.Domain
$ rm -R ProAgil.Domain/Class1.cs

### Adicionando projetos a solution
$ dotnet sln ProAgil.sln add ProAgil.WebAPI/ProAgil.WebAPI.csproj ProAgil.Repository/ProAgil.Repository.csproj ProAgil.Domain/ProAgil.Domain.csproj

### Adicionando Referências ao projeto
$ dotnet add ProAgil.WebAPI/ProAgil.WebAPI.csproj reference ProAgil.Repository/ProAgil.Repository.csproj

### Referenciando o projeto WebAPI
$ dotnet ef --startup-project ../ProAgil.WebAPI migrations add init

### Atualizando o banco de dados com migrations 
$ dotnet ef --startup-project ../ProAgil.WebAPI database update

### ngx-bootstrap
https://valor-software.com/ngx-bootstrap/#/documentation#getting-started
