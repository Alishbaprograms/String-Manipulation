Module array

    Sub Main()
        Dim numbers(100) As Integer
        Dim inputstring As String
        Dim nextchar As String
        Dim nextnumberstring As String
        Dim i As Integer
        Dim j As Integer

        Console.WriteLine("String...")
        inputstring = Console.ReadLine
        j = 1
        nextchar = Mid(inputstring, j, 1)

        i = 1
        While nextchar <> "#"
            nextnumberstring = ""
            While nextchar <> "*"
                nextnumberstring = nextnumberstring & nextchar
                j = j + 1
                nextchar = Mid(inputstring, j, 1)
            End While

            numbers(i) = Val(nextnumberstring)
            i = j + 1
            j = j + 1
            nextchar = Mid(inputstring, j, 1)

        End While
        For i = 1 To 10
            Console.WriteLine(numbers(i))
        Next
        Console.ReadKey()
    End Sub

End Module
