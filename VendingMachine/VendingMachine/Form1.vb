Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickels()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdimes()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarters()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollars()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            DollarPB.Visible = True
        Else
            DollarPB.Visible = False
        End If
        If q > 0 Then
            QuarterPB.Visible = True
        Else
            QuarterPB.Visible = False
        End If
        If di > 0 Then
            DimePB.Visible = True
        Else
            DimePB.Visible = False
        End If
        If n > 0 Then
            NickelPB.Visible = True
        Else
            NickelPB.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDtextbox.Text
            Case ProductControl1.productID
                cs.buy(ProductControl1)
            Case ProductControl2.productID
                cs.buy(ProductControl2)
            Case ProductControl3.productID
                cs.buy(ProductControl3)
            Case ProductControl4.productID
                cs.buy(ProductControl4)
            Case ProductControl5.productID
                cs.buy(ProductControl5)
            Case ProductControl6.productID
                cs.buy(ProductControl6)
            Case ProductControl7.productID
                cs.buy(ProductControl7)
            Case ProductControl8.productID
                cs.buy(ProductControl8)
            Case ProductControl9.productID
                cs.buy(ProductControl9)
            Case ProductControl10.productID
                cs.buy(ProductControl10)
            Case ProductControl11.productID
                cs.buy(ProductControl11)
            Case ProductControl12.productID
                cs.buy(ProductControl12)
            Case ProductControl13.productID
                cs.buy(ProductControl13)
            Case ProductControl14.productID
                cs.buy(ProductControl14)
            Case ProductControl15.productID
                cs.buy(ProductControl15)
            Case ProductControl16.productID
                cs.buy(ProductControl16)

            Case Else

        End Select
        TotalLabel.Text = cs.total.ToString("c2")
        ProductControl1.buy()
    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        ProductPB.Image = p
    End Sub
End Class
