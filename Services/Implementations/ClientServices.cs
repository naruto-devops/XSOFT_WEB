﻿using Models.Models;
using Repositories.Contracts;
using Services.Contracts;
using Services.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ClientServices : IClientService
    {

        IClientRepository _ClientRepository;
        IContactRepository _contactRepository;
        IParametresService _parametresService;
        public ClientServices(IClientRepository client, IParametresService parametres, IContactRepository contact )
      
        {   _ClientRepository = client;
            _parametresService = parametres;
            _contactRepository = contact;
        }

     

        public List<Client> GetAll()
        {
            List<Client> result = new List<Client>();
            result = _ClientRepository.GetAll();
            return result;
        }


        public Client GetById(int id)
        {
            return _ClientRepository.GetById(id);
        }

        public List<Contact> GetcontactByClient(int clientId)
        {
            List<Contact> result = new List<Contact>();
            result = _ClientRepository.GetByClient(clientId);
            return result;
        }

        public Client Add(Client client)
        {
            Client result = new Client();
            Parametres parametres = _parametresService.GetAll();

   
           
            if (!parametres.INCCLI)
            {
                if (!(CheckUnicCodification(client.Numero)))
                {
                    client.Type = 0;
                    _ClientRepository.Add(client);
                    result = client;
                }
                else
                {
                    result = null;
                }

            }
            else 
            {
                

                client.Numero = parametres.NUMCLI;
                while (CheckUnicCodification(client.Numero))
                {
                    client.Numero = client.Numero.IncrementCode();

                }
                client.Type = 0;
                result = _ClientRepository.Add(client);
                parametres.NUMCLI = client.Numero;
                _parametresService.Update(parametres);


            }
            return result;
        }

        public Client Update( Client client)
        {
            _ClientRepository.Update( client);
            return client;
        }

        public bool Delete(int id)
        {
            return _ClientRepository.Delete(id);

        }


        public bool CheckUnicCodification(string numero)
        {
            return _ClientRepository.CheckUnicCodification(numero);
        }

        
        //public bool CheckClient_ExistDocLig( int id)
        //{
        //    var result = _ClientRepository.GetByDocLig(id);
        //    return result != null;
        //}

        //public FamilleTier GetfamTier(int id)
        //{
        //    return _ClientRepository.GetFamilleTier(id);
        //}

    }
}
