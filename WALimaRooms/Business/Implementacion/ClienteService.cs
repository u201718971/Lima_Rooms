﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using Data.Implementacion;

namespace Business.Implementacion
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository clienteRepository = new ClienteRepository();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> FindAll()
        {
            return clienteRepository.FindAll();
        }

        public Cliente FindById(int? id)
        {
            return clienteRepository.FindbyID(id);
        }

        public bool insert(Cliente t)
        {
            return clienteRepository.insert(t);
        }

        public bool Update(Cliente t)
        {
            return clienteRepository.update(t);
        }
    }
}