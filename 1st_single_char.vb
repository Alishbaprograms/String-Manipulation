Module Module1

    Sub Main()
        Dim mystr1 As String
        Dim mychar1 As String
        Dim mychar2 As String
        Dim count As Integer
        Dim count2 As Integer
        Dim finalchar As String
        Dim counter As Integer

        mystr1 = ""
        mychar1 = ""
        mychar2 = ""
        count = 0
        count2 = 0
        finalchar = ""
        counter = 0

        Console.Write("Enter your string: ")
        mystr1 = Console.ReadLine

        For count = 1 To Len(mystr1)
            mychar1 = Mid(mystr1, count, 1)
            counter = 0

            For count2 = 1 To Len(mystr1)
                mychar2 = Mid(mystr1, count2, 1)


                If mychar1 = mychar2 Then
                    counter = counter + 1



                End If
            Next
            If counter = 1 Then
                finalchar = mychar1
                Exit For
            End If
        Next
        Console.Write("Your first non-repeated character is: " & finalchar)
        Console.ReadLine()



    End Sub

End Module
