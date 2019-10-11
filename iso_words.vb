Module iso_words

    Sub Main()
        Dim rawstr As String
        Dim firstword As String
        Dim midword As String
        Dim finalword As String
        Dim count As Integer
        Dim space As Integer
        Dim space2 As Integer

        rawstr = ""
        firstword = ""
        midword = ""
        finalword = ""
        count = 0
        space = 0
        space2 = 0

        Console.Write("Enter the string: ")
        rawstr = Console.ReadLine

        space = InStr(rawstr, " ")

        firstword = Left(rawstr, space - 1)
        space2 = InStr(space, rawstr, " ")

        midword = Mid(rawstr, space + 1, space2 - 1)


        finalword = Right(rawstr, space2 + 1)
        Console.WriteLine(firstword)

        Console.WriteLine(midword)
        Console.WriteLine(finalword)


        Console.ReadKey()


    End Sub

End Module
