/* MILTON OCHOA
 * Final Estructura de datos
 * 
 * Enunciado:
 * Un grupo de 10 estudiantes cursan la asignatura Estructura de Datos.
 * Tenga en cuenta que esos estudiantes deben obtener 6 notas parciales para completar el 100% de la nota de la asignatura.
 * 
 * Ingrese los datos correspondientes a las notas de cada estudiante, dentro del rango de 0 a 5, y almacenarlos en una matriz.
 * 
 * Mediante un Switch, defina cuál de las siguientes tareas realizar:
 * 
 * Imprima la matriz con las notas de los estudiantes del grupo.
 * Calcule la nota promedio de cada estudiante.
 * Calcule el número de estudiantes que aprobaron la asignatura.
 * Calcule el número de estudiantes que reprobaron la asignatura.
 * Imprima las calificaciones de cada estudiante por separado
 * 
 */


int fila = 10;
int columna = 6;
int calculo = 0;
int contadorApro = 0;
int contadorRepro = 0;

int[] contadorAproNota = new int[fila];
int[] contadorReproNota = new int[fila];
double[] promedioEst = new double[fila];

double[,] matrizC = new double[fila, columna];

//INGRESO DE DATOS
Console.WriteLine("INGRESO DE DATOS: ");
Console.WriteLine();
for (int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.Write($"Ingrese NOTA {j + 1} del estudiante {i + 1}: ");
        matrizC[i, j] = double.Parse(Console.ReadLine());

        if (matrizC[i, j] < 0 || matrizC[i, j] > 5)
        {
            j--;
            Console.WriteLine("La nota debe estar en el rango de 0 a 5.");
        }
        else
        {
            promedioEst[i] = promedioEst[i] + matrizC[i, j];

            //Console.WriteLine($"Nota acumulada: {promedio[i]}");
            //Console.WriteLine();
        }

    }
    Console.WriteLine();
}

do
{
    Console.WriteLine("\n******\nSWITCH\nELIJA UNA DE LAS SIGUIENTES TAREAS A REALIZAR ESCRIBIENDO EL NÚMERO CORRESPONDIENTE DE 1 a 5: \n\n" +
    "1. Imprimir la matriz con las notas de los estudiantes.\n" +
    "2. Calcular la nota promedio de cada estudiante.\n" +
    "3. Calcular la cantidad de estudiantes que aprobaron la asignatura.\n" +
    "4. Calcular la cantidad de estudiantes que reprobaron la asignatura.\n" +
    "5. Imprimir las calificaciones de cada estudiante por separado.\n");
    calculo = int.Parse(Console.ReadLine());

    switch (calculo)
    {
        case 1:
            Console.WriteLine("\n******\nMATRIZ DE NOTAS: \n");
            {
                for (int i = 0; i < fila; i++)
                {
                    Console.Write($"    * NOTAS estudiante {i + 1}:  ");
                    for (int j = 0; j < columna; j++)
                    {
                        Console.Write($"      {matrizC[i, j]}");
                    }
                    Console.WriteLine("\n");
                }
            }
            break;

        case 2:
            Console.WriteLine("\n******\nNOTA PROMEDIO DE CADA ESTUDIANTE: \n");
            {
                for (int i = 0; i < fila; i++)
                {
                    if ((promedioEst[i] / columna) < 3)
                    {
                        Console.Write($"    * El estudiante {i + 1} obtuvo un promedio de: {(promedioEst[i] / 6)}. REPROBÓ LA ASIGNATURA");
                        contadorRepro = contadorRepro + 1;
                    }
                    else
                    {
                        Console.Write($"    * El estudiante {i + 1} obtuvo un promedio de: {(promedioEst[i] / 6)}. APROBÓ LA ASIGNATURA");
                        contadorApro = contadorApro + 1;
                    }
                    Console.WriteLine();

                }
            }
            break;
        case 3:
            Console.WriteLine("\n******\nCANTIDAD DE APROBADOS: \n");
            {
                Console.WriteLine($"    * Un total de {contadorApro} estudiante(s) aprobaron la asignatura.");

            }
            break;
        case 4:
            Console.WriteLine("\n******\nCANTIDAD DE REPROBADOS: \n");
            {
                Console.WriteLine($"    * Un total de {contadorRepro} estudiante(s) reprobaron la asignatura.");

            }
            break;
        case 5:
            Console.WriteLine("\n******\nCALIFICACIONES POR ESTUDIANTE: \n");
            {
                for (int i = 0; i < fila; i++)
                {
                    Console.WriteLine($"EL ESTUDIANTE {i + 1}:  ");

                    for (int j = 0; j < columna; j++)
                    {

                        if (matrizC[i, j] >= 3)
                        {
                            Console.WriteLine($"    * Obtuvo una nota de {matrizC[i, j]} en la actividad {j + 1} manteniendose arriba de 3.");
                            contadorAproNota[i] = contadorAproNota[i] + 1;
                            //Console.WriteLine($"Acumulador aprobados: {contadorAproMateria[i]}");
                        }
                        else
                        {
                            Console.WriteLine($"    * Obtuvo una nota de {matrizC[i, j]} en la actividad {j + 1} quedando debajo de 3.");
                            contadorReproNota[i] = contadorReproNota[i] + 1;
                            //Console.WriteLine($"Acumulador reprobados: {contadorReproMateria[i]}");
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine($"      Cantidad de notas arriba de 3: {contadorAproNota[i]}");
                    Console.WriteLine($"      Cantidad de notas debajo de 3: {contadorReproNota[i]}");

                    Console.WriteLine("***");
                    Console.WriteLine();
                }
            }
            break;

    }

} while (true);

Console.ReadKey();
