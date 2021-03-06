﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
        
    public class ServicoRecomendacao
    {
        public void Executar()
        {
            // Recurso do Projeto
            var smtp = Smtp.ObterPorConfig();

            // Dependência do Processo
            IServicoWeb servico = new Gmail(smtp);
            var usuario = new Usuario("Denis", "dth");
            var blogMartinFowler = new FonteArtigos("http://martinfowler.com/feed.atom", "articles");
            IArtigos artigos = new Feed(blogMartinFowler);

            // Processo
            var artigo = artigos.ObterArtigo();

            var mensagem = new Mensagem(usuario, artigo);

            servico.Enviar(mensagem);
        }
    }
}
