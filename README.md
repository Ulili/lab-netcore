# lab-netcore

Laboratorio de exemplos de recuros do .NET Core

 
# Introdução

Convenção e nomenclatura

## Do Java para .NET Core o que tem de especial?

1. Propriedades ao invés do Getters and Setters
1. Construtor dinâmico
1. Uso o “VAR” ou Multiplas declarações para não ser repetitivo ao instanciar objeto
1. Tipos Anônimos e Tipo Dinâmico 
1. Algumas Keyword
1. Operadores especias ex: null-conditional
1. Yield
1. Async/Await
1. Linq ao invés do streams;
1. Métodos Anônimos, Delegators 
1. Lambda Expressions, Expression, Func e   Action


# Banco de Dados

Install DB usando Docker

## MySql

``` bash
docker run -d --name=mysql1 -p=3306:3306 -e MYSQL_ROOT_PASSWORD='Abc,123' -v /k8s/volumes/mysql1/mysql-datadir:/var/lib/mysql mysql
``` 

## PostgreSql

``` bash
docker run --name=postgre1 -p=5432:5432 -e POSTGRES_PASSWORD='Abc,123' -v /k8s/volumes/postgresql/pgdata:/var/lib/postgresql/data postgres
```

## SqlServer

``` bash
docker run --name=sqlserver1 -v /k8s/volumes/sqlserver/data:/var/opt/mssql -e ACCEPT_EULA=Y -e SA_PASSWORD='Abc,123' -p 1433:1433 -d microsoft/mssql-server-linux:2017-latest
```

# Links

https://developers.redhat.com/blog/2017/05/17/from-java-to-net-core-part-1/ 

https://blog.takipi.com/c-vs-java-5-irreplaceable-c-features-wed-kill-to-have-in-java/ 

https://stackoverflow.com/questions/295224/what-are-major-differences-between-c-sharp-and-java 

https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions   

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions   

https://docs.microsoft.com/en-us/ef/core/providers/
