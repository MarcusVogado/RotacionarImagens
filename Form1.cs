using System;
using System.Drawing;
using System.Windows.Forms;

namespace Image_Rotator
{
    public partial class Form1 : Form
    {
        Image IMG1;
        public Form1()
        {
            InitializeComponent();
            
        }
        // funções para rotacionar
        public void D180_Flip_None()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate180FlipNone);
            Pic_IMG.Image = IMG1;
        }
        //-----------------------------------------------------------
        public void D180_Flip_X()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate180FlipX);
            Pic_IMG.Image = IMG1;
        }
        //-------------------------------------------------------------
        public void D180_Flip_XY()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate180FlipXY);
            Pic_IMG.Image = IMG1;
        }
        //---------------------------------------------------------------
        public void D180_Flip_Y()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate180FlipY);
            Pic_IMG.Image = IMG1;
        }
        //-----------------------------------------------------------------
        public void D270_Flip_None()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Pic_IMG.Image = IMG1;
        }
        //----------------------------------------------------------------
        public void D270_Flip_X()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate270FlipX);
            Pic_IMG.Image = IMG1;
        }
        //--------------------------------------------------------------------
        public void D270_Flip_XY()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate270FlipXY);
            Pic_IMG.Image = IMG1;
        }
        //---------------------------------------------------------------------
        public void D270_Flip_Y()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate270FlipY);
            Pic_IMG.Image = IMG1;
        }
        //-----------------------------------------------------------------------
        public void D90_Flip_None()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Pic_IMG.Image = IMG1;
        }
        //-------------------------------------------------------------------------
        public void D90_Flip_X()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate90FlipX);
            Pic_IMG.Image = IMG1;
        }
        //--------------------------------------------------------------------------
        public void D90_Flip_XY()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate90FlipXY);
            Pic_IMG.Image = IMG1;
        }
        //--------------------------------------------------------------------------
        public void D90_Flip_Y()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.Rotate90FlipY);
            Pic_IMG.Image = IMG1;
        }
        //----------------------------------------------------------------------------
        public void None_Flip_None()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            Pic_IMG.Image = IMG1;
        }
        //---------------------------------------------------------------------------
        public void None_Flip_X()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Pic_IMG.Image = IMG1;
        }
        //---------------------------------------------------------------------------
        public void None_Flip_XY()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            Pic_IMG.Image = IMG1;
        }
        //----------------------------------------------------------------------------
        public void None_Flip_Y()
        {
            IMG1 = (Image)Image.FromFile(IMG_Path.Text);
            IMG1.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Pic_IMG.Image = IMG1;
        }
        // Fim das funções

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OFD1.Filter = "Arq. Imagens(*.JPG;*.BMP;*.PNG;*.GIF)|*.jpg;*.bmp;*.png;*.gif";
            OFD1.ShowDialog();
            IMG_Path.Text = OFD1.FileName;
            Pic_IMG.Image = Image.FromFile(IMG_Path.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string destino = "C:\\dados\\imgs";

            if (Pic_IMG.Image == null)
            {
                MessageBox.Show("Você tem que selecionar um arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (cboSalvarFormato.SelectedIndex)
                {
                    case 0:
                        IMG1.Save(destino + "\\Temp.jpg");
                        MessageBox.Show("Arquivo Salvo em : " + destino );
                        break;

                    case 1:
                        IMG1.Save(destino + "\\Temp.BMP");
                        MessageBox.Show("Arquivo Salvo em : " + destino);
                        break;

                    case 2:
                        IMG1.Save(destino + "\\Temp.PNG");
                        MessageBox.Show("Arquivo Salvo em : " + destino);
                        break;

                    case 3:
                        IMG1.Save(destino + "\\Temp.GIF");
                        MessageBox.Show("Arquivo Salvo em : " + destino);
                        break;

                    default :
                        MessageBox.Show("Formato Inválido !!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void cboRotacionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboRotacionar.SelectedIndex)
            {
                case 0:
                    D180_Flip_None();
                    break;
                case 1:
                    D180_Flip_X();
                    break;
                case 2:
                    D180_Flip_XY();
                    break;
                case 3:
                    D180_Flip_Y();
                    break;
                case 4:
                    D270_Flip_None();
                    break;
                case 5:
                    D270_Flip_X();
                    break;
                case 6:
                    D270_Flip_XY();
                    break;
                case 7:
                    D270_Flip_Y();
                    break;
                case 8:
                    D90_Flip_None();
                    break;
                case 9:
                    D90_Flip_X();
                    break;
                case 10:
                    D90_Flip_XY();
                    break;
                case 11:
                    D90_Flip_Y();
                    break;
                case 12:
                    None_Flip_None();
                    break;
                case 13:
                    None_Flip_X();
                    break;
                case 14:
                    None_Flip_XY();
                    break;
                case 15:
                    None_Flip_Y();
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}