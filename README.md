# OnionCrafter.Entities.Base

![Versión de la librería](https://img.shields.io/badge/Versi%C3%B3n-1.0.0-brightgreen) [![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Entities.Base.svg)](https://www.nuget.org/packages/OnionCrafter.Entities.Base/)

![](https://raw.githubusercontent.com/Dtopiast/OnionCrafter.Entities.Base/main/Images/Logo.png)

**Estado de la Librería: Pre-Alfa - No Listo para Producción**

Esta librería se encuentra actualmente en un estado pre-alfa, lo que significa que está en una fase muy temprana de desarrollo y no está destinada para su uso en entornos de producción. Estamos trabajando arduamente para mejorar y estabilizar la librería, pero aún pueden existir errores y limitaciones significativas.

Si estás interesado en utilizar esta librería, te recomendamos encarecidamente que la pruebes en un entorno de desarrollo o pruebas para evaluar su idoneidad para tu proyecto. No se garantiza la estabilidad ni la compatibilidad con versiones futuras en este estado inicial.

Por favor, mantente atento a futuras actualizaciones y anuncios sobre el progreso de la librería. Tu retroalimentación y contribuciones son bienvenidas a medida que avanzamos hacia una versión más estable y lista para producción.

## Descripción

OnionCrafter.Entities.Base es una biblioteca ligera que proporciona definiciones de interfaces y clases base para entidades en proyectos desarrollados en .NET 7. Esta biblioteca está diseñada para ayudarte a garantizar la seguridad de tipos y la trazabilidad en tu aplicación, simplificando el proceso de desarrollo y mejorando la calidad del código.

## Características

- Define interfaces y clases base para entidades en .NET 7.
- Proporciona una implementación base abstracta para entidades con claves.
- Admite tipos de clave genéricos y cadenas.
- Facilita la creación y gestión de entidades en tu aplicación.

## Requisitos

- .NET 7 (Asegúrate de tenerlo instalado en tu entorno de desarrollo).

## Uso

1. Agrega una referencia a OnionCrafter.Entities.Base en tu proyecto.
2. Crea clases de entidad que implementen las interfaces proporcionadas por la biblioteca.
3. Extiende la clase `BaseEntity<TKey>` o de la interfaz `IEntity<TKey>` para definir entidades con claves personalizadas.
4. Utiliza las clases y interfaces proporcionadas para crear y administrar entidades en tu aplicación.

Para obtener ejemplos detallados sobre cómo utilizar esta librería, consulta la [documentación](https://github.com/Dtopiast/OnionCrafter.Entities.Base/wiki).

## Ejemplo

```csharp
// Definición de una entidad de ejemplo con clave personalizada
public class MiEntidad : BaseEntity<int>
{
    // Propiedades adicionales de la entidad
    public string Nombre { get; set; }
}
```

## Contribuir

Si deseas contribuir a esta librería, ¡te damos la bienvenida! Puedes hacerlo de las siguientes maneras:

1. **Informa problemas:** Si encuentras algún problema o error, por favor, abre un [issue](https://github.com/dtopiast/OnionCrafter.Entities.Baseissues).

2. **Envía Pull Requests:** Si deseas agregar nuevas características o corregir errores existentes, no dudes en enviar un [pull request](https://github.com/dtopiast/OnionCrafter.Entities.Base/pulls).

## Licencia

Este proyecto está bajo la [Licencia Mozilla Public v. 2](LICENSE.txt). Consulta el archivo LICENSE.md para obtener más información.
