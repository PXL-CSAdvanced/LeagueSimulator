using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeagueSimulator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void LaadChampionDataButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void LaadAbilityDataButton_Click(object sender, RoutedEventArgs e)
    {

    }


    private void ComboBoxPositions_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void BestToWorstButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void ResetButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void DataGridChampions_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void LaadChampion(int indexChampion, int team)
    {

    }

    private void ImageIconChampion1Team1_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(0, 1);
    }

    private void ImageIconChampion2Team1_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(1, 1);
    }

    private void ImageIconChampion3Team1_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(2, 1);
    }

    private void ImageIconChampion4Team1_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(3, 1);
    }

    private void ImageIconChampion5Team1_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(4, 1);
    }

    private void ImageIconChampion1Team2_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(0, 2);
    }

    private void ImageIconChampion2Team2_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(1, 2);
    }

    private void ImageIconChampion3Team2_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(2, 2);
    }

    private void ImageIconChampion4Team2_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(3, 2);
    }

    private void ImageIconChampion5Team2_MouseEnter(object sender, MouseEventArgs e)
    {
        LaadChampion(4, 2);
    }

    private void Genereer5v5Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Genereer3v3Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ExportToXMLButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void BeslisWinnaarButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void ClearSimulatieTab()
    {

    }
}