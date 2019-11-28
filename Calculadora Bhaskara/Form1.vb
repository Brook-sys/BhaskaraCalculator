Imports System.Math
Public Class Form1
    Dim A As Single
    Dim B As Single
    Dim C As Single
    Dim Deltapt1 As Single
    Dim Deltapt2 As Single
    Dim Delta As Single
    Dim BMais As Single
    Dim Resultado1 As Single
    Dim Resultado2 As Single
    Dim RaizDelta As Single
    Dim DivisaoBhaskara As Single

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If A = "0" Then
            Label7.Text = ("A= ?")
        ElseIf B = "0" Then
            Label6.Text = ("B= ?")
        ElseIf C = "0" Then
            Label5.Text = ("C= ?")
        Else
            Label7.Text = ("A= " & A)
            Label6.Text = ("B= " & B)
            Label5.Text = ("C= " & C)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("É preciso ter todos os valores definidos na equação")

        Else
            A = Val(TextBox1.Text)
            B = Val(TextBox2.Text)
            C = Val(TextBox3.Text)

        End If
        Deltapt1 = (B ^ 2)
        Deltapt2 = (-4 * A * C)
        Delta = (Deltapt1 + Deltapt2)
        Label9.Text = ("Δ=" & Delta)
        RaizDelta = Sqrt(Delta)
        DivisaoBhaskara = (2 * A)
        If A = "0" Then
            MsgBox("O valor do coeficiente A não pode ser igual a zero.")
        ElseIf Deltapt2 < 0 Then
            TextBox4.Text = ("Resolução: Delta" & vbNewLine & "" & vbNewLine & "Δ=(" & B & ")²-4." & A & "." & C & vbNewLine & "" & vbNewLine & "Δ=" & Deltapt1 & Deltapt2 & vbNewLine & "" & vbNewLine & "Δ=" & Delta)
        Else
            TextBox4.Text = ("Resolução: Delta" & vbNewLine & "" & vbNewLine & "Δ=(" & B & ")²-4." & A & "." & C & vbNewLine & "" & vbNewLine & "Δ=" & Deltapt1 & "+" & Deltapt2 & vbNewLine & "" & vbNewLine & "Δ=" & Delta)
        End If
        If Delta < 0 Then
            TextBox5.Text = ("Resolução: Bhaskara" & vbNewLine & "Não tem raiz real pois o resultado de delta é menor que zero.")
        ElseIf B < 0 Then
            Resultado1 = (-B + Sqrt(Delta)) / (2 * A)
            TextBox6.Text = (Resultado1)
            Resultado2 = (-B - Sqrt(Delta)) / (2 * A)
            TextBox7.Text = (Resultado2)
            BMais = B - B - B
            TextBox5.Text = ("Resolução: Bhaskara" & vbNewLine & "" & vbNewLine & "X=-(" & B & ")±√" & Delta & vbNewLine & "     2." & A & vbNewLine & "" & vbNewLine & "X=" & BMais & "±" & RaizDelta & vbNewLine & "   " & DivisaoBhaskara)
        Else
            TextBox5.Text = ("Resolução: Bhaskara" & vbNewLine & "" & vbNewLine & "X=-(" & B & ")±√" & Delta & vbNewLine & "     2." & A & vbNewLine & "" & vbNewLine & "X=-" & B & "±" & RaizDelta & vbNewLine & "    " & DivisaoBhaskara)
            Resultado1 = (-B + Sqrt(Delta)) / (2 * A)
            TextBox6.Text = (Resultado1)
            Resultado2 = (-B - Sqrt(Delta)) / (2 * A)
            TextBox7.Text = (Resultado2)
        End If
    End Sub

End Class
