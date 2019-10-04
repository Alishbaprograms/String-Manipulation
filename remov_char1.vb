Module remov_char1

    Sub Main()
        Dim rawstr As String
        Dim mystr As String
        Dim unecesschar As Char
        Dim counter As Integer
        Dim finalstr As String
        Dim outstr As String
        Dim uppercase As String

        rawstr = ""
        mystr = ""
        unecesschar = ""
        counter = 0
        finalstr = ""
        outstr = ""
        uppercase = ""

        Console.Write("Enter your string: ")
        rawstr = Console.ReadLine()

        Console.Write("Enter the char u want to remove: ")
        unecesschar = Console.ReadLine

        For counter = 1 To Len(rawstr)
            finalstr = Mid(rawstr, counter, 1)
            If finalstr <> unecesschar Then
                outstr = outstr & finalstr
                uppercase = UCase(outstr)

            End If
        Next
        Console.WriteLine("The final string is  : " & outstr)
        Console.WriteLine("Uppercase of final string is: " & uppercase)



        Console.ReadKey()

    End Sub

End Module
