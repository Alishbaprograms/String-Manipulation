Module Module1

    Sub Main()
        Dim entstr As String
        Dim vowels As String
        Dim nextchar As String
        Dim count As Integer
        Dim nextvowel As String
        Dim vowelcounter As Integer
        Dim count2 As Integer

        entstr = ""
        nextchar = ""
        vowels = "AEIOU"
        nextvowel = ""
        vowelcounter = 0
        count = 0
        Console.Write("Enter your string: ")
        entstr = Console.ReadLine
        entstr = UCase(entstr)

        For count = 1 To Len(vowels)
            nextvowel = Mid(vowels, count, 1)


            For count2 = 1 To Len(entstr)
                nextchar = Mid(entstr, count2, 1)


                If nextchar = nextvowel Then
                    vowelcounter = vowelcounter + 1

                End If
            Next
        Next
        Console.WriteLine("Total vowels : " & vowelcounter)



        Console.ReadKey()


    End Sub

End Module
