Module Sort_num_char_sym

    Sub Main()
        Dim rawstr As String
        Dim mystr As String
        Dim num As String
        Dim sym As String
        Dim count As Integer
        Dim salpha As String
        Dim CAPSALPHA As String

        rawstr = ""
        mystr = ""
        num = ""
        sym = ""
        CAPSALPHA = ""
        salpha = ""


        Console.Write("Enter you value: ")
        rawstr = Console.ReadLine()

        For count = 1 To Len(rawstr)
            mystr = Mid(rawstr, count, 1)

            If Asc(mystr) >= 48 And
                Asc(mystr) <= 57 Then
                num = num & mystr
            End If
        Next

        Console.WriteLine("The numbers in your string are: " & num)

        For count = 1 To Len(rawstr)
            mystr = Mid(rawstr, count, 1)
            If Asc(mystr) >= 65 And
                Asc(mystr) <= 90 Then
                CAPSALPHA = CAPSALPHA & mystr

            End If
        Next
        Console.WriteLine("The CAPITAL LETTERS IN YOUR STRINGS ARE: " & CAPSALPHA)


        For count = 1 To Len(rawstr)
            mystr = Mid(rawstr, count, 1)
            If Asc(mystr) >= 97 And
                Asc(mystr) <= 122 Then
                salpha = salpha & mystr


                Console.WriteLine("Small letters in your string is: " & salpha)

            Else
                If mystr <> CAPSALPHA And
                   mystr <> num Then

                    sym = sym & mystr

                End If
            End If
        Next


        Console.WriteLine("The symbols in ur string are: " & sym)
        Console.ReadKey()

    End Sub

End Module
