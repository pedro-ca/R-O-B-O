using System;
using System.Collections.Generic;

namespace ROBOProject.model
{
    class ROBODictionary    //Dicionarios com nomes do estado baseado no id
    {
        Dictionary<int, string> dictHRotation = new Dictionary<int, string>()       //Nomes para rotação da cabeça
        {
            {1,"Rotação em -90o"},
            {2,"Rotação em -45o"},
            {3,"Em Repouso"},
            {4,"Rotação em 45o"},
            {5,"Rotação em 90o"}
        };
        Dictionary<int, string> dictHInclination = new Dictionary<int, string>()    //Nomes para inclinação da cabeça
        {
            {1,"Para Cima"},
            {2,"Em Repouso"},
            {3,"Para Baixo"}
        };
        Dictionary<int, string> dictElbowState = new Dictionary<int, string>()      //Nomes para contração do cotovelo (Direito e Esquerdo)
        {
            {1,"Em Repouso"},
            {2,"Levemente Contraído"},
            {3,"Fortemente Contraído" }

        };
        Dictionary<int, string> dictWristState = new Dictionary<int, string>()     //Nomes para rotação do pulso (Direito e Esquerdo)
        {
            {1,"Rotação em -90o"},
            {2,"Rotação em -45o"},
            {3,"Em Repouso"},
            {4,"Rotação em 45o"},
            {5,"Rotação em 90o"},
            {6,"Rotação em 135o"},
            {7,"Rotacao em 180o" }
        };
    }
}
