namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class FormatadorDeConta
    {
        public void Formatar(Conta conta, Requisicao requisicao)
        {
            FormatoPorcento formatoPorcento = new FormatoPorcento(null);
            FormatoCSV formatoCsv = new FormatoCSV(formatoPorcento);
            FormatoXML formatoXml = new FormatoXML(formatoCsv);

            formatoXml.Formatar(conta, requisicao);
        }
        
    }
}
