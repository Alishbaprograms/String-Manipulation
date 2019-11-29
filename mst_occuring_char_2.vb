Module mst_occuring_char_2

    Sub Main()
        Dim mystr1 As String
        Dim mychar1 As String
        Dim mychar2 As String
        Dim count As Integer
        Dim count2 As Integer
        Dim counter1 As Integer
        Dim h As Integer
        Dim finalchar As String
        Dim Isemptystr As Boolean
        Dim norepeatedchar As Boolean

        mystr1 = ""
        mychar1 = ""
        mychar2 = ""
        count = 0
        count2 = 0
        finalchar = ""
        Isemptystr = False
        norepeatedchar = False


        Console.WriteLine("Enter your string: ")
        mystr1 = Console.ReadLine

        If Len(mystr1) = 0 Then
            Isemptystr = True


        End If

        For count = 1 To Len(mystr1)
            mychar1 = Mid(mystr1, count, 1)
            counter1 = 0

            For count2 = 1 To Len(mystr1)
                mychar2 = Mid(mystr1, count2, 1)
                If mychar1 = mychar2 Then
                    counter1 = counter1 + 1

                End If
            Next


            If counter1 > h And norepeatedchar = False Then
                h = counter1
                finalchar = mychar1

            End If
        Next
        If Isemptystr = True Then
            Console.WriteLine("you have an empty string")

        Else

            Console.WriteLine(finalchar & " is repeated " & h & " times")

        End If
        If h = 1 Then
            norepeatedchar = True
            Console.WriteLine("no repeatedchar")
        End If


        Console.ReadKey()

    End Sub

End Module
