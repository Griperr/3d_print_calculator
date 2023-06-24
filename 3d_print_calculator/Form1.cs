using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3d_print_calculator
{
    public partial class Form1 : Form
    {
        //pkwh = price for KWH, t = time, P = power of printer, W = weight of print , pm = price of material, pw = price of work  

        float pkwh, P, W, pm, t = 0 ,pw, profit, tax;
        double result, price1, priceF;

        public static string massage;

        PopUpForm popUpForm = new PopUpForm();


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonLoadPreset_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Title = "Load your preset";
            openFileDialog1.Filter = "TXT files|*.txt";

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string[] contents = File.ReadAllLines(filename);
                string current, spliter;

                for(int i=0; i<=7; i++)
                {
                    current = contents[i];
                    spliter = current.Split(':').Last();
                    contents[i] = spliter;
                }
                textBoxPrinterName.Text = contents[0];
                textBoxPrice4Kwh.Text = contents[1];
                textBoxMaterial.Text = contents[2];
                textBoxMaterialPrice.Text = contents[3];
                textBoxCurency.Text = contents[4];
                textBoxPower.Text = contents[5];
                textBoxProfit.Text = contents[6];
                textBoxTax.Text = contents[7];

            }
        }

        private void buttonSavePreset_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory =Directory.GetCurrentDirectory();
            saveFileDialog1.Title = "Save your preset";
            saveFileDialog1.Filter = "TXT files|*.txt";
            saveFileDialog1.FileName = textBoxPrinterName.Text + " " + textBoxMaterial.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                string[] contents = new string[8];

                contents[0] = "Printer name: " + textBoxPrinterName.Text;
                contents[1] = "Price for kWh: " + textBoxPrice4Kwh.Text;
                contents[2] = "Material name: " + textBoxMaterial.Text;
                contents[3] = "Material price per kg: " + textBoxMaterialPrice.Text;
                contents[4] = "Currency: " + textBoxCurency.Text;
                contents[5] = "Printer Power: " + textBoxPower.Text;
                contents[6] = "Profit margin: " + textBoxProfit.Text;
                contents[7] = "Tax: " + textBoxTax.Text;

                
                File.WriteAllLines(filename, contents);
                

            }

        }

       


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var directory = Directory.GetCurrentDirectory();
                var file = new DirectoryInfo(directory).GetFiles()
                             .OrderByDescending(f => f.LastWriteTime)
             .First();
                string filename = file.ToString();
                if (file.Extension==".txt")
                {
                    string[] contents = File.ReadAllLines(filename);
                    string current, spliter;

                    for (int i = 0; i <= 7; i++)
                    {
                        current = contents[i];
                        spliter = current.Split(':').Last();
                        contents[i] = spliter;
                    }
                    textBoxPrinterName.Text = contents[0];
                    textBoxPrice4Kwh.Text = contents[1];
                    textBoxMaterial.Text = contents[2];
                    textBoxMaterialPrice.Text = contents[3];
                    textBoxCurency.Text = contents[4];
                    textBoxPower.Text = contents[5];
                    textBoxProfit.Text = contents[6];
                    textBoxTax.Text = contents[7];
                }
            }
            catch
            {

            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                t = float.Parse(textBoxTime.Text);
                W = float.Parse(textBoxWeight.Text);
              
            
            }
            catch(Exception e1)
            {
                t = 0;
                W = 0;
                pkwh = 0;
                P = 0;
                pm = 0;
                
            }
            try
            {
                pkwh = float.Parse(textBoxPrice4Kwh.Text);
            }
            catch(Exception e2)//no price for kWh
            {

                massage = "Please put in Price for kWh in setting tab.";
                                 
                popUpForm.ShowDialog();
                
                return;
                
            }
            try
            {
                pm = float.Parse(textBoxMaterialPrice.Text);
            }
            catch (Exception e3)//no material price
            {
                massage = "Please put in Price of material in setting tab.";
                
                popUpForm.ShowDialog();
                return;
            }
            try
            {
                P = float.Parse(textBoxPower.Text);
            }
            catch (Exception e4)// no power
            {
                massage = "Please put in Power of your printers power suply in setting tab.";
                
                popUpForm.ShowDialog();
                return;
            }
            try
            {
                profit = float.Parse(textBoxProfit.Text) / 100;
                tax = float.Parse(textBoxTax.Text) / 100;
            }
            catch(Exception ex)
            {
                profit = 0;
                tax = 0;
            }

            if(textBoxCurency.Text == "")
            {
                massage = "Plase put your prefered currency in setting tab";
                popUpForm.ShowDialog();
                return;
            }


                TimeSpan time = TimeSpan.FromMinutes(t); //convert time textbox to acual time in minutes
                
               
               
                //math to calculations
            pw = (float)((time.TotalHours * P) / 1000) * pkwh; 
            result = Math.Round(pw + (W * (pm / 1000)), 2);
            price1 = Math.Round(result + (result*profit),2);
            priceF = Math.Round(price1 + (price1 * tax), 2);

            
           
           
            labelResult.Text = result.ToString();
            labelPrice1.Text = price1.ToString();
            labelPriceFull.Text = priceF.ToString();
            labelCurrency2.Text = textBoxCurency.Text;
            labelCurrency3.Text = textBoxCurency.Text;
            labelCurrency4.Text = textBoxCurency.Text;

        }

       
    }
}
