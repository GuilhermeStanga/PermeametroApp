using Newtonsoft.Json;
using PermeametroApp.Entidades;
using PermeametroApp.Servicos.Interfaces;
using System;
using System.IO;

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

        public bool Salvar(Configuracao configuracao)
        {
            try
            {
                using (StreamWriter file = File.CreateText(@"./Configuracoes.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, configuracao);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
