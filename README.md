## Crud Basico(Crear-Visualizar-Actualizar-Borrar)



## Correr el proyecto desde VSC
dotnet run -p .\CrudEntityFramework\

## Instalar paquetes
* Se debe estar parado en la carpeta de trabajo

### DbContenxt
`dotnet add package Microsoft.EntityFrameworkCore --version 3.1.3`

### Base de datos
`dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.3`

### Migraciones
 ## VSC
Para ejecutar migraciones en Visual Studio Code se debe,primero instalar el paquete para que reconozca las migraciones
`dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.3`

### Añadir Migración
`dotnet ef migrations add InitialMigration`

### Correr Migración y Crear la BD
`dotnet ef database update`

### Remover Migración
`dotnet ef migrations remove`



 ## Visual Studio 2019
 Para ejecutar las migraciones en Visual Studio 2019 se debe primero instalar el paquete para que reconozca las migraciones
`dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.3`


### Añadir Migración
`add-migration MigracionInicial`

### Correr Migración y Crear la BD
`update-database`



## DataTables
Agregamos el CDN en _layout ya que este se aplicara para todas las vistas
* CSS
href=`"https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css"`
* JS
src=`"https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js"`

## Proximamente
Claims-JWT-UserSecret-Swagger-fluentAPI