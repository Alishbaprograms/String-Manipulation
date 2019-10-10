Module anagram

    Sub Main()
        Dim rawstrA As String
        Dim rawstrB As String
        Dim count1 As Integer
        Dim count2 As Integer
        Dim sumofA As Integer
        Dim sumofB As Integer
        Dim nextcharA As String
        Dim nextcharB As String
        Dim ascii As Integer
        Dim ascii2 As Integer
        rawstrA = ""
        rawstrB = ""
        count1 = 0
        count2 = 0
        sumofA = 0
        sumofB = 0
        nextcharA = ""
        nextcharB = ""
        ascii = 0
        ascii2 = 0

        Console.Write("Enter the first string : ")
        rawstrA = Console.ReadLine

        Console.Write("Enter your second string: ")
        rawstrB = Console.ReadLine
        For count1 = 1 To Len(rawstrA)
            nextcharA = Mid(rawstrA, count1, 1)
            ascii2 = Asc(nextcharA)
            sumofA = sumofA + ascii2

        Next
        For count2 = 1 To Len(rawstrB)
            nextcharB = Mid(rawstrB, count2, 1)
            ascii = Asc(nextcharB)
            sumofB = sumofB + ascii
        Next
        If sumofA = sumofB Then
            Console.WriteLine(" This is anagram")
        Else
            Console.WriteLine("this is not an anagram")
        End If
        Console.WriteLine("Ascii of first string is: " & sumofA)
        Console.WriteLine("Ascii of second string : " & sumofB)
        Console.ReadKey()



    End Sub

End Module
