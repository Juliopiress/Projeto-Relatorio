using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// blibioteca usada para salvar

namespace Relatório_de_Funcionarios_
{
    public partial class Frm_Relatorio : Form
    {
        public Frm_Relatorio()
        {
            InitializeComponent();
        }

        private void RadioPadaria_CheckedChanged(object sender, EventArgs e)
        {
            LblSetordesc.Text = "Relatorio setor padaria";// comando para aparecer frase na label de acordo com cada butaão

            //comando para habilitar as label os textbox os chek box e butoes
            LblCargos.Enabled = true;
            LblCpf.Enabled = true;
            LblInfor.Visible = true;
            LblNome.Enabled = true;
            LblTitulo.Enabled = true;
            TxtCpf.Enabled = true;
            Txthoratrabalhar.Enabled = true;
            Txtnome.Enabled = true;
            TxtRelatorio.Enabled = true;
            chekSsair.Enabled = true;
            ChekFalta.Enabled = true;
            Chekatraso.Enabled = true;
            menuStrip1.Enabled = true;
            CmbCargos.Enabled = true;
           
            BtnApagar.Enabled = true;
            BtnApagar2.Enabled = true;
            label1.Enabled = true;

        }

        private void RadioHortifruti_CheckedChanged(object sender, EventArgs e)
        {
            LblSetordesc.Text = "Relatorio setor Hortfruti";// comando para aparecer frase na label de acordo com cada butaão

            //comando para habilitar as label os textbox os chek box e butoes
            LblCargos.Enabled = true;
            LblCpf.Enabled = true;
            LblInfor.Visible = true;
            LblNome.Enabled = true;
            LblTitulo.Enabled = true;
            TxtCpf.Enabled = true;
            Txthoratrabalhar.Enabled = true;
            Txtnome.Enabled = true;
            TxtRelatorio.Enabled = true;
            chekSsair.Enabled = true;
            ChekFalta.Enabled = true;
            Chekatraso.Enabled = true;
            menuStrip1.Enabled = true;
            CmbCargos.Enabled = true;
            BtnApagar.Enabled = true;
            BtnApagar2.Enabled = true;
            label1.Enabled = true;
        }

        private void RadioCaixa_CheckedChanged(object sender, EventArgs e)
        {
            LblSetordesc.Text = "Relatorio setor Caixa";// comando para aparecer frase na label de acordo com cada butaão

            //comando para habilitar as label os textbox os chek box e butoes
            LblCargos.Enabled = true;
            LblCpf.Enabled = true;
            LblInfor.Visible = true;
            LblNome.Enabled = true;
            LblTitulo.Enabled = true;
            TxtCpf.Enabled = true;
            Txthoratrabalhar.Enabled = true;
            Txtnome.Enabled = true;
            TxtRelatorio.Enabled = true;
            chekSsair.Enabled = true;
            ChekFalta.Enabled = true;
            Chekatraso.Enabled = true;
            menuStrip1.Enabled = true;
            CmbCargos.Enabled = true;
            BtnApagar.Enabled = true;
            BtnApagar2.Enabled = true;
            label1.Enabled = true;
        }

        private void RadioAçogue_CheckedChanged(object sender, EventArgs e)
        {
            LblSetordesc.Text = "Relatorio setor Açogue";// comando para aparecer frase na label de acordo com cada butaão

            //comando para habilitar as label os textbox os chek box e butoes
            LblCargos.Enabled = true;
            LblCpf.Enabled = true;
            LblInfor.Visible = true;
            LblNome.Enabled = true;
            LblTitulo.Enabled = true;
            TxtCpf.Enabled = true;
            Txthoratrabalhar.Enabled = true;
            Txtnome.Enabled = true;
            TxtRelatorio.Enabled = true;
            chekSsair.Enabled = true;
            ChekFalta.Enabled = true;
            Chekatraso.Enabled = true;
            menuStrip1.Enabled = true;
            CmbCargos.Enabled = true;
            BtnApagar.Enabled = true;
            BtnApagar2.Enabled = true;
            label1.Enabled = true;
        }

        private void CmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comando para a opção selecionada no combobox apareça no textbox a frente com
            //informação de carga horaria
            if (CmbCargos.Text == "Aprendiz")
            {
                Txthoratrabalhar.Text = "Carga Horaria de 6 horas";
            }

            else if (CmbCargos.Text == "Encarregado")
            {
                Txthoratrabalhar.Text = "Carga Horaria de 9";
            }
            else if (CmbCargos.Text == "Gerente")
            {
                Txthoratrabalhar.Text = "Carga horaria de 9 horas ou mais";
            }
            else
            {
                Txthoratrabalhar.Text = "Carga horaria de 8 horas";
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Txtnome.Text = "";
        }

        private void BtnApagar2_Click(object sender, EventArgs e)
        {
            TxtCpf.Text = "";
        }

        private void apagarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtCpf.Text = "";//comando ´pra apagar text box e label
            Txtnome.Text = "";
            TxtRelatorio.Text = "";
            CombSituacoes.SelectedItem = null;// comando para apagar comboBox
            Txthoratrabalhar.Text = "";
            CmbCargos.SelectedItem = null;
            chekSsair.Checked = false;
            Chekatraso.Checked = false;
            ChekFalta.Checked = false;
        }

        private void informaçõesSobreSetoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetores setores = new FrmSetores();//Comando pra chamar o form
            setores.Show();//comando para mostar form
        }

        private void chekSsair_CheckedChanged(object sender, EventArgs e)
        {
            LblSituacoes.ForeColor = Color.DarkGreen;//cor inserida para cada chek box
            LblSituacoes.Visible = true;// comando pra mostra a label
            CombSituacoes.Visible = true;//comando para mostrar o comb box
            LblSituacoes.Text = "Insira seu motivo de saida";//texto inserido na label de acordo com cada chekbox

            CombSituacoes.Items.Clear();//comando para limpar o comb box e mostrar só as frases abixo
            CombSituacoes.Items.Add("Saiu por motivos familiares");//comando para mostrar as frases
            CombSituacoes.Items.Add("Saiu por motivos de acidentes");
            CombSituacoes.Items.Add("Saiu por Motivos Particulares");
            CombSituacoes.Items.Add("Motivos de Acidentes na Rua");

            if (chekSsair.Checked == false)//comando para deixar invisivél a label e o combobox
            {
                CombSituacoes.Visible = false;
                LblSituacoes.Visible = false;
            }

            Chekatraso.Checked = false;
            ChekFalta.Checked = false;

            //if (Chekatraso.Checked || ChekFalta.Checked == true)
            //{
            //    chekSsair.Checked = false;
            //     ChekFalta.Checked = false;
            //}
        }

        private void ChekFalta_CheckedChanged(object sender, EventArgs e)
        {
            LblSituacoes.Visible = true;//comando para mostra a label
            CombSituacoes.Visible = true;//comando para mostrar o comb box
            LblSituacoes.Text = "Explique seu motivo de falta";//comando para mostra frase na label de acordo com cada chek box
            LblSituacoes.ForeColor = Color.Red;//comando para colocar cor na frase de acordo com cada chek box

            CombSituacoes.Items.Clear();//comando para limpar comb box e aparecer so as frases abaixo
            CombSituacoes.Items.Add("Faltou por atestado médico");//comando para receber a frase
            CombSituacoes.Items.Add("Motivos de mobilidade pulblica");
            CombSituacoes.Items.Add("Faltou por motivos de acidentes");
            CombSituacoes.Items.Add("Faltou por inegligencia no trasito");

            if (ChekFalta.Checked == false)//comando para deixar invisivél a label e o combobox
            {
                LblSituacoes.Visible = false;
                CombSituacoes.Visible = false;
            }
            chekSsair.Checked = false;
            Chekatraso.Checked = false;

            //if (chekSsair.Checked || Chekatraso.Checked == true)
            //{
            //    chekSsair.Checked = false;
            //    Chekatraso.Checked = false;
            //}
        }

        private void Chekatraso_CheckedChanged(object sender, EventArgs e)
        {
            LblSituacoes.Visible = true;//comando para deixar a label visivél
            CombSituacoes.Visible = true;//comando para deixa o combobox visivél
            LblSituacoes.Text = "Explique seu motivo de Atraso";//comando pra colocar frase na label de acordo com cada chek box
            LblSituacoes.ForeColor = Color.DarkViolet;//comando para mudar a cor de acordo com cada chek box

            CombSituacoes.Items.Clear();//comando para limpar combo box para receber apenas as frases abaixo
            CombSituacoes.Items.Add("Acordou fora do horario");//comando para adicionar frase
            CombSituacoes.Items.Add("Falha no sistema de transporte Publico");
            CombSituacoes.Items.Add("Foi resolver problemas Particular");
            CombSituacoes.Items.Add("Foi para uma consulta Medica");

            if (Chekatraso.Checked == false)//comando para sumir a lebel ou combo box
            {
                LblSituacoes.Visible = false;
                CombSituacoes.Visible = false;
            }
            chekSsair.Checked = false;
            ChekFalta.Checked = false;


            //if (chekSsair.Checked|| ChekFalta.Checked == true)
            //{
            //    chekSsair.Checked = false;
            //    ChekFalta.Checked = false;
                 
            //}
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontes = new FontDialog();//instacie ao font dialog com o fone fontes
            fontes.MinSize = 9;//ajusta o tamanho minimo da fonte
            fontes.MaxSize = 11;//ajuta o tamanho maximo dá fonte
            fontes.Color = ForeColor;//comando pra usuario poder selecionar a cor
            fontes.ShowColor = true;//mostra opções de cores
            fontes.AllowVectorFonts = false;

            DialogResult minhasfont = fontes.ShowDialog();
            if (minhasfont == DialogResult.OK)//comando para habilitar o butão ok
            {
                TxtRelatorio.ForeColor = fontes.Color;//faz com que o texto receba a cor desejada
                TxtRelatorio.Font = fontes.Font;//faz com que o texto receba a fonte desejada
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // comando para verificar se os campos de texto se estão escritos para pode salvar

            if (TxtRelatorio.Text == "" || TxtCpf.Text == "" || Txtnome.Text == "")
            {
                MessageBox.Show("Escreva os campos obrigatorios", "Aviso");//mensagem que aparece caso os campos estejam escritos

            }
            else
            {
                saveFileDialog1.ShowDialog();//comando para mostrar janela de save
            }
        }

        private void SalvarOk(object sender, CancelEventArgs e)
        {
            //comando para guarda os texto em uma string e salvar
            string arquivos = Txtnome.Text + TxtCpf.Text + CmbCargos.Text + Txthoratrabalhar.Text + ( TxtRelatorio.Text + CombSituacoes.Text);
            string name = saveFileDialog1.FileName;//comando parar habilitar o butão de salvar
            File.WriteAllText(name, arquivos);//comando para receber a string onde estão todos os texto inseridos
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;          
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
