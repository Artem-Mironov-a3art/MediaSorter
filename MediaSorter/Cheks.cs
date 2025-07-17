/*
 * Copyright 2025 Artem Mironov
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace MediaSorter;

public static class Cheks
{
    //проверка наличия фаила конфигурации
    public static bool ChekJSONConfig()
    {
        // Получаем путь к директории исполняемого файла
        string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
        // Формируем полный путь к файлу config.json
        string configFilePath = Path.Combine(exeDirectory, "config.json");

        // Проверяем существование файла
        return File.Exists(configFilePath);
    }
}

