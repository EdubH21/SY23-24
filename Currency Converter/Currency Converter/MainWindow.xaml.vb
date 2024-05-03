Imports System.Net.Security

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim x As Integer
        Integer.TryParse(InputBox.Text, x)
        OutputLabel.Content = 0.93 * x
        Euro.Visibility = Visibility.Visible
        Pound.Visibility = Visibility.Hidden
        E_Pound.Visibility = Visibility.Hidden
        Peso.Visibility = Visibility.Hidden
        Yen.Visibility = Visibility.Hidden
        Real.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim x As Integer
        Integer.TryParse(InputBox.Text, x)
        OutputLabel.Content = 0.8 * x
        Pound.Visibility = Visibility.Visible
        Euro.Visibility = Visibility.Hidden
        E_Pound.Visibility = Visibility.Hidden
        Peso.Visibility = Visibility.Hidden
        Yen.Visibility = Visibility.Hidden
        Real.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim x As Integer
        Integer.TryParse(InputBox.Text, x)
        OutputLabel.Content = 17.08 * x
        Peso.Visibility = Visibility.Visible
        Pound.Visibility = Visibility.Hidden
        E_Pound.Visibility = Visibility.Hidden
        Euro.Visibility = Visibility.Hidden
        Yen.Visibility = Visibility.Hidden
        Real.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim x As Integer
        Integer.TryParse(InputBox.Text, x)
        OutputLabel.Content = 5.15 * x
        Real.Visibility = Visibility.Visible
        Pound.Visibility = Visibility.Hidden
        E_Pound.Visibility = Visibility.Hidden
        Peso.Visibility = Visibility.Hidden
        Yen.Visibility = Visibility.Hidden
        Euro.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        Dim x As Integer
        Integer.TryParse(InputBox.Text, x)
        OutputLabel.Content = 47.9 * x
        E_Pound.Visibility = Visibility.Visible
        Pound.Visibility = Visibility.Hidden
        Euro.Visibility = Visibility.Hidden
        Peso.Visibility = Visibility.Hidden
        Yen.Visibility = Visibility.Hidden
        Real.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)
        Dim x As Integer
        Integer.TryParse(InputBox.Text, x)
        OutputLabel.Content = 155.36 * x
        Yen.Visibility = Visibility.Visible
        Pound.Visibility = Visibility.Hidden
        E_Pound.Visibility = Visibility.Hidden
        Peso.Visibility = Visibility.Hidden
        Euro.Visibility = Visibility.Hidden
        Real.Visibility = Visibility.Hidden
    End Sub

    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles Clear.Click
        OutputLabel.Content = ""
        InputBox.Text = "1"
    End Sub
End Class
