using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace modelling2
{
    public class NelderMead
    {


        public static double[] Optimize(
            Func<double[], double> func,
            double[] initialGuess,
            double tolerance = 1e-6,
            int maxIterations = 10000,
            double alpha = 1,  //Коефіцієнт відбиття
            double beta = 0.5, //КОефіцієнт стискання
            double gamma = 2.0 // Коефіцієнт розширення
            )
        {
           int n = initialGuess.Length; //Розмірність задачі
           double[][] simplex = new double[n + 1][]; //Масив із n+1 масивів (точок)

           simplex[0] = (double[])initialGuess.Clone(); //Перша точка симплексу - базова
            //Інші точки - відповідна координата з початкової точки * 0,1
            for ( int i = 1; i <= n; i++ )
            {
                simplex[i] = (double[])initialGuess.Clone();
                simplex[i][i - 1] += Math.Max(0.1, Math.Abs(initialGuess[i - 1]) * 0.1);
            }

            for(int iteration = 0; iteration < maxIterations; iteration++)
            {
                //Масив значень функції в кожній точці симплекса
                double[] functionValues = simplex.Select(func).ToArray();
                //Сортування вершин симплекса за значенням функції від найкращого до найгіршого
                var sortedIndices = functionValues.Select((value, index) => index)
                                                  .OrderBy(index => functionValues[index]).ToArray();

                double[] best = simplex[sortedIndices[0]];
                double[] worst = simplex[sortedIndices[n]];
                double[] secondWorst = simplex[sortedIndices[n - 1]];
                
                double[] centroid = new double[n]; //Центр ваги симплекса
                //Обчислення центра ваги всіх вершин крім найгіршої
                for(int i = 0; i<n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        centroid[i] += simplex[sortedIndices[j]][i];
                    }
                    centroid[i] /= n;
                }

                //Відбита точка
                double[] reflectedPoint = new double[n];
                for (int i = 0; i < n; i++)
                {
                    reflectedPoint[i] = centroid[i] + alpha * (centroid[i] - worst[i]);
                    //                  Центр ваги  + а     * відстань між найгіршою точкою і центром ваги
                }
                //Значення цільової функції у відбитій точци
                double reflectedValue = func(reflectedPoint);
                //Перевірка на те щоб відбите значення функції було менше за найкраще
                if (reflectedValue < functionValues[sortedIndices[0]])
                {
                    //Істина: симплекс розширяється
                    double[] expandedPoint = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        expandedPoint[i] = centroid[i] + gamma * (reflectedPoint[i] - centroid[i]);
                        //               = Центр ваги  + коефіцієнт розширення * відстань між відбитою точкою і центром ваги
                    }
                    double expandedValue = func(expandedPoint);
                    //Перевірка на те щоб розширене значення функції було менше за найкраще
                    if (expandedValue < functionValues[sortedIndices[0]])
                    {
                        //Істина: найкраще = розширене
                        simplex[sortedIndices[n]] = expandedPoint;
                    }
                    else
                    {
                        //Інакше: найкраще = відбите
                        simplex[sortedIndices[n]] = reflectedPoint;
                    }
                }
                else if (reflectedValue < functionValues[sortedIndices[n - 1]])
                {
                    simplex[sortedIndices[n]] = reflectedPoint;
                }
                else
                {
                    //Інакше: симплекс стискається 

                    //Перевірка на те щоб відбите значення функції було менше за гірше значення
                    if (reflectedValue < functionValues[sortedIndices[n]])
                    {
                        //Істина: симплекс стискається ззовні
                        double[] contractedPoint = new double[n];

                        for(int i = 0; i<n; i++)
                        {
                            contractedPoint[i] = centroid[i] + beta * (reflectedPoint[i] - centroid[i]);
                            //                 = Центр ваги  + коефіцієнт стиснення * відстань між центром ваги і відбитою точкою (в іншу сторону)
                        }
                        simplex[sortedIndices[n]] = contractedPoint;
                    }
                    else
                    {
                        //Інакше: симплекс стискається зсередини
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                simplex[sortedIndices[i]][j] = best[j] + beta * (simplex[sortedIndices[i]][j] - best[j]);
                                //                           = Найкраща точка + коефіцієнт стиснення * дві інші сторони
                            }
                        }
                    }
                }

                double maxDiff = 0;
                for (int i = 1; i <= n; i++)
                {
                    //Максимальна відстань між найкращим значенням функції та іншими значеннями 
                    maxDiff = Math.Max(maxDiff, Math.Abs(functionValues[sortedIndices[0]] - functionValues[sortedIndices[i]]));
                }

                if (maxDiff < tolerance)
                {
                    break;
                }





            }
            //Найкраща точка
            double[] bestPoint = simplex.OrderBy(p => func(p)).First();
            return bestPoint;


            



        }





    }
}
