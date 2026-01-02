# Script para generar instalador ClickOnce
# No requiere instalaciones adicionales, usa MSBuild incluido con .NET Framework

Write-Host "=== Generador de Instalador SisSara ===" -ForegroundColor Green
Write-Host ""

# Ruta de MSBuild
$msbuild = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"

# Verificar que existe MSBuild
if (-not (Test-Path $msbuild)) {
    Write-Host "Error: No se encontró MSBuild en $msbuild" -ForegroundColor Red
    exit 1
}

# Proyecto principal
$proyecto = "DemoSistemaRegistro\DemoSistemaRegistro.csproj"

# Carpeta de salida para el instalador
$outputPath = ".\Instalador"

Write-Host "1. Limpiando compilaciones anteriores..." -ForegroundColor Yellow
& $msbuild $proyecto /t:Clean /p:Configuration=Release /v:minimal

Write-Host "2. Compilando proyecto en modo Release..." -ForegroundColor Yellow
& $msbuild $proyecto /t:Build /p:Configuration=Release /v:minimal

if ($LASTEXITCODE -ne 0) {
    Write-Host "Error en la compilación" -ForegroundColor Red
    exit 1
}

Write-Host "3. Generando instalador ClickOnce..." -ForegroundColor Yellow
& $msbuild $proyecto /t:Publish /p:Configuration=Release /p:PublishDir=$outputPath\ /v:minimal

if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "=== ¡Instalador generado exitosamente! ===" -ForegroundColor Green
    Write-Host "Ubicación: $outputPath" -ForegroundColor Cyan
    Write-Host ""
    
    # Copiar archivos de configuración al instalador
    Write-Host "4. Copiando archivos de configuración..." -ForegroundColor Yellow
    $archivosConfig = @("conexion.config", "INSTRUCCIONES.txt", "LEEME.txt")
    foreach ($archivo in $archivosConfig) {
        if (Test-Path $archivo) {
            Copy-Item $archivo -Destination $outputPath -Force
            Write-Host "  ✓ Copiado: $archivo" -ForegroundColor Green
        }
    }
    
    Write-Host ""
    Write-Host "Archivos generados:" -ForegroundColor Yellow
    Get-ChildItem $outputPath -Recurse | Where-Object { $_.Extension -in @('.application', '.exe', '.manifest', '.config', '.txt') } | ForEach-Object {
        Write-Host "  - $($_.Name)" -ForegroundColor White
    }
    Write-Host ""
    Write-Host "IMPORTANTE:" -ForegroundColor Yellow
    Write-Host "  • El archivo 'conexion.config' permite configurar la BD sin recompilar" -ForegroundColor Cyan
    Write-Host "  • Lee 'INSTRUCCIONES.txt' para configurar la conexión" -ForegroundColor Cyan
    Write-Host ""
    Write-Host "Para distribuir, comparte la carpeta completa '$outputPath'" -ForegroundColor Cyan
    
    # Abrir la carpeta
    explorer $outputPath
} else {
    Write-Host "Error al generar el instalador" -ForegroundColor Red
    exit 1
}
