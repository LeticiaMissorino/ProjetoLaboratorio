﻿using ProjetoLaboratorio.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLaboratorio.Models
{
    public class Converte
    {
        public static Laboratorio ToLaboratorio(ModelLaboratorio labModel)
        {
            Laboratorio lab = new Laboratorio();
            lab.id = labModel.Id;
            lab.nome = labModel.Nome;
            lab.projetor = labModel.Projetor;
            lab.qtdeAlunos = labModel.qtdAlunos;
            lab.qtdeComputadores = labModel.qtdComputadores;
            lab.sistemaOperacional = labModel.SistemaOperacional;
            lab.software1 = labModel.Software1;
            lab.software2 = labModel.Software2;
            lab.software3 = labModel.Software3;

            return lab;
        }

        public static ModelLaboratorio ToModelLaboratorio(Laboratorio lab)
        {
            ModelLaboratorio labModel = new ModelLaboratorio();
            labModel.Id = lab.id;
            labModel.Nome = lab.nome;
            labModel.Projetor = Convert.ToBoolean(lab.projetor);
            labModel.qtdAlunos = (int)lab.qtdeAlunos;
            labModel.qtdComputadores = (int)lab.qtdeComputadores;
            labModel.SistemaOperacional = lab.sistemaOperacional;
            labModel.Software1 = lab.software1;
            labModel.Software2 = lab.software2;
            labModel.Software3 = lab.software3;

            return labModel;
        }
    }
}