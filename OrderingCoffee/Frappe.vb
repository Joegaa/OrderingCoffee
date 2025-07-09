Imports System.Text.RegularExpressions

Public Class Frappe

    Const NotCoffee As Double = 45
    Const LargeNot As Double = 55
    Const CoffeeAndPremium As Double = 55
    Const LargeCoffeeAndPrem As Double = 65

    Dim Matcha As Double
    Dim Avocado As Double
    Dim Taro As Double
    Dim Mango As Double
    Dim RedVelvet As Double
    Dim RockyRoad As Double
    Dim DoubleDutch As Double
    Dim ChocoBerry As Double
    Dim DarkCaramel As Double
    Dim DarkCappuccino As Double
    Dim DarkMocha As Double
    Dim JavaChip As Double
    Dim CookiesnCream As Double
    Dim MangoGraham As Double

    Dim TotalFrappe As Double






    Private Sub Premium_Click(sender As Object, e As EventArgs) Handles Premium.Click

        Dim centerX As Integer = (Me.Width - PremiumBox.Width) \ 2
        Dim centerY As Integer = (Me.Height - PremiumBox.Height) \ 2 + 12

        PremiumBox.Location = New Point(centerX, centerY)



        PremiumBox.Controls.Add(LargeSizeBox)
        PremiumBox.Controls.Add(AddOrderButton)


        NonCoffee.Enabled = Not NonCoffee.Enabled



        PremiumBox.Visible = Not PremiumBox.Visible

        CoffeeBase.Enabled = Not CoffeeBase.Enabled

    End Sub

    Private Sub MinusCookie_Click(sender As Object, e As EventArgs) Handles MinusCookie.Click

        Cookies.Text -= 1

        If Cookies.Text <= 0 Then

            Cookies.Text = 0

        End If

    End Sub

    Private Sub PlusCookie_Click(sender As Object, e As EventArgs) Handles PlusCookie.Click

        Cookies.Text += 1

    End Sub

    Private Sub NonCoffee_Click(sender As Object, e As EventArgs) Handles NonCoffee.Click



        Dim centerX As Integer = (Me.Width - Notcoffeebox.Width) \ 2
        Dim centerY As Integer = (Me.Height - Notcoffeebox.Height) \ 2 + 12



        Notcoffeebox.Location = New Point(centerX, centerY)

        Notcoffeebox.Controls.Add(LargeSizeBox)
        Notcoffeebox.Controls.Add(AddOrderButton)

        Premium.Enabled = Not Premium.Enabled


        Notcoffeebox.Visible = Not Notcoffeebox.Visible

        CoffeeBase.Enabled = Not CoffeeBase.Enabled


    End Sub

    Private Sub MinusMango_Click(sender As Object, e As EventArgs) Handles MinusMango.Click

        MangoT.Text -= 1

        If MangoT.Text <= 0 Then

            MangoT.Text = 0

        End If

    End Sub

    Private Sub PlusMango_Click(sender As Object, e As EventArgs) Handles PlusMango.Click

        MangoT.Text += 1

    End Sub

    Private Sub MinusMangoGrah_Click(sender As Object, e As EventArgs) Handles MinusMangoGrah.Click

        MangoGT.Text -= 1

        If MangoGT.Text <= 0 Then

            MangoGT.Text = 0

        End If

    End Sub

    Private Sub PlusMangoGrah_Click(sender As Object, e As EventArgs) Handles PlusMangoGrah.Click

        MangoGT.Text += 1


    End Sub

    Private Sub MinusAvocado_Click(sender As Object, e As EventArgs) Handles MinusAvocado.Click

        AvoT.Text -= 1

        If AvoT.Text <= 0 Then

            AvoT.Text = 0

        End If

    End Sub

    Private Sub PlusAvocado_Click(sender As Object, e As EventArgs) Handles PlusAvocado.Click

        AvoT.Text += 1

    End Sub

    Private Sub MinusTaro_Click(sender As Object, e As EventArgs) Handles MinusTaro.Click

        TaroT.Text -= 1

        If TaroT.Text <= 0 Then

            TaroT.Text = 0

        End If

    End Sub

    Private Sub PlusTaro_Click(sender As Object, e As EventArgs) Handles PlusTaro.Click

        TaroT.Text += 1

    End Sub

    Private Sub MinusRed_Click(sender As Object, e As EventArgs) Handles MinusRed.Click

        RedT.Text -= 1

        If RedT.Text <= 0 Then

            RedT.Text = 0

        End If

    End Sub

    Private Sub PlusRed_Click(sender As Object, e As EventArgs) Handles PlusRed.Click

        RedT.Text += 1

    End Sub

    Private Sub MinusDouble_Click(sender As Object, e As EventArgs) Handles MinusDouble.Click

        DoubleT.Text -= 1

        If DoubleT.Text <= 0 Then

            DoubleT.Text = 0

        End If

    End Sub

    Private Sub PlusDouble_Click(sender As Object, e As EventArgs) Handles PlusDouble.Click

        DoubleT.Text += 1

    End Sub

    Private Sub MinusChoco_Click(sender As Object, e As EventArgs) Handles MinusChoco.Click

        DarkT.Text -= 1

        If DarkT.Text <= 0 Then

            DarkT.Text = 0

        End If

    End Sub

    Private Sub PlusChoco_Click(sender As Object, e As EventArgs) Handles PlusChoco.Click

        DarkT.Text += 1

    End Sub

    Private Sub MinusRock_Click(sender As Object, e As EventArgs) Handles MinusRock.Click

        RockyT.Text -= 1

        If RockyT.Text <= 0 Then

            RockyT.Text = 0

        End If

    End Sub

    Private Sub PlusRock_Click(sender As Object, e As EventArgs) Handles PlusRock.Click

        RockyT.Text += 1

    End Sub

    Private Sub CoffeeBase_Click(sender As Object, e As EventArgs) Handles CoffeeBase.Click

        Dim centerX As Integer = (Me.Width - CoffeeBox.Width) \ 2
        Dim centerY As Integer = (Me.Height - CoffeeBox.Height) \ 2 + 12

        CoffeeBox.Location = New Point(centerX, centerY)

        Premium.Enabled = Not Premium.Enabled

        CoffeeBox.Location = New Point(centerX, centerY)

        CoffeeBox.Visible = Not CoffeeBox.Visible

        NonCoffee.Enabled = Not NonCoffee.Enabled

        CoffeeBox.Controls.Add(LargeSizeBox)
        CoffeeBox.Controls.Add(AddOrderButton)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MinusDarkCara.Click

        DarkCT.Text -= 1

        If DarkCT.Text <= 0 Then

            DarkCT.Text = 0

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlusDarkCara.Click

        DarkCT.Text += 1

    End Sub

    Private Sub MinusDarkCappu_Click(sender As Object, e As EventArgs) Handles MinusDarkCappu.Click

        DarkCaT.Text -= 1

        If DarkCaT.Text <= 0 Then

            DarkCaT.Text = 0

        End If

    End Sub

    Private Sub PlusDarkCappu_Click(sender As Object, e As EventArgs) Handles PlusDarkCappu.Click

        DarkCaT.Text += 1

    End Sub

    Private Sub MinusDarkMocha_Click(sender As Object, e As EventArgs) Handles MinusDarkMocha.Click

        DarkMT.Text -= 1

        If DarkMT.Text <= 0 Then

            DarkMT.Text = 0

        End If

    End Sub

    Private Sub PlusDarkMocha_Click(sender As Object, e As EventArgs) Handles PlusDarkMocha.Click

        DarkMT.Text += 1

    End Sub

    Private Sub MinusJavaChip_Click(sender As Object, e As EventArgs) Handles MinusJavaChip.Click

        JavaCT.Text -= 1

        If JavaCT.Text <= 0 Then

            JavaCT.Text = 0

        End If

    End Sub

    Private Sub PlusJavaChip_Click(sender As Object, e As EventArgs) Handles PlusJavaChip.Click

        JavaCT.Text += 1

    End Sub

    Private Sub MinusMatcha_Click(sender As Object, e As EventArgs) Handles MinusMatcha.Click

        MatchaT.Text -= 1

        If MatchaT.Text <= 0 Then

            MatchaT.Text = 0

        End If

    End Sub

    Private Sub PlusMatcha_Click(sender As Object, e As EventArgs) Handles PlusMatcha.Click

        MatchaT.Text += 1

    End Sub

    Private Sub LargeSizeBox_CheckedChanged(sender As Object, e As EventArgs) Handles LargeSizeBox.CheckedChanged



    End Sub

    Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click

        If LargeSizeBox.Checked = False Then

            Matcha = Format(MatchaT.Text * NotCoffee, "0.00")
            Taro = Format(TaroT.Text * NotCoffee, "0.00")
            Mango = Format(MangoT.Text * NotCoffee, "0.00")
            Avocado = Format(AvoT.Text * NotCoffee, "0.00")
            RedVelvet = Format(RedT.Text * NotCoffee, "0.00")
            RockyRoad = Format(RockyT.Text * NotCoffee, "0.00")
            DoubleDutch = Format(DoubleT.Text * NotCoffee, "0.00")
            ChocoBerry = Format(DarkT.Text * NotCoffee, "0.00")

            DarkCaramel = Format(DarkCT.Text * CoffeeAndPremium, "0.00")
            DarkCappuccino = Format(DarkCaT.Text * CoffeeAndPremium, "0.00")
            DarkMocha = Format(DarkMT.Text * CoffeeAndPremium, "0.00")
            JavaChip = Format(JavaCT.Text * CoffeeAndPremium, "0.00")

            CookiesnCream = Format(Cookies.Text * CoffeeAndPremium, "0.00")
            MangoGraham = Format(MangoGT.Text * CoffeeAndPremium, "0.00")

        ElseIf LargeSizeBox.Checked = True Then

            Matcha = Format(MatchaT.Text * LargeNot, "0.00")
            Taro = Format(TaroT.Text * LargeNot, "0.00")
            Mango = Format(MangoT.Text * LargeNot, "0.00")
            Avocado = Format(AvoT.Text * LargeNot, "0.00")
            RedVelvet = Format(RedT.Text * LargeNot, "0.00")
            RockyRoad = Format(RockyT.Text * LargeNot, "0.00")
            DoubleDutch = Format(DoubleT.Text * LargeNot, "0.00")
            ChocoBerry = Format(DarkT.Text * LargeNot, "0.00")

            DarkCaramel = Format(DarkCT.Text * LargeCoffeeAndPrem, "0.00")
            DarkCappuccino = Format(DarkCaT.Text * LargeCoffeeAndPrem, "0.00")
            DarkMocha = Format(DarkMT.Text * LargeCoffeeAndPrem, "0.00")
            JavaChip = Format(JavaCT.Text * LargeCoffeeAndPrem, "0.00")

            CookiesnCream = Format(Cookies.Text * LargeCoffeeAndPrem, "0.00")
            MangoGraham = Format(MangoGT.Text * LargeCoffeeAndPrem, "0.00")


        End If


        Dim orderDetails As String = $"Frappe Order Details:" & vbCrLf &
                             $"Matcha: {Matcha}" & vbCrLf &
                             $"Taro: {Taro}" & vbCrLf &
                             $"Mango: {Mango}" & vbCrLf &
                             $"Avocado: {Avocado}" & vbCrLf &
                             $"Red Velvet: {RedVelvet}" & vbCrLf &
                             $"Rocky Road: {RockyRoad}" & vbCrLf &
                             $"Double Dutch: {DoubleDutch}" & vbCrLf &
                             $"Choco Berry: {ChocoBerry}" & vbCrLf &
                             $"Dark Caramel: {DarkCaramel}" & vbCrLf &
                             $"Dark Cappuccino: {DarkCappuccino}" & vbCrLf &
                             $"Dark Mocha: {DarkMocha}" & vbCrLf &
                             $"Java Chip: {JavaChip}" & vbCrLf &
                             $"Cookies and Cream: {CookiesnCream}" & vbCrLf &
                             $"Mango Graham: {MangoGraham}" & vbCrLf
        Dim form1Instance As Form1 = CType(Application.OpenForms("Form1"), Form1)
        form1Instance.OrderDetails += orderDetails


        MatchaT.Text = "0"
        TaroT.Text = "0"
        AvoT.Text = "0"
        RedT.Text = "0"
        MangoT.Text = "0"
        RockyT.Text = "0"
        DoubleT.Text = "0"
        DarkT.Text = "0"
        DarkCT.Text = "0"
        DarkCaT.Text = "0"
        DarkMT.Text = "0"
        JavaCT.Text = "0"
        Cookies.Text = "0"
        MangoGT.Text = "0"

        TotalFrappe = Matcha + Taro + Mango + Avocado + RedVelvet + RockyRoad + DoubleDutch + ChocoBerry + DarkCappuccino + DarkCaramel + DarkMocha + JavaChip + CookiesnCream + MangoGraham

        Form1.UpdateTotal(TotalFrappe)





        LargeSizeBox.Checked = False
    End Sub
End Class