using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace filtrar_input
{
    public partial class Window_text_filter : Form
    {
        string input_user = "";
        string filtered_input_user = "";
        public Window_text_filter()
        {
            InitializeComponent();
            this.Text = "Filtrar texto";

            Bitmap png = new Bitmap(global::filtrar_input.Properties.Resources.filter);
            Icon icone = Icon.FromHandle(png.GetHicon());
            this.Icon = icone;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botao_retirar_tracos_e_pontos_Click(object sender, EventArgs e)
        {
            if (verify_if_have_input() == true)
            {
                input_user = line_edit_texto.Text;
                filtered_input_user = input_user.Replace(" ", "").Replace("-", "").Replace(",", "").Replace(".", "");
                Clipboard.SetText(filtered_input_user);
                MessageBox.Show("Texto Copiado para a area de transferência");

            }
            else
            {
                MessageBox.Show("Coloque um texto primeiro");
            }
        }

        private void botao_colocar_em_modo_titulo_Click(object sender, EventArgs e)
        {
            if (verify_if_have_input() == true)
            {
                input_user = line_edit_texto.Text;
                TextInfo myTI = new CultureInfo("pt-br", false).TextInfo;
                filtered_input_user = myTI.ToTitleCase(input_user);
                Clipboard.SetText(filtered_input_user);
                MessageBox.Show("Texto Copiado para a area de transferência");
            }
            else
            {
                MessageBox.Show("Coloque um texto primeiro");
            }
        }

        private void botao_visitar_git_Click(object sender, EventArgs e) 
        {
            string url = "https://github.com/VBSX/filtrar_input";
            Process.Start(url);
        }
        private bool verify_if_have_input()
        {
            if(line_edit_texto.Text.Length > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
