<p>Task1(FindNextNiggestNumberlib)</p>
<p>Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в другое так, чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются справа налево).</p> <p>Разработать модульные тесты (NUnit и(!) MS Unit Test) для тестирования метода.</p>
<p>Реализовать метод FindNextBiggerNumber, который принимает положительное целое число и возвращает ближайшее наибольшее целое, состоящее из цифр исходного числа, и null (или -1), если такого числа не существует.</p>
<p>Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода. Примерные тест-кейсы</p>
<p>[TestCase(12, ExpectedResult = 21)]</p>
<p>[TestCase(513, ExpectedResult = 531)]</p>
<p>[TestCase(2017, ExpectedResult = 2071)]</p>
<p>[TestCase(414, ExpectedResult = 441)]</p>
<p>[TestCase(144, ExpectedResult = 414)]</p>
<p>[TestCase(1234321, ExpectedResult = 1241233)]</p>
<p>[TestCase(1234126, ExpectedResult = 1234162)]</p>
<p>[TestCase(3456432, ExpectedResult = 3462345)]</p>
<p>[TestCase(10, ExpectedResult = -1)]</p>
<p>[TestCase(20, ExpectedResult = -1)]</p>
<p>Добавить к методу FindNextBiggerNumber возможность вернуть время нахождения заданного числа, рассмотрев различные языковые возможности. Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода.</p>
<p>Task2(InsertNumberLib)</p>
<p>Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в другое так, чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются справа налево). Разработать модульные тесты (NUnit и(!) MS Unit Test) для тестирования метода.</p>
<p>Task3(Newton)</p>
<p>Реализовать алгоритм FindNthRoot, позволяющий вычислять корень n-ой степени ( n∈N ) из вещественного числа а методом Ньютона с заданной точностью. Разработать модульные тесты (NUnit и (или) MS Unit Test) для тестирования метода. Примерные тест кейсы:</p>

<p>[TestCase(1, 5, 0.0001,ExpectedResult =1)]</p>
<p>[TestCase(8, 3, 0.0001,ExpectedResult = 2)]</p>
<p>[TestCase(0.001, 3, 0.0001,ExpectedResult = 0.1)]</p>
<p>[TestCase(0.04100625,4 , 0.0001, ExpectedResult =0.45)]</p>
<p>[TestCase(8, 3, 0.0001, ExpectedResult =2)]</p>
<p>[TestCase(0.0279936, 7, 0.0001, ExpectedResult =0.6)]</p>
<p>[TestCase(0.0081, 4, 0.1, ExpectedResult =0.3)]</p>
<p>[TestCase(-0.008, 3, 0.1, ExpectedResult =-0.2)]</p>
<p>[TestCase(0.004241979, 9, 0.00000001, ExpectedResult =0.545)]</p>
<p>[TestCase(8, 15, -7, -5)] <- ArgumentOutOfRangeException</p>
<p>[TestCase(8, 15, -0.6, -0.1)] <- ArgumentOutOfRangeException</p>
