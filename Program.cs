using System.Text;
using System.Collections.Generic;
using AUA12PIPELINE.SIMPLES;
using AUA12PIPELINE.duplo;


Console.WriteLine("PIPELINE SIMPLES");
var montagemVeiculo = new Pipeline<StringBuilder>();
montagemVeiculo.AdicionaEtapa(new EtapaChassi());
montagemVeiculo.AdicionaEtapa(new EtapaMotor());
montagemVeiculo.AdicionaEtapa(new EtapaBanco());
montagemVeiculo.AdicionaEtapa(new EtapaCarroceria());
montagemVeiculo.AdicionaEtapa(new EtapaPorta());
montagemVeiculo.AdicionaEtapa(new EtapaPintura());

for(int i =0 ; i < 10 ; i++)
{
    var veiculo = montagemVeiculo.Processar(new StringBuilder());
    Console.WriteLine($"Veículo {i + 1:D2}): {veiculo.ToString()}");

}

Console.WriteLine("PIPELINE DUPLA");
var montagemVeiculo2 = new PipelineDuplo<StringBuilder>();
montagemVeiculo2.AdicionaEtapa(new EtapaDuplaChassi());
montagemVeiculo2.AdicionaEtapa(new EtapaDuplaMotor());
montagemVeiculo2.AdicionaEtapa(new EtapaDuplaBanco());
montagemVeiculo2.AdicionaEtapa(new EtapaDuplaCarroceria());
montagemVeiculo2.AdicionaEtapa(new EtapaDuplaPorta());
montagemVeiculo2.AdicionaEtapa(new EtapaDuplaPintura());

for(int i =0 ; i < 10 ; i++)
{
    var veiculo = montagemVeiculo2.Processar(new StringBuilder());
    Console.WriteLine($"Veículo {i + 1:D2}): {veiculo.ToString()}");

}