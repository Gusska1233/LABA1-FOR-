//1 Лаба Палехов Виктор БАС-1-2024, 6 вариант
open System

//1 Задание -----------------------------------------------------------------------------------
(*let a z= 
    [
    for i in 1..z do
        printfn "Введите ЧИСЛА для формирования списка c противоп знач: "
        let ch = int(Console.ReadLine())
        yield -ch //<----- Список противоположных значений создан
    ]   


[<EntryPoint>]
let main args = 
    printf "Введите кол-во чисел в списке: "
    let count = int(Console.ReadLine())

    let ListZ = a(count)
    printf "Список: %A" ListZ

    0*)
//-------------------------------------------------------------------------------------------


//2 Задание ------------------------------------------------------------------------------
(*let rec counting z c =
    if z = 0 then
        if c = 0 then 1 //Если введем 0
        else c
    else 
        counting (z / 10) (c + 1)

[<EntryPoint>]
let main args = 
    printf "Введите натуральное число: "
    let x = int(Console.ReadLine())
    
    let res = counting x 0
    printfn "Кол-во цифр в числе: %d" res
    
    0*)

//3 Задание -----------------------------------------------------------------------------------
let creat z= 
    [
    for i in 1..z do
        printfn "Введите ЧИСЛА для формир списка: "
        let ch = int(Console.ReadLine())
        yield ch 
    ]   

let joinz listA listB = 
    listA @ listB

let add listA = 
    printfn "Введите число, которое хотите добавить в список: "
    let c = int(Console.ReadLine())
    c :: listA

let search_el el ListNN =
    if List.contains el ListNN then
        printfn "Этот элемент есть в списке!!!"
    else
        printfn "Этого элемента нет в списке!!!"

let number_el num (ListN: int list) = 
    if num >= 0 && num < ListN.Length then
        printfn "Элемент под номером %d: %d" num ListN.[num]
    else
        printfn "Ошибка: Индекс %d вне диапазона (длина списка: %d)" num ListN.Length

let del_head (listN: int list) =
    if listN.Length = 0 then
        printfn "Список пуст"
        []
    else
        printfn "Удален элемент: %A" listN.[0]
        listN.Tail

[<EntryPoint>]
let main args =
    //1 список
    printf "Введите кол-во чисел в списке: "
    let count = int(Console.ReadLine())

    let List1 = creat(count)
    printfn "Список 1: %A" List1

    //2 список
    printfn "Введите кол-во чисел в списке: "
    let count1 = int(Console.ReadLine())

    let List2 = creat(count1)
    printfn "Список 2: %A" List2

    //Сцепление двух списков
    let list3 = joinz List1 List2
    printfn "Список 3: %A" list3

    //Добавление значение в список
    let List4 = add List1
    printfn "Список1 после добавление знач: %A" List4

    //Нахождение элемента в списке
    printfn "Введите значение для нахождения его в списке3: "
    let elem = int(Console.ReadLine())
    search_el elem list3

    //Получение значения из списка по номеру
    printfn "Введите номер элемента списка3: "
    let index = int(Console.ReadLine())
    number_el index list3

    //Функция для удаления head для списка3
    printfn "Удаление head из списка3!"
    printfn "Список до удаления: %A" list3
    let list3 = del_head list3
    printfn "Результат после удаления: %A" list3

    0