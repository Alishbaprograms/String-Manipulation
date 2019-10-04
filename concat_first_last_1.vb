Module concat_first_last_1

    Sub Main()
        Dim mystr1 As String
        Dim mystr2 As String
        Dim length As Integer
        Dim space As Integer
        Dim firstword As String
        Dim secondword As String

        mystr1 = ""
        mystr2 = ""
        length = 0
        space = 0
        firstword = ""
        secondword = ""



        Console.Write("Enter the string: ")
        mystr1 = Console.ReadLine

        Console.Write("Enter second string: ")
        mystr2 = Console.ReadLine

        space = InStr(mystr1, " ")
        firstword = Left(mystr1, space - 1)
        Console.WriteLine("Your first word is: " & firstword)

        space = InStr(mystr2, " ")
        length = Len(mystr2)
        secondword = Right(mystr2, length - space)


        Console.WriteLine("Your second word is: " & secondword)

        Console.WriteLine("Your final string is: " & firstword & " " & secondword)


        Console.ReadKey()

    End Sub

End Module
