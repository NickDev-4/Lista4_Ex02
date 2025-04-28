Console.Clear();

double kg, altura, resultado;

Console.WriteLine("-- Calculadora de IMC --");

Console.Write("Digite seu peso em Kg: ");
kg = double.Parse(Console.ReadLine());

Console.Write("Digite sua altura em metros: ");
altura = double.Parse(Console.ReadLine());

resultado = kg / (altura * altura);

if (resultado < 17){
    Console.WriteLine("Seu IMC é {0:f2} kg/m².", resultado);
    Console.WriteLine("Diagnóstico: Muito abaixo do peso");
}

else if (resultado > 17 && resultado < 18.49) {
    Console.WriteLine("Seu IMC é {0:f2} kg/m².", resultado);
    Console.WriteLine("Abaixo do peso");
}

else if (resultado > 18.5 && resultado < 24.99) {
    Console.WriteLine("Seu IMC é {0:f2} kg/m².", resultado);
    Console.WriteLine("Peso normal");
}

else if (resultado > 25 && resultado < 29.99) {
    Console.WriteLine("Seu IMC é {0:f2} kg/m².", resultado);
    Console.WriteLine("Acima do peso");
}

else if (resultado > 30 && resultado < 34.99) {
    Console.WriteLine("Seu IMC é {0:f2} kg/m².", resultado);
    Console.WriteLine("Obesidade I");
}

else if (resultado > 35 && resultado < 39.99) {
    Console.WriteLine("Seu IMC é {0:f2} kg/m².", resultado);
    Console.WriteLine("Obesidade II (severa)");
}

else if (resultado > 40) {
    Console.WriteLine("Seu IMC é {0:f2} kg/m².", resultado);
    Console.WriteLine("Obesidade III (mórbida)");
}