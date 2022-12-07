# boost-it-test
## Technical test for Boost IT Lisbon

## Features
Construa uma API REST que seja capaz de receber uma requisição em formato JSON contendo uma lista de
números. A resposta deverá informar para cada número se ele é ou não múltiplo de 11. Preferivelmente, a
solução deverá ser publicada em um repositório público do GitHub juntamente com as instruções de execução e
utilização.

A requisição terá o json abaixo para entrada:
```
{
	"numbers": [
		112233,
		30800,
		2937,
		323455693,
		5038297,
		112234
	]
}
```
### OBS: Estou recebendo um array de NUMEROS*
Como resposta, a aplicação irá devolver o json abaixo:
```
{
  "result": [
    {
      "number": 112233,
      "isMultiple": true
    },
    {
      "number": 30800,
      "isMultiple": true
    },
    {
      "number": 2937,
      "isMultiple": true
    },
    {
      "number": 323455693,
      "isMultiple": true
    },
    {
      "number": 5038297,
      "isMultiple": true
    },
    {
      "number": 112234,
      "isMultiple": false
    }
  ]
}
```
## Tech
- [.Net 6.0]
- Arquiteura no padrão DDD
- Unit Test with xUnit

## Execution of Project local

- Clone this repository in your local machine
- Open an terminal windows or power shell
- Navigate unit "..\src\Npf.Process.Selections\Npf.Process.Selections.Api"
- Execute the command "dotnet build" to compile your project locally
```
PS C:\Projects\boost-it-test\src\Npf.Process.Selections\Npf.Process.Selections.Api> dotnet build
Microsoft(R) Build Engine versão 17.2.0+41abc5629 para .NET
Copyright (C) Microsoft Corporation. Todos os direitos reservados.

  Determinando os projetos a serem restaurados...
  Todos os projetos estão atualizados para restauração.
  Npf.Process.Selections.Domain -> C:\Projects\boost-it-test\src\Npf.Process.Selections\Npf.Process.Selections.Domain\bin\Debug\net6.0\Npf.Process.Selectio
  ns.Domain.dll
  Npf.Process.Selections.Application -> C:\Projects\boost-it-test\src\Npf.Process.Selections\Npf.Process.Selections.Application\bin\Debug\net6.0\Npf.Proces
  s.Selections.Application.dll
  Npf.Process.Selections.Api -> C:\Projects\boost-it-test\src\Npf.Process.Selections\Npf.Process.Selections.Api\bin\Debug\net6.0\Npf.Process.Selections.Api
  .dll

Compilação com êxito.
    0 Aviso(s)
    0 Erro(s)

Tempo Decorrido 00:00:03.25
PS C:\Projects\boost-it-test\src\Npf.Process.Selections\Npf.Process.Selections.Api>
```
- Execute the command "dotnet run" to execution your project locally
```
PS C:\Projects\boost-it-test\src\Npf.Process.Selections\Npf.Process.Selections.Api> dotnet run
Compilando...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5032
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Projects\boost-it-test\src\Npf.Process.Selections\Npf.Process.Selections.Api\
```
### See that your project is running on the port pointed above
## Now listening on: http://localhost:5032

- Open your browser and execute the url with "/swagger/index.html", in this example "http://localhost:5032/swagger/index.html"



