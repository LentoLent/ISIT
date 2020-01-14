using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemSety
{
    class CreatNetWork
    {
        public List<Node> NodeList;
        public CreatNetWork()
        {
            NodeList = new List<Node>();
            Creat();
        }
        public void Creat()
        {
            NodeList.Add(new Node("Видео для просмотра"));//0

            NodeList.Add(new Node("Фильм")); //1
            NodeList.Add(new Node("Хатико")); //2
            NodeList.Add(new Node("93")); //3
            NodeList.Add(new Node("Жанр")); //4
            NodeList.Add(new Node("Драма")); //5
            NodeList.Add(new Node("Варкрафт")); //6
            NodeList.Add(new Node("123")); //7
            NodeList.Add(new Node("Жанр")); //8
            NodeList.Add(new Node("Боевик")); //9

            NodeList.Add(new Node("Сериал")); //10
            NodeList.Add(new Node("Сверхъестественное")); //11
            NodeList.Add(new Node("59")); //12
            NodeList.Add(new Node("Жанр")); //13
            NodeList.Add(new Node("Детектив")); //14
            NodeList.Add(new Node("Ведьмак")); //15
            NodeList.Add(new Node("60")); //16
            NodeList.Add(new Node("Жанр")); //17
            NodeList.Add(new Node("Фэнтази")); //18

            NodeList.Add(new Node("Мультипликация")); //19
            NodeList.Add(new Node("Холодное сердце")); //20
            NodeList.Add(new Node("133")); //21
            NodeList.Add(new Node("Жанр")); //22
            NodeList.Add(new Node("Фэнтази")); //23

            NodeList[0].AddIncomingConnection("Is a", NodeList[1]); NodeList[0].AddIncomingConnection("Is a", NodeList[10]); NodeList[0].AddIncomingConnection("Is a", NodeList[19]);
            // Видео для просмотра
            NodeList[1].AddIncomingConnection("Is a", NodeList[2]); NodeList[1].AddIncomingConnection("Is a", NodeList[6]); NodeList[1].AddOutConnection("Is a", NodeList[0]);
            // Хатико
            NodeList[2].AddIncomingConnection("Объект", NodeList[4]); NodeList[2].AddOutConnection("Is a", NodeList[1]); NodeList[2].AddOutConnection("Продолжительность", NodeList[3]);
            NodeList[3].AddIncomingConnection("Продолжительность", NodeList[2]);
            NodeList[4].AddOutConnection("Объект", NodeList[2]); NodeList[4].AddOutConnection("Значение", NodeList[5]);
            NodeList[5].AddIncomingConnection("Значение", NodeList[4]);
            // Варкрафт
            NodeList[6].AddIncomingConnection("Объект", NodeList[8]); NodeList[6].AddOutConnection("Is a", NodeList[1]); NodeList[6].AddOutConnection("Продолжительность", NodeList[7]);
            NodeList[7].AddIncomingConnection("Продолжительность", NodeList[6]);
            NodeList[8].AddOutConnection("Объект", NodeList[6]); NodeList[8].AddOutConnection("Значение", NodeList[9]);
            NodeList[9].AddIncomingConnection("Значение", NodeList[8]);
            // Сериал
            NodeList[10].AddIncomingConnection("Is a", NodeList[11]); NodeList[10].AddIncomingConnection("Is a", NodeList[15]); NodeList[10].AddOutConnection("Is a", NodeList[0]);
            // Сверхестественное
            NodeList[11].AddIncomingConnection("Объект", NodeList[13]); NodeList[11].AddOutConnection("Is a", NodeList[10]); NodeList[11].AddOutConnection("Продолжительность", NodeList[12]);
            NodeList[12].AddIncomingConnection("Продолжительность", NodeList[11]);
            NodeList[13].AddOutConnection("Объект", NodeList[11]); NodeList[13].AddOutConnection("Значение", NodeList[14]);
            NodeList[14].AddIncomingConnection("Значение", NodeList[13]);
            // Ведьмак
            NodeList[15].AddIncomingConnection("Объект", NodeList[17]); NodeList[15].AddOutConnection("Is a", NodeList[10]); NodeList[15].AddOutConnection("Продолжительность", NodeList[16]);
            NodeList[16].AddIncomingConnection("Продолжительность", NodeList[15]);
            NodeList[17].AddOutConnection("Объект", NodeList[15]); NodeList[17].AddOutConnection("Значение", NodeList[18]);
            NodeList[18].AddIncomingConnection("Значение", NodeList[17]);
            // Мультипликация
            NodeList[19].AddIncomingConnection("Is a", NodeList[20]); NodeList[19].AddOutConnection("Is a", NodeList[0]);
            // Холодное сердце 
            NodeList[20].AddIncomingConnection("Объект", NodeList[22]); NodeList[20].AddOutConnection("Is a", NodeList[19]); NodeList[20].AddOutConnection("Продолжительность", NodeList[21]);
            NodeList[21].AddIncomingConnection("Продолжительность", NodeList[20]);
            NodeList[22].AddOutConnection("Объект", NodeList[20]); NodeList[22].AddOutConnection("Значение", NodeList[23]);
            NodeList[23].AddIncomingConnection("Значение", NodeList[22]);
        }
    }
}
