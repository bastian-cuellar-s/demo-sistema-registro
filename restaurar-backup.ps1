# Script para restaurar backup de SQL Server
# Requisito: Tener SQL Server Express instalado

Write-Host "╔══════════════════════════════════════════════════╗" -ForegroundColor Cyan
Write-Host "║   RESTAURADOR DE BACKUP - SISTEMA SISSCZ       ║" -ForegroundColor Cyan
Write-Host "╚══════════════════════════════════════════════════╝" -ForegroundColor Cyan
Write-Host ""

# Verificar si el archivo existe
$backupPath = "C:\code\demo-sistema-registro\backup.sisscz.bak"
if (-not (Test-Path $backupPath)) {
    Write-Host "❌ Error: No se encontró el archivo backup" -ForegroundColor Red
    Write-Host "Ruta esperada: $backupPath" -ForegroundColor Yellow
    exit 1
}

Write-Host "✓ Archivo de backup encontrado: $(Split-Path $backupPath -Leaf)" -ForegroundColor Green
Write-Host "  Tamaño: $([math]::Round((Get-Item $backupPath).Length/1MB, 2)) MB" -ForegroundColor Green
Write-Host ""

# Verificar SQL Server
Write-Host "Verificando SQL Server..." -ForegroundColor Yellow
$sqlPath = "C:\Program Files\Microsoft SQL Server"
$sqlExpress = Get-ChildItem -Path $sqlPath -Filter "SQLEXPRESS" -Directory -ErrorAction SilentlyContinue

if (-not $sqlExpress) {
    Write-Host "❌ SQL Server Express NO está instalado" -ForegroundColor Red
    Write-Host ""
    Write-Host "Opciones:" -ForegroundColor Cyan
    Write-Host "1. Descargar SQL Server Express (2019 o 2022)" -ForegroundColor White
    Write-Host "   → https://www.microsoft.com/en-us/sql-server/sql-server-express" -ForegroundColor Cyan
    Write-Host ""
    Write-Host "2. O instalar LocalDB (más ligero, 50 MB):" -ForegroundColor White
    Write-Host "   → https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb" -ForegroundColor Cyan
    Write-Host ""
    exit 1
}

Write-Host "✓ SQL Server encontrado: SQLEXPRESS" -ForegroundColor Green
Write-Host ""

# Crear script SQL para restaurar
$sqlScript = @"
-- Script para restaurar backup
USE master;
GO

-- Usar el archivo de backup
RESTORE DATABASE [DBSisSara] 
FROM DISK = N'C:\code\demo-sistema-registro\backup.sisscz.bak'
WITH REPLACE, RECOVERY
GO

-- Verificar que se restauró
SELECT name, create_date, state_desc FROM sys.databases WHERE name = 'DBSisSara'
GO
"@

# Guardar script temporal
$scriptPath = "$env:TEMP\restore_backup.sql"
Set-Content -Path $scriptPath -Value $sqlScript -Encoding UTF8

Write-Host "Iniciando restauración..." -ForegroundColor Yellow
Write-Host ""

# Ejecutar script con sqlcmd
try {
    # Intentar con servidor local
    & sqlcmd -S "localhost\SQLEXPRESS" -i $scriptPath -o "$env:TEMP\restore_output.txt" 2>&1
    
    if ($LASTEXITCODE -eq 0) {
        Write-Host "✓ ¡Restauración completada exitosamente!" -ForegroundColor Green
        Write-Host ""
        Write-Host "Base de datos restaurada: DBSisSara" -ForegroundColor Cyan
        Write-Host "Servidor: localhost\SQLEXPRESS" -ForegroundColor Cyan
        Write-Host ""
        Write-Host "Actualiza tu cadena de conexión a:" -ForegroundColor Yellow
        Write-Host "Data Source=localhost\SQLEXPRESS;Initial Catalog=DBSisSara;Integrated Security=true" -ForegroundColor White
        Write-Host ""
        Write-Host "O edita el archivo: conexion.config" -ForegroundColor Cyan
    } else {
        Write-Host "⚠️  Error durante la restauración" -ForegroundColor Red
        Write-Host "Detalles:" -ForegroundColor Yellow
        Get-Content "$env:TEMP\restore_output.txt" | Write-Host -ForegroundColor Gray
    }
} 
catch {
    Write-Host "❌ Error: $_" -ForegroundColor Red
}

# Limpiar archivos temporales
Remove-Item -Path $scriptPath -Force -ErrorAction SilentlyContinue
Remove-Item -Path "$env:TEMP\restore_output.txt" -Force -ErrorAction SilentlyContinue

Write-Host ""
Write-Host "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" -ForegroundColor Gray
