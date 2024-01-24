using System.Text;
namespace AUA12PIPELINE.duplo;

public class EtapaDuplaPorta: IEtapaDupla<StringBuilder>
{
    public IEtapaDupla<StringBuilder> ProximaEtapa {get;set;} 
    public StringBuilder Processar(StringBuilder entrada)
    {
        entrada.Insert(0,"[PORTA]",2);
        entrada.Insert(entrada.Length, "[PORTA]", 2);
        entrada = ProximaEtapa?.Processar(entrada) ?? entrada;

// Introduzimos maçanetas durante o retorno do pipeline, mostrando que é possível realizar uma etapa não sequencial
        int posPortaEsquerda = entrada.ToString().IndexOf("[PORTA]");
        entrada.Insert(posPortaEsquerda, "[MAÇANETA]", 2);        
        
        int posPortarDireita = entrada.ToString().LastIndexOf("[PORTA]") +7;
        entrada.Insert(posPortarDireita, "[MAÇANETA]", 2);

        return entrada;
    }
}