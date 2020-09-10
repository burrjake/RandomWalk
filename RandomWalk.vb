Option Strict On
Option Explicit On
Option Compare Text

Module RandomWalk

    Sub Main()
        ' Dim randomNumber As Integer

        ' randomNumber = GetRandomNumber(1, 10)
        'Console.WriteLine(randomNumber)
        'Console.ReadLine()

    End Sub

    Sub RandomExample()
        'Dim value As Integer
        'Dim userInput As String

        'Do While userInput <> "q"
        'For i = 1 To 10
        'Randomize()
        'value = CInt(Int((Rnd() * 6) + 1))
        'Console.WriteLine(value)
        'Next
        'userInput = Console.ReadLine()
        'Console.Clear()
        'Loop
    End Sub

    Function GetRandomNumber(ByVal minimum As Integer, maximum As Integer) As Integer
        Dim value As Integer




        Randomize()
        'value = CInt(Int((Rnd() * 6) + 1))
        value = CInt(maximum * Rnd())
        Console.WriteLine(value)
        Return value
    End Function
End Module
