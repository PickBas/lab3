using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using lab3.FileWork.Services;

namespace lab3.FileWork.CSV
{
    public class CSVReader<T> : IReader<T>
    {
        public CSVReader()
        {
            
        }

        public List<T> GetStudentData<T>(string filePath, Func<string, int, int, T> del) where T: new()
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ","
            };
            StreamReader reader = new StreamReader(filePath);
            List<T> entities = new List<T>();
            using (var csvReader = new CsvReader(reader, csvConfig))
            {
                csvReader.Read();
                while (csvReader.Read())
                {
                    csvReader.TryGetField<string>(0, out var currentName);
                    csvReader.TryGetField<string>(1, out var currentPopulationStr);
                    csvReader.TryGetField<string>(1, out var currentSquareStr);
                    var currentPopulation = int.Parse(currentPopulationStr);
                    var currentSquare = int.Parse(currentSquareStr);
                    entities.Add((T)Activator.CreateInstance(typeof(T), currentName, currentPopulation, ));
                }
            }
            reader.Close();
            return entities;
        }
    }
}