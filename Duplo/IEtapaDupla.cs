using System.Collections.Generic;
using System.Text;

using AUA12PIPELINE.SIMPLES;
namespace AUA12PIPELINE.duplo;


public interface IEtapaDupla<T> : IEtapa<T>
{
    IEtapaDupla<T> ProximaEtapa {get;set;} 
}