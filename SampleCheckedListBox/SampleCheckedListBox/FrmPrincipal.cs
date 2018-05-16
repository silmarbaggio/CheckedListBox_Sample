using SampleCheckedListBox.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCheckedListBox
{
    public partial class FrmPrincipal : Form
    {
        private List<TipoGuia> TipoGuias;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCarregarTipoGuia_Click(object sender, EventArgs e)
        {
            chkTipoGuia.DataSource = TipoGuias;
            chkTipoGuia.DisplayMember = "Descricao";
            chkTipoGuia.ValueMember = "Id";
        }

        private void btnCarregarChecked_Click(object sender, EventArgs e)
        {

            btnCarregarTipoGuia_Click(null, null);

            foreach (var item in TipoGuias)
            {
                var id = item.Id.ToString();

                for (var i = 0; i < chkTipoGuia.Items.Count; i++)
                {
                    TipoGuia vm = (TipoGuia)chkTipoGuia.Items[i];
                    if (vm.Id == item.Id)
                    {
                        if (item.Ativo)
                        {
                            chkTipoGuia.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            TipoGuias = new TipoGuiaRepository().GetTipoGuias();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if(chkTipoGuia.Items.Count > 0)
            {
                TipoGuia tipoGuia;

                foreach (object itemChecked in chkTipoGuia.CheckedItems)
                {
                    tipoGuia = new TipoGuia();
                    tipoGuia = itemChecked as TipoGuia;
                    int valor = tipoGuia.Id;
                    string desc = tipoGuia.Descricao;

                    //aqui poderia enviar o valor para um inclusao ou alteração no repositorio 
                    MessageBox.Show("Esse é o (ID: " + valor + " - Descrição: " + desc + ") do selecionado");
                }
            }
            else
            {
                MessageBox.Show("Carregar primeiro a lista de guias");
            }

            
        }
    }
}
