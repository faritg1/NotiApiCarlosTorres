# Creación de Solución

```
dotnet new sln
```

# Creación de proyectos

## Creacion proyecto ClassLib

```
dotnet new classlib -o Core
dotnet new classlib -o Infrastructure
```

## Creacion Proyecto WebApi

```
dotnet new webapi -o ApiNoti
```

El folder destino corresponde a la carpeta donde se creara el proyecto. Se recomienda que el nombre tenga la palabra Api Por ej. ApiAnimals.

# Agregar proyectos a la solucion

```
dotnet sln add ApiNoti
dotnet sln add Core
dotnet sln add Infrastructure
```

# Agregar referencia entre Proyectos

Nota. Recuerde que las referencias se establecen desde el proyecto que contiene la referencia

```
dotnet add reference ..\Infrastructure
dotnet add reference ..\Core
```

# Instalacion de paquetes

## Proyecto WebApi ApiNoti

```
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.10
dotnet add package Microsoft.Extensions.DependencyInjection --version 7.0.0
dotnet add package System.IdentityModel.Tokens.Jwt --version 6.32.3
dotnet add package Serilog.AspNetCore --version 7.0.0
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1

```

## Proyecto Infrastructure

```
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore --version 7.0.10
dotnet add package CsvHelper --version 30.0.1

```

## Implementa Comandos Por Si Hay Algun Error

```
dotnet restore
dotnet clean
dotnet build

```

## Instrucciones de Uso

1. Debe tener instalado .Net 7.0
    Comprubalo con el siguiente comando dotnet --version
2. Sino tiene instalado .Net 7.0 Puedes instalarlo [aquí](https://dotnet.microsoft.com/en-us/download/dotnet/7.0). 
3. Debe terner algun gestor de base de datos para ejecutar el programa
4. El User=root y password=123456 o en appsettings implementarlo al gusto del ejecutador
3. Ejecute el programa con el siguiente comando.
    dotnet watch --project ./ApiNoti/ -- dotnet run --project ./ApiNoti/
4. Comprobar cada endpoint mediante su Uri o mediante swagger