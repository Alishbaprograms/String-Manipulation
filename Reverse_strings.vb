Module Reverse_strings

    Sub Main()
        Dim mystr As String
        Dim reverse As String
        Dim mychar As Char
        Dim count As Integer


        mystr = ""
        reverse = ""
        mychar = ""
        count = 0


        Console.WriteLine("Enter the value you wish to revese:")
        mystr = Console.ReadLine()

        For count = Len(mystr) To 1 Step -1
            mychar = Mid(mystr, count)
            reverse = reverse & mychar

        Next
        Console.WriteLine(reverse)
        Console.ReadKey()



    End Sub

End Module
