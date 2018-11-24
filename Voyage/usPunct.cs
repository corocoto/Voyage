using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyage
{
    public partial class usPunct : UserControl
    {
        bool clickImg;
        string click="";
        int rating = 0;
        public void printStars(PictureBox nameOfPicture)
        {
            switch (nameOfPicture.Name.ToString())
            {
                case "oneStar":
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "twoStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "threeStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    twoStars.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "fourStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    twoStars.Load(@"img\btn\star_orange.png");
                    threeStars.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
                case "fiveStars":
                    oneStar.Load(@"img\btn\star_orange.png");
                    twoStars.Load(@"img\btn\star_orange.png");
                    threeStars.Load(@"img\btn\star_orange.png");
                    fourStars.Load(@"img\btn\star_orange.png");
                    nameOfPicture.Load(@"img\btn\star_orange.png");
                    break;
            }
        }

        public void printStarsBack(PictureBox nameOfPicture, bool star,string click)
        {
            if (star)
            {
               if (click!= "")
               {
                    switch (click)
                    {
                        case "oneStar":
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_blue.png");
                            threeStars.Load(@"img\btn\star_blue.png");
                            fourStars.Load(@"img\btn\star_blue.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                            rating = 1;
                            break;
                        case "twoStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            threeStars.Load(@"img\btn\star_blue.png");
                            fourStars.Load(@"img\btn\star_blue.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                            rating = 2;
                            break;
                        case "threeStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            fourStars.Load(@"img\btn\star_blue.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                            rating = 3;
                            break;
                        case "fourStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_orange.png");
                            threeStars.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            fiveStars.Load(@"img\btn\star_blue.png");
                            rating = 4;
                            break;
                        case "fiveStars":
                            oneStar.Load(@"img\btn\star_orange.png");
                            twoStars.Load(@"img\btn\star_orange.png");
                            threeStars.Load(@"img\btn\star_orange.png");
                            fourStars.Load(@"img\btn\star_orange.png");
                            nameOfPicture.Load(@"img\btn\star_orange.png");
                            rating = 5;
                            break;
                    }
               }
            }
            else
            {
                oneStar.Load(@"img\btn\star_blue.png");
                twoStars.Load(@"img\btn\star_blue.png");
                threeStars.Load(@"img\btn\star_blue.png");
                fourStars.Load(@"img\btn\star_blue.png");
                fiveStars.Load(@"img\btn\star_blue.png");
            }
           // MessageBox.Show(rating.ToString());
        }

        public usPunct()
        {
            InitializeComponent();
            clickImg = false;
            this.ForeColor = Color.FromArgb(0, 71, 160);
            pBorderLeft.BackColor = Color.FromArgb(0, 71, 160);
            pBorderRight.BackColor = Color.FromArgb(0, 71, 160);
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel4.BackColor = Color.FromArgb(0, 71, 160);
        }

        private void oneStar_MouseEnter(object sender, EventArgs e)
        {
            printStars((sender as PictureBox));
           // MessageBox.Show("название:" + (sender as PictureBox).Name.ToString());
        }

        private void oneStar_MouseLeave(object sender, EventArgs e)
        {
           
            printStarsBack((sender as PictureBox), clickImg,click);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
            {
                label11.Visible = false;
                tbSearch.Visible = false;
            }
            else
            {
                label11.Visible = true;
                tbSearch.Visible = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void oneStar_Click(object sender, EventArgs e)
        {
            clickImg = true;
            click = (sender as PictureBox).Name.ToString();
            printStarsBack((sender as PictureBox), clickImg, click);
        }
    }
}
