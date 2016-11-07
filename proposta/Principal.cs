using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sharpPDF;
using sharpPDF.Enumerators;
using sharpPDF.Exceptions;
using System.IO;
using System.Diagnostics;

namespace GeradorDeProposta
{

    public partial class Principal : Form
    {
        Proposta proposta = new Proposta();
        BindingSource bSource = new BindingSource();
        public Principal()
        {
            InitializeComponent();
            bSource.DataSource = this.proposta.lista;

            dgProdutos.DataSource = bSource;
            if (proposta.lista.Count() == 0)
            {
                btExcluir.Enabled = false;
            }

            txtEntrada.Text = "0";
            txtEntrada.Enabled = false;
            txtVolume.Enabled = false;
            ddlPeriodo.Enabled = false;

            //teste
            if (!System.IO.Directory.Exists("teste__"))
                Directory.CreateDirectory("teste__");
            //teste
            //btContratoComodato.Enabled = false;
            //btContratoReserva.Enabled = false;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            this.periodoTableAdapter.Fill(this.dadosDataSet.Periodo);
            this.condicaoTableAdapter.Fill(this.dadosDataSet.Condicao);
            this.produtoTableAdapter.Fill(this.dadosDataSet.Produto);
            txtImagem.Visible = false;
            cbGeraFornMerc.Enabled = false;
            cbGeraResDom.Enabled = false;
            cbGeraTradein.Enabled = false;

            dgProdutos.Columns.Remove("Imagem");
        }
        private int ObterCodigo()
        {
            int retorno = 0;
            //se a lista estiver vazia retorna o código 1
            if (proposta.lista.Count == 0)
            {
                retorno = 1;
                return retorno;
            }
            //senão retona o maior código da lista mais 1
            else
            {
                retorno = proposta.lista.Max(x => x.ItemPropostaID) + 1;
                return retorno;
            }
        }
        private decimal CalculaComodato(decimal entrada, decimal preco, decimal volume, string periodostr)
        {
            decimal meses = 0;
            if (periodostr == "1 Ano ") meses = 12;
            if (periodostr == "2 Anos") meses = 24;
            if (periodostr == "3 Anos") meses = 36;

            return Math.Round(((preco-entrada) / meses / volume), 2);
        }
        private void cbComodato_CheckedChanged(object sender, EventArgs e)
        {
            txtEntrada.Enabled = cbComodato.Checked;
            txtVolume.Enabled = cbComodato.Checked;
            ddlPeriodo.Enabled = cbComodato.Checked;
            ddlCondicao.Enabled = !cbComodato.Checked;
        }
        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            ItemDeProposta item = new ItemDeProposta();
            item.ItemPropostaID = ObterCodigo();
            item.ProdutoNome = ddlProduto.Text;
            item.Moeda = txtMoeda.Text;
            item.Preco = txtPreco.Text;
            item.Imagem = txtImagem.Text;
            if (cbComodato.Enabled && cbComodato.Checked)
            {
                item.Condicao = "Comodato US$" + CalculaComodato(Convert.ToDecimal(txtEntrada.Text), Convert.ToDecimal(txtPreco.Text),
                    Convert.ToDecimal(txtVolume.Text), ddlPeriodo.Text) + " adicional por m2 ";
                if ((Convert.ToDecimal(txtEntrada.Text)!=0)) item.Condicao+="c/ entrada de "+item.Moeda+Convert.ToDecimal(txtEntrada.Text).ToString()+" ";
                item.Periodo = ddlPeriodo.Text;
                item.Volume = txtVolume.Text + " m2/mês";
            }
            else
                item.Condicao = ddlCondicao.Text;

            if (cbTradein.Checked)
                txtObs.Text = txtObs.Text + "- APLICADO DESCONTO 20% TRADE-IN EPSON. REQUER TERMO ASSINADO \n";

            proposta.lista.Add(item);
            bSource.ResetBindings(true);
            btExcluir.Enabled = true;
            cbTradein.Checked = false;
            dgProdutos.AutoResizeColumns();
            dgProdutos.Columns.Remove("Imagem");
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(dgProdutos.CurrentRow.Cells[0].Value);
            var item = proposta.lista.SingleOrDefault(x => x.ItemPropostaID == cod);
            //recupero o objeto cliente e excluo ele da lista recarrego
            //o grid e exibo a mensagem de sucesso
            proposta.lista.Remove(item);
            // CarregaDataGridView();
            //MessageBox.Show("Cliente Excluído com sucesso");
            bSource.ResetBindings(true);
        }
        private void ddlProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCondicao.Enabled = true;
        }
        private void btSalvarProposta_Click(object sender, EventArgs e)
        {
            pdfDocument myDoc = new pdfDocument("PROPOSTA", "IBF"); //cria o pdf
            int i = 1;
            int totalpag = bSource.Count + 1;

            #region itens
            foreach (ItemDeProposta item in bSource) //para cada produto
            {
                pdfPage myPage = myDoc.addPage();
                myPage.addImage(@"c:\propostas\cabeca.jpg", 0, 730);
                myPage.addText("Proposta IBF - Página " + i.ToString() + " de " + totalpag.ToString(), 500, 720,
                    predefinedFont.csHelveticaOblique, 8, predefinedColor.csDarkBlue);

                if (i == 1) //se está na primeira pagina
                {
                    myPage.addText("São Paulo, " + ucData.Text, 20, 690, predefinedFont.csHelveticaBold, 10, predefinedColor.csBlack);
                    myPage.addText("À " + txtCliente.Text + "(Cód." + txtCodCli.Text + " )", 20, 675,
                        predefinedFont.csHelveticaBold, 10, predefinedColor.csBlack);

                    myPage.addText("A/C Sr(a). " + txtContato.Text, 20, 660, predefinedFont.csHelvetica, 10, predefinedColor.csBlack);
                    myPage.addText("Prezado(a) cliente, temos a satisfação de apresentar a nossa proposta de fornecimento para"
                        + " os produtos a seguir descritos:", 20, 635, predefinedFont.csHelvetica, 10, predefinedColor.csBlack);
                }

                myPage.addText("Item " + i.ToString() + ":" + item.ProdutoNome.ToString(), 20, 615, predefinedFont.csHelveticaBold, 12, predefinedColor.csBlack);
                i++;

                myPage.addImage(@"c:\propostas\" + item.Imagem.ToString() + ".jpg", 20, 40, 570, 570);
                myPage.addImage(@"c:\propostas\rodape.jpg", 0, 0);

            }
            #endregion
            #region Condicoes
            pdfPage myPage2 = myDoc.addPage();
            myPage2.addImage(@"c:\propostas\cabeca.jpg", 0, 730);
            myPage2.addText("Proposta IBF - Página " + totalpag.ToString() + " de " + totalpag.ToString(), 500, 720,
                    predefinedFont.csHelveticaOblique, 8, predefinedColor.csDarkBlue);

            myPage2.addText("Condições Comerciais:", 20, 660, predefinedFont.csHelveticaBold, 10, predefinedColor.csBlack);

            if (txtObs.Text != "")
            {
                myPage2.addText("Observações: " + txtObs.Text, 20, 490, predefinedFont.csHelveticaBold, 9, predefinedColor.csDarkBlue);

            }

            pdfTable myTable = new pdfTable();
            //Set table's border
            myTable.borderSize = 1;
            myTable.borderColor = predefinedColor.csBlack;
            /*Create table's header*/
            myTable.tableHeader.addColumn(new pdfTableColumn("Item", predefinedAlignment.csRight, 30));
            myTable.tableHeader.addColumn(new pdfTableColumn("Produto", predefinedAlignment.csCenter, 180));
            myTable.tableHeader.addColumn(new pdfTableColumn("Preço", predefinedAlignment.csLeft, 80));
            myTable.tableHeader.addColumn(new pdfTableColumn("Condição", predefinedAlignment.csLeft, 280));
            myTable.tableHeaderStyle = new pdfTableRowStyle(predefinedFont.csHelveticaBold, 12, predefinedColor.csBlack, predefinedColor.csLightCyan);
            myTable.rowStyle = new pdfTableRowStyle(predefinedFont.csHelveticaBold, 7, predefinedColor.csBlack, predefinedColor.csWhite);

            foreach (ItemDeProposta item in bSource) //para cada produto
            {
                pdfTableRow myRow = myTable.createRow();
                myRow[0].columnValue = item.ItemPropostaID.ToString();
                myRow[1].columnValue = item.ProdutoNome;
                myRow[2].columnValue = item.Moeda + item.Preco;
                myRow[3].columnValue = item.Condicao + item.Periodo + " " + item.Volume;
                myTable.addRow(myRow);
            }

            myPage2.addTable(myTable, 20, 640);
            myPage2.addImage(@"c:\propostas\condicoes.jpg", 10, 50, 400, 600);
            myPage2.addImage(@"c:\propostas\rodape.jpg", 0, 0);
            #endregion

            if (!System.IO.Directory.Exists("c:\\propostas"))
                Directory.CreateDirectory("c:\\propostas");

            string newFile = @"c:\propostas\proposta_" + txtCliente.Text + "_" + ".pdf";

            myDoc.createPDF(newFile);
            //myPage = null;
            myDoc = null;

            //abre o pdf
            string sTmp = newFile;
            MessageBox.Show("PDF gravado com sucesso !\n\n  " + sTmp, "OK");
            Process p = new Process();
            ProcessStartInfo s = new ProcessStartInfo(sTmp);
            p.StartInfo = s;
            p.Start();
        }

        private void cbTradein_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTradein.Checked)
            {
                txtPreco.Text = (Convert.ToDouble(txtPreco.Text) * 0.8).ToString("n");
                cbGeraTradein.Enabled = true;
            }

            if (!cbTradein.Checked)
            {
                txtPreco.Text = (Convert.ToDouble(txtPreco.Text) / 0.8).ToString("n");
                cbGeraTradein.Enabled = false;
            }
        }


        //gerar pdf contrato - abrir nova janela para preenchimento de dados adicionais
    }
}
