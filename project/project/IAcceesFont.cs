using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public interface IAcceesFont
    {
      Task<String>  get_path_folder_font_in_document_build();
    }
}
