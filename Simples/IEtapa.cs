using System.Collections.Generic;
using System.Text;

namespace AUA12PIPELINE.SIMPLES;

public interface IEtapa<T>
{
    T Processar(T entrada);
}