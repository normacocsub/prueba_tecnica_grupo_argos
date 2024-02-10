# Prueba Tecnica Grupo Argos

¡Bienvenido al proyecto! Este README proporciona instrucciones completas sobre cómo ejecutar la aplicación utilizando Docker y .NET.

## Arquitectura

Este proyecto se baso en el patron arquitectonico Onion


## Ejecución con Docker

Docker proporciona una manera conveniente de contenerizar e implementar aplicaciones. Siga estos pasos para ejecutar Tienda Onion utilizando Docker:

1. Asegúrate de tener Docker instalado en tu sistema. Puedes descargar Docker desde [https://www.docker.com/get-started](https://www.docker.com/get-started).

2. Clona este repositorio en tu máquina local:

   git clone https://github.com/normacocsub/prueba_tecnica_grupo_argos.git


3. Navega al directorio del proyecto:
   cd prueba_tecnica_grupo_argos

4. Construye la imagen Docker:
   docker-compose up --build


5. Una vez que la construcción esté completa, la aplicación estará disponible en [http://localhost:80](http://localhost:80).

## Ejecución con .NET

Si prefieres ejecutar la aplicación utilizando .NET, sigue estos pasos:

1. Asegúrate de tener .NET SDK instalado en tu sistema. Puedes descargar el SDK desde [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

2. Clona este repositorio en tu máquina local (si aún no lo has hecho):

git clone https://github.com/normacocsub/prueba_tecnica_grupo_argos.git

3. Navega al directorio del proyecto:
   cd prueba_tecnica_grupo_argos
4. Restaura las dependencias del proyecto:

dotnet restore

5. Construye la aplicación:

dotnet build


6. Ejecuta la aplicación:

dotnet run --project Presentation/Presentation.csproj


7. Una vez que la aplicación esté ejecutándose, estará disponible en [http://localhost:5000](http://localhost:5000).


## Acceder al Swagger

En el swagger podremos encontrar los endpoints 

``` localhost:5000/swagger/index.html ```

## Requisitos

Para ejecutar la aplicación, necesitas tener instalado lo siguiente:

- Docker (si estás utilizando Docker)
- .NET SDK (si estás ejecutando con .NET)
