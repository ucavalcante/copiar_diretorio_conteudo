using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CopiarDiretorioEConteudo
{
    class Log
    {

        public void GravarLog(string msg, string local)
        {
            try
            {
                DirectoryInfo diretoriolog = new DirectoryInfo(".\\");
                if (!diretoriolog.Exists)
                {
                    diretoriolog.Create();
                }
                using (StreamWriter sw = File.AppendText(diretoriolog + "\\" + "Log_" + Process.GetCurrentProcess().ProcessName + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt"))
                {
                    sw.WriteLine();
                    sw.WriteLine("-------" + DateTime.Now + "-------");
                    sw.WriteLine("----------" + local + "----------");
                    sw.WriteLine();
                    sw.WriteLine(msg);
                    sw.WriteLine();
                    sw.WriteLine("--------------------------------");
                    sw.WriteLine();
                }
            }
            catch (Exception ex)
            {
                DirectoryInfo diretoriolog = new DirectoryInfo(".\\");
                if (!diretoriolog.Exists)
                {
                    diretoriolog.Create();
                }
                using (StreamWriter sw = new StreamWriter(diretoriolog + "\\" + "LogError_" + Process.GetCurrentProcess().ProcessName + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt"))
                {
                    sw.WriteLine();
                    sw.WriteLine("-------" + DateTime.Now + "-------");
                    sw.WriteLine("----------" + local + "----------");
                    sw.WriteLine();
                    sw.WriteLine(msg);
                    sw.WriteLine();
                    sw.WriteLine("--------------------------------");
                    sw.WriteLine();
                    sw.WriteLine(ex.Message);
                    sw.WriteLine();
                    sw.WriteLine("--------------------------------");
                    sw.WriteLine();
                }
            }
        }
    }
}
