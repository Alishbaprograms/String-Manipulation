Module Module1

    Sub Main()
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim e As Double
        Dim f As Double
        Dim g As Double
        Dim h As Double
        Dim i As Double
        Dim j As Double
        Dim k As Double
        Dim l As Double




        Console.Write("Enter ax^2= ")
        a = Console.ReadLine
        Console.Write("Enter bx= ")
        b = Console.ReadLine
        Console.Write("Enter c = ")
        c = Console.ReadLine
        l = 2 * a
        d = ((b ^ 2) - (4 * a * c))
        e = (d) ^ (1 / 2)
        f = e - b
        g = f / l

        h = ((b ^ 2) - (4 * a * c))
        i = (h) ^ (1 / 2)
        j = -b - i
        k = j / l
        Console.WriteLine("the value of x= " & g & " or x = " & k)


        Console.ReadKey()
    End Sub

End Module
