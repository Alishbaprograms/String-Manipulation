Module Module1

    Sub Main()
        Dim rawstr As String
        Dim count As Integer
        Dim midwrd As String
        Dim space As Integer
        Dim space2 As Integer

        rawstr = ""
        count = 0
        midwrd = ""
        space = 0
        space2 = 0


        Console.Write("enter your string: ")
        rawstr = Console.ReadLine

        For count = 1 To Len(rawstr)
            space = InStr(rawstr, " ")
            space2 = InStr(space, rawstr, " ")

            midwrd = Mid(rawstr, space + 1, space2)

        Next

        Console.WriteLine("The middle word is: " & midwrd)
        Console.ReadKey()

    End Sub

End Module
