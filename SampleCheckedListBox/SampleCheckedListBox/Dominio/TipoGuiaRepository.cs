using System.Collections.Generic;

namespace SampleCheckedListBox.Dominio
{
    public class TipoGuiaRepository
    {
        public List<TipoGuia> GetTipoGuias()
        {
            return new List<TipoGuia>
            {
                new TipoGuia { Id=100, Descricao = "SP/SADT", Ativo =false },
                new TipoGuia { Id=200, Descricao = "Internação", Ativo = true},
                new TipoGuia { Id=300, Descricao = "Consulta", Ativo = false},
                new TipoGuia { Id=400, Descricao= "Honorário Individual", Ativo = true},
                new TipoGuia { Id=500, Descricao= "Reembolso", Ativo = true},
                new TipoGuia { Id=600, Descricao= "Odontologia", Ativo = false},
            };
        }
    }
}
