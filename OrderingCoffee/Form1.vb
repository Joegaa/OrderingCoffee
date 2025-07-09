

Public Class Form1



    Private totalValue As Double = 0


    Private _orderDetails As String = ""

    Public Property OrderDetails As String
        Get
            Return _orderDetails
        End Get
        Set(value As String)
            _orderDetails = value
        End Set
    End Property

    Public Sub UpdateTotal(ParamArray orderValues() As Double)
        If totalValue = 0 Then
            TotalOrderBox.Text = "0.00"
        End If

        For Each orderValue As Double In orderValues
            totalValue += orderValue
        Next

        TotalOrderBox.Text = totalValue.ToString("0.00")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With MilkTea

            .TopLevel = False
            ShowPanel.Controls.Add(MilkTea)
            .BringToFront()
            .Show()

        End With


    End Sub

    Private Sub CheeseButton_Click(sender As Object, e As EventArgs) Handles CheeseButton.Click

        With Cheesecake

            .TopLevel = False
            ShowPanel.Controls.Add(Cheesecake)
            .BringToFront()
            .Show()


        End With

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ColdB.Click


        With ColdBrew

            .TopLevel = False
            ShowPanel.Controls.Add(ColdBrew)
            .BringToFront()
            .Show()


        End With


    End Sub

    Private Sub HotB_Click(sender As Object, e As EventArgs) Handles HotB.Click

        With HotBrew

            .TopLevel = False
            ShowPanel.Controls.Add(HotBrew)
            .BringToFront()
            .Show()

        End With


    End Sub

    Private Sub FrappeB_Click(sender As Object, e As EventArgs) Handles FrappeB.Click

        With Frappe

            .TopLevel = False
            ShowPanel.Controls.Add(Frappe)
            .BringToFront()
            .Show()


        End With


    End Sub

    Private Sub FinalOrder_Click(sender As Object, e As EventArgs) Handles FinalOrder.Click


        If TotalOrderBox.Text = "0.00" Then

            FinalOrder.Enabled = False

        Else

            FinalOrder.Enabled = True

        End If



        If Double.TryParse(TotalOrderBox.Text, totalValue) Then
            ' Show the total in a MessageBox
            Dim result As DialogResult = MessageBox.Show($"Total: ${totalValue:0.00}" & vbCrLf & "Do you want to reset for a new order?", "Order Total", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Show the order details in a MessageBox
                MessageBox.Show(OrderDetails, "Order Details")

                ' Reset the total for a new order
                TotalOrderBox.Text = "0.00"
                OrderDetails = ""

                MessageBox.Show("Thank you for your order!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Invalid total value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        totalValue = 0

    End Sub

    Private Sub TotalOrderBox_TextChanged(sender As Object, e As EventArgs) Handles TotalOrderBox.TextChanged

        If TotalOrderBox.Text = "0.00" Then

            FinalOrder.Enabled = False

        Else

            FinalOrder.Enabled = True

        End If

    End Sub
End Class
