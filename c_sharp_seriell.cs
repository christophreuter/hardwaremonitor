// Software mit Visual Studio zur seriellen Übertragung der Daten Openhardewaremonitor zum Arduino
// Dr. Christoph Reuter26.11.2020
//

// using System.Windows.Forms;
//

namespace seriell
{
    public partial class Form1 : Form
    {public Form1()
    {
      InitializeComponent();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
    System.IO.Ports.SerialPort sport = new System.IO.Ports.SerialPort(textBox1.Text,
                                                                        9600,
                                                                        Saystem.IO.Ports.Parity.None,
                                                                        8,
                                                                        System.IO.Ports.StopBits.One);
                                                                        
          try
          {
            sport.Open();
            sport.Write("Test");
          }
          catch (Exception ex) {
            MessageBox.Show(ex.ToString());
          }
          
          sport.Close();
        }
      }
    }
