using System;

namespace OsuCollabTool.Main_Classes
{
    internal class ExceptionsHandling
    {
        public static Exception operationCancelled = new Exception("Operation has been cancelled.");

        public static Exception moreThan2Objects = new Exception("Please make sure there are only 2 files to compare.");

        public static Exception identicalFiles = new Exception("The files you are comparing are identical!");

        public static Exception invalidInput = new Exception("Please fill in appropriate values!");

        public static Exception selectedNone = new Exception("Please select at least one or more options!");

        public static Exception patternFileNotSelected = new Exception("Please select a pattern file!");

        public static Exception noFilesFound = new Exception("Please insert at least more than two files!");

        public static Exception dirNull = new Exception("Please make sure to input the directories in Preferences!");

        public static Exception deleteAll = new Exception("You cannot delete all points at once!");
    }
}