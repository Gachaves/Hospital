# Grupo-5-Cl-nica-Hospital
Entregáveis (para cada exercício)
Diagrama UML de Classes

Conteúdo mínimo: classes, atributos principais, métodos (3 por classe), associações entre as classes do contexto.
Código em C#

Implementar as 5 classes do enunciado, com 3 métodos por classe, sem herança.
Um pequeno programa de teste (Program.cs) demonstrando o uso básico do modelo (criar objetos, chamar métodos na ordem lógica do contexto).
O que deve ser entregue: um arquivo zip contendo um PDF do diagrama em uma pasta chamada diagrama e outra pasta chamada solucao, contendo a solucao com todas as classes.
Cada aluno deve se inscrever em um grupo e haverá uma unica entrega para o grupo todo.

Grupo 5 — Clínica/Hospital
Objetivo: Agendar e concluir consultas com receita.
Classes & métodos:

Paciente: AgendarConsulta(Medico, string), ListarConsultas(): List<Consulta>, AtualizarContato(string)
Medico: AgendarAtendimento(Paciente, string), ListarConsultas(): List<Consulta>, EmitirReceita(Consulta, Receita)
Consulta: Marcar(Paciente, Medico, string), Concluir(string), GetResumo(): string
Receita: AdicionarMedicamento(string, string), RemoverMedicamento(string), ListarMedicamentos(): List<string>
Hospital: CadastrarPaciente(Paciente), CadastrarMedico(Medico), ListarConsultasDoDia(string): List<Consulta>
Entregáveis: UML + código + Program.cs com 1 paciente, 1 médico, consulta e receita.

Critérios:
Consulta marcada vincula paciente e médico.
Ao concluir, receita pode ser emitida.

Passos:
Paciente/Medico/Consulta.
Receita/Hospital.
Testes.
Extras: Simples filtragem de data em string.

Integrantes:
Amanda Avelino Camilo Barreto Santos
Gabriel Chaves Pinheiro
Josiane Teixeira de Vasconcelos
