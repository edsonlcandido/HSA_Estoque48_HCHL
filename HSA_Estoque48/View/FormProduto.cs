﻿using HSA_Estoque.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSA_Estoque.View
{
    public partial class FormProduto : Form
    {
        Presenter.Produto _presenterProduto;
        Presenter.Tipo _presenterTipo;
        Presenter.Unidade _presenterUnidade;
        FormProduto()
        {
            InitializeComponent();
        }

        public FormProduto(Presenter.Produto presenterProduto, Presenter.Tipo presenterTipo, Presenter.Unidade presenterUnidade)
        {
            InitializeComponent();
            _presenterProduto = presenterProduto;            
            _presenterTipo = presenterTipo;
            _presenterUnidade = presenterUnidade;

            var listaTipo = from tipo in _presenterTipo.showAll
                            where tipo.visible == true
                            select tipo.name;

            var listaUnidade = from unidade in _presenterUnidade.showAll
                               where unidade.visible == true
                               select unidade.name;
            comboBoxTipo.DataSource = listaTipo.ToList();
            comboBoxUnidade.DataSource = listaUnidade.ToList();

            buttonEditarProduto.Visible = false;
            buttonEditarProduto.Enabled = false;
        }

        public FormProduto(Produto presenterProduto, Tipo presenterTipo, Unidade presenterUnidade, Model.Produto modelProduto)
        {
            InitializeComponent();
            _presenterProduto = presenterProduto;
            _presenterTipo = presenterTipo;
            _presenterUnidade = presenterUnidade;

            var listaTipo = from tipo in _presenterTipo.showAll
                            where tipo.visible == true
                            select tipo.name;

            var listaUnidade = from unidade in _presenterUnidade.showAll
                               where unidade.visible == true
                               select unidade.name;
            comboBoxTipo.DataSource = listaTipo.ToList();
            comboBoxUnidade.DataSource = listaUnidade.ToList();

            this.Text = "HSA Estoque - edição de produto";
            textBoxProdutoId.Enabled = false;
            textBoxProdutoQuantidadeTotal.Enabled = false;
            labelInseridoPor.Text = "Alterado por";
            labelDataInclusao.Text = "Data modificação";

            buttonEditarProduto.Visible = true;
            buttonEditarProduto.Enabled = true;
            buttonAdicionaProduto.Visible = false;
            buttonAdicionaProduto.Enabled = false;
            buttonEditarProduto.Location = buttonAdicionaProduto.Location;

            textBoxProdutoId.Text = modelProduto.id.ToString();
            textBoxProdutoDescricao.Text = modelProduto.descricao;
            textBoxProdutoQuantidadeTotal.Text = modelProduto.quantidadeTotal.ToString();
            textBoxProdutoQuantidadeMinima.Text = modelProduto.quantidadeMinima.ToString();
            textBoxProdutoQuantidadeMaxima.Text = modelProduto.quantidadeMaxima.ToString();
            textBoxProdutoLeadTime.Text = modelProduto.leadTime.ToString();
            //comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxTipo.Text = modelProduto.tipo;
            //comboBoxUnidade.DropDownStyle= ComboBoxStyle.DropDown;
            comboBoxUnidade.Text = modelProduto.unidade;
            //comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBoxUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxProdutoLocalizacao.Text=modelProduto.localizacao.ToString();
            textBoxProdutoCaixa.Text=modelProduto.caixa.ToString();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

            textBoxInseridoPor.Text = Environment.UserName;
            textBoxDataInclusão.Text = DateTime.Now.ToString("d");
        }

        private void buttonAdicionaProduto_Click(object sender, EventArgs e)
        {
            _presenterProduto.id =Convert.ToInt32(textBoxProdutoId.Text);
            _presenterProduto.descricao = textBoxProdutoDescricao.Text;
            _presenterProduto.quantidadeTotal = Convert.ToDouble(textBoxProdutoQuantidadeTotal.Text);
            _presenterProduto.quantidadeMinima = Convert.ToDouble(textBoxProdutoQuantidadeMinima.Text);
            _presenterProduto.quantidadeMaxima = Convert.ToDouble(textBoxProdutoQuantidadeMaxima.Text);
            _presenterProduto.leadTime = Convert.ToInt32(textBoxProdutoLeadTime.Text);
            _presenterProduto.tipo = comboBoxTipo.Text;
            _presenterProduto.unidade = comboBoxUnidade.Text;
            _presenterProduto.localizacao = textBoxProdutoLocalizacao.Text;
            _presenterProduto.caixa = textBoxProdutoCaixa.Text;

            if (_presenterProduto.add() > 1)
            {
                MessageBox.Show("Produto incluido com sucesso.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possivél a inclusão.");
            } 
        }

        private void buttonEditarProduto_Click(object sender, EventArgs e)
        {
            _presenterProduto.id = Convert.ToInt32(textBoxProdutoId.Text);
            _presenterProduto.descricao = textBoxProdutoDescricao.Text;
            _presenterProduto.quantidadeTotal = Convert.ToDouble(textBoxProdutoQuantidadeTotal.Text);
            _presenterProduto.quantidadeMinima = Convert.ToDouble(textBoxProdutoQuantidadeMinima.Text);
            _presenterProduto.quantidadeMaxima = Convert.ToDouble(textBoxProdutoQuantidadeMaxima.Text);
            _presenterProduto.leadTime = Convert.ToInt32(textBoxProdutoLeadTime.Text);
            _presenterProduto.tipo = comboBoxTipo.Text;
            _presenterProduto.unidade = comboBoxUnidade.Text;
            _presenterProduto.localizacao = textBoxProdutoLocalizacao.Text;
            _presenterProduto.caixa = textBoxProdutoCaixa.Text;

            _presenterProduto.update();
            this.Close();
        }
    }
}
