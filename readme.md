# 🤖 Rui AI - Chat Local com Ollama

Uma aplicação console em C# para interagir com modelos LLM (Large Language Models) localmente usando Ollama e LLama3.

## 🎯 Sobre o Projeto

Este projeto demonstra como criar um chat local com inteligência artificial sem depender de APIs cloud, mantendo privacidade e controle total dos dados. A aplicação se conecta ao Ollama rodando localmente e permite conversas naturais com o modelo LLama3.

## ✨ Características

- 🔒 **100% Local**: Nenhum dado é enviado para servidores externos
- 💬 **Chat Interativo**: Interface console simples e direta
- ⚡ **Resposta Rápida**: Processamento local com LLama3
- 🛡️ **Privacidade Total**: Suas conversas permanecem no seu computador
- 🔧 **Fácil Configuração**: Poucas dependências e setup simples

## 🚀 Começando

### Pré-requisitos

1. **.NET 10 SDK** ou superior
   - [Download .NET](https://dotnet.microsoft.com/download)

2. **Ollama**
   - [Download Ollama](https://ollama.ai)
   - Certifique-se que está rodando na porta padrão 11434

3. **Modelo LLama3**
   ```bash
   ollama pull llama3:latest
   ```

### Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/ruiapmoraes/TesteLocalLlama.git
   cd TesteLocalLlama
   ```

2. Verifique se o Ollama está rodando:
   ```bash
   ollama list
   ```

3. Execute o projeto:
   ```bash
   dotnet run
   ```

## 💻 Uso

1. Inicie a aplicação
2. Digite sua mensagem quando aparecer "Você:"
3. Aguarde a resposta da IA
4. Continue a conversa ou digite `sair` para encerrar

### Exemplo de Uso

```
=== Rui AI - Chat Local com Ollama ===
Digite 'sair' para encerrar.

Você: Olá! Como você funciona?

IA: Olá! Sou uma IA rodando localmente através do Ollama...

Você: sair
Encerrado.
```

## 🛠️ Tecnologias

- **C# 14.0**
- **.NET 10**
- **Ollama API**
- **LLama3 Model**
- **System.Net.Http.Json**
- **System.Text.Json**

## 📁 Estrutura do Projeto

```
TesteLocalLlama/
├── Program.cs              # Código principal da aplicação
├── readme.md               # Este arquivo
├── historico_llama.md      # Histórico detalhado do desenvolvimento
└── TesteLocalLlama.csproj  # Configuração do projeto
```

## ⚙️ Configuração

### Trocar de Modelo

Edite o arquivo `Program.cs` e altere a linha:

```csharp
model = "llama3:latest", // Troque para outro modelo
```

Modelos disponíveis: `ollama list`

### URL do Ollama

Se o Ollama estiver em outro endereço, altere:

```csharp
BaseAddress = new Uri("http://localhost:11434")
```

## 🔍 Solução de Problemas

### Erro de Conexão

- Verifique se o Ollama está rodando: `ollama --version`
- Confirme a porta: deve estar na 11434
- Reinicie o serviço Ollama

### Modelo Não Encontrado

```bash
ollama pull llama3:latest
ollama list  # Confirme que aparece na lista
```

### Resposta Lenta

- LLMs locais dependem do hardware
- Considere usar modelos menores para testes rápidos
- GPU recomendada para melhor performance

## 🚧 Melhorias Futuras

- [ ] Implementar streaming de respostas
- [ ] Adicionar histórico de conversação
- [ ] Suporte a múltiplos modelos
- [ ] Interface gráfica (WPF/Blazor)
- [ ] Salvar conversas em arquivo
- [ ] Parâmetros configuráveis (temperature, top_p)
- [ ] Suporte a system prompts
- [ ] Modo de conversação com contexto

## 📚 Documentação Adicional

- [Histórico Detalhado](historico_llama.md)
- [Ollama API Documentation](https://github.com/ollama/ollama/blob/main/docs/api.md)
- [LLama3 Model Card](https://ollama.ai/library/llama3)

## 🤝 Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para:

1. Fazer fork do projeto
2. Criar uma branch para sua feature (`git checkout -b feature/NovaFuncionalidade`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/NovaFuncionalidade`)
5. Abrir um Pull Request

## 📝 Licença

Este projeto é de código aberto e está disponível para uso pessoal e educacional.

## 👤 Autor

**Rui Moraes**

- GitHub: [@ruiapmoraes](https://github.com/ruiapmoraes)
- Repositório: [TesteLocalLlama](https://github.com/ruiapmoraes/TesteLocalLlama)

## 🙏 Agradecimentos

- [Ollama](https://ollama.ai) por facilitar o uso de LLMs localmente
- Meta AI pelo modelo LLama3
- Comunidade .NET

---

⭐ Se este projeto foi útil, considere dar uma estrela no GitHub!
