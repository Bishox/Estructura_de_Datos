using System;
using System.Collections.Generic;

public class Producto
{
    // Propiedades del producto
    public int Id { get; set; }         // Identificador único del producto
    public string Nombre { get; set; }   // Nombre del producto
    public string Unidad { get; set; }   // Unidad de medida (por ejemplo, "kg", "unidad", etc.)
    public List<decimal> Precios { get; set; } // Lista para manejar tres precios

    // Constructor para inicializar el producto
    public Producto(int id, string nombre, string unidad, decimal precio1, decimal precio2, decimal precio3)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = new List<decimal> { precio1, precio2, precio3 };
    }

    // Método para mostrar la información del producto
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Unidad: {Unidad}");
        Console.WriteLine($"Precio de venta al público: {Precios[0]:C}");
        Console.WriteLine($"Precio de venta al distribuidor: {Precios[1]:C}");
        Console.WriteLine($"Precio de venta de oferta: {Precios[2]:C}");
    }
}

class Program
{
    static void Main()
    {
        // Crear un objeto de la clase Producto
        Producto producto1 = new Producto(1, "Arroz", "kg", 30.00m, 26.00m, 22.00m);
        
        // Mostrar la información del producto
        producto1.MostrarInformacion();
    }
}
