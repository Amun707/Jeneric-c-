using System.Collections;//подключаем коллекции

namespace Jeneric_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();//список, имеет методы
            list.Add("a");//вызываем метод Lista в данном случае добавить Add
            //со списками можно работать как с обычными массивами
            Stack<string> stack = new Stack<string>();//кто ПЕРВЫМ ЗАШЕЛ ТОТ ПОСЛЕДНИМ ВЫШЕЛ
            Queue<string> queue = new Queue<string>();//ОЧЕРЕДЬ (по порядку)
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();//по определенному ключу можно найти значение
            ArrayList arrayList = new ArrayList();//динамический массив, который хранит в себе все что угодно
            HashSet<string> keys = new HashSet<string>();//хранит уникальные значения

            //методы для списков List
            list.Add("asd");//добавили в конец списка элемент

            list.Remove("asd");//удаляем значение в скобках asd

            list.Contains("asd");//ищет есть ли такой элемент - asd

            list.Clear();//очищает список

            int c = list.Count;//возвращает количество элементов в списке


            //методы для Dictionary
            keyValuePairs.Add(1, "Alice");//добавляет новое значение в словарь 1 - ключ, Alice - значение которое нужно добавить
                                          //ключи всегдя должны быть уникальные

            keyValuePairs.Remove(1);//удаление по ключу

            keyValuePairs.ContainsKey(1);//ищет ключ и возвращает bool значение

            //мсетоды HashSet
            keys.Add("a");//добавили в конец списка элемент
           
            keys.Remove("a");// удаляем значение в скобках a
           
            keys.Contains("a");//ищет есть ли такой элемент - a
            
            keys.Clear();// очищает список
            
            int c4 = keys.Count;//возвращает количество элементов в списке


        

        }
    }
}
