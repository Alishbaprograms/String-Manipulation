Module Module1

    Sub Main()

        Dim binarystring As String
        Dim validBinaryString As Boolean
        Dim nextchar As Char
        Dim binarynum As Integer
        Dim nextnum As Integer
        Dim denarynum As Integer
        Dim space As String
        Dim count2 As Integer
        Dim worth As String
        Dim nextnum2 As String


        binarystring = ""
        validBinaryString = True
        nextchar = ""
        binarynum = 0
        nextnum = 0
        denarynum = 0
        space = 0
        count2 = 0
        worth = "128064032016080402021"




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
        For count2 = 1 To Len(worth)
            nextnum = Left(worth, 1)

            If nextnum < "1" And nextchar > "128" Then
                nextnum = Int(nextnum)
                nextnum2 = nextnum + 1
                nextnum2=nextnum2+nextnum




            End If
        nextnum2 = "0"
        Next
        Console.Write(nextnum)















        Console.ReadKey()









    End Sub

End Module
