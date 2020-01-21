Module Module1

    Sub Main()
        Dim mtotal As Integer
        Dim name As String
        Dim Id As Integer
        Dim telenum As Integer
        Dim Isfound As Boolean
        Dim more As String

        mtotal = 0
        Id = 0
        telenum = 0
        Isfound = False
        name = ""
        more = ""

        FileOpen(1, "MemberShip.txt", OpenMode.Output)

        Do
            WriteLine(1, name)
            WriteLine(1, Id)

            Console.Write("Enter name: ")
            name = Console.ReadLine

            Console.Write("Enter ID: ")
            Id = Console.ReadLine


            Console.WriteLine("Do u want to do it again? ")
            more = Console.ReadLine

        Loop Until more = "n" Or more = "N" Or more = "No" Or more = "no" Or more = "NO"
        FileClose()

        Console.ReadKey()
    End Sub

End Module
