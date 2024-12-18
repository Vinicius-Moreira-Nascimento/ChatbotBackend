# InovaCamp Banco Pine

**Autores:** Vinicius Moreira & Gabriel Cirino

---

## Visão Geral do Projeto

Este repositório apresenta uma aplicação desenvolvida para a competição **InovaCamp Banco Pine**. O projeto utiliza uma **arquitetura hexagonal** que promove alta escalabilidade, testabilidade e manutenção. A aplicação foi construída utilizando tecnologias de ponta como **SQL Server** e **.NET 9**, com foco em oferecer uma solução robusta e flexível para desafios reais do setor financeiro.

---

## Estrutura do Projeto

A estrutura segue os princípios da **arquitetura hexagonal** (ports and adapters):

```plaintext
📦 projeto-raiz
├── 📂 src
│   ├── 📂 Core
│   │   ├── 📂 Domain
│   │   ├── 📂 UseCases
│   │   └── 📂 Interfaces
│   ├── 📂 Adapters
│   │   ├── 📂 WebAPI
│   │   ├── 📂 Database
│   │   └── 📂 ExternalServices
│   └── 📂 Infrastructure
├── 📂 tests
│   ├── 📂 UnitTests
│   └── 📂 IntegrationTests
├── 📂 docs
└── 📄 README.md
```

- **Core**: Contém o domínio central e a lógica de negócios.
  - **Domain**: Entidades e regras fundamentais do negócio.
  - **UseCases**: Casos de uso que orquestram o fluxo da aplicação.
  - **Interfaces**: Definições para comunicação entre camadas.
- **Adapters**: Adapta o núcleo para o mundo externo.
  - **WebAPI**: Implementação de endpoints RESTful.
  - **Database**: Comunicação com o banco de dados SQL Server.
  - **ExternalServices**: Integração com serviços de terceiros.
- **Infrastructure**: Configurações e ferramentas auxiliares.
- **Tests**: Casos de teste unitários e de integração.

---

## Funcionalidades do Backend

1. **Gestão de Usuários:**
   - Criação, leitura, atualização e exclusão de usuários.
   - Controle de autenticação e autorização com JWT.
2. **Integração com Banco de Dados:**
   - Consultas e transações otimizadas utilizando **SQL Server**.
   - Validação e consistência de dados em tempo real.
3. **APIs RESTful:**
   - Endpoints bem documentados utilizando **Swagger/OpenAPI**.
   - Suporte a múltiplos formatos de resposta (JSON, XML).
4. **Suporte à Escalabilidade:**
   - Arquitetura preparada para balanceamento de carga.
   - Pronto para futuras implementações em microsserviços.

---

## Futuras Implementações

- **Hospedagem na Nuvem:**
  - Suporte a provedores como AWS, Azure e Google Cloud.
  - Implementação de pipelines CI/CD para deploy contínuo.
- **Melhorias de Escalabilidade:**
  - Utilização de filas assíncronas para processamento de tarefas.
  - Cache distribuído com Redis para melhorar o desempenho.
- **Novos Módulos Funcionais:**
  - Relatórios gerenciais com dashboards interativos.
  - Integração com APIs de inteligência artificial para análise preditiva.

---

## Tecnologias Utilizadas

- **Backend:**
  - **.NET 9**: Para construção da API e lógica de negócios.
  - **SQL Server**: Gerenciamento de banco de dados relacional.
- **Testes:**
  - xUnit e FluentAssertions para testes unitários e integração.
- **DevOps:**
  - Docker para conteinerização.
  - Configuração de infraestrutura como código com Terraform.

---

## Escalabilidade

A aplicação foi projetada com foco em:

- **Modularidade:**
  - Componentes desacoplados permitem evolução incremental do sistema.
- **Performance:**
  - Uso de estratégias de otimização no banco de dados e na aplicação.
- **Prontidão para o Futuro:**
  - Arquitetura preparada para escalar horizontalmente em ambientes de produção de alto tráfego.

---

Esperamos que este projeto inspire soluções inovadoras e práticas no setor financeiro, alinhando tecnologia e criatividade para enfrentar desafios complexos.

---

### Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

---

**Agradecimentos:** Este projeto foi desenvolvido como parte da competição InovaCamp Banco Pine, e agradecemos à organização pela oportunidade.
