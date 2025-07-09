Public Class ColdBrew

    Const Cold As Double = 45
    Const LargeCold As Double = 55

    Dim Americano As Double
    Dim SpanishLat As Double
    Dim MochaLatte As Double
    Dim JavaLatte As Double
    Dim CappuccinoLat As Double
    Dim MatchaLatte As Double
    Dim Caramel As Double
    Dim Chocolate As Double
    Dim WhiteMoc As Double
    Dim SaltedCara As Double

    Dim ColdBrew As Double

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PlusAme_Click(sender As Object, e As EventArgs) Handles PlusAme.Click

        IcedAme.Text += 1

    End Sub

    Private Sub MinusAme_Click(sender As Object, e As EventArgs) Handles MinusAme.Click

        IcedAme.Text -= 1

        If IcedAme.Text <= 0 Then

            IcedAme.Text = 0

        End If

    End Sub

    Private Sub MinusSpan_Click(sender As Object, e As EventArgs) Handles MinusSpan.Click

        Spanish.Text -= 1

        If Spanish.Text <= 0 Then

            Spanish.Text = 0

        End If

    End Sub

    Private Sub PlusSpan_Click(sender As Object, e As EventArgs) Handles PlusSpan.Click

        Spanish.Text += 1

    End Sub

    Private Sub MinusMoc_Click(sender As Object, e As EventArgs) Handles MinusMoc.Click

        MochaLat.Text -= 1

        If MochaLat.Text <= 0 Then

            MochaLat.Text = 0

        End If

    End Sub

    Private Sub PlusMoc_Click(sender As Object, e As EventArgs) Handles PlusMoc.Click

        MochaLat.Text += 1

    End Sub

    Private Sub MinusJava_Click(sender As Object, e As EventArgs) Handles MinusJava.Click

        Javalat.Text -= 1

        If Javalat.Text <= 0 Then

            Javalat.Text = 0

        End If

    End Sub

    Private Sub PlusJava_Click(sender As Object, e As EventArgs) Handles PlusJava.Click

        Javalat.Text += 1

    End Sub

    Private Sub MinusCap_Click(sender As Object, e As EventArgs) Handles MinusCap.Click

        CappuLat.Text -= 1

        If CappuLat.Text <= 0 Then

            CappuLat.Text = 0

        End If

    End Sub

    Private Sub PlusCap_Click(sender As Object, e As EventArgs) Handles PlusCap.Click

        CappuLat.Text += 1

    End Sub

    Private Sub MinusMat_Click(sender As Object, e As EventArgs) Handles MinusMat.Click

        MatchaLat.Text -= 1

        If MatchaLat.Text <= 0 Then

            MatchaLat.Text = 0

        End If

    End Sub

    Private Sub PlusMat_Click(sender As Object, e As EventArgs) Handles PlusMat.Click

        MatchaLat.Text += 1

    End Sub

    Private Sub MinusCara_Click(sender As Object, e As EventArgs) Handles MinusCara.Click

        CaramelMac.Text -= 1

        If CaramelMac.Text <= 0 Then

            CaramelMac.Text = 0

        End If

    End Sub

    Private Sub PlusCara_Click(sender As Object, e As EventArgs) Handles PlusCara.Click

        CaramelMac.Text += 1

    End Sub

    Private Sub MinusIced_Click(sender As Object, e As EventArgs) Handles MinusIced.Click

        IcedChoco.Text -= 1

        If IcedChoco.Text <= 0 Then

            IcedChoco.Text = 0

        End If

    End Sub

    Private Sub PlusIced_Click(sender As Object, e As EventArgs) Handles PlusIced.Click

        IcedChoco.Text += 1

    End Sub

    Private Sub MinusWhite_Click(sender As Object, e As EventArgs) Handles MinusWhite.Click

        WhiteMocha.Text -= 1

        If WhiteMocha.Text <= 0 Then

            WhiteMocha.Text = 0

        End If

    End Sub

    Private Sub PlusWhite_Click(sender As Object, e As EventArgs) Handles PlusWhite.Click

        WhiteMocha.Text += 1

    End Sub

    Private Sub MinusSalt_Click(sender As Object, e As EventArgs) Handles MinusSalt.Click

        SaltedLat.Text -= 1

        If SaltedLat.Text <= 0 Then

            SaltedLat.Text = 0

        End If

    End Sub

    Private Sub PlusSalt_Click(sender As Object, e As EventArgs) Handles PlusSalt.Click

        SaltedLat.Text += 1

    End Sub

    Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click

        If LargeSizeBox.Checked = False Then

            Americano = Format(IcedAme.Text * Cold, "0.00")
            SpanishLat = Format(Spanish.Text * Cold, "0.00")
            JavaLatte = Format(Javalat.Text * Cold, "0.00")
            MochaLatte = Format(MochaLat.Text * Cold, "0.00")
            CappuccinoLat = Format(CappuLat.Text * Cold, "0.00")
            MatchaLatte = Format(MatchaLat.Text * Cold, "0.00")
            Caramel = Format(CaramelMac.Text * Cold, "0.00")
            Chocolate = Format(IcedChoco.Text * Cold, "0.00")
            WhiteMoc = Format(WhiteMocha.Text * Cold, "0.00")
            SaltedCara = Format(SaltedLat.Text * Cold, "0.00")

        ElseIf LargeSizeBox.Checked = True Then

            Americano = Format(IcedAme.Text * LargeCold, "0.00")
            SpanishLat = Format(Spanish.Text * LargeCold, "0.00")
            JavaLatte = Format(Javalat.Text * LargeCold, "0.00")
            MochaLatte = Format(MochaLat.Text * LargeCold, "0.00")
            CappuccinoLat = Format(CappuLat.Text * LargeCold, "0.00")
            MatchaLatte = Format(MatchaLat.Text * LargeCold, "0.00")
            Caramel = Format(CaramelMac.Text * LargeCold, "0.00")
            Chocolate = Format(IcedChoco.Text * LargeCold, "0.00")
            WhiteMoc = Format(WhiteMocha.Text * LargeCold, "0.00")
            SaltedCara = Format(SaltedLat.Text * LargeCold, "0.00")

        End If

        Dim orderDetails As String = $"Cold Beverage Order Details:" & vbCrLf &
                             $"Americano: {Americano}" & vbCrLf &
                             $"Spanish Latte: {SpanishLat}" & vbCrLf &
                             $"Java Latte: {JavaLatte}" & vbCrLf &
                             $"Mocha Latte: {MochaLatte}" & vbCrLf &
                             $"Cappuccino Latte: {CappuccinoLat}" & vbCrLf &
                             $"Matcha Latte: {MatchaLatte}" & vbCrLf &
                             $"Caramel Macchiato: {Caramel}" & vbCrLf &
                             $"Iced Chocolate: {Chocolate}" & vbCrLf &
                             $"White Mocha: {WhiteMoc}" & vbCrLf &
                             $"Salted Caramel Latte: {SaltedCara}" & vbCrLf

        Dim form1Instance As Form1 = CType(Application.OpenForms("Form1"), Form1)
        form1Instance.OrderDetails += orderDetails


        LargeSizeBox.Checked = False

        IcedAme.Text = "0"
        Spanish.Text = "0"
        Javalat.Text = "0"
        MochaLat.Text = "0"
        CappuLat.Text = "0"
        MatchaLat.Text = "0"
        CaramelMac.Text = "0"
        IcedChoco.Text = "0"
        WhiteMocha.Text = "0"
        SaltedLat.Text = "0"



        ColdBrew = Americano + SpanishLat + JavaLatte + MochaLatte + CappuccinoLat + MatchaLatte + Caramel + Chocolate + WhiteMoc + SaltedCara

        Form1.UpdateTotal(ColdBrew)


    End Sub
End Class