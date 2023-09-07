using PruebaHerencia;

EmpleadoPorComison empleadocomision = new("Susana", "López", "222-22-222", 0.6M, 10000.00M);

Console.WriteLine("{0}: {1} {2}\n{3}: {4:C}\n",
    "LLama a ToStirng de EmpleadoPorComision con referencia de " + "clase base", "a objeto de clase base",
    empleadocomision.ToString(), "ingresos", empleadocomision.Ingresos());

EmpleadoBaseMasComision2 empleadobase = new("Roberto", "Pérez", "333-33-333", .04M, 5000.00M, 300.00M);

Console.WriteLine("{0}: {1} {2}\n{3}: {4:C}\n",
    "LLama a ToStirng de EmpleadoBaseMasComision con referencia de " + "clase derivada", "a objeto de clase base",
    empleadobase.ToString(), "ingresos", empleadobase.Ingresos());

EmpleadoPorComison empleadoporcomision2 = empleadobase;

Console.WriteLine("{0}: {1} {2}\n{3}: {4:C}\n",
    "LLama a ToStirng de EmpleadoBaseMasComision con referencia de " + "clase derivada", "a objeto de clase base",
    empleadoporcomision2.ToString(), "ingresos", empleadoporcomision2.Ingresos());

empleadobase.VentasBrutas = 4000.00M;
empleadobase.TarifaComision = .1M;
empleadobase.SalarioBase = 10000.00M;

Console.WriteLine("\n{0}:\n\n{1}", "Se actualizó la información del empleadobase por", "ToString", empleadobase);
Console.WriteLine("ingresos: {0:C}", empleadobase.Ingresos());