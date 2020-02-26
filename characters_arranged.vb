Module Module1

    Sub Main()
        Call character("*")
        Console.ReadKey()


    End Sub
    Sub character(ByVal inputchar As String)
        Dim count As Integer
        Dim count2 As Integer
        Dim count3 As Integer
        Dim count4 As Integer

        Console.WriteLine("Input character: ")
        inputchar = Console.ReadLine
        Do
            Console.Write(inputchar)
            count = count + 1

        Loop Until count = 8
        Console.WriteLine()
        Console.Write(" ")

        Do
            Console.Write(inputchar)
            count2 = count2 + 1
        Loop Until count2 = 6

        Console.WriteLine()
        Console.Write("  ")

        Do
            Console.Write(inputchar)
            count3 = count3 + 1
        Loop Until count3 = 4

        Console.WriteLine()
        Console.Write("   ")

        Do
            Console.Write(inputchar)
            count4 = count4 + 1
        Loop Until count4 = 2

        Console.ReadKey()
    End Sub
End Module
