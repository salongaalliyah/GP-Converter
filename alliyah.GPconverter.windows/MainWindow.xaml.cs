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

namespace alliyah.GPconverter.windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnconvert_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtBox_PCT.Text);
            if (x == 100 || x == 99 || x == 98)
            {
                lblResult.Content = "1";

            }
            else if (x == 97 || x == 96 || x == 95)
            {
                lblResult.Content = "1.25";
            }
            else if (x == 94 || x == 93 || x == 92)
            {
                lblResult.Content = "1.5";
            }
            else if (x == 91 || x == 90 || x == 89)
            { lblResult.Content = "1.75";
            }
            else if (x == 88 || x == 87 || x == 86)
            { lblResult.Content = "2";
            }
            else if (x == 85 || x == 84 || x == 83)
            { lblResult.Content = "2.25";
            }
            else if (x == 82 || x == 81 || x == 80)
            { lblResult.Content = "2.5";
            }
            else if (x == 79 || x == 78 || x == 76)
            { lblResult.Content = "2.75";
            }
            else if (x == 75)
            { lblResult.Content = "3";
            }
            else if ( x == 73 || x == 74)
            { lblResult.Content = "3.75";
            }
            else if (x == 71 || x == 72)
            { lblResult.Content = "3.5";
            }
            else if (x == 69 || x == 70)
            { lblResult.Content = "3.25";
            }
            else if (x == 67 || x == 68)
            { lblResult.Content = "4";
            }
            else if (x == 66 || x == 65)
            { lblResult.Content = "4.75";
            }
            else if (x == 64 || x == 63)
            { lblResult.Content = "4.5";
            }
            else if (x == 62 || x == 61)
            { lblResult.Content = "4.25";
            }
            else if (x == 60)
            { lblResult.Content = "5";
            }
        }
    }
}
