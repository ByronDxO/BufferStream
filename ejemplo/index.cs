using System;

namespace BufferOverflowExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamada al método que demostrará el desbordamiento de búfer
            UnsafeBufferOverflowExample();
        }

        // Método marcado como 'unsafe' para permitir operaciones de puntero
        unsafe static void UnsafeBufferOverflowExample()
        {
            const int bufferSize = 10;
            char* buffer = stackalloc char[bufferSize]; // Reserva un bloque de memoria en la pila

            Console.WriteLine("Ingrese una cadena (máximo 10 caracteres):");
            string input = Console.ReadLine();

            // Bucle que intenta copiar los caracteres de la entrada al buffer
            for (int i = 0; i < input.Length; i++)
            {
                // Aquí es donde puede ocurrir el desbordamiento si input.Length > bufferSize
                buffer[i] = input[i];
            }

            Console.WriteLine("Buffer overflow example completed.");
        }
    }
}
