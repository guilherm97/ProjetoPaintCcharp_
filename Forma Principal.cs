using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {

        private bool flagPintar = false; // para controlar qunado se deve pintar
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false; // para controlar quando se deve apagar com a borracha
        private Image imagemASalvar;
        private Graphics graphicsImagemASalvar;
        public Form1()
        {
            InitializeComponent();

            // as propriedades abaixo só fazem efeito quando o botão está com a propriedade flatstyle
            //setada em flat
            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray; //altera a cor do botão quando o curso está sobre ele
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for(int i=2; i <= 100; i += 2) // irá preencher o combox de 2 até 100 contando de 2 em 2
            {
                comboBoxExpessuraDaCaneta.Items.Add(i);
            }
            comboBoxExpessuraDaCaneta.Text = "2"; // textto que irá aparecer na combo box 
            comboBoxExpessuraDaCaneta.MaxDropDownItems = 5; // define o numero de itens a serem exibidos na combox
            comboBoxExpessuraDaCaneta.IntegralHeight = false; // necessario para que seja possivel para definir a quantidade de itens na combo box

            graphicsPainelPintura = panelpintura.CreateGraphics();// permite desenha sobre o controle
            espessuraCaneta = float.Parse(comboBoxExpessuraDaCaneta.Text); // converte o texto para tipo float
            corBorracha = panelpintura.BackColor;// especifica cor padrao da borracha

            imagemASalvar = new Bitmap(panelpintura.Width, panelpintura.Height);// imagem para salvar
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar);// extraindo graphics da imagem para salvar
            graphicsImagemASalvar.Clear(panelpintura.BackColor); // preeenchemos a imagem com a cor do fundo 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();// colordialog é uma caixa de seleção de cores
            var corEscolhida = colorDialog.ShowDialog(); // exibe na forma modal - aplicação fica travada enquanto o dialogo não é resolvido
            if(corEscolhida == DialogResult.OK) // verifca se usuario clickou em OK
            {
                ButtonCorCaneta.BackColor = colorDialog.Color; //alteramos a cor do botão para a cor escolhida
            }

        }

        private void panelpintura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelpintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void panelpintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }


        private void panelpintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPintar)
            {
                if (!flagApagar)
                {
                    //desenhamos uma eclipse da cor e espressura definida pelo usuario 
                    graphicsPainelPintura.DrawEllipse(new Pen(ButtonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    // desenhando imagem para salvar 
                    graphicsImagemASalvar.DrawEllipse(new Pen(ButtonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    graphicsPainelPintura.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta)); // transformaos a varivael tipo float para tipo int

                    graphicsImagemASalvar.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                }

               
            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza disso?? todo desenho será apagado", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White);//limpa o desenho e preeenche o fundo do painel de branco
                imagemASalvar = new Bitmap(panelpintura.Width, panelpintura.Height);// imagem para salvar
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar);// extraindo graphics da imagem para salvar
                graphicsImagemASalvar.Clear(panelpintura.BackColor); // preeenchemos a imagem com a cor do fundo 
            }

            
        }
        // SelectedIndexChanged ocorre quando é feita uma escolha  de item pelo usuario
        private void comboBoxExpessuraDaCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxExpessuraDaCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) // se clicar com botão direito do mouse sob o botão borracha
            {
                var colorDialog = new ColorDialog();
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color; // seleciona a cor da borracha de acordo com a escolha do usuario
                }
            }
            else
            {
                if (!flagApagar)// o operador ! antes irá virar o valor da flagApagar ao contrario , ou seja se é true fica false..
                {
                    flagApagar = true;
                    buttonBorracha.BackColor = corBorracha;
                }
                else
                {
                    flagApagar = false;// borracha não será  mais selecionada
                    buttonBorracha.BackColor = Color.Black;// cor voltará ao padrão
                }
             
            }
            
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog(); //janela pra salvar arquivos
            saveFileDialog.Filter = "Portable Network Grapichs|.png|Arquivo JPEG|.jpeg"; //atribuindo formatos de imagens
            if(saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;

                }
            }
        }

        private void panelpintura_Resize(object sender, EventArgs e) // evento disparado sempre q o painel é redimensionado
        {
            graphicsPainelPintura = panelpintura.CreateGraphics(); // atualiza a referencia do objeto grapichs do painel
            var imgTemp = new Bitmap(panelpintura.Width, panelpintura.Height); // criamos uma imagem temporaria
            var graphcisImgTemp = Graphics.FromImage(imgTemp);
            graphcisImgTemp.DrawImage(imagemASalvar, 0, 0); // desenhamos a imagem antiga na imagem temporaria - maneira de fazer uma copia
            imagemASalvar = imgTemp;
            graphicsImagemASalvar = graphcisImgTemp;
        }
    }
}
