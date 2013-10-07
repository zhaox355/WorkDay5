﻿Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim x As Double = CDbl(txtSideOne.Text)
        Dim y As Double = CDbl(txtSideTwo.Text)
        Dim z As Double

        z = Hypotenuse(x, y)
        txtHyp.Text = CStr(z)

    End Sub

    Function Hypotenuse(ByVal a As Double, b As Double) As Double

        Return Math.Sqrt(a ^ 2 + b ^ 2)

    End Function

End Class
