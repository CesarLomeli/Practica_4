namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Cargamos el archivo de procesos
            Proceso proceso = new Proceso();
            List<Proceso> procesosLst = new List<Proceso>();
            //Guardamos lista de procesos
            procesosLst = proceso.cargarProcesos("C:\\Users\\cesar\\OneDrive\\Documentos\\School\\Seminario de sistemas operativos\\Practica 4\\procesos.txt");
            foreach (var obj in procesosLst)
            {
                fileBox.Items.Add($"Proceso {obj.nombre}, Tiempo {obj.tiempo}, Prioridad {obj.prioridad}");
            }
            //Creamos objeto fifo
            Fifo fifo = new Fifo();
            var procesosFifo = procesosLst;
            var fifoItems = fifo.ejecutarFifo(procesosFifo);
            foreach (var obj in fifoItems)
            {
                fifoBox.Items.Add($"{obj.nombre} Inicio {obj.inicio} Final {obj.final}");
            }
            //Creamos objeto Sjf
            Sjf sjf = new Sjf();
            var procesosSjf = procesosLst;
            var sjfList = sjf.ejecutarSjf(procesosSjf);
            foreach (var obj in sjfList)
            {
                sjfBox.Items.Add($"{obj.nombre} Tiempo {obj.tiempo} Inicio {obj.inicio} Final {obj.final}");
            }
            //Creamos objeto Prioridad
            Prioridades pri = new Prioridades();
            var procesosList = procesosLst;
            var priList = pri.ejecutarPrioridad(procesosList);
            foreach (var obj in priList)
            {
                prioridadesBox.Items.Add($"{obj.nombre} Prioridad {obj.prioridad} Inicio {obj.inicio} Final {obj.final}");
            }
            //Creamos objeto Round Robin
            var procesosRR = procesosLst;
            foreach (var obj in procesosRR)
            {
                obj.inicio = 0;
                obj.final = 0;
                obj.restante = obj.tiempo;
            }
            int round = 1;
            int quantum = 3;
            int tiempo = 0;
            while (procesosRR.Any(p => p.restante > 0))
            {
                rrBox.Items.Add($"Ronda {round}");
                foreach (var pr in procesosRR.Where(p => p.restante > 0))
                {
                    if(pr.restante > quantum)
                    {
                        pr.inicio = tiempo;
                        pr.restante -= quantum;
                        pr.final += quantum;
                        tiempo += quantum;
                    }
                    else
                    {
                        pr.inicio = tiempo;
                        tiempo += pr.restante;
                        pr.final += tiempo;
                        pr.restante -= pr.restante;
                        
                    }
                    if(pr.restante == 0)
                    {
                        rrBox.Items.Add($"{pr.nombre} Tiempo inicio {pr.inicio} Tiempo final {pr.final}");
                    }
                    else
                    {
                        rrBox.Items.Add($"{pr.nombre} Tiempo inicio {pr.inicio} Tiempo restante {pr.restante}");
                    }
                    
                }
                round++;
            }
        }
    }
}
