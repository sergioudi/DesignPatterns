﻿using Strategy;

Console.Title = "";

var order = new Order("Marvin Software", 5, "Visual Studio License");
order.Export(new CSVExportService());
order.Export(new JsonExportService());
order.Export(new XMLExportService());

Console.ReadKey();