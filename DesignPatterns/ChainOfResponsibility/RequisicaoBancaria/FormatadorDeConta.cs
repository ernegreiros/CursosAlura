namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class FormatadorDeConta
    {
        public void Formatar(Conta conta, Requisicao requisicao)
        {
            FormatoCSV formatoCsv = new FormatoCSV();
            FormatoPorcento formatoPorcento = new FormatoPorcento();
            FormatoXML formatoXml = new FormatoXML();
            SemFormato semFormato = new SemFormato();

            formatoXml.ProximoFormato = formatoCsv;
            formatoCsv.ProximoFormato = formatoPorcento;
            formatoPorcento.ProximoFormato = semFormato;

            formatoXml.Formatar(conta, requisicao);
        }
        
    }
}
