**Задача**  
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 3 символов.  
**Решение**  
1. Задаем массив из строк разной длинны.  
>string[] array = { "dfjfjw", "-7", "mmm", "dkjfwljf","fdfk" };
2. Метод *FilterArray* принимает в качестве аргумента заданный массив. Затем создает новый пустой массив. В цикле проверяет условие: является ли длинна элемента массива <= 3.  
Если условие выполняется, то добавляет элемент в новый массив, если не выполняется, то переходит к следующему элементу массива.  
После завершения цикла выводит новый массив на экран.
