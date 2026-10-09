// Se solicitan los datos iniciales.
Console.Write("Introduce el voltaje inicial (V): ");
double voltajeInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce el incremento por ciclo (V): ");
double incremento = Convert.ToDouble(Console.ReadLine());

// Se validan los datos ingresados.
if (voltajeInicial < 0 || incremento <= 0)
{
    Console.WriteLine("Error: el voltaje no puede ser negativo y el incremento debe ser positivo.");
}
else if (voltajeInicial > 12.6)
{
    Console.WriteLine("Error: el voltaje inicial supera el límite de 12.6 V.");
}
else
{
    // OBJETO: se crea una instancia de la clase Bateria.
    Bateria bateria = new Bateria();

    // PROPIEDAD: se asigna el voltaje inicial.
    bateria.Voltaje = voltajeInicial;

    // Se ejecuta el método de carga.
    bateria.Cargar(incremento);
}

// CLASE: representa una batería.
class Bateria
{
    // PROPIEDAD: almacena el voltaje actual en V.
    public double Voltaje { get; set; }

    // MÉTODO: incrementa el voltaje hasta alcanzar 12.6 V.
    public void Cargar(double incremento)
    {
        int ciclo = 0;

        while (Voltaje < 12.6)
        {
            ciclo++;

            // Se incrementa el voltaje en cada ciclo.
            Voltaje += incremento;

            // Se limita el voltaje máximo a 12.6 V.
            if (Voltaje > 12.6)
            {
                Voltaje = 12.6;
            }

            // Se muestran los resultados de cada ciclo.
            Console.WriteLine($"Ciclo: {ciclo}");
            Console.WriteLine($"Voltaje actualizado: {Voltaje:F2} V");
        }

        Console.WriteLine("Batería cargada: 12.60 V");
    }
}