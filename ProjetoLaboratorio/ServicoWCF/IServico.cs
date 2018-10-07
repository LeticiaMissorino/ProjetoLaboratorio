using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServico" in both code and config file together.
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        bool Inserir(Laboratorio sala);

        [OperationContract]
        List<Laboratorio> Listar();

        [OperationContract]
        int Editar(Laboratorio sala);

        [OperationContract]
        int Excluir(int id);

    }
}
