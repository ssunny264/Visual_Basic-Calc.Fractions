'Sara Sunny
'Homework Number 8
'File Name: H8
'Action: Prompts user to input numbers for fraction to add two fractions together. Displays fractions after reducing by greatest common
'divisor

Option Strict On
Module H8
    'Action: Procedure reads numbers in to begin calculating
    'Parameters:
    '   In: Numerator 1 & 2 and Denominator 1 & 2
    '   Out: None. Just reading numbers in
    'Precondition: Numbers
    Sub InputNumbers(ByRef Numerator1 As Integer, ByRef Denominator1 As Integer, ByRef Numerator2 As Integer, ByRef Denominator2 As Integer)
        Console.WriteLine("This program adds fractions. 'Y' continues, any other key exits program")
        Console.WriteLine("=======================================================================")
        Console.Write("Enter   numerator 1 ==> ")
        Numerator1 = CInt(Console.ReadLine())
        Console.Write("Enter denominator 1 ==> ")
        Denominator1 = CInt(Console.ReadLine())
        Console.WriteLine()
        Console.Write("Enter   numerator 2 ==> ")
        Numerator2 = CInt(Console.ReadLine())
        Console.Write("Enter denominator 2 ==> ")
        Denominator2 = CInt(Console.ReadLine())
    End Sub
    '****************************************************************************************************************************************
    'Action: Procedure adds fractions and reduces down to by dividing by Greatest Common Divisor
    'Parameters:
    '   In: Numbers read from InputNumbers procedure
    '   Out: None. 
    'Precondition: Denominator cannot be 0
    Sub AddFractions(ByRef N1 As Integer, ByRef D1 As Integer, ByRef N2 As Integer, ByRef D2 As Integer, ByRef Numerator As Integer, ByRef Denominator As Integer)
        If (D1 = 0 Or D2 = 0) Then
            Console.WriteLine("Please enter proper denominator ")
            Exit Sub
        End If
        Dim GCD As Integer
        Numerator = (N1 * D2) + (D1 * N2)
        Denominator = D1 * D2

        If (Numerator <= Denominator) Then
            GCD = Numerator
        ElseIf (Denominator < Numerator) Then
            GCD = Denominator
        End If

        While (Numerator Mod GCD <> 0 And Denominator Mod GCD <> 0)
            GCD -= 1
        End While

        Numerator = Numerator \ GCD
        Denominator = Denominator \ GCD
    End Sub
    '*****************************************************************************************************************************************
    'Action: Procedure displays finized numerator and denominator from AddFractions procedure
    'Parameters:
    '   In: AddFraction Numbers
    '   Out: Result of adding two fractions together
    'Precondition: Number
    Sub Display(ByVal N1 As Integer, ByVal D1 As Integer, ByVal N2 As Integer, ByVal D2 As Integer, ByVal Numerator As Integer, ByVal Denominator As Integer)

        Console.WriteLine(" {0}       {1}       {2}", N1, N2, Numerator)
        Console.WriteLine("---  +  ---  =  ---")
        Console.WriteLine(" {0}       {1}       {2}", D1, D2, Denominator)

    End Sub
    Sub Main()
        Dim Num1, Den1, Num2, Den2, Numresult, Denresult As Integer
        Dim Response As Char
        Do
            InputNumbers(Num1, Den1, Num2, Den2)

            AddFractions(Num1, Den1, Num2, Den2, Numresult, Denresult)
            Display(Num1, Den1, Num2, Den2, Numresult, Denresult)
            Console.WriteLine("Continue? Y or N! ==>")
            Response = CChar(Console.ReadLine())
        Loop While (Response = "Y"c)
        Console.ReadLine()
    End Sub
End Module

