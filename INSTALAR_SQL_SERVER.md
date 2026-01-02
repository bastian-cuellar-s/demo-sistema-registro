# 📦 GUÍA: INSTALAR SQL SERVER EXPRESS Y RESTAURAR BACKUP

## 🎯 Paso 1: Descargar SQL Server Express

1. Ve a: **https://www.microsoft.com/en-us/sql-server/sql-server-express**
2. Haz click en **"Download now"**
3. Elige entre:
   - **SQL Server 2022 Express** (Recomendado - Más reciente)
   - **SQL Server 2019 Express** (Estable)

4. Descarga **"Express"** (no Desktop o Web)
5. El archivo será: `SQLEXPR_x64_ENU.exe` o similar (~500 MB)

---

## 🔧 Paso 2: Instalar SQL Server Express

1. **Ejecuta el instalador**
   - Click derecho → "Ejecutar como administrador"

2. **Elige opción:** "Custom" o "Express"

3. **En la instalación:**
   - ✅ SQL Server Database Engine
   - ✅ Full-Text and Semantic Searches
   - ✅ SQL Server Replication
   - ✅ Analysis Services (opcional)

4. **Nombre de instancia:** `SQLEXPRESS` (por defecto)

5. **Autenticación:** 
   - ✅ "Windows Authentication" (recomendado)

6. Continúa y completa la instalación
   - Toma 5-10 minutos

---

## 📥 Paso 3: Descargar SQL Server Management Studio (Opcional pero recomendado)

Si quieres interfaz gráfica:

1. Ve a: **https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms**
2. Descarga la versión más reciente
3. Instala normalmente

---

## 🔄 Paso 4: Restaurar el Backup

### **Opción A: Script automático (Recomendado)**

Ejecuta en PowerShell (como administrador):

```powershell
cd C:\code\demo-sistema-registro
.\restaurar-backup.ps1
```

El script hará todo automáticamente.

---

### **Opción B: Manualmente con SQL Server Management Studio**

1. **Abre SQL Server Management Studio**

2. **Conéctate:**
   - Server name: `localhost\SQLEXPRESS`
   - Click "Connect"

3. **Restaura el backup:**
   - Click derecho en "Databases"
   - Click "Restore Database..."

4. **En el formulario:**
   - Source: "Device"
   - Click "..." y selecciona: `C:\code\demo-sistema-registro\backup.sisscz.bak`
   - Database: `DBSisSara`
   - Click "OK"

5. **Espera a que se restaure** (1-2 minutos)

---

### **Opción C: Script SQL manual**

Si tienes `sqlcmd` disponible:

```powershell
sqlcmd -S "localhost\SQLEXPRESS" -U sa -P "tu_password"
```

Luego ejecuta:

```sql
RESTORE DATABASE [DBSisSara] 
FROM DISK = N'C:\code\demo-sistema-registro\backup.sisscz.bak'
WITH REPLACE, RECOVERY
GO
```

---

## ✅ Paso 5: Verificar que funcionó

### **Con SQL Server Management Studio:**
1. En el árbol izquierdo, bajo "Databases"
2. Debe aparecer: **DBSisSara**

### **Con PowerShell:**
```powershell
sqlcmd -S "localhost\SQLEXPRESS" -Q "SELECT name FROM sys.databases WHERE name='DBSisSara'"
```

Si aparece "DBSisSara" ✅ Está listo

---

## 🔌 Paso 6: Actualizar tu aplicación

Una vez restaurada, actualiza la cadena de conexión:

**Opción 1: Editar archivo `conexion.config`**
```
Data Source=localhost\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true
```

**Opción 2: Desde la aplicación**
1. Ejecuta tu app
2. Click en botón "⚙ Config"
3. Selecciona ejemplo: `localhost\SQLEXPRESS`
4. Click "Probar Conexión"
5. Click "Guardar"

---

## 🆘 Problemas Comunes

### ❌ "No se encuentra sqlcmd"
- Reinstala SQL Server con "Client Tools"
- O usa SQL Server Management Studio (más fácil)

### ❌ "Cannot connect to server"
- Verifica que SQL Server esté corriendo:
```powershell
Get-Service MSSQL`$SQLEXPRESS | Start-Service
```

### ❌ "Database already exists"
- Significa que ya está restaurada ✅

### ❌ "Backup file not found"
- Verifica que está en: `C:\code\demo-sistema-registro\backup.sisscz.bak`

---

## 📋 Checklist Final

- [ ] SQL Server Express instalado
- [ ] SQL Server Management Studio instalado (opcional)
- [ ] Backup restaurado
- [ ] Base de datos visible en "Databases"
- [ ] Cadena de conexión actualizada en tu app
- [ ] App se conecta correctamente

---

## 🚀 Resumen Rápido

1. **Descarga e instala:** SQL Server Express
2. **Ejecuta:** `.\restaurar-backup.ps1`
3. **Actualiza:** `conexion.config` (o usa el botón Config)
4. **Listo:** Tu app conecta a la BD

**¡Eso es todo!** 🎉

Si tienes problemas, avísame.
