Imports System.Text

Public Class Cheesecake

    Const Cheesecake = 45
    Const LargeCheeseCake = 55
    Dim WinterTea As Double
    Dim Okinawa As Double
    Dim Matcha As Double
    Dim Taro As Double
    Dim Dark As Double
    Dim Straw As Double
    Dim Avo As Double
    Dim Mango As Double
    Dim Cookies As Double
    Dim Rocky As Double
    Dim Salted As Double
    Dim Dutch As Double
    Dim RedVel As Double

    Dim TotalCheesecake As Double


    Private Sub Cheesecake_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub PlusWinter_Click_1(sender As Object, e As EventArgs) Handles PlusWinter.Click

        WinterText.Text += 1


    End Sub

    Private Sub MinusWinter_Click_1(sender As Object, e As EventArgs) Handles MinusWinter.Click

        WinterText.Text -= 1
        If WinterText.Text <= 0 Then

            WinterText.Text = 0

        End If

    End Sub

    Private Sub PlusOki_Click(sender As Object, e As EventArgs) Handles PlusOki.Click

        OkiText.Text += 1

    End Sub

    Private Sub MinusOki_Click(sender As Object, e As EventArgs) Handles MinusOki.Click

        OkiText.Text -= 1
        If OkiText.Text <= 0 Then

            OkiText.Text = 0

        End If

    End Sub

    Private Sub MinusMat_Click(sender As Object, e As EventArgs) Handles MinusMat.Click


        MatchaText.Text -= 1
        If MatchaText.Text <= 0 Then

            MatchaText.Text = 0

        End If

    End Sub

    Private Sub PlusMat_Click(sender As Object, e As EventArgs) Handles PlusMat.Click

        MatchaText.Text += 1

    End Sub

    Private Sub MinusMan_Click(sender As Object, e As EventArgs) Handles MinusMan.Click

        MangoText.Text -= 1
        If MangoText.Text <= 0 Then

            MangoText.Text = 0

        End If

    End Sub

    Private Sub PlusMan_Click(sender As Object, e As EventArgs) Handles PlusMan.Click

        MangoText.Text += 1

    End Sub

    Private Sub MinusAvo_Click(sender As Object, e As EventArgs) Handles MinusAvo.Click

        AvoText.Text -= 1
        If AvoText.Text <= 0 Then

            AvoText.Text = 0

        End If

    End Sub

    Private Sub PlusAvo_Click(sender As Object, e As EventArgs) Handles PlusAvo.Click

        AvoText.Text += 1

    End Sub

    Private Sub MinusStraw_Click(sender As Object, e As EventArgs) Handles MinusStraw.Click


        StrawText.Text -= 1
        If StrawText.Text <= 0 Then

            StrawText.Text = 0

        End If

    End Sub

    Private Sub PlusStraw_Click(sender As Object, e As EventArgs) Handles PlusStraw.Click

        StrawText.Text += 1

    End Sub

    Private Sub MinusTaro_Click(sender As Object, e As EventArgs) Handles MinusTaro.Click

        TaroText.Text -= 1
        If TaroText.Text <= 0 Then

            TaroText.Text = 0

        End If

    End Sub

    Private Sub PlusTaro_Click(sender As Object, e As EventArgs) Handles PlusTaro.Click

        TaroText.Text += 1

    End Sub

    Private Sub MinusDark_Click(sender As Object, e As EventArgs) Handles MinusDark.Click

        DarkText.Text -= 1
        If DarkText.Text <= 0 Then

            DarkText.Text = 0

        End If

    End Sub

    Private Sub PlusDark_Click(sender As Object, e As EventArgs) Handles PlusDark.Click

        DarkText.Text += 1

    End Sub

    Private Sub MinusCook_Click(sender As Object, e As EventArgs) Handles MinusCook.Click

        CookieText.Text -= 1
        If CookieText.Text <= 0 Then

            CookieText.Text = 0

        End If

    End Sub

    Private Sub PlusCook_Click(sender As Object, e As EventArgs) Handles PlusCook.Click

        CookieText.Text += 1

    End Sub

    Private Sub MinusSal_Click(sender As Object, e As EventArgs) Handles MinusSal.Click

        SaltedText.Text -= 1
        If SaltedText.Text <= 0 Then

            SaltedText.Text = 0

        End If

    End Sub

    Private Sub PlusSal_Click(sender As Object, e As EventArgs) Handles PlusSal.Click

        SaltedText.Text += 1

    End Sub

    Private Sub MinusRed_Click(sender As Object, e As EventArgs) Handles MinusRed.Click

        RedText.Text -= 1
        If RedText.Text <= 0 Then

            RedText.Text = 0

        End If

    End Sub

    Private Sub PlusRed_Click(sender As Object, e As EventArgs) Handles PlusRed.Click

        RedText.Text += 1

    End Sub

    Private Sub MinusRock_Click(sender As Object, e As EventArgs) Handles MinusRock.Click

        RockyText.Text -= 1
        If RockyText.Text <= 0 Then

            RockyText.Text = 0

        End If

    End Sub

    Private Sub PlusRock_Click(sender As Object, e As EventArgs) Handles PlusRock.Click

        RockyText.Text += 1

    End Sub

    Private Sub MinusDoub_Click(sender As Object, e As EventArgs) Handles MinusDoub.Click

        DoubleText.Text -= 1
        If DoubleText.Text <= 0 Then

            DoubleText.Text = 0

        End If

    End Sub

    Private Sub PlusDoub_Click(sender As Object, e As EventArgs) Handles PlusDoub.Click

        DoubleText.Text += 1

    End Sub

    Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click

        If LargeSizeBox.Checked = False Then
            WinterTea = Format(WinterText.Text * Cheesecake, "0.00")
            Okinawa = Format(OkiText.Text * Cheesecake, "0.00")
            Matcha = Format(MatchaText.Text * Cheesecake, "0.00")
            Mango = Format(MangoText.Text * Cheesecake, "0.00")
            Avo = Format(AvoText.Text * Cheesecake, "0.00")
            Straw = Format(StrawText.Text * Cheesecake, "0.00")
            Taro = Format(TaroText.Text * Cheesecake, "0.00")
            Dark = Format(DarkText.Text * Cheesecake, "0.00")
            Cookies = Format(CookieText.Text * Cheesecake, "0.00")
            Salted = Format(SaltedText.Text * Cheesecake, "0.00")
            RedVel = Format(RedText.Text * Cheesecake, "0.00")
            Rocky = Format(RockyText.Text * Cheesecake, "0.00")
            Dutch = Format(DoubleText.Text * Cheesecake, "0.00")
        ElseIf LargeSizeBox.Checked = True Then
            WinterTea = Format(WinterText.Text * LargeCheeseCake, "0.00")
            Okinawa = Format(OkiText.Text * LargeCheeseCake, "0.00")
            Matcha = Format(MatchaText.Text * LargeCheeseCake, "0.00")
            Mango = Format(MangoText.Text * LargeCheeseCake, "0.00")
            Avo = Format(AvoText.Text * LargeCheeseCake, "0.00")
            Straw = Format(StrawText.Text * LargeCheeseCake, "0.00")
            Taro = Format(TaroText.Text * LargeCheeseCake, "0.00")
            Dark = Format(DarkText.Text * LargeCheeseCake, "0.00")
            Cookies = Format(CookieText.Text * LargeCheeseCake, "0.00")
            Salted = Format(SaltedText.Text * LargeCheeseCake, "0.00")
            RedVel = Format(RedText.Text * LargeCheeseCake, "0.00")
            Rocky = Format(RockyText.Text * LargeCheeseCake, "0.00")
            Dutch = Format(DoubleText.Text * LargeCheeseCake, "0.00")
        End If

        Dim orderDetails As String = $"WinterMelon: {WinterTea}" & vbCrLf &
                                $"Okinawa: {Okinawa}" & vbCrLf &
                                $"Matcha: {Matcha}" & vbCrLf &
                                $"Mango: {Mango}" & vbCrLf &
                                $"Avo: {Avo}" & vbCrLf &
                                $"Straw: {Straw}" & vbCrLf &
                                $"Taro: {Taro}" & vbCrLf &
                                $"Dark: {Dark}" & vbCrLf &
                                $"Cookies: {Cookies}" & vbCrLf &
                                $"Salted: {Salted}" & vbCrLf &
                                $"RedVel: {RedVel}" & vbCrLf &
                                $"Rocky: {Rocky}" & vbCrLf &
                                $"Dutch: {Dutch}" & vbCrLf

        Dim form1Instance As Form1 = CType(Application.OpenForms("Form1"), Form1)
        form1Instance.OrderDetails += orderDetails



        TotalCheesecake = WinterTea + Okinawa + Matcha + Mango + Avo + Straw + Taro + Dark + Cookies + Salted + RedVel + Rocky + Dutch
        Form1.UpdateTotal(TotalCheesecake)

        WinterText.Text = "0"
        OkiText.Text = "0"
        MatchaText.Text = "0"
        MangoText.Text = "0"
        AvoText.Text = "0"
        StrawText.Text = "0"
        TaroText.Text = "0"
        DarkText.Text = "0"
        CookieText.Text = "0"
        SaltedText.Text = "0"
        RedText.Text = "0"
        RockyText.Text = "0"
        DoubleText.Text = "0"




        LargeSizeBox.Checked = False



    End Sub





End Class