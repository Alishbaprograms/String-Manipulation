Module Module1

    Sub Main()
        Dim binarystring As String
        Dim validBinaryString As Boolean
        Dim nextchar As Char
        Dim binarynum As Integer
        Dim nextnum As Integer
        Dim denarynum As Integer
        Dim count2 As Integer
        Dim worth As String



        binarystring = ""
        validBinaryString = True
        nextchar = ""
        binarynum = 0
        nextnum = 0
        denarynum = 0
        count2 = 0
        worth = "12806403201608040201"




        Console.Write("Enter binary number: ")
        binarystring = Console.ReadLine

        validBinaryString = True
        If Len(binarystring) < 1 And Len(binarystring) > 8 Then
            validBinaryString = False
        End If

        For count = 1 To Len(binarystring)


            nextchar = Mid(binarystring, count, 1)

            If nextchar <> "0" And nextchar <> "1" Then
                validBinaryString = False

            End If
        Next


        If validBinaryString = False Then
            Console.WriteLine("Not a valid binary number...")
        Else
            Console.WriteLine("A valid binary number...")

        End If
        binarynum = Int(binarystring)
       
        For count2 = 1 To Len(binarynum)
            nextnum = nextnum + (Mid(binarynum, Len(binarynum) - count2 + 1, 1) * (2 ^ (count2 - 1)))
        Next

        Console.WriteLine(binarystring & "=" & nextnum)
        Console.ReadKey()


    End Sub

End Module
