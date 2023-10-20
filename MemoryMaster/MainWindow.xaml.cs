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

namespace MemoryMaster
{
    public partial class MainWindow : Window
    {

        readonly List<Brush> colors = new List<Brush>() { Brushes.Blue, Brushes.PaleGoldenrod, Brushes.Orchid, Brushes.Navy, Brushes.Maroon, Brushes.Indigo, Brushes.Salmon, Brushes.Cyan, Brushes.Blue, Brushes.PaleGoldenrod, Brushes.Orchid, Brushes.Navy, Brushes.Maroon, Brushes.Indigo, Brushes.Salmon, Brushes.Cyan};
        //Buttonn buttonn;
        int count = 0;
        int podejscie = 0;
        int znalezione = 0;
        List<Brush> mieszane = new List<Brush>();
        public MainWindow()
        {
            InitializeComponent();
            B1.Background = Brushes.WhiteSmoke;
            B2.Background = Brushes.WhiteSmoke;
            B3.Background = Brushes.WhiteSmoke;
            B4.Background = Brushes.WhiteSmoke;
            B5.Background = Brushes.WhiteSmoke;
            B6.Background = Brushes.WhiteSmoke;
            B7.Background = Brushes.WhiteSmoke;
            B8.Background = Brushes.WhiteSmoke;
            B9.Background = Brushes.WhiteSmoke;
            B10.Background = Brushes.WhiteSmoke;
            B11.Background = Brushes.WhiteSmoke;
            B12.Background = Brushes.WhiteSmoke;
            B13.Background = Brushes.WhiteSmoke;
            B14.Background = Brushes.WhiteSmoke;
            B15.Background = Brushes.WhiteSmoke;
            B16.Background = Brushes.WhiteSmoke;
            
            mieszane = Colorsy();
        }

        //private Brush Random()
        //{
        //    Random rand = new Random();
        //    int number = rand.Next(0, 7);
        //    return colors[number];
        //}

        public List<Brush> Colorsy()
        {
            Random random = new Random();
            List<Brush> brr = new();
            colors.Sort((a, b) => random.Next(-1, 2));
            brr.AddRange(colors);

            return brr;
        }

        public List<Button> przyciskii()
        {
            List<Button> buttons = new();
            buttons.Add(B1);
            buttons.Add(B2);
            buttons.Add(B3);
            buttons.Add(B4);
            buttons.Add(B5);
            buttons.Add(B6);
            buttons.Add(B7);
            buttons.Add(B8);
            buttons.Add(B9);
            buttons.Add(B10);
            buttons.Add(B11);
            buttons.Add(B12);
            buttons.Add(B13);
            buttons.Add(B14);
            buttons.Add(B15);
            buttons.Add(B16);

            return buttons;
        }


        public void Refresh()
        {
            mieszane = Colorsy();

             count = 0;
             podejscie = 0;
             znalezione = 0;

            List<Button> brr = przyciskii();
            foreach(var b in brr)
            {
                b.IsEnabled = true;
            }

        }

        private void Bt1(object sender, RoutedEventArgs e)
        {

            podejscie++;
            count++;
            Graj(count, podejscie);
            B1.Background = mieszane[0];
            Sprawdz(B1);
        }

        private void Bt2(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B2.Background = mieszane[1];
            Sprawdz(B2);
        }

        private void Bt3(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B3.Background = mieszane[2];
            Sprawdz(B3);
        }

        private void Bt4(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B4.Background = mieszane[3];
            Sprawdz(B4);
        }

        private void Bt5(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B5.Background = mieszane[4];
            Sprawdz(B5);
        }

        private void Bt6(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B6.Background = mieszane[5];
            Sprawdz(B6);
        }

        private void Bt7(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B7.Background = mieszane[6];
            Sprawdz(B7);
        }

        private void Bt8(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B8.Background = mieszane[7];
            Sprawdz(B8);
        }

        private void Bt9(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B9.Background = mieszane[8];
            Sprawdz(B9);
        }

        private void Bt10(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B10.Background = mieszane[9];
            Sprawdz(B10);
        }

        private void Bt11(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B11.Background = mieszane[10];
            Sprawdz(B11);
        }

        private void Bt12(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            Graj(count, podejscie);
            B12.Background = mieszane[11];
            Sprawdz(B12);
        }

        private void Bt13(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            
            Graj(count, podejscie);
            B13.Background = mieszane[12];
            Sprawdz(B13);
        }

        private void Bt14(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            
            Graj(count, podejscie);
            B14.Background = mieszane[13];
            Sprawdz(B14);
        }

        private void Bt15(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            
            Graj(count, podejscie);
            B15.Background = mieszane[14];
            Sprawdz(B15);
        }

        private void Bt16(object sender, RoutedEventArgs e)
        {
            podejscie++;
            count++;
            
            Graj(count, podejscie);
            B16.Background = mieszane[15];
            Sprawdz(B16);
        }

        public void Sprawdz(Button button)
        {
            List<Button> buttons = przyciskii();

            for (int i = buttons.Count - 1; i >= 0; i--)
            {
                if (buttons[i].Equals(button))
                {
                    buttons.RemoveAt(i);
                }
            }

            foreach (var i in buttons)
            {
                if (i.Background == button.Background)
                {
                    i.IsEnabled = false;
                    button.IsEnabled = false;
                    znalezione++;
                    t2.Text = znalezione.ToString();
                }
            }
            if (znalezione == 8) MessageBox.Show("Gratulacje! Udało Ci się wygrać z ilością prób: " + podejscie/2);
        }

        public void Graj(int count1, int podejscie1)
        {
            if (count1 >= 3)
            {
                B1.Background = Brushes.WhiteSmoke;
                B2.Background = Brushes.WhiteSmoke;
                B3.Background = Brushes.WhiteSmoke;
                B4.Background = Brushes.WhiteSmoke;
                B5.Background = Brushes.WhiteSmoke;
                B6.Background = Brushes.WhiteSmoke;
                B7.Background = Brushes.WhiteSmoke;
                B8.Background = Brushes.WhiteSmoke;
                B9.Background = Brushes.WhiteSmoke;
                B10.Background = Brushes.WhiteSmoke;
                B11.Background = Brushes.WhiteSmoke;
                B12.Background = Brushes.WhiteSmoke;
                B13.Background = Brushes.WhiteSmoke;
                B14.Background = Brushes.WhiteSmoke;
                B15.Background = Brushes.WhiteSmoke;
                B16.Background = Brushes.WhiteSmoke;
                count = 1;
            }
            if (podejscie1 % 2 == 0)
            {
                int podejscie2 = podejscie1 / 2;
                t1.Text = podejscie2.ToString();
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ewelinka Resetuje");
            Refresh();
        }
    }
}
