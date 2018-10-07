using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Servico" in both code and config file together.
    public class Servico : IServico
    {
        public bool Inserir(Laboratorio sala)
        {
            return new Dados.Dados().Inserir(sala);
        }

        public List<Laboratorio> Listar()
        {
            return new Dados.Dados().Listar();
        }

        public Laboratorio getById(int id)
        {
            return new Dados.Dados().getById(id);
        }

        public int Editar(Laboratorio sala)
        {
            return new Dados.Dados().editar(sala);
        }

        public int Excluir(int id)
        {
            return new Dados.Dados().excluir(id);
        }
    }
}
