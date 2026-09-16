# ProjetoPesquisa_DDD2026
Aulas do Valdir Ferreira

# Criação das camadas "Via Terminal"

1 - src/Domain:
dotnet new console -n Domain

2 - src/Entities:
dotnet new console -n Entities

3- src/Helpers:

4 - src/Infra:
dotnet new console -n Infra

5- src/WebApi:
dotnet new webapi -o src/WebApi

# Instalando o Microsoft.EntityFrameworkCore

1 - src/Domain:
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

2 - src/Entities:
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

3 - src/Infra:
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

4 - src/WebApi
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.12

# Instalando o Microsoft.EntityFrameworkCore.SqlServer

1 - src/Domain:
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.12

2 - src/Entities:
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.12

3 - src/Infra:
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.12

4 - src/WebApi
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.12

# Instalando o Microsoft.EntityFrameworkCore.Tools

1 - src/Domain:
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.12

2 - src/Entities:
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.12

3 - src/Infra:
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.12

4 - src/WebApi
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.12

# Instalando o Microsoft.AspNetCore.Identity.EntityFrameworkCore

1 - src/Domain:
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.12

2 - src/Entities:
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.12

3 - src/Infra:
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.12

4 - src/WebApi
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.12

# Instalando o Swashbuckle.AspNetCore

1 - src/Domain:
dotnet add package Swashbuckle.AspNetCore --version 10.2.3

2 - src/Entities:
dotnet add package Swashbuckle.AspNetCore --version 10.2.3

3 - src/Infra:
dotnet add package Swashbuckle.AspNetCore --version 10.2.3

4 - src/WebApi
dotnet add package Swashbuckle.AspNetCore --version 10.2.3