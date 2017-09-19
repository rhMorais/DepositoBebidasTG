﻿namespace Domain
{
    public class BemAlugavel
    {
        public BemAlugavel(int idBem, string descricao, string numPatrimonio, decimal vlaluguel)
        {
            IdBem = idBem;
            Descricao = descricao;
            NumPatrimonio = numPatrimonio;
            VlAluguel = vlaluguel;
        }

        public int IdBem { get; set; }
        public string Descricao{ get; set; }
        public string NumPatrimonio { get; set; }
        public decimal VlAluguel { get; set; }


    }
}
