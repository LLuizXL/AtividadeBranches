﻿namespace AtividadeBranches.Models
{
    public class Personagens
    {
        public int PersonagemId { get; set; }
        public string Personagem { get; set; }
        public string Descricao { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public string Classe { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }

        public int? Nombre { get; set; }
        public bool EstaVivo { get; set; }

    }
}
