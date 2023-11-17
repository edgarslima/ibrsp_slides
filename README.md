
# Controle de Slides | IBRSP

Programa para geração slide com letras de músicas em tempo real, gerando imagem em outro monitor e enviando via websocket texto para inclusão de legenda em programa OBS Studio. 




## Instalação

Instalação do servidor WebSocket

#### Dependência servidor
Python versão: 3.10.9 - Testada

```bash
  pip install asyncio 
  pip install websockets
```

Instalação do cliente

### Dependência cliente

```bash
    Microsoft .NET Framework 4.5
    https://www.microsoft.com/pt-br/download/details.aspx?id=30653
```

## TO DO
- [x] Servidor WebSocket em Python
- [x] Cliente simples em C#
- [x] Extração de texto das apresentações PowerPoint (PPTX)
- [ ] Melhorias na aplicação Cliente
  - [x] Correção de erro ao carregar a imagem de fundo, salvando para não precisar selecionar sempre
  - [x] Criar modo off-line para utilização do aplicativo cliente
  - [x] Correção de erro para conseguir simular sem que a comunicação com o servidor esteja ativa
  - [ ] Criação de Pesquisa de Letra de Música em tempo real
  - [ ] Seleção de músicas de forma facilitada para eventos agendados
  - [x] Sugerir formatação e quebra de linha de forma automática
  - [ ] Documentação para utilização do aplicativo
  - [ ] Documentação para instalação do aplicativo
  - [ ] Documentação para alteração, manutenção e evolução do aplicativo


## Autor

- [@edgarslima](https://www.github.com/edgarslima) - Edgar Lima


## Licença

[MIT](https://choosealicense.com/licenses/mit/)

