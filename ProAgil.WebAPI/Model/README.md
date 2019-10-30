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
