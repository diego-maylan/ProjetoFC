﻿using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using Biblioteca.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFabricaCosmeticos
{
    public partial class FormCadastroItemFormula : Form
    {
        List<MateriaPrima> listaMateria = new List<MateriaPrima>();
        List<Produto> listaProduto = new List<Produto>();

        public FormCadastroItemFormula()
        {
            InitializeComponent();
            ListarProdutoCombo();
            ListarMateriaCombo();
        }

        private void ListarProdutoCombo()
        {
            try
            {
                ProdutoNegocio dados = new ProdutoNegocio();
                Produto filtro = new Produto();
                listaProduto = dados.Select(filtro);
                comboBoxProduto.Items.Clear();
                foreach (Produto p in listaProduto)
                {
                    comboBoxProduto.Items.Add(p.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarMateriaCombo()
        {
            try
            {
                MateriaPrimaNegocio dados = new MateriaPrimaNegocio();
                MateriaPrima filtro = new MateriaPrima();
                listaMateria = dados.Select(filtro);
                comboBoxMateriaPrima.Items.Clear();
                foreach (MateriaPrima m in listaMateria)
                {
                    comboBoxMateriaPrima.Items.Add(m.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int indexProduto = comboBoxProduto.SelectedIndex;
                if (indexProduto < 0)
                {
                    MessageBox.Show("Selecionar o produto");
                    comboBoxProduto.Focus();
                    return;
                }

                int indexMateriaPrima = comboBoxMateriaPrima.SelectedIndex;
                if (indexMateriaPrima < 0)
                {
                    MessageBox.Show("Selecionar a matéria prima");
                    comboBoxMateriaPrima.Focus();
                    return;
                }

                Produto p = listaProduto.ElementAt(indexProduto);
                p.MateriaPrima.Add(listaMateria.ElementAt(indexMateriaPrima));

                FormulaDados dados = new FormulaDados();
                dados.CadastrarFormula(p);
                MessageBox.Show("Formula cadastrada com sucesso");

                comboBoxProduto.SelectedIndex = -1;
                comboBoxMateriaPrima.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}