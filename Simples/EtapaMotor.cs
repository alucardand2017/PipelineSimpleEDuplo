using System.Text;
namespace AUA12PIPELINE.SIMPLES;

public class EtapaMotor: IEtapa<StringBuilder>
{
    public StringBuilder Processar(StringBuilder entrada)
    {
        entrada.Append("[MOTOR]");
        return entrada;
    }
}