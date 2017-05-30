using SAERP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SAERP.AcessaDados
{
    public class A23EstadoInit : CreateDatabaseIfNotExists<A23EstadoContexto>
    {
        protected override void Seed(A23EstadoContexto context)
        {
            List<A22Pais> pais = new List<A22Pais>()
            {
                new A22Pais() {nome="BRASIL", codigo="1058" },
                new A22Pais() {nome="EX", codigo="EX" }
            };

            pais.ForEach(p => context.A22Pais.Add(p));

            List<A23Estado> estado = new List<A23Estado>()
            {
                new A23Estado() {nome="PARANÁ",
                    sigla ="PR",
                    A22Pais = pais.FirstOrDefault(p =>p.nome=="BRASIL")
                },
                new A23Estado() {nome="SÃO PAULO",
                    sigla ="SP",
                    A22Pais = pais.FirstOrDefault(p =>p.nome=="BRASIL")}
            };

            estado.ForEach(e => context.A23Estado.Add(e));

            context.SaveChanges();
        }
    }
}