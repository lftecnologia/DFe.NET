using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Compartilhado.InformacoesIbsCbs
{
    /// <summary>
    ///     UB115a - Grupo de informações da composição do valor do IBS e da CBS para o Simples Nacional (NT 2026.005)
    /// </summary>
    public class gTribSN
    {
        /// <summary>
        ///     UB115b - Grupo do IBS para o Simples Nacional. Ausente quando só a CBS é informada (CRT 2 sem regime regular).
        /// </summary>
        [XmlElement(Order = 1)]
        public gIBSSN gIBSSN { get; set; }

        /// <summary>
        ///     UB115e - Grupo da CBS para o Simples Nacional (obrigatório dentro de gTribSN)
        /// </summary>
        [XmlElement(Order = 2)]
        public gCBSSN gCBSSN { get; set; }
    }

    /// <summary>
    ///     UB115b - Grupo de informações da composição do valor do IBS para o Simples Nacional
    /// </summary>
    public class gIBSSN
    {
        private decimal _pIBSSN;
        private decimal _vIBSSN;

        /// <summary>
        ///     UB115c - Alíquota efetiva do IBS para os optantes do Simples (3v2-4)
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal pIBSSN
        {
            get => _pIBSSN.Arredondar(4);
            set => _pIBSSN = value.Arredondar(4);
        }

        /// <summary>
        ///     UB115d - Valor do IBS para os optantes do Simples Nacional
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal vIBSSN
        {
            get => _vIBSSN.Arredondar(2);
            set => _vIBSSN = value.Arredondar(2);
        }
    }

    /// <summary>
    ///     UB115e - Grupo de informações da composição do valor da CBS para o Simples Nacional
    /// </summary>
    public class gCBSSN
    {
        private decimal _pCBSSN;
        private decimal _vCBSSN;

        /// <summary>
        ///     UB115f - Alíquota efetiva da CBS para os optantes do Simples (3v2-4)
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal pCBSSN
        {
            get => _pCBSSN.Arredondar(4);
            set => _pCBSSN = value.Arredondar(4);
        }

        /// <summary>
        ///     UB115g - Valor da CBS para os optantes do Simples Nacional
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal vCBSSN
        {
            get => _vCBSSN.Arredondar(2);
            set => _vCBSSN = value.Arredondar(2);
        }
    }
}
