using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Checkboxgame
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ECheck[] ec = new ECheck[25];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Fenster_Loaded(object sender, RoutedEventArgs e)
        {
            ec[0] = new ECheck(c0); //Die zu erweiternden Checkboxen werden der Klasse ECheck bei der Erstellung des Objekts übergeben.
            ec[1] = new ECheck(c1);
            ec[2] = new ECheck(c2);
            ec[3] = new ECheck(c3);
            ec[4] = new ECheck(c4);
            ec[5] = new ECheck(c5);
            ec[6] = new ECheck(c6);
            ec[7] = new ECheck(c7);
            ec[8] = new ECheck(c8);
            ec[9] = new ECheck(c9);

            ec[10] = new ECheck(c10);
            ec[11] = new ECheck(c11);
            ec[12] = new ECheck(c12);
            ec[13] = new ECheck(c13);
            ec[14] = new ECheck(c14);
            ec[15] = new ECheck(c15);
            ec[16] = new ECheck(c16);
            ec[17] = new ECheck(c17);
            ec[18] = new ECheck(c18);
            ec[19] = new ECheck(c19);

            ec[20] = new ECheck(c20);
            ec[21] = new ECheck(c21);
            ec[22] = new ECheck(c22);
            ec[23] = new ECheck(c23);
            ec[24] = new ECheck(c24);


            ec[0].Integrate(null, c1, null, c5); //Die 4 umliegenden Checkboxen werden den Objekten der Klasse ECheck durch die Methode Integrate übergeben.
            ec[1].Integrate(c0, c2, null, c6);
            ec[2].Integrate(c1, c3, null, c7);
            ec[3].Integrate(c2, c4, null, c8);
            ec[4].Integrate(c3, null, null, c9);
            ec[5].Integrate(null, c6, c0, c10);
            ec[6].Integrate(c5, c7, c1, c11);
            ec[7].Integrate(c6, c8, c2, c12);
            ec[8].Integrate(c7, c9, c3, c13);
            ec[9].Integrate(c8, null, c4, c14);

            ec[10].Integrate(null, c11, c5, c15);
            ec[11].Integrate(c10, c12, c6, c16);
            ec[12].Integrate(c11, c13, c7, c17);
            ec[13].Integrate(c12, c14, c8, c18);
            ec[14].Integrate(c13, null, c9, c19);
            ec[15].Integrate(null, c16, c10, c20);
            ec[16].Integrate(c15, c17, c11, c21);
            ec[17].Integrate(c16, c18, c12, c22);
            ec[18].Integrate(c17, c19, c13, c23);
            ec[19].Integrate(c18, null, c14, c24);

            ec[20].Integrate(null, c21, c15, null);
            ec[21].Integrate(c20, c22, c16, null);
            ec[22].Integrate(c21, c23, c17, null);
            ec[23].Integrate(c22, c24, c18, null);
            ec[24].Integrate(c23, null, c19, null);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ec.Length; ++i)
            {
                ec[i].th.IsChecked = false;
            }
        }
        public void Win()
        {
            for (int i = 0; i < ec.Length; ++i)
            {
                if (!(bool)ec[i].th.IsChecked)
                {
                    return;
                }
            }
            MessageBox.Show("You won!");
        }
        private void c0_Click(object sender, RoutedEventArgs e)
        {
            ec[0].Change(); //Der Status wird geändert
            Win();          //Überprüfung, ob man gesiegt hat
        }

        private void c1_Click(object sender, RoutedEventArgs e)
        {
            ec[1].Change(); //...
            Win();          //...
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            ec[2].Change();
            Win();
        }

        private void c3_Click(object sender, RoutedEventArgs e)
        {
            ec[3].Change();
            Win();
        }

        private void c4_Click(object sender, RoutedEventArgs e)
        {
            ec[4].Change();
            Win();
        }

        private void c5_Click(object sender, RoutedEventArgs e)
        {
            ec[5].Change();
            Win();
        }

        private void c6_Click(object sender, RoutedEventArgs e)
        {
            ec[6].Change();
            Win();
        }

        private void c7_Click(object sender, RoutedEventArgs e)
        {
            ec[7].Change();
            Win();
        }

        private void c8_Click(object sender, RoutedEventArgs e)
        {
            ec[8].Change();
            Win();
        }

        private void c9_Click(object sender, RoutedEventArgs e)
        {
            ec[9].Change();
            Win();
        }

        private void c10_Click(object sender, RoutedEventArgs e)
        {
            ec[10].Change();
            Win();
        }

        private void c11_Click(object sender, RoutedEventArgs e)
        {
            ec[11].Change();
            Win();
        }

        private void c12_Click(object sender, RoutedEventArgs e)
        {
            ec[12].Change();
            Win();
        }

        private void c13_Click(object sender, RoutedEventArgs e)
        {
            ec[13].Change();
            Win();
        }

        private void c14_Click(object sender, RoutedEventArgs e)
        {
            ec[14].Change();
            Win();
        }

        private void c15_Click(object sender, RoutedEventArgs e)
        {
            ec[15].Change();
            Win();
        }

        private void c16_Click(object sender, RoutedEventArgs e)
        {
            ec[16].Change();
            Win();
        }

        private void c17_Click(object sender, RoutedEventArgs e)
        {
            ec[17].Change();
            Win();
        }

        private void c18_Click(object sender, RoutedEventArgs e)
        {
            ec[18].Change();
            Win();
        }

        private void c19_Click(object sender, RoutedEventArgs e)
        {
            ec[19].Change();
            Win();
        }

        private void c20_Click(object sender, RoutedEventArgs e)
        {
            ec[20].Change();
            Win();
        }

        private void c21_Click(object sender, RoutedEventArgs e)
        {
            ec[21].Change();
            Win();
        }

        private void c22_Click(object sender, RoutedEventArgs e)
        {
            ec[22].Change();
            Win();
        }

        private void c23_Click(object sender, RoutedEventArgs e)
        {
            ec[23].Change();
            Win();
        }

        private void c24_Click(object sender, RoutedEventArgs e)
        {
            ec[24].Change();
            Win();
        }


    }
}
