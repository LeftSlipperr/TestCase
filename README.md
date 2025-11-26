# Тестовое задание

Для запуска вам понадобятся:

.NET 8 SDK
Docker
PostgreSQL (через Docker, локально ставить не нужно)

1. Запустить PostgreSQL в Docker

Выполните в терминале: docker run --name testcase -p 5440:5432 -e POSTGRES_PASSWORD=testcase -d postgres

2. Проверить, что контейнер запустился: docker ps

3. Применить миграции выполнить в IDE: dotnet ef database update --project Cars.Data --startup-project Cars.API

4. Запустить API выполнить в IDE:dotnet run --project Cars.API либо выбрать как стартовый проект Cars.API и запустить

5. ЗАпустится само API Swagger, где можно все проверить.
