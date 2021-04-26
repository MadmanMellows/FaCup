﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaCup
{
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
            Image myimage = new Bitmap(@"C:\Users\darkx\source\repos\FaCup\FaCup\Resources\facupbackground.png");
            this.BackgroundImage = myimage;
        }

        private async void Draw_Load(object sender, EventArgs e)
        {
            txtTeamList.GotFocus += txtTeamList_GotFocus;
        }
       


        //Changes focus away form text box to remove unwanted cursor
        private void txtTeamList_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }
        //Testing shuffle button
        private async void btnShuffle_Click(object sender, EventArgs e)
        {
            txtTeamList.Text = null;
            var file = new FileInfo(@"C:\Users\darkx\source\repos\FaCup\FaCup\Resources\FinalTeams.xlsx");
            TeamModel.TeamList = await DataAccess.LoadRemainingTeams(file);
            TeamModel.TeamList.ShuffleTeams();
            int counter = 1;

            foreach (var team in TeamModel.TeamList)
            {
                team.DrawId = counter;
                txtTeamList.Text += counter +") " + team.TeamName +  Environment.NewLine;
                counter++;
            }
            
        }
        //Testing
        private void btnDrawTeams_Click(object sender, EventArgs e)
        {
            foreach (var item in TeamModel.TeamList)
            {
                if(item.TeamName == "Manchester United")
                {
                    lblTeam1.Text = item.LeaugeName;
                }    
            }
        }
    }
}
