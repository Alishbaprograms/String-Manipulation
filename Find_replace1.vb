Module Find_replace1

    Sub Main()
        Dim entstr As String
        Dim rawchar1 As Char
        Dim rawchar2 As Char
        Dim finalstr As String
        Dim count As Integer
        Dim mychar As Char

        entstr = ""
        rawchar1 = ""
        rawchar2 = ""
        finalstr = ""
        count = 0
        mychar = ""

        Console.Write("Enter your string: ")
        entstr = Console.ReadLine

        Console.Write("Enter the string you want to remove: ")
        rawchar1 = Console.ReadLine

        Console.Write("Enter the character you want to replace it with: ")
        rawchar2 = Console.ReadLine

        For count = 1 To Len(entstr)
            mychar = Mid(entstr, count, 1)
            If mychar <> rawchar1 Then
                finalstr = finalstr & mychar
            Else
                mychar = rawchar2
                finalstr = finalstr & mychar

            End If
        Next

        Console.Write("Final string is: " & finalstr)
        Console.ReadKey()

    End Sub

End Module
