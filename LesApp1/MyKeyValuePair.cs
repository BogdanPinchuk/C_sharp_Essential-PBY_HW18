// зроблено аналогічно вже реалізованому

using System.Text;

namespace LesApp2
{
    /// <summary>
    /// Структура для повернення пари ключ-значення зі словника
    /// </summary>
    /// <typeparam name="TKey">Ключ</typeparam>
    /// <typeparam name="TValue">Значення</typeparam>
    struct MyKeyValuePair<TKey, TValue>
    {
        /// <summary>
        /// Ключ
        /// </summary>
        public TKey Key { get; }
        /// <summary>
        /// Значення
        /// </summary>
        public TValue Value { get; }

        /// <summary>
        /// Користувацький конструктор
        /// </summary>
        /// <param name="key">ключ</param>
        /// <param name="value">значення</param>
        public MyKeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Вивід даних словника
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var s = new StringBuilder()
                .Append($"\tkey: {Key}, value: {Value};");

            return s.ToString();
        }
    }
}
