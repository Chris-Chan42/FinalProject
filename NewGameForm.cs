using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinalProject
{
    public partial class NewGameForm : Form
    {
        private Form1 _form;
        private int GamerCount;
        private bool IsEditing;
        private int CurrentGamerId;
        public NewGameForm(Form1 form)
        {
            InitializeComponent();
            _form = form;
            GamerCount = 1;
            IsEditing = false;
            CurrentGamerId = -1;
        }

        public void ToggleEdit(bool newState)
        {
            IsEditing = newState;
        }

        private void CreateGamer()
        {
            Gamer gamer = new Gamer
            {
                GamerId = GamerCount,
                Name = txtName.Text,
                FavoriteGame = txtFavoriteGame.Text,
                Platform = txtPlatform.Text,
                Hours = txtHours.Text
            };

            _form.AddGamer(gamer);
            GamerCount++;
        } 

        private void EditGamer()
        {
            MessageBox.Show("Editing in progress");
            _form.EditGamer(CurrentGamerId, new Gamer
            {
                GamerId = CurrentGamerId,
                Name = txtName.Text,
                FavoriteGame = txtFavoriteGame.Text,
                Platform = txtPlatform.Text,
                Hours = txtHours.Text
            });

            CurrentGamerId = -1;
            ToggleEdit(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsEditing) 
            {
                EditGamer();
            }
            else
            {
                CreateGamer();
            }

            ClearForm();

            Hide();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtFavoriteGame.Text = "";
            txtPlatform.Text = "";
            txtHours.Text = "";
        }

        public void LoadGamer(Gamer gamer)
        {
            CurrentGamerId = gamer.GamerId;
            txtName.Text = gamer.Name;
            txtFavoriteGame.Text = gamer.FavoriteGame;
            txtPlatform.Text = gamer.Platform;
            txtHours.Text = gamer.Hours;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
