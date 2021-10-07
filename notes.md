## Arreglos y Colecciones

| Arreglos | Colecciones |
| --- | ----------- |
| Son mucho mas rapidos en memoria por estar organizados de forma secuencial | Mas faciles de manipular |
| Consumen menos memoria | Multiples variantes y, especializaciones para cada tarea |
| Si utilizas tipos nativos son de lejos mucho mas eficientes | Tamaños flexibles |
| Ideal para trabajar con APIs de bajo nivel | Extensibles, personalizables |

### Tipos de colecciones

| Tipo | Descripcion | Clases |
| --- | --- | --- |
| Simples | Manipulan todo como tipos object | ArrayList, BitArray, Queue, Stack, Sorted |
| Specialized | Implementaciones comunes | StringCollection, BitVector, ListDictionary, NameValueCollection |
| Genericas | Usan generics para crear implementaciones optimizadas de coleccion segun el tipo de dato configurado | Dictionary<T,K>, List<T>, Queue<T>, Stack<T>, HashSet<T>, SortedSet<T> |
| Concurrent | Preparadas para acceso concurrente | ConcurrentBag<T>, ConcurrentStack<T>, ConcurrentQueue<T> |