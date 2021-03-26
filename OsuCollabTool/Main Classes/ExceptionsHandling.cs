using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuCollabTool.Main_Classes
{
    class ExceptionsHandling
    {

        public static Exception operationCancelled = new Exception("Operation has been cancelled.");

        public static Exception moreThan2Objects = new Exception("Please make sure there are only 2 files to compare.");

        public static Exception identicalFiles = new Exception("The files you are comparing are identical!");

        public static Exception invalidInput = new Exception("Please fill in appropriate values!");
    }
}

