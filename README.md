# R.O.B.O
Robô Operacional Binariamente Orientado (R.O.B.O) desenvolvido como Prova de Conceito (PoC)

# Problema a ser Resolvido
Foi solicitado que os controles do R.O.B.O. possam ser realizados através de uma Web API RESTful, que interage com um back-end desenvolvido com C# .NET. Deve haver uma interface gráfica a critério do desenvolvedor, onde nela precisamos ser capazes de visualizar os estados atuais do R.O.B.O. e enviar comandos para ele.

# Restrições para o Funcionamento 
-Estado inicial dos movimentos é "Em repouso".
-Só pode movimentar o "Pulso" caso o "Cotovelo" esteja no estado "Fortemente Contraido".
-Só pode "Rotacionar" a "Cabeça" caso sua "Inclinação" da mesma não esteja no estado "Para Baixo".
-Ao realizar a progressão de estados, é necessário que sempre siga a ordem crescente ou decrescente, nunca pulando um estado.
-Levar em consideração estados inválidos.


