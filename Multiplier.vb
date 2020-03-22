Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = 0
        b = 0
        c = 0
        Console.WriteLine("Enter the tabe you want to learn: ")
        b = Console.ReadLine
        Console.WriteLine()


        For a = 1 To 10
            c = b * a
            Console.WriteLine(b & "*" & a & "=" & c)

        Next
        Console.ReadLine()

    End Sub

End Module
