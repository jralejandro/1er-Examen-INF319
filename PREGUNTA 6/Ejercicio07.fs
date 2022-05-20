// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = a / b 

[<EntryPoint>]
let main argumetos = 
    //printfn "%A" argv
    Console.WriteLine("Introduzca dos Numeros")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    
    let val1 = Convert.ToInt32(num1)
    let val2 = Convert.ToInt32(num2)

    let valsuma = suma val1 val2
    let valresta = resta val1 val2
    let valmultiplicacion = multiplicacion val1 val2
    let valdivision = division val1 val2

    Console.WriteLine("La suma es: "+valsuma.ToString())
    Console.WriteLine("La resta es: "+valresta.ToString())
    Console.WriteLine("La multiplicacion es: "+valmultiplicacion.ToString())
    Console.WriteLine("La division es: "+valdivision.ToString())

    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
