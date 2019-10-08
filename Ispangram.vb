Module Ispangram

    Sub Main()
        Dim s1 As String
        Dim nextchar As String
        Dim count As Integer
        Dim alphaset As String
        Dim Ispangram As Boolean

        s1 = ""
        nextchar = ""
        count = 0
        alphaset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Ispangram = True

        Console.WriteLine("Enter you string: ")
        s1 = Console.ReadLine
        s1 = UCase(s1)


        For count = 1 To Len(alphaset)
            nextchar = Mid(alphaset, count, 1)
            If InStr(s1, nextchar) = 0 Then
                Ispangram = False
                Exit For
            End If
        Next
        If Ispangram = True Then
            Console.Write("This is a pangram")
        Else
            Console.Write("This is not a pangram")


        End If
        Console.ReadKey()






    End Sub

End Module
