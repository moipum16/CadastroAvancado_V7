﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Source.Public.Utils.FileCHK
{
    public static class MkFile
    {
        public static void MkFile_0(string folder) 
        {
            using(File.Create(folder)) {}
        }
    }
}
