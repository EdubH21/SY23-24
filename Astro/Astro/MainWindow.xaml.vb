Class MainWindow
    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs) Handles Button.Click
        Dim d As Integer
        Dim m As Integer
        m = Cal1.SelectedDate.Value.Month
        d = Cal1.SelectedDate.Value.Day
        If m = 3 And d > 20 Or m = 4 And d < 20 Then
            Label1.Content = "Aries"
            AriesPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 4 And d > 19 Or m = 5 And d < 21 Then
            Label1.Content = "Taurus"
            TaurusPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
        End If
        If m = 5 And d > 20 Or m = 6 And d < 21 Then
            Label1.Content = "Gemini"
            GeminiPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 6 And d > 20 Or m = 7 And d < 23 Then
            Label1.Content = "Cancer"
            CancerPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 7 And d > 22 Or m = 8 And d < 23 Then
            Label1.Content = "Leo"
            LeoPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 8 And d > 22 Or m = 9 And d < 23 Then
            Label1.Content = "Virgo"
            VirgoPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 9 And d > 22 Or m = 10 And d < 23 Then
            Label1.Content = "Libra"
            LibraPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 10 And d > 22 Or m = 11 And d < 22 Then
            Label1.Content = "Scorpio"
            ScorpioPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 11 And d > 21 Or m = 12 And d < 22 Then
            Label1.Content = "Sagittarius"
            SagittariusPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 12 And d > 21 Or m = 1 And d < 20 Then
            Label1.Content = "Capricorn"
            CapricornPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 1 And d > 19 Or m = 2 And d < 19 Then
            Label1.Content = "Aquarius"
            AquariusPB.Visibility = Visibility.Visible
            AriesPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
        If m = 2 And d > 18 Or m = 3 And d < 21 Then
            Label1.Content = "Pisces"
            PiscesPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            AriesPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
        End If
    End Sub
End Class
