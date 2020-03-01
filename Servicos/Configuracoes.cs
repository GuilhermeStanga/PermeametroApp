using Newtonsoft.Json;
using PermeametroApp.Entidades;
using PermeametroApp.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PermeametroApp.Servicos
{
    public class Configuracoes : IConfiguracoes
    {
        public Configuracao Carregar()
        {
            Configuracao configuracoes = null;
            try
            {
                using (StreamReader r = new StreamReader(@"./Configuracoes.json"))
                {
                    string json = r.ReadToEnd();
                    configuracoes = JsonConvert.DeserializeObject<Configuracao>(json);
                }
            }
            catch (Exception)
            {
                configuracoes = null;
            }            
            return configuracoes;
        }

        public List<List<HoldingRegisters>> GetHoldingRegisters(Configuracao configuracao)
        {
            return configuracao.holdingRegisters
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Value.idEscravo)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        public string Salvar(Configuracao configuracao)
        {
            try
            {
                using (StreamWriter file = File.CreateText(@"./Configuracoes.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, configuracao);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;
        }
    }
}
