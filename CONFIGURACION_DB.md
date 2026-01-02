# 🔧 Guía de Configuración de Conexión a Base de Datos

## Problema Resuelto

Este sistema ahora permite configurar la conexión a la base de datos de manera flexible, **sin necesidad de recompilar** la aplicación cuando cambia la IP o el servidor.

## 📋 Soluciones Implementadas

### 1. **Archivo de Configuración Externa** (✅ Recomendado)

Se creó el archivo `conexion.config` que puedes editar con cualquier editor de texto:

```
Data Source=localhost\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true
```

**Ventajas:**
- ✅ Se puede editar sin Visual Studio
- ✅ No requiere recompilar
- ✅ Solo reiniciar la aplicación
- ✅ Cualquier usuario puede modificarlo

**Cómo usar:**
1. Abre `conexion.config` con el Bloc de notas
2. Modifica la primera línea con tu servidor
3. Guarda el archivo
4. Reinicia la aplicación

### 2. **Formulario de Configuración** (Interfaz Gráfica)

Agregado formulario `frmConfiguracionDB` con:
- ✅ Ejemplos de conexiones predefinidos
- ✅ Botón "Probar Conexión" antes de guardar
- ✅ Ayuda integrada
- ✅ Validación de errores

**Cómo acceder:**
- Desde el menú de la aplicación: **Herramientas → Configurar Conexión**
- O mediante código: `new frmConfiguracionDB().ShowDialog();`

### 3. **Detección Automática** (Fallback)

Si no existe archivo de configuración, el sistema intenta automáticamente:
1. Leer desde `conexion.config`
2. Leer desde `App.config`
3. Usar `localhost\SQLEXPRESS` por defecto

## 🔌 Ejemplos de Cadenas de Conexión

### Para Red Local (Sin IP Fija) - **RECOMENDADO**
```
Data Source=localhost\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true
```
✅ Funciona aunque cambie la IP del equipo

### Por Nombre de Equipo
```
Data Source=MI-PC\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true
```

### Por IP (Red Local)
```
Data Source=192.168.1.100\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true
```
⚠️ Puede fallar si cambia la IP

### Con Usuario y Contraseña
```
Data Source=servidor\SQLEXPRESS;Initial Catalog=DBSisSara;User ID=sa;Password=miPassword;Integrated Security=false
```

## 📦 Al Distribuir la Aplicación

### Opción A: Incluir configuración por defecto
1. Copia `conexion.config` junto con el `.exe`
2. El usuario puede editarlo según su red

### Opción B: Sin configuración
1. La aplicación usará `localhost\SQLEXPRESS` por defecto
2. El usuario puede configurarlo desde el menú

## 🛠️ Archivos Modificados/Creados

1. **CapaDatos/ConfiguracionDB.cs** - Nueva clase para gestión de configuración
2. **CapaDatos/conexion.cs** - Actualizada para usar configuración dinámica
3. **CapaPresentacion/frmConfiguracionDB.cs** - Formulario de configuración
4. **conexion.config** - Archivo de configuración externa

## ⚙️ Cómo Funciona

```
┌─────────────────────────────────┐
│  Aplicación solicita conexión  │
└───────────┬─────────────────────┘
            │
            ▼
┌─────────────────────────────────┐
│ 1. ¿Existe conexion.config?    │
│    ✅ SÍ → Usar esa conexión    │
└───────────┬─────────────────────┘
            │ ❌ NO
            ▼
┌─────────────────────────────────┐
│ 2. ¿Existe App.config?          │
│    ✅ SÍ → Usar esa conexión    │
└───────────┬─────────────────────┘
            │ ❌ NO
            ▼
┌─────────────────────────────────┐
│ 3. Usar localhost por defecto   │
└─────────────────────────────────┘
```

## 🚀 Uso en Diferentes Escenarios

### Escenario 1: Desarrollo Local
```
localhost\SQLEXPRESS
```

### Escenario 2: Servidor de Oficina
```
SERVIDOR-OFICINA\SQLEXPRESS
```

### Escenario 3: Red con DHCP (IP Dinámica)
```
nombre-del-servidor\SQLEXPRESS
```
👍 Usa nombre, no IP

### Escenario 4: Servidor Remoto con IP Fija
```
192.168.10.5\SQLEXPRESS
```

## 💡 Consejos

1. **Para evitar problemas de red cambiante**: Usa `localhost` o nombre del servidor, NO la IP
2. **Para servidor centralizado**: Usa el nombre del equipo servidor
3. **Siempre prueba** la conexión antes de guardar (botón "Probar Conexión")
4. **Backups**: Guarda una copia de `conexion.config` con configuraciones funcionando

## 🔍 Solución de Problemas

**Error: "No se puede conectar al servidor"**
- Verifica que SQL Server esté ejecutándose
- Confirma el nombre/IP del servidor
- Revisa el firewall de Windows

**Error: "Login failed"**
- Si usas `Integrated Security=true`, verifica permisos de Windows
- Si usas usuario/contraseña, verifica credenciales

**Archivo conexion.config no existe**
- La aplicación lo creará automáticamente en el primer uso
- O créalo manualmente con Bloc de notas

## 📞 Soporte

Para más ayuda, abre el formulario de configuración y presiona el botón "? Ayuda"
