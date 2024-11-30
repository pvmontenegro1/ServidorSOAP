# CRUD SOAP de Librería

Este proyecto implementa un CRUD (Crear, Leer, Actualizar, Eliminar) utilizando servicios SOAP para gestionar una librería. A continuación, se detallan los pasos para ejecutar correctamente el servidor y el cliente.

## Pasos para ejecutar el proyecto

### 1. Clonar el repositorio

Primero, debes clonar el repositorio desde GitHub a tu máquina local.

```bash
git clone https://github.com/pvmontenegro1/ServidorSOAP.git

### 2. Ejecutar los proyectos por separado
El proyecto consta de dos partes: el servidor SOAP y el cliente. Es importante ejecutar ambos proyectos por separado.

### 3. Iniciar el servidor SOAP

Ejecuta el servidor SOAP primero. Este se encargará de gestionar las operaciones CRUD.
Una vez que el servidor esté ejecutándose, abre el navegador y verifica que el servidor SOAP esté activo y funcionando correctamente.

### 4. Ejecutar el cliente
Una vez que el servidor SOAP esté en funcionamiento, abre la aplicación de consola del cliente.
Al abrir la consola, podrás empezar a realizar las operaciones CRUD en la librería. Las operaciones disponibles son:
Crear: Añadir un nuevo libro a la librería.
Leer: Consultar la lista de libros o detalles de un libro específico.
Actualizar: Modificar los datos de un libro existente.
Eliminar: Eliminar un libro de la librería.

### 5. Mantener el servidor SOAP abierto

Es muy importante que mantengas el servidor SOAP abierto y funcionando mientras interactúas con el cliente. Si el servidor se detiene o se cierra, el cliente no podrá realizar ninguna operación correctamente.

### Detalles adicionales
Si encuentras problemas al ejecutar el proyecto, asegúrate de que:

El servidor SOAP esté corriendo antes de intentar usar el cliente.
No haya errores en la consola del servidor SOAP.
El cliente esté apuntando a la URL correcta del servidor SOAP.
Si necesitas más ayuda, no dudes en abrir un issue en el repositorio.

### Tecnologías utilizadas
.NET Framework
Servicios SOAP
Visual Studio 2022

### Licencia
Este proyecto está bajo la Licencia MIT. Para más detalles, consulta el archivo LICENSE.

Nota importante
Recuerda que el servidor SOAP debe estar en funcionamiento para que el cliente pueda realizar las operaciones CRUD. Asegúrate de verificar que la URL del servicio SOAP esté accesible antes de intentar hacer peticiones desde el cliente.

Si tienes algún problema con la configuración del servidor o del cliente, revisa la documentación de cada uno o abre un issue para obtener soporte adicional.

