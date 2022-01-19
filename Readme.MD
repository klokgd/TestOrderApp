### Запуск веб-приложения
1. Скопировать репозиторий.
2. Найти файл EFDBcontext в папке DataLayer.
3. Прописать свой путь до базы данных после ```optionsBuilder.UseSqlServer("```.
4. Открыть окно Package Manager Console.
![Местонахождение PMC](https://i.ibb.co/rtv9sFK/index.png)
3. Убедиться, что в Default Project стоит "DataLayer".
4. Прописать команду ```Add-Migration init```. Эта команда инициализирует базу данных. 
5. Там же прописать команду ```Update-Database```. Эта команда создаст необходимые таблицы. 
6. Нажать F5, проект запустится. 
