using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    class LogicaJogo
    {
        private int[,] matrizBase = new int[3, 3];
        public int turno = 0;
        private string vencedor = "";
        private int vencedorID = 0;



        public LogicaJogo() {
            Array.Clear(matrizBase, 0, matrizBase.Length);
            

        }

        public void atualizaPosicao(string posicao)
        {
            if(posicao == "btn_00")
            {
                if(turno % 2 == 0)
                {
                    matrizBase[0, 0] = -1;
                }
                else matrizBase[0, 0] = 1;

                turno++;

            }
            else if(posicao == "btn_01")
            {
                if (turno % 2 == 0)
                {
                    matrizBase[0, 1] = -1;
                }
                else matrizBase[0, 1] = 1;

                turno++;
            }
            else if (posicao == "btn_02")
            {
                if (turno % 2 == 0)
                {
                    matrizBase[0, 2] = -1;
                }
                else matrizBase[0, 2] = 1;

                turno++;
            }
            else if (posicao == "btn_10")
            {
                if (turno % 2 == 0)
                {
                    matrizBase[1, 0] = -1;
                }
                else matrizBase[1, 0] = 1;

                turno++;
            }
            else if (posicao == "btn_11")
            {
                if (turno % 2 == 0)
                {
                    matrizBase[1, 1] = -1;
                }
                else matrizBase[1, 1] = 1;

                turno++;
            }
            else if (posicao == "btn_12")
            {
                if (turno % 2 == 0)
                {
                    matrizBase[1, 2] = -1;
                }
                else matrizBase[1, 2] = 1;

                turno++;
            }
            else if (posicao == "btn_20")
            {
                matrizBase[2, 0] = (turno % 2 == 0) ? - 1 : 1;

                turno++;
            }
            else if (posicao == "btn_21")
            {
                if (turno % 2 == 0)
                {
                    matrizBase[2, 1] = -1;
                }
                else matrizBase[2, 1] = 1;

                turno++;
            }
            else if (posicao == "btn_22")
            {
                if (turno % 2 == 0)
                {
                    matrizBase[2, 2] = -1;
                }
                else matrizBase[2, 2] = 1;

                turno++;
            }
        }

        public void leituraMatriz()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MessageBox.Show((this.matrizBase[i, j]).ToString());
                }
            }
        }

        public void log()
        {
            MessageBox.Show("testeBrum2");
            //System.Diagnostics.Debug.WriteLine("Teste do brum");
        }

        public int atualizaTurno()
        {
            return turno;
        }

        public int verificaVitoria()
        {
            int acumulador = 0;
            int vencedorID = -1;

            //somatoria de linhas
            for (int i = 0; i < 3; i++)
            {
                acumulador = 0;

                for (int j = 0; j < 3; j++)
                {
                    acumulador = acumulador + this.matrizBase[i,j];
                }

                if(acumulador == 3)
                {
                    vencedorID = 0;
                }
                else if(acumulador == -3)
                {
                    vencedorID = 1;
                }
            }

            //somatoria de colunas
            for (int j = 0; j < 3; j++)
            {
                acumulador = 0;

                for (int i = 0; i < 3; i++)
                {
                    acumulador = acumulador + this.matrizBase[i, j];
                    //MessageBox.Show("col j: " + j.ToString() + "\nlin i: " + i.ToString() + "\nval: " + (this.matrizBase[i, j]).ToString());
                }
                MessageBox.Show("col: " + j.ToString() + "\nacumulador: " + acumulador.ToString());
                if (acumulador == 3)
                {
                    vencedorID = 0;
                }
                else if (acumulador == -3)
                {
                    vencedorID = 1;
                }
            }

            //somatoria diagonais

            acumulador = 0;
            acumulador = this.matrizBase[0, 0] + this.matrizBase[1, 1] + this.matrizBase[2, 2];
            if (acumulador == 3)
            {
                vencedorID = 0;
            }
            else if (acumulador == -3)
            {
                vencedorID = 1;
            }

            acumulador = 0;
            acumulador = this.matrizBase[0, 2] + this.matrizBase[1, 1] + this.matrizBase[2, 0];
            if (acumulador == 3)
            {
                vencedorID = 0;
            }
            else if (acumulador == -3)
            {
                vencedorID = 1;
            }


            return vencedorID;
        }

    }
}
