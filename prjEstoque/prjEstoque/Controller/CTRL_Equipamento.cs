﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using prjEstoque.Model;

namespace prjEstoque.Controller
{
    class CTRL_Equipamento
    {
        private MODEL_Equipamento modelE;

        public CTRL_Equipamento()
        {
            modelE = new MODEL_Equipamento();
        }

        public List<Equipamento> GetAll()
        {
            return modelE.GetAll();
        }

        public void Insert(Equipamento c)
        {
            modelE.Insert(c);
        }

        public void Update(Equipamento c)
        {
            modelE.Update(c);
        }

        public void Delete(int cod)
        {
            modelE.Delete(cod);
        }
    }
}