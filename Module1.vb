Module Module1

    Sub Main()
        Dim myName As String
        myName = ""

        Dim Counter As Integer
        Counter = 0

        For Counter = 1 To 3
            Console.Write("Enter the name: ")
            myName = Console.ReadLine
            Console.WriteLine(myName)
        Next
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()



    End Sub

End Module
