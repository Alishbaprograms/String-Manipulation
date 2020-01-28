Module Module1


    Sub LineNumber(ByVal filename As String, ByVal StartNumber As Integer, ByVal stepNumber As Integer)
        
        Dim count As Integer
        Dim fileline As String
        Dim more As String

        filename = ""
        stepNumber = 0
        count = 0
        more = ""

        FileOpen(1, "Myfile.txt", OpenMode.Input)
        Do
            Input(1, fileline)
            Console.WriteLine(StartNumber & ": " & fileline)
            StartNumber = StartNumber + StepNumber
            count = count + 1
            If count = 20 Then
                Console.WriteLine("Do you wish to continue? (y/n)")
                more = Console.ReadLine
                If more = "y" Then
                    count = 0

                End If
            End If
        Loop Until EOF(filename) Or more = "n"
        FileClose(1)

    End Sub


End Module
Sub main()
    Call LineNumber number("Myfile.txt")
End Sub