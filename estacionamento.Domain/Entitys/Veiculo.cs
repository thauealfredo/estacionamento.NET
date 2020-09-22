﻿using System;

namespace estacionamento.Domain.Entitys
{
    public class Veiculo
    {
        public int Id { get; set; }

        public int Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Tipo { get; set; }

        public int IdVaga { get; set; }

        public int IdEstabelecimento { get; set; }

        public DateTime HrEntrada { get; set; }

        public DateTime HrSaida { get; set; }
    }
}