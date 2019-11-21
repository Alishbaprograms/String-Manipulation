Module Module1

    Sub Main()
        Dim mystr1 As String
        Dim mychar1 As String
        Dim mychar2 As String
        Dim count As Integer
        Dim count2 As Integer
        Dim counter1 As Integer
        Dim h As Integer
        Dim finalchar As String

        mystr1 = ""
        mychar1 = ""
        mychar2 = ""
        count = 0
        count2 = 0
        finalchar = ""

        Console.WriteLine("Enter your string: ")
        mystr1 = Console.ReadLine

        For count = 1 To Len(mystr1)
            mychar1 = Mid(mystr1, count, 1)
            counter1 = 0

            For count2 = 1 To Len(mystr1)
                mychar2 = Mid(mystr1, count2, 1)
                If mychar1 = mychar2 Then
                    counter1 = counter1 + 1

                End If
            Next
            If counter1 > h Then
                h = counter1
                finalchar = mychar1
            End If
        Next
        Console.WriteLine(finalchar & " is repeated " & h & " times")
        Console.ReadKey()
    End Sub

End Module
