using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        LogicaJogo jogo01;
        readonly char[] marcador = new char[]{'X','0'};


        public Form1()
        {
            InitializeComponent();

            jogo01 = new LogicaJogo();
            lbl_Turno.Text = "";
            lbl_Vencedor.Text = "";

        }

        private void evento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //this.jogo01.incrementa_turno();
            //MessageBox.Show(btn.Name);
            jogo01.atualizaPosicao(btn.Name);
            btn.Text = this.marcador[(jogo01.turno)%2].ToString();

            lbl_Turno.Text = ("Turno = " + (jogo01.atualizaTurno()).ToString());

            if(jogo01.verificaVitoria() != -1)
            {
                lbl_Vencedor.Text = ("Venceu o jogador " + (jogo01.verificaVitoria()).ToString());
            }
        }

        private void btn_iniciarJogo_Click(object sender, EventArgs e)
        {
            jogo01.leituraMatriz();
        }
    }
}
