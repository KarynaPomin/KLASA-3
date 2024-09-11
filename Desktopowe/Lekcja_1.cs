/*
PAD - rozgrzewka z kontrolek

Zad 1. Mają być 2 textboxy (placeholder imie, nazwisko) i dwa butony. Po kliknieciu w jeden z buttonów ma wyskoczyc messageBox z napisem: Witaj imie i nazwisko
A drugi button zamyka apke poprzedzajac to messboxem (baj baj)

MessageBox.Show();
Close();

Zad 2. Napisz program w WPF, w którym podajesz dane o osobie:
1 - textbox imie
2 - radio płeć
3 - checkbox hobby   ??
4 - textarea o sobie  

Po kliknięciu w button zapisz -> całość danych zapisać do pliku
Inny button zamyka program. Można dodać labele informacyjne.

Zad 3. Stwórz program, który wyświetla drzewo plików w Windows. 
Dodatkowo stwórz prosty edytor, który tworzy plik tekstowy *.txt
(nazwa, zawartość) i zapisuje na dysku.
Nazwa pliku może być wpisywana przez usera albo generowana przez program
np: plik_bieżącyczas.txt
Zapis może być na fix - w określonym w programie miejscu.
Jak się uda to niech user decyduje o miejscu zapisu pku
*/

//Zad 1
private void Button_Click(object sender, RoutedEventArgs e)
{
    MessageBox.Show("Witaj " + userName.Text + " " + userSurname.Text);
    Close();
}

private void Button_Click_1(object sender, RoutedEventArgs e)
{
    MessageBox.Show("By by " + userName.Text);
    Close();
}

 <Grid>
     <TextBox x:Name="userName" HorizontalAlignment="Left" Height="50" Margin="42,53,0,0" TextWrapping="Wrap" Text="Podaj imię" VerticalAlignment="Top" Width="153" FontSize="20"/>
     <TextBox x:Name="userSurname" HorizontalAlignment="Left" Height="50" Margin="42,139,0,0" TextWrapping="Wrap" Text="Podaj nazwisko" VerticalAlignment="Top" Width="153" FontSize="20"/>
     <Button Content="Witaj" HorizontalAlignment="Left" Margin="42,217,0,0" VerticalAlignment="Top" Width="57" Height="35" Click="Button_Click"/>
     <Button Content="By" HorizontalAlignment="Left" Margin="138,217,0,0" VerticalAlignment="Top" Width="57" Height="35" Click="Button_Click_1"/>
 </Grid>
