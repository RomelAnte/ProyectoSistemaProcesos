# ⚙️ Sistema de Gestión de Procesos y Producción

Un sistema de escritorio desarrollado en C# (.NET / WinForms) diseñado para la administración integral de órdenes de trabajo, control de inventario, maquiladores, moldes, clientes, ventas y servicios subcontratados.

---

## 📌 1. Problema
En empresas dedicadas a la manufactura, confección o servicios de maquila, el seguimiento manual de órdenes de trabajo, moldes, inventario de artículos, servicios subcontratados, ventas y pagos suele generar pérdida de trazabilidad, retrasos en la producción y discrepancias contables o de inventario.

---

## 🎯 2. Objetivo
Desarrollar una aplicación de escritorio robusta y centralizada para administrar de manera integral los procesos operativos y comerciales de la empresa: control de clientes y empleados, seguimiento de maquiladores y moldes de fabricación, registro de servicios contratados, gestión de ventas, pagos y emisión de reportes.

---

## 🛠️ 3. Stack
- **Lenguaje Principal**: C# (.NET Framework)
- **Tipo de Aplicación**: Aplicación de Escritorio (Windows Forms / GUI Nativo)
- **IDE / Entorno de Desarrollo**: Microsoft Visual Studio (`ProyectoSistemaProcesos.sln`)
- **Persistencia de Datos**: SQL Server (Base de Datos Relacional con clases de acceso a datos en C#)
- **Librerías GUI**: WinForms (`System.Windows.Forms`) con componentes personalizados

---

## 📐 4. Arquitectura
La aplicación está organizada en capas dentro de la solución C#:

```text
ProyectoSistemaProcesos/
├── GUI/                      # Capa de Presentación (Formularios WinForms)
│   ├── Form_Inicio.cs        # Pantalla de Login y Autenticación
│   ├── Form_Menu.cs          # Menú principal de navegación
│   ├── Form_Articulo.cs      # Catálogo e inventario de artículos
│   ├── Form_Cliente.cs       # Gestión de clientes
│   ├── Form_Empleado.cs      # Registro de empleados
│   ├── Form_Maquilador.cs    # Administración de maquiladores externos
│   ├── Form_Moldes.cs        # Control de moldes de producción
│   ├── Form_ServContra.cs    # Control de servicios subcontratados
│   ├── Form_Ventas&Pagos.cs  # Módulo de ventas, pagos y cobros
│   └── Form_Reportes.cs      # Emisión de reportes e informes
├── CodeBase/                 # Capa de Lógica de Negocio y Datos
│   ├── Login.cs              # Lógica de inicio de sesión y autenticación
│   ├── Usuario.cs            # Entidad y permisos de usuario
│   ├── Articulos.cs          # Modelo y operaciones de artículos
│   ├── RegArticulo.cs        # Registro y reglas de negocio de artículos
│   ├── RegMolde.cs           # Reglas de negocio para moldes
│   ├── ServContra.cs         # Modelo de servicios contratados
│   └── Reg_ServContra.cs     # Registro de servicios subcontratados
└── resources/ & Properties/  # Iconos, imágenes y configuraciones del proyecto
```

---

## ⚙️ 5. Funcionalidades
- 🔐 **Autenticación y Control de Accesos**: Inicio de sesión por roles de usuario y navegación dinámica.
- 📦 **Gestión de Artículos e Inventario**: Alta, edición y catálogo de productos y materias primas.
- 👥 **Administración de Clientes y Empleados**: Registro, actualización y consulta de datos personales y comerciales.
- 🧱 **Control de Moldes y Maquiladores**: Gestión de moldes de producción y asignación de trabajos a maquiladores externos.
- 📑 **Servicios Contratados**: Seguimiento y registro de órdenes de servicio subcontratadas.
- 💳 **Ventas y Registro de Pagos**: Módulo comercial para procesar ventas, cobros, abonos y saldos pendientes.
- 📊 **Generación de Reportes**: Informes consolidados de operaciones, estado de producción y resultados comerciales.

---

## 📊 6. Estado Actual
🟢 **Funcional / Estable (v1.0)**: Estructura completa por capas (GUI y Lógica de Negocio en C#) con formularios funcionales para cada módulo administrativo.

---

## 🖼️ 7. Capturas

> *Sección reservada para capturas de pantalla de la interfaz de usuario en Windows Forms (Formulario de Login, Menú Principal, Módulo de Ventas, Control de Moldes, etc.).*

---

## 🚀 8. Cómo Ejecutarlo

### Requisitos previos
- **Sistema Operativo**: Windows 10 / 11.
- **Entorno**: Microsoft Visual Studio 2019 / 2022 con la carga de trabajo *Desarrollo de escritorio de .NET* instalada.
- **Framework**: .NET Framework compatible (definido en `.csproj`).
- **Base de Datos**: Servidor SQL Server instalado y configurado.

### Pasos de instalación y ejecución
1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/RomelAnte/ProyectoSistemaProcesos.git
   ```
2. **Abrir la solución**:
   Abre Visual Studio y carga el archivo `ProyectoSistemaProcesos.sln`.
3. **Configurar la cadena de conexión**:
   Actualizar la cadena de conexión a SQL Server en las clases de datos dentro de `CodeBase/` o archivos de configuración.
4. **Compilar y Ejecutar**:
   Presiona `F5` o haz clic en **Iniciar** en Visual Studio para compilar y lanzar la aplicación.

---

## 🗺️ 9. Roadmap
- [ ] Migración o modernización de la interfaz gráfica a **WPF** o **.NET MAUI**.
- [ ] Implementar exportación automática de reportes a formatos **PDF** y **Excel**.
- [ ] Módulo de auditoría e historial de cambios por usuario/rol.
- [ ] Integración con impresoras térmicas de tickets para comprobantes de pago.
