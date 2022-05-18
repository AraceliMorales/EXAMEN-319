// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
let suma a b = a + b
let resta a b = a - b
let multi a b = a * b
let divi a b = a / b
[<EntryPoint>]
let main calculadora = 
    Console.WriteLine("INTRODUZCA 2 NUMEROS: ")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let valor3 = suma valor1 valor2
    let valor4 = resta valor1 valor2
    let valor5 = multi valor1 valor2
    let valor6 = divi valor1 valor2 
    Console.WriteLine("La suma es: " + valor3.ToString())
    Console.WriteLine("La resta es: " + valor4.ToString())
    Console.WriteLine("La multiplicacion es: " + valor5.ToString())
    Console.WriteLine("La division es: " + valor6.ToString())
    printfn "%d" valor6

    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
