using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCopyFiles
{
    internal class Files
    {
        #region Variables
        static List<Files> files = new List<Files>();
        static List<Files> failed_files = new List<Files> ();
        static string new_location = string.Empty;
        static string current_location = string.Empty;
        string new_directory = string.Empty;
        string current_directory = string.Empty;
        bool is_folder = true;
        bool is_copied;

        #endregion

        #region Constructors
        public Files(string directory, bool isfolder)
        {
            current_directory = directory;
            is_folder = isfolder;
            SetNewDirectory();
            SetIsCopied(false);
        }

        public Files(string directory)
        {
            current_directory = directory;
            is_folder = System.IO.Directory.Exists(directory);
            SetNewDirectory();
            SetIsCopied(false);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the current directory of the file
        /// </summary>
        /// <returns></returns>
        public string GetCurrentDirectory()
        {
            return current_directory;
        }

        /// <summary>
        /// Returns the new directory of the file: the new destination it will be copied to
        /// </summary>
        /// <returns></returns>
        public string GetNewDirectory()
        {
            return new_directory;
        }

        /// <summary>
        /// returns boolean value, True if file is a folder
        /// </summary>
        /// <returns></returns>
        public bool IsFolder()
        {
            return is_folder;
        }

        /// <summary>
        /// sets the new directory of the file
        /// </summary>
        /// <param name="directory"></param>
        private void SetNewDirectory()
        {
            new_directory = GetNewLocation() + GetCurrentDirectory().Substring(GetCurrentLocation().Length);
        }

        /// <summary>
        /// sets the root path of the new directory to save the files to
        /// </summary>
        /// <param name="newdirectory"></param>
        static public void SetNewLocation(string newdirectory)
        {
            new_location = newdirectory;
        }

        /// <summary>
        /// returns the root path to the new directory where the files will be saved to
        /// </summary>
        /// <returns></returns>
        static public string GetNewLocation()
        {
            return new_location;
        }

        /// <summary>
        /// sets the root path of the current directory where the files are stored
        /// </summary>
        /// <param name="newdirectory"></param>
        static public void SetCurrentLocation(string newdirectory)
        {
            current_location = newdirectory;
        }

        /// <summary>
        /// returns the root path to the current directory where the files will be saved to
        /// </summary>
        /// <returns></returns>
        static public string GetCurrentLocation()
        {
            return current_location;
        }

        /// <summary>
        /// adds a file into the static list of files
        /// </summary>
        /// <param name="file"></param>
        static public void AddFile(Files file)
        {
            files.Add(file);
        }

        /// <summary>
        /// removes a specific file
        /// </summary>
        /// <param name="file"></param>
        static public void RemoveFile(Files file)
        {
            try
            {
                files.Remove(file);
            }
            catch
            {
                throw new ArgumentException("File not in list.");
            }
        }

        /// <summary>
        /// adds a failed file into the static list of failed files
        /// </summary>
        /// <param name="file"></param>
        static public void AddFailedFile(Files file)
        {
            failed_files.Add(file);
        }

        /// <summary>
        /// removes a specific failed file
        /// </summary>
        /// <param name="file"></param>
        static public void RemoveFailedFile(Files file)
        {
            if (failed_files.Contains(file))
            {
                failed_files.Remove(file);
            }
        }

        /// <summary>
        /// gets specific file form the list
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public Files GetFile(int number)
        {
            return files[number];
        }

        /// <summary>
        /// returns a list of all files created
        /// </summary>
        /// <returns></returns>
        static public List<Files> GetFiles()
        {
            return files;
        }

        /// <summary>
        /// gets specific failed file form the list
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public Files GetFailedFile(int number)
        {
            return failed_files[number];
        }

        /// <summary>
        /// returns a list of all failed files created
        /// </summary>
        /// <returns></returns>
        static public List<Files> GetFailedFiles()
        {
            return failed_files;
        }

        /// <summary>
        /// returns int value of the number of files saved in the list
        /// </summary>
        /// <returns></returns>
        static public int GetNumberOfFiles()
        {
            return files.Count;
        }

        /// <summary>
        /// returns bool value: returns true if file has been copied successfully
        /// </summary>
        /// <returns></returns>
        public bool IsCopied()
        {
            return is_copied;
        }

        /// <summary>
        /// sets the bool value if the file has been copied or not
        /// </summary>
        /// <param name="status"></param>
        private void SetIsCopied(bool status)
        {
            is_copied = status;
        }

        /// <summary>
        /// attempts to copy the file and sets is_copied to true is copied and false if not
        /// also adds file to list of failed files if failed
        /// </summary>
        public void CopyFile()
        {
            try
            {
                if (is_folder)
                {
                    Directory.CreateDirectory(GetNewDirectory());
                }
                else
                {
                    if (System.IO.File.Exists(GetNewDirectory()))
                    {
                        System.IO.File.Delete(GetNewDirectory());
                    }
                    System.IO.File.Copy(GetCurrentDirectory(), GetNewDirectory());
                }
                RemoveFailedFile(this);
                SetIsCopied(true);
            }
            catch
            {
                AddFailedFile(this);
                SetIsCopied(false);
            }
        }
        #endregion
    }
}
