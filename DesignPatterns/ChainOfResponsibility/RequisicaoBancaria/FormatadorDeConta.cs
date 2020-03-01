namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class FormatadorDeConta
    {
        public void Formatar(Conta conta, Requisicao requisicao)
        {
            SemFormato semFormato = new SemFormato();
            FormatoPorcento formatoPorcento = new FormatoPorcento(semFormato);
            FormatoCSV formatoCsv = new FormatoCSV(formatoPorcento);
            FormatoXML formatoXml = new FormatoXML(formatoCsv);

            formatoXml.Formatar(conta, requisicao);
        }
        
    }
}
