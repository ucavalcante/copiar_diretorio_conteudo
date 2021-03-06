﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopiarDiretorioEConteudo
{
    class Copiadora
    {
        

        public static string RealizarCopia(string dirFonte, string destino, bool copiarSubdiretorios, bool sobrescrever)
        {
            Log log = new Log();
            //DirectoryCopy("", "",true, true);
            try
            {
                DirectoryCopy(dirFonte, "\\\\" + destino, copiarSubdiretorios, sobrescrever);

                return destino + " Copia Realizada.";
            }
            catch (Exception ex)
            {
                
                //log.GravarLog(ex.Message, GetType().Name.ToString());

                return  "\r\n" + destino + " Falha: " + ex.Message;
            }
            
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool overWriteFiles)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, overWriteFiles);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs, overWriteFiles);
                }
            }
        }

    }
}
