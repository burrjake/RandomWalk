Option Strict On
Option Explicit On
Option Compare Text

Module RandomWalk

    Sub Main()
        Dim value As Integer
        Dim userInput As String

        Do While userInput <> "q"
            For i = 1 To 10
                Randomize()
                value = CInt(Int((Rnd() * 6) + 1))
                Console.WriteLine(value)
            Next
            userInput = Console.ReadLine()
            Console.Clear()
        Loop
    End Sub

End Module
