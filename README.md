# R.O.B.O
Robô Operacional Binariamente Orientado (R.O.B.O) desenvolvido como Prova de Conceito (PoC)


# Problema a ser Resolvido
Foi solicitado que os controles do R.O.B.O. possam ser realizados através de uma Web API RESTful, que interage com um back-end desenvolvido com C# .NET. Deve haver uma interface gráfica a critério do desenvolvedor, onde nela precisamos ser capazes de visualizar os estados atuais do R.O.B.O. e enviar comandos para ele.

# Ferramentas Utilizadas

Sera utilizado C# .NET para o desenvolvimento do código back-end. Sera utilizado o framework ASP.NET Web APi para o desenvolvimento da API RESTful. Sera utilizado o aplicativo Astah UML Editor para o desevenvolimento do diagrama de Modelagem Conceitual. Sera utilizado o aplicativo Github Desktop para o facilitamento da gerencia do projeto. O desenvolvimento será realizado na IDE Visual Studio Code. 



# Cronograma 

- **1o Dia:** Levantamento de Requisitos, metas e engenharia de Software

- **2o Dia:** Back-end, desenvolvimento de funcionalidades (Código C# .NET e inicio da API RESTful)

- **2o Dia:** Finalização da API RESTful, interface, aparencia e ultimos retoques


# Restrições para o Funcionamento 
- Estado inicial dos movimentos é "Em repouso".  

- Só pode movimentar o "Pulso" caso o "Cotovelo" esteja no estado "Fortemente Contraido".

- Só pode "Rotacionar" a "Cabeça" caso sua "Inclinação" da mesma não esteja no estado "Para Baixo".

- Ao realizar a progressão de estados, é necessário que sempre siga a ordem crescente ou decrescente, nunca pulando um estado.

- Levar em consideração estados inválidos.


# Possíveis estados
- **Braço Esquerdo**: 

	- *Cotovelo*:	
	
		1.Em Repouso
		
		2.Levemente Contraído
		
		3.Contraído
		
		4.Fortemente Contraído
		

	- *Pulso*:
		1.Rotação para -90º
		
		2.Rotação para -45º
		
		3.Em Repouso
		
		4.Rotação para 45º
		
		5.Rotação para 90º
		
		6.Rotação para 135º
		
		7.Rotação para 180º
		
- **Braço Direito**: 

	- *Cotovelo*:	
	
		1.Em Repouso
		
		2.Levemente Contraído
		
		3.Contraído
		
		4.Fortemente Contraído

	- *Pulso*:
	
		1.Rotação para -90º
		
		2.Rotação para -45º
		
		3.Em Repouso
		
		4.Rotação para 45º
		
		5.Rotação para 90º
		
		6.Rotação para 135º
		
		7.Rotação para 180º

- **Cabeça**: 

	- *Rotação*:
	
		1.Rotação -90º
		
		2.Rotação -45º
		
		3.Em Repouso
		
		4.Rotação 45º
		
		5.Rotação 90º
		
	- *Inclinação*: 
		
		1.Para Cima
		
		2.Em Repouso
		
		3.Para Baixo


# Diagrama de Classes model
![alt text](https://raw.githubusercontent.com/pedro-ca/R.O.B.O/master/Documentacao/Diagrama%20de%20Classes%20model.JPG?token=AMEQONHDISS2LIF3Q4DCAOC5Z42PG)





