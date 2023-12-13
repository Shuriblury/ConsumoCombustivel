using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsumoCombustivel
{
    class Program
    {
        static int ExibirMenu()
        {
            int op = 0;
            Console.Clear();
            Console.WriteLine("Consumo Combustivel");
            Console.WriteLine("\n");
            Console.WriteLine("Escolha seu destino:");
            Console.WriteLine("1-Criar veiculo"); //classe principal 
            Console.WriteLine("2-Abastecer veiculo");
            Console.WriteLine("3-Alterar dados do veiculo"); //alterar e excluir
            Console.WriteLine("4-Buscar dados do veiculo");
            Console.WriteLine("5-Info veiculo"); //rodar e contar aqui
            Console.WriteLine("6-Sair");
            Console.Write("Opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return op;

        }

        
      


        static void CriarVeiculo()
        {


        }

        static void InfoVeiculo(string[] veiculo, string[] portador, int tl)
        {
            Console.WriteLine("Exibir Veiculos\n ");
            for (int i = 0; i < tl; i++)
            {
                Console.WriteLine("Veiculo : {0} \n Portador : {1}\n", veiculo[i], portador[i]);
                
            }
            Console.ReadKey();

        }

        static void InserirVeiculo(ref string[] veiculo, ref string[] portador, ref int tl)
        {

            try
                {

                    Console.WriteLine("\n Inserir Veiculo \n");
                    Console.Write("Veiculo: ");
                    veiculo[tl] = Console.ReadLine();
                int pos = LocalizarVeiculo(veiculo, tl, veiculo[tl]);
                if(pos != -1)
                {
                    tl++;
                }
                else
                {
                    Console.WriteLine("Veiculo ja cadastrado");
                }
                    Console.WriteLine("\n Inserir Portador \n");
                    Console.Write("Portador: ");
                    portador[tl] = Console.ReadLine();
                    Console.Clear();
                    // Console.WriteLine("Veiculo adicionado");
                    tl++;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro:" + e.Message);
                   Console.ReadKey();
                }

            try
            {

                Console.WriteLine("\n Inserir Veiculo 2 \n");
                Console.Write("Veiculo: ");
                veiculo[tl] = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\n Inserir Portador 2\n");
                Console.Write("Portador: ");
                portador[tl] = Console.ReadLine();
                Console.Clear();
                // Console.WriteLine("Veiculo adicionado");
                tl++;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro:" + e.Message);
                Console.ReadKey();
            }

            try
            {

                Console.WriteLine("\n Inserir Veiculo 3 \n");
                Console.Write("Veiculo: ");
                veiculo[tl] = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\n Inserir Portador 3\n");
                Console.Write("Portador: ");
                portador[tl] = Console.ReadLine();
                Console.Clear();
                // Console.WriteLine("Veiculo adicionado");
                tl++;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro:" + e.Message);
                Console.ReadKey();
            }










            //while (tl < 4)
            //{
            //    try
            //    {

            //        Console.WriteLine("\n Inserir Veiculo \n");
            //        Console.Write("Veiculo: ");
            //        veiculo[tl] = Console.ReadLine();
            //        Console.Clear();

            //        Console.WriteLine("\n Inserir Portador \n");
            //        Console.Write("Portador: ");
            //        portador[tl] = Console.ReadLine();
            //        Console.Clear();
            //        // Console.WriteLine("Veiculo adicionado");
            //        tl++;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Erro:" + e.Message);
            //        Console.ReadKey();
            //    }
            //}




        }

        static int LocalizarVeiculo( string[] veiculo,  int tl, string modelo)
        {

            int pos = -1;
            int i = 0;

            while( i < tl && veiculo[i] !=  modelo)
            {

                i++;
            }
            if (i < tl) pos = i;
            return pos;
        }

        // numero de serie e definido automaticamente quando um carro e criado
        //capacidade e selecionada das opçoes 
        //portador e digitado pelo usuario
            static void Main(string[] args)
        {
            //armazena os dados
            string[] veiculo = new string[4];
            string[] portador = new string[4];
            
            
            //tamanho logico e operação
            int tl = 0;
            int op = 0;

            string modelo = "";
            //carregar dados de arquivo texto 
            //dados temporarios
            veiculo[0] = "Gol";
            portador[0] = "Henrique";
            tl++;
            veiculo[tl] = "Civic";
            portador[tl] = "Renata";
            tl++;
            veiculo[tl] = "Cb 500";
            portador[tl] = "Bruno";
            tl++;
            //fim dados temporarios

            while (op != 6)
            {
                op = ExibirMenu();

                switch (op)
                {
                    case 1:
                        //criar veiculo
                        InserirVeiculo(ref veiculo, ref portador, ref tl);
                        break;

                    case 2:
                        //abastecer veiculo
                        break;

                    case 3:
                        //alterar e excluir veiculo
                        break;

                    case 4:
                        //localizar veiculo
                        Console.WriteLine("Localizar Veiculo\n");
                        Console.Write("Modelo: ");
                        modelo = Console.ReadLine();
                        int pos = LocalizarVeiculo(veiculo, tl,modelo);
                        if (pos != -1)
                        {
                            Console.WriteLine("Veiculo : {0} \n Portador : {1}\n", veiculo[pos], portador[pos]);
                            
                        }
                        else
                        {
                            Console.WriteLine("Veiculo não encontrado");
                            
                        }
                        Console.ReadKey();
                        break;
                        

                    case 5:
                        //info veiculo
                        InfoVeiculo(veiculo, portador, tl);
                        break;

                    case 6:
                        //sair
                        break;
                }

            }


            //salvar dados no arquivo de texto





        }
    }

    class ConsumoCombustivel
    {

        public char sn { get; set; }
        public string capacidade { get; set; }
        public string portador { get; set; }




        //Abastecer, rodar, contar


        static public int Abastecer(int n2, int n1 = 0)
        {

            int resultado = n1 + n2;
            return resultado;


        }

        static public void Rodar()
        {
            


        }

        static public void Contar()
        {



        }

        //static public void Combustivel(int n1, int n2) 
      //  {
      //      int quantidadeinicial = 0;
       //     public string
     //   }

       

     



    }

    public class Principal
    {

        string carro1 = "50L";
        string carro2 = "55L";
        string carro3 = "40L";

        


        //criar 3 carros e 3 portadores quaisquer diferentes iniciais 

       

    }
}
