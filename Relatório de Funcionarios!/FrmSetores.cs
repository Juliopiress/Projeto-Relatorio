using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatório_de_Funcionarios_
{
    public partial class FrmSetores : Form
    {
        public FrmSetores()
        {
            InitializeComponent();
        }

        private void RadPadaria_CheckedChanged(object sender, EventArgs e)
        {
            PicSetores.Image = Properties.Resources.padaria;
            LblDescr1.Text = "Setor Responsavél pela venda de paes bolos e massas";
            LblDesc2.Text = "É nescessario ter o conhecimento em massas\n e agilidade na hora do atendimento";
        }

        private void RadHortifruti_CheckedChanged(object sender, EventArgs e)
        {
            PicSetores.Image = Properties.Resources.Hortfruiti1;
            LblDescr1.Text = "Setor Responsavél pela vendas de frutas e legumes";
            LblDesc2.Text = "É necessario ter uma boa reposição das frutas e legumes\n e uma boa observação";
        }

        private void RadCaixa_CheckedChanged(object sender, EventArgs e)
        {
            PicSetores.Image = Properties.Resources.Caixa;
            LblDescr1.Text = "Setor Responsavél pela somas e pagamentos dos produtos";
            LblDesc2.Text = "É necessario ter bastante atençaõ na hora da soma\n e não dar o troco errado para o cliente";
        }

        private void RadAçogue_CheckedChanged(object sender, EventArgs e)
        {
            PicSetores.Image = Properties.Resources.Açogue1;
            LblDesc2.Text = "Setor Responsavél pela venda de carnes e congelados";
            LblDesc2.Text = "É nescerio ter o conhecimento e carnes\n e um bom atendimento";
        }

        private void FrmSetores_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
