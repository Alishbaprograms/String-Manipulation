Module removing_1char_2char

    Sub Main()
        Dim mystr1 As String
        Dim mystr2 As String
        Dim mychar1 As String
        Dim mychar2 As String
        Dim count1 As Integer
        Dim count2 As Integer
        Dim finalstr As String
        Dim str As String


        mystr1 = ""
        mystr2 = ""
        mychar1 = ""
        mychar2 = ""
        count1 = 0
        count2 = 0
        finalstr = ""

        Console.Write("Enter your first string: ")
        mystr1 = Console.ReadLine
        Console.Write("Enter your second string: ")
        mystr2 = Console.ReadLine

        For count1 = 1 To Len(mystr2)
            mychar1 = Mid(mystr2, count1, 1)
            For count2 = 1 To Len(mystr1)
                mychar2 = Mid(mystr1, count2, 1)


                If mychar1 <> mychar2 Then
                    finalstr = finalstr & mychar1

                End If
            Next

        Next
        Console.Write(finalstr)

        Console.ReadLine()

    End Sub

End Module
