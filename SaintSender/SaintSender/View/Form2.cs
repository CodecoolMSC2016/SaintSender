using MaterialSkin;
using MaterialSkin.Controls;
using SaintSender.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.View
{
    public partial class Form2 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form2()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //materialSkinManager.

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //TODO: Remove...
            emailWebBrowser.Navigate("https://dcrazed.com/html/kreative-demo/");
;
            var data = new[]
            {
                new []{"Rosszlanyok.hu regisztracio", "noreply@rosszlanyok.hu", "2017.02.01 12:23"},
                new []{"Canvas recent notifications", "canvas@codecool.hu.hu", "2017.12.04 02:33"},
                new []{"Felhívás", "felhiveas@tek.hu", "2016.12.01 01:23"},
                new []{"Óriási akciók", "noreply@edigital.hu", "2017.02.01 12:23"}
            };

            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                emailListView.Items.Add(item);
            }

            
        }

    }
}
