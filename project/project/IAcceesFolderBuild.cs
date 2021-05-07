using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public interface IAcceesFolderBuild
    {
        Task<String> get_path_folder_build();
    }
}
